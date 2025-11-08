using System;
using System.Numerics;
using System.Security.Claims;

namespace project01
{
    // 형용사를 기준으로 네이밍, 이름의 앞에 I
    class  Moveable
    {
        void Move(int x, int y)
        {

        }
    }
    class IAttackable
    {
        void Attack(Player target)
        {

        }
    }
    struct Position
    {
        public int x;
        public int y;
        public int z;
        public int w;
    }
    partial class Character
    {

        public delegate void CallbackAttack(int hp);
        public static event CallbackAttack callbackAttack;
    
        // 클래스의 결합도를 낮추기 위해 private 선언
       // private int x;
       // private int y;

        // 프로퍼티
        //public int X
        //{
        //    get { return x; }
        //    set { x = value; }
        //}

        // 자동 구현 프로퍼티
        public int X { get; set; }
        public int Y { get; set; }
        public string Name { get; set; }
        public int Mana;
        public int Health;

        public class Builder
        {
            private string name;
            private int x;
            private int y;
            private int Mana;
            public Builder SetName(string name)
            {
                this.name = name;
                return this;
            }
            public Builder SetMana(int mana)
            {
                this.Mana = mana;
                return this;
            }
            public Builder SetX(int x)
            {
                this.x = x;
                return this;
            }
            public Builder SetY(int y)
            {
                this.y = y;
                return this;
            }
            public Character Build()
            {
                var character = new Character();
                character.Name = name;
                character.Mana = Mana;
                character.X = x;
                character.Y = y;

                return character;
            }

            public void Translate(Position  position)
            {
                this.x = position.x;
                this.y = position.y;
            }
        }
        // 로컬 함수: 속성 업데이트
        public void UpdateStatus(int healthChange, int manaChange)
        {
            // 중첩 메소드 : 속성 업데이트
            void Update(ref int property, int change)
            {
                property += change;

                if (property > 100)
                    property = 100;
                
                
            }
            // 상태 업데이트 로직
            Update(ref Health, healthChange);
            Update(ref Mana, manaChange);
        }

        public void Save()
        {

        }
        public void Load()
        {
        }

        public virtual void Move(int x, int y)
        {

        }


        public virtual void Attack(Player target)
        {

        }
    }

    class Player : Character
    {
        public int hp;
        public Weapon weapon;

        public Player(int hp, int x, int y) : base()
        {
            this.hp = hp;
        }
        public Player(int hp, int AttackPower) : this(hp, 1, 1)
        {

        }
        public override void Move(int x, int y)
        {
            // 몬스터 특수 이동
        }
        public override void Attack(Player target)
        {
            // 플레이어의 특수 공격
            callbackAttack?.Invoke(target.hp);
        }
        public void RangeAttack(Player target)
        {
            // 원거리 공격
        }
        class Monster : Character
        {
            public Monster(int x, int y) : base()
            {

            }
            public override void Move(int x, int y)
            {

            }
            public override void Attack(Player target)
            {

            }
        }
    }
    abstract class Weapon
    {
        protected int power;

        public Weapon (int power)
        {
            this.power = power;
        }

        // 가상 메소드 > 확장이 가능
        public abstract void Attack(Player target); 
    }

        class PosionGun : Weapon
        {
            private int dotDamage;
            public PosionGun(int power, int dotDamage) : base(power)
            {
                this.dotDamage = dotDamage;
            }

            public override void Attack(Player target)
            {
                target.hp -= dotDamage;
                target.hp -= power;
            }
        }
}
