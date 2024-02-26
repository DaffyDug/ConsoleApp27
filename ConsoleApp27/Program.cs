using System;






//Разработайте систему управления персонажами в игре, где абстрактный класс Character будет содержать общие атрибуты и методы,
//такие как name, health, attack(), и defend(). Создайте несколько конкретных классов (3 и более), таких как Warrior, Mage,
//и Rogue, которые будут наследоваться от Character и реализовывать свои уникальные способности атаки и защиты.

class Program
{
    static void Main(string[] args)
    {
        Character Character_Warrior = new Warrior();
        Character_Warrior.attack();
        Character_Warrior.defend();
        Character_Warrior.health();
        Console.WriteLine('\n');

        Character Character_Mage = new Mage();
        Character_Mage.attack();
        Character_Mage.defend();
        Character_Mage.health();
        Console.WriteLine('\n');

        Character Character_Rogue = new Rogue();
        Character_Rogue.attack();
        Character_Rogue.defend();
        Character_Rogue.health();
    }
}
public abstract class Character
{
    public abstract string _name { get; }
    public abstract void health();
    public abstract void attack();
    public abstract void defend();
}
public class Warrior : Character
{
    public override string _name => "Воин";

    public override void attack()
    {
        Console.WriteLine("нанесен урон");
    }

    public override void defend()
    {
        Console.WriteLine("урон поглощен");
    }

    public override void health()
    {
        Console.WriteLine("прибавилось здоровье");
    }
}
public class Mage : Character
{
    public override string _name => "могучий маг";

    public override void attack()
    {
        Console.WriteLine("огненный шар");
    }

    public override void defend()
    {
        Console.WriteLine("невидимый шит сработал, урон поглощен");
    }

    public override void health()
    {
        Console.WriteLine("лечебное зелье");
    }
}
public class Rogue : Character
{
    public override string _name => "ах ты негодник";

    public override void attack()
    {
        Console.WriteLine("разбитая бутылка");
    }

    public override void defend()
    {
        Console.WriteLine("коробка сойдет ?");
    }

    public override void health()
    {
        Console.WriteLine("ПИВАС, чинезес");
    }
}
