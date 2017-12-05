using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ticket_Spawn : MonoBehaviour
{

	public GameObject[] tickets;
	public string[] order;
	public Material sauce;
	public Material cheese;
	public Material roni;
	public Material peppers;
	public Material mushrooms;
	public Material bacon;

	public GameObject trash;
	public GameObject turninbox;

	public int randticket;
	public int ticketnum = 5;
	public int currentticket = 0;
	public int spawndelay;

	private bool iscorrect = false;
	public int strikes = 0;
	public int points = 0;

	void SpawnTicket ()
	{
		tickets [currentticket].SetActive (true);
		switch (randticket) {
		case 1:
			//sauce pizza
			tickets [currentticket].GetComponent<Renderer> ().material = sauce;
			order [currentticket] = "sauce";
			break;

		case 2:
			//cheese
			tickets [currentticket].GetComponent<Renderer> ().material = cheese;
			order [currentticket] = "cheese";
			break;

		case 3:
			//roni
			tickets [currentticket].GetComponent<Renderer> ().material = roni;
			order [currentticket] = "roni";
			break;

		case 4:
			//peppers
			tickets [currentticket].GetComponent<Renderer> ().material = peppers;
			order [currentticket] = "peppers";
			break;

		case 5:
			//mush
			tickets [currentticket].GetComponent<Renderer> ().material = mushrooms;
			order [currentticket] = "mushrooms";
			break;
		}
		currentticket = currentticket + 1;
	}


	void Start ()
	{
		randticket = Random.Range (1, 5);
		spawndelay = Random.Range (10, 50);
		SpawnTicket ();
	}


	void FixedUpdate ()
	{
		if (strikes == 3) {
				#if UNITY_EDITOR
				UnityEditor.EditorApplication.isPlaying = false;
				#else
				Application.Quit ();
				#endif
		}
	}


	void OnCollisionEnter (Collision col)
	{
		for (int i = 0; i < order.Length; i++) {
			if (order [i] == col.gameObject.GetComponent<Pizza_Controller> ().pizzatype) {
				iscorrect = true;
				break;
			}
			else {
				print ("nope");
				iscorrect = false;
			}
		}
		if (iscorrect == false) {
			strikes = strikes + 1;
			Destroy (col.gameObject);
		} else if (iscorrect == true){
			points = points + 1;
			Destroy (col.gameObject);
		}
	}
}
