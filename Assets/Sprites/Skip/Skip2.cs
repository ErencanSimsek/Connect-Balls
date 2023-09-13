using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skip2 : MonoBehaviour
{
    [SerializeField]
    GameObject skip;
    float a = 0;
    private void Update()
    {
        a += 1;
        if (a >= 200)
        {
            skip.SetActive(true);
        }
       
    }
}
