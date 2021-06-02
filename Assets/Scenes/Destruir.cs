using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruir: MonoBehaviour {

	public GameObject versionDestruida;

	void Update()
	{
		if (Input.GetKeyDown("space"))
		{
			Instantiate(versionDestruida, transform.position, transform.rotation);
			Destroy(this.gameObject);
		}
	}

}
