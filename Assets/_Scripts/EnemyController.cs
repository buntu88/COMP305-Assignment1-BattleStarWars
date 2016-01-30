using UnityEngine;
using System.Collections;

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

    // Update is called once per frame
    void Update()
    {
        this._currentPos = this._tranform.position;
        this._currentPos -= new Vector2(_horizontalDrift, _verticalSpeed);
        this._tranform.position = this._currentPos;
        if (this._currentPos.x <= -245)
        {
            this.Reset();
        }
    }

    public void Reset()
    {
        float yPos = Random.Range(-140f, 140f);
        //add vector
        this._tranform.position = new Vector2(240, yPos);
        this._verticalSpeed = Random.Range(this.minVerticalSpeed, this.maxVerticalSpeed);
        this._horizontalDrift = Random.Range(this.minHorizontalSpeed, maxHorizontalSpeed);
        Debug.Log(_verticalSpeed);
    }
}
