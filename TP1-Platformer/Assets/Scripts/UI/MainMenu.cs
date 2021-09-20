using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject levelSelect;

    private void Awake()
    {
        Screen.SetResolution(1920, 1080, false);
        PlayerPrefs.SetInt("levelReached", 1);
    }

    public void PlayGame()
    {
        if (PlayerPrefs.GetInt("levelReached") == 1) {
            SceneManager.LoadScene("Level1");
        } else {
            levelSelect.SetActive(true);
        }
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
