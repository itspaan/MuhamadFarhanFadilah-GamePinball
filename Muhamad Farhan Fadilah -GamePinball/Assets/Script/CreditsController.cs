using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CreditsController : MonoBehaviour
{
    public Button MenuButton;

    private void Start()
    {
        MenuButton.onClick.AddListener(MainMenu);
    }

    private void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
