using UnityEngine;
using System.Collections;

/*
    Source File Name: CoinController
    Author's Name: Vinay Bhardwaj
    Last Modified By: Vinay Bhardwaj
    Date Last Modified: 5th February 2016
    Program Descreption: COMP305-ASSIGNMENT 1-HELI ATTACK
    Revision History: v16
*/
public class CoinController : MonoBehaviour {
    //PRIVATE INSTANCE VARIABLES
    private Transform _transform;
    private Vector2 _currentPosition;

    public float speed = 5f;
	// Use this for initialization
	void Start () {
        this._transform = gameObject.GetComponent<Transform>();//GETTING THE TRANSFORMATION COMPONENT OF THE CURRENT OBJECT
        this.reset();
    }
	
	// Update is called once per frame
	void Update () {
        this._currentPosition = this._transform.position;
        this._currentPosition -= new Vector2(this.speed, 0);
        this._transform.position = this._currentPosition;

        if (this._currentPosition.x <= -190)
        {
            this.reset();
        }
    }
    //PUBLIC METHOD TO RESET THE POSITION OF CURRENT OBJECT
    public void reset()
    {
        float xpos = Random.Range(750f, 1600f);
        float yPos = Random.Range(127f, -208f);//Boundary Checking
        this._transform.position = new Vector2(xpos, yPos);
    }
}
