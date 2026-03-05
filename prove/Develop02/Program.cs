using System;
using System.Data;
using System.Runtime.CompilerServices;

//nouns: jounal, entry, date, file, menu, prompts, response (journal/entry- classes) prompts- attribute on entry, date- atribute on journal
//journal: file path, menu
//entry: prompts, response, date
class Program
{

// #region functions
    // static List<string> Prompt_question(List<string> x)
    // {
    //     List<string> input = new List<string>();
        
    //     Random randomGenerator = new Random();
    //     int magik = randomGenerator.Next(0, x.Count);
    //     input.Add(x[magik]);



//     // }


// #region Object
//     public class DisplayJob
//     {
//         public string _date;
//         public string _prompt, _response;
//         public string _rating, _cal, _sleepHours, _screenTime; //stretch challenges

//         public List<string> data;
    
//     }

    //how started
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        bool done = false;
        int userResponse;
        do
        {
            userResponse = menu.ProcessMenu();
            switch(userResponse)
            {
                case 1:
                //creates and adds entry to list of journal entries
                break;
                case 2:
                //displays jounral entries
                break;
                case 3:
                //save journal to file
                break;
                case 4:
                //load journal from file
                break;
                case 5:
                    done = true;
                    break;

            }
            if (userResponse == 5)
            {
                done = true;
            }
        } while(!done);
       
    }
}
