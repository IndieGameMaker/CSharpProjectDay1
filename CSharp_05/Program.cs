namespace CSharp_05;

// 클래스 정의 (설계도)
class Player
{
    // 필드(field) : 데이터
    public string name;
    public float hp;
    public float attackPower;

    // 메서드(Method) : 로직 (동작)
    public void Attack()
    {
        Console.WriteLine($"{name} 가 {attackPower}로 공격!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        // 힙 메모리에 객체(Instance)가 생성됨
        Player hero = new Player();
        // 객체의 필드값 정의 (변수 설정)
        hero.name = "전사";  // 객체.필드
        hero.hp = 100f;
        hero.attackPower = 30f;
        // 메소드 호출
        hero.Attack();
    }
}