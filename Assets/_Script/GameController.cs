using UnityEngine;
using System.Collections;
using UnityEngine.UI;

/*
    Source File Name: GameController
    Author's Name: Vinay Bhardwaj
    Last Modified By: Vinay Bhardwaj
    Date Last Modified: 5th February 2016
    Program Descreption: COMP305-ASSIGNMENT 1-HELI ATTACK
    Revision History: v16
*/

public class GameController : MonoBehaviour {
    //PRIVATE INSTANCE VARIABLES
    private int _scoreValues;
    private int _livesValues;
    [SerializeField] //SERIALIZED FIELDS TO BE ACCESSED IN INSPECTOR
    private AudioSource _gameOverSound;
    [SerializeField]
    private AudioSource _skySound; 
    
    //PUBLIC INSTANCE VARIABLES
    public EnemyController helicopter;
    public Text ScoreLabel;
    public Text LivesLabel;
    public Text GameOverLabel;
    public Text HighScoreLabel;
    public PlayerController player;
    public CoinController Coin5;
    public CoinController Coin25;
    public CoinController Coin100;
    public CoinController Coin500;
    public EnemyController Enemy1;
    public EnemyController Enemy2;
    public EnemyController Enemy3;
    public EnemyPlaneController EnemyPlane;
    public Button RestartButton;
    public Button StartButton;
    public Button QuitButton;
    public Text StartingLogo;
    public Text NameBy;

    public int ScoreValues
    {
        get
        {
            return this._scoreValues;
        }

        set
        {
            this._scoreValues = value;
            this.ScoreLabel.text = "Score: " + this._scoreValues;
        }
    }

    public int LivesValues
    {
        get
        {
            return this._livesValues;
        }

        set
        {
            this._livesValues = value;
            if (this._livesValues <= 0)
            {
                this._endGame();
            }
            else
            {
                this.LivesLabel.text = "Lives: " + this._livesValues;
            }
            
        }
    }
	// Use this for initialization
	void Start () {
        
        
        this._hideAll();
        

    }
	
	// Update is called once per frame
	void Update () {
        
	}

    //PRIVATE METHODS
    private void _init()
    {
        this.LivesLabel.enabled = true;
        this.ScoreLabel.enabled = true;
        this.GameOverLabel.enabled = false;
        this.HighScoreLabel.enabled = false;
        this.player.gameObject.SetActive(true);
        this.Enemy1.gameObject.SetActive(true);
        this.Enemy2.gameObject.SetActive(true);
        this.Enemy3.gameObject.SetActive(true);
        this.EnemyPlane.gameObject.SetActive(true);
        this.Coin5.gameObject.SetActive(true);
        this.Coin500.gameObject.SetActive(true);
        this.Coin25.gameObject.SetActive(true);
        this.Coin100.gameObject.SetActive(true);
        this.ScoreValues = 0;
        this.LivesValues = 5;
        this._gameOverSound.Stop();
        this.RestartButton.gameObject.SetActive(false);
        this.StartButton.gameObject.SetActive(false);
        this.QuitButton.gameObject.SetActive(false);
        this.StartingLogo.enabled = false;
        this.NameBy.enabled = false;

    }

    //CALLED WHEN LIVES GET TO 0
    private void _endGame()
    {
        this.HighScoreLabel.text = "HighScore: "+ this._scoreValues;
        this.LivesLabel.enabled = false;
        this.ScoreLabel.enabled = false;
        this.GameOverLabel.enabled = true;
        this.HighScoreLabel.enabled = true;
        this.player.gameObject.SetActive(false);
        this.Enemy1.gameObject.SetActive(false);
        this.Enemy2.gameObject.SetActive(false);
        this.Enemy3.gameObject.SetActive(false);
        this.EnemyPlane.gameObject.SetActive(false);
        this.Coin5.gameObject.SetActive(false);
        this.Coin500.gameObject.SetActive(false);
        this.Coin25.gameObject.SetActive(false);
        this.Coin100.gameObject.SetActive(false);
        this._gameOverSound.Play();
        this._skySound.Stop();
        this.RestartButton.gameObject.SetActive(true);
        this.QuitButton.gameObject.SetActive(true);
    }

    private void _hideAll()
    {
        this.LivesLabel.enabled = false;
        this.ScoreLabel.enabled = false;
        this.GameOverLabel.enabled = false;
        this.HighScoreLabel.enabled = false;
        this.player.gameObject.SetActive(false);
        this.Enemy1.gameObject.SetActive(false);
        this.Enemy2.gameObject.SetActive(false);
        this.Enemy3.gameObject.SetActive(false);
        this.EnemyPlane.gameObject.SetActive(false);
        this.Coin5.gameObject.SetActive(false);
        this.Coin500.gameObject.SetActive(false);
        this.Coin25.gameObject.SetActive(false);
        this.Coin100.gameObject.SetActive(false);
        this._gameOverSound.Stop();
        this.StartButton.gameObject.SetActive(true);
        this.StartingLogo.enabled = true;
        this.NameBy.enabled = true;
    }

    public void startButton()
    {
        this._init();
    }

    //FUNCTIONALITY OF RESTART BUTTON
    public void restartButton()
    {
        Application.LoadLevel("Main");
        this.RestartButton.gameObject.SetActive(false);
    }

    public void quitButton()
    {
        Application.Quit();
    }
}
