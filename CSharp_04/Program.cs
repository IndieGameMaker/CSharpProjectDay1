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
    }

    // 메서드 문법 형식
    // [static] [접근제한자] 반환타입 메서드_이름([매개변수])
    // {
    //     실행할 로직;
    // }
    // private / public  / protected
    
    // void : 반환할 데이터가 없는 경우
    // C# 메서드 이름은 규약 : PascalCase (파스칼 케이스)
    static void DisplayTitle()
    {
        string title = "Text RPG";
        Console.Clear();
        Console.WriteLine(title);
    }
}