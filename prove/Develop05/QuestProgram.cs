using System;

class Program
{
    static void Main(string[] args)
    {
        Goals goals = new Goals();
        bool running = true;

        while (running)
        {
            Console.WriteLine($"Score: {goals.GetDisplayScore()}");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create Goal:");
            Console.WriteLine("2. Display Goals:");
            Console.WriteLine("3. Record Event:");
            Console.WriteLine("4. Save Goals:");
            Console.WriteLine("5. Load Goals:");
            Console.WriteLine("6. Quit:");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                int createGoalChoice = 0;

                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Checklist Goal");
                Console.WriteLine("3. Eternal Goal");
                Console.WriteLine("4. Quit");
                createGoalChoice = int.Parse(Console.ReadLine());
                switch (createGoalChoice)
                {
                    case 1:
                        Simple mySimpleGoal = new Simple("Simple");
                        mySimpleGoal.CreateGoal();        
                        goals.AddGoal(mySimpleGoal);                
                        //Console.WriteLine(mySimpleGoal.GetConsoleString());
                        break;

                    case 2:
                        Checklist myChecklist = new Checklist("Checklist");
                        myChecklist.CreateGoal();
                        goals.AddGoal(myChecklist);                
                        //Console.WriteLine(myChecklist.GetConsoleString());
                        break;

                    case 3:
                        Eternal myEternal = new Eternal("Eternal");
                        myEternal.CreateGoal();
                        goals.AddGoal(myEternal);                
                        //Console.WriteLine(myEternal.GetConsoleString());
                        break;

                }
                break;

                case 2:
                goals.DisplayGoals();
                break;

                case 3:
                goals.RecordEvent();
                break;

                case 4:
                goals.SaveGoals();
                break;

                case 5:
                goals.LoadGoals();
                break;

                case 6:
                running = false;
                break;
            }

        }
        
        //Console.Write("Set goal name: ");
        //Goal.SetName(Console.ReadLine());
    }

}