using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndCheckVertScene3 : MonoBehaviour
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
            Instantiate(SplashPrefab, new Vector3(0.426f, 1.333f, -0.053f), Quaternion.identity);
            transform.parent.position = new Vector3(0, -15, 0);
        }
    }
}
