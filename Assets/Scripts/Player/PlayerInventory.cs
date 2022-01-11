using UnityEngine;
using System.Collections;

public class PlayerInventory : MonoBehaviour 
{

	// Singleton instance
	public static PlayerInventory Instance;

	// private variables
	Quaternion initialRotation;
	Vector3 initialPosition;

	// Use this for initialization
	void Start () 
	{
		Instance = this;

		initialRotation = transform.rotation;
		initialPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.Escape) || OVRGamepadController.GPC_GetButtonDown (OVRGamepadController.Button.B))
		{
			ResetPlayer ();
		}
	}

	void ResetPlayer ()
	{
		transform.position = initialPosition;
		transform.rotation = initialRotation;
	}
}
