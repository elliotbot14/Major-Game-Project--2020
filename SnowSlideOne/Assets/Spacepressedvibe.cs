using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spacepressedvibe : MonoBehaviour
{
    public GameObject Grabby;
    public Material Normal;
    public Material NotNormal;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Grabby.GetComponent<PlayerGrab>().SpacePressed == true)
        {
            gameObject.GetComponent<MeshRenderer>().material = NotNormal;
        }
        if (Grabby.GetComponent<PlayerGrab>().SpacePressed == false)
        {
            gameObject.GetComponent<MeshRenderer>().material = Normal;
        }
    }
}
