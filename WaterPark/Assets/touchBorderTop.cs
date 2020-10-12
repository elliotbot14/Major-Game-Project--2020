using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchBorderTop : MonoBehaviour
{
    public bool TopTriggerHitv;
    public bool HorTriggerTop;

    private void Start()
    {
        TopTriggerHitv = false;
        HorTriggerTop = false;
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
    }

}