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

	}

    void toppingChange() {
        if (psauce == true && pcheese != true && proni != true && pmush != true && pbacon != true && ppeppers != true) {
            pizza.GetComponent<Renderer>().material = sauce;
            pizzatype = "sauce";

        } else if (psauce == true && pcheese == true && proni != true && pmush != true && pbacon != true && ppeppers != true) {
            pizza.GetComponent<Renderer>().material = cheese;
            pizzatype = "cheese";

        } else if (psauce == true && pcheese == true && proni == true && pmush != true && pbacon != true && ppeppers != true) {
            pizza.GetComponent<Renderer>().material = roni;
            pizzatype = "roni";

        } else if (psauce == true && pcheese == true && ppeppers == true && pmush != true && pbacon != true && proni != true) {
            pizza.GetComponent<Renderer>().material = peppers;
            pizzatype = "peppers";

        } else if (psauce == true && pcheese == true && pmush == true && proni != true && pbacon != true && ppeppers != true) {
            pizza.GetComponent<Renderer>().material = mushrooms;
            pizzatype = "mushrooms";

        } else if (psauce == true && pcheese == true && pbacon == true && pmush != true && proni != true && ppeppers != true) {
            pizza.GetComponent<Renderer>().material = bacon;
			pizzatype = "bacon";

        } else if (psauce == true && pcheese == true && proni == true && ppeppers == true && pbacon != true && pmush != true) {
            pizza.GetComponent<Renderer>().material = roniandpeppers;
			pizzatype = "roniandpeppers";

        } else if (psauce == true && pcheese == true && proni == true && pmush == true && ppeppers != true && ppeppers != true) {
            pizza.GetComponent<Renderer>().material = roniandmush;
			pizzatype = "roniandmush";

        } else if (psauce == true && pcheese == true && proni == true && pbacon == true && pmush != true && ppeppers != true) {
            pizza.GetComponent<Renderer>().material = roniandbacon;
			pizzatype = "roniandbacon";

        } else if (psauce == true && pcheese == true && pmush == true && ppeppers == true && pbacon != true && proni != true) {
            pizza.GetComponent<Renderer>().material = peppersandmush;
			pizzatype = "peppersandmush";

        } else if (psauce == true && pcheese == true && pbacon == true && ppeppers == true && proni != true && pmush != true) {
            pizza.GetComponent<Renderer>().material = peppersandbacon;
			pizzatype = "peppersandbacon";

        } else if (psauce == true && pcheese == true && pmush == true && pbacon == true && proni != true && ppeppers != true) {
            pizza.GetComponent<Renderer>().material = baconandmush;
			pizzatype = "baconandmush";
 
        } else if (psauce == true && pcheese == true && proni == true && pbacon == true && ppeppers == true && pmush != true) {
            pizza.GetComponent<Renderer>().material = roniandbaconandpep;
			pizzatype = "roniandbaconandpep";

        } else if (psauce == true && pcheese == true && proni == true && pmush == true && pbacon == true && ppeppers != true) {
            pizza.GetComponent<Renderer>().material = roniandbaconandmush;
			pizzatype = "roniandbaconandmush";

        } else if (psauce == true && pcheese == true && proni == true && pmush == true && ppeppers == true && pbacon != true) {
            pizza.GetComponent<Renderer>().material = roniandPepandmush;
			pizzatype = "roniandPepandmush";

        } else if (psauce == true && pcheese == true && pmush == true && pbacon == true && ppeppers == true && proni != true) {
            pizza.GetComponent<Renderer>().material = mushandbaconandpep;
			pizzatype = "mushandbaconandpep";

        } else if (psauce == true && pcheese == true && proni == true && pmush == true && pbacon == true && ppeppers == true) {
            pizza.GetComponent<Renderer>().material = theworks;
			pizzatype = "theworks";

        }
    }

	void OnCollisionEnter (Collision col)
	{
		print ("col");
		GameObject other = col.gameObject;
		switch (other.tag) {
		case "sauce":
			Destroy (other);
			psauce = true;
			break;
		case "cheese":
			Destroy (other);
			if (psauce == true) {
				pcheese = true;
			}   
			break;
		case "roni":
			Destroy (other);
			if (psauce == true && pcheese == true) {
				proni = true;
			} 
			break;
		case "peppers":
			Destroy (other);
			if (psauce == true && pcheese == true) {
				ppeppers = true;
			} 
			break;
		case "mushrooms":
			Destroy (other);
			if (psauce == true && pcheese == true) {
				pmush = true;
			}
			break;
		case "bacon":
			Destroy (other);
			if (psauce == true && pcheese == true) {
				pbacon = true;
			}
			break;
		}
        toppingChange();
	}
}
