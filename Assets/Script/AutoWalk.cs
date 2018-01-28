using UnityEngine;
using System.Collections;

public class AutoWalk : MonoBehaviour {
	public int speed = 2;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = transform.position + Camera.main.transform.forward * speed * Time.deltaTime;
	}
}
