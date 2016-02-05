using UnityEngine;
using System.Collections;


//Source file name      SpaceController
//Last Modified by      Vishal Guleria
//Date last Modified    February 4,2016
//Program description   COMP305 - Assignment 1 - BattleStar Wars    
//Revision History      v11


public class SpaceController : MonoBehaviour {

    //PRIVATE INSTANCE VARIABLE
    private Transform _tranform;
    private Vector2 _currentPos;

    public float speed = 5;

    // Use this for initialization
    void Start () {
        //link the tranform - make refrence with transform componenent
        this._tranform = gameObject.GetComponent<Transform>();
        this.Reset();



	}
	
	// Update is called once per frame
	void Update () {
        this._currentPos = this._tranform.position;
        this._currentPos -= new Vector2(this.speed,0);
        this._tranform.position = this._currentPos;
        if (this._currentPos.x <= -507.5)
        {
            this.Reset();
        }
	}

    public void Reset()
    {
        //add vector
        this._tranform.position = new Vector2(692f, 0);

    }
}
