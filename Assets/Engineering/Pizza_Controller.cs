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
    //public GameObject trigger;


	void Awake () {
        S = this;

    }

	void Start () {
        GetComponent<Renderer>().material = dough;
        active = dough;
    }
	
	
	void Update () {
        
	}

    void OnCollisionEnter(Collision col) {
        GameObject other = col.gameObject;
        switch (other.tag) {
            case "sauce":
                GetComponent<Renderer>().material = sauce;
                active = sauce;
                break;
            case "cheese":
                GetComponent<Renderer>().material = cheese;
                active = cheese;
                break;
        }
    }
}
