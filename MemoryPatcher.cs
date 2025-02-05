using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Cheat_VIP
{
    public class MemoryPatcher
    {
        private readonly MemoryManager memoryManager;

        // Dicionário de opcodes para mov <registrador>, <valor>
        private static readonly Dictionary<string, byte> RegisterOpcodes = new Dictionary<string, byte>
        {
            { "eax", 0xB8 }, // mov eax, <valor>
            { "ecx", 0xB9 }, // mov ecx, <valor>
            { "edx", 0xBA }, // mov edx, <valor>
            { "ebx", 0xBB }, // mov ebx, <valor>
            { "esi", 0xBE }, // mov esi, <valor>
            { "edi", 0xBF }  // mov edi, <valor>
        };

        public MemoryPatcher(MemoryManager memoryManager)
        {
            this.memoryManager = memoryManager;
        }

        // Método para escrever na memória (agora retorna bool)
        public bool WriteMemory(IntPtr address, byte[] value)
        {
            try
            {
                if (memoryManager.IsAttached())
                {
                    return memoryManager.WriteMemory(address, value);
                }
                else
                {
                    MessageBox.Show("Processo não anexado.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao escrever na memória: " + ex.Message);
                return false;
            }
        }

        // Método para substituir a instrução (agora generalizado)
        public void ReplaceInstruction(IntPtr address, int value, string register, int bytesToReplace, int bytesToNop)
        {
            try
            {
                if (!memoryManager.IsAttached())
                {
                    MessageBox.Show("Processo não anexado.");
                    return;
                }

                // Verifica se o registrador é válido
                if (!RegisterOpcodes.ContainsKey(register.ToLower()))
                {
                    MessageBox.Show("Registrador inválido.");
                    return;
                }

                // Obtém o opcode correspondente ao registrador
                byte opcode = RegisterOpcodes[register.ToLower()];

                // Código assembly para mov <registrador>, <valor>
                byte[] newCode = new byte[]
                {
            opcode, 0x00, 0x00, 0x00, 0x00 // mov <registrador>, <valor>
                };

                // Define o valor
                byte[] valueBytes = BitConverter.GetBytes(value);
                Array.Copy(valueBytes, 0, newCode, 1, 4);
          

                // Escreve os bytes da nova instrução
                if (!WriteMemory(address, newCode.Take(bytesToReplace).ToArray()))
                {
                    MessageBox.Show("Falha ao substituir a instrução.");
                    return;
                }

                // Preenche os bytes restantes com NOP
                if (bytesToNop > 0)
                {
                    byte[] nopCode = new byte[bytesToNop];
                    for (int i = 0; i < bytesToNop; i++)
                        nopCode[i] = 0x90; // NOP

                    if (!WriteMemory(address + bytesToReplace, nopCode))
                    {
                        MessageBox.Show("Falha ao preencher com NOP.");
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao substituir a instrução: " + ex.Message);
            }
        }

        // Método para restaurar o código original
        public void RestoreOriginalCode(IntPtr address, byte[] originalCode)
        {
            try
            {
                if (!memoryManager.IsAttached())
                {
                    MessageBox.Show("Processo não anexado.");
                    return;
                }

                // Restaura o código original
                if (!WriteMemory(address, originalCode))
                {
                    MessageBox.Show("Falha ao restaurar o código original.");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao restaurar o código original: " + ex.Message);
            }
        }
    }
}