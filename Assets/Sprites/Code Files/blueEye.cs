using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blueEye : MonoBehaviour
{
    float speed = 100f, amount = 0.2f;
    Transform Object, back;

    private void Start()
    {
        Object = GameObject.FindGameObjectWithTag("Red").transform;
    }

    private void Update()
    {
        Vector3 character = Object.position;
        Vector2 offset = new Vector2(character.x - transform.position.x, character.y - transform.position.y);
        Vector3 dir = transform.TransformDirection(offset).normalized;
        transform.localPosition = Vector3.Lerp(transform.localPosition, dir * amount, speed * Time.deltaTime);
    }
}