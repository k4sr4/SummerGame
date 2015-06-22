using UnityEngine;
using System.Collections;

public class TextScript : MonoBehaviour {

	void Start()
	{
		GetComponent<TextMesh>().GetComponent<MeshRenderer>().sortingLayerName = "Forground";
		GetComponent<TextMesh>().GetComponent<MeshRenderer>().sortingOrder = 99;
	}
}
