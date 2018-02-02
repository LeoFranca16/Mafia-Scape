using UnityEngine;
using System.Collections;

public class WinReturn : MonoBehaviour {

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

}
