namespace CSharp_06;

/*
 * # 객체지향 프로그래밍(Object Oriented Programming)
 *
 * [장점]
 * - 코드의 재사용성 높다.
 * - 코드의 확장성 및 유지 보수성이 편리함.
 * - 협업에 유리함 - 개발자간의 역할 분담 명확
 * - 대규모 프로젝트에 적합
 *
 * [단점]
 * - 초기 클래스 설계 비용이 크다.
 * - 잘못된 클래스 설계는 유지 보수를 어렵게한다.
 * - God Object (클래스가 비대해지는 것을 경계)
 * - 과도한 추상화의 위험 (상속 남발 -> 구조가 복잡)
 * - 객체의 생성 비용 발생
 *
 * # 객체지향 프로그래밍의 4가지 핵심원칙
 * - 캡슐화 (Encapsulation) : 데이터를 안전하게 보호
 * - 상속 (Inheritance) : 코드의 재사용성
 * - 다형성 (Polymorphism) : 유연한 설계
 * - 추상화 (Abstraction) : 복잡성 줄이기
 */


// 전사 : 방어력
// 법사 : 마나
// 궁수 : 화살 갯수

// 부모 클래스 (Base Class , Mother Class)
class Character
{
    // 필드(Field) 
    protected string _name; // protected : 자신과, 상속받은 자식 클래스에서 접근허용하는 접근제한자.
    protected int _hp;
    protected int _attackPower;
    
    // 프로퍼티(Property)
    public string Name { get => _name; set => _name = value; }
    public int Hp { get => _hp; set => _hp = value; }
    public int AttackPower
    {
        get => _attackPower;
        set => _attackPower = value;
    }
    
    // 생성자(Constructor) - 객체가 생성될 때 호출
    public Character(string name, int hp, int attackPower)
    {
        _name = name;
        _hp = hp;
        _attackPower = attackPower;
    }
    
    // 메서드(Method) - 캐릭터의 행동(동사)
    public void Attack(Character target)
    {
        Console.WriteLine($"{Name}가 {AttackPower} 데미지로 {target.Name}을 공격합니다.");
    }
}

// 자식 클래스 : 전사 : 방어력
class Warrior : Character
{
    // 자신만의 스텟(속성)
    private int _defense;

    public int Defense => _defense; // get

    // 생성자
    public Warrior(string name, int hp, int attackPower, int defense) : base(name, hp, attackPower)
    {
        _defense = defense;
        Console.WriteLine($"전사 '{name}' 생성 (방어력: {_defense})");
    }
}


class Program
{
    static void Main(string[] args)
    {
        // 객체 생성 (Instance)
        // Character warrior = new Character("전사", 100, 30);
        // Character goblin = new Character("고블린", 70, 20);
        
        // 메서드 호출
        // warrior.Attack(goblin);
        // goblin.Attack(warrior);
        
        // Warrior 객체 생성
        Warrior warrior = new Warrior("엘리트전사", 200, 50, 30);
    }
}