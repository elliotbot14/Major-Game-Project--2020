using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHorizontal : MonoBehaviour
{

    public float moveSpeed = 4f;
    public Transform movePoint;

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
            if (Mathf.Abs(Input.GetAxisRaw("Horizontal")) == 1f)
            {
                //if (Physics.OverlapSphere(movePoint.position + new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f), .2f, Border))
               // {
                    movePoint.position += new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f);
               // }
            }
        }
    }


}
