// Design Spreadsheet
namespace CompetitiveProgramming.LeetCode.DesignSpreadsheet;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Spreadsheet {

    private Dictionary<string, int> _sheet = new Dictionary<string, int>();

    public Spreadsheet(int rows) {
    }
    
    public void SetCell(string cell, int value) {
        _sheet[cell] = value;
    }
    
    public void ResetCell(string cell) {
        _sheet.Remove(cell);
    }
    
    public int GetValue(string formula) {
        string[] cells = formula.Substring(1).Split('+');

        int cell0;
        if (!int.TryParse(cells[0], out cell0)) {
            _sheet.TryGetValue(cells[0], out cell0);
        }

        int cell1;
        if (!int.TryParse(cells[1], out cell1)) {
            _sheet.TryGetValue(cells[1], out cell1);
        }
        
        return cell0 + cell1;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Design Spreadsheet");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}