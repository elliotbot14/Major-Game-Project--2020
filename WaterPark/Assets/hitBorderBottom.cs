using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitBorderBottom : MonoBehaviour
{
    public bool BottomTriggerHit;
    public bool VerTriggerBottom;

    private void Start()
    {
        BottomTriggerHit = false;
        VerTriggerBottom = false;
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
    }
}
