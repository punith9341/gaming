using UnityEngine;
using System.Collections;

public class cubeMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float forwardforce = 2000f;
    public float sideforce = 500f;
    public float down = 111f;
    public void FixedUpdate()
    {
        rb.AddForce(0,0,forwardforce*Time.deltaTime);


        if (rb.position.y < -11f)
        {
            FindObjectOfType<manger>().EndGame();
        }
    }
    public void right()
    {
        rb.AddForce(sideforce*Time.deltaTime,0,0,ForceMode.VelocityChange);
    }
    public void left()
    {
        rb.AddForce(-sideforce*Time.deltaTime,0,0,ForceMode.VelocityChange);
    }
}