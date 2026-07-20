namespace CSharp_04;

class Program
{
    static void Main(string[] args)
    {
        // List로 인벤토리 만들기
        List<string> inventory = new List<string>();
        
        // 아이템 추가
        inventory.Add("목검");
        inventory.Add("녹슨 검");
        inventory.Add("체력 물약");
        
        Console.WriteLine($"인벤토리 갯수 : {inventory.Count}");
        // 아이템 확인
        // var 키워드
        
        foreach (string item in inventory)
        {
            Console.WriteLine($"{inventory.IndexOf(item)} : {item}");
        }
        
        // 녹슨 검 버리기(List 삭제)
        inventory.Remove("녹슨 검");
        Console.WriteLine($"검 버린 후 갯수: {inventory.Count}");
        
        // 물약 검색
        if (inventory.IndexOf("체력 물약") > -1)
        {
            Console.WriteLine($"물약 보유");
        }
        
        // Dictionary 상점 구현
        // 초기화 하면서 데이터 저장
        Dictionary<string, int> shop = new Dictionary<string, int>
        {
            {"체력 물약", 5},
            {"마나 포션", 10},
            {"강철 검", 2},
            {"녹슨 검", 3}
        };
        Console.Clear();
        Console.WriteLine($"강철검 수량 : {shop["강철 검"]}");
        
        // 데이터가 존재할 경우에만 원하는 로직을 실행하는 방법
        if (shop.TryGetValue("녹슨 검", out int count))
        {
            Console.WriteLine($"녹슨 검 : {count} 보유");
        }
        else
        {
            Console.WriteLine("녹슨 검은 팔지 않습니다.");
        }

        /*
         * 함수 (Function) => 절차지향 언어 (C)
         * 메서드 (Method) => 객체지향 언어 (Java, C++, C#)
         */
        
        DisplayTitle();
        TakeDamage(30f);
        
        // 지역 변수(Local Variable)
        float realDamage = GetDamage(50f);
        Console.WriteLine($"실제 입은 데미지량: {realDamage}");
        
        Console.WriteLine($"실제 데미지 : {GetDamage(100f, 80f)}");
        
        // 콘솔에서 입력처리
        Console.Clear();
        Console.Write("이름을 입력하세요: ");
        string name = Console.ReadLine(); // 한줄로 입력받기
        Console.WriteLine($"마을에 오신것을 환영합니다. {name}님");
        
        Console.Write("물약을 몇 개 구매하시겠습니까? :");
        string input = Console.ReadLine();
        int buyCount = int.Parse(input); // 문자열을 정수로 변환 int.Parse(문자열);
        Console.WriteLine($"구매 물약의 총 가격은 {buyCount * 10} G 입니다.");
    }

    #region 메서드 문법 형식
    
    // 메서드 문법 형식
    // [static] [접근제한자] 반환타입 메서드_이름([매개변수])
    // {
    //     실행할 로직;
    // }
    // private / public  / protected
    // C# 메서드 이름은 규약 : PascalCase (파스칼 케이스)
    
    // 1) void : 반환할 데이터가 없는 경우
    static void DisplayTitle()
    {
        // 변수 이름 규약 : camelCase (카멜 케이스, 단봉 막타 표기법)
        string title = "Text RPG";
        
        Console.Clear();
        Console.WriteLine(title);
    }
    
    // 2) 매개변수(파라메터, Parameter)가 있는 경우
    static void TakeDamage(float damage)
    {
        float defense = 10;
        float realDamage = damage - defense;
        Console.WriteLine($"{realDamage}의 데미지를 입었다.");
    }
    
    // 3) 매개변수, 반환값이 있는 메서드 문법
    static float GetDamage(float damage)
    {
        float defense = 10f;
        float realDamage = damage - defense;
        
        return realDamage;
    }
    
    // 4) 메서드 오버로딩 (Method Override)
    // 매서드이 이름은 동일 , 파라메터 갯수를 다르게 설정하는 기능
    static float GetDamage(float damage, float defense)
    {
        return damage - defense;
        // float realDamage = damage - defense;
        // return realDamage;
    }
    #endregion
}