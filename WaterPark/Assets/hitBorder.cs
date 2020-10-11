using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitBorder : MonoBehaviour
{
    public bool LeftTriggerHit;

    private void Start()
    {
        LeftTriggerHit = false;
    }

    private void OnTriggerEnter(Collider Collider)
    {
        LeftTriggerHit = true;
        
    }
    private void OnTriggerExit(Collider Collider)
    {
        LeftTriggerHit = false;
        
    }

}
