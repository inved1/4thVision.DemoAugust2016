using UnityEngine;
using System.Collections;

public class ResetFPS : MonoBehaviour {

    private Vector3 myStartPos;
    private Quaternion myStartRot; 

	// Use this for initialization
	void Start () {
        this.myStartPos = transform.position;
        this.myStartRot = transform.rotation;

	
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        if (Input.GetKeyDown(KeyCode.R))
        {
            transform.position = this.myStartPos;
            transform.rotation = this.myStartRot;
        }

	}
}
