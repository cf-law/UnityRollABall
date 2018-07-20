using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {

	// Update is called once per frame (not using physics so can use this instead of lateupdate)
	void Update () {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime); // multiply it by Time.deltaTime to ensure animation is smooth and not tied to frame rate.
	}
}
