using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {

	public Texture2D background;
	public Texture2D titulo;


	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void OnGUI() {

		GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), background);
		GUI.DrawTexture (new Rect (225, 50, 150, 40), titulo);

		GUI.BeginGroup (new Rect(240,150, 120, 120));
		if (GUI.Button (new Rect (20, 30, 50, 20), "Iniciar")) {
			Application.LoadLevel("Scene");
		}

		if (GUI.Button (new Rect (20, 60, 70, 20), "Sair")) {
            Application.Quit();		
		
			GUI.EndGroup();
	}
}

}