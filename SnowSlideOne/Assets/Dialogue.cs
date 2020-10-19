using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour
{

    public bool MoveActive = false;

    public Sprite line1;
    public Sprite line2;
    public Sprite line3;

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
        if(nextLine == 1)
        {
            Image.GetComponent<Image>().sprite = line1;
        }
        if (nextLine == 2)
        {
            Image.GetComponent<Image>().sprite = line2;
        }
        if (nextLine == 3)
        {
            Image.GetComponent<Image>().sprite = line3;
            
        }
        if (nextLine == 4)
        {
            Image.GetComponent<Image>().enabled = false;
            MoveActive = true;
        }
    }
}
