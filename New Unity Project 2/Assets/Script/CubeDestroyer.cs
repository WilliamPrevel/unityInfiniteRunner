using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeDestroyer : MonoBehaviour {
    //Public Variables
    public GameObject cubeDestroyPoint;

    //Private Variables

    // Use this for initialization
    void Start()
    {
        cubeDestroyPoint = GameObject.Find("PlatformDestroyPoint");
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < cubeDestroyPoint.transform.position.x)
        {
            //Destroy(gameObject);
            gameObject.SetActive(false);
        }

    }
}
