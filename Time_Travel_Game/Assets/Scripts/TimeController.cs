using UnityEngine;
using System.Collections;

public class TimeController : MonoBehaviour {

	public int time;
	bool isAhead = true;

	void Update()
	{
		if (Input.GetKeyDown (KeyCode.Q))
		{
			isAhead = true;
		}
		if (Input.GetKeyDown (KeyCode.R)) 
		{
			isAhead = false;
		}
	}

	void FixedUpdate () {
		if (isAhead) {
			time++;
		}
		else 
		{
			time--;
			if (time < 0)
			{
				time = 0;
			}
		}
	}
}
