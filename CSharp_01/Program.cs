namespace CSharp_01;

class Program
{
    static void Main(string[] args)
    {
        // 변수 선언   타입 변수명 = 초깃값;
        // 변수 명 - 카멜 케이스 (camel case , 단봉낙타 표기법) : 첫 글짜는 소문자로 시작 다른 키워드는 대문자로 시작
        string playerName = "Zack";
        int level;          // 정수 (int, integer)
        float hp = 100.0f;      // 실수 (float)
        bool isDead = false;    // 불, 불린, 불리언 (bool, boolean)
        
        level = 1;
        
        Console.WriteLine("게임 개발자의 세계로 오신것을 환영합니다.!");
        Console.WriteLine("이름:" + playerName);
        Console.WriteLine("레벨: " + level);      // "문자열" + 1  => "문자열" + "1" 
        Console.WriteLine("HP: " + hp);
        Console.WriteLine("사망여부:" + isDead);
        
        Console.WriteLine("이름: " + playerName + " 레벨: " + level + " HP: " + hp);
        
        level = level + 1;  // level 1 증가
       
        // 문자열 보간
        Console.WriteLine($"이름: {playerName} 레벨: {level} HP: {hp}");
    }
}