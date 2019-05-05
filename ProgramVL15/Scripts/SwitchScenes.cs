using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class SwitchScenes : MonoBehaviour {
	public void MySwitchScenes() {
        SceneManager.LoadScene("scene1");
    }
}