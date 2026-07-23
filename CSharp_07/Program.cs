namespace CSharp_07;

// abstract 클래스(추상 클래스) : 로직을 정의할 수 없고 , 상속받은 클래스에서 로직을 구현하도록 강제
abstract class Enemy
{
    public string Name { get; set; } // Auto Property
    public int Hp { get; set; }

    public Enemy(string name, int hp)
    {
        Name = name;
        Hp = hp;
    }

    // abstract 메서드(추상 메서드) 선언만 가능
    public abstract void Attack();

    public void TakeDamage(int damage)
    {
        Hp -= damage;
        if (Hp <= 0) Hp = 0;
    }
}

class Dragon : Enemy
{
    public Dragon(string name, int hp) : base(name, hp)
    {
    }

    // 공격로직 실제로 구현
    public override void Attack()
    {
        // 추가 광역 데미지
        Console.WriteLine("화염 지속 데미지 추가");
    }

    public void Fly()
    {
        Console.WriteLine("비행중...");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Enemy e = new Dragon("드래곤", 1000);

        // is : ~ 인가? ~타입인가? : bool

        if (e is Dragon)
        {
            Console.WriteLine("드래곤 입니다."); 
            e.Attack();
        }
        
        if (e is Dragon d)
    }
}