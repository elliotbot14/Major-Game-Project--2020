using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchBorderRight : MonoBehaviour
{
    public bool RightTriggerHitv;
    public bool HorTriggerRight;

    private void Start()
    {
        RightTriggerHitv = false;
        HorTriggerRight = false;
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Border")
        {
            RightTriggerHitv = true;
        }
        if (col.gameObject.tag == "HorPlayer")
        {
            HorTriggerRight = true;
        }
    }
    private void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Border")
        {
            RightTriggerHitv = false;
        }
        if (col.gameObject.tag == "HorPlayer")
        {
            HorTriggerRight = false;
        }
    }
}
