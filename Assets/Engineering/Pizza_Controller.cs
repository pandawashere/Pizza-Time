using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class Pizza_Controller : MonoBehaviour {

    public Pizza_Controller S;
    public Material active;
    public Material sauce;
    public Material cheese;
    public Material roni;
    public Material peppers;
    public Material mushrooms;
    public Material bacon;
    public Material dough;
    public Material burnt;
    public Material cooked;
    public GameObject pizza;
    //public Topping_Spawn tspawn;

	void Awake () {
        S = this;
        //tspawn = GetComponent<Topping_Spawn>();
    }

	void Start () {
        pizza.GetComponent<Renderer>().material = dough;
        //active = dough;
        //pizza = transform.Find("Pizza");
    }
	
	
	void Update () {
        
	}

    void OnCollisionEnter(Collision col) {
        print ("col");
        GameObject other = col.gameObject;
        switch (other.tag) {
            case "sauce":
                pizza.GetComponent<Renderer>().material = sauce;
                Destroy(other);
				Orders.pizza1 = Orders.pizza1 + "s";
                //tspawn.S.spawn = 0;
                //active = sauce;
                break;
            case "cheese":
                pizza.GetComponent<Renderer>().material = cheese;
                Destroy(other);
				Orders.pizza1 = Orders.pizza1 + "c";
                //tspawn.S.spawn = 0;
                //active = cheese;
                break;
        }
    }
}
