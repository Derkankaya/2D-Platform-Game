using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapAI : MonoBehaviour
{
    public GameObject[] kolayYapilar;
    public GameObject[] zorYapilar;
    public GameObject[] backgroundDecor;
    

    [SerializeField]
    public GameObject scorePrefab;
    private float takilmaSuresi;
    private Vector3 nesneKonumu;

    public ScoreScripts scoreScripts;


    private void Start()
    {
        takilmaSuresi = OrtalamaTakilmaSuresi();
        InvokeRepeating("OlusturHarita", 0f, 5f);

    }

    public void OlusturHarita()
    {
        takilmaSuresi = YenidenHesaplaTakilmaSuresi();

        GameObject[] seciliYapilar;
        GameObject[] seciliBackground;


        if (takilmaSuresi < 5f)
        {
            seciliYapilar = zorYapilar;
            seciliBackground = backgroundDecor; // Kolay durum için arka plan
        }
        else
        {
            seciliYapilar = kolayYapilar;
            seciliBackground = backgroundDecor; // Zor durum için aynı arka plan, isteğe bağlı olarak değiştirilebilir
        }

        for (int i = 0; i < seciliYapilar.Length; i++)
        {
            Vector3 konum = GetRastgeleKonum();

            // Arka planı ekleyin
            if (i < seciliBackground.Length)
            {
                Instantiate(seciliBackground[i], konum, Quaternion.identity);
            }

            Instantiate(seciliYapilar[i], konum, Quaternion.identity);

            scoreScripts.OlusturulmaZamaniGuncelle();
            
            float scoreTime = scoreScripts.GetOlusturulmaZamani();
        }
    }


    float YenidenHesaplaTakilmaSuresi()
    {
        return Random.Range(0f, 10f);
    }

    float OrtalamaTakilmaSuresi()
    {
        return 5f;
    }

    Vector3 GetRastgeleKonum()
    {
        nesneKonumu.x += 67f;
        nesneKonumu.y = 8f;
        nesneKonumu.z = -0.98f;

        return nesneKonumu;
    }
    
}
