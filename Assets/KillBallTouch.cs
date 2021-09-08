using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillBallTouch : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame

    private void OnCollisionEnter(Collision collision) {
        PlayerActions pActions = collision.gameObject.GetComponent<PlayerActions>();
        if ( pActions != null) {
            pActions.Die();
        }
    }
}
