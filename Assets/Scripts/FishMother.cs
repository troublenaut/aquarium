using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FishMother : MonoBehaviour {

	public FishScript fishPrint;
	public FishScript fishPrint2;
	List<FishScript> fishList = new List<FishScript>();

	// Use this for initialization
	void Start () {
		int counter = 0;
		while (counter < 40) {
			FishScript newFish = Instantiate(fishPrint, Random.insideUnitSphere * 10f, Random.rotation) as FishScript;
			FishScript newFish2 = Instantiate(fishPrint2, Random.insideUnitSphere * 10f, Random.rotation) as FishScript;
			fishList.Add(newFish);
			fishList.Add(newFish2);
			counter++;
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.Space)){
			foreach (FishScript pierce in fishList) {
				pierce.destination = new Vector3 (5,1,10);
			}
		}
	}
	
}
