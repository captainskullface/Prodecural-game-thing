using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed;
    public Transform movePoint;

    public LayerMask whatStopsMovement;

    private void Start()
    {
        movePoint.parent = null;    
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, movePoint.position, speed * Time.deltaTime);

        if(Vector3.Distance(transform.position, movePoint.position) <= 0.5f)
        {
            if (Mathf.Abs(Input.GetAxisRaw("Horizontal")) == 1f)
            {
                if(Physics2D.OverlapCircle(movePoint.position + new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f), .2f, whatStopsMovement))
                {
                    movePoint.position += new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f);
                }
                
            } 
            
            if (Mathf.Abs(Input.GetAxisRaw("Vertical")) == 1f)
            {
                if(Physics2D.OverlapCircle(movePoint.position + new Vector3(0f, Input.GetAxisRaw("Vertical"), 0f), .2f, whatStopsMovement))
                {
                    movePoint.position += new Vector3(0f, Input.GetAxisRaw("Vertical"), 0f);
                }
                
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //speed = collision.GetComponent<tileData>().tileSpeed;
    }

}
