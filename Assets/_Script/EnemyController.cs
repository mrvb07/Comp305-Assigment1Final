using UnityEngine;
using System.Collections;

/*
    Source File Name: EnemyController
    Author's Name: Vinay Bhardwaj
    Last Modified By: Vinay Bhardwaj
    Date Last Modified: 5th February 2016
    Program Descreption: COMP305-ASSIGNMENT 1-HELI ATTACK
    Revision History: v16
*/


public class EnemyController : MonoBehaviour {

    //PRIVATE INSTANCE VARIABLES
    private Transform _transform;
    private Vector2 _currentPosition;
    private float _verticalDrift;
    private float _horizontalDrift;

    //PUBLIC INSTANCE VARIABLES
    public float minVerticalSpeed = -0.55f;
    public float maxVerticalSpeed = 0.55f;
    public float minHorizontalSpeed = 8f;
    
    public float maxHorizontalSpeed = 15f;

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
        this._currentPosition -= new Vector2(this._horizontalDrift, this._verticalDrift);
        this._transform.position = this._currentPosition;

        if (this._currentPosition.x <= -230)
        {
            this.reset();
        }
    }
    //PUBLIC METHOD TO RESET THE POSITION OF CURRENT OBJECT
    public void reset()
    {
        float yPos = Random.Range(127f,-208f);
        this._horizontalDrift = Random.Range(this.minHorizontalSpeed,this.maxHorizontalSpeed);
        this._verticalDrift = Random.Range(this.minVerticalSpeed, this.maxVerticalSpeed);
        this._transform.position = new Vector2(730f, yPos);
    }

}
