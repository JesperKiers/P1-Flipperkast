using UnityEngine;
using System.Collections;

public class PullSpring : MonoBehaviour
{
    public float thrust;
    public GameObject ball;
    public Vector3 positie;
   

    void Start()
    {
        
    }
    void Update()
    {

        if (Input.GetButton("Jump"))
        {
            GetComponent<Rigidbody>().AddForce(-transform.forward * thrust);//gives force forward when spacebar is pressed
        }
        
        

    }

    public void SpawnNewBall()
    {
        Instantiate((GameObject)ball,transform.position , transform.rotation);//spawns a new ball when the other is destroyed
    }
    
}
