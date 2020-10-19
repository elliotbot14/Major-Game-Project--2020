using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndCheckVert : MonoBehaviour
{

    public bool VertReachEnd = false;
    public GameObject SplashPrefab;
    public float delay = 0f;

    private void Start()
    {
        VertReachEnd = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Gate")
        {
            VertReachEnd = true;
            Instantiate(SplashPrefab, new Vector3(0.479f, 1.27f, 1.812f), Quaternion.identity);
            transform.parent.position = new Vector3(0, -15, 0);
        }
    }
}