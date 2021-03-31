using System;
using System.Collections.Generic;

namespace MoviesLab
{
    //Set constructor
    class Movie
    {
        private string Title;
        private string Category;

        public Movie(string movieTitle, string movieCtr)
        {
            Title = movieTitle;
            Category = movieCtr;
        }
        class Program
        {

            static void Main(string[] args)
            {
                Console.WriteLine("Welcome to the Movie List Application");

                List<Movie> movies = new List<Movie>();

                movies.Add(new Movie("Come Play", "Horror"));
                movies.Add(new Movie("Annabelle", "Horror"));
                movies.Add(new Movie("The SpongeBob Movie", "Comedy"));
                movies.Add(new Movie("Boss Baby", "Comedy"));
                movies.Add(new Movie("Aladdin", "Comedy"));
                movies.Add(new Movie("Underwater", "Sci-Fi"));
                movies.Add(new Movie("Platform", "Sci-Fi"));
                movies.Add(new Movie("Honest Theif", "Action"));
                movies.Add(new Movie("Wonder Woman", "Action"));
                movies.Add(new Movie("Monster Hunter", "Action"));

                bool done = false;

                while (!done)
                {
                    bool existingCtr = false;
                    Console.WriteLine("There are ten movies in this list. \nWhich category are you interested in?");
                    string userInput = Console.ReadLine();

                    foreach (Movie Title in movies)
                    {
                        if (Title.Category == userInput)
                        {
                            existingCtr = true;
                            break;
                        }
                    }
                    if (existingCtr)
                    {
                        foreach (Movie Title in movies)
                        {
                            if (Title.Category == userInput)
                            {
                                Console.WriteLine(Title.Title, Title.Category);
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Sorry {userInput} does not exist.");
                    }

                    bool Continue = false;

                    while (!Continue)
                    {
                        Console.WriteLine("Would you like to continue? Please enter (y/n)");
                        string userContinue = Console.ReadLine().ToLower();

                        if (userContinue == "n" || userContinue == "N")
                        {
                            done = true;
                            Continue = false;
                            Console.WriteLine("Thanks for watching!");
                            break;
                        }
                        if (userContinue == "y" || userContinue == "Y")
                        {
                            done = false;
                            Continue = true;
                        }
                        else
                        {
                            Console.WriteLine("Invalid option. Please select y or n");
                        }
                    }
                }
            }
        }
    }
}



 