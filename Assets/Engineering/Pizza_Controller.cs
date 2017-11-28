using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class Pizza_Controller : MonoBehaviour {

    public Pizza_Controller S;
    public Material sauce;
    public Material cheese;
    public Material sauceandcheese;
    public Material roni;
    public Material scr;
    public Material cr;
    public Material peppers;
    public Material scp;
    public Material scrp;
    public Material cp;
    public Material crp;
    public Material mushrooms;
    public Material scm;
    public Material scpm;
    public Material scrpm;
    public Material cpm;
    public Material crpm;
    public Material bacon;
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

    void Awake () {
        S = this;
    }

	void Start () {
        pizza.GetComponent<Renderer>().material = dough;
    }
	
	
	void Update () {
        if (psauce == true && pcheese == true) {
            pizza.GetComponent<Renderer>().material = sauceandcheese;
        }
	}

    void OnCollisionEnter(Collision col) {
        print ("col");
        GameObject other = col.gameObject;
        switch (other.tag) {
            case "sauce":
                pizza.GetComponent<Renderer>().material = sauce;
                Destroy(other);
                psauce = true;
                Orders.pizza1 = Orders.pizza1 + "s";
                break;
            case "cheese":
                pizza.GetComponent<Renderer>().material = cheese;
                Destroy(other);
                pcheese = true;
                Orders.pizza1 = Orders.pizza1 + "c";
                break;
        }
    }
}
