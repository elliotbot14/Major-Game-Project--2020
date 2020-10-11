using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchBorderBottom : MonoBehaviour
{
    public bool BottomTriggerHitv;

    private void Start()
    {
        BottomTriggerHitv = false;
    }

    private void OnTriggerEnter(Collider Collider)
    {
        BottomTriggerHitv = true;

    }
    private void OnTriggerExit(Collider Collider)
    {
        BottomTriggerHitv = false;

    }

}