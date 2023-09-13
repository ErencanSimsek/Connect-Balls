using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    [SerializeField]
    GameObject Canvas, wifiControl, Balls, PlayPause;
    bool balls;
    void Start()
    {
        if (Application.internetReachability == NetworkReachability.NotReachable)
        {
            balls = false;
        }
        else if (Application.internetReachability == NetworkReachability.ReachableViaCarrierDataNetwork || Application.internetReachability == NetworkReachability.ReachableViaLocalAreaNetwork)
        {
            balls = true;
        }
        control();
    }

    void Update()
    {
        control();
    }

    void control()
    {
        if (Application.internetReachability == NetworkReachability.NotReachable)
        {
            if (balls == false)
            {
                wifiControl.SetActive(true);
                Canvas.SetActive(false);
                Balls.SetActive(false);
                PlayPause.SetActive(false);
            }
            balls = true;
        }
        else if(Application.internetReachability == NetworkReachability.ReachableViaCarrierDataNetwork || Application.internetReachability == NetworkReachability.ReachableViaLocalAreaNetwork)
        {
            if(balls == true)
            {
                wifiControl.SetActive(false);
                Canvas.SetActive(true);
                Balls.SetActive(true);
                PlayPause.SetActive(true);
            }
            balls = false;
        }
    }
}
