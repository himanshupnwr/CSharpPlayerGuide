using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPlayerGuide
{
    class Tuple
    {
        static void Main(string[] args)
        {
            //basics of tuple
            //(string, int, int) score = ("R2-D2", 12420, 15);

            var score = ("R2-D2", 12420, 15);

            Console.WriteLine($"Name:{score.Item1} Level:{score.Item3} Score:{score.Item2}");

            (string, int, int) score1 = ("R2-D2", 12420, 15);
            (string, int, int) score2 = score1; // An exact match works.

            //incorrect mapping
            //(string, int) partialScore = score1;  Not the same number of items.
            //(int, int, string) mixedUpScore = score1;  Items in a different order.

            (string Name, int Points, int Level) scorewithname = ("R2-D2", 12420, 15);
            Console.WriteLine($"Name:{scorewithname.Name} Level:{scorewithname.Level} Score:{scorewithname.Points}");

            var scoredisplay = (Name: "R2-D2", Points: 12420, Level: 15);
            Console.WriteLine($"Name:{scoredisplay.Name} Level:{scoredisplay.Level} Score:{scoredisplay.Points}");

            //However, if you do not use var, then the names will not be inferred, and any name supplied
            //when you declared the variable would be used:

            (string, int P, int L) scoreTest = (Name: "R2-D2", Points: 12420, Level: 15);
            Console.WriteLine($"Name:{scoreTest.Item1} Level:{scoreTest.L} Score:{scoreTest.P}");

            //With the above code, the names are Item1, P, and L, not Name, Points, and Level.
            //These examples help illustrate that even though adding names can lead to clearer code, the
            //names are fluid and are not a part of the tuple itself.


            //Tuples use in methods
            void DisplayScore((string Name, int Points, int Level) scoreparameter)
            {
                Console.WriteLine(
                $"Name:{scoreparameter.Name} Level:{scoreparameter.Level} Score:{scoreparameter.Points}");
            }

            (string Name, int Points, int Level) GetScore() => ("R2-D2", 12420, 15);

            var getScore = GetScore();
            Console.WriteLine($"Name:{getScore.Name} Level:{getScore.Level} Score:{getScore.Points}");

            //the names provided by your return value do not need to match those of your variable.This
            //is shown below, where everything is using different names:
            (string One, int Two, int Three) scoreGet = GetScoreLambda();
            DisplayScoreDsiplay(scoreGet);
            (string N, int P, int L) GetScoreLambda() => ("R2-D2", 12420, 15);
            void DisplayScoreDsiplay((string Name, int Points, int Level) scoreGetPara)
            {
                Console.WriteLine(
                $"Name:{scoreGetPara.Name} Level:{scoreGetPara.Level} Score:{scoreGetPara.Points}");
            }
            //This illustrates more clearly that names are ephemeral and not a part of the tuple.

            //here is a tuple with 16 elements to show a much bigger tuple, representing a 4×4 matrix—something often used in games:
            var matrix = (M11: 1, M12: 0, M13: 0, M14: 0,
                          M21: 0, M22: 1, M23: 0, M24: 0,
                          M31: 0, M32: 0, M33: 1, M34: 0,
                          M41: 0, M42: 0, M43: 0, M44: 1);

            (string Name, int Points, int Level)[] CreateHighScores()
            {
                return new (string, int, int)[3]
                {
                    ("R2-D2", 12420, 15),
                    ("C-3PO", 8543, 9),
                    ("GONK", -1, 1),
                };
            }

            //Deconstructing Tuples
            string name;
            int points;
            int level;
            (name, points, level) = score;
            Console.WriteLine($"{name} reached level {level} with {points} points.");

            //using junk or ignorevar as underscore
            (string namescore, int pointsscore, _) = score;


        }
    }
}
