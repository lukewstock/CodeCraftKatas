using System;

namespace InstrumentProcessorKata
{
    public class InstrumentProcessor : IInstrumentProcessor, IDisposable
    {
        private readonly IInstrument _instrument;
        private readonly ITaskDispatcher _taskDispatcher;
        private readonly IConsoleWrapper _consoleWrapper;

        public InstrumentProcessor(IInstrument instrument, ITaskDispatcher taskDispatcher, IConsoleWrapper consoleWrapper)
        {
            _instrument = instrument;
            _taskDispatcher = taskDispatcher;
            _consoleWrapper = consoleWrapper;
            _instrument.Finished += OnFinished;
            _instrument.Error += OnError;
        }

        public void Process()
        {
            var task = _taskDispatcher.GetTask();

            _instrument.Finished += (sender, args) => _taskDispatcher.FinishTask(task);
            _instrument.Error += (sender, args) => WriteErrorMessage();

            _instrument.Execute(task);
        }

        private void OnFinished(object sender, EventArgs e)
        {
            var taskName = (e as TaskEventArgs).TaskNAme;
            _taskDispatcher.FinishTask(taskName);
        }

        private void OnError(object sender, EventArgs e)
        {
            _consoleWrapper.WriteLine("Error occurred");            
        }

        private void WriteErrorMessage()
        {
            _consoleWrapper.WriteLine("Error occurred");
        }

        public void Dispose()
        {
            _instrument.Error -= OnError;

        }
    }

    public class TaskEventArgs : EventArgs
    {
        public string TaskNAme
        {
            get; private set; 
            
        }

        public TaskEventArgs(string taskNAme)
        {
            TaskNAme = taskNAme;
        }
    }


}