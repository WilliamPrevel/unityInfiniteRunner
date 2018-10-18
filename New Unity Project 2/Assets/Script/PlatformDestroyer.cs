using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformDestroyer : MonoBehaviour {

    //Public Variables
    public GameObject platformDestroyPoint;

    //Private Variables

    // Use this for initialization
    void Start () {
        platformDestroyPoint = GameObject.Find("PlatformDestroyPoint");
	}
	
	// Update is called once per frame
	void Update () {
        if(transform.position.x < platformDestroyPoint.transform.position.x)
        {
            //Destroy(gameObject);
            gameObject.SetActive(false);
        }
       
	}
}
