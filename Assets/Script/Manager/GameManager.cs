using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameOption
{
    public enum GameControllOption
    {
        GAMEPAD  = 0,
        KEYBOARD = 1,
        MAX
    }

    public enum GameDifficultOption
    {
        Easy = 0,
        Normal = 1,
        Hard = 2,
        MAX
    }
}

public class GameManager : Singleton<GameManager>
{
    private GameOption.GameControllOption ControllOption;
    private GameOption.GameDifficultOption DifficultOption;

    //private GameOption.InGameTurn NowGameTurnState;

    #region Battle Instance

    //// 플레이어의 턴을 관리한다.
    //public int PlayerTurnCount
    //{
    //    get
    //    {
    //        return PlayerTurnCount;
    //    }
    //    set
    //    {
    //        PlayerTurnCount = value;
    //    }
    //}
    
    // 플레이어 캐릭터의 수를 관리한다.
    public int PlayerCount
    {
        get
        {
            return PlayerCount;
        }
        set
        {
            if(value <= 0)
            {
                PlayerCount = 1;
            }
            else
            {
                PlayerCount = value;
            }
            
        }
    }

    // 적의 캐릭터 수를 관리한다.
    public int EnemyCount
    {
        get
        {
            return EnemyCount;
        }
        set
        {
            if(value <= 0)
            {
                EnemyCount = 1;
            }
            else
            {
                EnemyCount = value;
            }
            
        }
    }

    //// 배틀 시작후 초기화를 시켜준다.
    //public void Initilize_Battle()
    //{
    //    int FairChecker = Random.Range(0, 2);

    //    if (FairChecker == 0)
    //    {
    //        NowGameTurnState = GameOption.InGameTurn.Player;
    //    }
    //    else
    //    {
    //        NowGameTurnState = GameOption.InGameTurn.Enemy;
    //    }
    //}

    //// 현재 누구의 턴인지 알려준다.
    //public GameOption.InGameTurn GetNowGameTurn()
    //{
    //    return NowGameTurnState;
    //}

    #endregion

    public void Initilize_GameManager()
    {
        ControllOption = GameOption.GameControllOption.KEYBOARD;
        DifficultOption = GameOption.GameDifficultOption.Normal;

        //NowGameTurnState = GameOption.InGameTurn.Player;
    }



    // 현재 게임에서 선택된 컨트롤 옵션을 반환
    public GameOption.GameControllOption GetNowControllOption()
    {
        return ControllOption;
    }

    // 현재 게임에서 선택된 난이도를 반환
    public GameOption.GameDifficultOption GetNowDifficultOption()
    {
        return DifficultOption;
    }


}
