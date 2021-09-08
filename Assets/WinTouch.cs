using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinTouch : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision) {
        PlayerActions pActions = collision.gameObject.GetComponent<PlayerActions>();
        if (pActions != null) {
            pActions.Win();
        }
    }
}
