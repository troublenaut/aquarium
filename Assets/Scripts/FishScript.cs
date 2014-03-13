using UnityEngine;
using System.Collections;

public class FishScript : MonoBehaviour {

	public Vector3 destination;

	// Use this for initialization
	void Start () {
		InvokeRepeating("RandomizeDestination", 1f, 10f);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		rigidbody.AddForce(Vector3.Normalize(destination - transform.position));
	}

	void Update(){
		transform.rotation = Quaternion.LookRotation(rigidbody.velocity);
	}

	void RandomizeDestination() {
		destination = Random.insideUnitSphere * 5f;
	}
	
}
