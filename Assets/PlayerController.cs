using System.Collections;
using System.Collections.Generic;
using Spine.Unity;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    // 카메라 정보
    public Camera MainField_Character_Camera;

    // 플레이어 정보 값
    public SkeletonAnimation PlayerAni;
    private CharacterController controller;
    private float MySpeed;

    // 게임 설정 값들
    private GameOption.GameControllOption NowControllOption;
    private GameOption.GameDifficultOption NowDifficultOption;

    // 스파인 애니메이션 및 이펙트, 사운드 정보들
    [Header("Animation")]
    [SpineAnimation(dataField: "skeletonAnimation")]
    public string Spine_Ani_walkName = "Walk";
    [SpineAnimation(dataField: "skeletonAnimation")]
    public string Spine_Ani_runName = "Run";
    [SpineAnimation(dataField: "skeletonAnimation")]
    public string Spine_Ani_idleName = "Idle";
    //[SpineAnimation(dataField: "skeletonAnimation")]
    //public string jumpName = "Jump";
    //[SpineAnimation(dataField: "skeletonAnimation")]
    //public string fallName = "Fall";
    //[SpineAnimation(dataField: "skeletonAnimation")]
    //public string crouchName = "Crouch";
    

    // Use this for initialization
    void Start () {

        MySpeed = 0.1f;

        if(PlayerAni == null)
        {
            PlayerAni = GetComponent<SkeletonAnimation>();
            PlayerAni.AnimationState.Event += HandleEvent;
        }
        else
        {
            PlayerAni.AnimationState.Event += HandleEvent;
        }

        if(controller == null)
        {
            controller = GetComponent<CharacterController>();
        }
        

        NowControllOption = GameManager.GetInstance.GetNowControllOption();
        NowDifficultOption = GameManager.GetInstance.GetNowDifficultOption();

    }

    void HandleEvent(Spine.TrackEntry trackEntry, Spine.Event e)
    {
        //if (e.Data.Name == footstepEventName)
        //{

        //}
    }

    float GetRandomPitch(float maxOffset)
    {
        return 1f + Random.Range(-maxOffset, maxOffset);
    }

    // Update is called once per frame
    void Update () {
        NowControllOption = GameManager.GetInstance.GetNowControllOption();
        NowDifficultOption = GameManager.GetInstance.GetNowDifficultOption();

        switch(NowControllOption)
        {
            case GameOption.GameControllOption.KEYBOARD:
                {
                    if(Input.GetKey(KeyCode.LeftArrow))
                    {
                        PlayerAni.AnimationName = Spine_Ani_runName;
                        PlayerAni.skeleton.flipX = true;

                        if (Input.GetKey(KeyCode.UpArrow))
                        {
                            transform.Translate(new Vector2(-MySpeed, MySpeed));
                            MainField_Character_Camera.transform.Translate(new Vector2(-MySpeed, MySpeed));
                        }
                        else if(Input.GetKey(KeyCode.DownArrow))
                        {
                            transform.Translate(new Vector2(-MySpeed, -MySpeed));
                            MainField_Character_Camera.transform.Translate(new Vector2(-MySpeed, -MySpeed));
                        }
                        else
                        {
                            transform.Translate(new Vector2(-MySpeed, 0.0f));
                            MainField_Character_Camera.transform.Translate(new Vector2(-MySpeed, 0.0f));
                        }
                        
                    }
                    else if(Input.GetKey(KeyCode.RightArrow))
                    {
                        PlayerAni.AnimationName = Spine_Ani_runName;
                        PlayerAni.skeleton.flipX = false;

                        if (Input.GetKey(KeyCode.UpArrow))
                        {
                            transform.Translate(new Vector2(MySpeed, MySpeed));
                            MainField_Character_Camera.transform.Translate(new Vector2(MySpeed, MySpeed));
                        }
                        else if (Input.GetKey(KeyCode.DownArrow))
                        {
                            transform.Translate(new Vector2(MySpeed, -MySpeed));
                            MainField_Character_Camera.transform.Translate(new Vector2(MySpeed, -MySpeed));
                        }
                        else
                        {
                            transform.Translate(new Vector2(MySpeed, 0.0f));
                            MainField_Character_Camera.transform.Translate(new Vector2(MySpeed, 0.0f));
                        }
                        
                    }
                    else if (Input.GetKey(KeyCode.UpArrow))
                    {
                        PlayerAni.AnimationName = Spine_Ani_runName;

                        if (Input.GetKey(KeyCode.LeftArrow))
                        {
                            transform.Translate(new Vector2(-MySpeed, MySpeed));
                            MainField_Character_Camera.transform.Translate(new Vector2(-MySpeed, MySpeed));
                        }
                        else if (Input.GetKey(KeyCode.RightArrow))
                        {
                            transform.Translate(new Vector2(MySpeed, MySpeed));
                            MainField_Character_Camera.transform.Translate(new Vector2(MySpeed, MySpeed));
                        }
                        else
                        {
                            transform.Translate(new Vector2(0.0f, MySpeed));
                            MainField_Character_Camera.transform.Translate(new Vector2(0.0f, MySpeed));
                        }

                        
                    }
                    else if (Input.GetKey(KeyCode.DownArrow))
                    {
                        PlayerAni.AnimationName = Spine_Ani_runName;

                        if (Input.GetKey(KeyCode.LeftArrow))
                        {
                            transform.Translate(new Vector2(-MySpeed, -MySpeed));
                            MainField_Character_Camera.transform.Translate(new Vector2(-MySpeed, -MySpeed));
                        }
                        else if (Input.GetKey(KeyCode.RightArrow))
                        {
                            transform.Translate(new Vector2(MySpeed, -MySpeed));
                            MainField_Character_Camera.transform.Translate(new Vector2(MySpeed, -MySpeed));
                        }
                        else
                        {
                            transform.Translate(new Vector2(0.0f, -MySpeed));
                            MainField_Character_Camera.transform.Translate(new Vector2(0.0f, -MySpeed));
                        }
                        
                    }
                    else
                    {
                        PlayerAni.AnimationName = Spine_Ani_idleName;
                    }
                }
                break;

            case GameOption.GameControllOption.GAMEPAD:
                {

                }
                break;
        }
    }
}
