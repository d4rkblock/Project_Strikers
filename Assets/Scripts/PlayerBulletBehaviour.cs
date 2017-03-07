using UnityEngine;
using System.Collections;

public class PlayerBulletBehaviour : BulletBase {

	// Use this for initialization
	void Start () {
		base.Start ();
	}
	
	// Update is called once per frame
	void Update () {
		base.Update ();
	}

	protected override void OnCollisionEnter (Collision collision) {
		if (collision.gameObject.tag == "Enemy") {
			Destroy (collision.gameObject);
		}
	}
}