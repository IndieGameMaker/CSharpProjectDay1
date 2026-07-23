namespace CSharp_07;

// 인터페이스 정의 (선언)
interface IDamageable
{
    void TakeDamage(int damage);   // 구현부(로직), 구현체없이 "뼈대만" 선언 
}

interface IAttackable
{
    void Attack();
}

class Player : IDamageable, IAttackable
{
    public int Hp { get; set; }
    
    // 인테페이스에서 요구한 메서드를 반드시 구현해야 함.
    public void TakeDamage(int damage)
    {
        Hp -= damage;
        // 실제 로직 작성
        Console.WriteLine($"플레이어 HP: {Hp}");
    }}

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

class Goblin : Enemy
{
    public Goblin(string name, int hp) : base(name, hp) {}
    
    // 추상 메소드 구현
    public override void Attack()
    {
        Console.WriteLine("고블린 공격!");
    }

    public void Steal()
    {
        Console.WriteLine("도둑질");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Enemy e = new Dragon("드래곤", 1000);
        Enemy g = new Goblin("고블린", 50);

        // is : ~ 인가? ~타입인가? : bool

        if (e is Dragon)
        {
            Console.WriteLine("드래곤 입니다."); 
            e.Attack();
        }

        // 패턴 매칭 (확인과 변환을 한번에 처리)
        if (e is Dragon d)
        {
            d.Fly();
            d.Attack();
        }
        
        // as: a as b : 변환시도, 타입이 다르면 null을 반환
        // Goblin goblin = e as Goblin;
        Goblin goblin = g as Goblin;
        if (goblin == null)
        {
            Console.WriteLine("고블린이 아님");
        }
        else
        {
            goblin.Steal();
        }
    }
}