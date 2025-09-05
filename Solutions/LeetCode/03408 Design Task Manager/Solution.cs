// Design Task Manager
namespace CompetitiveProgramming.LeetCode.DesignTaskManager;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class TaskManager {
    private Dictionary<int, (int userId, int priority)> taskDict;
    private SortedSet<(int priority, int taskId, int userId)> taskSet;

    public TaskManager(IList<IList<int>> tasks) {
        taskDict = new Dictionary<int, (int userId, int priority)>();
        taskSet = new SortedSet<(int priority, int taskId, int userId)>(Comparer<(int priority, int taskId, int userId)>.Create((a, b) => {
            if(a.priority != b.priority) {
                return b.priority.CompareTo(a.priority);
            }

            if (a.taskId != b.taskId)
                return b.taskId.CompareTo(a.taskId);
            return a.userId.CompareTo(b.userId);
        }));

        foreach (var task in tasks) {
            int userId = task[0], taskId = task[1], priority = task[2];
            Add(userId, taskId, priority);
        }
    }
    
    public void Add(int userId, int taskId, int priority) {
        taskDict[taskId] = (userId, priority);
        taskSet.Add((priority, taskId, userId));
    }
    
    public void Edit(int taskId, int newPriority) {
        if (taskDict.TryGetValue(taskId, out var task))
        {
            taskSet.Remove((task.priority, taskId, task.userId));
            taskDict[taskId] = (task.userId, newPriority);
            taskSet.Add((newPriority, taskId, task.userId));
        }
    }
    
    public void Rmv(int taskId) {
        if (taskDict.TryGetValue(taskId, out var task)) {
            taskSet.Remove((task.priority, taskId, task.userId));
            taskDict.Remove(taskId);
        }
    }
    
    public int ExecTop() {
        if (taskSet.Count == 0)
            return -1;

        var topTask = taskSet.First();
        taskSet.Remove(topTask);
        taskDict.Remove(topTask.taskId);
        return topTask.userId;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Design Task Manager");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}