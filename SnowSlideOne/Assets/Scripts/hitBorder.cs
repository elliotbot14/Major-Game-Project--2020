using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitBorder : MonoBehaviour
{
    public bool LeftTriggerHit;
    public bool VerTriggerLeft;
    public bool GrabTriggerLeft;

    private void Start()
    {
        LeftTriggerHit = false;
        VerTriggerLeft = false;
        GrabTriggerLeft = false;
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Border")
        {
            LeftTriggerHit = true;
        }
        if (col.gameObject.tag == "VerPlayer")
        {
            VerTriggerLeft = true;
        }
        if (col.gameObject.tag == "GrabPlayer")
        {
            GrabTriggerLeft = true;
        }

    }
    private void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Border")
        {
            LeftTriggerHit = false;
        }
        if (col.gameObject.tag == "VerPlayer")
        {
            VerTriggerLeft = false;
        }
        if (col.gameObject.tag == "GrabPlayer")
        {
            GrabTriggerLeft = false;
        }
    }

}
