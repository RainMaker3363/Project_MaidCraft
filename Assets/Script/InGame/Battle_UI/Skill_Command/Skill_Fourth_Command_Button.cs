using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Skill_Fourth_Command_Button : MonoBehaviour, IDragHandler, IPointerUpHandler, IPointerDownHandler
{

	// Use this for initialization
	void Start () {
        //this.gameObject.SetActive(false);
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

    }

    // 터치에서 손을 땠을때 발생하는 함수
    public virtual void OnPointerUp(PointerEventData ped)
    {

    }
}
