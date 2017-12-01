using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishBox : MonoBehaviour {

	private Pizza_Controller pizzainfo;
	public GameObject pizzainstance;

	void Update () {

		pizzainfo = pizzainstance.GetComponent<Pizza_Controller> ();
		pizzainfo = GameObject.Find("Pizza_Trig").GetComponent<Pizza_Controller>();
	}

	void OnCollisionEnter (Collision col)
	{
			for (int i = 0; i < Ticket_Spawn.order.Length; i++) {
			if (Ticket_Spawn.order [i] == pizzainfo.pizzatype) {
					Destroy (col.gameObject);
					print ("yay");
				}
			}
			//if if above fails strikes


		}


}
