using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;


public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI textMeshProUGUI;
    private int playerScore = 0;
    [SerializeField] int targetScore = 5; // Hedef skor

    public ScoreScripts scoreScripts;

    protected bool levelEnded;


    private void Start()
    {
        textMeshProUGUI.text = playerScore.ToString();
        levelEnded = false;
    }
   
    public void Update()
    {
    if (!levelEnded) // Düzeyin henüz bitmediğinden emin olun
    {
        EndLvl();
    }
    }

    private void EndLvl()
        {
        if (playerScore == targetScore)
        {

        levelEnded = true; // Düzeyin bittiğini işaretleyin, böylece EndLvl artık çağrılmaz
        }
    }
    public void IncreaseScore()
    {
        playerScore++;
        UpdateScoreUI();

        if (playerScore == targetScore)
        {
            // Hedefe ulaşıldığında yapılacak işlemler buraya yazılabilir
        }
    }

    public void UpdateScoreUI()
    {
        textMeshProUGUI.text = playerScore.ToString();

    }



    public int GetPlayerScore()
    {
        return playerScore;
    }

}
