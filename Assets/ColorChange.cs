using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour {

    [SerializeField]
    public GameObject[] gameObjects;

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ColorRed(GameObject gameObject)
    {
        gameObject.GetComponentInChildren<Renderer>().material.color = Color.red;
    }

    public void ColorGreen(GameObject gameObject)
    {
        gameObject.GetComponentInChildren<Renderer>().material.color = Color.green;
    }

    public void ColorBlue(GameObject gameObject)
    {
        gameObject.GetComponentInChildren<Renderer>().material.color = Color.blue;
    }
}
