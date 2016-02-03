using UnityEngine;
using System.Collections;

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
        Debug.Log(this._playerInput);

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

        if (this._currentPos.y > 140)
        {
            this._currentPos.y = 140;
        }

        if (this._currentPos.y < -140)
        {
            this._currentPos.y = -140;
        }
        this._transform.position = this._currentPos;


    }
}
