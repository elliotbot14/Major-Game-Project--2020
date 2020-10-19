using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitBorderTop : MonoBehaviour
{
    public bool TopTriggerHit;
    public bool VerTriggerTop;
    public bool GrabTriggerTop;

    private void Start()
    {
        TopTriggerHit = false;
        VerTriggerTop = false;
        GrabTriggerTop = false;
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Border")
        {
            TopTriggerHit = true;
        }
        if (col.gameObject.tag == "VerPlayer")
        {
            VerTriggerTop = true;
        }
        if (col.gameObject.tag == "GrabPlayer")
        {
            GrabTriggerTop = true;
        }
    }
    private void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Border")
        {
            TopTriggerHit = false;
        }
        if (col.gameObject.tag == "VerPlayer")
        {
            VerTriggerTop = false;
        }
        if (col.gameObject.tag == "GrabPlayer")
        {
            GrabTriggerTop = false;
        }
    }
}