using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Services.Interfaces;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.Services.Providers
{
    public class CodeChefServices : ICodeChefServices
    {
        public int GetCodeChefLearnProblems()
        {
            return InvokeDelegateHelper.InvokeDelegateIfNotNull(codeChefLearn);
        }

        public int GetCodeChefBeginnerProblems()
        {
            return InvokeDelegateHelper.InvokeDelegateIfNotNull(codeChefBeginner);
        }

        // Delegates
        private static readonly Delegate[] codeChefLearn = new Delegate[]
        {
            StringOperationsFunc, IndexingFunc, AccessingcharactersofaStringFunc, StringOperationsSTRS7Func, EnormousInputTestFunc, GoodTurnFunc, AddTwoNumbersCCFunc, UserInputUsrs1Func, USRS2IntegerInputFunc, HelloUserFunc, MultipleoutputsusingasinglelineFunc,
            CalculatorFunc, MiletoKilometerConvertorFunc, CSB001IntroductionFunc, CSB002IntroductionFunc, CSB003IntroductionFunc, CSB004ArithmeticOperationsFunc, CSB007MultipleOutputsFunc, CSB008OutputsInSeperateLinesFunc, CSB009AreaPerimeterofRectangleFunc,
            InsertingspacebetweenoutputsFunc, InsertingtextBetweenOutputsFunc, MultiplicationFunc, DivisionFunc, SyntaxFunc, StoringBoxesFunc, DeclaringavariableFunc, AdditionofVariablesFunc, AreaofRectangleFunc, DoubledatatypeFunc, StringDatatypeFunc,
        };

        private static readonly Delegate[] codeChefBeginner = new Delegate[]
        {
            AgeLimitFunc, NumberMirrorFunc, RichieRichFunc, VaccineDatesFunc, HoopJumpFunc, TheTwoDishesFunc, MotivationFunc, TwoDishesFunc, CricketWorldCupQualifierFunc, LuckySevenFunc,
        };

        // Functions 

        private static void LuckySevenFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Lucky Seven");
            ResultTester.CheckSolution(ProblemOrigin.CodeChef, CodeChef.LuckySeven.Test.TestCases());
        }

        private static void CricketWorldCupQualifierFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Cricket World Cup Qualifier");
            ResultTester.CheckSolution(ProblemOrigin.CodeChef, CodeChef.CricketWorldCupQualifier.Test.TestCases());
        }

        private static void StringOperationsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("String Operations");
            ResultTester.CheckSolution(ProblemOrigin.CodeChef, CodeChef.StringOperations.Test.TestStringOperations());
        }

        private static void StringOperationsSTRS7Func()
        {
            StyleHelper.Space();
            StyleHelper.Title("String Operations 7");
            ResultTester.CheckSolution(ProblemOrigin.CodeChef, CodeChef.StringOperationsStrs7.Test.TestStringOperationsStrs7());
        }

        private static void AgeLimitFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Age Limit");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeChef);
        }

        private static void TwoDishesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Two Dishes");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeChef);
        }

        private static void NumberMirrorFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Number Mirror");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeChef);
        }

        private static void EnormousInputTestFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Enormous Input Test");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeChef);
        }

        private static void GoodTurnFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Good Turn");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeChef);
        }

        private static void AccessingcharactersofaStringFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Accessing characters of a String");
            ResultTester.CheckSolution(ProblemOrigin.CodeChef, CodeChef.AccessingcharactersofaString.Test.TestAccessingcharactersofaString());
        }

        private static void IndexingFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Indexing");
            ResultTester.CheckSolution(ProblemOrigin.CodeChef, CodeChef.Indexing.Test.TestIndexing());
        }

        private static void UserInputUsrs1Func()
        {
            StyleHelper.Space();
            StyleHelper.Title("User Input USRS 1");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeChef);
        }

        private static void AddTwoNumbersCCFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Add Two Numbers (CodeChef)");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeChef);
        }

        private static void USRS2IntegerInputFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("USRS2 Integer Input");
            ResultTester.CheckSolution(ProblemOrigin.CodeChef, CodeChef.USRS2IntegerInput.Test.TestCases());
        }

        private static void HelloUserFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Hello User");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeChef);
        }

        private static void MultipleoutputsusingasinglelineFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Multiple outputs using a single line");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeChef);
        }

        private static void InsertingspacebetweenoutputsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Inserting space between outputs");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeChef);
        }

        private static void InsertingtextBetweenOutputsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Inserting text Between Outputs");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeChef);
        }

        private static void MultiplicationFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Multiplication");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeChef);
        }

        private static void DivisionFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Division");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeChef);
        }

        private static void SyntaxFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Syntax");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeChef);
        }

        private static void StoringBoxesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Storing Boxes");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeChef);
        }

        private static void DeclaringavariableFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Declaring a variable");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeChef);
        }

        private static void AdditionofVariablesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Addition of Variables");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeChef);
        }

        private static void AreaofRectangleFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Area of Rectangle");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeChef);
        }

        private static void DoubledatatypeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Double data type");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeChef);
        }

        private static void StringDatatypeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("String Data type");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeChef);
        }

        private static void CalculatorFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Calculator");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeChef);
        }

        private static void MiletoKilometerConvertorFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Mile to Kilometer Convertor");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeChef);
        }

        private static void CSB001IntroductionFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("CSB001 Introduction");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeChef);
        }

        private static void CSB002IntroductionFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("CSB002 Introduction");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeChef);
        }

        private static void CSB003IntroductionFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("CSB003 Introduction");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeChef);
        }

        private static void CSB004ArithmeticOperationsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("CSB004 Arithmetic Operations");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeChef);
        }

        private static void CSB007MultipleOutputsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("CSB007 Multiple Outputs");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeChef);
        }

        private static void CSB008OutputsInSeperateLinesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("CSB008 Outputs In Seperate Lines");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeChef);
        }

        private static void CSB009AreaPerimeterofRectangleFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("CSB009 Area & Perimeter of Rectangle");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeChef);
        }

        private static void RichieRichFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Richie Rich");
            ResultTester.CheckSolution(ProblemOrigin.CodeChef, CodeChef.RichieRich.Test.TestCases());
        }

        private static void VaccineDatesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Vaccine Dates");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeChef);
        }

        private static void HoopJumpFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Hoop Jump");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeChef);
        }

        private static void TheTwoDishesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("The Two Dishes");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeChef);
        }

        private static void MotivationFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Motivation");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeChef);
        }
    }
}