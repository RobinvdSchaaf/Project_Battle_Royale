using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ItemSpawning : MonoBehaviour
{

    private GameManager G_GameManager;
    void Awake()
    {
        G_GameManager = GameObject.FindGameObjectWithTag("Manager").GetComponent<GameManager>();
        // needs to be edited. NOTE! spawnrate/rarity and array of ammo and weapon types
        for (int a = 0; a < 5; a++)
        {
            Vector3 position = new Vector3(Random.Range(-50f, 50f), 0, Random.Range(-50f, 50f));
            //GameObject[] spawningAreas = GameObject.FindGameObjectsWithTag("CanSpawnOn");
            //foreach(Transform child )
            //Instantiate(G_GameManager.gun, hit.position, new Quaternion(0, 0, 0, 0));
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
