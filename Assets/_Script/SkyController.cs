using UnityEngine;
using System.Collections;

/*
    Source File Name: GameController
    Author's Name: Vinay Bhardwaj
    Last Modified By: Vinay Bhardwaj
    Date Last Modified: 5th February 2016
    Program Descreption: COMP305-ASSIGNMENT 1-HELI ATTACK
    Revision History: v16
*/

public class SkyController : MonoBehaviour {
    //PRIVATE INSTANCE VARIABLES
    private Transform _transform; 
    private Vector2 _currentPosition;

    //PUBLIC INSTANCE VARIABLES
    public float speed = 3f;


	// Use this for initialization
	void Start () {
        this._transform = gameObject.GetComponent<Transform>(); //GETTING THE TRANSFORMATION COMPONENT OF THE CURRENT OBJECT
        //Reset the background
        this.reset();
	}
	
	// Update is called once per frame
	void Update () {
        
        this._currentPosition = this._transform.position;
        this._currentPosition -= new Vector2(this.speed, 0);
        this._transform.position = this._currentPosition;

        if (this._currentPosition.x <= 129)
        {
            this.reset();
        }
	}

    //PUBLIC METHOD TO RESET THE POSITION OF CURRENT OBJECT
    public void reset()
    {
        this._transform.position = new Vector2(783f, 0f);
    }
}
