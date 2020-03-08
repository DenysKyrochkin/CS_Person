namespace Practice02.Models
{
    public class Zodiac
    {
        public static string ZodiacChinese(int year)
        {
            if (year % 12 == 0) { return "Monkey"; }
            else if (year % 12 == 1) { return "Rooster"; }
            else if (year % 12 == 2) { return "Dog"; }
            else if (year % 12 == 3) { return "Pig"; }
            else if (year % 12 == 4) { return "Rat"; }
            else if (year % 12 == 5) { return "Ox"; }
            else if (year % 12 == 6) { return "Tiger"; }
            else if (year % 12 == 7) { return "Rabbit"; }
            else if (year % 12 == 8) { return "Dragon"; }
            else if (year % 12 == 9) { return "Snake"; }
            else if (year % 12 == 10) { return "Horse"; }
            else { return "Sheep"; }
        }

        public static string ZodiacWestern(int day, int month)
        {
            switch (month)
            {
                case 1:
                    if (day < 20)
                        return "Capricorn";
                    else
                        return "Aquarius";

                case 2:
                    if (day < 19)
                        return "Aquarius";
                    else
                        return "Pisces";

                case 3:
                    if (day < 21)
                        return "Pisces";
                    else
                        return "Aries";

                case 4:
                    if (day < 20)
                        return "Aries";
                    else
                        return "Taurus";

                case 5:
                    if (day < 21)
                        return "Taurus";
                    else
                        return "Gemini";

                case 6:

                    if (day < 21)
                        return "Gemini";
                    else
                        return "Cancer";

                case 7:
                    if (day < 23)
                        return "Cancer";
                    else
                        return "Leo";


                case 8:
                    if (day < 23)
                        return "Leo";
                    else
                        return "Virgo";

                case 9:
                    if (day < 23)
                        return "Virgo";
                    else
                        return "Libra";

                case 10:
                    if (day < 23)
                        return "Libra";
                    else
                        return "Scorpio";

                case 11:

                    if (day < 22)
                        return "Scorpio";
                    else
                        return "Sagittarius";

                case 12:
                    if (day < 22)
                        return "Sagittarius";
                    else
                        return "Capricorn";
                default:
                    return "";
            }
        }
    }
}
