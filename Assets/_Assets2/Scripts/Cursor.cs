using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Cursor : MonoBehaviour {

	public Image viseur;

	// Use this for initialization
	void Start () {
		Screen.lockCursor = true;
		UnityEngine.Cursor.visible = false;
	}
	
	// Update is called once per frame
	void Update () {

		RaycastHit hit;
		Vector3 fwd = transform.TransformDirection(Vector3.forward);
		if (Physics.Raycast(transform.position, fwd, out hit))
		{
			if(hit.transform.name == "Mob")
			{
				viseur.color = Color.red;
			}
			else{
				viseur.color = Color.white;
			}
		}

	}
}
