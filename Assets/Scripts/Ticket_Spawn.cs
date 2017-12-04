using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ticket_Spawn : MonoBehaviour {

	public GameObject[] tickets;
	public Material sauce_;
	public Material cheese_;
	public Material roni_;
	public Material peppers_;
	public Material mushrooms_;
	public Material bacon_;

	public int randticket;
	public int ticketnum = 5;
	public int currentticket = 0;
	public int spawndelay;
	public static string[] order;

	void SpawnTicket(){
		tickets[currentticket].SetActive(true);
		switch (randticket) {
		case 1:
			//sauce pizza
			tickets[currentticket].GetComponent<Renderer> ().material = sauce_;
			order[currentticket] = "sauce";
			break;

		case 2:
			//cheese
			tickets[currentticket].GetComponent<Renderer> ().material = cheese_;
			order[currentticket] = "cheese";
			break;

		case 3:
			//roni
			tickets[currentticket].GetComponent<Renderer> ().material = roni_;
			order[currentticket] = "roni";
			break;

		case 4:
			//peppers
			tickets[currentticket].GetComponent<Renderer> ().material = peppers_;
			order[currentticket] = "peppers";
			break;

		case 5:
			//mush
			tickets[currentticket].GetComponent<Renderer> ().material = mushrooms_;
			order[currentticket] = "mushrooms";
			break;
		}
		currentticket = currentticket + 1;
	}


	void Start () {
		randticket = Random.Range (1, 5);
		spawndelay = Random.Range (10, 50);
		SpawnTicket();
	}
	

	void Update () {

	}
}
