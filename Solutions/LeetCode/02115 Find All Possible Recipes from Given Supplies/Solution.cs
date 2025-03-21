// Find All Possible Recipes from Given Supplies
namespace CompetitiveProgramming.LeetCode.FindAllPossibleRecipesfromGivenSupplies;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution {
    public IList<string> FindAllRecipes(string[] recipes, IList<IList<string>> ingredients, string[] supplies) {
        Dictionary<string, int> inDegree = new Dictionary<string, int>();
        Dictionary<string, List<string>> graph = new Dictionary<string, List<string>>();
        HashSet<string> available = new HashSet<string>(supplies);
        Queue<string> queue = new Queue<string>();
        List<string> result = new List<string>();
        for (int i = 0; i < recipes.Length; i++) {
            string recipe = recipes[i];
            inDegree[recipe] = ingredients[i].Count; 

            foreach (string ingredient in ingredients[i]) {
                if (!graph.ContainsKey(ingredient)) {
                    graph[ingredient] = new List<string>();
                }
                graph[ingredient].Add(recipe); 
            }
        }
        foreach (string supply in supplies) {
            queue.Enqueue(supply);
        }
        while (queue.Count > 0) {
            string ingredient = queue.Dequeue();
            if (inDegree.ContainsKey(ingredient)) {
                result.Add(ingredient);
            }
            if (graph.ContainsKey(ingredient)) {
                foreach (string recipe in graph[ingredient]) {
                    inDegree[recipe]--;
                    if (inDegree[recipe] == 0) {
                        queue.Enqueue(recipe);
                        available.Add(recipe);
                    }
                }
            }
        }

        return result;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Find All Possible Recipes from Given Supplies");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}