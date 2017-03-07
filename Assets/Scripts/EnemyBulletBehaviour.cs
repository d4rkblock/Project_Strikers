using UnityEngine;
using System.Collections;

public class EnemyBulletBehaviour : BulletBase {

	// Use this for initialization
	void Start () {
		base.Start ();
	}
	
	// Update is called once per frame
	void Update () {
		base.Update ();
	}

	override protected void OnCollisionEnter (Collision collision) {
		if (collision.gameObject.tag == "Player") {
			var player = collision.gameObject.GetComponent<PlayerBehaviour> ();
			player.LosePointsOfLife (10);
		}
	}
}