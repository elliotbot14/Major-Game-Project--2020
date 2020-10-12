using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchBorderLeft : MonoBehaviour
{
    public bool LeftTriggerHitv;
    public bool HorTriggerLeft;

    private void Start()
    {
        LeftTriggerHitv = false;
        HorTriggerLeft = false;
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Border")
        {
           LeftTriggerHitv = true;
        }
        if (col.gameObject.tag == "HorPlayer")
        {
            HorTriggerLeft = true;
        }
    }
    private void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Border")
        {
            LeftTriggerHitv = false;
        }
        if (col.gameObject.tag == "HorPlayer")
        {
            HorTriggerLeft = false;
        }
    }

}
