using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UnitSelection : MonoBehaviour {
	
	public int power, defence;
	public GameObject toInstantiate;

	public void Select(){
		SetToInstantiate(power, defence);
	}

	void SetToInstantiate (int pow, int def){
		toInstantiate.transform.Find ("Power").GetComponent<TextMesh>().text = pow.ToString();
		toInstantiate.transform.Find ("Defence").GetComponent<TextMesh>().text = def.ToString();
	}

	public GameObject GetToInstantiate(){
		return toInstantiate;
	}
}
