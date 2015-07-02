/**
 *  This is data representing factions in the game.  The actual faction names
 *  are located in the Faction enum at the bottom.  A C# extension is used to
 *  add functionality to the enum.
 *  
 *  @usage
 *  Faction f1 = Faction.White;
 *  Faction f2 = Faction.Black;
 *  bool b = f1.Is(f2);  // false
 * 
 *  @version B.00.1507
 *  **************************************************************************/
public static class FactionExtension {
/**
 *  Determines whether two factions are the same.
 *  @param faction First faction
 *  @param other Second faction
 *  @param strictly If true, checks if one faction is exactly the other.  When false, checks if the faction belongs to the faction set.
 *  @return True if the factions are equivalent, false otherwise.
 */
	public static bool Is(this Faction faction, Faction other, bool strictly = false) {
		return strictly ? faction == other : (faction & other) > 0;
	}

/**
 *  Returns the opposite faction of the one given.
 *  @param faction The current faction
 *  @return The opposite faction.
 */
	public static Faction Other(this Faction faction) {
		return ~faction & Faction.Both;
	}
}

public enum Faction : byte {
	None  = 0x00,
	White = 0x01,
	Black = 0x02,
	Both  = 0x03
}