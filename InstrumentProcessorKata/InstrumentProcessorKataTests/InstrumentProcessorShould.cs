using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InstrumentProcessorKata;
using Moq;
using NUnit.Framework;

namespace InstrumentProcessorKataTests
{
    [TestFixture]
    public class InstrumentProcessorShould
    {
        private Mock<IInstrument> _instrument;
        private InstrumentProcessor _processor;
        private Mock<ITaskDispatcher> _taskDispatcher;

        [SetUp]
        public void Setup()
        {
            _taskDispatcher = new Mock<ITaskDispatcher>();
            _instrument = new Mock<IInstrument>();
            _processor = new InstrumentProcessor(_instrument.Object, _taskDispatcher.Object);
        }

        [TestCase("task1")]
        [TestCase("task2")]
        public void ExecuteTask_WhenProcesing_GivenATask(string taskName)
        {
            _taskDispatcher
                .Setup(taskDispatcher => taskDispatcher.GetTask())
                .Returns(taskName);

            _processor.Process();

            _instrument.Verify(i => i.Execute(taskName), Times.Once);
        }
    }
}