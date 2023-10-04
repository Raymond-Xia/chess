using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlate : MonoBehaviour
{

    public GameObject circle;

    public void Activate(int xBoard, int yBoard) {        
        if (xBoard>0) 
        {
            if (yBoard>0) 
            {
                Instantiate(circle, new Vector3(CoordToPixel(xBoard-1), CoordToPixel(yBoard-1), -2), Quaternion.identity);
            }
            Instantiate(circle, new Vector3(CoordToPixel(xBoard-1), CoordToPixel(yBoard), -2), Quaternion.identity);
            if (yBoard>0) 
            {
                Instantiate(circle, new Vector3(CoordToPixel(xBoard-1), CoordToPixel(yBoard+1), -2), Quaternion.identity);
            }
        }
    }

    // Start is called before the first frame update
    void Start() 
    {

    }

    private float CoordToPixel(int i) {
        return i * 1.25f + 0.625f - 5;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
