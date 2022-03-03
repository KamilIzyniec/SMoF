using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class EnemySpawn : MonoBehaviour
{

    public TextMeshProUGUI killcounter;
    private float countDown = 4f;
    public int fledcount;
    public int killcount;
    public GameObject Enemy;
    public GameObject Boom;
    public Vector3 touchPos;
    int level = 1;
    public float cntdwnx;
    public float cntdwny;
    string levelkey = "level";
    void spawnenemy()
    {
        Instantiate(Enemy, transform.position, transform.rotation);
        
    }
    void gettouchpos()
    {
        touchPos = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
        touchPos.z = 0;
    }
    
    
        
    
    void Start()
    {   try
        {
            level = PlayerPrefs.GetInt(levelkey);
        }
        catch
        {
           
        }
        killcounter.text = "0";
        if (level <= 5)
        {
            cntdwnx = 1f;
            cntdwny = 3f;

        }
        if (level > 5 && level < 10)
        {
            cntdwnx = 0.8f;
            cntdwny = 2.5f;

        }
        if (level >= 10 && level < 15)
        {
            cntdwnx = 0.7f;
            cntdwny = 2f;
        }
        if (level >= 15 && level < 20)
        {
            cntdwnx = 0.5f;
            cntdwny = 1.75f;
        }
        if (level >= 20)
        {
            cntdwnx = 0.4f;
            cntdwny = 1.25f;
        }
    }


    void Update()
    {
        killcounter.text = killcount.ToString();
        touchPos.y = 40;
        countDown -= Time.deltaTime;
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            gettouchpos();
        }

        if (countDown < 0f)
        {
            spawnenemy();
            countDown = Random.Range(cntdwnx, cntdwny);
        
            
        }

        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject Enemy in enemies)
        {
            if (Enemy.transform.position.x >= 40f)
            {
                Destroy(Enemy);
                fledcount = fledcount + 1;
            }
            if ((touchPos.y - Enemy.transform.position.y) > -2.5f && 2.5f > (touchPos.y - Enemy.transform.position.y) && (touchPos.x - Enemy.transform.position.x) > -4.5f && 4.5f > (touchPos.x - Enemy.transform.position.x))
            {
                
                Destroy(Enemy);
                killcount = killcount + 1;
                Instantiate(Boom, touchPos, transform.rotation);
                touchPos.x = 45f;
                
            }
        }
        
    }
}