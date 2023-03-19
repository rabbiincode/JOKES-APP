using Microsoft.EntityFrameworkCore;

namespace JOKES.Models
{
    public static class TableData
    {
        //An extension method on the ModelBuilder type
        public static void SeedData(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Joke>().HasData(
                new Joke { Id = 1, Question = "Where do developers drink", Answer = "At joined table" },
                new Joke { Id = 2, Question = "What’s the object-oriented way to become wealthy?", Answer = "Inheritance" },
                new Joke { Id = 3, Question = "When is a function a bad investment?", Answer = "When there's no return" },
                new Joke { Id = 4, Question = "You have just boarded an airline with your team. Shortly before takeoff, you discovered that your team of programmers had been responsible for the flight control software, how many of you would stay on the plane??", 
                                   Answer = "One remained onboard \n\t___After all of them unboarded, one of the team members still remained onboard. When asked why he trusted the software, he said With his team's software, the plane was unlikely to taxi as far as the runway let alone take off" },
                new Joke { Id = 5, Question = "3 SQL databases walked into a NoSQL bar to have some drinks. A little while later they walked out, why??", Answer = "Because they couldn’t find a table" },
                new Joke { Id = 6, Question = "I'm a detective loking for an assassin with my team, but unfortunately i am the one. What am i doing?", Answer = "Debugging" },
                new Joke { Id = 7, Question = "When do two functions fight?", Answer = "When they have arguments" },
                new Joke { Id = 8, Question = "How did the programmer get stuck in the shower?", Answer = "He read the shampoo bottle instructions: Lather. Rinse. Repeat" },
                new Joke { Id = 9, Question = "An SQL query goes into a bar, walks up to two tables, and asks them a question. What did he ask??", Answer = "“Can I join you?”" },
                new Joke { Id = 10, Question = "Why was the DataBase Administrator divorced?", Answer = "Because he has one to many relationships" },
                new Joke { Id = 11, Question = "Why do programmers prefer dark mode?", Answer = "Because light attracts bugs" },
                new Joke { Id = 12, Question = "Why do Java programmers have to wear glasses?", Answer = "Because they don’t C#[see sharp]" },
                new Joke { Id = 13, Question = "How do functions break up?", Answer = "They stop calling each other" },
                new Joke { Id = 14, Question = "What happened to all the illegal exceptions?", Answer = "They were all caught!" },
                new Joke { Id = 15, Question = "What do threads do after they make love?", Answer = "They go to sleep" }
            );
        }
    } 
}
