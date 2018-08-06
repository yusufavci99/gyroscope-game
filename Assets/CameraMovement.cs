using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {
    public GameObject Ball;
    private Vector3 offset;

	// Use this for initialization
	void Start () {
        offset = transform.position - Ball.transform.position;
        
    }
	
	// LateUpdate is called once per frame
	void LateUpdate () {
        transform.position = offset + Ball.transform.position;
	}
}
