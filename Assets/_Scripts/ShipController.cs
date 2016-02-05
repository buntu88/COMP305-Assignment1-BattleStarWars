using UnityEngine;
using System.Collections;


//Source file name      ShipController
//Last Modified by      Vishal Guleria
//Date last Modified    February 4,2016
//Program description   COMP305 - Assignment 1 - BattleStar Wars    
//Revision History      v11


public class ShipController : MonoBehaviour
{

    //PUBLIC VARIABLE
    public float speed = 5f;

    //PRIVATE INSTANCE VARIABLE
    private float _playerInput;
    private Transform _transform;
    private Vector2 _currentPos;

    // Use this for initialization
    void Start()
    {
        this._transform = gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        this._currentPos = this._transform.position;

        this._playerInput = Input.GetAxis("Vertical");
        

        //MOVE RIGHT
        if (this._playerInput > 0)
        {
            this._currentPos += new Vector2(0, this.speed);


        }

        //MOVE LEFT
        if (this._playerInput < 0)
        {
            this._currentPos -= new Vector2(0, this.speed);

        }

        //Ristrict the player to the boundaries

        if (this._currentPos.y > 135)
        {
            this._currentPos.y = 135;
        }

        if (this._currentPos.y < -135)
        {
            this._currentPos.y = -135;
        }
        this._transform.position = this._currentPos;


    }
}
