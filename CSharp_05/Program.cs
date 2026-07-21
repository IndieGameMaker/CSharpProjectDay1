namespace CSharp_05;

/*
 * 접근제한자
 * public  - 어디서든지 모두 접근을 허용 (외부에 공개)
 * private - 자신의 클래스에서 만 접근을 허용 (데이터 은닉화, 캡슐화)
 * protected - 자신의 클래스 + 자식 클래스에 접근을 허용
 * internal - 같은 어셈블리 안에서 접근을 허용 (같은 프로그램내에서 접근을 허용)
 */

// 클래스 정의 (설계도)
// C# 코딩 컨벤션 (코드 작성할 때 표준)
internal class Player
{
    // 필드(field) : 데이터
    public string name;
    private float _hp; // 캡슐화
    public float attackPower;

    // 프로퍼티 방식 (Property: 속성)
    public float Hp
    {
        get => _hp;
        set
        {
            if (value > 100f)
            {
                _hp = 100f;
            }
            else if (value < 0f)
            {
                _hp = 0f;
            }
            else
            {
                _hp = value;
            }
        }
    }
    
    // 메서드를 활용한 방식
    public void SetHp(float hp)
    {
        _hp = hp;
    }

    public float GetHp() => _hp;
    // public float GetHp()
    // {
    //     return _hp;
    // }
    
    // 메서드(Method) : 로직 (동작)
    public void Attack()
    {
        Console.WriteLine($"{name}가 {attackPower} 파워로 공격!");
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        // 힙 메모리에 객체(Instance)가 생성됨
        Player hero = new Player();
        // 객체의 필드값 정의 (변수 설정)
        hero.name = "전사";  // 객체.필드
        // hero.hp = 100f;
        // hero.SetHp(100f);
        hero.Hp = -90f; // set {}
        
        // 지역 변수 (Local Variable)
        float hp = hero.Hp; // get {} // hero.GetHp();
        Console.WriteLine(hp);
        
        hero.attackPower = 30f;
        // 메소드 호출
        hero.Attack();
    }
}