using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueScene5 : MonoBehaviour
{

    public bool MoveActive = false;

    
   

    public GameObject Image;

    int nextLine = 1;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            nextLine = nextLine + 1;
        }
       
        if (nextLine == 1)
        {
            Image.GetComponent<Image>().enabled = false;
            MoveActive = true;
        }
    }
}