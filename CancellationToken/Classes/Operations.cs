using System;
using System.Threading.Tasks;

namespace CancellationToken.Classes
{
    public class Operations
    {
        public delegate void MonitorHandler(MonitorArgs args);
        public event MonitorHandler OnMonitor;

        public delegate void AddItem(string item);
        public static event AddItem OnAddItem;
        
        public async Task<int> Run(int value, System.Threading.CancellationToken token)
        {
            var currentIndex = 0;

            while (currentIndex <= value -1)
            {

                OnMonitor?.Invoke(new MonitorArgs("Working", currentIndex));

                currentIndex += 1;

                await Task.Delay(1, token);
                
                if (token.IsCancellationRequested) token.ThrowIfCancellationRequested();
            }

            OnMonitor?.Invoke(new MonitorArgs("Done", currentIndex));
            return currentIndex;
        }
        public static async Task Load(int value)
        {
            var currentIndex = 0;

            TimeSpan timeSpan = new TimeSpan(0, 0, 0, 0, 10);

            while (currentIndex <= value - 1)
            {
                OnAddItem?.Invoke($"{currentIndex} item");
                currentIndex += 1;
                await Task.Delay(timeSpan);
            }
        }
    }
}