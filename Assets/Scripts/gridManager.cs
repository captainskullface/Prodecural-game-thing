using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gridManager : MonoBehaviour
{
    public GameObject tilePrefab;

    public Sprite[] tileSprites;
    public Sprite dug;
    public Sprite skull;
    public Sprite treasure;
    public GridMove gridMove;

    GameObject[,] gridTiles;

    public int gridWidth;
    public int gridHeight;

    void Start()
    {
        gridTiles = new GameObject[gridWidth, gridHeight];
        for(int x = 0; x < gridWidth; x++)
        {
            for(int y = 0; y < gridHeight; y++)
            {
                MakeTile(x, y);
            }
             
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
       // tileData.newTile.GetComponent<SpriteRenderer>().sprite = targetSprite; 
    }

    void MakeTile(int xPos, int yPos)
    {
        GameObject newTile = Instantiate(tilePrefab);
        int randTile = Random.Range(0, tileSprites.Length);
        newTile.GetComponent<SpriteRenderer>().sprite = tileSprites[randTile];
        newTile.transform.position = new Vector3(transform.position.x + xPos, transform.position.y + yPos, 0);
        tileData myData = newTile.GetComponent<tileData>();

        if(randTile == 0)
        {
            Sprite targetSprite = dug;

        } else if(randTile == 1) 
        {
            Sprite targetSprite = skull;
        } else if(randTile == 2)
        {
            Sprite targetSprite = treasure;
        }

        myData.gridX = xPos;
        myData.gridY = yPos;
        gridTiles[xPos, yPos] = newTile;
    }

}

