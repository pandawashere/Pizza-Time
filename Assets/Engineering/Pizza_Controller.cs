using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class Pizza_Controller : MonoBehaviour
{
    public float cookTime = 0;
    public float doneTime = 10;
    public float burntTime = 20;
    public bool isCooked = false;
    public bool isBurned = false;

	public Pizza_Controller S;

    public Material active;
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
    
	void Start () {
        S = this;
        active = dough;
	}

    void ToppingChange() {
        int caseSwitch = 0;
        if (isCooked != true && isBurned != true) caseSwitch = 1;
        if (isCooked == true && isBurned != true) caseSwitch = 2;
        if (isCooked == true && isBurned == true) caseSwitch = 3;
        switch (caseSwitch) {
               case 1:
                    if (psauce == true && pcheese != true && proni != true && pmush != true && pbacon != true && ppeppers != true) {
                        active = sauce;
                        pizzatype = "sauce";
                    } else if (psauce == true && pcheese == true && proni != true && pmush != true && pbacon != true && ppeppers != true) {
                        active = cheese;
                        pizzatype = "cheese";
                    } else if (psauce == true && pcheese == true && proni == true && pmush != true && pbacon != true && ppeppers != true) {
                        active = roni;
                        pizzatype = "roni";
                    } else if (psauce == true && pcheese == true && ppeppers == true && pmush != true && pbacon != true && proni != true) {
                        active = peppers;
                        pizzatype = "peppers";
                    } else if (psauce == true && pcheese == true && pmush == true && proni != true && pbacon != true && ppeppers != true) {
                        active = mushrooms;
                        pizzatype = "mushrooms";
                    } else if (psauce == true && pcheese == true && pbacon == true && pmush != true && proni != true && ppeppers != true) {
                        active = bacon;
                        pizzatype = "bacon";
                    } else if (psauce == true && pcheese == true && proni == true && ppeppers == true && pbacon != true && pmush != true) {
                        active = roniandpeppers;
                        pizzatype = "roniandpeppers";
                    } else if (psauce == true && pcheese == true && proni == true && pmush == true && ppeppers != true && ppeppers != true) {
                        active = roniandmush;
                        pizzatype = "roniandmush";
                    } else if (psauce == true && pcheese == true && proni == true && pbacon == true && pmush != true && ppeppers != true) {
                        active = roniandbacon;
                        pizzatype = "roniandbacon";
                    } else if (psauce == true && pcheese == true && pmush == true && ppeppers == true && pbacon != true && proni != true) {
                        active = peppersandmush;
                        pizzatype = "peppersandmush";
                    } else if (psauce == true && pcheese == true && pbacon == true && ppeppers == true && proni != true && pmush != true) {
                        active = peppersandbacon;
                        pizzatype = "peppersandbacon";
                    } else if (psauce == true && pcheese == true && pmush == true && pbacon == true && proni != true && ppeppers != true) {
                        active = baconandmush;
                        pizzatype = "baconandmush";
                    } else if (psauce == true && pcheese == true && proni == true && pbacon == true && ppeppers == true && pmush != true) {
                        active = roniandbaconandpep;
                        pizzatype = "roniandbaconandpep";
                    } else if (psauce == true && pcheese == true && proni == true && pmush == true && pbacon == true && ppeppers != true) {
                        active = roniandbaconandmush;
                        pizzatype = "roniandbaconandmush";
                    } else if (psauce == true && pcheese == true && proni == true && pmush == true && ppeppers == true && pbacon != true) {
                        active = roniandPepandmush;
                        pizzatype = "roniandPepandmush";
                    } else if (psauce == true && pcheese == true && pmush == true && pbacon == true && ppeppers == true && proni != true) {
                        active = mushandbaconandpep;
                        pizzatype = "mushandbaconandpep";
                    } else if (psauce == true && pcheese == true && proni == true && pmush == true && pbacon == true && ppeppers == true) {
                        active = theworks;
                        pizzatype = "theworks";
                    }
                    break;
                case 2:
                    active = cooked;
                    break;
                case 3:
                    active = burnt;
                    break;
            }        
    }

    void Cook() {
        cookTime += Time.deltaTime;
        if (cookTime >= doneTime && cookTime <= burntTime)
            isCooked = true;
        else if (cookTime >= burntTime)
            isBurned = true;
        ToppingChange();
    }
    void OnTriggerStay(Collider col) {
        GameObject other = col.gameObject;
        switch (other.tag) {            
		case "oven":
            Cook();
			break;
        }
    }
    void OnCollisionEnter(Collision col) {
        GameObject other = col.gameObject;
        if (isCooked == false) {
            switch (other.tag) {
                case "sauce":
                    Destroy(other);
                    psauce = true;
                    break;
                case "cheese":
                    Destroy(other);
                    if (psauce == true) {
                        pcheese = true;
                    }
                    break;
                case "roni":
                    Destroy(other);
                    if (psauce == true && pcheese == true) {
                        proni = true;
                    }
                    break;
                case "peppers":
                    Destroy(other);
                    if (psauce == true && pcheese == true) {
                        ppeppers = true;
                    }
                    break;
                case "mushrooms":
                    Destroy(other);
                    if (psauce == true && pcheese == true) {
                        pmush = true;
                    }
                    break;
                case "bacon":
                    Destroy(other);
                    if (psauce == true && pcheese == true) {
                        pbacon = true;
                    }
                    break;
            }
            ToppingChange();
        }
    }
    public void Update(){
        pizza.GetComponent<Renderer>().material = active;
    }
    
}
