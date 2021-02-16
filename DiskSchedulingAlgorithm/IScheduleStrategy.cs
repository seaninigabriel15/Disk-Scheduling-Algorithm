using System.Collections.Generic;

namespace DiskSchedulingAlgorithm
{
    public interface IScheduleStrategy
    {
        string GetName();
        int ReadNext(List<int> readRequest, int previousRead, ref bool direction);
    }
}
