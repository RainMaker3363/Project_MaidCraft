using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Skill_First_Command_Button : MonoBehaviour, IDragHandler, IPointerUpHandler, IPointerDownHandler
{
    public GameObject Normal_Command_Object;
    public GameObject Skill_Command_object;

    public GameObject SKill_Test_Effect;
    public Transform Enemy_Field_Transform;

    private float Skill_Timer;
    private float Skill_CoolTime;

    [HideInInspector]
    public bool Skill_Active;

    [HideInInspector]
    public int Skill_Button_ID;

    //public Panel

	// Use this for initialization
	void Start () {

        if (Enemy_Field_Transform == null)
        {
            Enemy_Field_Transform = GameObject.Find("Enemy_Field").transform;
        }

        Skill_Timer = SKill_Test_Effect.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length;

        //Skill_Active = true;
        //Skill_CoolTime = 1.0f;
        Skill_Active = true;
        Skill_Button_ID = 1;

        //this.gameObject.SetActive(false);
    }

    private void OnEnable()
    {
        if (Enemy_Field_Transform == null)
        {
            Enemy_Field_Transform = GameObject.Find("Enemy_Field").transform;
        }

        Skill_Timer = SKill_Test_Effect.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length;
        Skill_Active = true;
        Skill_Button_ID = 1;
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
        if (Skill_Active == true)
        {
            Skill_Active = false;

            StopCoroutine(Skill_Command_Active());
            StartCoroutine(Skill_Command_Active());

        }
        else
        {
            Skill_Active = false;
            //this.gameObject.SetActive(false);

            Normal_Command_Object.SetActive(true);
            Skill_Command_object.SetActive(false);
        }

        


    }

    // 터치에서 손을 땠을때 발생하는 함수
    public virtual void OnPointerUp(PointerEventData ped)
    {

    }

    IEnumerator Skill_Command_Active()
    {
        Instantiate(SKill_Test_Effect, Enemy_Field_Transform);

        yield return new WaitForSeconds(Skill_Timer);

        Normal_Command_Object.SetActive(true);
        Skill_Command_object.SetActive(false);

    }

    IEnumerator Skill_Cool_Time_Checker()
    {
        yield return new WaitForSeconds(Skill_CoolTime);

        Skill_Active = true;
    }
}
