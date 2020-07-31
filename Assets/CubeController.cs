using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour {
	AudioSource audioData;
	private float speed = -12;
	private float deadLine = -10;
	private float groundLevel = -3.0f;
	private bool isAudio = true;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(this.speed* Time.deltaTime, 0, 0);

		if(transform.position.x < this.deadLine){
			Destroy(gameObject);
		}
	}
	 void OnCollisionEnter2D(Collision2D other)
	{
		this.audioData = GetComponent<AudioSource>();
		if(other.gameObject.tag == "CubeTag" || other.gameObject.tag =="GroundTag")
		{
			this.audioData.Play(0);
		}
    }
}
