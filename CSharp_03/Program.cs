// ReSharper disable All
namespace CSharp_03;

class Program
{
    static void Main(string[] args)
    {
        // 몬스터의 레벨
        int monsterLevel = 47;
        
        // 몬스터의 등급
        string rank;

        // bool isGameOver = true;
        // if (isGameOver) return;
        
        if (monsterLevel >= 50)
        {
            rank = "보스";
        }
        else if (monsterLevel >= 30)
        {
            rank = "정예";
        }
        else if (monsterLevel >= 10)
        {
            rank = "일반";
        }
        else
        {
            rank = "잡몹";
        }
        
        Console.WriteLine($"레벨: {monsterLevel} 몬스터 등급: {rank}");
    }
}