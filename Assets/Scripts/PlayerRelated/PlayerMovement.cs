using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Moves and rotates player
/// </summary>

public class PlayerMovement : MonoBehaviour 
{
	private float distance = 3;
	public float moveSpeed;

	private Vector3 moveInput;
	private Vector3 moveVelocity;

	private Rigidbody myRigidBody;


	void Start()
	{
		myRigidBody = GetComponent<Rigidbody>();
	}

	void Update()
	{
		{
			if (Input.GetKey(KeyCode.W)){
				transform.position = transform.position + Camera.main.transform.forward * distance * Time.deltaTime;
			}

			if (Input.GetKey(KeyCode.A)){
				transform.position = transform.position + -Camera.main.transform.right * distance * Time.deltaTime;
			}

			if (Input.GetKey(KeyCode.S)){
				transform.position = transform.position + -Camera.main.transform.forward * distance * Time.deltaTime;
			}

			if (Input.GetKey(KeyCode.D)){
				transform.position = transform.position + Camera.main.transform.right * distance * Time.deltaTime;
			}
			if (transform.position.y != 3.4f){
				transform.position = new Vector3(transform.position.x, 3.4f, transform.position.z);
			}
		}
	}

	void FixedUpdate()
	{
		myRigidBody.velocity = moveVelocity;
	}
}
