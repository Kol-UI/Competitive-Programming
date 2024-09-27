// My Calendar II

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MyCalendarII
{
    public class MyCalendarTwo {
        List<Tuple<int,int>>  doubleOverlappedRegion;
        List<Tuple<int,int>>  overallBookings;

        public bool CheckOverlap(int start1,int end1,int start2,int end2){
            return Math.Max(start1,start2)<Math.Min(end1,end2);
        }
        public Tuple<int, int> FindOverlappedRegion(int start1,int end1,int start2,int end2){
            int overlappedStart = Math.Max(start1, start2);
            int overlappedEnd = Math.Min(end1, end2);
            return new Tuple<int, int>(overlappedStart, overlappedEnd);
        }
        public MyCalendarTwo() {
        doubleOverlappedRegion = new List<Tuple<int, int>>();
        overallBookings = new List<Tuple<int, int>>();        
        }
        
        public bool Book(int start, int end) {
            foreach(var region in doubleOverlappedRegion){
                if(CheckOverlap(region.Item1,region.Item2,start,end)){
                    return false;
                }
            }
            foreach(var booking in overallBookings ){
                if(CheckOverlap(booking.Item1,booking.Item2,start,end)){
                    doubleOverlappedRegion
                    .Add(FindOverlappedRegion(booking.Item1,booking.Item2,start,end));
                }
            }
            overallBookings.Add(new Tuple<int,int>(start,end));
            return true;
        }
    }

    /**
    * Your MyCalendarTwo object will be instantiated and called as such:
    * MyCalendarTwo obj = new MyCalendarTwo();
    * bool param_1 = obj.Book(start,end);
    */

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("My Calendar II");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}