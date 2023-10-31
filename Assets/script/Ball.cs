using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public float xPosition = 1f;
    public float yPosition = 1f;
    public float xSpeed = 5f;
    public float ySpeed = 5f;
    public bool hitTop = false;
    public bool hitBottom = true;
    public bool hitLeft = true;
    public bool hitRight = false;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(xPosition, yPosition, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (hitTop)
        {
            yPosition = yPosition - ySpeed * Time.deltaTime;
        }
        if (hitBottom)
        {
            yPosition = yPosition + ySpeed * Time.deltaTime;
        }
        if (hitLeft)
        {
            xPosition = xPosition + xSpeed * Time.deltaTime;
        }
        if (hitRight)
        {
            xPosition = xPosition - xSpeed * Time.deltaTime;
        }
        transform.position = new Vector3(xPosition, yPosition, 0f);
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "TopWall")
        {
            hitTop = true;
            hitBottom = false;
        }
        if (collision.gameObject.name == "BottomWall")
        {
            hitBottom = true;
            hitTop = false;
        }
        if (collision.gameObject.name == "PlayerPaddle")
        {
            hitLeft = true;
            hitRight = false;
            xSpeed = xSpeed + 0f;
            ySpeed = ySpeed + 0f;
        }
        if (collision.gameObject.name == "ComputerPaddle")
        {
            hitRight = true;
            hitLeft = false;
            xSpeed = xSpeed + 0f;
            ySpeed = ySpeed + 0f;
        }
        if (collision.gameObject.name == "LeftWall")
        {
             xPosition = 0f;
             yPosition = 0f;
}
        if (collision.gameObject.name == "RIghtWall")
        {
            xPosition = 0f;
            yPosition = 0f;
        }
    }
}

