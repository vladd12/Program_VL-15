using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ClickObject : MonoBehaviour {
	
	public bool click = false;
	public GameObject UIObject;
	
	void Start () {
		UIObject.SetActive(false);
	}
	
	void Update () {
		if (click == true) {
			Debug.Log("UIObject = true");
			UIObject.SetActive(true);
		}
		else UIObject.SetActive(false);
	}
	
	void OnMouseDown() {
		if (click == false) {
			Debug.Log("Click = true");
			click = true;
			if (UnityEngine.EventSystems.EventSystem.current.IsPointerOverGameObject()) {
				HideUI();
			}
		}
	}
	
	public void HideUI() {
		Debug.Log("Click = false, UIObject = false");
		click = false;
	}
}