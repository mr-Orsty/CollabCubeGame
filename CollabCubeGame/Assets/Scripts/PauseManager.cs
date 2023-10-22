using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PauseManager : MonoBehaviour
{

    public bool isPaused;
    public GameObject pausePanel;
    public GameObject optionsPanel;
    public TMP_Text fpsText;

    public void PauseGame()
    {
        pausePanel.SetActive(true);
        isPaused = true;
        Time.timeScale = 0f;
    }

    public void ResumeGame()
    {
        pausePanel.SetActive(false);
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

    public void OptionsInGame()
    {

        optionsPanel.SetActive(true);

    }

    public void CloseOptionsInGame()
    {

        optionsPanel.SetActive(false);

    }

    public void LeaveRoom()
    {
        PhotonNetwork.LeaveRoom();
    }

    public void OnLeftRoom()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Menu");
    }

}
