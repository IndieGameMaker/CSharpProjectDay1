namespace CSharp_02;

class Program
{
    static void Main(string[] args)
    {
        int a = 10;
        int b = 3;

        // int a = 10, b = 3;
        // 산술 연산자 (+ - / * %)
        Console.WriteLine(a + b);
        Console.WriteLine(a - b);
        Console.WriteLine(a * b);
        Console.WriteLine(a / b); // 정수 / 정수 ==> 소숫점 10/3 3.333

        float c = 10.0f; // 10f;
        float d = 3.0f;  // 3f;
        Console.WriteLine(c / d);
        
        // 0 으로 나누는 경우 ==> 주의
        Console.WriteLine(c / 0);
        
        // 나머지 연산 (Modulo)
        Console.WriteLine(a % b);
        
        // 복합 대입 연산자 (게임개발시 많이 활용됨)
        float hp = 100f;
        
        // 데미지 적용
        hp -= 20f; // hp = hp - 20f;
        // 물약 사용
        hp += 15f; // hp = hp + 15f;
        
        Console.Clear();
        Console.WriteLine($"회복 후 생명: {hp}");
        
        // 증감 연산자 (전치 , 후치)
        int combo = 0;
        combo++;  // combo = combo + 1; 콤보 1 증가
        combo *= 2; // combo = combo * 2; // 콤보 수치를 2배
        Console.Clear();
        Console.WriteLine(combo);

        int itemCount = 5;
        Console.Clear();
        Console.WriteLine(itemCount++);  // 아직 5 저장, 실행한 후에 +1
        Console.WriteLine(itemCount);    // 6
    }
}