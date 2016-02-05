using UnityEngine;
using System.Collections;
using UnityEngine.UI;


//Source file name      GameController
//Last Modified by      Vishal Guleria
//Date last Modified    February 4,2016
//Program description   COMP305 - Assignment 1 - BattleStar Wars    
//Revision History      v11


public class GameController : MonoBehaviour {

    private int _scoreValue;
    private int _livesValue;
    private int enemyNumber = 2;
    private int difficultyBenchmark = 1500;

    [SerializeField]
    private AudioSource _gameOver;

    //PUBLIC INSTANCE VARIABLE
    
    public Text Lives;
    public Text Points;
    public Text GameOverLabel;
    public Text HighScoreLabel;
    public ShipController ship;
    public PlanetController planet;
    public EnemyController enemy;
    public Button ResetButton;


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
            
            this.Points.text = "Score: "+ this._scoreValue;
            if(this._scoreValue == this.difficultyBenchmark)
            {
                this.enemyNumber = 1;
                enemyGenerator();
            }
            if (this._scoreValue == this.difficultyBenchmark*2)
            {
                this.enemyNumber = 1;
                enemyGenerator();
            }
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
            if (this._livesValue <= 0)
            {
                this._endGame();
            }
                this.Lives.text = "Lives: " + this._livesValue;
            

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
        this.GameOverLabel.enabled = false;
        this.ResetButton.gameObject.SetActive(false);
        enemyGenerator();

    }


    //Generate more enemies on high level
    public void enemyGenerator()
    {
        for (int enemyCount = 0; enemyCount < this.enemyNumber; enemyCount++)
        {
            Instantiate(enemy.gameObject);
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    private void _endGame()
    {
        this.HighScoreLabel.text = "High Scrore: " + this._scoreValue;
        this.GameOverLabel.enabled = true;
        this.HighScoreLabel.enabled = true;
        this._gameOver.Play();
        this.ship.gameObject.SetActive(false);
        this.planet.gameObject.SetActive(false);
        this.Points.enabled = false;
        this.Lives.enabled = false;
        this.ResetButton.gameObject.SetActive(true);

    }

    public void RestartButtonClick()
    {
        Application.LoadLevel("Main");
    }
}
