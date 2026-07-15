namespace CSharp_02;

class Program
{
    static void Main(string[] args)
    {
        // 전투 상황을 가정 : 공격력에서 방어력을 차감해서 데미지가 적용
        float attackPower = 45f;    // 공격자의 공격력
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
    }
}