﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new Character",menuName = "Character")]
public class Character : ScriptableObject {

    public string charName;
    public float health;
    public float strength;
    public float magicalPow;
    public float physicalDef;
    public float magicalDef;
    public GameObject myPrefab;
	// Use this for initialization
	void Start () {
		//asda
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
