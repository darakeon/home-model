using UnityEngine;
using System.Collections;

public class Control : MonoBehaviour
{
	public float positionMoveUnit;
	public float rotationMoveUnit;
	
	private Vector3 initialPosition;
	private Vector3 initialRotation;
	
	
	void Start()
	{
		initialPosition = this.transform.position;
		initialRotation = this.transform.rotation.eulerAngles;
	}
	
	
	void Update ()
	{
		changePosition();
		changeRotation();
	}

	private void changePosition()
	{
		if (!Input.anyKey)
			return;

		var diff = Vector3.zero;
		var unit = positionMoveUnit;

		if (Input.GetKey(KeyCode.PageDown))
			diff.y -= unit;

		if (Input.GetKey(KeyCode.PageUp))
			diff.y += unit;

		if (Input.GetKey(KeyCode.LeftArrow))
			diff.x -= unit;

		if (Input.GetKey(KeyCode.RightArrow))
			diff.x += unit;

		if (Input.GetKey(KeyCode.DownArrow))
			diff.z -= unit;

		if (Input.GetKey(KeyCode.UpArrow))
			diff.z += unit;

		if (Input.GetKey(KeyCode.Q))
			diff = initialPosition - this.transform.position;

		this.transform.Translate(diff.x, diff.y, diff.z);
	}

	private void changeRotation()
	{
		if (!Input.anyKey)
			return;

		var diff = Vector3.zero;
		var unit = rotationMoveUnit;

		if (Input.GetKey(KeyCode.S))
			diff.x -= unit;

		if (Input.GetKey(KeyCode.W))
			diff.x += unit;

		if (Input.GetKey(KeyCode.A))
			diff.y -= unit;

		if (Input.GetKey(KeyCode.D))
			diff.y += unit;

		if (Input.GetKey(KeyCode.Q))
			diff = initialRotation - this.transform.rotation.eulerAngles;

		this.transform.Rotate(diff.x, diff.y, diff.z);
	}


}
