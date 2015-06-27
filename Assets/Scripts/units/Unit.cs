using UnityEngine;
using System.Collections;

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
	public string ToString() {
		return this.Name;
	}

/*  Protected Members
 *  =========================================================================*/
	protected string name;
	protected int power;
	protected int defense;
	protected Faction faction;
}
