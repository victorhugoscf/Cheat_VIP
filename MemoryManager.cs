using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Cheat_VIP
{
    public class MemoryManager
    {
        private IntPtr processHandle = IntPtr.Zero;
        private const int PROCESS_ALL_ACCESS = 0x1F0FFF;

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, int nSize, out int lpNumberOfBytesWritten);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, int nSize, out int lpNumberOfBytesRead);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool VirtualFreeEx(IntPtr hProcess, IntPtr lpAddress, uint dwSize, uint dwFreeType);

        private const uint MEM_COMMIT = 0x1000;
        private const uint MEM_RESERVE = 0x2000;
        private const uint PAGE_EXECUTE_READWRITE = 0x40;

        // Método para anexar ao processo
        public bool AttachToProcess(string processName)
        {
            try
            {
                Process[] processos = Process.GetProcessesByName(processName);
                if (processos.Length > 0)
                {
                    processHandle = OpenProcess(PROCESS_ALL_ACCESS, false, processos[0].Id);
                    if (processHandle == IntPtr.Zero)
                    {
                        MessageBox.Show("Falha ao abrir o processo. Erro: " + Marshal.GetLastWin32Error());
                        return false;
                    }
                    return true;
                }
                else
                {
                    MessageBox.Show("Processo não encontrado: " + processName);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao anexar ao processo: " + ex.Message);
                return false;
            }
        }

        // Verifica se o processo está anexado
        public bool IsAttached()
        {
            return processHandle != IntPtr.Zero;
        }

        // Método para escrever na memória (agora retorna bool)
        public bool WriteMemory(IntPtr address, byte[] value)
        {
            try
            {
                if (!IsAttached())
                {
                    MessageBox.Show("Processo não anexado.");
                    return false;
                }

                int bytesWritten;
                bool success = WriteProcessMemory(processHandle, address, value, value.Length, out bytesWritten);
                if (!success)
                {
                    MessageBox.Show("Falha ao escrever na memória. Erro: " + Marshal.GetLastWin32Error());
                }
                return success;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao escrever na memória: " + ex.Message);
                return false;
            }
        }

        // Método para ler da memória
        public byte[] ReadMemory(IntPtr address, int size)
        {
            try
            {
                if (!IsAttached())
                {
                    MessageBox.Show("Processo não anexado.");
                    return null;
                }

                byte[] buffer = new byte[size];
                int bytesRead;
                bool success = ReadProcessMemory(processHandle, address, buffer, size, out bytesRead);
                if (!success)
                {
                    MessageBox.Show("Falha ao ler da memória. Erro: " + Marshal.GetLastWin32Error());
                    return null;
                }
                return buffer;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao ler da memória: " + ex.Message);
                return null;
            }
        }

        // Método para alocar memória
        public IntPtr AllocateMemory(uint size)
        {
            try
            {
                if (!IsAttached())
                {
                    MessageBox.Show("Processo não anexado.");
                    return IntPtr.Zero;
                }

                IntPtr allocatedMemory = VirtualAllocEx(processHandle, IntPtr.Zero, size, MEM_COMMIT | MEM_RESERVE, PAGE_EXECUTE_READWRITE);
                if (allocatedMemory == IntPtr.Zero)
                {
                    MessageBox.Show("Falha ao alocar memória no processo. Erro: " + Marshal.GetLastWin32Error());
                }
                return allocatedMemory;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alocar memória: " + ex.Message);
                return IntPtr.Zero;
            }
        }

        // Método para liberar memória (agora retorna bool)
        public bool FreeMemory(IntPtr address, uint size)
        {
            try
            {
                if (!IsAttached())
                {
                    MessageBox.Show("Processo não anexado.");
                    return false;
                }

                bool success = VirtualFreeEx(processHandle, address, size, 0x8000); // MEM_RELEASE
                if (!success)
                {
                    MessageBox.Show("Falha ao liberar memória no processo. Erro: " + Marshal.GetLastWin32Error());
                }
                return success;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao liberar memória: " + ex.Message);
                return false;
            }
        }
    }
}