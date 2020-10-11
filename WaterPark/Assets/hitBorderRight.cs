using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitBorderRight : MonoBehaviour
{
    public bool RightTriggerHit;

    private void Start()
    {
        RightTriggerHit = false;
    }

    private void OnTriggerEnter(Collider Collider)
    {
        RightTriggerHit = true;
        
    }
    private void OnTriggerExit(Collider Collider)
    {
        RightTriggerHit = false;
        
    }

}
