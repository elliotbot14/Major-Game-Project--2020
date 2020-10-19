using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitBorderBottom : MonoBehaviour
{
    public bool BottomTriggerHit;
    public bool VerTriggerBottom;
    public bool GrabTriggerBottom;

    private void Start()
    {
        BottomTriggerHit = false;
        VerTriggerBottom = false;
        GrabTriggerBottom = false;
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Border")
        {
            BottomTriggerHit = true;
        }
        if(col.gameObject.tag == "VerPlayer")
        {
            VerTriggerBottom = true;
        }
        if (col.gameObject.tag == "GrabPlayer")
        {
            GrabTriggerBottom = true;
        }

    }
    private void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Border")
        {
            BottomTriggerHit = false;
        }
        if (col.gameObject.tag == "VerPlayer")
        {
            VerTriggerBottom = false;
        }
        if (col.gameObject.tag == "GrabPlayer")
        {
            GrabTriggerBottom = false;
        }
    }
}
