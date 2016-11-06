using UnityEngine;
using System.Collections;

public class PullSpring : MonoBehaviour
{
    public float thrust;
    public GameObject ball;
    public bool schecker;

    void Start()
    {
        
    }
    void Update()
    {

        if (Input.GetButton("Jump"))
        {
            GetComponent<Rigidbody>().AddForce(-transform.forward * thrust);//gives force forward when spacebar is pressed
        }

        if (GetComponent("ball"))
        {
            schecker = true;
        }
        else
        {
            schecker = false;
        }

        if (schecker == false)
        {
            if (Input.GetButton("Fire3"))
            {
                Instantiate((GameObject)ball, transform.position, transform.rotation);//spawns a unlimited amount of balls because i can't figure out to do 1 when you need only 1, please press for the game over
            }
        }
    }
}
