using UnityEngine;
using System.Collections;

public class SpaceController : MonoBehaviour {

    //PRIVATE INSTANCE VARIABLE
    private Transform _tranform;
    public float speed = 5;
    private Vector2 _currentPos;



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
