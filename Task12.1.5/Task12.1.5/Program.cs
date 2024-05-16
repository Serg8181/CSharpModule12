using System;

/*Для списка пользователей добавьте приветствие по имени.
  Если пользователь не имеет премиум-подписки, то ему нужно показать рекламу.*/

namespace Task12._1._5
{
    internal class Programm
    {

        public static void Main()
        {
            List<User> users = new List<User>()
            {
                new User("First","Дмитрий",true),
                new User("Second","Вадим",false),
                new User("Third","Виталий",true)
            };
            foreach (var user in users)
            {
                Console.WriteLine($"Добрый день, {user.Name}!");
                if (!user.IsPremium) ShowAds();
            }
            Console.ReadLine();
        }
        static void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            // Остановка на 1 с
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            // Остановка на 2 с
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            // Остановка на 3 с
            Thread.Sleep(3000);
        }
    }
   
}
