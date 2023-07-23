using FinOps.Model.Interfaces;
using Moq.AutoMock;
using Xunit.Abstractions;

namespace FinOps.BusinessTests.Fixtures
{
    public class BaseFixture
    {
        public AutoMocker Mocker;

        public ITestOutputHelper OutputHelper
        {
            get => _outputHelper ?? throw new Exception("OutputHelper not initialized!");
            set => _outputHelper = value;
        }

        private ITestOutputHelper _outputHelper;

        public BaseFixture()
        {
            Mocker = new AutoMocker();
        }

        public virtual void OutpuHelperWriteLine(INotifier notifier)
        {
            var notifications = notifier.GetNotifications();
            if (notifications != null && notifications.Count > 0)
            {
                OutputHelper.WriteLine(string.Join(" - ", notifications));
            }
        }

        public void InitializeOutputHelper(ITestOutputHelper outputHelper)
        {
            if (outputHelper != null || OutputHelper == null)
                OutputHelper = outputHelper;
        }
    }
}
