using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CupeGenerator : MonoBehaviour{

    //Public Variables
    public GameObject Cube;
    public Transform generation;
    public float distBetween;
    //Private Variables
    private float cubeWidth;
    private float distance = Random.Range(1.0f, 10.0f);

    public ObjPool theObjectPool;

    // Use this for initialization
    void Start()
    {
        cubeWidth = Cube.GetComponent<BoxCollider2D>().size.x;

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < generation.position.x)
        {
            transform.position = new Vector3(transform.position.x + cubeWidth + distBetween, transform.position.y, transform.position.z);


            //Instantiate(platforms, transform.position, transform.rotation)
            GameObject newCube = theObjectPool.GetPooledObject();
            distance = Random.Range(1.0f, 10.0f);
            newCube.transform.position = transform.position;
            newCube.transform.rotation = transform.rotation;
            newCube.SetActive(true);

        }
    }
}
