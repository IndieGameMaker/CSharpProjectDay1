namespace CSharp_02;

class Program
{
    static void Main(string[] args)
    {
        // 전투 상황을 가정 : 공격력에서 방어력을 차감해서 데미지가 적용
        float attackPower = 50f;    // 공격자의 공격력
        float defence = 12f;        // 방어자의 방어력
        float enemyHp = 100f;       // 적 캐릭터의 체력
        
        // 1) 실제 데미지 계산
        float damage = attackPower - defence;
        Console.WriteLine($"실제 데미지: {damage}");
        
        // 2) 적 체력 차감 (복합 대입연산자)
        enemyHp -= damage;
        Console.WriteLine($"적의 남은 HP: {enemyHp}");

        // 3) 크리티컬 데미지 계산
        bool isCritical = true;
        float critDamage = damage * 2f;
        enemyHp -= critDamage;
        Console.WriteLine($"치명타 후 적의 체력: {enemyHp}");
        
        // 4) 적 캐릭터 사망 여부 (비교 연산)
        bool isDead = enemyHp <= 0;
        Console.WriteLine($"적 사망여부: {isDead}");
        
        Console.Clear();
        int score = 7;
        Console.WriteLine(score % 2);

        int gold = 100;
        gold += 50; // 100 + 50 = 150
        gold -= 30; // 150 - 30 = 120
        gold *= 2;  // 120 * 2 = 240
        
        Console.WriteLine(gold);

        /*
         * 조건문 (if / switch) : 만약 ~ 라면(이면) 이걸 처리해줘
         * if / else
         * if / else if
         */
        Console.Clear();
        float hp = 25f;
        hp += 30f;
        
        if (hp <= 0f)
        {
            Console.WriteLine("게임 오버");
        }
        else if (hp < 30f)
        {
            Console.WriteLine("체력저하!! 물약 필요함");
        }
        else
        {
            Console.WriteLine("정상 체력");
        }
        
        // switch 구문 : 값에 따라서 분기 
    }
}