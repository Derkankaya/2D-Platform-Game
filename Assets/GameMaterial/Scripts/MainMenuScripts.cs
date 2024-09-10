using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScripts : MonoBehaviour
{
 

    public bool isPausedGame = false;

    public GameObject mainMenu;
    public GameObject mainMenuPanel;


    public AudioSource theme;

    private void Start()
    {   

        mainMenu.SetActive(true);
        mainMenuPanel.SetActive(true);
      
        
    }


    // Oyunu duraklatma işlemini gerçekleştirir



    public void ShowOptions()
    {
        isPausedGame = true;
        mainMenu.SetActive(false);
        mainMenuPanel.SetActive(false);
       

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

    // Ses ayarlarını yapmak için kullanılır


}
