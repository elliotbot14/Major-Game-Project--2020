using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerVertical : MonoBehaviour
{

    public float moveSpeed = 4f;
    public Transform movePoint;
    public GameObject Vert;
    public Material lava;
    public Material ground;  
    public GameObject UITEXT;

    public GameObject GrabPlayer;

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

    //Grab Colliders

    public GameObject GrabTopCollider;
    public GameObject GrabBottomCollider;
    public GameObject GrabLeftCollider;
    public GameObject GrabRightCollider;

    public AudioClip movebeep;
    AudioSource audioSource;

    public LayerMask Border;

    void Start()
    {
        movePoint.parent = null;
        gameObject.GetComponent<MeshRenderer>().material = ground;

        GameObject soundGameObject = new GameObject("sound");
        audioSource = soundGameObject.AddComponent<AudioSource>();
    }

    void Update()
    {
        if(GrabPlayer.GetComponent<PlayerGrab>().NextTooVer == true)
        {
            if(GrabPlayer.GetComponent<PlayerGrab>().SpacePressed == true)
            {
                gameObject.GetComponent<MeshRenderer>().material = lava;
            }
        }

        if (Vert.GetComponent<EndCheckVert>().VertReachEnd == false)
        {
            if (UITEXT.GetComponent<DialogueScene2>().MoveActive == true)
            {
                transform.position = Vector3.MoveTowards(transform.position, movePoint.position, moveSpeed * Time.deltaTime);

                // if (TopCollider.GetComponent<touchBorderTop>().TopTriggerHitv == false && GrabTopCollider.GetComponent<GrabTopCollider>().TopBorderGrab == false) {

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
                                audioSource.PlayOneShot(movebeep);
                            }
                            if (HorTopCollider.GetComponent<hitBorderTop>().TopTriggerHit == false && TopCollider.GetComponent<touchBorderTop>().HorTriggerTop == true)
                            {
                                movePoint.position += new Vector3(0f, 0f, Input.GetAxisRaw("Vertical"));
                                audioSource.PlayOneShot(movebeep);
                            }
                            if (HorTopCollider.GetComponent<hitBorderTop>().TopTriggerHit == false && TopCollider.GetComponent<touchBorderTop>().HorTriggerTop == false)
                            {
                                movePoint.position += new Vector3(0f, 0f, Input.GetAxisRaw("Vertical"));
                                audioSource.PlayOneShot(movebeep);
                            }
                        }
                    }
                }
                // }//end of grab loop

                if (Input.GetKeyDown("s"))
                {
                    if (BottomCollider.GetComponent<touchBorderBottom>().BottomTriggerHitv == false)
                    {

                        // Bottom Colliders
                        if (HorBottomCollider.GetComponent<hitBorderBottom>().BottomTriggerHit == true && BottomCollider.GetComponent<touchBorderBottom>().HorTriggerBottom == false)
                        {
                            movePoint.position += new Vector3(0f, 0f, Input.GetAxisRaw("Vertical"));
                            audioSource.PlayOneShot(movebeep);
                        }
                        if (HorBottomCollider.GetComponent<hitBorderBottom>().BottomTriggerHit == false && BottomCollider.GetComponent<touchBorderBottom>().HorTriggerBottom == true)
                        {
                            movePoint.position += new Vector3(0f, 0f, Input.GetAxisRaw("Vertical"));
                            audioSource.PlayOneShot(movebeep);
                        }
                        if (HorBottomCollider.GetComponent<hitBorderBottom>().BottomTriggerHit == false && BottomCollider.GetComponent<touchBorderBottom>().HorTriggerBottom == false)
                        {
                            movePoint.position += new Vector3(0f, 0f, Input.GetAxisRaw("Vertical"));
                            audioSource.PlayOneShot(movebeep);
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
    }
 }


