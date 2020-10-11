using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchBorderLeft : MonoBehaviour
{
    public bool LeftTriggerHitv;

    private void Start()
    {
        LeftTriggerHitv = false;
    }

    private void OnTriggerEnter(Collider Collider)
    {
        LeftTriggerHitv = true;

    }
    private void OnTriggerExit(Collider Collider)
    {
        LeftTriggerHitv = false;

    }

}
