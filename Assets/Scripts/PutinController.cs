using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PutinController : MonoBehaviour
{
    public GameObject neutralPutin;
    public GameObject angryPutin1;
    public GameObject angryPutin2;
    public GameObject angryPutin3;
    public GameObject happyPutin1;
    public GameObject happyPutin2;
    public int killed = 0;
    public int failed = 0;
    public int score = 5;
    public int score_k;
    public int score_f;
    void GameOver()
    {
        FindObjectOfType<GameManager>().GameOver();
    }
    void Start()
    {
        Instantiate(neutralPutin, transform.position, transform.rotation);
    }


    void Update()
    {
        if (score == 0)
        {
            Invoke("GameOver", 0.4f);
        }
        killed = GameObject.Find("EnemySpawn").GetComponent<EnemySpawn>().killcount;
        failed = GameObject.Find("EnemySpawn").GetComponent<EnemySpawn>().fledcount;
        if (killed > score_k)
        {
            score_k = score_k + 1;

            if (score < 10)
            {
                score = score + 1;
                GameObject[] putins = GameObject.FindGameObjectsWithTag("Putin");
                foreach (GameObject Putin in putins)
                {
                    if (score < 2)
                    {
                        Destroy(Putin);
                        Instantiate(happyPutin2, transform.position, transform.rotation);
                    }
                    if (score < 4 && score >= 2)
                    {
                        Destroy(Putin);
                        Instantiate(happyPutin1, transform.position, transform.rotation);
                    }
                    if (score < 6 && score >= 4)
                    {
                        Destroy(Putin);
                        Instantiate(neutralPutin, transform.position, transform.rotation);
                    }
                    if (score < 8 && score >= 6)
                    {
                        Destroy(Putin);
                        Instantiate(angryPutin1, transform.position, transform.rotation);
                    }
                    if (score < 10 && score >= 8)
                    {
                        Destroy(Putin);
                        Instantiate(angryPutin2, transform.position, transform.rotation);
                    }
                    if (score == 10)
                    {
                        Destroy(Putin);
                        Instantiate(angryPutin3, transform.position, transform.rotation);
                    }
                }
            }
        }
        if (failed > score_f)
        {
            score_f = score_f + 1;

            {
                if (score > 0)
                {
                    score = score - 1;
                    GameObject[] putins = GameObject.FindGameObjectsWithTag("Putin");
                    foreach (GameObject Putin in putins)
                    {
                        if (score < 2)
                        {
                            Destroy(Putin);
                            Instantiate(happyPutin2, transform.position, transform.rotation);
                        }
                        if (score < 4 && score >= 2)
                        {
                            Destroy(Putin);
                            Instantiate(happyPutin1, transform.position, transform.rotation);
                        }
                        if (score < 6 && score >= 4)
                        {
                            Destroy(Putin);
                            Instantiate(neutralPutin, transform.position, transform.rotation);
                        }
                        if (score < 8 && score >= 6)
                        {
                            Destroy(Putin);
                            Instantiate(angryPutin1, transform.position, transform.rotation);
                        }
                        if (score < 10 && score >= 8)
                        {
                            Destroy(Putin);
                            Instantiate(angryPutin2, transform.position, transform.rotation);
                        }
                        if (score == 10)
                        {
                            Destroy(Putin);
                            Instantiate(angryPutin3, transform.position, transform.rotation);
                        }
                    }
                }

            }

        }
    }

}