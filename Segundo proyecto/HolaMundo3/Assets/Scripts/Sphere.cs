using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour {

    // Use this for initialization
    public float moveX;
    public Vector3 move;

    Color GetRandomColor() {
        float r = Random.Range(0.0f, 1.0f);
        float g = Random.Range(0.0f, 1.0f);
        float b = Random.Range(0.0f, 1.0f);
        return new Color(r,g,b);
    }

    void ChangeColor() {
        gameObject.GetComponent<Renderer>().material.color = this.GetRandomColor();
    }


    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space)) {
            this.ChangeColor();
        }

        if (Input.GetKeyDown(KeyCode.RightArrow)){
            this.gameObject.transform.Translate(move);
        }
	}

    void OnMouseDown(){
        this.ChangeColor();
    }


}
