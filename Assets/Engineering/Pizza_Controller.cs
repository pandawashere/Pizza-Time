using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class Pizza_Controller : MonoBehaviour
{

	public Pizza_Controller S;
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
	public Material dough;
	public Material burnt;
	public Material cooked;
	public GameObject pizza;
	public bool psauce = false;
	public bool pcheese = false;
	public bool proni = false;
	public bool ppeppers = false;
	public bool pmush = false;
	public bool pbacon = false;
	public string pizzatype = "dough";

	void Awake ()
	{
		S = this;
	}

	void Start ()
	{
		pizza.GetComponent<Renderer> ().material = dough;
	}

	
	void Update ()
	{
		if (psauce == true && pcheese != true && proni != true && pmush != true && pbacon != true && ppeppers != true) {
			pizza.GetComponent<Renderer> ().material = sauce;
			pizzatype = "sauce";
			//-----------------------------------------------------------------sauce--------------------------------------------------------------------------------------------------
		} else if (psauce == true && pcheese == true && proni != true && pmush != true && pbacon != true && ppeppers != true) {
			pizza.GetComponent<Renderer> ().material = cheese;
			pizzatype = "cheese";
			//-----------------------------------------------------------------cheese---------------------------------------------------------------------------------------------------------------
		} else if (psauce == true && pcheese == true && proni == true && pmush != true && pbacon != true && ppeppers != true) {
			pizza.GetComponent<Renderer> ().material = roni;
			pizzatype = "roni";
			//-----------------------------------------------------------------roni--------------------------------------------------------------------------------------------------------------
		} else if (psauce == true && pcheese == true && ppeppers == true && pmush != true && pbacon != true && proni != true) {
			pizza.GetComponent<Renderer> ().material = peppers;
			pizzatype = "peppers";
			//-----------------------------------------------------------------peppers-------------------------------------------------------------------------------------------------------------
		} else if (psauce == true && pcheese == true && pmush == true && proni != true && pbacon != true && ppeppers != true) {
			pizza.GetComponent<Renderer> ().material = mushrooms;
			pizzatype = "mushrooms";
			//-----------------------------------------------------------------mushroom------------------------------------------------------------------------------------------------------------
		} else if (psauce == true && pcheese == true && pbacon == true && pmush != true && proni != true && ppeppers != true) {
			pizza.GetComponent<Renderer> ().material = bacon;
			//-----------------------------------------------------------------bacon------------------------------------------------------------------------------------------------------------
		} else if (psauce == true && pcheese == true && proni == true && ppeppers == true && pbacon != true && pmush != true) {
			pizza.GetComponent<Renderer> ().material = roniandpeppers;
			//-----------------------------------------------------------------roni_peps------------------------------------------------------------------------------------------------------------
		} else if (psauce == true && pcheese == true && proni == true && pmush == true && ppeppers != true && ppeppers != true) {
			pizza.GetComponent<Renderer> ().material = roniandmush;
			//-----------------------------------------------------------------roni_mush------------------------------------------------------------------------------------------------------------
		} else if (psauce == true && pcheese == true && proni == true && pbacon == true && pmush != true && ppeppers != true) {
			pizza.GetComponent<Renderer> ().material = roniandbacon;
			//-----------------------------------------------------------------roni_Bacon------------------------------------------------------------------------------------------------------------
		} else if (psauce == true && pcheese == true && pmush == true && ppeppers == true && pbacon != true && proni != true) {
			pizza.GetComponent<Renderer> ().material = peppersandmush;
			//-----------------------------------------------------------------pep_mush------------------------------------------------------------------------------------------------------------
		} else if (psauce == true && pcheese == true && pbacon == true && ppeppers == true && proni != true && pmush != true) {
			pizza.GetComponent<Renderer> ().material = peppersandbacon;
			//-----------------------------------------------------------------pep_bacon------------------------------------------------------------------------------------------------------------
		} else if (psauce == true && pcheese == true && pmush == true && pbacon == true && proni != true && ppeppers != true) {
			pizza.GetComponent<Renderer> ().material = baconandmush;
			//-----------------------------------------------------------------mush_bac------------------------------------------------------------------------------------------------------------
		} else if (psauce == true && pcheese == true && proni == true && pbacon == true && ppeppers == true && pmush != true) {
			pizza.GetComponent<Renderer> ().material = roniandbaconandpep;
			//-----------------------------------------------------------------roni_bacon_pep------------------------------------------------------------------------------------------------------------
		} else if (psauce == true && pcheese == true && proni == true && pmush == true && pbacon == true && ppeppers != true) {
			pizza.GetComponent<Renderer> ().material = roniandbaconandmush;
			//-----------------------------------------------------------------roni_bacon_mush------------------------------------------------------------------------------------------------------------
		} else if (psauce == true && pcheese == true && proni == true && pmush == true && ppeppers == true && pbacon != true) {
			pizza.GetComponent<Renderer> ().material = roniandPepandmush;
			//-----------------------------------------------------------------roni_pep_mush------------------------------------------------------------------------------------------------------------
		} else if (psauce == true && pcheese == true && pmush == true && pbacon == true && ppeppers == true && proni != true) {
			pizza.GetComponent<Renderer> ().material = mushandbaconandpep;
			//-----------------------------------------------------------------bac_mush_pep------------------------------------------------------------------------------------------------------------
		} else if (psauce == true && pcheese == true && proni == true && pmush == true && pbacon == true && ppeppers == true) {
			pizza.GetComponent<Renderer> ().material = theworks;
			//-----------------------------------------------------------------works------------------------------------------------------------------------------------------------------------
		}
	}

	void OnCollisionEnter (Collision col)
	{
		print ("col");
		GameObject other = col.gameObject;
		switch (other.tag) {
		case "sauce":
                //pizza.GetComponent<Renderer>().material = sauce;
			Destroy (other);
			psauce = true;
			AutoSpawn.spawnnum = AutoSpawn.spawnnum - 1;
			break;
		case "cheese":
                //pizza.GetComponent<Renderer>().material = cheese;
			Destroy (other);
			if (psauce == true) {
				pcheese = true;
			}
			AutoSpawn.spawnnum = AutoSpawn.spawnnum - 1;   
			break;
		case "roni":
                //pizza.GetComponent<Renderer>().material = roni;
			Destroy (other);
			if (psauce == true && pcheese == true) {
				proni = true;
			}
			AutoSpawn.spawnnum = AutoSpawn.spawnnum - 1;  
			break;
		case "peppers":
                //pizza.GetComponent<Renderer>().material = peppers;
			Destroy (other);
			if (psauce == true && pcheese == true) {
				ppeppers = true;
			}
			AutoSpawn.spawnnum = AutoSpawn.spawnnum - 1;  
			break;
		case "mushrooms":
                //pizza.GetComponent<Renderer>().material = mushrooms;
			Destroy (other);
			if (psauce == true && pcheese == true) {
				pmush = true;
			}
			AutoSpawn.spawnnum = AutoSpawn.spawnnum - 1;  
			break;
		case "bacon":
                //pizza.GetComponent<Renderer>().material = bacon;
			Destroy (other);
			if (psauce == true && pcheese == true) {
				pbacon = true;
			}
			AutoSpawn.spawnnum = AutoSpawn.spawnnum - 1; 
			break;
		}
	}
}
