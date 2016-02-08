using UnityEngine;
using System.Collections;

/*
    Source File Name: CloudController
    Author's Name: Vinay Bhardwaj
    Last Modified By: Vinay Bhardwaj
    Date Last Modified: 5th February 2016
    Program Descreption: COMP305-ASSIGNMENT 1-HELI ATTACK
    Revision History: v16
*/

public class CloudController : MonoBehaviour {

    //PRIVATE INSTANCE VARIABLES
    private Transform _transform;
    private Vector2 _currentPosition;
    private float _speed;

    //PUBLIC INSTANCE VARIABLES
    public float minSpeed = 3f;
    public float maxSpeed = 6f;

    // Use this for initialization
    void Start()
    {
        this._transform = gameObject.GetComponent<Transform>();//GETTING THE TRANSFORMATION COMPONENT OF THE CURRENT OBJECT
        //Reset the Cloud position
        this.reset();
    }

    // Update is called once per frame
    void Update()
    {

        this._currentPosition = this._transform.position;
        this._currentPosition -= new Vector2(this._speed, 0);
        this._transform.position = this._currentPosition;

        if (this._currentPosition.x <= -1055)
        {
            this.reset();
        }
    }

    //PUBLIC METHOD TO RESET THE POSITION OF CURRENT OBJECT
    public void reset()
    {
        this._speed = Random.Range(this.minSpeed, this.maxSpeed);
        this._transform.position = new Vector2(1830f, 200);
    }
}
