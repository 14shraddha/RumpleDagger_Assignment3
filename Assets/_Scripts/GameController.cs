//GameController

//Developed by Shraddhaben Patel 300821026
//Last Modified by Shraddhaben Patel
//Last Modified Date: Mar 25,2016


using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{

    //Private instance variables
    private int _scoreValue;
    private int _livesValue;

    private Vector3 _playerSpawnPoint;
    //Public Access methods

    public int ScoreValue
    {
        get
        {
            return _scoreValue;
        }
        set
        {
            this._scoreValue = value;
            this.ScoreLable.text = "Score:" + this._scoreValue;
            Debug.Log(this._scoreValue);
        }
    }

    public int LivesValue
    {
        get
        {
            return _livesValue;
        }
        set
        {
            this._livesValue = value;

            if (this._livesValue <= 0)
            {
                this._endGame();
            }
            else
            {
                this._livesValue = value;
                this.LivesLable.text = "Lives:" + this._livesValue;
            }

        }
    }

    //Public Instances
    public Text LivesLable;
    public Text ScoreLable;
    public Text GameOverLable;
    public Text HighScoreLable;
    public Text WinLabel;
    public Button RestartButton;
    public GameObject player;

   

    // Use this for initialization
    void Start()
    {
        this._intitialize();
        Instantiate(this.player, this._playerSpawnPoint, Quaternion.identity);

    }

    // Update is called once per frame
    void Update()
    {

    }

    //********PRIVATE METHODS***********
    private void _intitialize()
    {
        this._playerSpawnPoint = new Vector3(23f, 0.6f, 1.1f);
        this._scoreValue = 0;
        this._livesValue = 5;
        this.GameOverLable.enabled = false;
        this.HighScoreLable.enabled = false;
        this.WinLabel.enabled = false;
        this.RestartButton.gameObject.SetActive(false);

        
    }

    public void _endGame()
    {
        this.HighScoreLable.text = "High Score: " + this._scoreValue;
        if (LivesValue > 0)
        {
            this.GameOverLable.text = "You Won";
        }
        this.GameOverLable.enabled = true;
        this.HighScoreLable.enabled = true;
        this.RestartButton.gameObject.SetActive(true);

        this.LivesLable.enabled = false;
        this.ScoreLable.enabled = false;
        
    }

    //Public methods

    public void RestartButtonClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


}
