using UnityEngine;
using System.Collections;

public class EnemyBehaviour : MonoBehaviour {

	public EnemyBulletBehaviour enemyBullet;
	public PlayerBehaviour target;

	public float enemySpeed = 0.5f;
	public float timeToShoot = 1;
	public float timeToLive = 2;

	private float _currentTimeToShoot;
	private float _currentTimeToLive;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.forward * enemySpeed);

		_currentTimeToShoot += Time.deltaTime;
		_currentTimeToLive += Time.deltaTime;

		if (_currentTimeToShoot >= timeToShoot) {
			Instantiate (enemyBullet, transform.position, transform.rotation);
			_currentTimeToShoot = 0;
		}

		if (_currentTimeToLive >= timeToLive)
			Destroy (gameObject);
	}
}