﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Ticket_Spawn : MonoBehaviour
{

	public GameObject[] tickets;
	public string[] order;
	public Material cheese;
	public Material roni;
	public Material peppers;
	public Material mushrooms;
	public Material bacon;
	public Material roniandbacon;
	public Material roniandpeppers;
	public Material roniandmush;
	public Material peppersandmush;
	public Material peppersandbacon;
	public Material baconandmush;
	public Material roniandbaconandpep;
	public Material roniandbaconandmush;
	public Material roniandPepandmush;
	public Material mushandbaconandpep;
	public Material theworks;

	public int randticket;
	public int ticketnum = 5;
	public int currentticket = 0;
	public int spawndelay;

    //public AudioSource pizzaTime;
    public Transform audioPlay;

	private bool iscorrect = false;
	public int strikes = 0;
	public int points = 0;

	public Text scoreText;
	public Text strikeText;
	public Text winText;

	public string ezmode = "";

	void SpawnTicket ()
	{
		tickets [currentticket].SetActive (true);
		if (ezmode == "yes") {
			randticket = Random.Range (1, 6);
		} else {
			randticket = Random.Range (1, 16);
		}
		switch (randticket) {
		case 1:
			tickets [currentticket].GetComponent<Renderer> ().material = cheese;
			order [currentticket] = "cheese";
			break;

		case 2:
			tickets [currentticket].GetComponent<Renderer> ().material = roni;
			order [currentticket] = "roni";
			break;

		case 3:
			tickets [currentticket].GetComponent<Renderer> ().material = peppers;
			order [currentticket] = "peppers";
			break;

		case 4:
			tickets [currentticket].GetComponent<Renderer> ().material = mushrooms;
			order [currentticket] = "mushrooms";
			break;

		case 5:
			tickets [currentticket].GetComponent<Renderer> ().material = bacon;
			order [currentticket] = "bacon";
			break;

		case 6:
			tickets [currentticket].GetComponent<Renderer> ().material = roniandbacon;
			order [currentticket] = "roniandbacon";
			break;

		case 7:
			tickets [currentticket].GetComponent<Renderer> ().material = roniandpeppers;
			order [currentticket] = "roniandpeppers";
			break;

		case 8:
			tickets [currentticket].GetComponent<Renderer> ().material = roniandmush;
			order [currentticket] = "roniandmush";
			break;

		case 9:
			tickets [currentticket].GetComponent<Renderer> ().material = peppersandmush;
			order [currentticket] = "peppersandmush";
			break;


		case 10:
			tickets [currentticket].GetComponent<Renderer> ().material = peppersandbacon;
			order [currentticket] = "peppersandbacon";
			break;

		case 11:
			tickets [currentticket].GetComponent<Renderer> ().material = baconandmush;
			order [currentticket] = "baconandmush";
			break;

		case 12:
			tickets [currentticket].GetComponent<Renderer> ().material = roniandbaconandpep;
			order [currentticket] = "roniandbaconandpep";
			break;

		case 13:
			tickets [currentticket].GetComponent<Renderer> ().material = roniandbaconandmush;
			order [currentticket] = "roniandbaconandmush";
			break;

		case 14:
			tickets [currentticket].GetComponent<Renderer> ().material = roniandPepandmush;
			order [currentticket] = "roniandPepandmush";
			break;

		case 15:
			tickets [currentticket].GetComponent<Renderer> ().material = mushandbaconandpep;
			order [currentticket] = "mushandbaconandpep";
			break;

		case 16:
			tickets [currentticket].GetComponent<Renderer> ().material = theworks;
			order [currentticket] = "theworks";
			break;

		}
		currentticket = currentticket + 1;
		spawndelay = Random.Range (10, 25);

	}


	void Start ()
	{
		SetScoreText ();
		StartCoroutine (TicketSpawn ());
	}

	IEnumerator TicketSpawn()
	{
		SpawnTicket ();
		yield return new WaitForSeconds(spawndelay);
		SpawnTicket ();
		yield return new WaitForSeconds(spawndelay);
		SpawnTicket ();
		yield return new WaitForSeconds(spawndelay);
		SpawnTicket ();
		yield return new WaitForSeconds(spawndelay);
		SpawnTicket ();
		yield return new WaitForSeconds(spawndelay);
		SpawnTicket ();

	}

    void FixedUpdate() { }
	void SetScoreText()
	{
		scoreText.text = "Correct Pizzas: " + points + "/6";
		strikeText.text = "Strikes: " + strikes + "/3";
		if (points == 6) {
			winText.text= "YOU WIN!";
		}
		if (strikes == 3) {
			winText.text = "YOU LOSE!";
		}

	}



	void OnCollisionEnter (Collision col)
	{
		for (int i = 0; i < order.Length; i++) {
			if (order [i] == col.gameObject.GetComponent<Pizza_Controller> ().pizzatype) {
				iscorrect = true;
				tickets [i].SetActive (false);
				order [i] = "done";
				break;
			}
			else {
				print ("nope");
				iscorrect = false;
			}
		}
		if (iscorrect == true && col.gameObject.tag == "dough") {
            points = points + 1;
            SetScoreText ();
			Destroy (col.gameObject);
		}  else if (iscorrect == false && col.gameObject.tag == "dough") {
            strikes = strikes + 1;
            SetScoreText ();
			Destroy (col.gameObject);
		}
	}
}
