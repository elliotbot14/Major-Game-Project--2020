using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitBorderTop : MonoBehaviour
{
    public bool TopTriggerHit;

    private void Start()
    {
        TopTriggerHit = false;
    }

    private void OnTriggerEnter(Collider Collider)
    {
        TopTriggerHit = true;        
    }
    private void OnTriggerExit(Collider Collider)
    {
        TopTriggerHit = false;
    }

}