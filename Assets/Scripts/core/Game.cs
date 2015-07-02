using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/**
 *  This is the master class and is the first thing that is run on game start up.
 *  Game is responsible for creating all other objects for the game itself.
 *  This does not control any menu states.
 * 
 *  @version B.00.1507
 *  **************************************************************************/
public class Game : MonoBehaviour {

/*  Class Members
 *  =========================================================================*/
	public static Faction playerFaction = Faction.White;

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

		field.fieldUnits(generateUnits());
	}
	
	// Update is called once per frame
	void Update () {
	
	}

/**
 *  @DEBUG
 */
	public Dictionary<Unit, Vector2> generateUnits() {
		Dictionary<Unit, Vector2> units = new Dictionary<Unit, Vector2>();
		for(int r = 0; r < 8; ++r) for(int c = 0; c < 8; ++c) {
			Unit u = new DebugUnit(Random.Range(1, 9), Random.Range(1, 9), r < 4 ? Faction.White : Faction.Black);
			units[u] = new Vector2(c, r);
		}
		return units;
	}
}
