using System;
using System.ComponentModel.DataAnnotations;

namespace Practice02.Models
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public DateTime Birthday { get; set; }

        public static DateTime Today = DateTime.Today;

        public Person(string name, string surname, string email, DateTime birthday)
        {
            Name = name; Surname = surname; Email = email; Birthday = birthday;
        }

        public Person(string name, string surname, string email)
        {
            Name = name; Surname = surname; Email = email;
        }

        public Person(string name, string surname, DateTime birthday)
        {
            Name = name; Surname = surname; Birthday = birthday;
        }

        public static int GetAge(DateTime birthDate)
        {
            return Today.Year - birthDate.Year - 1 +
                ((Today.Month > birthDate.Month || Today.Month == birthDate.Month && Today.Day >= birthDate.Day) ? 1 : 0);
        }

        public bool IsAdult
        {
            get
            {
                if(GetAge(Birthday) >= 18)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public string SunSign => Zodiac.ZodiacWestern(Birthday.Day, Birthday.Month);

        public string ChineseSign => Zodiac.ZodiacChinese(Birthday.Year);

        public bool IsBirthday
        {

            get
            {
                
                if (Today.Month == Birthday.Month && Today.Day == Birthday.Day)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
