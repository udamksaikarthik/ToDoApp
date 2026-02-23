namespace ToDoApp
{
    public class Program()
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("=========================");
            Console.WriteLine("Welcome to the ToDo App");
            Console.WriteLine("=========================");

            ToDoClass tdClass = new ToDoClass() { Title="Sleep", Description="Atleast 7 hours of sleep in the day"};
            ToDoClass tdClass2 = new ToDoClass() { Title = "Sleep", Description = "Atleast 7 hours of sleep in the day" };
            ToDoClass tdClass3 = new ToDoClass() { Title = "Sleep", Description = "Atleast 7 hours of sleep in the day" };
            ToDoClass tdClass4 = new ToDoClass() { Title = "Sleep", Description = "Atleast 7 hours of sleep in the day" };

            List<ToDoClass> AllToDoClasses = new List<ToDoClass>();

            AllToDoClasses.Add(tdClass);
            AllToDoClasses.Add(tdClass2);
            AllToDoClasses.Add(tdClass3);
            AllToDoClasses.Add(tdClass4);

            Console.WriteLine("*****Pending Tasks*****");
            Console.WriteLine("----------------------------------------------------------------------");
            foreach (var item in AllToDoClasses)
            {
                Console.WriteLine(
                    $"\r\r\nId: {item.Id} " +
                    $"\nTitle: {item.Title} " +
                    $"\nDescription: {item.Description} " +
                    $"\nPriority: {item.Priority} " +
                    $"\nIsCompleted: {item.IsCompleted} " +
                    $"\nCreatedAt: {item.CreatedAt} ");

            }
            Console.WriteLine("----------------------------------------------------------------------");
        }
    }
}