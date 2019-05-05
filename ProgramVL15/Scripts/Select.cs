using UnityEngine;
using System.Collections;

public class Select : MonoBehaviour {
	
	public Material m1;
	public Material m2;
	
	void OnMouseEnter() {
		GetComponent<Renderer> ().material = m1;
	}
	void OnMouseExit(){
		GetComponent<Renderer> ().material = m2;
	}
}
