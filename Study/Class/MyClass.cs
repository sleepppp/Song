
class Monster
{
    public string Name;
    public int MaxHP;
    public int HP;
    public int Atk;
}

class BossMonster : Monster
{
    public int Def;
    public int Skill;
}

/*
 * 이름을 입력받아 플레이어를 만든다
 * 직업은 2개 (전사, 궁수)
 * 체력, 공격력, 방어력
 * 
 * 몬스터가 등장
 * 
 * 전투
 */