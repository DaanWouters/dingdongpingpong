using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static Playerpaddle;

public class PlayerpaddleSonic : MonoBehaviour
{

    public enum PaddleType { Left, Right };
    public PaddleType paddleType;
    public float speed = 17f;  //this is the speed of the playerpaddle
    public float maxValue = 3f; // this one is actually useless
    public bool hitTop = false; // if the paddle hits the top he cant get any further up
    public bool hitBottom = false; // if the paddle hits the bottom he cant any further down

    void Update()
    {
        if (paddleType == PaddleType.Left)  // this shows the left paddle
        {
            if (Input.GetKey(KeyCode.W) && !hitTop) // the button W lets the paddle go up
            {
                transform.Translate(Vector3.up * speed * Time.deltaTime); // lets the paddle go up, x speed x time of the game
            }
            else if (Input.GetKey(KeyCode.S) && !hitBottom) // lets the paddle go up with the button s
            {
                transform.Translate(Vector3.down * speed * Time.deltaTime); // lets the paddle go up, x speed, x time of the game
            }
        }
    }
    void OnTriggerStay2D(Collider2D collision) //this one checks for the collision of the walls
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
