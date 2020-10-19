using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGrab : MonoBehaviour
{
    public bool SpacePressed;

    public bool SpaceVert;
    public bool SpaceHor;

    public bool NextTooVer;
    public bool NextTooHor;

    public bool moveVerUp;

    public Transform movePoint;
    public float moveSpeed = 4f;
    

    //Colliders

    public GameObject LeftCol;
    public GameObject RightCol;
    public GameObject TopCol;
    public GameObject BottomCol;

    //Vert Colliders
    public GameObject VerTopCollider;
    public GameObject VerBottomCollider;
    public GameObject VerRightCollider;
    public GameObject VerLeftCollider;

    //Hori Colliders
    public GameObject HorTopCollider;
    public GameObject HorBottomCollider;
    public GameObject HorRightCollider;
    public GameObject HorLeftCollider;



    public GameObject Ver;
    public GameObject Hor;

    // Start is called before the first frame update
    void Start()
    {
        
        movePoint.parent = null;

    }

    // Update is called once per frame
    void Update()
    {

        transform.position = Vector3.MoveTowards(transform.position, movePoint.position, moveSpeed * Time.deltaTime);

        if (LeftCol.GetComponent<GrabLeftCollider>().VertGrabLeft == true || RightCol.GetComponent<GrabRightCollider>().VertGrabRight == true || TopCol.GetComponent<GrabTopCollider>().VertGrabTop == true || BottomCol.GetComponent<GrabBottomCollider>().VertGrabBottom == true)
        {
            NextTooVer = true; 
        }
        if (LeftCol.GetComponent<GrabLeftCollider>().VertGrabLeft == false && RightCol.GetComponent<GrabRightCollider>().VertGrabRight == false && TopCol.GetComponent<GrabTopCollider>().VertGrabTop == false && BottomCol.GetComponent<GrabBottomCollider>().VertGrabBottom == false)
        {
            NextTooVer = false;
        }

        if (Input.GetKeyDown("space"))
        {
            if (SpacePressed == false)
            {
                SpacePressed = true;
            }
            else
            {
                SpacePressed = false;
            }
        }

        if (SpacePressed == true)
        {
            

            if(NextTooVer == true)
            {
                if (Input.GetKeyDown("w"))
                {
                    if (VerTopCollider.GetComponent<touchBorderTop>().TopTriggerHitv == false && TopCol.GetComponent<GrabTopCollider>().TopBorderGrab == false)
                    {
                        moveVerUp = true;
                        movePoint.position += new Vector3(0f, 0f, Input.GetAxisRaw("Vertical"));
                    }
                    if (VerTopCollider.GetComponent<touchBorderTop>().TopTriggerHitv == true && TopCol.GetComponent<GrabTopCollider>().TopBorderGrab == false)
                    {
                        moveVerUp = true;
                        movePoint.position += new Vector3(0f, 0f, Input.GetAxisRaw("Vertical"));
                    }
                    if (VerTopCollider.GetComponent<touchBorderTop>().TopTriggerHitv == false && TopCol.GetComponent<GrabTopCollider>().TopBorderGrab == true)
                    {
                        moveVerUp = true;
                        movePoint.position += new Vector3(0f, 0f, Input.GetAxisRaw("Vertical"));
                    }
                }
                if (Input.GetKeyDown("s"))
                {
                    if (VerBottomCollider.GetComponent<touchBorderBottom>().BottomTriggerHitv == false && BottomCol.GetComponent<GrabBottomCollider>().BottomBorderGrab == false)
                    {
                        moveVerUp = true;
                        movePoint.position += new Vector3(0f, 0f, Input.GetAxisRaw("Vertical"));
                    }
                    if (VerBottomCollider.GetComponent<touchBorderBottom>().BottomTriggerHitv == true && BottomCol.GetComponent<GrabBottomCollider>().BottomBorderGrab == false)
                    {
                        moveVerUp = true;
                        movePoint.position += new Vector3(0f, 0f, Input.GetAxisRaw("Vertical"));
                    }
                    if (VerBottomCollider.GetComponent<touchBorderBottom>().BottomTriggerHitv == false && BottomCol.GetComponent<GrabBottomCollider>().BottomBorderGrab == true)
                    {
                        moveVerUp = true;
                        movePoint.position += new Vector3(0f, 0f, Input.GetAxisRaw("Vertical"));
                    }
                }
            }
            
        }

        if (SpacePressed == false)
        {
            
        }




    }
}
