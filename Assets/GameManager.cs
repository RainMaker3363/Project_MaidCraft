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

    public void Initilize_GameManager()
    {
        ControllOption = GameOption.GameControllOption.KEYBOARD;
        DifficultOption = GameOption.GameDifficultOption.Normal;
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
