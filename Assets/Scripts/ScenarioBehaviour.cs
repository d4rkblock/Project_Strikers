using UnityEngine;
using System.Collections;
using System.Linq;
using System.Collections.Generic;

public class ScenarioBehaviour : MonoBehaviour {

	private EnemyRespawnController enemyRespawn;
	private PlayerRespawnController playerRespawn;

	private PlayerBehaviour player;

	public float enemyTimeToLive = 3;
	private float _currentEnemyTimeToLive;

	public float timeToEnemyRespawn = 3;
	private float _currentTimeToEnemyRespawn;

	// Use this for initialization
	void Start () {
		enemyRespawn = GetComponent<EnemyRespawnController> ();
		playerRespawn = GetComponent<PlayerRespawnController> ();
	}
	
	// Update is called once per frame
	void Update () {
		_currentTimeToEnemyRespawn += Time.deltaTime;
		_currentEnemyTimeToLive += Time.deltaTime;

		if (_currentTimeToEnemyRespawn >= timeToEnemyRespawn) {
			enemyRespawn.InstantiateEnemy ();
			_currentTimeToEnemyRespawn = 0;
		}
		player = GetComponentInChildren<PlayerBehaviour> ();
	}
}