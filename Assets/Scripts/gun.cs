using UnityEngine;
using System.Collections;

public class gun : MonoBehaviour {

	public GameObject bulletPrefab;

	private void Update(){
	
		if (Input.GetMouseButtonDown (0)) {
		
			GameObject go = Instantiate(bulletPrefab,transform.position,transform.rotation) as GameObject;
			go.GetComponent<Rigidbody>().AddForce(transform.forward * 25,ForceMode.Impulse);

		}
	}

}
