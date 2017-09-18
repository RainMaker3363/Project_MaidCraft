using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Skill_Command_Button : MonoBehaviour, IDragHandler, IPointerUpHandler, IPointerDownHandler
{
    public GameObject Skill_Active_Object;

    //public GameObject Skill_First_Button;
    //private float Skill_First_Button_Fill_Gage;

    //public GameObject Skill_Second_Button;
    //public GameObject Skill_Third_Button;
    //public GameObject Skill_Fourth_Button;

    //public GameObject SKill_Test_Effect;
    //public Transform Enemy_Field_Transform;

    //private float Skill_Timer;
    //private float Skill_CoolTime;

    // Use this for initialization
    void Start () {
        //if (Enemy_Field_Transform == null)
        //{
        //    Enemy_Field_Transform = GameObject.Find("Enemy_Field").transform;
        //}

        //Skill_Timer = SKill_Test_Effect.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length;
        
        //Skill_CoolTime = 1.0f;
        //Skill_First_Button_Fill_Gage = Skill_CoolTime;
    }

    private void OnEnable()
    {
        //if (Enemy_Field_Transform == null)
        //{
        //    Enemy_Field_Transform = GameObject.Find("Enemy_Field").transform;
        //}

        //Skill_Timer = SKill_Test_Effect.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length;

    }


    // Update is called once per frame
    void Update () {
		
	}

    // 터치가 드래그(Drag) 했을때 호출 되는 함수
    public virtual void OnDrag(PointerEventData ped)
    {

    }


    // 터치를 하고 있을 대 발생하는 함수
    public virtual void OnPointerDown(PointerEventData ped)
    {
        if(Skill_Active_Object.activeSelf == false)
        {
            Skill_Active_Object.SetActive(true);
        }
        
        //// 첫번째 버튼 스킬에 대한 처리
        //if (Skill_First_Button.activeSelf == false)
        //{
        //    Skill_First_Button.SetActive(true);

        //    if (Skill_First_Button.GetComponent<Skill_First_Command_Button>().Skill_Active == true)
        //    {
        //        StopCoroutine(Skill_Command_Active());
        //        StartCoroutine(Skill_Command_Active());

        //        StopCoroutine(Skill_Cool_Time_Checker(Skill_First_Button.GetComponent<Skill_First_Command_Button>().Skill_Button_ID));
        //        StartCoroutine(Skill_Cool_Time_Checker(Skill_First_Button.GetComponent<Skill_First_Command_Button>().Skill_Button_ID));
        //    }
        //}

        //// 두번째 버튼 스킬에 대한 처리
        //if (Skill_Second_Button.activeSelf == false)
        //{
        //    Skill_Second_Button.SetActive(true);

        //    //if (Skill_Second_Button.GetComponent<Skill_First_Command_Button>().Skill_Active == true)
        //    //{
        //    //    StopCoroutine(Skill_Command_Active());
        //    //    StartCoroutine(Skill_Command_Active());

        //    //    StopCoroutine(Skill_Cool_Time_Checker(Skill_Second_Button.GetComponent<Skill_First_Command_Button>().Skill_Button_ID));
        //    //    StartCoroutine(Skill_Cool_Time_Checker(Skill_Second_Button.GetComponent<Skill_First_Command_Button>().Skill_Button_ID));
        //    //}
        //}

        //// 세번째 버튼 스킬에 대한 처리
        //if (Skill_Third_Button.activeSelf == false)
        //{
        //    Skill_Third_Button.SetActive(true);

        //    //if (Skill_Third_Button.GetComponent<Skill_First_Command_Button>().Skill_Active == true)
        //    //{
        //    //    StopCoroutine(Skill_Command_Active());
        //    //    StartCoroutine(Skill_Command_Active());

        //    //    StopCoroutine(Skill_Cool_Time_Checker(Skill_Third_Button.GetComponent<Skill_First_Command_Button>().Skill_Button_ID));
        //    //    StartCoroutine(Skill_Cool_Time_Checker(Skill_Third_Button.GetComponent<Skill_First_Command_Button>().Skill_Button_ID));
        //    //}
        //}

        //// 네번째 버튼 스킬에 대한 처리
        //if (Skill_Fourth_Button.activeSelf == false)
        //{
        //    Skill_Fourth_Button.SetActive(true);

        //    //if (Skill_Fourth_Button.GetComponent<Skill_First_Command_Button>().Skill_Active == true)
        //    //{
        //    //    StopCoroutine(Skill_Command_Active());
        //    //    StartCoroutine(Skill_Command_Active());

        //    //    StopCoroutine(Skill_Cool_Time_Checker(Skill_Fourth_Button.GetComponent<Skill_First_Command_Button>().Skill_Button_ID));
        //    //    StartCoroutine(Skill_Cool_Time_Checker(Skill_Fourth_Button.GetComponent<Skill_First_Command_Button>().Skill_Button_ID));
        //    //}
        //}
    }

    // 터치에서 손을 땠을때 발생하는 함수
    public virtual void OnPointerUp(PointerEventData ped)
    {

    }

    //IEnumerator Skill_Command_Active()
    //{
    //    Debug.Log("SKill Active");

    //    Instantiate(SKill_Test_Effect, Enemy_Field_Transform);

    //    yield return new WaitForSeconds(Skill_Timer);

    //    Debug.Log("SKill Active End");
    //    //Normal_Command_Object.SetActive(true);
    //    //Skill_Command_object.SetActive(false);

    //}

    //IEnumerator Skill_Cool_Time_Checker(int ID = 0)
    //{
    //    switch(ID)
    //    {
    //        case 0:
    //            {

    //            }
    //            break;

    //        case 1:
    //            {
    //                Debug.Log("SKill Cool Time Active");

    //                yield return new WaitForSeconds(Skill_CoolTime);

    //                Debug.Log("SKill Cool Time Active End");

    //                Skill_First_Button.GetComponent<Skill_First_Command_Button>().Skill_Active = true;
    //            }
    //            break;
    //    }


    //    //Skill_Active = true;
    //}
}
