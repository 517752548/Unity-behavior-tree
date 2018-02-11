﻿
namespace BTreeFrame
{
    public enum BTreeRunningStatus
    {
        Error = 0,
        Executing = 1,
        Finish = 2,
    }
    public enum BTreeNodeStatus
    {
        Ready = 1,
        Running = 2,
        Finish = 3,
    }
    public enum BTreeParallelFinishCondition
    {
        OR = 1,
        AND = 2,
    }

}
