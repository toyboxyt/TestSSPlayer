using UnityEngine;
using System.Collections;

public class testss : MonoBehaviour {
	public SsSprite sprite;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("up")) {
			sprite.Play();
			print ("up arrow key is held down");
		}
		if (Input.GetKey ("down")) {
			sprite.Pause();
			print ("down arrow key is held down");
		}
	}


}
