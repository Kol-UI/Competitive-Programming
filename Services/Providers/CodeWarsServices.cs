using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Services.Interfaces;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.Services.Providers
{
    public class CodeWarsServices : ICodeWarsServices
    {
        public int GetCodeWarsEightKyuProblems()
        {
            return InvokeDelegateHelper.InvokeDelegateIfNotNull(codeWarsEightKyuList);
        }

        public int GetCodeWarsSevenKyuProblems()
        {
            return InvokeDelegateHelper.InvokeDelegateIfNotNull(codeWarsSevenKyuList);
        }

        public int GetCodeWarsSixKyuProblems()
        {
            return InvokeDelegateHelper.InvokeDelegateIfNotNull(codeWarsSixKyuList);
        }

        // Delegates
        private static readonly Delegate[] codeWarsEightKyuList = new Delegate[]
        {
            GrasshopperSummationFunc, SumArrayFunc, RemoveFirstandLastCharacterFunc, ReturnNegativeFunc, RemoveExclamationMarksFunc, BeginnerLostWithoutaMapFunc, AreYouPlayingBanjoFunc,
            FindMinAndMaxOfListFunc, StringRepeatFunc, SumOfPositiveFunc, ConvertbooleanvaluestostringsYesorNoFunc, ConvertaNumbertoaStringFunc, ANeedleintheHaystackFunc, InvertValuesFunc,
            EvenOrOddFunc, SquareNSumFunc, FindthesmallestintegerinthearrayFunc, RemoveStringSpacesFunc, CountingsheepFunc, ConvertaStringtoaNumberFunc, MakeUpperCaseFunc, CalculateaverageFunc,
            BeginnerSeries2ClockFunc, OppositesAttractFunc, SquaringAnArgumentFunc, ReturningStringsFunc, ReturnToSanityFunc, ReturnHelloWorldFunc, BeginnerSeries1SchoolPaperworkFunc,
            YouCantCodeUnderPressure1Func, CenturyFromYearFunc, BasicMathematicalOperationsFunc, ConvertNumberToReversedArrayOfDigitsFunc, AbbreviateaTwoWordNameFunc, SimplemultiplicationFunc,
            IshegonnasurviveFunc, FakeBinaryFunc, CountofpositivesSumofnegativesFunc, BeginnerReducebutGrowFunc, HowgoodareyoureallyFunc,
        };

        private static readonly Delegate[] codeWarsSevenKyuList = new Delegate[]
        {
            ItIsIsogramFunc,
        };

        private static readonly Delegate[] codeWarsSixKyuList = new Delegate[]
        {
            ReplaceWithAlphabetPositionFunc,
        };

        // Functions 

        private static void HowgoodareyoureallyFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("How good are you really");
            ResultTester.CheckSolution(ProblemOrigin.CodeWars, CodeWars.EightKyu.Howgoodareyoureally.Test.TestCases());
        }

        private static void BeginnerReducebutGrowFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Beginner - Reduce but Grow");
            ResultTester.CheckSolution(ProblemOrigin.CodeWars, CodeWars.EightKyu.BeginnerReducebutGrow.Test.TestCases());
        }

        private static void CountofpositivesSumofnegativesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Count of positives Sum of negatives");
            ResultTester.CheckSolution(ProblemOrigin.CodeWars, CodeWars.EightKyu.CountofpositivesSumofnegatives.Test.TestCases());
        }

        private static void SquaringAnArgumentFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Squaring An Argument");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeWars);
        }

        private static void ReturningStringsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Returning Strings");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeWars);
        }

        private static void ReturnToSanityFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Return To Sanity");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeWars);
        }

        private static void ReturnHelloWorldFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Return Hello World");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeWars);
        }
        private static void CalculateaverageFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Calculate average");
            ResultTester.CheckSolution(ProblemOrigin.CodeWars, CodeWars.EightKyu.Calculateaverage.Test.TestCases());
        }

        private static void InvertValuesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Invert Values");
            ResultTester.CheckSolution(ProblemOrigin.CodeWars, CodeWars.EightKyu.InvertValues.Test.TestCases());
        }

        private static void AreYouPlayingBanjoFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Are You Playing Banjo");
            ResultTester.CheckSolution(ProblemOrigin.CodeWars, CodeWars.EightKyu.AreYouPlayingBanjo.Test.TestCases());
        }

        private static void MakeUpperCaseFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Make Upper Case");
            ResultTester.CheckSolution(ProblemOrigin.CodeWars, CodeWars.EightKyu.MakeUpperCase.Test.TestCases());
        }

        private static void SimplemultiplicationFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Simple multiplication");
            ResultTester.CheckSolution(ProblemOrigin.CodeWars, CodeWars.EightKyu.Simplemultiplication.Test.TestCases());
        }

        private static void BeginnerSeries1SchoolPaperworkFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Beginner Series #1 School Paperwork");
            ResultTester.CheckSolution(ProblemOrigin.CodeWars, CodeWars.EightKyu.BeginnerSeries1SchoolPaperwork.Test.TestCases());
        }

        private static void AbbreviateaTwoWordNameFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Abbreviate a Two Word Name");
            ResultTester.CheckSolution(ProblemOrigin.CodeWars, CodeWars.EightKyu.AbbreviateaTwoWordName.Solution.TestAbbreviateaTwoWordName());
        }

        private static void BeginnerSeries2ClockFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Beginner Series #2 Clock");
            ResultTester.CheckSolution(ProblemOrigin.CodeWars, CodeWars.EightKyu.BeginnerSeries2Clock.Solution.TestBeginnerSeries2Clock());
        }

        private static void ConvertNumberToReversedArrayOfDigitsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Convert number to reversed array of digits");
            ResultTester.CheckSolution(ProblemOrigin.CodeWars, CodeWars.EightKyu.ConvertNumberToReversedArrayOfDigits.Test.TestConvertNumberToReversedArrayOfDigits());
        }

        private static void BeginnerLostWithoutaMapFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Beginner - Lost Without a Map");
            ResultTester.CheckSolution(ProblemOrigin.CodeWars, CodeWars.EightKyu.BeginnerLostWithoutaMap.Test.TestBeginnerLostWithoutaMap());
        }

        private static void CenturyFromYearFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Century From Year");
            ResultTester.CheckSolution(ProblemOrigin.CodeWars, CodeWars.EightKyu.CenturyFromYear.Test.TestCenturyFromYear());
        }

        private static void BasicMathematicalOperationsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Basic Mathematical Operations");
            ResultTester.CheckSolution(ProblemOrigin.CodeWars, CodeWars.EightKyu.BasicMathematicalOperations.Test.TestBasicMathematicalOperations());
        }

        private static void YouCantCodeUnderPressure1Func()
        {
            StyleHelper.Space();
            StyleHelper.Title("You Can't Code Under Pressure #1");
            ResultTester.CheckSolution(ProblemOrigin.CodeWars, CodeWars.EightKyu.YouCantCodeUnderPressure1.Test.TestYouCantCodeUnderPressure1());
        }

        private static void RemoveStringSpacesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Remove String Spaces");
            ResultTester.CheckSolution(ProblemOrigin.CodeWars, CodeWars.EightKyu.RemoveStringSpaces.Test.TestRemoveStringSpaces());       
        }
        
        private static void CountingsheepFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Counting Sheep");
            ResultTester.CheckSolution(ProblemOrigin.CodeWars, CodeWars.EightKyu.Countingsheep.Test.TestCountingsheep());       
        }

        private static void ConvertaStringtoaNumberFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Convert a String to a Number");
            ResultTester.CheckSolution(ProblemOrigin.CodeWars, CodeWars.EightKyu.ConvertaStringtoaNumber.Test.TestConvertaStringtoaNumber());       
        }

        private static void ANeedleintheHaystackFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("A Needle in the Haystack");
            ResultTester.CheckSolution(ProblemOrigin.CodeWars, CodeWars.EightKyu.ANeedleintheHaystack.Test.TestCases());
        }

        private static void SquareNSumFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Square(n) Sum");
            ResultTester.CheckSolution(ProblemOrigin.CodeWars, CodeWars.EightKyu.SquareNSum.Test.TestStringrepeat());
        }

        private static void FindthesmallestintegerinthearrayFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find the smallest integer in the array");
            ResultTester.CheckSolution(ProblemOrigin.CodeWars, CodeWars.EightKyu.Findthesmallestintegerinthearray.Test.TestFindthesmallestintegerinthearray());
        }

        private static void IshegonnasurviveFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Is he gonna survive");
            ResultTester.CheckSolution(ProblemOrigin.CodeWars, CodeWars.EightKyu.Ishegonnasurvive.Test.TestCases());
        }

        private static void OppositesAttractFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("OppositesAttract");
            ResultTester.CheckSolution(ProblemOrigin.CodeWars, CodeWars.EightKyu.OppositesAttract.Test.TestOppositesAttract());
        }

        private static void ConvertbooleanvaluestostringsYesorNoFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Convert boolean values to strings Yes or No");
            ResultTester.CheckSolution(ProblemOrigin.CodeWars, CodeWars.EightKyu.ConvertbooleanvaluestostringsYesorNo.Test.TestConvertbooleanvaluestostringsYesorNo());  
        }

        private static void SumOfPositiveFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Sum Of Positive");
            ResultTester.CheckSolution(ProblemOrigin.CodeWars, CodeWars.EightKyu.Sumofpositive.Test.TestYouCantCodeUnderPressure1());
        }

        private static void StringRepeatFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("String Repeat");
            ResultTester.CheckSolution(ProblemOrigin.CodeWars, CodeWars.EightKyu.Stringrepeat.Test.TestStringrepeat());
        }

        private static void FindMinAndMaxOfListFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find Min And Max Of List");
            ResultTester.CheckSolution(ProblemOrigin.CodeWars, CodeWars.EightKyu.FindMaximumandMinimumValuesofaList.Test.TestFindMaximumandMinimumValuesofaList());
        }

        private static void RemoveExclamationMarksFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Remove Exclamation Marks");
            ResultTester.CheckSolution(ProblemOrigin.CodeWars, CodeWars.EightKyu.RemoveExclamationMarks.Test.TestRemoveExclamationMarks());
        }

        private static void ReturnNegativeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Return Negative");
            ResultTester.CheckSolution(ProblemOrigin.CodeWars, CodeWars.EightKyu.ReturnNegative.Test.TestReturnNegative());
        }

        private static void ConvertaNumbertoaStringFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Convert a Number to a String");
            ResultTester.CheckSolution(ProblemOrigin.CodeWars, CodeWars.EightKyu.ConvertaNumbertoaString.Test.TestConvertaNumbertoaString());
        }

        private static void EvenOrOddFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Even or Odd");
            ResultTester.CheckSolution(ProblemOrigin.CodeWars, CodeWars.EightKyu.EvenorOdd.Test.TestEvenorOdd());
        }

        private static void RemoveFirstandLastCharacterFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Remove First and Last Character");
            ResultTester.CheckSolution(ProblemOrigin.CodeWars, CodeWars.EightKyu.RemoveFirstandLastCharacter.Test.TestRemoveFirstandLastCharacter());
        }

        private static void ItIsIsogramFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("It is an Isogram");
            ResultTester.CheckSolution(ProblemOrigin.CodeWars, CodeWars.SevenKyu.Isograms.Test.TestIsograms());
        }

        private static void SumArrayFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Sum Array");
            ResultTester.CheckSolution(ProblemOrigin.CodeWars, CodeWars.EightKyu.SumArray.Test.TestSumArray());
        }

        private static void ReplaceWithAlphabetPositionFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Replace With Alphabet Position");
            ResultTester.CheckSolution(ProblemOrigin.CodeWars, CodeWars.SixKyu.ReplaceWithAlphabetPosition.Test.TestReplaceWithAlphabetPosition());
        }

        private static void FakeBinaryFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Fake Binary");
            ResultTester.CheckSolution(ProblemOrigin.CodeWars, CodeWars.EightKyu.FakeBinary.Test.TestCases());
        }

        private static void GrasshopperSummationFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Grasshopper Summation");
            ResultTester.CheckSolution(ProblemOrigin.CodeWars, CodeWars.EightKyu.GrasshopperSummation.Test.TestGrasshopperSummation());
        }
    }
}
