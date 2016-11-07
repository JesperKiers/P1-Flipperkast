using UnityEngine;
using System.Collections;

public class DeathZone : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


    void OnCollisionEnter(Collision c)
    {
        Destroy(c.gameObject);//deletes object that collides with the one with this component
        GameObject.Find("Manager").GetComponent<GameManager>().lives -= 1;//takes one life 

        GameObject.Find("launcher").GetComponent<PullSpring>().SpawnNewBall();
    }
}
