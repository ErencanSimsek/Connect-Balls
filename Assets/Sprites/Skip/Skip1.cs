using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skip1 : MonoBehaviour
{
    [SerializeField]
    GameObject skip;
    private void Start()
    {
        StartCoroutine(MySkip());
    }
    IEnumerator MySkip()
    {
        yield return new WaitForSeconds(6f);
        skip.SetActive(true);
    }
}
