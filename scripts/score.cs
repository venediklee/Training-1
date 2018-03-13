using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour {

    public Transform playerpos;
    public Text scoretext;
	
	// Update is called once per frame
	void Update () {
        scoretext.text= playerpos.position.z.ToString("0");
	}
}
