namespace CompetitiveProgramming.Algorithms
{
    public class Logic
    {
        public static bool Negation(bool a) => !a;
        public static bool Conjunction(bool a, bool b) => a && b;
        public static bool Disjunction(bool a, bool b) => a || b;
        public static bool Implication(bool a, bool b) => !a || b;
        public static bool Equivalence(bool a, bool b) => (a && b) || (!a && !b);
    }
}