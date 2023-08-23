using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuUIController : MonoBehaviour
{
    public Button playButton;
    public Button exitButton;
    public Button creditsButton;

    private void Start()
    {
        playButton.onClick.AddListener(PlayGame);
        exitButton.onClick.AddListener(ExitGame);
        creditsButton.onClick.AddListener(Credits);
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("MuhamadFarhan_PinBall");
    }

    private void ExitGame()
    {
        Application.Quit();

    }
    private void Credits()
    {
        SceneManager.LoadScene("Credits");
    }
}
