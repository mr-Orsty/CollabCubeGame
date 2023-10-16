using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using TMPro;

public class Player : MonoBehaviour
{
    public TMP_Text textName;

    public float speed;
    PhotonView view;

    void Start()
    {
        view = GetComponent<PhotonView>();
        
        textName.text = view.Owner.NickName;
    }

    void Update()
    {
        if (view.IsMine)
        {
            Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
            Vector2 moveAmount = moveInput.normalized * speed * Time.deltaTime;
            transform.position += (Vector3)moveAmount;
        }
    }
}
