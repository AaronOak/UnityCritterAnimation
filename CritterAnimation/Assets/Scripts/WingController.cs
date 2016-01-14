using UnityEngine;
using System.Collections;

public class WingController : MonoBehaviour {

	private enum AnimType {
		Idle,
		FlapLeftWing,
		FlapRightWing,
		FlapWingsVertically
	}

	private Animator _animator;
	private int _animType = (int)AnimType.Idle;

	// Use this for initialization
	void Start () {
		_animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (_animator.GetInteger("animType") != _animType) {
			_animator.SetInteger("animType", _animType);
		}
	}

	public void GoToNextAnimationType() {
		_animType++;
		if (_animType > (int)AnimType.FlapWingsVertically) {
			_animType = (int)AnimType.Idle;
		}
	}
}
