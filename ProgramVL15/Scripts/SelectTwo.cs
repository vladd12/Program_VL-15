using UnityEngine;
using System.Collections;

public class SelectTwo : MonoBehaviour {
	
	public Material[] mats;
	public GameObject NameObject;
	public Material m11;
	public Material m12;
	public Material m21;
	public Material m22;
	
	void OnMouseEnter() {
		var nameRenderer = NameObject.GetComponent<Renderer>();
		var mats = nameRenderer .sharedMaterials;
		mats [0] = m11;
		mats [1] = m12;
		nameRenderer.sharedMaterials = mats;
	}
	void OnMouseExit(){
		var nameRenderer = NameObject.GetComponent<Renderer>();
		var mats = nameRenderer .sharedMaterials;
		mats [0] = m21;
		mats [1] = m22;
		nameRenderer.sharedMaterials = mats;
	}
}
