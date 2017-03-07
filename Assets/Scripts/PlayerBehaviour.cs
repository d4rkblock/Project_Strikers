using UnityEngine;
using System.Collections;
using System;

public class PlayerBehaviour : MonoBehaviour {

	public float playerSpeed = 5;
	public float timeToShoot = 1;

	public int lifePoints = 100;

	public PlayerBulletBehaviour bullet;

	private float _currentTimeToShoot;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.forward * playerSpeed);

		_currentTimeToShoot += Time.deltaTime;

		if (Input.GetKey (KeyCode.A))
			transform.position = PositionController.LeftPosition (transform.position.z);

		if (Input.GetKey (KeyCode.D))
			transform.position = PositionController.RightPosition (transform.position.z);

		if (!Input.anyKey)
			transform.position = PositionController.MiddlePosition (transform.position.z);

		if (Input.GetKeyDown (KeyCode.Space) || Input.GetKey (KeyCode.Space)) {

			if (_currentTimeToShoot >= timeToShoot) {
				Instantiate (bullet, transform.position, transform.rotation);
				_currentTimeToShoot = 0;
			}
		}
	}

    void OnGUI () {
		GUI.Label (new Rect(10, 10, 100, 20), "Health: " + lifePoints);
	}

	public void LosePointsOfLife(int damage) {
		lifePoints -= damage;
	}
}