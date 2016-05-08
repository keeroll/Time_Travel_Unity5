using UnityEngine;
using System.Collections;

public class TimeController : MonoBehaviour {

	public int time;
	bool isForward = true;

	void FixedUpdate () {
		if (isForward) 
		{
			time++;
		}
	}
}
