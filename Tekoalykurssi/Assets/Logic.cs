using UnityEngine;
using System.Collections;
using System.Timers;

public class Logic : MonoBehaviour
{
	const float max_time = 2.0f; // Maksimiaika minkä nyrkki on kartalla.

	const float fist_speed = 1.0f; // Nyrkin nopeus.

	Transform player; // Pelaaja referenssi.

	float timer = 0.0f; // Lasketaan kulunutta aikaa.
	
	void Start ()
	{
		player = GameObject.Find("Player").transform;
	}

	void Update ()
	{
		// Mistä saa hahmon transformin?
		//Vector3 characterTransform = this.GetComponent<Transform> ().TransformVector; // Hahmon positio ja suunta.

		this.GetComponent<Rigidbody> ().AddForce (player.forward, ForceMode.Impulse); // Nyrkki liikkuu eteenpäin.



		timer += Time.deltaTime;

		if (timer > max_time)
			Destroy (this.gameObject); // Tuhotaan nyrkki.
	}
}