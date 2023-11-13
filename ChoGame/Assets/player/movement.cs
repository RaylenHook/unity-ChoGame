using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{

    [SerializeField] float speed = 0.05f;

        void Update()
    {
        MovementSystem();
    }

    void MovementSystem()
    {
        if(Input.GetKey(KeyCode.W))
        {
            moveFwrd();
        }
        if(Input.GetKey(KeyCode.A))
        {
            moveLeft();
        }
        if(Input.GetKey(KeyCode.S))
        {
            moveBkwrd();
        }
        if(Input.GetKey(KeyCode.D))
        {
            moveRight();
        }
    }

    void moveFwrd(){transform.Translate(0,0,speed);}

    void moveBkwrd(){transform.Translate(0,0,-speed);}

    void moveLeft(){transform.Translate(-speed,0,0);}

    void moveRight(){transform.Translate(speed,0,0);}
}
