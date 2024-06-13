using System;
using System.Formats.Asn1;
using System.Net;


public class Listing : Mindfulness
{
    private List<string> _promptsList;
    private List<string> _userList;
    /*
    private List<> prompts;
    private List<> userList;
    */

    public Listing(string title, string time, int countdown, string startUpMsg, string endActivity, string activityDescription)
        : base(title, time, countdown, startUpMsg, endActivity, activityDescription)
    {
        _promptsList = new List<string>
        {
            "What are some your favorite memories from your childhood",
            "Who are some superheroes in your life",
            "What are the biggest advantages to being a college student?",
            "Why do you love your significant other?",
            "What is a key-defining moment for you in your life",
            "What are some of the greatest ambitions that you have within your life?",
            "What are you going to do to accomplish your dreams?",
            "What life dreams scare you the most, in that they require an intense amount of effort to get there?",
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
        };

        _userList = new List<string>();
    }
        private string GetRandomPromptList()
        {
            Random random = new Random();
            int promptList = random.Next(_promptsList.Count);
            return _promptsList[promptList];
        }

        public void StartupListing()
        {
            Console.WriteLine(_startUpMsg);

            // will prompt the user for the duration of time, with a variable for input and duration. //
            Console.Write("Please enter the desired duration in (seconds) for the Listing Activity: ");

            string input = Console.ReadLine();
            int duration;

            // validator for the user input for the time duation //
            while (!int.TryParse(input, out duration) || duration <= 0)
            {
                Console.Write("This is not a valid input type, I cannot accept negative values, or less than time alloted in the Universe. Please try again!");
                input = Console.ReadLine();
            }

            // this will display a random prompt from my list //
            string prompt = GetRandomPromptList();
            Console.WriteLine("\n" + prompt);

            DateTime endTime = DateTime.Now.AddSeconds(duration);
            while (DateTime.Now < endTime)
            {
                Console.WriteLine("Enter your responses here: ");
                string response = Console.ReadLine();

                if (!string.IsNullOrEmpty(response))
                {
                    _userList.Add(response);
                }
                
                else
                {
                    Console.WriteLine("You've gotta try entering something, or else the response will not be recorded. Keep it up though, and try again!");
                }
            }

            // This is what the user will see after doing the exercise. //

            Console.WriteLine("\n The timer has ended, congratulations for taking the time to take care of yourself!");
            Console.WriteLine("\nHere are your responses for this activity:");

            foreach (string response in _userList)
            {
                Console.WriteLine("- ");
            }
        }


    }

