using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Node : MonoBehaviour {

	
	public Transform cameraPosition;
	public List<Node> reachableNodes = new List<Node>() ; //list for nodes

	[HideInInspector]
	public Collider2D col;


	// Use this for initialization
	void Start () {
		col = GetComponent<Collider2D>();


	}

	void onMouseDown() {

		Camera.main.transform.position = cameraPosition.position;
		Camera.main.transform.rotation = cameraPosition.rotation;


	}

	
	
}
