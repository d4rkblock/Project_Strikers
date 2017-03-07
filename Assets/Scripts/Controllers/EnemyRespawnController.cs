using UnityEngine;
using System.Collections;

public class EnemyRespawnController : MonoBehaviour {

	public EnemyBehaviour enemy;

	private GameObject playerPosition;

	// Use this for initialization
	void Start () {
		playerPosition = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		playerPosition = GameObject.FindGameObjectWithTag ("Player");


	}

	public void InstantiateEnemy() {
		if (playerPosition != null) {
			Instantiate (enemy, new Vector3 (playerPosition.transform.position.x, playerPosition.transform.position.y,
			                                 playerPosition.transform.position.z + 100), enemy.transform.rotation);
		}
	}
}