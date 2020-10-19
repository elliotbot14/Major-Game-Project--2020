using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndCheckVertScene4 : MonoBehaviour
{

    public bool VertReachEnd = false;
    public GameObject SplashPrefab;
    public float delay = 0f;

    private void Start()
    {
        VertReachEnd = false;
    }
    private void Update()
    {
        if(VertReachEnd == true)
        {
            transform.parent.position = new Vector3(0, -15, 0);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Gate")
        {
            VertReachEnd = true;
            if (SceneManager.GetActiveScene().buildIndex == 4)
            {
                Instantiate(SplashPrefab, new Vector3(2.387f, 1.1f, -0.408f), Quaternion.identity);
            }
            if (SceneManager.GetActiveScene().buildIndex == 5 || SceneManager.GetActiveScene().buildIndex == 6)
            {
                Instantiate(SplashPrefab, new Vector3(0.349f, 1.122f, 2.511f), Quaternion.identity);
            }
            if (SceneManager.GetActiveScene().buildIndex == 7)
            {
                Instantiate(SplashPrefab, new Vector3(-3.659f, 1.056f, -0.118f), Quaternion.identity);
            }
            if (SceneManager.GetActiveScene().buildIndex == 8)
            {
                Instantiate(SplashPrefab, new Vector3(-0.204f,1.28f,-0.126f), Quaternion.identity);
            }
            if (SceneManager.GetActiveScene().buildIndex == 9)
            {
                Instantiate(SplashPrefab, new Vector3(-1.835f, 1.141f, 1.309187f), Quaternion.identity);
            }


        }
    }
}

