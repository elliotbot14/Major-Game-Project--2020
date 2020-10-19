using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchBorderTop : MonoBehaviour
{
    public bool TopTriggerHitv;
    public bool HorTriggerTop;
    public bool GrabTriggerTop;

    private void Start()
    {
        TopTriggerHitv = false;
        HorTriggerTop = false;
        GrabTriggerTop = false;
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Border") { 
            TopTriggerHitv = true;
        }
        if (col.gameObject.tag == "HorPlayer")
        {
            HorTriggerTop = true;
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
            TopTriggerHitv = false;
        }
        if (col.gameObject.tag == "HorPlayer")
        {
            HorTriggerTop = false;
        }
        if (col.gameObject.tag == "GrabPlayer")
        {
            GrabTriggerTop = false;
        }
    }

}