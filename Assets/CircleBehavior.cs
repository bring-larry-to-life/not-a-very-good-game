using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CircleBehavior : MonoBehaviour {

	void Start() {
		print("GAME STARTED");
	}

	void Update() {

	}

	void OnMouseDown() {
		print("COMPONENT CLICKED");
		SceneManager.LoadScene("circle");
		//gameObject.GetComponent<Renderer>().material.color = UnityEngine.Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
	}

}