using UnityEngine;
using UnityEngine.SceneManagement;

public class CarregarCena : MonoBehaviour
{
	public void loadScene (string nomeDaCena)
	{
		SceneManager.LoadScene (nomeDaCena);
		Debug.Log ("carregando cena " + nomeDaCena);
	}
}
