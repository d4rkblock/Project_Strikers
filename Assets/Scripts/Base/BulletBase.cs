using UnityEngine;
using System.Collections;

public abstract class BulletBase : MonoBehaviour {

	public float bulletSpeed = 10;
	public float timeOnScene = 5;

	private float _currentTimeOnScene;

	protected abstract void OnCollisionEnter (Collision collision);

	// Use this for initialization
	protected void Start () {
		
	}
	
	// Update is called once per frame
	protected void Update () {
		_currentTimeOnScene += Time.deltaTime;

		transform.Translate (Vector3.forward * bulletSpeed);

		if (_currentTimeOnScene > timeOnScene)
			Destroy (gameObject);
	}
}