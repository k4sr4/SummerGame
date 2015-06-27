using UnityEngine;
using System.Collections;

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

	public override string ToString() {
		return "Tile@(" + this.Row.ToString() + ", " + this.Col.ToString() + ")";
	}

/*  Private Members
 *  =========================================================================*/
	private bool initialized = false;
	private int row;  // @TODO make short?
	private int col;
}
