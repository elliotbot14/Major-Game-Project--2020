using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchBorderRight : MonoBehaviour
{
    public bool RightTriggerHitv;

    private void Start()
    {
        RightTriggerHitv = false;
    }

    private void OnTriggerEnter(Collider Collider)
    {
        RightTriggerHitv = true;

    }
    private void OnTriggerExit(Collider Collider)
    {
        RightTriggerHitv = false;

    }

}
