using UnityEngine;
using System.Collections;

public class ShowSelectedChar : MonoBehaviour {

	void Start () {
		// We just have to Instantiate a new GameObject based on the selected character
		GameObject.Instantiate(SelectCharStyled.charsPrefabsAux[SelectCharStyled.currentChar].gameObject, Vector3.zero, Quaternion.identity);
	}
	
	void OnGUI() {
		if (GUI.Button(new Rect(50, 50, 100, 50), "Back")) {
			Application.LoadLevel("main-styled");
		}
	}
	
}
