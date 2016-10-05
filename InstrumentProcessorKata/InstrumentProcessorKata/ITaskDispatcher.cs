namespace InstrumentProcessorKata
{
    public interface ITaskDispatcher
    {
        string GetTask();
        void FinishTask(string task);
    }
}