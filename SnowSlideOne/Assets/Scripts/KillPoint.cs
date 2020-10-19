using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPoint : MonoBehaviour
{

    public GameObject Vert;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Vert.GetComponent<EndCheckVert>().VertReachEnd == true)
        {
            Destroy(gameObject);
        }
    }
}
