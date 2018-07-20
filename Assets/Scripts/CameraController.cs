using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject player;

    private Vector3 offset; // private because we can set it in the script

	// Use this for initialization
	void Start () {
        offset = transform.position - player.transform.position;
	}
	
	// LateUpdate is called once per frame, but guaranteed to run after all items are processed and updated (so after the player has moved)
    // this is why we dont use update^^
	void LateUpdate () {
        transform.position = player.transform.position + offset;
	}
}
