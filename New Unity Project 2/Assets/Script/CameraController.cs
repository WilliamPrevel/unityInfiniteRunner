using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    //Public Variables
    public PlayerController player;

    
    //Private Variables
    private Vector3 lastPlayerPos;
    private float distToMove;


    // Use this for initialization
    void Start () {
        player = FindObjectOfType<PlayerController>();
        lastPlayerPos = player.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        //Camera Location
        distToMove = player.transform.position.x - lastPlayerPos.x;
        transform.position = new Vector3(transform.position.x + distToMove, transform.position.y, transform.position.z + 1);
        lastPlayerPos = player.transform.position;
	}
}
