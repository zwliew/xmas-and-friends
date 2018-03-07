﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EditorModeItem : MonoBehaviour, IRecycle {

	public int cost;
	public string fullName;
	public Sprite itemSprite;
	public Sprite selectedSprite;
	public Sprite unselectedSprite;
	public bool isBuyable;
	public bool isOnSale;
	public bool isSelected;
    public GameObject furniture;
	private Button itemButton;
	private EditorModeItem editorModeItem;
    public Vector3 position;
    public Vector3 rotation;

    public void Initialize(){
		itemButton = GetComponent<Button> ();
		editorModeItem = GetComponent<EditorModeItem> ();
		itemButton.gameObject.transform.GetChild(0).GetComponentInChildren<Image> ().sprite = itemSprite;
		itemButton.onClick.RemoveAllListeners ();
		itemButton.onClick.AddListener (()=>{SelectItem();});
		if (isSelected) {
			isSelected = false;
			SelectItem ();
			Debug.Log ("Setting this item as equipped");
		} else {
			Debug.Log ("did not set this item as equipped");
		}
	}

	public void SelectItem(){
		SendMessageUpwards ("SelectItem_Master", editorModeItem);
	}

	public void SetSelected(){
		Debug.Log (fullName + " is selected");
		itemButton.GetComponent<Image> ().sprite = selectedSprite;
		isSelected = true;

	}

	public void SetUnselected(){
		itemButton.GetComponent<Image> ().sprite = unselectedSprite;
		isSelected = false;
	}

	public void SetDisabled(){
		itemButton.onClick.RemoveAllListeners ();
		Debug.Log ("One item has been disabled");
	}

	public void Restart(){
	}
	public void Shutdown(){
	}
}
	
