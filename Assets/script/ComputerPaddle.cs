using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerPaddle : MonoBehaviour
{
    public enum PaddleType { Left, Right };
    public PaddleType paddleType;
    public float speed = 5f;
    public float maxValue = 3f;
    public bool hitTop = false;
    public bool hitBottom = false;

    void Update()
    {
        if (paddleType == PaddleType.Right)
        {
            if (Input.GetKey(KeyCode.UpArrow) && !hitTop)
            {
                transform.Translate(Vector3.up * speed * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.DownArrow) && !hitBottom)
            {
                transform.Translate(Vector3.down * speed * Time.deltaTime);
            }
        }
    }
    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.name == "TopWall")
        {
            hitTop = true;
        }
        if (collision.gameObject.name == "BottomWall")
        {
            hitBottom = true;
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        hitBottom = false;
        hitTop = false;
    }
}
