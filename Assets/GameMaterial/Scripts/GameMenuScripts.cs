using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenuScripts : MonoBehaviour
{
    public bool isPausedGame = false;

    public GameObject pauseMenu;
    public GameObject pausedPanel;

    private void Start()
    {
        pauseMenu.SetActive(false);
        pausedPanel.SetActive(false);
    }


    // Oyunu duraklatma işlemini gerçekleştirir
    public void PauseGame()
    {
        isPausedGame = true;
        pauseMenu.SetActive(true);
        pausedPanel.SetActive(true);


        Time.timeScale = 0f;
        Debug.Log("PauseGame() method is called.");

    }
    public void ResumeGame()
    {
        isPausedGame = false;
        pauseMenu.SetActive(false);
        pausedPanel.SetActive(false);
        Time.timeScale = 1f;

    }

    public void ShowOptions()
    {
        isPausedGame = true;
        pauseMenu.SetActive(false);
        pausedPanel.SetActive(false);
        Time.timeScale = 0f;
    }

    // Oyunu başlatmak için kullanılır

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Time.timeScale = 1f;
    }

    // Oyundan çıkmak için kullanılır
    public void QuitGame()
    {
        Debug.Log("Oyundan Çıkıldı");
        Application.Quit();
    }

    // Ana menüye dönüş yapmak için kullanılır
    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    // Oyun sahnesine dönüş yapmak için kullanılır
    public void ReturnToGame()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;
    }


}
