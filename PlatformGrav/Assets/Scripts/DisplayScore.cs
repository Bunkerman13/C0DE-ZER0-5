using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayScore : MonoBehaviour {

	// Use this for initialization
	void Start() { 
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(MySceneManager.Instance.finalScore);
        Debug.Log(MySceneManager.Instance.finalCoins);
        Debug.Log(MySceneManager.Instance.finalMultiplier);
    }
}
