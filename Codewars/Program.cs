using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;
using System.Text;

namespace Codewars
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * <summary>
             *  1. completed
             *  2. completed
             *  3. completed
             *  4. completed
             *  5. completed
             *  6. completed
             *  7. completed
             *  8. completed
             *  9. completed - Zip and Range function (LINQ)
             *  10. completed
             *  11. completed
             *  12. completed
             *  13. completed
             *  14. completed - interesting, Where with two paramaters
             *  15. completed
             *  16. completed
             *  17. completed
             *  18. completed - you could find the ForEach with the list in Linq
             *  19. completed - interesting use of Linq
             *  20. completed
             *  21. completed
             *  22. not completed
             *  23. completed
             *  24. completed
             * </summary>
             */
            #region 1. Are they the "same"?
            // link: https://www.codewars.com/kata/550498447451fbbd7600041c
            // create a function comp(a, b). a and b are two array of numbers
            // valid array:
            // a = [121, 144, 19, 161, 19, 144, 19, 11]
            // b = [121, 14641, 20736, 361, 25921, 361, 20736, 361]
            // because 19 * 19 = 361;  121 * 121 = 14641 ...

            // valid case
            //int[] a = new int[] { 121, 144, 19, 161, 19, 144, 19, 11 };
            //int[] b = new int[] { 11 * 11, 121 * 121, 144 * 144, 19 * 19, 161 * 161, 19 * 19, 144 * 144, 19 * 19 };

            //Console.WriteLine("Are the \"same\"? " + comp(a, b));

            //// invalid case
            //int[] ab = new int[] { 121, 144, 19, 161, 19, 144, 19, 11 };
            //int[] ba = new int[] { 132, 14641, 20736, 361, 25921, 361, 20736, 361 };

            //Console.WriteLine("Are the \"same\"? " + compShortMethod(ab, ba));
            #endregion

            #region 2. Simple assembler interpreter
            // link: https://www.codewars.com/kata/58e24788e24ddee28e000053/train/csharp
            //var program = new[] { "mov a 5", "inc a", "dec a", "dec a", "jnz a -1", "inc a", "mov a -10", "mov b a", "inc a", "dec b", "jnz a -2", "mov a 1", "mov b 1", "mov c 0", "mov d 26", "jnz c 2", "jnz 1 5", "mov c 7", "inc d", "dec c", "jnz c -2", "mov c a", "inc a", "dec b", "jnz b -2", "mov b c", "dec d", "jnz d -6", "mov c 18", "mov d 11", "inc a", "dec d", "jnz d -2", "dec c", "jnz c -5" };

            //foreach (KeyValuePair<string, int> kvp in Interpret(program))
            //    Console.WriteLine("Variable {0} value: {1}", kvp.Key, kvp.Value);
            #endregion

            #region 3. Genetic Algorithm Series - #1 Generate
            //// link: https://www.codewars.com/kata/567b468357ed7411be00004a
            //// generate a random numbers between 0 and 1 of a specific length
            //var length = 10;

            //Console.WriteLine(Generate(length));

            //Console.WriteLine(GenerateLINQ_01(length));
            #endregion

            #region 4. Genetic Algorithm Series - #2 Mutation
            //// link: https://www.codewars.com/kata/567b39b27d0a4606a5000057/train/csharp
            //var mutate = GenerateLINQ_01(10);

            //Console.WriteLine("The binary number is: {0}", mutate);
            //Console.WriteLine("The binary number mutate is: {0}", Mutate(mutate, 0.3));

            #endregion

            #region 5. Genetic Algorithm Series - #3 Crossover
            //// link: https://www.codewars.com/kata/567d71b93f8a50f461000019/csharp
            //var chromosome1 = "111110";
            //var chromosome2 = "000000";
            //var index = 3;

            //Console.WriteLine("Chromosome1 is: {0} and chromosome2 is: {1}", Crossover(chromosome1, chromosome2, index).ElementAt(0), Crossover(chromosome1, chromosome2, index).ElementAt(1));
            #endregion

            #region 6. Genetic Algorithm Series - #4 Get population and fitnesses
            //// link: https://www.codewars.com/kata/567b468357ed7411be00004a/train/csharp
            //IEnumerable<string> population = new List<string> { "11001111", "01110001",
            //                                                    "00010011", "01101100", "00110101", "00110011", "01011000", "11101001", "11101101",
            //                                                    "10001100", "01100101", "01000001", "01010000", "00000000", "11110111", "01100000",
            //                                                    "11110011", "10101110", "10101100", "11101010", "10011000", "01100001", "00101001",
            //                                                    "11101000", "11011101", "00110111", "00111011", "10100100", "11101100", "01111011",
            //                                                    "00001010", "10010010", "11101000", "00110000", "01000010", "10100110", "10011101",
            //                                                    "11110000", "00100010", "11001010", "11010001", "00010110", "10110011", "00111000",
            //                                                    "10111010", "10000100", "11101011", "01001111", "01101101", "00101110", "11010110",
            //                                                    "11100110", "10010011", "00110100", "11011111", "00111100", "01011011", "11101100",
            //                                                    "01110101", "11010111", "00101000", "00100110", "11001010", "10011011", "01000011",
            //                                                    "00101111", "01110110", "10011110", "11011101", "10011110", "00001101", "01101100",
            //                                                    "01110111", "00111101", "00000011", "00111001", "10000011", "01000110", "01011101",
            //                                                    "01110011", "10011011", "10000110", "10101111", "10111100", "00011010", "11100101",
            //                                                    "01110101", "00000110", "11111000", "10000110", "01001000", "11111100", "11010000",
            //                                                    "10011101", "01001100", "01101011", "11010110", "11011100", "01000101", "01110000" };

            //Func<string, double> fitness = (c) => {
            //    var ideal = "11110000";
            //    double r = 0;
            //    for (int i = 0; i < c.Length; ++i)
            //    {
            //        if (c[i] == ideal[i])
            //        {
            //            r++;
            //        }
            //    }
            //    return r / (double)ideal.Length;
            //};

            //foreach (var r in ChromosomeWrap.MapPopulationFit(population, fitness))
            //    Console.WriteLine("Chromosome: {0} and his Fitness {1}.", r.Chromosome, r.Fitness);
            #endregion

            #region 7. Genetic Algorithm Series - #5 Roulette wheel selection
            ////link: https://www.codewars.com/kata/567b21565ffbdb30e3000010/train/csharp
            //// Fitness proportionate selection or roulette wheel selection: https://en.wikipedia.org/wiki/Fitness_proportionate_selection
            //// or: https://www.tutorialspoint.com/genetic_algorithms/genetic_algorithms_parent_selection.htm
            //string[] population = new string[] { "1", "2", "3" };
            //double[] fitnesses = new double[] { 0.05, 0.05, 0.90 };

            //for (int i = 0; i < 10; i++)
            //{
            //    var results = new List<string>();
            //    for (int j = 0; j < 10; j++)
            //    {
            //        results.Add(Select(population, fitnesses));
            //    }

            //    var threes = results.Count(c => c == "3");
            //    Console.WriteLine($"3 should be the most returned element, got {threes} returns");
            //}
            #endregion

            #region 8. Array.diff
            //// link: https://www.codewars.com/kata/523f5d21c841566fde000009/train/csharp
            //// example 1:
            //Console.WriteLine("Expected: new int[] { 2 }");

            //foreach (var val in ArrayDiff(new int[] { 1, 2 }, new int[] { 1 }))
            //    Console.WriteLine("'" + val + "'");

            //// example 2:
            //Console.WriteLine("Expected: new int[] { 2, 2 }");

            //foreach (var val in ArrayDiff(new int[] { 1, 2, 2 }, new int[] { 1 }))
            //    Console.WriteLine("'" + val + "'");

            //// example 3:
            //Console.WriteLine("Expected: new int[] { 1 }");

            //foreach (var val in ArrayDiff(new int[] { 1, 2, 2 }, new int[] { 2 }))
            //    Console.WriteLine("'" + val + "'");

            //// example 4:
            //Console.WriteLine("Expected: new int[] { 1, 2, 2 }");

            //foreach (var val in ArrayDiff(new int[] { 1, 2, 2 }, new int[] { }))
            //    Console.WriteLine("'" + val + "'");

            //// example 5:
            //Console.WriteLine("Expected: ew int[] { }");

            //foreach (var val in ArrayDiff(new int[] { }, new int[] { 1, 2 }))
            //    Console.WriteLine("'" + val + "'");
            #endregion

            #region 9. Integer Difference
            //// link: https://www.codewars.com/kata/57741d8f10a0a66915000001/train/csharp
            //var elements = new int[] { 1, 1, 5, 6, 9, 16, 27 };
            //var diff = 4;

            //Console.WriteLine(IntDiffShorther(elements, diff));
            #endregion

            #region 10. Difference of 2
            //// link: https://www.codewars.com/kata/5340298112fa30e786000688/train/csharp
            //int[] array = { 2, 1, 3, 4 };

            //foreach (var value in TwosDifferenceCleaver(array))
            //    Console.WriteLine(value);
            #endregion

            #region 11. Not very secure
            // link: https://www.codewars.com/kata/526dbd6c8c0eb53254000110/train/csharp
            //Console.WriteLine("'Ciao mondo' è alfanumerico: {0}", Alphanumeric("Ciao Mondo"));
            //Console.WriteLine("'SuperCalifragiListicheSpiralidoso' è alfanumerico: {0}", Alphanumeric("SuperCalifragiListicheSpiralidoso"));
            //Console.WriteLine("'FucK69' è alfanumerico: {0}", Alphanumeric("FucK69"));
            //Console.WriteLine("'Ehilà0990' è alfanumerico: {0}", Alphanumeric("Ehilà0990"));
            //Console.WriteLine("'prova_underscore___' è alfanumerico: {0}", Alphanumeric("prova_underscore___"));
            #endregion

            #region 12. Number Zoo Patrol
            //link: https://www.codewars.com/kata/5276c18121e20900c0000235/train/javascript
            //var numberZoo1 = new int[] { 1, 3, 4, 5, 6, 7, 8 };

            //Console.WriteLine(FindNumber_02(numberZoo1));

            //var numberZoo2 = new int[] { 1, 2 };

            //Console.WriteLine(FindNumber_02(numberZoo2));

            //var numberZoo3 = new int[] { 2, 3, 4 };

            //Console.WriteLine(FindNumber_02(numberZoo3));
            #endregion

            #region 13. Reversing a Process
            //// link: https://www.codewars.com/kata/5dad6e5264e25a001918a1fc/train/csharp

            //// the function code(string, int) is only for practise
            //Func<string, int, string> code = (s, num) =>
            //{
            //    if (!Regex.IsMatch(s, @"^[a-z]+$"))
            //        throw new ArgumentException("You can insert only lower case characters");

            //    var r = "";

            //    for (int i = 0; i < s.Length; i++)
            //    {
            //        var x = s[i] - 'a';
            //        var n = x * num % 26;
            //        r += Convert.ToChar(n + 'a');
            //    }

            //    return num + r;
            //};

            //var inputS = code("mer", 6015);

            //Console.WriteLine(Decode(inputS));
            #endregion

            #region 14. Delete occurrences of an element if it occurs more than n times
            // link: https://www.codewars.com/kata/554ca54ffa7d91b236000023/train/csharp
            //var arr = new int [] { 1, 2, 3, 1, 2, 1, 2, 3 };
            //var x = 2;
            //var list = new List<int>();

            //// my version
            //foreach (var i in DeleteNth(arr, x))
            //    Console.Write(i);

            //Console.WriteLine();

            //// shorter
            //foreach (var l in DeleteNth_01(arr, x))
            //    Console.Write(l);

            //Console.WriteLine();

            #endregion

            #region 15. Lazy Repeater
            //// link: https://www.codewars.com/kata/51fc3beb41ecc97ee20000c3/train/csharp

            //var abc = MakeLooperS("abc");
            //Console.WriteLine(abc());
            //Console.WriteLine(abc());
            //Console.WriteLine(abc());
            //Console.WriteLine(abc());
            //Console.WriteLine(abc());
            //Console.WriteLine(abc());
            #endregion

            #region 16. Greed is Good
            //// link: https://www.codewars.com/kata/5270d0d18625160ada0000e4/csharp
            //var arr = new int[] { 6, 6, 6, 3, 3 };

            //Console.WriteLine(ScoreS(arr));
            #endregion

            #region 17. Josephus Permutation
            //// link: https://www.codewars.com/kata/5550d638a99ddb113e0000a2/train/csharp

            //// test 1:
            //// (new List<object> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 1) ==> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }
            //// test 2:
            //// (new List<object> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 2) ==> { 2, 4, 6, 8, 10, 3, 7, 1, 9, 5 }
            //// test 3:
            //// (new List<object> { "C", "o", "d", "e", "W", "a", "r", "s" }, 4) ==> { "e", "s", "W", "o", "C", "d", "r", "a" }
            //// test 4:
            //// (new List<object> { 1, 2, 3, 4, 5, 6, 7 }, 3) ==> { 3, 6, 2, 7, 5, 1, 4 }


            //var jp = JosephusProblemS(new List<object> { "C", "o", "d", "e", "W", "a", "r", "s" }, 4);

            //foreach (var val in jp)
            //    Console.WriteLine(val);

            #endregion

            #region 18. Does my number look big in this?
            //// link: https://www.codewars.com/kata/5287e858c6b5a9678200083c/csharp
            //var n = 357;

            //Console.WriteLine(Narcissistic(n));

            //var n1 = 153;

            //Console.WriteLine(NarcissisticWoW(n1));
            #endregion

            #region 19. String Letter Counting
            //// link: https://www.codewars.com/kata/59e19a747905df23cb000024/train/csharp
            //var str = "This is a test sentence.";

            //Console.WriteLine(StringLetterCountS(str));

            //var str1 = "5677855421";

            //Console.WriteLine(StringDigitCount(str1));
            #endregion

            #region 20. Play with two Strings
            //// link: https://www.codewars.com/kata/56c30ad8585d9ab99b000c54/train/csharp
            //var a = "abcdeFgtrzw";
            //var b = "defgGgfhjkwqe";

            //Console.WriteLine(workOnStrings(a, b));
            #endregion

            #region 21. Encrypt this!
            //// link: https://www.codewars.com/kata/5848565e273af816fb000449
            //var str = "hello world";

            //Console.WriteLine(EncryptThisAnotherVersion(str));
            #endregion

            #region 22. Text align justify
            // link: https://www.codewars.com/kata/537e18b6147aa838f600001b/csharp
            var str = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum sagittis dolor mauris, at elementum ligula tempor eget. In quis rhoncus nunc, at aliquet orci. Fusce at dolor sit amet felis suscipit tristique. Nam a imperdiet tellus. Nulla eu vestibulum urna. Vivamus tincidunt suscipit enim, nec ultrices nisi volutpat ac. Maecenas sit amet lacinia arcu, non dictum justo. Donec sed quam vel risus faucibus euismod. Suspendisse rhoncus rhoncus felis at fermentum. Donec lorem magna, ultricies a nunc sit amet, blandit fringilla nunc. In vestibulum velit ac felis rhoncus pellentesque. Mauris at tellus enim. Aliquam eleifend tempus dapibus. Pellentesque commodo, nisi sit amet hendrerit fringilla, ante odio porta lacus, ut elementum justo nulla et dolor.";
            var len = 30;

            #endregion

            #region 23. Address Book by State
            //// link: https://www.codewars.com/kata/59d0ee709f0cbcf65400003b/solutions/csharp
            //string ad3 = "John Daggett, 341 King Road, Plymouth MA\nAlice Ford, 22 East Broadway, Richmond VA\nOrville Thomas, 11345 Oak Bridge Road, Tulsa OK\nTerry Kalkas, 402 Lans Road, Beaver Falls PA\nEric Adams, 20 Post Road, Sudbury MA\nHubert Sims, 328A Brook Road, Roanoke VA\nAmy Wilde, 334 Bayshore Pkwy, Mountain View CA\nSal Carpenter, 73 6th Street, Boston MA";

            //Console.WriteLine(ByState(ad3));
            #endregion

            #region 24. A Rule of Divisibility by 13
            //// link: https://www.codewars.com/kata/564057bc348c7200bd0000ff/train/csharp
            //long n = 12345678;

            //Console.WriteLine(ThirtSeprum(n));
            #endregion

            #region Curiosity
            // 1. recursion
            //var array = new int[] { 1, 2, 3 };

            //Console.WriteLine(SumArray(array, array.Length));
            #endregion
        }

        #region 1. Are they the "same"?
        public static bool comp(int[] a, int[] b)
        {
            if (a == null || b == null || a.Length != b.Length)
                return false;

            double totalA = 0, totalB = 0;

            for (int i = 0; i < a.Length; i++)
            {
                totalA += a[i];
                totalB += System.Math.Sqrt(b[i]);
            }

            return totalA == totalB;
        }

        public static bool compShortMethod(int[] a, int[] b)
        {
            if (a == null || b == null || a.Length != b.Length)
                return false;

            return a.Select(x => x * x).OrderBy(x => x).SequenceEqual(b.OrderBy(x => x));
        }
        #endregion

        #region 2. Simple assembler interpreter
        public static Dictionary<string, int> Interpret(string[] program)
        {
            var i = 0;
            var variables = new Dictionary<string, int>();

            while (i<program.Length)
            {
                var instruction = program[i].Split(' ');
                var cmd = instruction[0];
                var variable = instruction[1];
                var option = (cmd == "inc" || cmd == "dec") ? "" : instruction[2];
                var existVariable = variables.ContainsKey(variable);

                switch (cmd)
                {
                    case "mov":
                        var val = (variables.ContainsKey(option)) ? variables[option] : Convert.ToInt32(option);

                        if (!existVariable)
                            variables.Add(variable, val);
                        else
                            variables[variable] = val;
                        break;
                    case "inc":
                        variables[variable]++;
                        break;
                    case "dec":
                        variables[variable]--;
                        break;
                    case "jnz":
                        var isNotZero = existVariable ? variables[variable] != 0 : Convert.ToInt32(variable) != 0;

                        if (isNotZero)
                        {
                            i += Convert.ToInt32(option);
                            continue;
                        }
                        break;
                    default:
                        throw new ArgumentException("Invalid command");
                }
                i++;
            }
            return variables;
        }
        #endregion

        #region 3. Genetic Algorithm Series - #1 Generate
        public static string Generate(int length)
        {
            var str = "";
            var random = new Random();

            for (int i = 0; i < length; i++)
                str = String.Concat(str, random.Next(0, 2));

            return str;
        }

        // another method with LINQ
        public static string GenerateLINQ_01(int length)
        {
            var random = new Random();

            return String.Concat(Enumerable.Range(0, length).Select(_ => random.Next(0, 2)));
        }
        #endregion

        #region 4. Genetic Algorithm Series - #2 Mutation
        public static string Mutate(string chromosome, double probability)
        {
            if (String.IsNullOrEmpty(chromosome))
                throw new ArgumentNullException("Chromosome is empty");

            if (probability < 0.0 || probability > 1.0)
                throw new ArgumentOutOfRangeException("The probability can be between 0.0 and 1.1");

            var right = chromosome.Skip(Convert.ToInt32(chromosome.Length * probability)).Select(x => x);

            return String.Concat(chromosome.Take(Convert.ToInt32(chromosome.Length * probability))
                                           .Select(x => (x == '1') ? '0' : '1')
                                           .Concat(right));
        }

        // another version
        public static string MutateAnother(string chromosome, double probability)
        {
            if (String.IsNullOrEmpty(chromosome)) throw new ArgumentNullException("Chromosome is empty");
            if (probability < 0.0 || probability > 1.0) throw new ArgumentOutOfRangeException("The probability can be between 0.0 and 1.1");

            var random = new Random();

            return String.Concat(chromosome.Select(x => random.NextDouble() < probability ? (x == '1') ? '0' : '1' : x));
        }
        #endregion

        #region 5. Genetic Algorithm Series - #3 Crossover
        public static IEnumerable<string> Crossover(string chromosome1, string chromosome2, int cut)
        {
            return new[]
                        {
                            String.Concat(chromosome1.Take(cut).Concat(chromosome2.Skip(cut).Select(x => x)))
                            ,String.Concat(chromosome2.Take(cut).Concat(chromosome1.Skip(cut).Select(x => x)))
                        };
        }

        // another version
        public static IEnumerable<string> CrossoverStrange(string chromosome1, string chromosome2, int cut)
        {
            return new[]
            {
                $"{chromosome1.Substring(0, cut)}{chromosome2.Substring(cut)}",
                $"{chromosome2.Substring(0, cut)}{chromosome1.Substring(cut)}"
            };
        }
        #endregion

        #region 6. Genetic Algorithm Series - #4 Get population and fitnesses
        public class ChromosomeWrap
        {
            public string Chromosome { get; set; }
            public double Fitness { get; set; }

            public static IEnumerable<ChromosomeWrap> MapPopulationFit(IEnumerable<string> population, Func<string, double> fitness)
            {
                Func<string, double, ChromosomeWrap> concat = (s, d) =>
                {
                    return
                    new ChromosomeWrap()
                    {
                        Chromosome = s,
                        Fitness = d
                    };
                };

                return population.Select(x => concat(x, fitness(x)));
            }
            // another similar way
            public static IEnumerable<ChromosomeWrap> MapPopulationFitShorter(IEnumerable<string> population, Func<string, double> fitness)
            {
                return population.Select(x => new ChromosomeWrap() { Chromosome = x, Fitness = fitness(x) });
            }
        }
        #endregion

        #region 7. Genetic Algorithm Series - #5 Roulette wheel selection
        public static string Select(IEnumerable<string> population, IEnumerable<double> fitnesses)
        {
            var sum = fitnesses.Sum();
            var popularity = 0.0;
            var ran = new Random().NextDouble(); // this is the wheel that rotate and give me a number when it ends
            var i = 0;

            while (i++ < population.Count())
            {
                popularity += Convert.ToDouble(fitnesses.ElementAt(i)) / sum;

                if (ran <= popularity)
                    break;
            }
            return population.ElementAt(i);
        }

        // another way
        public static string SelectEasy(IEnumerable<string> population, IEnumerable<double> fitnesses)
        {
            var target = new Random().NextDouble();
            return population.ElementAt(fitnesses.TakeWhile(f => target - f > 0).Count());
        }

        #endregion

        #region 8. Array.diff
        public static int[] ArrayDiff(int[] a, int[] b)
        {
            return a.Where(x => !b.Contains(x)).ToArray();
        }
        #endregion

        #region 9. Integer Difference
        public static int IntDiff(int[] arr, int n)
        {
            if (arr == null || arr.Length < 2) return 0;

            int count = 0;

            Array.Sort(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] - arr[i] == n)
                        count++;
                }
            }
            return count;
        }
        // shorter
        public static int IntDiffShorther(int[] arr, int n)
        {
            if (arr == null || arr.Length < 2) return 0;

            return Enumerable.Range(0, arr.Length - 1)
                             .Sum(i => arr.Zip(arr.Skip(i + 1), (x, y) => Math.Abs(x - y) == n ? 1 : 0)
                             .Sum());
        }
        #endregion

        #region 10. Difference of 2
        public static (int, int)[] TwosDifference(int[] array)
        {
            var list = new List<(int, int)>();
            int arraySize = array.Length;
            const int DIFFERENCE = 2;

            Array.Sort(array);

            for (int i = 0; i < arraySize - 1; i++)
            {
                for (int j = i + 1; j < arraySize; j++)
                {
                    int iElement = array[i];
                    int jElement = array[j];

                    if ((jElement - iElement) == DIFFERENCE)
                        list.Add((iElement, jElement));
                }
            }

            return list.ToArray();
        }

        // best practise
        public static (int, int)[] TwosDifferenceCleaver(int[] array) => array.OrderBy(x => x)
                                                                              .Where(x => array.Contains(x + 2))
                                                                              .Select(x => (x, x + 2))
                                                                              .ToArray();

        #endregion

        #region 11. Not very secure
        public static bool Alphanumeric(string str) => Regex.IsMatch(str, @"^[a-zA-Z0-9]+$");
        #endregion

        #region 12. Number Zoo Patrol
        public static int FindNumber(int[] numberZoo)
        {
            var allNumberZoo = Enumerable.Range(1, numberZoo.Length + 1).ToArray();
            var notFind = true;
            var i = 0;
            var result = 0;

            Array.Sort(numberZoo);

            while (notFind && i < allNumberZoo.Length)
            {
                if (i >= numberZoo.Length)
                {
                    notFind = false;
                    result = allNumberZoo[i];
                }
                else if (numberZoo[i] != allNumberZoo[i])
                {
                    notFind = false;
                    result = allNumberZoo[i];
                }

                i++;
            }

            return result;
        }

        public static int FindNumber_01(int[] array)
        {
            var allNumberZoo = Enumerable.Range(1, array.Length + 1).ToArray();
            var result = 0;

            for (int i = 0; i < allNumberZoo.Length; i++)
            {
                if (!array.Contains(allNumberZoo[i]))
                {
                    result = allNumberZoo[i];
                    break;
                }
            }

            return result;
        }

        // too short. BOOOOMMMMM...!
        public static int FindNumber_02(int[] array) => Enumerable.Range(1, array.Length + 1).Except(array).First();
        #endregion

        #region 13. Reversing a Process
        public static string Decode(string r)
        {
            var num = Convert.ToInt32(Regex.Match(r, @"\d+").Value);
            var rs = r.Replace(num.ToString(), "");
            var s = "";

            if (Enumerable.Range(0, 26).Select(x => x * num % 26).Distinct().Count() < 26)
                return "Impossible to decode";

            for (int i = 0; i < rs.Length; i++)
            {
                var notFind = true;
                var letter = rs[i] - 'a';
                var j = 0;

                while (j < 26 && notFind)
                {
                    var n = j * num % 26;

                    if (n == letter)
                    {
                        s += Convert.ToChar(j + 'a');
                        notFind = false;
                    }
                    else
                    {
                        j++;
                    }
                }
            }

            return s;
        }

        #endregion

        #region 14. Delete occurrences of an element if it occurs more than n times
        public static int[] DeleteNth(int[] arr, int x)
        {
            //[1,2,3,1,2,1,2,3], 2 => [1,2,3,1,2,3]
            var result = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (result.Count(y => y == arr[i]) >= x)
                    continue;

                result.Add(arr[i]);
            }

            return result.ToArray();
        }

        public static int[] DeleteNth_01(int[] arr, int x) => arr.Where((t, i) => arr.Take(i + 1).Count(s => s == t) <= x).ToArray();
        #endregion

        #region 15. Lazy Repeater
        public static Func<char> MakeLooper(string str)
        {
            var i = str.Length;

            Func<char> abc = () =>
            {
                var s = str;

                i = (i < s.Length - 1) ? i + 1 : 0;

                return s[i];
            };

            return abc;
        }

        // shorter
        public static Func<char> MakeLooperS(string str)
        {
            int i = -1;

            return () => str[++i % str.Length];
        }
        #endregion

        #region 16. Greed is Good
        public static int Score(int[] dice)
        {
            var num = 0;

            for (int i = 1; i <= 6; i++)
            {
                var t = dice.Select(x => x).Where(x => x == i).Count();

                if (t >= 3 && (i == 1 || i == 5))
                {
                    num += (i == 1) ? i * 1000 : i * 100;
                    num += (i == 1) ? i * 100 * (t - 3) : i * 10 * (t - 3);
                }
                else if (t >= 3 && (i == 2 || i == 3 || i == 4 || i == 6))
                {
                    num += i * 100;
                }
                else if (i == 1 || i == 5)
                {
                    num += (i == 1) ? i * 100 * t : i * 10 * t;
                }
            }
            return num;
        }

        // shorter
        public static int ScoreS(int[] dice)
        {
            var tripleValue = new int[] { 0, 1000, 200, 300, 400, 500, 600 };
            var singleValue = new int[] { 0, 100, 0, 0, 0, 50, 0 };
            var tot = 0;

            for (int i = 1; i <= 6; i++)
            {
                var countElement = dice.Where(x => x == i).Count();

                tot += tripleValue[i] * (countElement / 3) + singleValue[i] * (countElement % 3);
            }

            return tot;
        }
        #endregion

        #region 17. Josephus Permutation
        //private static List<object> killed = new List<object>();
        //private static int i = 0;
        public static List<object> JosephusProblem(List<object> items, int k)
        {
            var n = items.Count;
            var i = 0;
            var killed = new List<object>();

            while (n > 0)
            {
                i += k - 1;

                while (i >= n)
                    i = i - n;

                killed.Add(items[i]);
                items.RemoveAt(i);

                n = items.Count;
            }

            return killed;
        }

        public static List<object> JosephusProblemS(List<object> items, int k)
        {
            var i = 0;
            var killed = new List<object>();

            while (items.Count > 0)
            {
                i = (i + k - 1) % items.Count;

                killed.Add(items[i]);
                items.RemoveAt(i);
            }

            return killed;
        }

        // link: https://www.geeksforgeeks.org/josephus-problem-set-1-a-on-solution/
        static int josephus(int n, int k)
        {
            if (n == 1)
                return 1;
            else
                /* The position returned  
                by josephus(n - 1, k) is 
                adjusted because the 
                recursive call josephus(n 
                - 1, k) considers the  
                original position k%n + 1 
                as position 1 */
                return (josephus(n - 1, k)
                           + k - 1) % n + 1;
        }
        #endregion

        #region 18. Does my number look big in this?
        public static bool Narcissistic(int value)
        {
            return value.ToString().Select(x => Math.Pow(Convert.ToInt32(x) - '0', value.ToString().Length)).Sum() == value;
        }

        // interesting
        public static bool NarcissisticWoW(int value)
        {
            var list = value.ToString().Select(x => int.Parse(x.ToString())).ToList();
            double tot = 0;

            list.ForEach(x =>
            {
                tot += Math.Pow(x, list.Count);
            });

            return tot == value;
        }
        #endregion

        #region 19. String Letter Counting
        public static string StringLetterCount(string str)
        {
            str = str.ToLower();

            var distinctChar = str.Where(x => new Regex(@"[a-zA-Z]").IsMatch(x.ToString())).Distinct().ToArray();
            var result = "";

            Array.Sort(distinctChar);

            foreach (var v in distinctChar)
                result += String.Concat(str.Where(x => x == v).Count(), v);

            return result;
        }

        // best
        public static string StringLetterCountS(string str) => String.Concat(str
                                                                                .Where(char.IsLetter)
                                                                                .GroupBy(char.ToLowerInvariant)
                                                                                .OrderBy(x => x.Key)
                                                                                .Select(x => $"{x.Count()}{x.Key}"));
        public static string StringDigitCount(string str) => String.Concat(str
                                                                                .Where(char.IsDigit)
                                                                                .GroupBy(x => x)
                                                                                .OrderBy(x => x.Key)
                                                                                .Select(x => $"{x.Count()}{x.Key}"));
        #endregion

        #region 20. Play with two Strings
        public static Func<string, string, string> swap = (str1, str2) =>
        {
            var result = "";

            for (int i = 0; i < str1.Length; i++)
            {
                var el = str1[i];
                var count = 0;

                for (int j = 0; j < str2.Length; j++)
                {
                    if (char.ToLower(el) == char.ToLower(str2[j]))
                        count++;
                }

                if (count % 2 == 1 && char.IsUpper(el))
                    result += char.ToLower(el);
                else if (count % 2 == 1 && char.IsLower(el))
                    result += char.ToUpper(el);
                else
                    result += el;
            }

            return result;
        };

        public static string workOnStrings(string a, string b) => String.Concat(swap(a, b), swap(b, a));
        #endregion

        #region 21. Encrypt this!
        public static string EncryptThis(string input)
        {
            // Implement me! :)
            if (string.IsNullOrEmpty(input))
                return "";

            string encryptedText = "";

            foreach (var word in input.Split(' '))
            {
                if (string.IsNullOrEmpty(word))
                    continue;

                encryptedText += string.IsNullOrEmpty(encryptedText) ? "" : " ";

                int length = word.Length;
                int firstCharacterASCIICode = (int)word[0];

                encryptedText += firstCharacterASCIICode.ToString();

                if (length > 2)
                    encryptedText += word[length - 1];

                if (length > 3)
                    encryptedText += word.Substring(2, length - 3);

                if (length > 1)
                    encryptedText += word[1];
            }
            return encryptedText;
        }

        public static string EncryptThisAnotherVersion(string input) => string.Join(" ", input.Split(' ').Select(Encrypt));
        private static string Encrypt(string s)
        {
            int length = s.Length;

            if (string.IsNullOrEmpty(s))
                return "";
            else if (length == 1)
                return $"{(int)s[0]}";
            else if (length == 2)
                return $"{(int)s[0]}{s[1]}";
            else
                return $"{(int)s[0]}{s[length - 1]}{s.Substring(2, length - 3)}{s[1]}";
        }
        #endregion

        #region 22. Text align justify
        private static List<string> GetTheLines(string str, int len)
        {
            string line = "";
            var linesStr = new List<string>();
            var splittedWord = str.Split(' ');

            for (int i = 0; i < splittedWord.Length; i++)
            {
                string word = splittedWord[i];
                string tmpLine = string.Concat(line, ' ', word).Trim();

                if (i == splittedWord.Length - 1)
                {
                    linesStr.Add(tmpLine);
                }
                if (tmpLine.Length > len)
                {
                    linesStr.Add(line);
                    line = word;
                }
                else
                {
                    line = tmpLine;
                }
            }
            return linesStr;
        }
        public static string Justify(string str, int len)
        {
            return "";
        }
        #endregion

        #region 23. Address Book by State
        public static string ByState(string str)
        {
            var states = new Dictionary<string, string>()
                {
                    { "AZ", "Arizona" },
                    { "CA", "California" },
                    { "ID", "Idaho" },
                    { "IN", "Indiana" },
                    { "MA", "Massachusetts" },
                    { "OK", "Oklahoma" },
                    { "PA", "Pennsylvania" },
                    { "VA", "Virginia" }
                };
            string lastKey = "";
            var newAddressBook = new List<string>();
            var splittedString = str.Replace(",", "").Split('\n').OrderBy(x => x).OrderBy(x => x.Substring(x.Length - 2)).ToList();

            foreach (var line in splittedString)
            {
                string newAddress = "";

                foreach (var state in states)
                {
                    if (line.Contains(state.Key))
                    {
                        if (lastKey != state.Key)
                        {
                            newAddress = (newAddressBook.Count() == 0) ?
                                         string.Concat(state.Value, "\n..... ", line.Replace(state.Key, state.Value)) :
                                         string.Concat(" ", state.Value, "\n..... ", line.Replace(state.Key, state.Value));
                            lastKey = state.Key;
                        }
                        else
                        {
                            newAddress = string.Concat("..... ", line.Replace(state.Key, state.Value));
                        }
                        break;
                    }
                }
                newAddressBook.Add(newAddress);
            }

            return string.Join("\n", newAddressBook);
        }
        #endregion

        #region 24. A Rule of Divisibility by 13
        // my version
        private static int[] ModThirteen(long n)
        {
            int nSize = n.ToString().Length;
            var modThirteen = new int[nSize];
            const int divider = 13;

            for (int i = 0; i < nSize; i++)
                modThirteen[i] = (int)Math.Pow(10, i) % divider;

            return modThirteen;
        }

        private static int[] ReverseLongN(long n)
        {
            int nSize = n.ToString().Length;
            var newN = new int[nSize];

            nSize--;

            foreach (var num in n.ToString())
            {
                newN[nSize] = num - 48;
                nSize--;
            }

            return newN;
        }

        public static long Thirt(long n)
        {
            if (n < 0)
                return n;

            var modThirteen = ModThirteen(n);
            var reverseN = ReverseLongN(n);
            long result = 0;

            for (int i = 0; i < n.ToString().Length; i++)
                result += reverseN[i] * modThirteen[i];

            if (n == result)
                return n;

            return Thirt(result);
        }

        // seprum version
        public static long ThirtSeprum(long n)
        {
            int[] remainders = { 1, 10, 9, 12, 3, 4 };
            int sum = 0;
            for (int r = 0; n > 0; r++)
            {
                if (r == remainders.Length) r = 0;
                sum += (int)(n % 10 * remainders[r]);
                n /= 10;
            }
            if (sum > 99) return Thirt(sum);
            return sum;
        }

        #endregion

        #region Curiosity
        // 1. recursion
        public static int SumArray(int[] array, int position)
        {
            if (position <= 0)
                return 0;

            return SumArray(array, position - 1) + array[position - 1];
        }

        // 2. recursion
        public static int CalculateSumRecursively(int n, int m)
        {
            int sum = n;

            if (n < m)
            {
                n++;
                return sum += CalculateSumRecursively(n, m);
            }

            return sum;
        }
        #endregion
    }
}
