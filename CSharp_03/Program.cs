// ReSharper disable All
namespace CSharp_03;

// 열거형 정의
enum MonsterRank
{
    Boss, Elite, Normal, Weak
}

class Program
{
    static void Main(string[] args)
    {
        // 몬스터의 레벨
        int monsterLevel = 52;
        
        // 몬스터의 등급
        MonsterRank rank;

        // bool isGameOver = true;
        // if (isGameOver) return;
        
        if (monsterLevel >= 50)
        {
            rank = MonsterRank.Boss;
        }
        else if (monsterLevel >= 30)
        {
            rank = MonsterRank.Elite;
        }
        else if (monsterLevel >= 10)
        {
            rank = MonsterRank.Normal;
        }
        else
        {
            rank = MonsterRank.Weak;
        }
        
        Console.WriteLine($"레벨: {monsterLevel} 몬스터 등급: {rank}");

        int reward = rank switch
        {
            MonsterRank.Boss => 1000,
            MonsterRank.Elite => 300,
            MonsterRank.Normal => 100,
            MonsterRank.Weak => 30
        };
        Console.WriteLine($"처치 보상: {reward} G");
        
        // 반복문 (for/foreach/while/do~while)
        /* for (시작점; 조건; 증감)
           {
                반복 실행할 로직;
           }
        */

        Console.Clear();
        // i => 0, 1, 2, 3, 4
        for (int i = 0; i < 5 ; i++)
        {
            Console.WriteLine($" 적 {i+1}번째 소환");
            // 적을 스폰시키는 로직...
        }
        
        // while 문 - while (조건) {}
        float bossHp = 100f;

        while (bossHp > 0f)
        {
            bossHp -= 25f; // 매번 25씩 공격
            //Console.WriteLine("보스 체력 :" + bossHp);
            Console.WriteLine($"보스 체력 : {bossHp}");
        }
        
        Console.WriteLine("보스 사망");
        
        // foreach 문 - 배열(컬렉션)
        Console.Clear();
        string[] items = { "검", "마나", "물약" };

        int index = 0;
        foreach (string item in items)
        {
            Console.WriteLine($"{index++}: {item}");
        }

        for (int i = 0; i < items.Length; i++)
        {
            Console.WriteLine($"{i} : {items[i]}");
        }

        Console.Clear();
        for (int i = 0; i < 10; i++)
        {
            if (i == 5) break;
            
            if (i % 2 == 0) continue;
            Console.WriteLine(i);
        }

    }
}