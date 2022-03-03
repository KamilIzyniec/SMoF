using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawn : MonoBehaviour
{
    public GameObject Player1;
    public GameObject Player2;
    public GameObject Player3;
    public Vector3 smokePos;
    public GameObject Smoke;
    private int playernumber = 0;
    string characterkey = "character";

    void Start()
    {
        try
        {
            playernumber = PlayerPrefs.GetInt(characterkey);
        }
        catch
        {

        }
        if (playernumber == 0)
        {
            Instantiate(Player1, transform.position, transform.rotation);
            smokePos.x = 19;
            smokePos.y = -1;
            smokePos.z = 0;
        }
        if (playernumber == 1)
        {
            Instantiate(Player2, transform.position, transform.rotation);
            smokePos.x = 20.5f;
            smokePos.y = 1;
            smokePos.z = 0;
        }
        if (playernumber == 2)
        {
            Instantiate(Player3, transform.position, transform.rotation);
            smokePos.x = 17;
            smokePos.y = 0;
            smokePos.z = 0;
        }
    }

   
    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            GameObject[] smokes = GameObject.FindGameObjectsWithTag("Smoke");
            foreach (GameObject Smoke in smokes)
            {
                Destroy(Smoke);
            }

            Instantiate(Smoke, smokePos, transform.rotation);
            



        }

    }
}
