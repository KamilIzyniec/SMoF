using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalsDisapear : MonoBehaviour
{
    float countdown = 4f;
    void Update()
    {
        countdown -= Time.deltaTime;
        if (countdown < 0)
        {
            LeanTween.scale(gameObject, new Vector3(0, 0, 0), 1f);
        }
    }
}
