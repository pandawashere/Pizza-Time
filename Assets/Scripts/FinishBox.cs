using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishBox : MonoBehaviour {

	void OnCollisionEnter (Collision col)
	{
		if (Orders.order1 == Orders.pizza1) {
			Destroy (col.gameObject);
			print ("Positive points!");
			Orders.pizza1 = "d";
		}
		else if (Orders.order2 == Orders.pizza1){
			Destroy (col.gameObject);
			print("Positive points!");
			Orders.pizza1 = "d";
			//add positive points to point count
		}
		else {
			Destroy (col.gameObject);
			print ("negative points");
			Orders.pizza1 = "d";
			//subtract from point count for mistake here
		}

	}
}
