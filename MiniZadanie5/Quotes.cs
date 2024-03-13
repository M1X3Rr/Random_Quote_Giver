using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniZadanie5
{
    internal class Quotes
    {
        private List<string> quotesList;
        private Random random;

        public Quotes() 
        {
            quotesList = new List<string>()
            {
                "Be the change that you wish to see in the world. - Mahatma Gandhi",
                "The only limit to our realization of tomorrow will be our doubts of today. - Franklin D. Roosevelt",
                "The future belongs to those who believe in the beauty of their dreams. - Eleanor Roosevelt",
                "The only way to do great work is to love what you do. - Steve Jobs",
                "In the middle of difficulty lies opportunity. - Albert Einstein",
                "The future belongs to those who believe in the beauty of their dreams. - Eleanor Roosevelt",
                "Success is not final, failure is not fatal: It is the courage to continue that counts. - Winston Churchill",
                "Strive not to be a success, but rather to be of value. - Albert Einstein",
                "It always seems impossible until it's done. - Nelson Mandela",
                "Your time is limited, don't waste it living someone else's life. - Steve Jobs",
                "The only limit to our realization of tomorrow will be our doubts of today. - Franklin D. Roosevelt"
            };

            random = new Random();
        }

        public string GetRandomQuote()
        {
            int randomIndex = random.Next(quotesList.Count);

            return quotesList[randomIndex];
        }
    }
}
