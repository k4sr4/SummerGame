using UnityEngine;
using System.Collections;

public class Game : MonoBehaviour {

/*  Public Members
 *  =========================================================================*/
/**
 *  Field is specified in the Editor.
 */
	public Field field;

/*  Unity API
 *  =========================================================================*/
	// Use this for initialization
	void Start () {
		field.Init(8, 8);  // @DEBUG
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
