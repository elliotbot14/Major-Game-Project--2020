using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndCheckScene3 : MonoBehaviour
{

    public bool HorReachEnd = false;
    public GameObject SplashPrefab;
    public float delay = 0f;

    private void Start()
    {
        HorReachEnd = false;

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Gate")
        {
            HorReachEnd = true;
            Instantiate(SplashPrefab, new Vector3(0.426f, 1.333f, -0.053f), Quaternion.identity);
            transform.parent.position = new Vector3(0, -15, 0);
            //rotation x = 22.026f
        }
    }

}
