using UnityEngine;
using System.Collections;

public class Pizza : MonoBehaviour {

	public class ingredients
	{
		public bool sauce;
		public bool cheese;
		public bool roni;
		public bool peppers;
		public bool mushrooms;
		public bool bacon;

		public bool dough;
		public bool cooked;
		public bool burnt;

		public GameObject Piemodel;
		public GameObject pielocation;
	
	//constructor
		public ingredients ()
		{
			sauce = false;
			cheese = false;
			roni = false;
			peppers = false;
			mushrooms = false;
			bacon = false;
		}
	}


	void Start () {
		public ingredients mypizza = new ingredients();
	}
}