
    //Developed by Shraddhaben Patel 300821026
    //Last Modified by Shraddhaben Patel
    //Last Modified Date: Mar 25,2016

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HouseController : MonoBehaviour {
    private GameController _gameController;


    // Use this for initialization
    void Start () {
        this._gameController = GameObject.FindWithTag("GameController").GetComponent("GameController") as GameController;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
    public void OnTriggerEnter(Collider otherGameObject)
    {


        if (otherGameObject.gameObject.CompareTag("Player"))
        {
            this._gameController._endGame();
            
        }



    }

   
}
