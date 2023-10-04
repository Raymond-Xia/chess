using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Piece : MonoBehaviour
{

    public GameObject controller;
    public GameObject movePlate;
    // public GameObject temp;

    private int xBoard = -1;
    private int yBoard = -1;

    public void Activate(int x, int y) {
        controller = GameObject.FindGameObjectWithTag("GameController");
        Debug.Log(this.gameObject.transform.GetChild(0));
        Move(x,y);
    }

    private float CoordToPixel(int i) {
        return i * 1.25f + 0.625f - 5;
    }

    private int PixelToCoord(float f) {
        return (int)((f + 5)/1.25f); 
    }

    private void Move(int x, int y) {
        xBoard = x;
        yBoard = y;

        float xPos = CoordToPixel(xBoard);
        float yPos = CoordToPixel(yBoard);
        transform.position = new Vector3(xPos, yPos, -2);
    }

    // // Start is called before the first frame update
    // void Start()
    // {
    //     // temp = Instantiate(movePlate, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
    //     Debug.Log("ong");
    // }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnMouseDown()
    {
        // movePlate.GetComponent<MovePlate>().Activate(xBoard, yBoard);
        // movePlate.SetActive(true);
    }
    
    private bool isValidMove(int x, int y) 
    {
        int xDiff = x - xBoard;
        int yDiff = y - yBoard;


        switch (this.name)
        {
            case "King":
            
                if (Math.Abs(xDiff) > 1 || Math.Abs(yDiff) > 1)
                {
                    return false;
                }

                if (xDiff < 0 && xBoard == 0 || xDiff > 0 && xBoard == 7 
                    || yDiff < 0 && yBoard == 0 || yDiff > 7 && yBoard > 7)
                {
                    return false;
                }
                break;
            
            default:
                break;
        } 
        return true;
    }

    void OnMouseUp()
    {        
        Debug.Log(transform.position);

        // Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        
        // Vector3 diff = position - transform.position;
        // if (Math.Abs(diff.x) > 2.5 || Math.Abs(diff.y) > 2.5) {
        //     transform.position = position;
        // } else {
        //     position = transform.position;
        // }
        if (isValidMove(PixelToCoord(transform.position.x), PixelToCoord(transform.position.y))) {
            Move(PixelToCoord(transform.position.x), PixelToCoord(transform.position.y));
        } else {
            Move(xBoard, yBoard); // jump back if invalid move
        }
        // movePlate.SetActive(false);

    }

    void OnMouseDrag()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        
        transform.position = new Vector3(mousePosition.x, mousePosition.y, transform.position.z);
    }
}
