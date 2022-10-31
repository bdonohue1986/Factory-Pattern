namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            var NewService = NewCaller.NewCust();
            Console.WriteLine();
            NewService.MakeKey();
            Console.WriteLine();
            var NewService2 = NewCaller.NewCust();
            Console.WriteLine();
            NewService2.Opendoor();
            Console.WriteLine();
            Console.WriteLine("Would you like to try another we will change the locks this time");
            var answer = Console.ReadLine();
            if(answer.ToLower() == "yes")
            {
                var NewService3 = NewCaller.NewCust();
                NewService3.ChangeLock();
                
            }
            else { Console.WriteLine("Ok have a great day"); }
            

        }
    }
}
