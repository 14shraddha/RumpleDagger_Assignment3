
//Developed by Shraddhaben Patel 300821026
//Last Modified by Shraddhaben Patel
//Last Modified Date: Mar 25,2016
using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {


    //Private Instances
    private Transform _transform;
    private GameController _gameController;


    // Use this for initialization
    void Start () {

        this._transform = gameObject.GetComponent<Transform>();
        this._gameController = GameObject.FindWithTag("GameController").GetComponent("GameController") as GameController;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        //RaycastHit hit;

        //if(Physics.Raycast(this._transform.position,this._transform.forward,out hit, 5f))
        //{
        //    if (hit.transform.gameObject.CompareTag("bottle"))
        //    {
        //        this.gameController.ScoreValue += 100; // to increase the score  by 100 
        //    }
        //}

	}

    //PUBLIC METHODS
    public void OnTriggerEnter(Collider otherGameObject)
    {


        if (otherGameObject.gameObject.CompareTag("potion"))
        {
            this._gameController.ScoreValue += 100; // to increase the score  by 100 
            Destroy(otherGameObject.gameObject);
        }
        if (otherGameObject.gameObject.CompareTag("spike"))
        {
            this._gameController.LivesValue -= 1;  // To decrease the life  by 1 when hit 
        }
        if (otherGameObject.gameObject.CompareTag("barrier"))
        {
            this._gameController.LivesValue -= 1;  // To decrease the life by 1 when hit
        }


    }
}
