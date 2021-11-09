using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridMove : MonoBehaviour
{
    public int playerX;
    public int playerY;
    public float gridSpaceSize;
    public float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetInput();
        MovePlayer();
    }

    void GetInput()
    {
        if (Input.GetKeyDown(KeyCode.W)) playerY++;
        if (Input.GetKeyDown(KeyCode.A)) playerX--;
        if (Input.GetKeyDown(KeyCode.S)) playerY--;
        if (Input.GetKeyDown(KeyCode.D)) playerX++;
    }

    void MovePlayer()
    {
        Vector2 MovePointPosition = new Vector2(playerX * gridSpaceSize, playerY * gridSpaceSize);
        transform.position = Vector3.MoveTowards(transform.position, MovePointPosition, speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //speed = collision.GetComponent<tileData>().tileSpeed;
    }
}
