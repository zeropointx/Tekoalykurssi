using UnityEngine;
using System.Collections;



public class Punch : MonoBehaviour
{
	GameObject fist;

	// Use this for initialization
	void Start ()
	{
		fist = (GameObject)Instantiate (Resources.Load ("Fist")); // Luodaan nyrkki prefab.
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
}