using UnityEngine;
using System.Collections;

public class FlyMode : MonoBehaviour {

    private bool isFlying = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        if (Input.GetKeyDown(KeyCode.F))
        {
            isFlying = !isFlying;
            //var ri = gameObject.GetComponent<Rigidbody>();
            //ri.useGravity = isFlying;
            //ri.isKinematic  = isFlying;
            SetAllCollidersStatus(isFlying);
        }

	}
    public void SetAllCollidersStatus(bool active)
    {
        foreach (Collider c in GetComponents<Collider>())
        {
            c.enabled = active;
            Debug.Log(c.enabled);
        }
    }
}
