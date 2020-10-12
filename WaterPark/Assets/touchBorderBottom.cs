using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchBorderBottom : MonoBehaviour
{
    public bool BottomTriggerHitv;
    public bool HorTriggerBottom;

    private void Start()
    {
        BottomTriggerHitv = false;
        HorTriggerBottom = false;
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Border")
        {
            BottomTriggerHitv = true;
        }
        if (col.gameObject.tag == "HorPlayer")
        {
            HorTriggerBottom = true;
        }
    }
    private void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Border")
        {
            BottomTriggerHitv = false;
        }
        if (col.gameObject.tag == "HorPlayer")
        {
            HorTriggerBottom = false;
        }
    }
}