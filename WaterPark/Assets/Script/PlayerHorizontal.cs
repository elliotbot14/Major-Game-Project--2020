﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHorizontal : MonoBehaviour
{

    public float moveSpeed = 4f;
    public Transform movePoint;
    public GameObject LeftCollider;
    public GameObject RightCollider;
    

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
            if (Input.GetKeyDown("a"))
            {
               if(LeftCollider.GetComponent<hitBorder>().LeftTriggerHit == false)
                {
                    movePoint.position += new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f);
                }
            }

            if (Input.GetKeyDown("d"))
            {
                if (RightCollider.GetComponent<hitBorderRight>().RightTriggerHit == false)
                {
                    movePoint.position += new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f);
                }
            }
        }
    }


}
