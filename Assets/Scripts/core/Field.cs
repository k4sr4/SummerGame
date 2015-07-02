using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/**
 *  This class represents the field of play.  It lays out the Tiles and
 *  directs the traffic of UnitTokens.
 * 
 *  @version B.00.1507
 *  **************************************************************************/
public class Field : MonoBehaviour {

/*  Public Members
 *  =========================================================================*/
/**
 *  This tile is used to instantiate other tiles.  Never display this tile in particular.
 */
	public Tile tileToInstantiate;

/**
 *  This UnitToken is used to instantiate other tokens.
 */
	public UnitToken unitTokenToInstantiate;

/**
 *  Number of rows in the grid currently.
 */
	public int Rows {
		get {
			return grid.GetLength(0);
		}
	}

/**
 *  Number of columns in the grid currently.
 */
	public int Cols {
		get {
			return grid.GetLength(1);
		}
	}

/*  Unity API
 *  =========================================================================*/
	private void Awake() {
		tileLayer = new GameObject("TileLayer");
		unitLayer = new GameObject("UnitLayer");

	}
	// Use this for initialization
	void Start () {
	//  Must be in Start, not Awake
		tileLayer.transform.SetParent(this.transform);
		unitLayer.transform.SetParent(this.transform);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

/*  Public Methods
 *  =========================================================================*/
/**
 *  Initializes a new grid and displays it.
 *  @param rows Number of rows
 *  @param cols Number of columns
 */
	public void Init(int rows, int cols) {
	//  @TODO need to properly destroy all previous tiles?  Probably will need a Clear() method called before Init()
		grid = new Tile[rows, cols];

	//  Create the grid of tiles and throw them onto the screen
		for(int r = 0; r < rows; ++r) for(int c = 0; c < cols; ++c) {
			Tile tile = Instantiate(this.tileToInstantiate, new Vector3(r, c, 0), Quaternion.identity) as Tile;
			tile.Init(r, c);
			grid[r, c] = tile;
			tile.transform.SetParent(tileLayer.transform);
		}
	}

/**
 *  @deprecated
 *
	public UnitToken SetUnit(UnitToken original, int r, int c) {
		UnitToken instantiated = Instantiate(original, new Vector3(r, c, 0), Quaternion.identity) as UnitToken;
		instantiated.transform.SetParent(unitLayer.transform);
		return instantiated;
	}
  */

/**
 *  Places units onto the field given their data and coordinates
 *  @param units Map of unit data to their coordinates.  This should be generated from outside the class.
 */
	public void fieldUnits(Dictionary<Unit, Vector2> units) {
		foreach(Unit u in units.Keys) {
			Vector2 location = units[u];
			UnitToken instantiated = Instantiate(unitTokenToInstantiate, new Vector3(location.x, location.y, 0), Quaternion.identity) as UnitToken;
			instantiated.Unit = u;
			instantiated.transform.SetParent(unitLayer.transform);
			instantiated.UpdateVisual();
			grid[(int)location.x, (int)location.y].DeployUnit(instantiated);
		}
	}

/*  Private Members
 *  =========================================================================*/
	private Tile[,] grid;
	private GameObject tileLayer;
	private GameObject unitLayer;
}
