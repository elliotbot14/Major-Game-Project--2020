using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabLeftCollider : MonoBehaviour
{

    public bool LeftBorderGrab;

    public bool VertGrabLeft;
    public bool HorGrabLeft;

    // Start is called before the first frame update
    void Start()
    {
        LeftBorderGrab = false;
        VertGrabLeft = false;
        HorGrabLeft = false;

    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Border")
        {
            LeftBorderGrab = true;
        }
        if (col.gameObject.tag == "HorPlayer")
        {
            HorGrabLeft = true;
        }
        if (col.gameObject.tag == "VerPlayer")
        {
            VertGrabLeft = true;
        }
    }
    private void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Border")
        {
            LeftBorderGrab = false;
        }
        if (col.gameObject.tag == "HorPlayer")
        {
            HorGrabLeft = false;
        }
        if (col.gameObject.tag == "VerPlayer")
        {
            VertGrabLeft = false;
        }
    }
}
