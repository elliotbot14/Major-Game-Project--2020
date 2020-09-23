using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerVertical : MonoBehaviour
{

    public float moveSpeed = 5f;
    public Transform movePointVert;

    // Start is called before the first frame update
    void Start()
    {
        movePointVert.parent = null;
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = Vector3.MoveTowards(transform.position, movePointVert.position, moveSpeed * Time.deltaTime);

        if (Vector3.Distance(transform.position, movePointVert.position) <= .05f)
        {
            if (Mathf.Abs(Input.GetAxisRaw("Vertical")) == 1f)
            {
                movePointVert.position += new Vector3(0f, Input.GetAxisRaw("Vertical"), 0f);
            }
        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        this.gameObject.SetActive(false);
    }
}
