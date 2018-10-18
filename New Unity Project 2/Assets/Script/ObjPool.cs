using System.Collections;
using UnityEngine;
using System.Collections.Generic;


public class ObjPool : MonoBehaviour {

    public List<GameObject> pooledObjects;
    public GameObject objectToPool;
    public int amountToPool;

    public static ObjPool SharedInstance;
    
    void Awake()
    {
        SharedInstance = this;
    }
    // Use this for initialization
    void Start () {
        pooledObjects = new List<GameObject>();
        for (int i = 0; i < amountToPool; i++)
        {
            GameObject obj = (GameObject)Instantiate(objectToPool);
            obj.SetActive(false);
            pooledObjects.Add(obj);
        }


    }

    // Update is called once per frame
    void Update () {
		
	}
    public GameObject GetPooledObject()
    {
        for (int i = 0; i < pooledObjects.Count; i++)
        {
            if (!pooledObjects[i].activeInHierarchy)
            {
                return pooledObjects[i];
            }
        }
        GameObject obj = (GameObject)Instantiate(objectToPool);
        obj.SetActive(false);
        pooledObjects.Add(obj);
        return obj;
    }
}
