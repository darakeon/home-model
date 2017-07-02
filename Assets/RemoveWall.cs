using UnityEngine;
using System.Collections;

public class RemoveWall : MonoBehaviour
{
	void OnCollisionEnter(Collision collision)
	{
		collision.gameObject.renderer.enabled = false;
		Debug.Log(collision.gameObject.name);
	}

	void OnCollisionExit(Collision collision)
	{
		collision.gameObject.renderer.enabled = true;
		Debug.Log(collision.gameObject.name);
	}

	void OnTriggerEnter(Collider collider)
	{
		collider.gameObject.renderer.enabled = false;
		Debug.Log(collider.gameObject.name);
	}

	void OnTriggerExit(Collider collider)
	{
		collider.gameObject.renderer.enabled = true;
		Debug.Log(collider.gameObject.name);
	}
}
