using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using static Cheat_VIP.MemoryPatcher;

namespace Cheat_VIP
{
    public partial class Form1 : Form
    {
        private MemoryManager memoryManager;
        private MemoryPatcher memoryPatcher;
        private PastebinAuth pastebinAuth;

        // Address
        private static class MemoryAddresses
        {
            public static readonly IntPtr TravaHP = (IntPtr)0x00A90C50;
            public static readonly IntPtr TravaMP = (IntPtr)0x00A90CC0;
            public static readonly IntPtr TravaRES = (IntPtr)0x00A90D10;
            public static readonly IntPtr MinDamage = (IntPtr)0x00A3DAED;
            public static readonly IntPtr MaxDamage = (IntPtr)0x00A3DB4A;
            public static readonly IntPtr Abs = (IntPtr)0x00A3E2A5;
            public static readonly IntPtr HPTotal = (IntPtr)0x00A3E494;
            public static readonly IntPtr AtackSpeed = (IntPtr)0x00A3E87D;
            public static readonly IntPtr VelSpeed = (IntPtr)0x00A3E41D;
            public static readonly IntPtr Critico = (IntPtr)0x00A3E182;
            public static readonly IntPtr Block = (IntPtr)0x00A3E2E2;

        }

        public Form1()
        {
            InitializeComponent();
            memoryManager = new MemoryManager();
            memoryPatcher = new MemoryPatcher(memoryManager);
            pastebinAuth = new PastebinAuth();
            TabControl.TabPages.Remove(tabPageProcess);
            TabControl.TabPages.Remove(tabPageCheats);
            comboBox1.Items.Add("8");
            comboBox1.Items.Add("9");
            comboBox1.Items.Add("10");
            comboBox1.Items.Add("11");
            comboBox1.Items.Add("12");
            comboBox1.Items.Add("13");
            comboBox1.Items.Add("14");
            comboBox1.Items.Add("15");
        }

        // Método para carregar a lista de processos
        private void CarregarProcessos()
        {
            listBoxProcessos.Items.Clear();
            Process[] processos = Process.GetProcesses();
            foreach (Process processo in processos)
            {
                string item = $"{processo.ProcessName} (PID: {processo.Id})";
                listBoxProcessos.Items.Add(item);
            }
        }

        // Atualizar lista de processos
        private void BtnAtualizarProcessos_Click(object sender, EventArgs e)
        {
            CarregarProcessos();
        }

        // Evento de seleção de processo na lista
        private void ListBoxProcessos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxProcessos.SelectedItem != null)
            {
                string itemSelecionado = listBoxProcessos.SelectedItem.ToString();
                int indiceParenteses = itemSelecionado.IndexOf(" (PID:");
                if (indiceParenteses > 0)
                {
                    string nomeProcesso = itemSelecionado.Substring(0, indiceParenteses);
                    txtProcessName.Text = nomeProcesso;
                }
            }
        }

        // Login com Pastebin
        private async void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (await pastebinAuth.AuthenticateAsync(username, password))
            {
                MessageBox.Show("Login bem-sucedido!");
                TabControl.TabPages.Add(tabPageProcess); 
                TabControl.SelectedTab = tabPageProcess;
                CarregarProcessos();
            }
            else
            {
                MessageBox.Show("Login ou senha inválidos.");
            }
        }

        // Anexar ao processo selecionado
        private void BtnAttachProcess_Click(object sender, EventArgs e)
        {
            string processName = txtProcessName.Text;
            if (memoryManager.AttachToProcess(processName))
            {
                MessageBox.Show("Processo anexado com sucesso!");
                TabControl.TabPages.Add(tabPageCheats); 
                TabControl.SelectedTab = tabPageCheats;
            }
            else
            {
                MessageBox.Show("Falha ao anexar ao processo.");
            }
        }

        // Filtrar processos na lista
        private void txtPesquisarProcesso_TextChanged_1(object sender, EventArgs e)
        {
            string filtro = txtPesquisarProcesso.Text.ToLower();
            listBoxProcessos.Items.Clear();

            Process[] processos = Process.GetProcesses();
            foreach (Process processo in processos)
            {
                string item = $"{processo.ProcessName} (PID: {processo.Id})";
                if (item.ToLower().Contains(filtro))
                {
                    listBoxProcessos.Items.Add(item);
                }
            }
        }

        //Travar HP
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                memoryPatcher.WriteMemory(MemoryAddresses.TravaHP, new byte[] { 0xC3 }); // Ret
            }
            else
            {
                memoryPatcher.WriteMemory(MemoryAddresses.TravaHP, new byte[] { 0x55 }); // Push ebp
            }
        }

        //Travar MP
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                memoryPatcher.WriteMemory(MemoryAddresses.TravaMP, new byte[] { 0xC3 }); // Ret
            }
            else
            {
                memoryPatcher.WriteMemory(MemoryAddresses.TravaMP, new byte[] { 0x55 }); // Push ebp
            }
        }

        //Travar Res
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                memoryPatcher.WriteMemory(MemoryAddresses.TravaRES, new byte[] { 0xC3 }); // Ret
            }
            else
            {
                memoryPatcher.WriteMemory(MemoryAddresses.TravaRES, new byte[] { 0x55 }); // Push ebp
            }
        }

        //Dano Mínimo
        private void checkBoxValue1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxValue1.Checked)
            {
                if (int.TryParse(textBoxValue1.Text, out int valor))
                {
                    memoryPatcher.ReplaceInstruction(MemoryAddresses.MinDamage, valor, "eax", 5, 0);
                }
                else
                {
                    MessageBox.Show("Valor inválido para dano mínimo.");
                    checkBoxValue1.Checked = false;
                }
            }
            else
            {
                byte[] originalCode = new byte[] { 0x8B, 0x4D, 0xD0, 0x83, 0xC1, 0x03 };
                memoryPatcher.RestoreOriginalCode(MemoryAddresses.MinDamage, originalCode);
            }
        }

        //Dano Máximo
        private void checkBoxValue2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxValue2.Checked)
            {
                if (int.TryParse(textBoxValue2.Text, out int valor))
                {
                    // Substitui a instrução no endereço de MaxDamage
                    memoryPatcher.ReplaceInstruction(MemoryAddresses.MaxDamage, valor, "eax", 5, 1);
                }
                else
                {
                    MessageBox.Show("Valor inválido para dano máximo.");
                    checkBoxValue2.Checked = false;
                }
            }
            else
            {
                // Restaura o código original no endereço de MaxDamage
                byte[] originalCode = new byte[] { 0x8B, 0x4D, 0xD0, 0x83, 0xC1, 0x03 }; // mov ecx, [ebp-30] + add ecx, 03
                memoryPatcher.RestoreOriginalCode(MemoryAddresses.MaxDamage, originalCode);
            }
        }
        //ABS
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                if (int.TryParse(textBoxValue3.Text, out int valor))
                {

                    memoryPatcher.ReplaceInstruction(MemoryAddresses.Abs, valor, "eax", 5, 1);
                }
                else
                {
                    MessageBox.Show("Valor inválido para Absorção");
                    checkBox4.Checked = false;
                }
            }
            else
            {

                byte[] originalCode = new byte[] { 0x8B, 0x8D, 0x24, 0xFF, 0xFF, 0xFF };
                memoryPatcher.RestoreOriginalCode(MemoryAddresses.Abs, originalCode);
            }
        }
        //HPTOTAL
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                if (int.TryParse(textBoxValue4.Text, out int valor))
                {
                    memoryPatcher.ReplaceInstruction(MemoryAddresses.HPTotal, valor, "eax", 5, 2);

                }
                else
                {
                    MessageBox.Show("Valor inválido para o Total de HP");
                    checkBox5.Checked = false;
                }
            }

        }
        //ATACKSPEED
        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                if (comboBox1.SelectedItem != null)
                {
                    if (int.TryParse(comboBox1.SelectedItem.ToString(), out int valor))
                    {
                        memoryPatcher.ReplaceInstruction(MemoryAddresses.AtackSpeed, valor, "ecx", 5, 1);
                    }
                    else
                    {
                        MessageBox.Show("Valor inválido!");
                        checkBox6.Checked = false;
                    }
                }
                else
                {
                    MessageBox.Show("Selecione uma opção de velocidade!");
                    checkBox6.Checked = false;
                }
            }


        }
        //VelSpeed
        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                if (int.TryParse(textBoxValue5.Text, out int valor))
                {
                    memoryPatcher.ReplaceInstruction(MemoryAddresses.VelSpeed, valor, "eax", 5, 7);

                }
                else
                {
                    MessageBox.Show("Valor inválido para a Velocidade de Movimento");
                    checkBox7.Checked = false;
                }
            }

        }
        //Critico
        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked)
            {
                if (int.TryParse(textBoxValue6.Text, out int valor))
                {
                    memoryPatcher.ReplaceInstruction(MemoryAddresses.Critico, valor, "eax", 5, 1);

                }
                else
                {
                    MessageBox.Show("Valor inválido para o Crítico");
                    checkBox8.Checked = false;
                }
            }

        }
        //Block
        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked)
            {
                if (int.TryParse(textBoxValue7.Text, out int valor))
                {
                    memoryPatcher.ReplaceInstruction(MemoryAddresses.Block, valor, "ecx", 5, 2);

                }
                else
                {
                    MessageBox.Show("Valor inválido para o Bloqueio");
                    checkBox9.Checked = false;
                }
            }

        }

        
    }
}


