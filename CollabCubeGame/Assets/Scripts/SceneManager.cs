using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour
{

    public void PlayButton()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Multiplayer");
    }

    public void OptionsButton()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("OptionsMenu");
    }

    public void AcessoriesButton()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("AccessoriesScene");
    }

    public void QuitButton()
    {
        Application.Quit();
    }

    public void BackToMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Menu");
    }

}
