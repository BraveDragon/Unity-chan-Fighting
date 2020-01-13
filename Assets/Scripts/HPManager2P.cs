using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class HPManager2P : MonoBehaviour {
	float size;
	RectTransform rect;
	void Start () {
		rect = GetComponent<RectTransform> ();
	}

	void Update () {
		const float C = 0.256f;
		size=Move2P.Player2.GetHP();
		rect.sizeDelta=new Vector2(size*C,32);


	}
 
}
