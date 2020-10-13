using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitBorderTop : MonoBehaviour
{
    public bool TopTriggerHit;
    public bool VerTriggerTop;

    private void Start()
    {
        TopTriggerHit = false;
        VerTriggerTop = false;
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
    }
}