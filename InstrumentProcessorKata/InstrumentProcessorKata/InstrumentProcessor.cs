namespace InstrumentProcessorKata
{
    public class InstrumentProcessor : IInstrumentProcessor
    {
        private readonly IInstrument _instrument;
        private readonly ITaskDispatcher _taskDispatcher;
        private ConsoleWrapper _consoleWrapper;

        public InstrumentProcessor(IInstrument instrument, ITaskDispatcher taskDispatcher, ConsoleWrapper consoleWrapper)
        {
            _instrument = instrument;
            _taskDispatcher = taskDispatcher;
            _consoleWrapper = consoleWrapper;
        }

        public void Process()
        {
            var task = _taskDispatcher.GetTask();

            _instrument.Finished += (sender, args) => _taskDispatcher.FinishTask(task);
            _instrument.Error += (sender, args) => WriteErrorMessage();

            _instrument.Execute(task);
        }

        private void WriteErrorMessage()
        {
            _consoleWrapper.WriteLine("Error occurred");
        }
    }
}