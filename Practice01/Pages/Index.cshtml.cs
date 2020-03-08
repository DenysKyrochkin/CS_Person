using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Practice02.Models;

namespace Practice02.Pages
{
    public class IndexModel : PageModel
    {

        public string Header { get; set; }
        public string Information { get; set; }

        public void OnGet()
        {
            Header = "Input information about yourself!";

        }
        public void OnPost(string name, string surname, string email, DateTime date)
        {
            var years = Person.GetAge(date);

            if (years < 0)
            {
                Header = "Hello, man from the future!";
                Information = $"Please, input correct date. (before {Person.Today.ToShortDateString()})";
            }

            else if (years > 135)
            {
                Header = "Hello, man from the afterlife!";
                Information = $"Please, input correct date. (after {Person.Today.Year - 135} year). You are {years}";
            }
            else
            {
                Person person = new Person(name, surname, email, date);
                Header = "Thank you for your information. ";
                if (person.IsAdult)
                {
                    Header += "And Happy Birthday to you!";
                }

                Information = $"Now we know that you are {person.Name} {person.Surname}. Your email is {person.Email}. Your birthday date is {person.Birthday.ToShortDateString()}. We know that you are ";
                if (person.IsAdult) { Information += "an adult. "; }
                else { Information += " no an adult. "; }
                Information += $"In western system your zodiac sign is {person.SunSign} and in Chinese is {person.ChineseSign}. And today is ";
                if (person.IsBirthday) { Information += "your birhtday."; }
                else { Information += "not your birhtday."; }
            }
        }

    }

}
