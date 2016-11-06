using UnityEngine;
using System.Collections;

public class XtraBall : MonoBehaviour {
    public GameObject ball;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter()
    {
        Destroy(gameObject);//deletes the object with this script component
        GameObject prefab = (GameObject)Instantiate((GameObject)ball, transform.position, transform.rotation);//spawns prefab of the ball on the transform
        
    }
}
