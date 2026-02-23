namespace ToDoApp
{
    public class Program()
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("=========================");
            Console.WriteLine("Welcome to the ToDo App");
            Console.WriteLine("=========================");

            ToDoClass tdClass = new ToDoClass() { Id=1, Title="Sleep", Description="Atleast 7 hours of sleep in the day"};
            ToDoClass tdClass2 = new ToDoClass() { Id = 1, Title = "Sleep", Description = "Atleast 7 hours of sleep in the day" };
            ToDoClass tdClass3 = new ToDoClass() { Id = 1, Title = "Sleep", Description = "Atleast 7 hours of sleep in the day" };
            ToDoClass tdClass4 = new ToDoClass() { Id = 1, Title = "Sleep", Description = "Atleast 7 hours of sleep in the day" };

            List<ToDoClass> AllToDoClasses = new List<ToDoClass>();

            AllToDoClasses.Add(tdClass);
            AllToDoClasses.Add(tdClass2);
            AllToDoClasses.Add(tdClass3);
            AllToDoClasses.Add(tdClass4);

            Console.WriteLine("*****Pending Tasks*****");
            Console.WriteLine("----------------------------------------------------------------------");
            for (int i=0; i<AllToDoClasses.Count(); i++)
            {
                Console.WriteLine(
                    $"\r\r\nNumber: {i+1} " +
                    $"\nTitle: {AllToDoClasses[i].Title} " +
                    $"\nDescription: {AllToDoClasses[i].Description} " +
                    $"\nPriority: {AllToDoClasses[i].Priority} " +
                    $"\nIsCompleted: {AllToDoClasses[i].IsCompleted} " +
                    $"\nCreatedAt: {AllToDoClasses[i].CreatedAt} ");

            }
            Console.WriteLine("----------------------------------------------------------------------");
        }
    }
}