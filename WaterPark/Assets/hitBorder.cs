using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitBorder : MonoBehaviour
{
    public bool LeftTriggerHit;
    public bool VerTriggerLeft;

    private void Start()
    {
        LeftTriggerHit = false;
        VerTriggerLeft = false;
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
    }

}
