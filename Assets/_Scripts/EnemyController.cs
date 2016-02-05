using UnityEngine;
using System.Collections;



//Source file name      EnemyController
//Last Modified by      Vishal Guleria
//Date last Modified    February 4,2016
//Program description   COMP305 - Assignment 1 - BattleStar Wars    
//Revision History      v11



public class EnemyController : MonoBehaviour {

    

    private Transform _tranform;
    private Vector2 _currentPos;
    public float minVerticalSpeed = -2f;
    public float maxVerticalSpeed = 2f;
    public float minHorizontalSpeed = 5f;
    public float maxHorizontalSpeed = 10f;
    private float _verticalSpeed;
    private float _horizontalDrift;

    void Start()
    {
        //link the tranform - make refrence with transform componenent
        this._tranform = gameObject.GetComponent<Transform>();
        this.Reset();

    }
    public GameController gameController;
    public void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("Enemy"))
        {
            this._verticalSpeed = -this._verticalSpeed;


        }
    }
    // Update is called once per frame
    void Update()
    {

        this._currentPos = this._tranform.position;
        this._currentPos -= new Vector2(_horizontalDrift, _verticalSpeed);

        if (this._currentPos.y > 135f)
        {
            
            this._verticalSpeed = -this._verticalSpeed;
        }

        if (this._currentPos.y < -135f)
        {
           
            this._verticalSpeed = -this._verticalSpeed;
        }

        this._tranform.position = this._currentPos;
        if (this._currentPos.x <= -245)
        {
            this.Reset();
        }
    }

    
    public void Reset()
    {


        float yPos = Random.Range(-140f, 140f);
        float xPos = Random.Range(240f, 500f);
        //add vector



        this._tranform.position = new Vector2(xPos, yPos);
        this._verticalSpeed = Random.Range(this.minVerticalSpeed, this.maxVerticalSpeed);
        this._horizontalDrift = Random.Range(this.minHorizontalSpeed, maxHorizontalSpeed);
        
    }
}
