using UnityEngine;
using System.Collections;

public class SelectThree : MonoBehaviour {
	
	public Material[] mats;
	public GameObject NameObject;
	public Material m11;
	public Material m12;
	public Material m13;
	public Material m21;
	public Material m22;
	public Material m23;
	
	void OnMouseEnter() {
		var nameRenderer = NameObject.GetComponent<Renderer>();
		var mats = nameRenderer .sharedMaterials;
		mats [0] = m11;
		mats [1] = m12;
		mats [2] = m13;
		nameRenderer.sharedMaterials = mats;
	}
	void OnMouseExit(){
		var nameRenderer = NameObject.GetComponent<Renderer>();
		var mats = nameRenderer .sharedMaterials;
		mats [0] = m21;
		mats [1] = m22;
		mats [2] = m23;
		nameRenderer.sharedMaterials = mats;
	}
}
