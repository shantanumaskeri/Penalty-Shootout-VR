using UnityEngine;
using System.Collections;
using UnityEngine.VR;

public class VRConfiguration : MonoBehaviour 
{

	// Singleton instance;
	public static VRConfiguration Instance;

	// Use this for initialization
	void Start () 
	{
		Instance = this;

		VRSettings.enabled = true;
		Cursor.visible = false;
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
