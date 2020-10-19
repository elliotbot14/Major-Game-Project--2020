using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endcheckgrab : MonoBehaviour
{
    public bool GrabReachEnd = false;
    public GameObject SplashPrefab;
    public float delay = 0f;
    public GameObject vert;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(GrabReachEnd == true)
        {
            vert.GetComponent<EndCheckVertScene4>().VertReachEnd = true;
            transform.parent.position = new Vector3(0, -15, 0);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Gate")
        {
            GrabReachEnd = true;
            Instantiate(SplashPrefab, new Vector3(0.534f,0.93f,1.61f), Quaternion.identity);
        }
    }
}
