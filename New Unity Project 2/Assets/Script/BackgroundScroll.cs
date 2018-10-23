using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroll : MonoBehaviour
{

    Material material;
    Vector2 offset;

    public float xVelocity;

    // Use this for initialization
    void Start()
    {

        material = GetComponent<Renderer>().material;

        offset = new Vector2(xVelocity, 0);

    }

    // Update is called once per frame
    void Update()
    {

        material.mainTextureOffset += offset * Time.deltaTime;
    }
}
