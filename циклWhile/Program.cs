// написать программу , которая выдаёт сколько чёт и не чет в заданном диапазоне
namespace цикл_While1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
        
            int eventnumbers = 0;//чётные 
           int oldtnumbers = 0;//нечётные
            Console.WriteLine("Введите первое число диапазона");
            int currentvalue = Convert.ToInt32(Console.ReadLine()); ;//текущая позиция от которой , будут отсчитывать чет и нечет
            Console.WriteLine("Введите последнне число дипазона");
            int limit = Convert.ToInt32(Console.ReadLine());// конечная позиция , до которй идёт отсчёт

            while (currentvalue <= limit)// пока переменная current < limit , то будут выполняться действия
            {
                if (currentvalue %2 ==0)
                {
                    eventnumbers++;
                }
                else
                {
                    oldtnumbers++;
                }
                currentvalue++;
            }



            Console.WriteLine("количество чётных "+ eventnumbers);
            Console.WriteLine("количество нечётных " +oldtnumbers);
            Console.ReadLine();
        }
    }
}