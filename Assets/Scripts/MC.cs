﻿using UnityEngine;
using System.Collections;

public class MC : MonoBehaviour {
	public static MC instance { get; private set; }
	
	public bool CearaCursed;
	public bool toldAboutSmell;
	public bool toldCearaAboutSageBeingWeird;
	public bool wentWithCearaForGloves;
	public bool wentToCaudden;

	void Awake()
	{
		if (instance != null && instance != this) {
			Destroy (gameObject);
		}
		instance = this;
		DontDestroyOnLoad (gameObject);
	}





	public void UpdateBool(string s){
		if (s == "momIntro") {
			Story.instance.hasTalkedToMomIntro = true;
		}
	}



}