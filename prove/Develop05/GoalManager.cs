public class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }
    public void Start()
    {
        while (true)
        {
            Console.WriteLine("\nEternal Quest Program");
            Console.WriteLine("1. Display Player Info");
            Console.WriteLine("2. List Goal Names");
            Console.WriteLine("3. List Goal Details");
            Console.WriteLine("4. Create Goal");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Save Goals");
            Console.WriteLine("7. Load Goals");
            Console.WriteLine("8. Exit");

            Console.Write("Choose an option: ");
            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                if (choice == 1) DisplayPlayerInfo();
                else if (choice == 2) ListGoalNames();
                else if (choice == 3) ListGoalDetails();
                else if (choice == 4) CreateGoal();
                else if (choice == 5) RecordEvent();
                else if (choice == 6) SaveGoals();
                else if (choice == 7) LoadGoals();
                else if (choice == 8) break;
                else Console.WriteLine("Invalid option. Please try again.");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nTotal Score: {_score} points");
    }
        public void ListGoalNames()
    {
        Console.WriteLine("\nGoal Names:");
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }
    public void ListGoalDetails()
    {
        Console.WriteLine("\nGoal Details:");
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }
    public void CreateGoal()
    {
        Console.WriteLine("\nChoose Goal Type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        int choice;
        if (int.TryParse(Console.ReadLine(), out choice))
        {
            Console.Write("Enter goal name: ");
            string name = Console.ReadLine();
            Console.Write("Enter goal description: ");
            string description = Console.ReadLine();
            Console.Write("Enter goal points: ");
            int points = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                _goals.Add(new SimpleGoal(name, description, points));
            }
            else if (choice == 2)
            {
                _goals.Add(new EternalGoal(name, description, points));
            }
            else if (choice == 3)
            {
                Console.Write("Enter target times to complete: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new CheckListGoal(name, description, points, target, bonus));
            }
            else
            {
                Console.WriteLine("Invalid option. Goal not created.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number.");
        }
    }
    public void RecordEvent()
    {
        Console.WriteLine("\nEnter the name of the goal to record:");
        string name = Console.ReadLine();

        Goal goal = null;
        foreach (var g in _goals)
        {
            if (g.GetDetailsString().Contains(name))
            {
                goal = g;
                break;
            }
        }
        if (goal != null)
        {
            _score += goal.RecordEvent();
            Console.WriteLine($"Current Points: {_score}");
        }
        else
        {
            Console.WriteLine("Goal not found.");
        }
    }
    public void SaveGoals()
    {
        Console.Write("Enter file name to save goals: ");
        string fileName = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (var goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
            writer.WriteLine(_score);
        }
        Console.WriteLine("Goals saved.");
    }
    public void LoadGoals()
    {
        Console.Write("Enter file name to load goals: ");
        string fileName = Console.ReadLine();

        if (File.Exists(fileName))
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                _goals.Clear();
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var parts = line.Split(':');
                    var type = parts[0];
                    var data = parts[1].Split(',');
                    if (type == "SimpleGoal")
                    {
                        _goals.Add(new SimpleGoal(data[0], data[1], int.Parse(data[2])));
                    }
                    else if (type == "EternalGoal")
                    {
                        _goals.Add(new EternalGoal(data[0], data[1], int.Parse(data[2])));
                    }
                    else if (type == "CheckListGoal")
                    {
                        _goals.Add(new CheckListGoal(data[0], data[1], int.Parse(data[2]), int.Parse(data[3]), int.Parse(data[4])));
                    }
                }
                _score = int.Parse(reader.ReadLine());
            }
            Console.WriteLine("Goals loaded.");
        }
        else
        {
            Console.WriteLine("No saved goals found.");
        }
    }
}
