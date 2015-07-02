using UnityEngine;
using System.Collections;

/**
 *  The actual token the players sees on the field.  It represents exactly
 *  one unit.
 * 
 *  @version B.00.1507
 *  **************************************************************************/
public class UnitToken : MonoBehaviour {

/*  Class Members
 *  =========================================================================*/
	public const string IS_ENEMY = "isBlack";

/*  Public Members
 *  =========================================================================*/
	public GameObject frame;
	public GameObject powerTextObj;
	public GameObject defenseTextObj;
	public GameObject avatar;

	public Unit Unit {
		get {
			return unit;
		}
		set {
			unit = value;
		}
	}

/*  Unity API
 *  =========================================================================*/
	void Awake () {
		powerText = powerTextObj.GetComponent<TextMesh>();
		defenseText = defenseTextObj.GetComponent<TextMesh>();
		animator = frame.GetComponent<Animator>();

	}
	
	// Update is called once per frame
	void Update () {
	
	}

/*  Public Methods
 *  =========================================================================*/
/**
 *  Updates the token on the screen to match internal Unit data.
 *  Should be called when any change is made to the Unit.
 *  At the moment, we should keep this out of the Update() method for performace reasons.
 */
	public void UpdateVisual() {
		powerText.text = unit.Power.ToString();
		defenseText.text = unit.Defense.ToString();
		if(unit.Faction.Is(Game.playerFaction.Other())) {
			animator.SetBool(IS_ENEMY, true);
		}
		else {
			animator.SetBool(IS_ENEMY, false);
		}
	}

/*  Private Members
 *  =========================================================================*/
	private Unit unit;
	private TextMesh powerText;
	private TextMesh defenseText;
	private Animator animator;
}
