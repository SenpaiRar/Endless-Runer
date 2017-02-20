using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Backround : MonoBehaviour {

    public float scroolSpeed = 0.5f;
    public Renderer rend;
	void Start () {
        rend = GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update () {
        float offset = Time.time * scroolSpeed;
        rend.material.SetTextureOffset("_MainTex", new Vector2(offset, 0));
	}
}
