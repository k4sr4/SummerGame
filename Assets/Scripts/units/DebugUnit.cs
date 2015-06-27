using UnityEngine;
using System.Collections;

public class DebugUnit : Unit {

/*  Constructor
 *  =========================================================================*/
	public DebugUnit(int p, int d, Faction f) : base("", p, d, f) {
		++numberOfUnits;
		this.name = "[Debug Unit " + numberOfUnits.ToString() + "]";
	}

/*  Public Methods
 *  =========================================================================*/
	public void SetStats(int pow, int def, Faction fac) {
		this.power = pow;
		this.defense = def;
		this.faction = fac;
	}

/*  Private Members
 *  =========================================================================*/
	private static int numberOfUnits = 0;
}
