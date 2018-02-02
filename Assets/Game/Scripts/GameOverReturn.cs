using UnityEngine;
using System.Collections;

public class GameOverReturn : MonoBehaviour {

	public Texture2D background;
	public float duracao;
	private float contagem;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		contagem += Time.deltaTime;
		if (contagem >= duracao) {
			Application.LoadLevel("Menu");
		}
	}

	void OnGUI() {
		GUI.DrawTexture (new Rect(0, 0, Screen.width, Screen.height), background);
	}
}