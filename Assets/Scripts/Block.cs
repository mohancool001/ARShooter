using UnityEngine;
using System.Collections;

public class Block : MonoBehaviour {

	private Vector3 startPos;
	private float lastcheck;
	private bool hasFall;

	private void Start () {
	
		startPos = transform.position;
	}
	
	// Update is called once per frame
	private void Update () {

		if (hasFall)
			return;

		if (Time.time - lastcheck > 1) {
			lastcheck = Time.time;

			if (Vector3.Magnitude(transform.position - startPos) > 0.5f) {
				hasFall = true;
				GameManager.Instance.RemoveBlock (this.gameObject);
			}
		}
	}
}
