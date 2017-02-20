using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour {
    public float speed;
	void Start () {
 
	}
	
	void Update () {
        
        transform.position = transform.position + new Vector3(speed * Time.deltaTime, 0, 0);
	}
}
