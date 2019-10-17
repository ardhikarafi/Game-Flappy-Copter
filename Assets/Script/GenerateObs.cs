using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateObs : MonoBehaviour {
	public GameObject rocks;
	public int score = 0;
	public int level = 1;

	// Use this for initialization
	void Start () {
		InvokeRepeating("CreateObstacle",1f,1.5f);		
	}
	void CreateObstacle(){
		Instantiate(rocks);
		score++;
	}
	
	
	// Update is called once per frame
	void Update () {
		
		
	}
	void OnGUI(){
		GUI.color = Color.black;
		GUILayout.Label ("Score : " +score.ToString());
		
		GUILayout.Label ("Level : " +level.ToString());
		
	}
}
