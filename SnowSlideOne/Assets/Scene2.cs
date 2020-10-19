using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene2 : MonoBehaviour
{
    public GameObject Hor;
    // Start is called before the first frame update
    void Start()
    {
        Hor.GetComponent<endCheck>().HorReachEnd = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
