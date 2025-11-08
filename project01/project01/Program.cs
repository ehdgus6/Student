using project01;
using System.Numerics;
using System.Runtime.InteropServices;

internal class Program
{
    private static void Main(string[] args)
    {
        // 업캐스팅
        // Character[] characters = new Character[2];
        // characters[0] = new Player(10);
        // characters[1] = new Monster();

        // characters[0].Move(1, 1);

        // 다운캐스팅
        // Player player = characters[0] as Player;
        // Player.RangeAttack(characters[1]);

        // Character.Builder characterBuilder = new Character.Builder();

        // Character character = characterBuilder.SetX(0).
        //    SetY(0).
        //    SetName("Name").
        //    // SetMana(0).
        //    Build();

        // character.Attack(null);
        // 델리게이트 체인
        // Character.callbackAttack += DisplayAttack;
        // Character.callbackAttack += DisplayAttack2;

        // Plus(1, 1);
        // Plus(2, 3);
        // Plus(5, 4);
        // Plus(5, 4);
        // Plus(5, 4);

        // int aa = 1;
        // int bb = 2;

        // float cc = 3;
        // float dd = 4;
        // GenericEx<int> generic = new GenericEx<int>();
        // generic.Swap(ref aa, ref bb);
        // generic.Copy<float>(ref cc, ref dd);

        int a = 10;
        int b = 20;

        int result = Calc2(a, b);

        //for (int i = 0; i < 100; i++)
        //{
        //    Console.WriteLine(i);
        //}

        // result는 50이 나와야 한다.
        Console.WriteLine(result);
    }

    private static int Calc(int a, int b)
    {
        return a + b;
    }
    private static int Calc2(int a, int b)
    { 
        return Calc(a, b); 
    }

    private static void DisplayAttack(int hp)
    {
        Console.WriteLine(hp);   
    }

    private static void DisplayAttack2(int hp)
    {
       Console.WriteLine(hp);
    }
    private static int  Plus (int a , int b, int c = 0)
    {
        return a + b + c;
    }

    private static float Plus(float a, float b, float c)
    {
        return a + b;
    }

    // 메서드 오버라이딩 위반
    // private double Plus(int a, int b)
    // {
    //    return a + b;  
    // }



}