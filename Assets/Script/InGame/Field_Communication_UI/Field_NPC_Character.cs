using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Field_NPC_Character : MonoBehaviour {

    private GameOption.Field_Event NowFieldEvent;
    public GameObject Communication_UI_Canvas;
    public GameObject NPC_Communication_UI_Prefab;

    public string NPC_Name;
    public Sprite NPC_Illust;
    public List<string> NPC_Texts;

    private int NowPrintTextNumber;
    private bool CanvasChecker;

	// Use this for initialization
	void Start () {

        NowPrintTextNumber = 0;
        CanvasChecker = false;

        if (NPC_Communication_UI_Prefab != null)
        {
            NPC_Communication_UI_Prefab.GetComponent<Communication_Field_UI>().Set_Character_Community_Illust(NPC_Illust);
            NPC_Communication_UI_Prefab.GetComponent<Communication_Field_UI>().Set_Character_Community_NameTag(NPC_Name);

            for (int i = 0; i < NPC_Texts.Count; i++)
            {
                NPC_Communication_UI_Prefab.GetComponent<Communication_Field_UI>().Set_Character_Community_Text(NPC_Texts[i].ToString());
            }

            NPC_Communication_UI_Prefab.gameObject.SetActive(false);
        }

        if(Communication_UI_Canvas == null)
        {
            Communication_UI_Canvas = GameObject.Find("Field_UI_Canvas");
        }

        NowFieldEvent = GameManager.GetInstance.GetNowFieldGameEvent();
    }

    private void OnEnable()
    {
        NowPrintTextNumber = 0;

        if (NPC_Communication_UI_Prefab != null)
        {
            NPC_Communication_UI_Prefab.GetComponent<Communication_Field_UI>().Set_Character_Community_Illust(NPC_Illust);
            NPC_Communication_UI_Prefab.GetComponent<Communication_Field_UI>().Set_Character_Community_NameTag(NPC_Name);

            for (int i = 0; i < NPC_Texts.Count; i++)
            {
                NPC_Communication_UI_Prefab.GetComponent<Communication_Field_UI>().Set_Character_Community_Text(NPC_Texts[i].ToString());
            }

            NPC_Communication_UI_Prefab.gameObject.SetActive(false);
        }

        if (Communication_UI_Canvas == null)
        {
            Communication_UI_Canvas = GameObject.Find("Field_UI_Canvas");
        }

        NowFieldEvent = GameManager.GetInstance.GetNowFieldGameEvent();
    }

    // Update is called once per frame
    void Update () {
        NowFieldEvent = GameManager.GetInstance.GetNowFieldGameEvent();

        switch(NowFieldEvent)
        {
            case GameOption.Field_Event.None:
                {
                    if(CanvasChecker == true)
                    {
                        if (NPC_Communication_UI_Prefab != null)
                        {
                            NPC_Communication_UI_Prefab.GetComponent<Communication_Field_UI>().Community_TextLog_Print(1000);
                        }
                    }
                    
                }
                break;

            case GameOption.Field_Event.Text_Event:
                {
                    if (CanvasChecker == true)
                    {
                        if (NPC_Communication_UI_Prefab != null)
                        {
                            NPC_Communication_UI_Prefab.GetComponent<Communication_Field_UI>().Community_TextLog_Print(NowPrintTextNumber);
                        }
                    }

                    if(Input.GetKeyDown(KeyCode.Backspace))
                    {
                        NowPrintTextNumber++;
                    }
                }
                break;

            case GameOption.Field_Event.Camera_Event:
                {
                    if (CanvasChecker == true)
                    {
                        if (NPC_Communication_UI_Prefab != null)
                        {
                            NPC_Communication_UI_Prefab.GetComponent<Communication_Field_UI>().Community_TextLog_Print(1000);
                        }
                    }
                }
                break;
        }
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

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            Debug.Log("Event Start!");

            GameManager.GetInstance.SetNowFieldGameEvent(GameOption.Field_Event.Text_Event);
            Start_NPC_Communication_Event();
        }
    }
}
