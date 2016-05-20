using System.Reflection;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DropMe : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler
{
	public Image containerImage;
	public Image receivingImage;
	private Color normalColor;
	public Color highlightColor = Color.yellow;

	public void OnEnable ()
	{
		if (containerImage != null)
			normalColor = containerImage.color;
	}

	public void OnDrop (PointerEventData data)
	{
		if (receivingImage == null)
			return;

//		Sprite dropSprite = GetDropSprite (data);
//		if (dropSprite != null) 
////			receivingImage.overrideSprite = dropSprite;
//
//			EraseDropSprite (data);

//		Color c = receivingImage.color;
//		c.a = 255;
//		receivingImage.color = c;
	}

	public void OnPointerEnter (PointerEventData data)
	{
		if (containerImage == null)
			return;

		Sprite dropSprite = GetDropSprite (data);
		if (dropSprite != null)
			containerImage.color = highlightColor;
		else
			Debug.Log ("dropSprite null");
               
	}

	public void OnPointerExit (PointerEventData data)
	{
		if (containerImage == null)
			return;
		
		containerImage.color = normalColor;
	}

	private Sprite GetDropSprite (PointerEventData data)
	{
		var originalObj = data.pointerDrag;
		if (originalObj == null)
			return null;
		
		var dragMe = originalObj.GetComponent<DragMe> ();
		if (dragMe == null)
			return null;
		
		var srcImage = originalObj.GetComponent<Image> ();
		if (srcImage == null)
			return null;
		
		return srcImage.sprite;
	}

	private void EraseDropSprite (PointerEventData data)
	{
		GameObject go = data.pointerDrag;

		Color c = go.GetComponent<Image> ().color;
		c.a = 0;
		go.GetComponent<Image> ().color = c;

//		go.SetActive (false);
	}
}
