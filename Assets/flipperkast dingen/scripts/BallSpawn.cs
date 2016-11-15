using UnityEngine;
using System.Collections;

public class BallSpawn : MonoBehaviour {
    public GameObject ball;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void SpawnNewBall()
    {
        Instantiate((GameObject)ball, transform.position, transform.rotation);//spawns a new ball when the other is destroyed
    }
}
