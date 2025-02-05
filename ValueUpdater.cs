using System.Threading;
using System.Windows.Forms;

namespace Cheat_VIP
{
    public class ValueUpdater
    {
        private readonly MemoryPatcher memoryPatcher;
        private Thread updateThread;
        private bool isRunning = false;

        public ValueUpdater(MemoryPatcher memoryPatcher)
        {
            this.memoryPatcher = memoryPatcher;
        }

        public void Start(IntPtr address, TextBox textBox)
        {
            isRunning = true;
            updateThread = new Thread(() =>
            {
                while (isRunning)
                {
                    if (int.TryParse(textBox.Text, out int valor))
                    {
                        // Implementação para atualizar o valor na memória
                    }
                    Thread.Sleep(100); // Ajuste o intervalo conforme necessário
                }
            });
            updateThread.Start();
        }

        public void Stop()
        {
            isRunning = false;
            updateThread?.Join(); // Espera a thread terminar
        }
    }
}