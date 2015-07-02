using UnityEngine;
using System.Collections;

/**
 *  Unit data.  This is not what is actually displayed on the game screen.
 *  This class is meant to hold data about a unit and is attached to both
 *  UnitToken and Tile.  We separate this from UnitToken for the sake of
 *  decoupling state and UI.
 * 
 *  This does not extend MonoDevelop because it does not need to.  It is
 *  a pure data class.
 * 
 *  @NOTE It is likely going to be better to attach a UnitToken to Tile, not
 *  Unit.
 * 
 *  @version B.00.1507
 *  **************************************************************************/
public abstract class Unit {

/*  Constructor
 *  =========================================================================*/
	public Unit(string name, int p, int d, Faction f) {
		this.name = name;
		this.power = p;
		this.defense = d;
		this.faction = f;
	}

/*  Public Members
 *  =========================================================================*/
	public string Name {
		get {
			return name;
		}
	}

	public int Power {
		get {
			return power;
		}
	}

	public int Defense {
		get {
			return defense;
		}
	}

	public int Health {
		get {
			return power;
		}
	}

	public Faction Faction {
		get {
			return faction;
		}
	}

/*  Public Members
 *  =========================================================================*/
/**
 *  Just the unit's name.  Used for debugging or for displaying unit information.
 */
	override public string ToString() {
		return this.Name;
	}

/*  Protected Members
 *  =========================================================================*/
	protected string name;
	protected int power;
	protected int defense;
	protected Faction faction;
}
