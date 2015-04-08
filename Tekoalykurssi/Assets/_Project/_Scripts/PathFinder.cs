using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class PathFinder : MonoBehaviour {
    List<Vector3> waypoints = new List<Vector3>();
	// Use this for initialization
	void Start () {
	    for(int i = 0; i <  GameObject.Find("PathMap").transform.childCount; i++)
        {
            waypoints.Add(GameObject.Find("PathMap").transform.GetChild(i).position);
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
