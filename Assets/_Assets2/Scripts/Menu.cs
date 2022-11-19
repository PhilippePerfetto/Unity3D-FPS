using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Menu : MonoBehaviour {


	public void LoadLevel(string l)
	{
		Application.LoadLevel(l);
	}

	public void LoadLastScene()
	{
		if(PlayerPrefs.GetString("lastlevel") != null && PlayerPrefs.GetString("lastlevel") != "")
		{
			Application.LoadLevel(PlayerPrefs.GetString("lastlevel"));
		}
		else{
			GameObject.Find("Continue").GetComponent<Button>().interactable = false;
		}
	}

	public void QuitGame()
	{
		Application.Quit();
	}

}
