using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Communication_Field_UI : MonoBehaviour {



    public GameObject Character_Illust_Object;
    public GameObject Character_NameTag_Object;
    public Text Character_Text_Object;
    public List<string> Character_Text;

	// Use this for initialization
	void Start () {
        if (Character_Text == null)
        {
            Character_Text = new List<string>(1);
        }
    }

    private void OnEnable()
    {
        if (Character_Text == null)
        {
            Character_Text = new List<string>(1);
        }
    }

    // Update is called once per frame
    void Update () {
		
	}

    public void Set_Character_Community_Illust(Sprite Char_Illust)
    {
        if(Char_Illust != null &&
            Character_Illust_Object != null)
        {
            Character_Illust_Object.GetComponent<Image>().overrideSprite = Char_Illust;
        }
        
    }

    public void Set_Character_Community_NameTag(string Nametag = "")
    {
        if(Character_NameTag_Object != null)
        {
            Character_NameTag_Object.GetComponent<Text>().text = Nametag;
        }
    }

    public void Community_TextLog_Print(int NowPrintTextCount = 0)
    {
        Character_Text_Object.text = "";

        if (NowPrintTextCount < Character_Text.Count)
        {
            Character_Text_Object.text = "";

            StopCoroutine(TextLogPrint_Protocol(NowPrintTextCount));
            StartCoroutine(TextLogPrint_Protocol(NowPrintTextCount));
        }
        else
        {
            Character_Text_Object.text = "";

            StopCoroutine(TextLogPrint_Protocol(NowPrintTextCount));

            StopCoroutine(TextLogTerminate_Protocol());
            StartCoroutine(TextLogTerminate_Protocol());

            GameManager.GetInstance.SetNowFieldGameEvent(GameOption.Field_Event.None);
        }
        
    }

    public void Set_Character_Community_Text(string text = "")
    {
        if(Character_Text != null)
        {
            Character_Text.Add(text);
        }
    }

    public void Set_Character_Community_Text(List<string> texts)
    {
        if (Character_Text != null &&
            texts != null)
        {
            Character_Text = texts;
        }
    }

    IEnumerator TextLogPrint_Protocol(int NowPrintTextCount = 0)
    {

        if (Character_Text_Object != null)
        {
            Character_Text_Object.text = "";

            for (int i = 0; i< Character_Text[NowPrintTextCount].Length; i++)
            {
                Character_Text_Object.text += Character_Text[NowPrintTextCount][i];
                yield return new WaitForSeconds(0.03f);
            }
            
        }
    }

    IEnumerator TextLogTerminate_Protocol()
    {
        Character_Text_Object.text = "";

        yield return new WaitForSeconds(0.1f);

        this.gameObject.SetActive(false);
    }
}
