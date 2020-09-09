namespace DataStructuresAndAlgorithms.LeetCode
{
    public interface IVersionControl
    {
        bool IsBadVersion(int version);
    }
    public class FirstBadVersionControl 
    {
        private IVersionControl versionControl;
        public FirstBadVersionControl(IVersionControl versionControl)
        {
            this.versionControl = versionControl;
        }
        public int FirstBadVersion(int n)
        {
            int pivot, left = 1, right = n;
            while (left <= right)
            {
                pivot = left + (right - left) / 2;
                if (versionControl.IsBadVersion(pivot) && !versionControl.IsBadVersion(pivot - 1)) return pivot;
                if (!versionControl.IsBadVersion(pivot)) right = pivot - 1;
                else left = pivot + 1;
            }
            return 0;
        }
    }
}