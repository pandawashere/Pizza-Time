using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashCan : MonoBehaviour
{

	void OnCollisionEnter (Collision col)
	{
		Destroy (col.gameObject);
		AutoSpawn.spawnnum = AutoSpawn.spawnnum + 1;
		//negative points if pizza?

	}
}