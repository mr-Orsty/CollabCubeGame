using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Photon.Pun;
using Photon.Realtime;
using TMPro;


public class MenuManager : MonoBehaviourPunCallbacks
{

    public TMP_InputField inputName;
    public TMP_InputField createInput;
    public TMP_InputField joinInput;

    public bool isPaused;
    public GameObject Panel;

    void Start()
    {
        inputName.text = PlayerPrefs.GetString("name");
        PhotonNetwork.NickName = inputName.text;
    }

    public void PauseGame()
    {
        Panel.SetActive(true);
        isPaused = true;
        Time.timeScale = 0f;
    }

    public void ResumeGame()
    {
        Panel.SetActive(false);
        isPaused = false;
        Time.timeScale = 1f;
    }

    public void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }

    }

    public void CreateRoom()
    {
        RoomOptions roomOptions = new RoomOptions();
        roomOptions.MaxPlayers = 8;
        PhotonNetwork.CreateRoom(createInput.text, roomOptions);
    }

    public void JoinRoom()
    {
        PhotonNetwork.JoinRoom(joinInput.text);
    }

    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("Game");
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void PlayButton()
    {
        SceneManager.LoadScene("Multiplayer");
    }

    public void QuitButton()
    {
        Application.Quit();
    }

    public void SaveName()
    {
        PlayerPrefs.SetString("name", inputName.text);
        PhotonNetwork.NickName = inputName.text;
    }

    public void OptionsButton()
    {
        SceneManager.LoadScene("OptionsMenu");
    }

}
