using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DialogueScene2 : MonoBehaviour
{

    public bool MoveActive = false;

    public Sprite line1;
    public Sprite line2;
    public Sprite line3;
    public Sprite line4;

    public GameObject Image;

    int nextLine = 1;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex == 4 || SceneManager.GetActiveScene().buildIndex == 3 || SceneManager.GetActiveScene().buildIndex == 2)
        {

            if (Input.anyKeyDown)
            {
                nextLine = nextLine + 1;
            }
            if (nextLine == 1)
            {
                Image.GetComponent<Image>().sprite = line1;
            }
            if (nextLine == 2)
            {
                Image.GetComponent<Image>().sprite = line2;
            }
            if (nextLine == 3)
            {
                Image.GetComponent<Image>().enabled = false;
                MoveActive = true;
            }
        }
        if (SceneManager.GetActiveScene().buildIndex == 5 || SceneManager.GetActiveScene().buildIndex == 6 || SceneManager.GetActiveScene().buildIndex == 7 || SceneManager.GetActiveScene().buildIndex == 8 || SceneManager.GetActiveScene().buildIndex == 9)
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
        if(SceneManager.GetActiveScene().buildIndex == 10)
        {
            if (Input.anyKeyDown)
            {
                nextLine = nextLine + 1;
            }
            if (nextLine == 1)
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
                Image.GetComponent<Image>().sprite = line4;
            }
            if (nextLine == 5)
            {
                Image.GetComponent<Image>().enabled = false;
                MoveActive = true;
            }
        }
    }
}
