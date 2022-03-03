using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountdownAnimation : MonoBehaviour
{
    public GameObject LevelNumber;
    public GameObject Number3;
    public GameObject Number2;
    public GameObject Number1;
    public GameObject Go;

    float countDown3 = 1f;
    float countDown2 = 2f;
    float countDown1 = 3f;
    float countDownGo = 4f;
    void Start()
    {
        Instantiate(LevelNumber, transform.position, transform.rotation);

    }

    
    
    void Update()
    {
        countDown3 -= Time.deltaTime;
        countDown2 -= Time.deltaTime;
        countDown1 -= Time.deltaTime;
        countDownGo -= Time.deltaTime;

        if (countDown3 < 0 && countDown3 > -10)
        {
            Instantiate(Number3, transform.position, transform.rotation);
            countDown3 = -11;
        }
        if (countDown2 < 0 && countDown2 > -10)
        {
            Instantiate(Number2, transform.position, transform.rotation);
            countDown2 = -11;
        }
        if (countDown1 < 0 && countDown1 > -10)
        {
            Instantiate(Number1, transform.position, transform.rotation);
            countDown1 = -11;
        }
        if (countDownGo < 0 && countDownGo > -10)
        {
            Instantiate(Go, transform.position, transform.rotation);
            countDownGo = -11;
        }
    }
}
