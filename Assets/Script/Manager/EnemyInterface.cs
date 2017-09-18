using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EnemyInfo
{
    public struct Enemy_Skill_Info
    {
        int Skill_ID;
        string Skill_Name;
        CharacterInfo.SkillType Skill_Type;
        float Skill_CoolTime;
        string Info;
    }
}

public class EnemyInterface
{
    // 적 캐릭터의 이름
    public string Enemy_Name;

    // 체력
    public int Enemy_HP;
    // 마나
    public int Enemy_MP;
    // 물리 공격
    public int Melee_Attack;
    // 마법 공격
    public int Magic_Attack;
    // 물리 방어력
    public int Melee_Registance;
    // 마법 방어력
    public int Magic_Registance;
    // 현재 레벨
    public int Enemy_Level;

    // 스킬 정보 테이블
    public Dictionary<int, EnemyInfo.Enemy_Skill_Info> Skill_Info_Table;

    EnemyInterface()
    {
        Enemy_Name = "";

        Enemy_HP = 1;
        Enemy_MP = 1;
        Enemy_Level = 1;

        Magic_Attack = 1;
        Melee_Attack = 1;

        Melee_Registance = 1;
        Magic_Registance = 1;
    }
}