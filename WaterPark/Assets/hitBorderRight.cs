using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitBorderRight : MonoBehaviour
{
    public bool RightTriggerHit;
    public bool VerTriggerRight;

    private void Start()
    {
        RightTriggerHit = false;
        VerTriggerRight = false;
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

    }
    private void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Border")
        {
            RightTriggerHit = true;
        }
        if (col.gameObject.tag == "VerPlayer")
        {
            VerTriggerRight = true;
        }
    }
}
