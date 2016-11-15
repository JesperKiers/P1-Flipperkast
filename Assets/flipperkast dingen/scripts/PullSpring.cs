using UnityEngine;
using System.Collections;

public class PullSpring : MonoBehaviour
{
    public float thrust;
    public Vector3 positie;
   

    void Start()
    {
        
    }
    void Update()
    {

        if (Input.GetButtonDown("Jump"))
        {
            GetComponent<Rigidbody>().AddForce(-transform.forward * thrust);//gives force forward when spacebar is pressed
        }
        
        

    }

    
    
}
