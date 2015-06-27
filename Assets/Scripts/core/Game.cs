using UnityEngine;
using System.Collections;

public class Game : MonoBehaviour {

/*  Class Members
 *  =========================================================================*/
/**
 *  A UnitToken used for instantiation anywhere
 */
	public UnitToken unitTokenToInstantiate;

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
		UnitToken u = field.SetUnit(unitTokenToInstantiate, 1, 1);
		u.unit = new DebugUnit(1, 1, Faction.White);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
