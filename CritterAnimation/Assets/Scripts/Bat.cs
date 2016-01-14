using UnityEngine;
using System.Collections;

public class Bat : MonoBehaviour {

	[SerializeField] private WingController _wingController;

	// Use this for initialization
	void Start () {
		
	}
		
	void OnMouseDown() {
		Debug.Log("BatAnimationScript.OnMouseDown");
		_wingController.GoToNextAnimationType();
	}
}
