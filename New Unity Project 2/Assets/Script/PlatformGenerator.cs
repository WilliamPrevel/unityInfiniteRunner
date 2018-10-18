using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour {

    //Public Variables
    public GameObject platforms;
    public Transform generation;
    public float distBetween;
    //Private Variables
    private float platformWidth;

    public ObjPool theObjectPool;

    // Use this for initialization
    void Start ()
    {
        platformWidth = platforms.GetComponent<BoxCollider2D>().size.x;

	}
	
	// Update is called once per frame
	void Update ()
    {
		if(transform.position.x < generation.position.x)
        {
            transform.position = new Vector3(transform.position.x + platformWidth + distBetween, transform.position.y, transform.position.z);

            //Instantiate(platforms, transform.position, transform.rotation);
            GameObject newPlatform = theObjectPool.GetPooledObject();

            newPlatform.transform.position = transform.position;
            newPlatform.transform.rotation = transform.rotation;
            newPlatform.SetActive(true);

        }
	}
}
