// Word Capitalization

/*
Capitalization is writing a word with its first letter as a capital letter. Your task is to capitalize the given word.

Note, that during capitalization all the letters except the first one remains unchanged.
*/


using System;
using CompetitiveProgramming;
using CompetitiveProgramming.AtCoder.ADisjointSetUnion;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.CodeForces.WordCapitalization
{
    // Solution
    /*
    class Program
    {
        static void Main()
        {
            string word = Console.ReadLine()!;
            string capitalizedWord = CapitalizeWord(word);
            Console.WriteLine(capitalizedWord);
        }

        static string CapitalizeWord(string word)
        {
            if (string.IsNullOrEmpty(word))
            {
                return word;
            }

            char[] letters = word.ToCharArray();
            letters[0] = char.ToUpper(letters[0]);
            return new string(letters);
        }
    }
    */

    // Test Solution
    public class Solution
    {
        public static string CapitalizeWord(string word)
        {
            if (string.IsNullOrEmpty(word))
            {
                return word;
            }

            char[] letters = word.ToCharArray();
            letters[0] = char.ToUpper(letters[0]);
            return new string(letters);
        }

        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<string>(Solution.CapitalizeWord("ApPLe"), "ApPLe"),
                ResultTester.CheckResult<string>(Solution.CapitalizeWord("konjac"), "Konjac"),
                ResultTester.CheckResult<string>(Solution.CapitalizeWord("A"), "A"),
                ResultTester.CheckResult<string>(Solution.CapitalizeWord("z"), "Z"),
                ResultTester.CheckResult<string>(Solution.CapitalizeWord("ABACABA"), "ABACABA"),
                ResultTester.CheckResult<string>(Solution.CapitalizeWord("xYaPxPxHxGePfGtQySlNrLxSjDtNnTaRaEpAhPaQpWnDzMqGgRgEwJxGiBdZnMtHxFbObCaGiCeZkUqIgBhHtNvAqAlHpMnQhNeQbMyZrCdElVwHtKrPpJjIaHuIlYwHaRkAkUpPlOhNlBtXwDsKzPyHrPiUwNlXtTaPuMwTqYtJySgFoXvLiHbQwMjSvXsQfKhVlOxGdQkWjBhEyQvBjPoFkThNeRhTuIzFjInJtEfPjOlOsJpJuLgLzFnZmKvFgFrNsOnVqFcNiMfCqTpKnVyLwNqFiTySpWeTdFnWuTwDkRjVxNyQvTrOoEiExYiFaIrLoFmJfZcDkHuWjYfCeEqCvEsZiWnJaEmFbMjDvYwEeJeGcKbVbChGsIzNlExHzHiTlHcSaKxLuZxX"), "XYaPxPxHxGePfGtQySlNrLxSjDtNnTaRaEpAhPaQpWnDzMqGgRgEwJxGiBdZnMtHxFbObCaGiCeZkUqIgBhHtNvAqAlHpMnQhNeQbMyZrCdElVwHtKrPpJjIaHuIlYwHaRkAkUpPlOhNlBtXwDsKzPyHrPiUwNlXtTaPuMwTqYtJySgFoXvLiHbQwMjSvXsQfKhVlOxGdQkWjBhEyQvBjPoFkThNeRhTuIzFjInJtEfPjOlOsJpJuLgLzFnZmKvFgFrNsOnVqFcNiMfCqTpKnVyLwNqFiTySpWeTdFnWuTwDkRjVxNyQvTrOoEiExYiFaIrLoFmJfZcDkHuWjYfCeEqCvEsZiWnJaEmFbMjDvYwEeJeGcKbVbChGsIzNlExHzHiTlHcSaKxLuZxX"),
                ResultTester.CheckResult<string>(Solution.CapitalizeWord("rZhIcQlXpNcPgXrOjTiOlMoTgXgIhCfMwZfWoFzGhEkQlOoMjIuShPlZfWkNnMyQfYdUhVgQuSmYoElEtZpDyHtOxXgCpWbZqSbYnPqBcNqRtPgCnJnAyIvNsAhRbNeVlMwZyRyJnFgIsCnSbOdLvUyIeOzQvRpMoMoHfNhHwKvTcHuYnYySfPmAiNwAiWdZnWlLvGfBbRbRrCrBqIgIdWkWiBsNyYkKdNxZdGaToSsDnXpRaGrKxBpQsCzBdQgZzBkGeHgGxNrIyQlSzWsTmSnZwOcHqQpNcQvJlPvKaPiQaMaYsQjUeCqQdCjPgUbDmWiJmNiXgExLqOcCtSwSePnUxIuZfIfBeWbEiVbXnUsPwWyAiXyRbZgKwOqFfCtQuKxEmVeRlAkOeXkO"), "RZhIcQlXpNcPgXrOjTiOlMoTgXgIhCfMwZfWoFzGhEkQlOoMjIuShPlZfWkNnMyQfYdUhVgQuSmYoElEtZpDyHtOxXgCpWbZqSbYnPqBcNqRtPgCnJnAyIvNsAhRbNeVlMwZyRyJnFgIsCnSbOdLvUyIeOzQvRpMoMoHfNhHwKvTcHuYnYySfPmAiNwAiWdZnWlLvGfBbRbRrCrBqIgIdWkWiBsNyYkKdNxZdGaToSsDnXpRaGrKxBpQsCzBdQgZzBkGeHgGxNrIyQlSzWsTmSnZwOcHqQpNcQvJlPvKaPiQaMaYsQjUeCqQdCjPgUbDmWiJmNiXgExLqOcCtSwSePnUxIuZfIfBeWbEiVbXnUsPwWyAiXyRbZgKwOqFfCtQuKxEmVeRlAkOeXkO"),
                ResultTester.CheckResult<string>(Solution.CapitalizeWord("hDgZlUmLhYbLkLcNcKeOwJwTePbOvLaRvNzQbSbLsPeHqLhUqWtUbNdQfQqFfXeJqJwWuOrFnDdZiPxIkDyVmHbHvXfIlFqSgAcSyWbOlSlRuPhWdEpEzEeLnXwCtWuVcHaUeRgCiYsIvOaIgDnFuDbRnMoCmPrZfLeFpSjQaTfHgZwZvAzDuSeNwSoWuJvLqKqAuUxFaCxFfRcEjEsJpOfCtDiVrBqNsNwPuGoRgPzRpLpYnNyQxKaNnDnYiJrCrVcHlOxPiPcDbEgKfLwBjLhKcNeMgJhJmOiJvPfOaPaEuGqWvRbErKrIpDkEoQnKwJnTlStLyNsHyOjZfKoIjXwUvRrWpSyYhRpQdLqGmErAiNcGqAqIrTeTiMuPmCrEkHdBrLyCxPtYpRqD"), "HDgZlUmLhYbLkLcNcKeOwJwTePbOvLaRvNzQbSbLsPeHqLhUqWtUbNdQfQqFfXeJqJwWuOrFnDdZiPxIkDyVmHbHvXfIlFqSgAcSyWbOlSlRuPhWdEpEzEeLnXwCtWuVcHaUeRgCiYsIvOaIgDnFuDbRnMoCmPrZfLeFpSjQaTfHgZwZvAzDuSeNwSoWuJvLqKqAuUxFaCxFfRcEjEsJpOfCtDiVrBqNsNwPuGoRgPzRpLpYnNyQxKaNnDnYiJrCrVcHlOxPiPcDbEgKfLwBjLhKcNeMgJhJmOiJvPfOaPaEuGqWvRbErKrIpDkEoQnKwJnTlStLyNsHyOjZfKoIjXwUvRrWpSyYhRpQdLqGmErAiNcGqAqIrTeTiMuPmCrEkHdBrLyCxPtYpRqD"),
                ResultTester.CheckResult<string>(Solution.CapitalizeWord("qUdLgGrJeGmIzIeZrCjUtBpYfRvNdXdRpGsThIsEmJjTiMqEwRxBeBaSxEuWrNvExKePjPnXhPzBpWnHiDhTvZhBuIjDnZpTcEkCvRkAcTmMuXhGgErWgFyGyToOyVwYlCuQpTfJkVdWmFyBqQhJjYtXrBbFdHzDlGsFbHmHbFgXgFhIyDhZyEqEiEwNxSeByBwLiVeSnCxIdHbGjOjJrZeVkOzGeMmQrJkVyGhDtCzOlPeAzGrBlWwEnAdUfVaIjNrRyJjCnHkUvFuKuKeKbLzSbEmUcXtVkZzXzKlOrPgQiDmCcCvIyAdBwOeUuLbRmScNcWxIkOkJuIsBxTrIqXhDzLcYdVtPgZdZfAxTmUtByGiTsJkSySjXdJvEwNmSmNoWsChPdAzJrBoW"), "QUdLgGrJeGmIzIeZrCjUtBpYfRvNdXdRpGsThIsEmJjTiMqEwRxBeBaSxEuWrNvExKePjPnXhPzBpWnHiDhTvZhBuIjDnZpTcEkCvRkAcTmMuXhGgErWgFyGyToOyVwYlCuQpTfJkVdWmFyBqQhJjYtXrBbFdHzDlGsFbHmHbFgXgFhIyDhZyEqEiEwNxSeByBwLiVeSnCxIdHbGjOjJrZeVkOzGeMmQrJkVyGhDtCzOlPeAzGrBlWwEnAdUfVaIjNrRyJjCnHkUvFuKuKeKbLzSbEmUcXtVkZzXzKlOrPgQiDmCcCvIyAdBwOeUuLbRmScNcWxIkOkJuIsBxTrIqXhDzLcYdVtPgZdZfAxTmUtByGiTsJkSySjXdJvEwNmSmNoWsChPdAzJrBoW"),
                ResultTester.CheckResult<string>(Solution.CapitalizeWord("kHbApGoBcLmIwUlXkVgUmWzYeLoDbGaOkWbIuXoRwMfKuOoMzAoXrBoTvYxGrMbRjDuRxAbGsTnErIiHnHoLeRnTbFiRfDdOkNlWiAcOsChLdLqFqXlDpDoDtPxXqAmSvYgPvOcCpOlWtOjYwFkGkHuCaHwZcFdOfHjBmIxTeSiHkWjXyFcCtOlSuJsZkDxUgPeZkJwMmNpErUlBcGuMlJwKkWnOzFeFiSiPsEvMmQiCsYeHlLuHoMgBjFoZkXlObDkSoQcVyReTmRsFzRhTuIvCeBqVsQdQyTyZjStGrTyDcEcAgTgMiIcVkLbZbGvWeHtXwEqWkXfTcPyHhHjYwIeVxLyVmHmMkUsGiHmNnQuMsXaFyPpVqNrBhOiWmNkBbQuHvQdOjPjKiZcL"), "KHbApGoBcLmIwUlXkVgUmWzYeLoDbGaOkWbIuXoRwMfKuOoMzAoXrBoTvYxGrMbRjDuRxAbGsTnErIiHnHoLeRnTbFiRfDdOkNlWiAcOsChLdLqFqXlDpDoDtPxXqAmSvYgPvOcCpOlWtOjYwFkGkHuCaHwZcFdOfHjBmIxTeSiHkWjXyFcCtOlSuJsZkDxUgPeZkJwMmNpErUlBcGuMlJwKkWnOzFeFiSiPsEvMmQiCsYeHlLuHoMgBjFoZkXlObDkSoQcVyReTmRsFzRhTuIvCeBqVsQdQyTyZjStGrTyDcEcAgTgMiIcVkLbZbGvWeHtXwEqWkXfTcPyHhHjYwIeVxLyVmHmMkUsGiHmNnQuMsXaFyPpVqNrBhOiWmNkBbQuHvQdOjPjKiZcL"),
                ResultTester.CheckResult<string>(Solution.CapitalizeWord("Zzz"), "Zzz"),
                ResultTester.CheckResult<string>(Solution.CapitalizeWord("Zp"), "Zp"),
                ResultTester.CheckResult<string>(Solution.CapitalizeWord("Xyzzy"), "Xyzzy"),
            };
            return results;
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Word Capitalization");
        ResultTester.CheckCurrentSolution(ProblemOrigin.CodeForces, ProblemCategory.CF800, Test.TestCases());
    }
}