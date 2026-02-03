using System;
using JournalObjects;

class Program
{
    static PromptGenerator pg = new PromptGenerator();
    static Journal myJournal = new Journal(pg);

    static void Welcome()
    {
        Console.WriteLine("Welcome to the Journal Program!");
    }

    static void TaskInput(out int selection)
    {
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Merge (bonus function)");
        Console.WriteLine("6. Quit");
        Console.Write("What would you like to do? ");
        selection = int.Parse(Console.ReadLine());
    }

    static void TaskEvaluator(int selection)
    {
        switch(selection)
        {
            case 1:
                //Write
                TaskWrite();
                break;
            case 2:
                //Display
                TaskDisplay();
                break;
            case 3:
                //Load
                TaskLoad();
                break;
            case 4:
                //Save
                TaskSave();
                break;
            case 5:
                //BONUS POINTS, MERGE
                TaskMerge();
                break;
            case 6:
                //Quit
                TaskQuit();
                break;
            default:
                //Incorrect selection
                break;
        }
    }

    static void TaskWrite()
    {
        myJournal.Write();
    }

    static void TaskDisplay()
    {
        myJournal.Display();
    }

    static void TaskLoad()
    {
        myJournal.Load();
    }

    static void TaskSave()
    {
        myJournal.Save();
    }

    static void TaskMerge()
    {
        myJournal.Merge();
    }

    static void TaskQuit()
    {
        Environment.Exit(0);
    }

    static void Main(string[] args)
    {
        Welcome();
        for(;;)
        {
            TaskInput(out int selection);
            TaskEvaluator(selection);
        }
    }
}