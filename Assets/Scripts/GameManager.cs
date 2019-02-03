using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GameManager : MonoBehaviour
{
    // maxhealth values
    [SerializeField] private GameObject Player;
    public GameObject player
    {
        get { return Player; }
    }
    [SerializeField] private int MaxHealth;
    public int maxHealth
    {
        get { return MaxHealth; }
    }

    [SerializeField] private int PlaneHeight;
    public int planeheight
    {
        get { return PlaneHeight; }
    }

    [SerializeField] private float CycleSpeed;
    public float cycleSpeed
    {
        get { return CycleSpeed; }
    }

    [SerializeField] private GameObject Gun;
    public GameObject gun
    {
        get { return Gun; }
    }

    [SerializeField] private GameObject navMesh;
    public GameObject navmesh
    {
        get { return navMesh; }
    }

    [SerializeField] private List<GameObject> SpawnItems;
    public List<GameObject> spawnItems
    {
        get { return SpawnItems; }
    }

    [SerializeField] private List<GameObject> SpawnLocations;
    public List<GameObject> spawnLocations
    {
        get { return SpawnLocations; }
    }



    // Start is called before the first frame update
    void Start()
    {

    }
    
    // Update is called once per frame
    void FixedUpdate()
    {
        if (CycleSpeed <= 0f) { CycleSpeed = 1f; }
        GameObject.FindGameObjectWithTag("DayNightCycle").transform.Rotate(new Vector3(Time.deltaTime * CycleSpeed, 0, 0), Space.Self);
    }
    

}
