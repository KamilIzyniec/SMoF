using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideButtonFromRight : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        LeanTween.moveLocalX(gameObject, 351f, 2f);
    }


}
