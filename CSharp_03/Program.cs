// ReSharper disable All

using System.Collections.Generic; // List 자료형을 사용하기 위해서 반드시 추가해야 하는 네임스페이스

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

        Console.Clear();
        Console.WriteLine("=== 웨이브 시작 ===");
        
        // 고블린 3 생성
        for (int i = 1; i <= 3; i++)
        {
            Console.WriteLine($"고블린 {i}번째 생성");
        }
        
        // 보스 공격
        Console.WriteLine("=== 보스전 ===");
        bossHp = 100f;

        float playerDamage = 30f;
        // 턴 정보 저장
        int turn = 1;

        while (bossHp > 0f)
        {
            bossHp -= playerDamage;
            if (bossHp < 0f) bossHp = 0f; // 음수 방지
            Console.WriteLine($"{turn}턴 : 보스에게 {playerDamage} 만큼 데미지 입힘!(남은 체력:{bossHp})");
            ++turn; // 다음 턴 설정
        }
        
        Console.WriteLine("보스 처리");
        
        // 배열과 컬렉션
        // string[] items = { "검", "마나", "물약" };

        Console.Clear();
        Console.WriteLine(items[0]);
        
        // List : 크기를 자유롭게 변경
        // 제너릭 문법 T 
        // List<string> inventory = new();
        List<string> inventory = new List<string>();
        inventory.Add("대용량 물약");
        inventory.Add("소용량 마나");
        inventory.Add("대용량 마나");
        
        Console.Clear();
        Console.WriteLine(inventory.Count);
        Console.WriteLine(inventory[2]);
        
        // Dictionary 딕셔너리 자료형 : 키(Key)로 저장된 값(Value)을 검색이 가능
        Dictionary<string, int> shop = new Dictionary<string, int>(); // new ();
        // Indexer 방식으로 추가 (중복시 업데이트하고 오류 X)
        shop["물약"] = 10;
        shop["검"] = 2;
        // Add 로 추가(중복이 발생하면 오류 발생)
        shop.Add("마나", 3);
        
        Console.WriteLine(shop["물약"]);
    }
}