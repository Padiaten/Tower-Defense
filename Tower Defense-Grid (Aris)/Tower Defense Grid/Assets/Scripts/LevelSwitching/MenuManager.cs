﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour {

	void Start()
	{
		List<int> killist = new List<int> (){0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
		for (int i = 0; i < 20; i++) {
			//killist [i]++;
			print (killist[i]);
		}
	}

	public void LoadGame(string sel_schene) {
		SceneManager.LoadScene (sel_schene);
}
	public void QuitGame(){
		Application.Quit (); 
	}
}