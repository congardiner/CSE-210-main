
class journalPrompt
{
         // need to implement the Random promptGenerator here.
        private static List<string> prompts = new List<string>()
        {
        
         "What is one of highlights from your day?",
         "Did you have a funny, weird, or abnormal experience?",
         "Write the first word that comes to mind, and write a short paragraph about what the means to you based off of your day?",
         "Outline three things that you are grateful for, and why:",
         "Write about your favorite vacation, and one place that you'd like to visit:",
         "What did you do to 'love yourself' today?",
         "What is something that you did today that pushed you outside of your comfort zone, if you can't think of something, what will you do tomorrow? Be specific.",
         "Who did you serve today?",
         "What are some goals that you accomplished, or are working on for this week?",
         "Did you overcome a specific challenge today, and if so, what was it and how did you make it happen?",
         "Who are you trying to become?",
         "What brings you joy? Truly, what is helping you through life right now?",
         "What will you do tomorrow to make today memorable, worthwhile, and relivable?",
        };

        public static string GetRandomPrompt()
        {
            Random random = new Random();
            int index = random.Next(0, prompts.Count);

            return prompts[index];
        }
}






    