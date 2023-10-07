using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{

    public GameObject white_king;
    public GameObject white_queen;
    public GameObject white_rook1;
    public GameObject white_rook2;
    public GameObject white_knight1;
    public GameObject white_knight2;
    public GameObject white_bishop1;
    public GameObject white_bishop2;
    public GameObject white_pawn1;
    public GameObject white_pawn2;
    public GameObject white_pawn3;
    public GameObject white_pawn4;
    public GameObject white_pawn5;
    public GameObject white_pawn6;
    public GameObject white_pawn7;
    public GameObject white_pawn8;

    public GameObject black_king;
    public GameObject black_queen;
    public GameObject black_rook1;
    public GameObject black_rook2;
    public GameObject black_knight1;
    public GameObject black_knight2;
    public GameObject black_bishop1;
    public GameObject black_bishop2;
    public GameObject black_pawn1;
    public GameObject black_pawn2;
    public GameObject black_pawn3;
    public GameObject black_pawn4;
    public GameObject black_pawn5;
    public GameObject black_pawn6;
    public GameObject black_pawn7;
    public GameObject black_pawn8;

    // Start is called before the first frame update
    void Start()
    {
        // Instantiate(white_king, new Vector3(0.5f,-4.3f,-1), Quaternion.identity);
        // white_king.transform.position = new Vector3(0+0.625f, -5+0.625f, -2);

        white_king.GetComponent<Piece>().Activate(4, 0);
        white_queen.GetComponent<Piece>().Activate(3, 0);
        white_rook1.GetComponent<Piece>().Activate(0, 0);
        white_rook2.GetComponent<Piece>().Activate(7, 0);
        white_knight1.GetComponent<Piece>().Activate(1, 0);
        white_knight2.GetComponent<Piece>().Activate(6, 0);
        white_bishop1.GetComponent<Piece>().Activate(2, 0);
        white_bishop2.GetComponent<Piece>().Activate(5, 0);
        white_pawn1.GetComponent<Piece>().Activate(0, 1);
        white_pawn2.GetComponent<Piece>().Activate(1, 1);
        white_pawn3.GetComponent<Piece>().Activate(2, 1);
        white_pawn4.GetComponent<Piece>().Activate(3, 1);
        white_pawn5.GetComponent<Piece>().Activate(4, 1);
        white_pawn6.GetComponent<Piece>().Activate(5, 1);
        white_pawn7.GetComponent<Piece>().Activate(6, 1);
        white_pawn8.GetComponent<Piece>().Activate(7, 1);

        black_king.GetComponent<Piece>().Activate(4, 7);
        black_queen.GetComponent<Piece>().Activate(3, 7);
        black_rook1.GetComponent<Piece>().Activate(0, 7);
        black_rook2.GetComponent<Piece>().Activate(7, 7);
        black_knight1.GetComponent<Piece>().Activate(1, 7);
        black_knight2.GetComponent<Piece>().Activate(6, 7);
        black_bishop1.GetComponent<Piece>().Activate(2, 7);
        black_bishop2.GetComponent<Piece>().Activate(5, 7);
        black_pawn1.GetComponent<Piece>().Activate(0, 6);
        black_pawn2.GetComponent<Piece>().Activate(1, 6);
        black_pawn3.GetComponent<Piece>().Activate(2, 6);
        black_pawn4.GetComponent<Piece>().Activate(3, 6);
        black_pawn5.GetComponent<Piece>().Activate(4, 6);
        black_pawn6.GetComponent<Piece>().Activate(5, 6);
        black_pawn7.GetComponent<Piece>().Activate(6, 6);
        black_pawn8.GetComponent<Piece>().Activate(7, 6);
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