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

    public enum Field_Event
    {
        None = 0,
        Text_Event,
        Camera_Event,
    }
}

public class GameManager : Singleton<GameManager>
{
    private GameOption.GameControllOption ControllOption;
    private GameOption.GameDifficultOption DifficultOption;
    private GameOption.Field_Event Field_event;

    //private GameOption.InGameTurn NowGameTurnState;

    // 텍스트 넘김 여부 타이머
    private float TextSkipTimer = 1.0f;
    // 텍스트 출력 타이머
    private float TextPrintTimer = 0.03f;

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
        Field_event = GameOption.Field_Event.None;

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

    // 현재 필드에서 일어나는 이벤트를 감지한다.
    public GameOption.Field_Event GetNowFieldGameEvent()
    {
        return Field_event;
    }

    public void SetNowFieldGameEvent(GameOption.Field_Event Event)
    {
        Field_event = Event;
    }

    // 텍스트 출력 타이머 반환
    public float GetFieldTextPrintTimer()
    {
        return TextPrintTimer;
    }

    public void SetFieldTextPrintTimer(float Timer = 1.0f)
    {
        TextPrintTimer = Timer;
    }

    // 텍스트 스킵 타이머 반환
    public float GetFieldTextSkipTimer()
    {
        return TextSkipTimer;
    }

    public void SetFieldTextSkipTimer(float Timer = 0.03f)
    {
        TextSkipTimer = Timer;
    }

}
