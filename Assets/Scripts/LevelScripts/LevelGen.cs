using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGen : MonoBehaviour {
    public List<GameObject> levelsList = new List<GameObject>();
    public GameObject CurrentLevel;
    private GameObject nextLevel;
    private Vector3 levelPosition;

	// Use this for initialization
	void Start () {
     
        levelPosition = new Vector3(18, 0, 0);

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
            nextLevel = levelsList[Random.Range(0, 4)];
            levelPosition = levelPosition + new Vector3(22, 0, 0);
            NextLevelSpawner();
        }

        
        
    }

    public void NextLevelSpawner()
    {
        GameObject levelSpawn = Instantiate(nextLevel,levelPosition,Quaternion.identity);
    }
}
