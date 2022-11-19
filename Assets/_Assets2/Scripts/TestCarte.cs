using UnityEngine;
using System.Collections;

public class TestCarte : MonoBehaviour {

	void Start () {
		if(PlayerPrefs.GetInt("carteok") == 1)
		{
			this.gameObject.SetActive(false);
		}
	}
	

}
