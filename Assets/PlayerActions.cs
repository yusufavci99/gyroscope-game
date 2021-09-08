using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerActions : MonoBehaviour
{

    public GameObject displayMessage;
    public Canvas cv;
    public Rigidbody rb;

    private void Start() {
        rb = GetComponent<Rigidbody>();
    }

    public void Win() {

        SceneManager.LoadScene("WinScene");
    }

    public void Die() {
        transform.position = new Vector3(3f, 0.5f, 3f);
        rb.velocity = new Vector3(0f, 0f, 0f);

        GameObject go = Instantiate(displayMessage);
        go.transform.SetParent(cv.transform);
    }
}
