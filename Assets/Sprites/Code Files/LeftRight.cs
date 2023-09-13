using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftRight : MonoBehaviour
{
    Vector3 posA, posB, nexPos;
    float speed = 2f;
    [SerializeField]
    Transform transformA, transformB;

    private void Start()
    {
        posA = transformA.localPosition;
        posB = transformB.localPosition;
        nexPos = posB;
    }

    private void Update()
    {
        if (Move.leftRight==true)
        {
            Movee();
        }
    }

    void Movee()
    {
        transformA.localPosition = Vector3.MoveTowards(transformA.localPosition, nexPos, speed * Time.deltaTime);

        if (Vector3.Distance(transformA.localPosition, nexPos) <= 0.1)
        {
            ChangeDestination();
        }
    }

    void ChangeDestination()
    {
        nexPos = nexPos != posA ? posA : posB;
    }
}
