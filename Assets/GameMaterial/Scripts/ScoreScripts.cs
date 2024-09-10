using UnityEngine;
using System.Collections;
using System.Collections.Generic;



public class ScoreScripts : MonoBehaviour
{

    private float olusturulmaZamani;
    private float toplamaZamani;

    public ScoreManager scoreManager;


    private void Start()
    {
        // Ödül nesnesi oluşturulma zamanını başlat
        OlusturulmaZamaniGuncelle();
        scoreManager = FindObjectOfType<ScoreManager>();

    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            ToplamaZamaniGuncelle();
            Destroy(gameObject);
            scoreManager.IncreaseScore();

            
        }
    }


    public float GetOlusturulmaZamani()
    {
        return olusturulmaZamani;
    }

    public void OlusturulmaZamaniGuncelle()
    {
        olusturulmaZamani = Time.time;
    }

    public void ToplamaZamaniGuncelle()
    {
        toplamaZamani = Time.time;
    }

    public float GetToplamaSuresi()
    {
        return toplamaZamani - olusturulmaZamani;
    }


}