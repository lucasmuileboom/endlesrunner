﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGen : MonoBehaviour {
    private Playermovement Playermovement;
    public List<GameObject> levelsList = new List<GameObject>();
    public GameObject CurrentLevel;
    private GameObject nextLevel;
    private Vector3 levelPosition;

	// Use this for initialization
	void Start () {
        Playermovement = GameObject.Find("Player").GetComponent<Playermovement>();
        levelPosition = new Vector3(7, 0, 0);

    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log(nextLevel);
        }
	}

    void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("generate"))
        {
            nextLevel = levelsList[Random.Range(0, 5)];
            levelPosition = levelPosition + new Vector3(22, 0, 0);
            NextLevelSpawner();
            Playermovement.getMoreSpeed();
        }

        
        
    }

    public void NextLevelSpawner()
    {
        GameObject levelSpawn = Instantiate(nextLevel,levelPosition,Quaternion.identity);
    }
}
