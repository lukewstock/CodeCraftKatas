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
        private Mock<IConsoleWrapper> _console;

        [SetUp]
        public void Setup()
        {
            _taskDispatcher = new Mock<ITaskDispatcher>();
            _instrument = new Mock<IInstrument>();
            _console = new Mock<IConsoleWrapper>();
            _processor = new InstrumentProcessor(_instrument.Object, _taskDispatcher.Object, _console.Object);
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

        [Test]
        public void FinishTask_WhenProcessing_GivenFinishEventIsRaised()
        {
            const string taskName = "task";
            _taskDispatcher
                .Setup(td => td.GetTask())
                .Returns(taskName);
            _instrument
                .Setup(i => i.Execute(taskName))
                .Raises(i => i.Finished += null, EventArgs.Empty);
            
            _processor.Process();

            _taskDispatcher.Verify(td => td.FinishTask(taskName), Times.Once);
        }

        [Test]
        public void WriteAnErrorMessage_WhenProcessing_GivenErrorEventIsRaised()
        {
            const string ERROR_MESSAGE = "Error occurred";
            const string TASK_NAME = "task";
            _taskDispatcher
                .Setup(td => td.GetTask())
                .Returns(TASK_NAME);
            _instrument
                .Setup(i => i.Execute(TASK_NAME))
                .Raises(i => i.Error += null, EventArgs.Empty);

            _processor.Process();

            _console.Verify(console => console.WriteLine(ERROR_MESSAGE));
        }

//        [Test]
//        public void ShouldThrowExceptio
    }
}   