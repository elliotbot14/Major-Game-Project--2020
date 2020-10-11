using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchBorderTop : MonoBehaviour
{
    public bool TopTriggerHitv;

    private void Start()
    {
        TopTriggerHitv = false;
    }

    private void OnTriggerEnter(Collider Collider)
    {
        TopTriggerHitv = true;
    }
    private void OnTriggerExit(Collider Collider)
    {
        TopTriggerHitv = false;
    }

}