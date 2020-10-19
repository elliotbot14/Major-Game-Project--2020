using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChangerScene4 : MonoBehaviour
{

    public Animator anim;
    int levelToLoad;

    public GameObject Vert;
    public GameObject Hor;
    public GameObject Grab;
    


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("r"))
        {
            FadeToLevel(SceneManager.GetActiveScene().buildIndex);
        }
        if (Vert.GetComponent<EndCheckVertScene4>().VertReachEnd == true && Hor.GetComponent<EndCheckScene4>().HorReachEnd == true)
        {
            FadeToNextLevel();
        }
        if(SceneManager.GetActiveScene().buildIndex == 10 && Grab.GetComponent<endcheckgrab>().GrabReachEnd == true)
        {
            FadeToNextLevel();
        }
    }
    public void FadeToNextLevel()
    {
        FadeToLevel(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void FadeToLevel(int levelIndex)
    {

        levelToLoad = levelIndex;
        anim.SetTrigger("FadeOut");
    }

    public void OnFadeComp()
    {

        SceneManager.LoadScene(levelToLoad);
    }
}
