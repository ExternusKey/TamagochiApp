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
        Console.WriteLine("Ваш питомец погиб.");
    }

    static void PrintPetInfo(Pet pet)
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(pet.Name);
        Console.ResetColor();
        Console.WriteLine($"Здоровье питомца: {pet.Health}");
        Console.WriteLine($"Голод питомца: {pet.Hunger}");
        Console.WriteLine($"Усталость питомца: {pet.Fatigue}\n\n");
    }

    static void ChooseAction(Pet pet)
    {
        Console.WriteLine("Выберите действие");
        Console.WriteLine("1.Поесть");
        Console.WriteLine("2.Поиграть");
        Console.WriteLine("3.Поспать\n");
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
            default:
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Действите выбрано некорректно.");
                    Console.ResetColor();
                    Thread.Sleep(2500);
                    return;
                }
        }

    }
}