using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BotaoAjuda : MonoBehaviour
{
	private Toggle toggle;

	// Use this for initialization
	void Start ()
	{
		toggle = GetComponent<Toggle> ();
		toggle.isOn = false;
	}
	
	// Update is called once per frame
	void Update ()
	{

	}

	public void AjudaClicked ()
	{
		foreach (Transform child in transform) {
			if (child.name == "Background")
				continue;

			child.gameObject.SetActive (toggle.isOn);
		}
	}
}
