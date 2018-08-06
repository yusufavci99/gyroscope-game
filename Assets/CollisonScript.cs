using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisonScript : MonoBehaviour {
    public PlayerControl Ball;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Ball")
        {
            Destroy(this.gameObject);
            Ball.speed = 100;
        }
    }
}
