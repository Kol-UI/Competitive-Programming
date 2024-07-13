// Robot Collisions

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.RobotCollisions
{
    public class Solution 
    {
        public IList<int> SurvivedRobotsHealths(int[] positions, int[] healths, string directions) 
        {
            var robots = new List<Robot>(positions.Length);
            for(int i = 0; i < positions.Length; i++)
            {
                robots.Add(new Robot(i, positions[i], healths[i], directions[i]));
            }
            robots.Sort((rX, rY) => rX.Position - rY.Position);

            var collisionsStack = new Stack<Robot>();
            foreach (var robot in robots)
            {
                if (robot.Direction == 'R') collisionsStack.Push(robot); 
                else if (robot.Direction == 'L' && (collisionsStack.Count == 0 || collisionsStack.Peek().Direction == 'L'))
                    collisionsStack.Push(robot);

                int rightDestroy = 0;
                while (collisionsStack.Count > 0 && robot.Direction == 'L' && collisionsStack.Peek().Direction == 'R')
                {
                    var current = collisionsStack.Pop();

                    if (current.Health > (robot.Health - rightDestroy))
                    {
                        collisionsStack.Push(current with { Health = current.Health - 1 });
                        break;
                    }
                    else if (current.Health < (robot.Health - rightDestroy))
                    {
                        rightDestroy++;
                        if (collisionsStack.Count == 0 || collisionsStack.Peek().Direction == 'L')
                        {
                            collisionsStack.Push(robot with { Health = robot.Health - rightDestroy });
                            break;
                        }
                        continue;
                    }
                    else break;
                }

                rightDestroy = 0;     
            }

            return collisionsStack.OrderBy(r => r.Index).Select(r => r.Health).ToList();
        }

        record struct Robot(int Index, int Position, int Health, char Direction);
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Robot Collisions");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.HardLC);
        }
    }
}