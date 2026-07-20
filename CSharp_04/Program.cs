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
        
        
    }
}