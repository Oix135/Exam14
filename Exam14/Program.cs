namespace Exam14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var work = new Work();

            int countRecords = 2;

            while (true)
            {
                var input = Console.ReadKey().KeyChar;

                var parsed = Int32.TryParse(input.ToString(), out int pageNumber);

                if (!parsed || pageNumber < 1 || pageNumber > 4)
                {
                    Console.WriteLine();
                    Console.WriteLine("Страницы не существует");
                }
                else
                {
                    var pageContent = work.GetContacts(pageNumber, countRecords);
                    Console.WriteLine();

                    // выводим результат
                    foreach (var entry in pageContent)
                        Console.WriteLine(entry.Name + " " + entry.LastName + ": " + entry.PhoneNumber + " e-mail: " + entry.Email);

                    Console.WriteLine();
                }
            }
        }
    }
}
