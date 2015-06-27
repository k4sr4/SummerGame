using UnityEngine;
using System.Collections;

public class Field : MonoBehaviour {

/*  Public Members
 *  =========================================================================*/
/**
 *  This tile is used to instantiate other tiles.  Never display this tile in particular.
 */
	public Tile tileToInstantiate;

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

/*  Private Members
 *  =========================================================================*/
	private Tile[,] grid;
	private GameObject tileLayer;
	private GameObject unitLayer;
}
