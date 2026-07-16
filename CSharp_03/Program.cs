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
        int monsterLevel = 47;
        
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
            MonsterRank.Weak => 100,
            _ => 30
        };
        Console.WriteLine($"처치 보상: {reward} G");
    }
}