using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{

    [SerializeField] float speed = 0.05f;

        void Update()
    {
        //MovementSystem();
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

    private void LateUpdate()
    {
        MovementSystem();
    }

    void moveFwrd(){ Move(new Vector3(0, 0, speed)); }

    void moveBkwrd(){ Move(new Vector3(0, 0, -speed)); }

    void moveLeft(){ Move(new Vector3(-speed, 0, 0)); }

    void moveRight(){ Move(new Vector3(speed, 0, 0)); }

    private void Move(Vector3 d)
    {
        transform.Translate(d * Time.deltaTime);
    }
}
