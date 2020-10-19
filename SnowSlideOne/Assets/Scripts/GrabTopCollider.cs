using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabTopCollider : MonoBehaviour
{
    public bool TopBorderGrab;

    public bool HorGrabTop;
    public bool VertGrabTop;

    // Start is called before the first frame update
    void Start()
    {
        TopBorderGrab = false;
        VertGrabTop = false;
        HorGrabTop = false;

    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Border")
        {
            TopBorderGrab = true;
        }
        if (col.gameObject.tag == "HorPlayer")
        {
            HorGrabTop = true;
        }
        if (col.gameObject.tag == "VerPlayer")
        {
            VertGrabTop = true;
        }
    }
    private void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Border")
        {
            TopBorderGrab = false;
        }
        if (col.gameObject.tag == "HorPlayer")
        {
            HorGrabTop = false;
        }
        if (col.gameObject.tag == "VerPlayer")
        {
            VertGrabTop = false;
        }
    }
}

