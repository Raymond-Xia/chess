using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{

    public GameObject white_king;
    public GameObject white_pawn1;
    public GameObject white_pawn2;
    public GameObject white_pawn3;
    public GameObject white_pawn4;
    public GameObject white_pawn5;
    public GameObject white_pawn6;
    public GameObject white_pawn7;
    public GameObject white_pawn8;

    // Start is called before the first frame update
    void Start()
    {
        // Instantiate(white_king, new Vector3(0.5f,-4.3f,-1), Quaternion.identity);
        // white_king.transform.position = new Vector3(0+0.625f, -5+0.625f, -2);

        white_king.GetComponent<Piece>().Activate(4, 0);
        white_pawn1.GetComponent<Piece>().Activate(0, 1);
        white_pawn2.GetComponent<Piece>().Activate(1, 1);
        white_pawn3.GetComponent<Piece>().Activate(2, 1);
        white_pawn4.GetComponent<Piece>().Activate(3, 1);
        white_pawn5.GetComponent<Piece>().Activate(4, 1);
        white_pawn6.GetComponent<Piece>().Activate(5, 1);
        white_pawn7.GetComponent<Piece>().Activate(6, 1);
        white_pawn8.GetComponent<Piece>().Activate(7, 1);
    }
    
    // Update is called once per frame
    // void Update()
    // {
    //     Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    //     if (Input.GetMouseButtonDown(0))
    //     {
    //         Collider2D targetObject = Physics2D.OverlapPoint(mousePosition);
    //         if (targetObject)
    //         {
    //             Debug.Log("touch!");
    //             white_king = targetObject.transform.gameObject;
    //             white_king.transform.position = new Vector3(mousePosition.x, mousePosition.y, 0);
    //             Debug.Log("white " + white_king.transform.position);
    //             Debug.Log("mouse " + mousePosition);
    //         }
    //     }
    // }

    // void OnMouseDrag()
    // {
        
    //     Debug.Log("touch!");
    //     white_king.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    // }
}