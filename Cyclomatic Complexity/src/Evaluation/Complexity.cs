namespace Evaluation
{
    /// <summary>
    /// This class expose multiple methods to evaluate their complexity.
    /// <remarks>
    /// The results are obtained by :
    ///  - ReSharper "CyclomaticComplexity" extension       => cyclomatic complexity
    ///  - ReSharper "CognitiveComplexity" extension        => cognitive complexity
    ///  - Visual Studio "CodeMaid" extension               => cyclomatic complexity
    ///  - Visual Studio "Code Maintainability" extension   => maintainability index, cyclomatic complexity, [Halstead volume], [lines of code]
    /// </remarks>>
    /// </summary>
    public static class Complexity
    {
        /// <summary>
        /// The obtained results are:
        ///  - Cyclomatic complexity    = 6
        ///  - Cognitive complexity     = 2
        ///  - Maintainability index    = 83
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static string Good(int number)
        {
            if (number <= 0)
                return string.Empty;

            switch (number)
            {
                case 1:
                    return "one";
                case 2:
                    return "a couple";
                case 3:
                    return "a few";
                default:
                    return "lots";
            }
        }

        /// <summary>
        /// The obtained results are:
        ///  - Cyclomatic complexity    = 4
        ///  - Cognitive complexity     = 7
        ///  - Maintainability index    = 67
        /// </summary>
        /// <param name="max"></param>
        /// <returns></returns>
        public static int QuiteGood(int max)
        {
            int total = 0;

            for (int i = 1; i <= max; i++)
            {
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        goto OUT;
                    }
                }

                total += i;

            OUT:
                ;
            }

            return total;
        }

        /// <summary>
        /// The obtained results are:
        ///  - Cyclomatic complexity    = 21
        ///  - Cognitive complexity     = 66
        ///  - Maintainability index    = 48
        /// </summary>
        /// <param name="max"></param>
        /// <returns></returns>
        public static int Bad(int max)
        {
            int total = 0;
            if (max < 0)
                return 0;

            if (max < 20)
            {
                for (int i = 1; i <= max; i++)
                {
                    for (int j = 2; j < max / 2; j++)
                    {
                        for (int k = 2; k < j; k++)
                        {
                            if (j % k == 0)
                            {
                                break;
                            }
                        }
                    }

                    total += i;
                }
            }
            else
            {
                if (max < 30)
                {
                    if (max < 28)
                    {
                        for (int i = 1; i <= max; i++)
                        {
                            for (int j = 2; j < max / 2; j++)
                            {
                                if (i % j == 0)
                                {
                                    total += i;
                                }
                            }
                        }

                        if (max < 25)
                        {
                            for (int i = 1; i <= max; i++)
                            {
                                for (int j = 2; j < max / 2; j++)
                                {
                                    if (i % j == 0)
                                    {
                                        total += i;
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        for (int i = 1; i <= max; i++)
                        {
                            for (int j = 2; j < max / 2; j++)
                            {
                                if (i % j == 0)
                                {
                                    total += i;
                                }
                            }
                        }
                    }
                }
            }

            return total;
        }
    }
}
