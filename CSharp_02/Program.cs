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
        
        // 비교 연산자 ( > , < , >=, <=, ==, != )
        int level = 30;

        bool isOver30 = level != 30;  // != 다르다 여부를 확인 (같지 않는가?)
        Console.Clear();
        Console.WriteLine(isOver30);
        
        // 논리 연산자 
        /*
           멀티 라인 주석
           &&  // a AND b : 둘 다 참일 경우에만 true
           ||  // a || b
           !   // NOT : true -> false , false -> true
        */
        
        // 살아있고, 마나가 충분 하면 스킬 시전할 수 있는 지 여부
        int mana = 40;
        bool canCast = (hp > 0) && (mana >= 30);
        Console.Clear();
        Console.WriteLine(canCast);

    }
}