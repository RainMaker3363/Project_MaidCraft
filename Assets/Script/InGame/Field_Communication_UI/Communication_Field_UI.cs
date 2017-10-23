using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Communication_Field_UI : MonoBehaviour {

    public GameObject Character_Illust_Object;
    public GameObject Character_NameTag_Object;
    public Text Character_Text_Object;
    public List<string> Character_Texts;
    public List<Sprite> Character_Illusts;

    public GameObject Skip_Key_Icon_Object;
    public Sprite Skip_KeyBoard_Key_Icon;
    public Sprite Skip_GamePad_Key_Icon;

    // 현재 텍스트 출력이 다 끝났는지 여부
    private bool TextPrintEnd;

    // 텍스트 넘김 여부 타이머
    private float TextSkipTimer;
    private float TextPrintTimer;

	// Use this for initialization
	void Start () {
        if (Character_Texts == null)
        {
            Character_Texts = new List<string>(1);
        }

        if(Character_Illusts == null)
        {
            Character_Illusts = new List<Sprite>(1);
        }

        TextPrintEnd = true;

        TextSkipTimer = GameManager.GetInstance.GetFieldTextSkipTimer();
        TextPrintTimer = GameManager.GetInstance.GetFieldTextPrintTimer();
    }

    private void OnEnable()
    {
        if (Character_Texts == null)
        {
            Character_Texts = new List<string>(1);
        }

        if (Character_Illusts == null)
        {
            Character_Illusts = new List<Sprite>(1);
        }

        TextPrintEnd = true;

        TextSkipTimer = GameManager.GetInstance.GetFieldTextSkipTimer();
        TextPrintTimer = GameManager.GetInstance.GetFieldTextPrintTimer();
    }

    // Update is called once per frame
    void Update () {
		switch(GameManager.GetInstance.GetNowControllOption())
        {
            case GameOption.GameControllOption.KEYBOARD:
                {
                    if(Skip_Key_Icon_Object != null)
                    {
                        if(Skip_KeyBoard_Key_Icon != null)
                        {
                            Skip_Key_Icon_Object.GetComponent<Image>().overrideSprite = Skip_KeyBoard_Key_Icon;
                        }
                        
                    }
                }
                break;

            case GameOption.GameControllOption.GAMEPAD:
                {
                    if (Skip_Key_Icon_Object != null)
                    {
                        if (Skip_GamePad_Key_Icon != null)
                        {
                            Skip_Key_Icon_Object.GetComponent<Image>().overrideSprite = Skip_GamePad_Key_Icon;
                        }

                    }
                }
                break;
        }
	}

    public void Set_Character_Community_Illust(Sprite Char_Illust)
    {
        if (Char_Illust != null &&
            Character_Illusts != null
            )
        {
            Character_Illusts.Add(Char_Illust);
        }


    }

    public void Set_Character_Community_Illust(List<Sprite> Char_Illust)
    {
        if (Char_Illust != null &&
            Character_Illusts != null
            )
        {
            Character_Illusts = Char_Illust;
        }


    }

    public void Set_Character_Community_NameTag(string Nametag = "")
    {
        if(Character_NameTag_Object != null)
        {
            Character_NameTag_Object.GetComponent<Text>().text = Nametag;
        }
    }


    public void Set_Character_Community_Text(string text = "")
    {
        if (Character_Texts != null)
        {
            Character_Texts.Add(text);
        }
    }

    public bool GetNowTextPrintEnd()
    {
        return TextPrintEnd;
    }

    public void Set_Character_Community_Text(List<string> texts)
    {
        if (Character_Texts != null &&
            texts != null)
        {
            Character_Texts = texts;
        }
    }

    public void Community_TextLog_Print(int NowPrintTextCount = 0, int NowPrintIllustCount = 0)
    {
        //Character_Text_Object.text = "";
        if (NowPrintIllustCount < Character_Illusts.Count)
        {
            IllustLogoPrint_Protocol(NowPrintIllustCount);
        }
        else
        {
            IllustLogoPrint_Protocol(0);
        }

        if (NowPrintTextCount < Character_Texts.Count)
        {
            Character_Text_Object.text = " ";

            StopCoroutine(TextSkip_Protocol());
            StartCoroutine(TextSkip_Protocol());



            StopCoroutine(TextLogPrint_Protocol(NowPrintTextCount));
            StartCoroutine(TextLogPrint_Protocol(NowPrintTextCount));
        }
        else
        {
            Character_Text_Object.text = " ";

            StopCoroutine(TextSkip_Protocol());
            StartCoroutine(TextSkip_Protocol());

            StopCoroutine(TextLogPrint_Protocol(NowPrintTextCount));

            StopCoroutine(TextLogTerminate_Protocol());
            StartCoroutine(TextLogTerminate_Protocol());

            GameManager.GetInstance.SetNowFieldGameEvent(GameOption.Field_Event.None);
        }
        
    }


    IEnumerator TextLogPrint_Protocol(int NowPrintTextCount = 0)
    {
        if (Character_Text_Object != null)
        {
            Character_Text_Object.text = " ";

            for (int i = 0; i< Character_Texts[NowPrintTextCount].Length; i++)
            {
                Character_Text_Object.text += Character_Texts[NowPrintTextCount][i];
                yield return new WaitForSeconds(TextPrintTimer);
            }
            
        }
    }

    public void IllustLogoPrint_Protocol(int NowPrintIllustCount = 0)
    {
        if(Character_Illust_Object != null)
        {
            Character_Illust_Object.GetComponent<Image>().overrideSprite = Character_Illusts[NowPrintIllustCount];
        }
    }

    IEnumerator TextLogTerminate_Protocol()
    {
        Character_Text_Object.text = " ";

        yield return new WaitForSeconds(0.1f);

        TextPrintEnd = true;
        this.gameObject.SetActive(false);
    }

    IEnumerator TextSkip_Protocol()
    {
        TextPrintEnd = false;
        Debug.Log("TextPrintEnd : " + TextPrintEnd);

        yield return new WaitForSeconds(TextSkipTimer);

        TextPrintEnd = true;
        Debug.Log("TextPrintEnd : " + TextPrintEnd);
    }
}
