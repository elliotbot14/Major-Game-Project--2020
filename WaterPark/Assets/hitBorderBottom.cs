using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitBorderBottom : MonoBehaviour
{
    public bool BottomTriggerHit;

    private void Start()
    {
        BottomTriggerHit = false;
    }

    private void OnTriggerEnter(Collider Collider)
    {
        BottomTriggerHit = true;
        
    }
    private void OnTriggerExit(Collider Collider)
    {
        BottomTriggerHit = false;
       
    }

}
