using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoSpawn : MonoBehaviour {


	public GameObject ingredient;
	public GameObject spawnarea;
	public string tagname;
	public int spawnlimit;
	public static int spawnnum;




	void Start () {
		Instantiate (ingredient, spawnarea.transform.position, spawnarea.transform.rotation);
	}
	
	void OnTriggerExit(Collider collision){
		if (spawnnum < spawnlimit) {
			if (collision.gameObject.tag == tagname) {
				Instantiate (ingredient, spawnarea.transform.position, spawnarea.transform.rotation);
				spawnnum = spawnnum + 1;
			}
		}
	}

	void Update () {
		
	}
}
