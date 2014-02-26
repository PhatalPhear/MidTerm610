using UnityEngine;
using System.Collections;

public class EventManager : MonoBehaviour {

	public GameObject SphereOne;
	public GameObject SphereTwo;
	public GameObject SphereThree;
	// Use this for initialization
	void Start () {
	
	}

	void OnCollisionEnter(Collision Obj)
	{
		if (Obj.gameObject.tag == "CubeOne") {
			Debug.Log("test");
			SphereOne.renderer.material.color = Color.yellow;
			SphereTwo.renderer.material.color = Color.yellow;
			SphereThree.renderer.material.color = Color.yellow;
				}
	}
	// Update is called once per frame
	void Update () {
	
	}
}
