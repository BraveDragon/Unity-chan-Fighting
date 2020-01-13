using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class HPManager1P : MonoBehaviour {
	float size;
	RectTransform rect;
	// Use this for initialization
	void Start () {
		rect = GetComponent<RectTransform> ();
	}
	
	// Update is called once per frame
	void Update () {
		const float C = 0.256f;
		size=Move1P.Player1.GetHP();
		rect.sizeDelta=new Vector2(size*C,32);
       

	}
}
