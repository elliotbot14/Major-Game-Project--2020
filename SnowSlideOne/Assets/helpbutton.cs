using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class helpbutton : MonoBehaviour
{

   public  bool helpopen = false;
    public GameObject Image;
    // Start is called before the first frame update
    void Start()
    {
        helpopen = false;
        Image.GetComponent<Image>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(helpopen == true)
        {
            Image.GetComponent<Image>().enabled = true;
        }
        if (helpopen == false)
        {
            Image.GetComponent<Image>().enabled = false;
        }
    }
    public void HelpButton()
    {
        if (helpopen == true)
        {
            helpopen = false;  
        }
        else
        {
            helpopen = true;
        }

        
       
    }
}
