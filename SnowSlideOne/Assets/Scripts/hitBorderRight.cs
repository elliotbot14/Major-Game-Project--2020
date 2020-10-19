using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitBorderRight : MonoBehaviour
{
    public bool RightTriggerHit;
    public bool VerTriggerRight;
    public bool GrabTriggerRight;

    private void Start()
    {
        RightTriggerHit = false;
        VerTriggerRight = false;
        GrabTriggerRight = false;
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Border")
        {
            RightTriggerHit = true;
        }
        if (col.gameObject.tag == "VerPlayer")
        {
            VerTriggerRight = true;
        }
        if (col.gameObject.tag == "GrabPlayer")
        {
            GrabTriggerRight = true;
        }

    }
    private void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Border")
        {
            RightTriggerHit = false;
        }
        if (col.gameObject.tag == "VerPlayer")
        {
            VerTriggerRight = false;
        }
        if (col.gameObject.tag == "GrabPlayer")
        {
            GrabTriggerRight = false;
        }
    }
}
