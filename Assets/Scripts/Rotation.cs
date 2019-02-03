using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    private GameObject player;
    private float xRotate, yRotate;

    void Start()
    {
        player = GameObject.Find("Player");
    }

    void Update()
    {
        //xRotate = Mathf.Min(50, Mathf.Max(-50, xRotate + Input.GetAxis("Mouse X")));
        xRotate += Input.GetAxis("Mouse X");
        yRotate += Input.GetAxis("Mouse Y");
        player.transform.localRotation = Quaternion.Euler(0, xRotate, 0);
        transform.localRotation = Quaternion.Euler(-yRotate, 0, 0);
    }
}
