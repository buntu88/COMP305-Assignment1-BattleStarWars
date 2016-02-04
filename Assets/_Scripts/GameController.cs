using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    private int _scoreValue;
    private int _livesValue;


    [SerializeField]
    private AudioSource _gameOver;

    //PUBLIC INSTANCE VARIABLE
    public int enemyNumber = 3;
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
