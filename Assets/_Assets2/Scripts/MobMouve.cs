using UnityEngine;
using System.Collections;

public class MobMouve : MonoBehaviour {

	private Transform target;
	private UnityEngine.AI.NavMeshAgent agent;
	public static string nomObj;
	Animator anim;
	private bool fin = false;
	public static bool danger = false;

	public GameObject[] destinations;
	
	void Awake () {
		nomObj = "Centre";
		agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
		GameObject centre = GameObject.Find(nomObj);
		target = centre.transform;
	}
	
	void Start() {
		anim = GetComponent<Animator>();
		anim.SetBool("isWalking",true);
		UnityEngine.AI.NavMeshPath path = new UnityEngine.AI.NavMeshPath();
		agent.destination = target.position;
	}

	void Update(){

		if(!Mob.isDead)
		{
			if(danger)
			{
				setNewDestination("Cache");
			}

			else if (agent.pathStatus==UnityEngine.AI.NavMeshPathStatus.PathComplete && 
			    agent.remainingDistance <= 0.5f)
			{
				anim.SetBool("isWalking",false);
				if(fin == false)
				{
					fin = true;
					string dest = destinations[Random.Range(0,destinations.Length)].name;
					setNewDestination(dest);
				}
				}

		}
	}

	void setNewDestination(string d)
	{
		nomObj = d;
		GameObject centre = GameObject.Find(nomObj);
		target = centre.transform;
		anim.SetBool("isWalking",true);
		UnityEngine.AI.NavMeshPath path = new UnityEngine.AI.NavMeshPath();
		agent.destination = target.position;
		fin = false;
	}
}