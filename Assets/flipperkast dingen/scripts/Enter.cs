using UnityEngine;
using System.Collections;

public class Enter : MonoBehaviour
{



    

    void OnCollisionEnter()
    {
        

        GameObject.Find("Manager").GetComponent<GameManager>().score += 100;//adds 100 points every time collision is made

        
    }
}