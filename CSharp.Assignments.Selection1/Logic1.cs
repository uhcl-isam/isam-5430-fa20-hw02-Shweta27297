using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Assignments.Loop1
{
    public class Logic1
    {
        /// <summary>
        /// When squirrels get together for a party, they like to have cigars. A squirrel party is successful when the number of cigars is between 40 and 60, inclusive. Unless it is the weekend, in which case there is no upper bound on the number of cigars. Return true if the party with the given values is successful, or false otherwise.
        /// </summary>
        /// <param name="cigars"></param>
        /// <param name="isWeekend"></param>
        /// <returns></returns>
        public static bool CigarParty(int cigars, bool isWeekend)
        {
            {
                if (isWeekend && (cigars >= 40))
                {
                    return true;
                }
                else if (cigars >= 40 && cigars <= 60)
                {
                    return true;
                }
                return false;
            }
        }

        public static bool CloseFar(int a, int b, int c)
        {
            throw new NotImplementedException();
        }

        public static bool IsHilly(int number)
        {
            throw new NotImplementedException();
        }

        public static bool AnswerCell(bool isMorning, bool isMom, bool isAsleep)
        {
            throw new NotImplementedException();
        }

        public static string AlarmClock(DayOfWeek dayOfWeek, bool vacation)
        {
            throw new NotImplementedException();
        }

        public static bool SquirrelPlay(int temperature, bool isSummer)
        {
            throw new NotImplementedException();
        }

        public static int TeaParty(int tea, int candy)
        {
            throw new NotImplementedException();
        }

        public static bool NearTen(int num)
        {
            throw new NotImplementedException();
        }

        public static bool More20(int num)
        {
            throw new NotImplementedException();
        }

        public static bool Love6(int a, int b)
        {
            throw new NotImplementedException();
        }

        public static int CaughtSpeeding(int speed, bool birthday)
        {
            throw new NotImplementedException();
        }
    }
}
