using UnityEngine;
using System.Collections;

public class RaycastDemo : MonoBehaviour {

	public Transform blueprint;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit rayHit = new RaycastHit();

		if (Physics.Raycast(ray, out rayHit, 1000f) && Input.GetMouseButtonDown(0)) {
			Destroy(rayHit.transform.gameObject);
		}
	}
}
