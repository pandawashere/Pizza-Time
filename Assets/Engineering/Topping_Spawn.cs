using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Topping_Spawn : MonoBehaviour {

    public Topping_Spawn S;

    public GameObject topping;
    public int spawn;

    void awake() {
        S = this;
    }

	void Start () {
        spawn = 0;
	}
	
	
	void Update () {
        for (spawn = 0; spawn <= 5; spawn++) {
            if (spawn < 5) {
                Instantiate(topping, transform.position, transform.rotation);
            }            
            spawn++;
        }
	}

    void toppingCheck(GameObject t) {
        t = topping;
    }
}
