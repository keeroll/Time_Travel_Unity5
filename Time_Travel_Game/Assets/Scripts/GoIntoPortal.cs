using UnityEngine;
using System.Collections;

public class GoIntoPortal : MonoBehaviour {

	public GameObject anotherPortal;
	void Start () {
	
	}
	

	void Update () {
	
	}

	void OnTriggerEnter(Collider otherCollider)
	{
		if (otherCollider.tag == "Player") 
		{
			otherCollider.transform.position = anotherPortal.transform.position;
		}

	}
}
