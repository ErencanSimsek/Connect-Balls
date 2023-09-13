using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlMainMenu : MonoBehaviour
{
    [SerializeField]
    GameObject Canvas, wifiControl;
    void Start()
    {
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
            wifiControl.SetActive(true);
            Canvas.SetActive(false);
        }
        else if (Application.internetReachability == NetworkReachability.ReachableViaCarrierDataNetwork || Application.internetReachability == NetworkReachability.ReachableViaLocalAreaNetwork)
        {
            wifiControl.SetActive(false);
            Canvas.SetActive(true);
        }
    }
}
