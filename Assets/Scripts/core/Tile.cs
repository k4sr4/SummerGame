using UnityEngine;
using System.Collections;

/**
 *  This represents a tile on the Field and has attached to it a variety of
 *  information regarding the tile, including its location and unit occupying
 *  it.  To operate, the Init() method must first be called after being
 *  instantiated.
 * 
 *  @version B.00.1507
 *  **************************************************************************/
public class Tile : MonoBehaviour {

/*  Public Members
 *  =========================================================================*/
	public int Row {
		get {
			return (int)row;
		}
	}

	public int Col {
		get {
			return (int)col;
		}
	}

/**
 *  The Tile holds a reference to the token that sits on it.  The token then
 *  contains a reference to the Unit data itself.
 */
	public UnitToken Unit {
		get {
			return unit;
		}
	}

/*  Unity API
 *  =========================================================================*/
	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	
	}

/*  Public Members
 *  =========================================================================*/
/**
 *  Initializes the tile so that it knows its row and column.  These values should not be changed after the tile is made.
 *  @param row The row (y axis)
 *  @param col The column (x axis)
 */
	public void Init(int row, int col) {
		if(!initialized) {
			initialized = true;
			this.row = row;
			this.col = col;
		}
		else
			throw new System.Exception("ERROR in Tile Init: " + this.ToString() + " was initialized twice");
	}

/**
 *  Deploys a unit onto the tile.  The tile must first be unoccupied.
 *  @param u The unit to put on this tile
 * 	@return true if succeeded, false otherwise
 */
	public bool DeployUnit(UnitToken u) {
		if(this.unit == null) {
			unit = u;
			return true;
		}
		else
			return false;
	}

/**
 *  Tile@(r, c)
 */
	public override string ToString() {
		return "Tile@(" + this.Row.ToString() + ", " + this.Col.ToString() + ")";
	}

/*  Private Members
 *  =========================================================================*/
	private bool initialized = false;
	private int row;  // @TODO make short?
	private int col;

//	private Unit unit;
	private UnitToken unit;
}
