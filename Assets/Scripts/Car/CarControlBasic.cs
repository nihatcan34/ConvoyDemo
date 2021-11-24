using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarControlBasic : MonoBehaviour
{
    public Levels levels;
    public PlayerControl playerControl;
    public GameState gameState;

    public float carSpeed = 5f;
    public Rigidbody carRigidbody;
    public Transform carTransform;
    float x = 0;
    private bool dirRight = false;
    private bool dirLeft = false;
    bool rotateRight = false;
    bool rotateLeft = false;
    public float speed = 2.0f;

    private void Movement()
    {
        if(carSpeed >= 15f)
        {
            speed = 4.0f;
        }
        else
        {
            speed = 2.0f;
        }

        if (dirRight)
        {
            carTransform.Translate(Vector2.right * speed * Time.deltaTime);
            carTransform.Rotate(Vector2.up * 5f * Time.deltaTime);
        }
        
        if (dirLeft)
        {
            carTransform.Translate(-Vector2.right * speed * Time.deltaTime);
            carTransform.Rotate(Vector2.down * 5f * Time.deltaTime);
        }


        if (carTransform.position.x >= x)
        {
            dirRight = false;
            if (carTransform.rotation.y >= 0f)
            {
                carTransform.Rotate(Vector2.down * 30f * Time.deltaTime);
            }
        }

        if (carTransform.position.x <= x)
        {
            dirLeft = false;
            if (carTransform.rotation.y <= 0f)
            {
                carTransform.Rotate(Vector2.up * 30f * Time.deltaTime);
            }
        }
    }

    private void GetInput()
    {
        if (Input.GetKeyUp(KeyCode.A) || playerControl.swipeLeft == true)
        {
            if(x > -1.25f)
            {
                x = x - 1.25f;
                dirLeft = true;
            }
        }
        
        if (Input.GetKeyUp(KeyCode.D) || playerControl.swipeRight == true)
        {
            if (x < 2f)
            {
                x = x + 1.24f;
                dirRight = true;
            }
        }
    }

    private void Accelerate()
    {
        /*if(levels.level == 1)
        {
            carRigidbody.velocity = transform.forward * carSpeed;
        }else if (levels.level == 2)
        {
            carRigidbody.velocity = transform.forward * (carSpeed + 2);
        }*/
        carTransform.position =new Vector3(carTransform.position.x, carTransform.position.y, carTransform.position.z + carSpeed  * Time.deltaTime);
        
    }

    private void LateUpdate()
    {
        if(gameState.state == "start")
        {
            Accelerate();
            GetInput();
            Movement();
        }
    }
}
