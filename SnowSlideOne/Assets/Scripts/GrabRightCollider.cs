using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabRightCollider : MonoBehaviour
{
    public bool RightBorderGrab;

    public bool VertGrabRight;
    public bool HorGrabRight;

    // Start is called before the first frame update
    void Start()
    {
        RightBorderGrab = false;
        VertGrabRight = false;
        HorGrabRight = false;

    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Border")
        {
            RightBorderGrab = true;
        }
        if (col.gameObject.tag == "HorPlayer")
        {
            HorGrabRight = true;
        }
        if (col.gameObject.tag == "VerPlayer")
        {
            VertGrabRight = true;
        }
    }
    private void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Border")
        {
            RightBorderGrab = false;
        }
        if (col.gameObject.tag == "HorPlayer")
        {
            HorGrabRight = false;
        }
        if (col.gameObject.tag == "VerPlayer")
        {
            VertGrabRight = false;
        }
    }
}
