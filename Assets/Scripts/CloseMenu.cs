using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.Events;

public class CloseMenu : MonoBehaviour
{

	private Toggle toggle;

	void Start ()
	{
		toggle = gameObject.GetComponent<Toggle> ();
	}

	// Função utilizada no event OnValueChanged de botões que abrem um menu
	// É utilizada para fechar outros menus que estiverem abertos
	public void CloseMenus ()
	{
		foreach (Transform child in transform.parent) {
			if (child.name != this.name) {
				Toggle toggle;
				if (toggle = child.GetComponent<Toggle> ()) {
					toggle.onValueChanged.SetPersistentListenerState (1, UnityEventCallState.Off);
					toggle.isOn = false;
					toggle.onValueChanged.SetPersistentListenerState (1, UnityEventCallState.RuntimeOnly);
				}
			}
		}

	}

	public void ClickInBackGround ()
	{
		toggle.isOn = false;
	}

}
