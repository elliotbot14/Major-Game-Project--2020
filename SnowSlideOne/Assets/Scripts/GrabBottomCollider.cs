using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabBottomCollider : MonoBehaviour
{
    public bool BottomBorderGrab;

    public bool HorGrabBottom;
    public bool VertGrabBottom;

    // Start is called before the first frame update
    void Start()
    {
        BottomBorderGrab = false;
        VertGrabBottom = false;
        HorGrabBottom = false;

    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Border")
        {
            BottomBorderGrab = true;
        }
        if (col.gameObject.tag == "HorPlayer")
        {
            HorGrabBottom = true;
        }
        if (col.gameObject.tag == "VerPlayer")
        {
            VertGrabBottom = true;
        }
    }
    private void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Border")
        {
            BottomBorderGrab = false;
        }
        if (col.gameObject.tag == "HorPlayer")
        {
            HorGrabBottom = false;
        }
        if (col.gameObject.tag == "VerPlayer")
        {
            VertGrabBottom = false;
        }
    }
}
