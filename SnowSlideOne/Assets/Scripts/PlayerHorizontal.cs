﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHorizontal : MonoBehaviour
{

    public float moveSpeed = 4f;
    public Transform movePoint;
    public GameObject Hor;
    public GameObject UITEXT;
    public GameObject Vert;
 
    

    //Hori Colliders
    public GameObject LeftCollider;
    public GameObject RightCollider;
    public GameObject BottomCollider;
    public GameObject TopCollider;

    //Vert Colliders
    public GameObject VertLeftCollider;
    public GameObject VertRightCollider;
    public GameObject VertBottomCollider;
    public GameObject VertTopCollider;

    public AudioClip movebeep;
    AudioSource audioSource;


    public LayerMask Border;

    void Start()
    {
        Vert.GetComponent<EndCheckVert>().VertReachEnd = true;
        movePoint.parent = null;
        GameObject soundGameObject = new GameObject("sound");
        audioSource = soundGameObject.AddComponent<AudioSource>();
    }
    void Update()
    {
        

        if (Hor.GetComponent<endCheck>().HorReachEnd == false)
        {
            if (UITEXT.GetComponent<Dialogue>().MoveActive == true)
            {
                

                    transform.position = Vector3.MoveTowards(transform.position, movePoint.position, moveSpeed * Time.deltaTime);

                    if (Vector3.Distance(transform.position, movePoint.position) <= .05f)
                    {
                        if (Input.GetKeyDown("a"))
                        {
                            if (LeftCollider.GetComponent<hitBorder>().LeftTriggerHit == false)
                            {
                                //Left Colliders
                                if (VertLeftCollider.GetComponent<touchBorderLeft>().LeftTriggerHitv == true && LeftCollider.GetComponent<hitBorder>().VerTriggerLeft == false)
                                {
                                    movePoint.position += new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f);
                                    audioSource.PlayOneShot(movebeep);
                                }
                                if (VertLeftCollider.GetComponent<touchBorderLeft>().LeftTriggerHitv == false && LeftCollider.GetComponent<hitBorder>().VerTriggerLeft == true)
                                {
                                    movePoint.position += new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f);
                                    audioSource.PlayOneShot(movebeep);
                                }
                                if (VertLeftCollider.GetComponent<touchBorderLeft>().LeftTriggerHitv == false && LeftCollider.GetComponent<hitBorder>().VerTriggerLeft == false)
                                {
                                    movePoint.position += new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f);
                                    audioSource.PlayOneShot(movebeep);
                                }
                            }
                        }

                        if (Input.GetKeyDown("d"))
                        {
                            if (RightCollider.GetComponent<hitBorderRight>().RightTriggerHit == false)
                            {
                                //Right Colliders
                                if (VertRightCollider.GetComponent<touchBorderRight>().RightTriggerHitv == true && RightCollider.GetComponent<hitBorderRight>().VerTriggerRight == false)
                                {
                                    movePoint.position += new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f);
                                    audioSource.PlayOneShot(movebeep);
                                }
                                if (VertRightCollider.GetComponent<touchBorderRight>().RightTriggerHitv == false && RightCollider.GetComponent<hitBorderRight>().VerTriggerRight == true)
                                {
                                    movePoint.position += new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f);
                                    audioSource.PlayOneShot(movebeep);
                                }
                                if (VertRightCollider.GetComponent<touchBorderRight>().RightTriggerHitv == false && RightCollider.GetComponent<hitBorderRight>().VerTriggerRight == false)
                                {
                                    movePoint.position += new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f);
                                    audioSource.PlayOneShot(movebeep);
                                }

                            }
                        }
                        if (Input.GetKeyDown("w") && VertTopCollider.GetComponent<touchBorderTop>().HorTriggerTop == true)
                        {
                            if (TopCollider.GetComponent<hitBorderTop>().TopTriggerHit == false)
                            {
                                movePoint.position += new Vector3(0f, 0f, Input.GetAxisRaw("Vertical"));
                                audioSource.PlayOneShot(movebeep);
                            }
                        }
                        if (Input.GetKeyDown("s") && VertBottomCollider.GetComponent<touchBorderBottom>().HorTriggerBottom == true)
                        {
                            if (BottomCollider.GetComponent<hitBorderBottom>().BottomTriggerHit == false)
                            {
                                movePoint.position += new Vector3(0f, 0f, Input.GetAxisRaw("Vertical"));
                                audioSource.PlayOneShot(movebeep);
                            }
                        }
                    }
                
            }

        }
    }
}
