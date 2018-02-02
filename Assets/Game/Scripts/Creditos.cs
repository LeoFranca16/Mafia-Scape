using UnityEngine;
using System.Collections;

public class Creditos : MonoBehaviour {

	public Texture2D background;
	public float duracao;
	private float contagem;
	private GUIStyle fonte;	
	// Use this for initialization
	void Start () {
		fonte = new GUIStyle();
		fonte.fontSize = 20;
		fonte.normal.textColor = Color.gray;
	}

	// Update is called once per frame
	void Update () {
		contagem += Time.deltaTime;
		if (contagem >= duracao) {
			Application.LoadLevel("Menu");
		}
	}

	void OnGUI() {
		GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), background);
		GUI.BeginGroup (new Rect(175,200, 250, 150));
		GUI.Label(new Rect(0, 0, 150, 20), "Leonardo França", fonte);
		GUI.Label(new Rect(0, 30, 150, 20), "Matheus Victor", fonte);
		GUI.Label(new Rect(0, 60, 150, 20), "Joadson Texeira", fonte);
		GUI.Label(new Rect(0, 90, 150, 20), "Vitor Augusto", fonte);
		GUI.EndGroup();
	}
}