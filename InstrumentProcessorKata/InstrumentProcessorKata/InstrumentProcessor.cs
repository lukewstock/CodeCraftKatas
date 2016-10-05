using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstrumentProcessorKata
{
    public class InstrumentProcessor : IInstrumentProcessor
    {
        private IInstrument _instrument;
        private ITaskDispatcher _taskDispatcher;

        public InstrumentProcessor(IInstrument instrument, ITaskDispatcher taskDispatcher)
        {
            _instrument = instrument;
            _taskDispatcher = taskDispatcher;
        }

        public void Process()
        {
            var task = _taskDispatcher.GetTask();

            _instrument.Execute(task);
        }
    }
}