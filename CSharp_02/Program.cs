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
    }
}