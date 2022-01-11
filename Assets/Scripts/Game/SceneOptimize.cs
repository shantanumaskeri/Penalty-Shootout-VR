using UnityEngine;
using System.Collections;

public class SceneOptimize : MonoBehaviour 
{

	// Singleton instance
	public static SceneOptimize Instance;

	// public variables
	public float optimizeTime = 10.0f;

	// Use this for initialization
	void Start () 
	{
		Instance = this;

		Destroy (gameObject, optimizeTime);
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
