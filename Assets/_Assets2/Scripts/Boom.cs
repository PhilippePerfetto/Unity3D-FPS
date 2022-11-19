using UnityEngine;
using System.Collections;

public class Boom : MonoBehaviour {

	public GameObject boom;
	public AudioClip son;

	void OnCollisionEnter(Collision col)
	{
		if(col.gameObject.name == "bullet")
		{
			GetComponent<AudioSource>().PlayOneShot(son);
			Instantiate(boom, this.transform.position, Quaternion.identity);
			Destroy(this.gameObject,0.6f);
		}
	}

}
