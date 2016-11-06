using UnityEngine;
using System.Collections;

public class PlayOnImpact : MonoBehaviour {

    public AudioSource impactSound;

	// Use this for initialization
	void Start () {
	
	}
	
	void OnCollisionEnter()
    {
        impactSound.Play();// plays sound on collision
    }
}
