using UnityEngine;
using System.Collections;

public class ClickAction : MonoBehaviour {

	GameObject selected;

	void Update () {
		//Gets where the mouse is clicking by ray casting
		if (Input.GetMouseButtonDown(0)){
			Ray toMouse = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit rhInfo;
			bool didHit = Physics.Raycast (toMouse, out rhInfo);
			if (StartScript.start){
				if (didHit){
					if (!isSelected() && rhInfo.collider.tag == "Unit"){ //if a unit was not selected before, select this unit to move on the next click
						selected = rhInfo.collider.gameObject;
					}
					else if (isSelected() && rhInfo.collider.tag == "Unit"){ //if a unit was selected before, swap two positions
						Swap (selected, rhInfo.collider.gameObject);
						selected = null;
					}
					else if (rhInfo.collider.tag == "Grid"){ ////if a unit was selected before, move it to this grid
						if (isSelected()){
							changePosition (rhInfo.collider.gameObject.transform.position);
							selected = null;
						}
					}
					Debug.Log("Hitted " + rhInfo.collider.name);
				}
				else
					Debug.Log("NO hit");
			}
			else if (!StartScript.start){
				if (didHit){
					if (rhInfo.collider.tag == "Grid"){
						Instantiate(FindObjectOfType<UnitSelection>().GetToInstantiate(), rhInfo.collider.transform.position, Quaternion.identity);
					}
				}
				else
					Debug.Log("NO hit");
			}

		}
	}

	void Swap (GameObject first, GameObject second){
		Vector3 temp;
		temp = first.transform.position;
		first.transform.position = second.transform.position;
		second.transform.position = temp;
	}
	
	bool isSelected(){
		if (selected == null)
			return false;
		else
			return true;
	}

	void changePosition (Vector3 pos){
		selected.transform.position = pos;
	}
}
