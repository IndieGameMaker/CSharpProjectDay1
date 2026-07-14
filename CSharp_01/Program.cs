namespace CSharp_01;

class Program
{
    static void Main(string[] args)
    {
        // 변수 선언   타입 변수명 = 초깃값;
        int level = 1;          // 정수 (int, integer)
        float hp = 100.0f;      // 실수 (float)
        bool isDead = false;    // 불, 불린, 불리언 (bool, boolean)
        
        Console.WriteLine("게임 개발자의 세계로 오신것을 환영합니다.!");

        Console.WriteLine("레벨: " + level); // "문자열" + 1  => "문자열" + "1" 
        Console.WriteLine("HP: " + hp);
        Console.WriteLine("사망여부:" + isDead);
    }
}