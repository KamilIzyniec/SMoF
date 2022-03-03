using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyMovement : MonoBehaviour
{
    float movetype;
    public float speedx = 0.1f;
    public float speedy = 0.1f;
    private int level = 1;
    string levelkey = "level";
    

    void Start()
    {
        try
        {
            level = PlayerPrefs.GetInt(levelkey);
        }
        catch
        {

        }
        if (level <= 14)
        {
            speedx = speedx * (float)level * 0.1f;
            speedy = speedy * (float)level * 0.15f;
        }
        if (level > 14)
        {
            speedx = speedx * 20f * 0.24f + 0.05f * ((float)level - 14f);
            speedy = speedy * 20f * 0.30f + 0.05f * ((float)level - 14f);
        }
        movetype = Random.Range(speedx, speedy);
    }

    void Update()
    {
        
        float movespeed = movetype * 400f * Time.deltaTime;
        transform.position = new Vector3(transform.position.x + movespeed, transform.position.y);
        
    }
}
