using DataStructuresAndAlgorithms.MITProgramming_for_the_Puzzled;

namespace DataStructuresAndAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = new Puzzle1YouWillAllConform();
            x.PleaseConfirm(new char[]
            {
                'F',
                'B',
                'B',
                'F',
                'B',
                'F',
                'F',
                'B',
                'B',
                'B',
                'F'
            });
        }
    }
}