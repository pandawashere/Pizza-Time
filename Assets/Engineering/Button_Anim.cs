using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_Anim : MonoBehaviour {

    Animation button;
    public GameObject spawner;
    public GameObject topping;
    public GameObject buttonObject;

    void Start () {
		
	}
	
	
	void Update () {
		//if () {
        //    buttonType();
        //}
	}

    public void buttonType() {
        if (buttonObject.tag == "tbutton") {
            Instantiate(topping, spawner.transform.position, spawner.transform.rotation);
        }
        if (buttonObject.tag == "dbutton") {
            Instantiate(topping, spawner.transform.position, spawner.transform.rotation);
        }
    }
}
