using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexagonBehavior : MonoBehaviour {

	void Start() {
		print("GAME STARTED");
	}

	void Update() {

	}

	void OnMouseDown() {
		print("COMPONENT CLICKED");
		gameObject.GetComponent<Renderer>().material.color = UnityEngine.Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
	}

}