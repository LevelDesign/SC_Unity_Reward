using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour {
	new Transform target;
	new float shoot_delay = 3.0f;
	new float cooldown = 5.0f;
	public GameObject bullet_prefab;
	public float shooting_range = 50f;

	// Use this for initialization
	void Start () {
		target = GameObject.FindWithTag("Player").transform;
	}

	void OnCollisionEnter ( )
	{
		GameObject.Destroy ( gameObject ) ;

	}
	// Update is called once per frame
	void Update () {
		transform.LookAt(target);
		cooldown -= Time.deltaTime;
		if (cooldown < 0 && Vector3.Distance(gameObject.transform.position, target.position) < shooting_range)  {
			cooldown = shoot_delay + Random.Range (0f, 2f);
			GameObject bullet = Instantiate (bullet_prefab, new Vector3 (transform.position.x, transform.position.y + 0.52f, transform.position.z), transform.rotation);
			Destroy (bullet, 3f);
		}
	}
}
