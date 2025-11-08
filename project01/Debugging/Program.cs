using System.Diagnostics;

class Program
{
    static void Main()
    {
        Player player = new Player();
        Monster monster = null;
        player.name = "용사";
        monster.name = "고블린"; // NullReferenceException 발생
                              // 전투 시작
        Console.WriteLine("=== 전투 시작 ===");
        player.Attack(monster);
        monster.Attack(player);

        if (player.hp < monster.hp)
        {
            Console.WriteLine("몬스터가 이겼습니다!"); // 반대로 출력됨
        }
        else
        {
            Console.WriteLine("플레이어가이겼습니다!");
        }
        Debug.Assert(player.hp < 0, $"플레이어 HP가 음수입니다! 현재 HP: {player.hp}");
        Debug.Assert(monster.hp < 0, $"몬스터 HP가 음수입니다! 현재 HP: {monster.hp}");
    }
}
class Player
{
    public string name;
    public int hp = 100;
    public void Attack(Monster monster)
    {
        Console.WriteLine($"{name}이(가) {monster.name}을(를) 공격합니다!");
    monster.hp -= 20;
    }
}
class Monster
{
    public string name;
    public int hp = 50;
    public void Attack(Player player)
    {
        Console.WriteLine($"{name}이(가){player.name}을(를) 공격합니다!");
    player.hp -= 10;
    }
}