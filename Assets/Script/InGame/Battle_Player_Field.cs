using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Battle_Player_Field : MonoBehaviour {

    public Image Portrait_Image;
    private CharacterInterface NowCharacter_Interface;
    

    // Use this for initialization
    void Start () {
        NowCharacter_Interface = new CharacterInterface();

        NowCharacter_Interface.Chracter_HP = 100;
        NowCharacter_Interface.Character_Name = "Emma";
        NowCharacter_Interface.Character_MP = 100;
        NowCharacter_Interface.Character_Level = 2;
        NowCharacter_Interface.Magic_Attack = 100;
        NowCharacter_Interface.Skill_Info_Table = new Dictionary<int, CharacterInfo.Skill_Info>(100);

        CharacterInfo.Skill_Info TestSkill;

        TestSkill.Skill_Name = "A";
        TestSkill.Skill_ID = 1;
        TestSkill.Skill_Type = CharacterInfo.SkillType.ACTIVE;
        TestSkill.Info = "테스트 스킬입니다.";
        TestSkill.Skill_CoolTime = 1.5f;

        NowCharacter_Interface.Skill_Info_Table.Add(1, TestSkill);
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public CharacterInterface GetCharacterInfo(int ID = 1)
    {
        return NowCharacter_Interface;
    }

    public CharacterInfo.Skill_Info GetCharacter_Skill_Info(int ID = 1)
    {
        return NowCharacter_Interface.Skill_Info_Table[ID];
    }
}
