using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Player : MonoBehaviour {

	public static int vie = 100;
	public static int munitions = 1000;
	public static bool hasCard = false;
	public GameObject[] weapons;
	public static int score = 0;

	void Start()
	{
		PlayerPrefs.SetString("lastlevel", Application.loadedLevelName);
	}

	void OnTriggerEnter(Collider col)
	{
		if(col.gameObject.name == "Card")
		{
			hasCard = true;
			Destroy(col.gameObject);
			weapons[0].SetActive(false);
			weapons[1].SetActive(true);
			PlayerPrefs.SetInt("carteok", 1);
		}

		else if(col.gameObject.name == "door")
		{
			if(hasCard)
			{
				Destroy(col.gameObject);
			}
			else
			{

			}
		}
	}

	void OnCollisionEnter(Collision col)
	{
		if(col.gameObject.name == "bullet")
		{
			vie = vie - Random.Range(5,15);
			int casevie = vie / 10;
			switch(casevie)
			{
			case 1:
					GameObject.Find("MaBarre").GetComponent<Text>().text = "-";
					break;
			case 2:
					GameObject.Find("MaBarre").GetComponent<Text>().text = "--";
					break;
			case 3:
					GameObject.Find("MaBarre").GetComponent<Text>().text = "---";
					break;
			case 4:
					GameObject.Find("MaBarre").GetComponent<Text>().text = "----";
					break;
			case 5:
					GameObject.Find("MaBarre").GetComponent<Text>().text = "-----";
					break;
			case 6:
					GameObject.Find("MaBarre").GetComponent<Text>().text = "------";
					break;
			case 7:
					GameObject.Find("MaBarre").GetComponent<Text>().text = "-------";
					break;
			case 8:
					GameObject.Find("MaBarre").GetComponent<Text>().text = "--------";
					break;
			case 9:
					GameObject.Find("MaBarre").GetComponent<Text>().text = "---------";
					break;
				default:
					GameObject.Find("MaBarre").GetComponent<Text>().text = "----------";
					break;
			}

			if(vie <= 0)
			{
				print ("Perdu !");
				Application.LoadLevel(Application.loadedLevel);
			}
		}
	}

}
