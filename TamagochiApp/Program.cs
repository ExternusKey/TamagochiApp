using System.Runtime.CompilerServices;
using TamagochiApp;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите имя питомца: ");
        string namePet = Console.ReadLine();

        while(namePet.Trim() == string.Empty)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Неверное имя питомца. Имя должно содержать цифры или буквы.");
            Console.ResetColor();
            Console.Write("Введите имя питомца: ");
            namePet = Console.ReadLine();
        }

        Pet pet = new Pet(namePet);
        while (pet.liveFlag) 
        {
            PrintPetInfo(pet);
            ChooseAction(pet);
        }

        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Ваш питомец погиб.");
        Console.ResetColor();
    }

    static void PrintPetInfo(Pet pet)
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(pet.Name);
        Console.ResetColor();
        Console.WriteLine($"Здоровье питомца: {pet.Health}");
        Console.WriteLine($"Голод питомца: {pet.Hunger}");
        Console.WriteLine($"Усталость питомца: {pet.Fatigue}");
        Console.WriteLine($"Баланс питомца: {pet.Balance}\n\n");
    }

    static void ChooseAction(Pet pet)
    {
        Console.WriteLine("Выберите действие");
        Console.WriteLine("1.Поесть");
        Console.WriteLine("2.Поиграть");
        Console.WriteLine("3.Поспать");
        Console.WriteLine("4.Посетить магазин");
        Console.WriteLine("5.Отправиться на работу\n");
        Console.WriteLine("*Введите цифру действия, которое хотите совершить.*");
        Console.Write("Действие - ");

        switch (Console.ReadLine())
        {
            case "1":
                {
                    pet.Feed();
                    return;
                }
            case "2":
                {
                    pet.Play();
                    return;
                }
            case "3":
                {
                    pet.Sleep();
                    return;
                }
            case "4":
                {
                    ShopPrint(pet);
                    return;
                }
            case "5":
                {
                    pet.Work();
                    return;
                }
            default:
                {
                    WrongChoise();
                    return;
                }
        }

    }

    

    static void ShopPrint(Pet pet)
    {
        Console.Clear();
        Console.WriteLine($"Здоровье питомца: {pet.Health}");
        Console.WriteLine($"Голод питомца: {pet.Hunger}");
        Console.WriteLine($"Усталость питомца: {pet.Fatigue}");
        Console.WriteLine($"Баланс питомца: {pet.Balance}\n\n");

        Console.WriteLine("Выберите продукт для покупки:");
        Console.WriteLine("1. Тако (-2 голода) | Цена - 2 монеты");
        Console.WriteLine("2. Энергетик (-2 усталости) | Цена - 3 монеты ");
        Console.WriteLine("3. Покинуть магазин");
        Console.WriteLine("*Введите цифру действия, которое хотите совершить.*");
        Console.Write("Действие - ");

        switch(Console.ReadLine())
        {
            case "1":
                {
                    if (pet.Balance >= 2)
                    {
                        pet.EatTaco();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Голод уменьшен на 2 единицы.");
                        Console.ResetColor();
                        Thread.Sleep(2500);
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Недостаточно средств");
                        Thread.Sleep(2500);
                        ShopPrint(pet);
                        return;
                    }
                }
            case "2": 
                {
                    if (pet.Balance >= 3)
                    {
                        pet.DrinkEnergy(); 
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Усталость уменьшена на 2 единицы");
                        Console.ResetColor();
                        Thread.Sleep(2500);
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Недостаточно средств");
                        Thread.Sleep(2500);
                        ShopPrint(pet);
                        return;
                    }
                }
            case "3":
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Вы покидаете магазин");
                    Console.ResetColor();
                    Thread.Sleep(2500);
                    return;
                }
            default:
                {
                    WrongChoise();
                    ShopPrint(pet);
                    return;
                }
        }

    }

    static void WrongChoise()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Действите выбрано некорректно.");
        Console.ResetColor();
        Thread.Sleep(2500);
    }
}