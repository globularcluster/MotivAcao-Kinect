using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ChangeLayerOrder : MonoBehaviour
{

	public GameObject btn;
	public GameObject lixos;


	public void ChangeLayers ()
	{
		if (btn.GetComponent<Toggle> ().isOn) {
			lixos.transform.SetParent (transform.parent);
		} else {
			lixos.transform.SetParent (transform);
		}
			
	}
}
