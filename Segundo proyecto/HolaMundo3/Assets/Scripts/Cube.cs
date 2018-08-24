using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour {


    public bool DoRotation = false;
    public Vector3 move;
    // Use this for initialization
    void Start () {
		
	}

    private void OnMouseDown()
    {
        DoRotation = !DoRotation;
    }

    // Update is called once per frame
    void Update () {
        if (DoRotation) { 
            transform.Rotate(Vector3.up);
        }
    }
}
