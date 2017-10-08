using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleManager : MonoBehaviour {

    public GameObject Player_Field;
    public GameObject Enemy_Field;

    //private GameOption.InGameTurn NowGameTurn;

	// Use this for initialization
	void Awake () {

        if(GameManager.GetInstance != null)
        {
            //GameManager.GetInstance.Initilize_Battle();
            //NowGameTurn = GameManager.GetInstance.GetNowGameTurn();
        }
        
        if(Player_Field == null)
        {
            Player_Field = GameObject.Find("Player_Field").gameObject;
        }

        if(Enemy_Field == null)
        {
            Enemy_Field = GameObject.Find("Enemy_Field").gameObject;
        }
	}
	
	// Update is called once per frame
	void Update () {

        //NowGameTurn = GameManager.GetInstance.GetNowGameTurn();

        //switch (NowGameTurn)
        //{
        //    case GameOption.InGameTurn.Player:
        //        {

        //        }
        //        break;

        //    case GameOption.InGameTurn.Enemy:
        //        {

        //        }
        //        break;
        //}
	}
}
