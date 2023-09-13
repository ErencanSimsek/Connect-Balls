using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotation : MonoBehaviour
{
    private void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if(touch.phase == TouchPhase.Moved)
            {
                if(Move.leftRight == true)
                {
                    if (touch.deltaPosition.y > 0f)
                    {
                        transform.Rotate(0, 0, 2f);
                    }
                    if (touch.deltaPosition.y < 0f)
                    {
                        transform.Rotate(0, 0, -2f);
                    }
                }
                else if(Move.leftRight == false)
                {
                    if (touch.deltaPosition.y > 0f)
                    {
                        transform.Rotate(0, 0, 0f);
                    }
                    if (touch.deltaPosition.y < 0f)
                    {
                        transform.Rotate(0, 0, 0f);
                    }
                }
            }
        }
    }
}
