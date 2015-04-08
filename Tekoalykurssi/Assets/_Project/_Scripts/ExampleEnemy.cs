using UnityEngine;
using System.Collections;

public class ExampleEnemy : MonoBehaviour {
    Transform player;
	// Use this for initialization
	void Start () {
        player = GameObject.Find("Player").transform;
	}
	
	// Update is called once per frame
	void Update () {
	if(Vector3.Distance(transform.position,player.position) > 2.0f)
    {
        Quaternion tempRot = Quaternion.LookRotation(player.position-transform.position);
        tempRot.x = 0;
        tempRot.z = 0;
        transform.rotation = tempRot;
        this.transform.position += (player.position - transform.position).normalized * Time.deltaTime;
    }
	}
}
