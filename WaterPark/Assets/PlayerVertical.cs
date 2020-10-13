using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerVertical : MonoBehaviour
{

    public float moveSpeed = 4f;
    public Transform movePoint;

    //Vert Colliders
    public GameObject TopCollider;
    public GameObject BottomCollider;
    public GameObject RightCollider;
    public GameObject LeftCollider;

    //Hori Colliders
    public GameObject HorTopCollider;
    public GameObject HorBottomCollider;
    public GameObject HorRightCollider;
    public GameObject HorLeftCollider;


    public LayerMask Border;

    void Start()
    {
        movePoint.parent = null;
    }

    void Update()
    {


        transform.position = Vector3.MoveTowards(transform.position, movePoint.position, moveSpeed * Time.deltaTime);

        if (Vector3.Distance(transform.position, movePoint.position) <= .05f)
        {
            if (Input.GetKeyDown("w"))
            {
                if (TopCollider.GetComponent<touchBorderTop>().TopTriggerHitv == false)
                {

                    // Top Colliders 
                    if (HorTopCollider.GetComponent<hitBorderTop>().TopTriggerHit == true && TopCollider.GetComponent<touchBorderTop>().HorTriggerTop == false)
                    {
                        movePoint.position += new Vector3(0f, 0f, Input.GetAxisRaw("Vertical"));
                    }
                    if (HorTopCollider.GetComponent<hitBorderTop>().TopTriggerHit == false && TopCollider.GetComponent<touchBorderTop>().HorTriggerTop == true)
                    {
                        movePoint.position += new Vector3(0f, 0f, Input.GetAxisRaw("Vertical"));
                    }
                    if (HorTopCollider.GetComponent<hitBorderTop>().TopTriggerHit == false && TopCollider.GetComponent<touchBorderTop>().HorTriggerTop == false)
                    {
                        movePoint.position += new Vector3(0f, 0f, Input.GetAxisRaw("Vertical"));
                    }
                }
            }
        }

                if (Input.GetKeyDown("s"))
                {
                    if (BottomCollider.GetComponent<touchBorderBottom>().BottomTriggerHitv == false)
                    {

                    // Bottom Colliders
                    if (HorBottomCollider.GetComponent<hitBorderBottom>().BottomTriggerHit == true && BottomCollider.GetComponent<touchBorderBottom>().HorTriggerBottom == false)
                    {
                        movePoint.position += new Vector3(0f, 0f, Input.GetAxisRaw("Vertical"));
                    }
                    if (HorBottomCollider.GetComponent<hitBorderBottom>().BottomTriggerHit == false && BottomCollider.GetComponent<touchBorderBottom>().HorTriggerBottom == true)
                    {
                        movePoint.position += new Vector3(0f, 0f, Input.GetAxisRaw("Vertical"));
                    }
                    if (HorBottomCollider.GetComponent<hitBorderBottom>().BottomTriggerHit == false && BottomCollider.GetComponent<touchBorderBottom>().HorTriggerBottom == false)
                    {
                        movePoint.position += new Vector3(0f, 0f, Input.GetAxisRaw("Vertical"));
                    }
                }
            }

        if (Input.GetKeyDown("a") && HorLeftCollider.GetComponent<hitBorder>().VerTriggerLeft == true)
        {
            if (LeftCollider.GetComponent<touchBorderLeft>().LeftTriggerHitv == false)
            {
                movePoint.position += new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f);
            }
        }
        if (Input.GetKeyDown("d") && HorRightCollider.GetComponent<hitBorderRight>().VerTriggerRight == true)
        {
            if (RightCollider.GetComponent<touchBorderRight>().RightTriggerHitv == false)
            {
                movePoint.position += new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f);
            }
        }



    }
    }


