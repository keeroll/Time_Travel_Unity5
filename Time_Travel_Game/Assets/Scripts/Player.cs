using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Player : MonoBehaviour
{
	[SerializeField] TimeController timeController;

	Dictionary<int,PlayerState> recording;

	//Animator _animator;

	void Start ()
	{
		//_animator = GetComponent<Animator> ();

	}

	public void SetRecording (Dictionary<int, PlayerState> recording)
	{
		this.recording = new Dictionary<int, PlayerState> (recording);
		isPlaying = true;

	}

	void Update()
	{
		
	}


	bool isPlaying = false;
	void FixedUpdate ()
	{
		if (isPlaying) 
		{
			if (recording.ContainsKey (timeController.time))
			{
				PlayState(recording [timeController.time]);
			}
		}
	}

	void PlayState(PlayerState playerState)
	{
		transform.position = playerState.position;
		//_animator.Play(playerState.animationStatement);
		Vector3 localScale = transform.localScale;
		localScale.x = playerState.direction ? Mathf.Abs (localScale.x) : -Mathf.Abs (localScale.x);
	}
}
