using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CharacterInfo
{
    public enum SkillType
    {
        PASSIVE = 0,
        ACTIVE,
        BUFF,
        MAX
    }

    public struct Skill_Info
    {
        public int Skill_ID;
        public string Skill_Name;
        public SkillType Skill_Type;
        public float Skill_CoolTime;
        public string Info;
    }
}

public class CharacterInterface
{

    // 캐릭터의 이름
    public string Character_Name;

    // 체력
    public int Chracter_HP;
    // 마나
    public int Character_MP;
    // 물리 공격
    public int Melee_Attack;
    // 마법 공격
    public int Magic_Attack;
    // 물리 방어력
    public int Melee_Registance;
    // 마법 방어력
    public int Magic_Registance;
    // 현재 레벨
    public int Character_Level;

    // 경험치 테이블
    public List<int> EXP_Table;
    // 스킬 언락 테이블
    public Dictionary<string, bool> Skill_Unlock_Table;
    // 스킬 정보 테이블
    public Dictionary<int, CharacterInfo.Skill_Info> Skill_Info_Table;

    public CharacterInterface()
    {
        Character_Name = "";

        Chracter_HP = 1;
        Character_MP = 1;
        Character_Level = 1;

        Magic_Attack = 1;
        Melee_Attack = 1;

        Melee_Registance = 1;
        Magic_Registance = 1;
    }
}
