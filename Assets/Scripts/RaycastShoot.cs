using UnityEngine;
using System.Collections;

public class RaycastShoot: MonoBehaviour {

	public int gunDamage = 1;                                           
	public float fireRate = .25f;                                       
	public float weaponRange = 50f;                                     
	public float hitForce = 100f;
	public Transform gunEnd;
	//public string Ingredient = "";

	private Camera fpsCam;
	private WaitForSeconds shotDuration = new WaitForSeconds(0.01f);
	private LineRenderer laserLine;
	private float nextFire; 


	void Start () {
		laserLine = GetComponent<LineRenderer>();
		fpsCam = GetComponentInParent<Camera> ();

	}

	void Update () {
		if (Input.GetButtonDown ("Fire1") && Time.time > nextFire) {
			nextFire = Time.time + fireRate;
			StartCoroutine(ShotEffect());
			Vector3 rayOrigin = fpsCam.ViewportToWorldPoint (new Vector3(0.5f, 0.5f, 0.0f));
			RaycastHit hit;
			laserLine.SetPosition(0, gunEnd.position);
			if (Physics.Raycast (rayOrigin, fpsCam.transform.forward, out hit, weaponRange)) 
			{
				laserLine.SetPosition (1, hit.point);
				Pizza health = hit.collider.GetComponent<Pizza> ();

				if (health != null) {
					health.Place (gunDamage);
				}

			
			}
			else
			{
				laserLine.SetPosition(1, fpsCam.transform.forward * weaponRange);
			}
		}
	}

	private IEnumerator ShotEffect(){
		laserLine.enabled = true;
		yield return shotDuration;
		laserLine.enabled = false;
	}

}