using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour {
	private GameObject _tpPoint;
	private Transform _target;

	void Start() {
		_tpPoint = GameObject.Find("EnemyTP");
		_target = GameObject.Find("Player").transform;
	}

	void Update(){
		if (Input.GetKeyDown(KeyCode.T)){
			transform.position = _tpPoint.transform.position;
		}

		if (transform.position.y != 3.46f){
			transform.position = new Vector3(transform.position.x, 3.46f, transform.position.z);
			transform.LookAt(_target);
		}
	}
}
