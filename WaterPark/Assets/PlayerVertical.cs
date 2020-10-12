using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerVertical : MonoBehaviour
{

    public float moveSpeed = 4f;
    public Transform movePoint;
    public GameObject TopCollider;
    public GameObject BottomCollider;
    public GameObject HorTopCollider;


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
                  // if (HorTopCollider.GetComponent<hitBorderTop>().TopTriggerHit == false && TopCollider.GetComponent<touchBorderTop>().HorTriggerTop == false)
                  //{
                        movePoint.position += new Vector3(0f, 0f, Input.GetAxisRaw("Vertical"));
                    //}
                }
            }

            if (Input.GetKeyDown("s"))
            {
                if (BottomCollider.GetComponent<touchBorderBottom>().BottomTriggerHitv == false)
                {
                    movePoint.position += new Vector3(0f, 0f, Input.GetAxisRaw("Vertical"));
                }
            }
        }
    }


} 