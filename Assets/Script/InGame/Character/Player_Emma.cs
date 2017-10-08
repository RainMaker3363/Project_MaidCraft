using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Emma : MonoBehaviour {

    private CharacterInterface Character_Infomation;

    // 게임 설정 값들
    private GameOption.GameControllOption NowControllOption;
    private GameOption.GameDifficultOption NowDifficultOption;

    // Use this for initialization
    void Awake () {
        
        // 맨 처음 세팅을 초기화 받는다.
        NowControllOption = GameManager.GetInstance.GetNowControllOption();
        NowDifficultOption = GameManager.GetInstance.GetNowDifficultOption();
    }
	
	// Update is called once per frame
	void Update () {

        // 컨트롤 옵션을 체크 받는다.
        NowControllOption = GameManager.GetInstance.GetNowControllOption();

        switch (NowControllOption)
        {
            case GameOption.GameControllOption.KEYBOARD:
                {

                }
                break;

            case GameOption.GameControllOption.GAMEPAD:
                {
                    if (Input.GetButtonDown("P1_360_AButton"))
                    {
                        Debug.Log("A Button!");
                    }
                    if (Input.GetButtonDown("P1_360_BButton"))
                    {
                        Debug.Log("B Button!");
                    }
                    if (Input.GetButtonDown("P1_360_XButton"))
                    {
                        Debug.Log("X Button!");
                    }
                    if (Input.GetButtonDown("P1_360_YButton"))
                    {
                        Debug.Log("Y Button!");
                    }
                    if (Input.GetButtonDown("P1_360_LeftBumper"))
                    {
                        Debug.Log("Left Bumper!");
                    }
                    if (Input.GetButtonDown("P1_360_RightBumper"))
                    {
                        Debug.Log("Right Bumper!");
                    }
                    if (Input.GetButtonDown("P1_360_BackButton"))
                    {
                        Debug.Log("Back Button!");
                    }
                    if (Input.GetButtonDown("P1_360_StartButton"))
                    {
                        Debug.Log("Start Button!");
                    }
                    if (Input.GetButtonDown("P1_360_LeftThumbStickButton"))
                    {
                        Debug.Log("Left Thumbstick Button!");
                    }
                    if (Input.GetButtonDown("P1_360_RightThumbStickButton"))
                    {
                        Debug.Log("Right Thumbstick Button!");
                    }

                    if (Input.GetAxis("P1_360_Triggers") > 0.001)
                    {
                        Debug.Log("Right Trigger!");
                    }
                    if (Input.GetAxis("P1_360_Triggers") < 0)
                    {
                        Debug.Log("Left Trigger!");
                    }
                    if (Input.GetAxis("P1_360_HorizontalDPAD") > 0.001)
                    {
                        Debug.Log("Right D-PAD Button!");
                    }
                    if (Input.GetAxis("P1_360_HorizontalDPAD") < 0)
                    {
                        Debug.Log("Left D-PAD Button!");
                    }
                    if (Input.GetAxis("P1_360_VerticalDPAD") > 0.001)
                    {
                        Debug.Log("Up D-PAD Button!");
                    }
                    if (Input.GetAxis("P1_360_VerticalDPAD") < 0)
                    {
                        Debug.Log("Down D-PAD Button!");
                    }
                }
                break;
        }
	}
}
