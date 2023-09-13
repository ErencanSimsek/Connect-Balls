using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blueAnimation : MonoBehaviour
{
    [SerializeField]
    GameObject Heart;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Red"))
        {
            Instantiate(Heart, new Vector3(gameObject.transform.position.x - 0.2f, gameObject.transform.position.y + 1.4f), Quaternion.identity, transform);
        }
    }
}
