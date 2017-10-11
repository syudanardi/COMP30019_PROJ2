﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GILighting : MonoBehaviour {
    public Renderer renderer;
	// Use this for initialization
	void Start () {
        renderer = GetComponent<Renderer>();

    }
	
	// Update is called once per frame
	void Update () {
        float intensity = 5.0f;
        Color final = Color.cyan * Mathf.LinearToGammaSpace(intensity);
        renderer.material.SetColor("_EmissionColor", final);
        renderer.UpdateGIMaterials();
        
    }
}
