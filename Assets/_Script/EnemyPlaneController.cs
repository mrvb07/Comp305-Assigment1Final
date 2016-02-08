using UnityEngine;
using System.Collections;

/*
    Source File Name: EnemyPlaneController
    Author's Name: Vinay Bhardwaj
    Last Modified By: Vinay Bhardwaj
    Date Last Modified: 5th February 2016
    Program Descreption: COMP305-ASSIGNMENT 1-HELI ATTACK
    Revision History: v16
*/

public class EnemyPlaneController : MonoBehaviour {

    //PRIVATE INSTANCE VARIABLES
    private Transform _transform;
    private Vector2 _currentPosition;
    private float _speed;

    //PUBLIC INSTANCE VARIABLES
    public float minSpeed = 7.5f;
    public float maxSpeed = 12.5f;


    // Use this for initialization
    void Start()
    {
        this._transform = gameObject.GetComponent<Transform>();//GETTING THE TRANSFORMATION COMPONENT OF THE CURRENT OBJECT
        //Reset the Enemy
        this.reset();
    }

    // Update is called once per frame
    void Update()
    {

        this._currentPosition = this._transform.position;
        this._currentPosition -= new Vector2(this._speed, 0);
        this._transform.position = this._currentPosition;

        if (this._currentPosition.x <= -1200)
        {
            this.reset();
        }
    }
    //PUBLIC METHOD TO RESET THE POSITION OF CURRENT OBJECT
    public void reset()
    {
        this._speed = Random.Range(this.minSpeed, this.maxSpeed);
        float yPos = Random.Range(200f, 128f); //Boundary Checking
        this._transform.position = new Vector2(2100f, yPos); 
    }
}
