using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Field_NPC_Character : MonoBehaviour {

    private GameOption.GameControllOption NowControlOption;
    private GameOption.Field_Event NowFieldEvent;
    public GameObject Communication_UI_Canvas;
    public GameObject NPC_Communication_UI_Prefab;

    public string NPC_Name;
    //public Sprite NPC_Illust;
    public List<Sprite> NPC_Illusts;
    public List<string> NPC_Texts;

    private int NowPrintTextNumber;
    private int NowPrintIllustNumber;
    public List<int> NowPrintIllustIndexNumber;
    private bool CanvasChecker;

	// Use this for initialization
	void Start () {

        NowPrintTextNumber = 0;

        CanvasChecker = false;

        if (NPC_Communication_UI_Prefab != null)
        {
            NPC_Communication_UI_Prefab.GetComponent<Communication_Field_UI>().Set_Character_Community_Illust(NPC_Illusts);
            NPC_Communication_UI_Prefab.GetComponent<Communication_Field_UI>().Set_Character_Community_NameTag(NPC_Name);

            for (int i = 0; i < NPC_Texts.Count-1; i++)
            {
                //NPC_Communication_UI_Prefab.GetComponent<Communication_Field_UI>().Set_Character_Community_Text(NPC_Texts[i].ToString());
                NPC_Communication_UI_Prefab.GetComponent<Communication_Field_UI>().Set_Character_Community_Text(NPC_Texts);
            }

            NPC_Communication_UI_Prefab.gameObject.SetActive(false);
        }

        if(Communication_UI_Canvas == null)
        {
            Communication_UI_Canvas = GameObject.Find("Field_UI_Canvas");
        }

        if (NowPrintIllustIndexNumber == null)
        {
            if (NPC_Texts != null)
            {
                NowPrintIllustIndexNumber = new List<int>(NPC_Texts.Count);
            }
            else
            {
                NowPrintIllustIndexNumber = new List<int>(1);
                NowPrintIllustIndexNumber[0] = 0;
            }
        }

        NowFieldEvent = GameManager.GetInstance.GetNowFieldGameEvent();
        NowControlOption = GameManager.GetInstance.GetNowControllOption();
    }

    private void OnEnable()
    {
        NowPrintTextNumber = 0;



        if (NPC_Communication_UI_Prefab != null)
        {
            NPC_Communication_UI_Prefab.GetComponent<Communication_Field_UI>().Set_Character_Community_Illust(NPC_Illusts);
            NPC_Communication_UI_Prefab.GetComponent<Communication_Field_UI>().Set_Character_Community_NameTag(NPC_Name);

            for (int i = 0; i < NPC_Texts.Count; i++)
            {
                NPC_Communication_UI_Prefab.GetComponent<Communication_Field_UI>().Set_Character_Community_Text(NPC_Texts);
            }

            NPC_Communication_UI_Prefab.gameObject.SetActive(false);
        }

        if (Communication_UI_Canvas == null)
        {
            Communication_UI_Canvas = GameObject.Find("Field_UI_Canvas");
        }

        if (NowPrintIllustIndexNumber == null)
        {
            if(NPC_Texts != null)
            {
                NowPrintIllustIndexNumber = new List<int>(NPC_Texts.Count);
            }
            else
            {
                NowPrintIllustIndexNumber = new List<int>(1);
                NowPrintIllustIndexNumber[0] = 0;
            }
        }

        NowFieldEvent = GameManager.GetInstance.GetNowFieldGameEvent();
        NowControlOption = GameManager.GetInstance.GetNowControllOption();
    }

    // Update is called once per frame
    void Update () {
        NowFieldEvent = GameManager.GetInstance.GetNowFieldGameEvent();
        NowControlOption = GameManager.GetInstance.GetNowControllOption();

        #region 필드 이벤트

        switch (NowFieldEvent)
        {
            #region 아무 이벤트 업음

            case GameOption.Field_Event.None:
                {

                    #region 키 입력 이벤트

                    switch (NowControlOption)
                    {
                        #region 게임 패드 입력

                        case GameOption.GameControllOption.GAMEPAD:
                            {
                                if (Input.GetButtonDown("P1_360_BButton"))
                                {
                                    if (CanvasChecker == true)
                                    {
                                        if (NPC_Communication_UI_Prefab != null)
                                        {
                                            NPC_Communication_UI_Prefab.GetComponent<Communication_Field_UI>().Community_TextLog_Print(1000);
                                        }
                                    }
                                }

                            }
                            break;

                        #endregion

                        #region 키보드 입력

                        case GameOption.GameControllOption.KEYBOARD:
                            {
                                if (Input.GetKeyDown(KeyCode.Escape))
                                {
                                    if (CanvasChecker == true)
                                    {
                                        if (NPC_Communication_UI_Prefab != null)
                                        {
                                            NPC_Communication_UI_Prefab.GetComponent<Communication_Field_UI>().Community_TextLog_Print(1000);
                                        }
                                    }
                                }

                            }
                            break;


                        #endregion
                    }

                    #endregion

                }
                break;

            #endregion

            #region 대화 이벤트 진행 중

            case GameOption.Field_Event.Text_Event:
                {
                    #region 키 입력 이벤트

                    switch (NowControlOption)
                    {
                        #region 게임 패드 입력

                        case GameOption.GameControllOption.GAMEPAD:
                            {
                                if (Input.GetButtonDown("P1_360_BButton"))
                                {
                                    if (CanvasChecker == true)
                                    {
                                        if (NPC_Communication_UI_Prefab != null)
                                        {
                                            NPC_Communication_UI_Prefab.GetComponent<Communication_Field_UI>().Community_TextLog_Print(1000);
                                        }
                                    }
                                }

                                if (Input.GetButtonDown("P1_360_AButton"))
                                {
                                    if (CanvasChecker == true)
                                    {
                                        if (NPC_Communication_UI_Prefab != null)
                                        {
                                            if (NPC_Communication_UI_Prefab.GetComponent<Communication_Field_UI>().GetNowTextPrintEnd() == true)
                                            {
                                                if (NowPrintTextNumber < NPC_Illusts.Count)
                                                {
                                                    NPC_Communication_UI_Prefab.GetComponent<Communication_Field_UI>().Community_TextLog_Print(NowPrintTextNumber, NowPrintIllustIndexNumber[NowPrintTextNumber]);
                                                }
                                                else
                                                {
                                                    NPC_Communication_UI_Prefab.GetComponent<Communication_Field_UI>().Community_TextLog_Print(NowPrintTextNumber, NowPrintIllustIndexNumber[0]);
                                                }

                                                NowPrintTextNumber++;

                                            }
                                           
                                        }
                                    }

                                    //if (NPC_Communication_UI_Prefab != null)
                                    //{

                                    //}
                                }

                            }
                            break;

                        #endregion

                        #region 키보드 입력

                        case GameOption.GameControllOption.KEYBOARD:
                            {
                                // 대화 스킵
                                if (Input.GetKeyDown(KeyCode.Escape))
                                {
                                    if (CanvasChecker == true)
                                    {
                                        if (NPC_Communication_UI_Prefab != null)
                                        {
                                            NPC_Communication_UI_Prefab.GetComponent<Communication_Field_UI>().Community_TextLog_Print(1000);
                                        }
                                    }
                                }

                                // 다음 대화 넘기기
                                if (Input.GetKeyDown(KeyCode.Space))
                                {
                                    if (CanvasChecker == true)
                                    {
                                        if (NPC_Communication_UI_Prefab != null)
                                        {
                                            if (NPC_Communication_UI_Prefab.GetComponent<Communication_Field_UI>().GetNowTextPrintEnd() == true)
                                            {
                                                if(NowPrintTextNumber < NPC_Illusts.Count)
                                                {
                                                    NPC_Communication_UI_Prefab.GetComponent<Communication_Field_UI>().Community_TextLog_Print(NowPrintTextNumber, NowPrintIllustIndexNumber[NowPrintTextNumber]);
                                                }
                                                else
                                                {
                                                    NPC_Communication_UI_Prefab.GetComponent<Communication_Field_UI>().Community_TextLog_Print(NowPrintTextNumber, NowPrintIllustIndexNumber[0]);
                                                }

                                                NowPrintTextNumber++;

                                            }

                                        }
                                    }

                                    //if (NPC_Communication_UI_Prefab != null)
                                    //{
                                    //    if (NPC_Communication_UI_Prefab.GetComponent<Communication_Field_UI>().GetNowTextPrintEnd() == true)
                                    //    {
                                    //        NowPrintTextNumber++;
                                    //    }
                                    //}
                                }



                            }
                            break;


                            #endregion
                    }

                    #endregion


                }
                break;

            #endregion

            #region 카메라 이벤트

            case GameOption.Field_Event.Camera_Event:
                {

                    #region 키 입력 이벤트

                    switch (NowControlOption)
                    {
                        #region 게임 패드 입력

                        case GameOption.GameControllOption.GAMEPAD:
                            {
                                if (Input.GetButtonDown("P1_360_BButton"))
                                {
                                    if (CanvasChecker == true)
                                    {
                                        if (NPC_Communication_UI_Prefab != null)
                                        {
                                            NPC_Communication_UI_Prefab.GetComponent<Communication_Field_UI>().Community_TextLog_Print(1000);
                                        }
                                    }
                                }

                            }
                            break;

                        #endregion

                        #region 키보드 입력

                        case GameOption.GameControllOption.KEYBOARD:
                            {
                                if (Input.GetKeyDown(KeyCode.Escape))
                                {
                                    if (CanvasChecker == true)
                                    {
                                        if (NPC_Communication_UI_Prefab != null)
                                        {
                                            NPC_Communication_UI_Prefab.GetComponent<Communication_Field_UI>().Community_TextLog_Print(1000);
                                        }
                                    }
                                }

                            }
                            break;


                            #endregion
                    }

                    #endregion
                }
                break;

                #endregion
        }

        #endregion
    }

    // 맨 처음 대화를 시작했을 때 캔버스 영역에다가 차일드로 추가해준다.
    public void Start_NPC_Communication_Event()
    {
        if(NPC_Communication_UI_Prefab != null &&
            Communication_UI_Canvas != null)
        {
            if(CanvasChecker == false)
            {
                CanvasChecker = true;
                NowPrintTextNumber = 0;

                NPC_Communication_UI_Prefab.transform.SetParent(Communication_UI_Canvas.transform, false);
                NPC_Communication_UI_Prefab.gameObject.SetActive(true);
            }
            else
            {
                NowPrintTextNumber = 0;

                NPC_Communication_UI_Prefab.gameObject.SetActive(true);
            }

        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            Debug.Log("Event Start!");

            switch(NowFieldEvent)
            {
                case GameOption.Field_Event.None:
                    {
                        switch (NowControlOption)
                        {
                            case GameOption.GameControllOption.GAMEPAD:
                                {
                                    if (Input.GetButtonDown("P1_360_AButton"))
                                    {
                                        GameManager.GetInstance.SetNowFieldGameEvent(GameOption.Field_Event.Text_Event);
                                        Start_NPC_Communication_Event();
                                    }
                                }
                                break;

                            case GameOption.GameControllOption.KEYBOARD:
                                {
                                    if (Input.GetKeyDown(KeyCode.Space))
                                    {
                                        GameManager.GetInstance.SetNowFieldGameEvent(GameOption.Field_Event.Text_Event);
                                        Start_NPC_Communication_Event();
                                    }
                                }
                                break;
                        }
                    }
                    break;

                case GameOption.Field_Event.Text_Event:
                    {
                        switch (NowControlOption)
                        {
                            case GameOption.GameControllOption.GAMEPAD:
                                {
                                    //if (Input.GetButtonDown("P1_360_AButton"))
                                    //{
                                    //    GameManager.GetInstance.SetNowFieldGameEvent(GameOption.Field_Event.Text_Event);
                                    //    Start_NPC_Communication_Event();
                                    //}
                                }
                                break;

                            case GameOption.GameControllOption.KEYBOARD:
                                {
                                    //if (Input.GetKeyDown(KeyCode.Space))
                                    //{
                                    //    GameManager.GetInstance.SetNowFieldGameEvent(GameOption.Field_Event.Text_Event);
                                    //    Start_NPC_Communication_Event();
                                    //}
                                }
                                break;
                        }
                    }
                    break;

                case GameOption.Field_Event.Camera_Event:
                    {
                        switch (NowControlOption)
                        {
                            case GameOption.GameControllOption.GAMEPAD:
                                {
                                    //if (Input.GetButtonDown("P1_360_AButton"))
                                    //{
                                    //    GameManager.GetInstance.SetNowFieldGameEvent(GameOption.Field_Event.Text_Event);
                                    //    Start_NPC_Communication_Event();
                                    //}
                                }
                                break;

                            case GameOption.GameControllOption.KEYBOARD:
                                {
                                    //if (Input.GetKeyDown(KeyCode.Space))
                                    //{
                                    //    GameManager.GetInstance.SetNowFieldGameEvent(GameOption.Field_Event.Text_Event);
                                    //    Start_NPC_Communication_Event();
                                    //}
                                }
                                break;
                        }
                    }
                    break;
            }


        }
    }
}
