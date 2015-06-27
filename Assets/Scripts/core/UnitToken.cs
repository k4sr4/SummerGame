using UnityEngine;
using System.Collections;

public class UnitToken : MonoBehaviour {

/*  Public Members
 *  =========================================================================*/
	public GameObject powerTextObj;
	public GameObject defenseTextObj;

	public Unit unit;

	// Use this for initialization
	void Start () {
		powerText = powerTextObj.GetComponent<TextMesh>();
		defenseText = defenseTextObj.GetComponent<TextMesh>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

/*  Private Members
 *  =========================================================================*/
	private TextMesh powerText;
	private TextMesh defenseText;
}
