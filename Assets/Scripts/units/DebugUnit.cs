using UnityEngine;
using System.Collections;

/**
 *  Special unit used for development only.  It has a ton of flexibility for
 *  the sake of testing.
 * 
 *  @version B.00.1507
 *  **************************************************************************/
public class DebugUnit : Unit {

/*  Constructor
 *  =========================================================================*/
	public DebugUnit(int p, int d, Faction f) : base("", p, d, f) {
		++numberOfUnits;
		this.name = "[Debug Unit " + numberOfUnits.ToString() + "]";
	}

/*  Public Methods
 *  =========================================================================*/
/**
 *  Not normally available in units.  Used here for testing.
 */
	public void SetStats(int pow, int def, Faction fac) {
		this.power = pow;
		this.defense = def;
		this.faction = fac;
	}

/*  Private Members
 *  =========================================================================*/
	private static int numberOfUnits = 0;
}
