using UnityEngine;
using System.Collections;

public class Pizza : MonoBehaviour {

	//make this private later probably
	public bool cheese = false;
	//other ingredients and cooked or not will probably go here


	public void Place(int damageAmount)

	{
		//need to add current ingredient check
		//add ingredient when function is called
		cheese = true;
		//need to add texture here


		//deactivate for now to show its hitting
		if (cheese == true) {
			gameObject.SetActive (false);
		}

	}

}