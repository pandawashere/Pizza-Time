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

	private bool iscorrect = false;
	public int strikes = 0;
	public int points = 0;


	void SpawnTicket ()
	{
		tickets [currentticket].SetActive (true);
			randticket = Random.Range (1, 6);
		} else {
			randticket = Random.Range (1, 17);
		}
		switch (randticket) {
		case 1:
			tickets [currentticket].GetComponent<Renderer> ().material = sauce;
			order [currentticket] = "sauce";
			break;

		case 2:
			tickets [currentticket].GetComponent<Renderer> ().material = cheese;
			order [currentticket] = "cheese";
			break;

		case 3:
			tickets [currentticket].GetComponent<Renderer> ().material = roni;
			order [currentticket] = "roni";
			break;

		case 4:
			tickets [currentticket].GetComponent<Renderer> ().material = peppers;
			order [currentticket] = "peppers";
			break;

		case 5:
			tickets [currentticket].GetComponent<Renderer> ().material = mushrooms;
			order [currentticket] = "mushrooms";
			break;

		case 6:
			tickets [currentticket].GetComponent<Renderer> ().material = bacon;
			order [currentticket] = "bacon";
			break;

		case 7:
			tickets [currentticket].GetComponent<Renderer> ().material = roniandbacon;
			order [currentticket] = "roniandbacon";
			break;

		case 8:
			tickets [currentticket].GetComponent<Renderer> ().material = roniandpeppers;
			order [currentticket] = "roniandpeppers";
			break;

		case 9:
			tickets [currentticket].GetComponent<Renderer> ().material = roniandmush;
			order [currentticket] = "roniandmush";
			break;

		case 10:
			tickets [currentticket].GetComponent<Renderer> ().material = peppersandmush;
			order [currentticket] = "peppersandmush";
			break;


		case 11:
			tickets [currentticket].GetComponent<Renderer> ().material = peppersandbacon;
			order [currentticket] = "peppersandbacon";
			break;

		case 12:
			tickets [currentticket].GetComponent<Renderer> ().material = baconandmush;
			order [currentticket] = "baconandmush";
			break;

		case 13:
			tickets [currentticket].GetComponent<Renderer> ().material = roniandbaconandpep;
			order [currentticket] = "roniandbaconandpep";
			break;

		case 14:
			tickets [currentticket].GetComponent<Renderer> ().material = roniandbaconandmush;
			order [currentticket] = "roniandbaconandmush";
			break;

		case 15:
			tickets [currentticket].GetComponent<Renderer> ().material = roniandPepandmush;
			order [currentticket] = "roniandPepandmush";
			break;

		case 16:
			tickets [currentticket].GetComponent<Renderer> ().material = mushandbaconandpep;
			order [currentticket] = "mushandbaconandpep";
			break;

		case 17:
			tickets [currentticket].GetComponent<Renderer> ().material = theworks;
			order [currentticket] = "theworks";
			break;

		}
		currentticket = currentticket + 1;

	}


	void Start ()
	{
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
				tickets [i].SetActive (false);
				order [i] = "done";
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
