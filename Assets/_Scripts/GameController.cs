using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

    //PUBLIC INSTANCE VARIABLE
    public int enemyNumber = 3;
    public EnemyController enemy;

	// Use this for initialization
	void Start () {
        this._initialize();
	}

    //PRIVATE METHODS
    private void _initialize()
    {

        for(int enemyCount = 0; enemyCount < this.enemyNumber; enemyCount++)
        {
            Instantiate(enemy.gameObject);
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
