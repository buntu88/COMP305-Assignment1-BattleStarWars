using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

    private int _scoreValue;
    private int _livesValue;

    //PUBLIC INSTANCE VARIABLE
    public int enemyNumber = 3;
    public EnemyController enemy;

    // PUBLIC ACCESS METHODS
    public int ScoreValue
    {
        get
        {
            return this._scoreValue;
        }

        set
        {
            this._scoreValue = value;
            Debug.Log(this._scoreValue);
        }
    }


    public int LivesValue
    {
        get
        {
            return this._livesValue;
        }

        set
        {
            this._livesValue = value;
            Debug.Log(this._livesValue);
        }
    }


    // Use this for initialization
    void Start () {
        this._initialize();
	}

    //PRIVATE METHODS
    private void _initialize()
    {
        this.ScoreValue = 0;
        this.LivesValue = 5;

        for (int enemyCount = 0; enemyCount < this.enemyNumber; enemyCount++)
        {
            Instantiate(enemy.gameObject);
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
