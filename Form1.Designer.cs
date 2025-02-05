namespace Cheat_VIP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            TabControl = new TabControl();
            tabPageLogin = new TabPage();
            groupBox5 = new GroupBox();
            txtUsername = new TextBox();
            label5 = new Label();
            label2 = new Label();
            txtPassword = new TextBox();
            BtnLogin = new Button();
            label4 = new Label();
            label1 = new Label();
            tabPageProcess = new TabPage();
            groupBox4 = new GroupBox();
            label3 = new Label();
            txtProcessName = new TextBox();
            BtnAttachProcess = new Button();
            groupBox3 = new GroupBox();
            listBoxProcessos = new ListBox();
            txtPesquisarProcesso = new TextBox();
            btnAtualizarProcessos = new Button();
            tabPageCheats = new TabPage();
            label6 = new Label();
            label7 = new Label();
            groupBox2 = new GroupBox();
            textBoxValue7 = new TextBox();
            checkBox9 = new CheckBox();
            textBoxValue6 = new TextBox();
            checkBox8 = new CheckBox();
            textBoxValue5 = new TextBox();
            checkBox7 = new CheckBox();
            comboBox1 = new ComboBox();
            checkBox6 = new CheckBox();
            textBoxValue4 = new TextBox();
            checkBox5 = new CheckBox();
            textBoxValue3 = new TextBox();
            checkBox4 = new CheckBox();
            textBoxValue2 = new TextBox();
            textBoxValue1 = new TextBox();
            checkBoxValue2 = new CheckBox();
            checkBoxValue1 = new CheckBox();
            groupBox1 = new GroupBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            comboBoxValue1 = new ComboBox();
            TabControl.SuspendLayout();
            tabPageLogin.SuspendLayout();
            groupBox5.SuspendLayout();
            tabPageProcess.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            tabPageCheats.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // TabControl
            // 
            TabControl.Controls.Add(tabPageLogin);
            TabControl.Controls.Add(tabPageProcess);
            TabControl.Controls.Add(tabPageCheats);
            TabControl.Location = new Point(14, 5);
            TabControl.Margin = new Padding(5, 3, 5, 3);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(488, 209);
            TabControl.SizeMode = TabSizeMode.Fixed;
            TabControl.TabIndex = 0;
            // 
            // tabPageLogin
            // 
            tabPageLogin.Controls.Add(groupBox5);
            tabPageLogin.Controls.Add(label4);
            tabPageLogin.Controls.Add(label1);
            tabPageLogin.ForeColor = SystemColors.ActiveCaptionText;
            tabPageLogin.Location = new Point(4, 26);
            tabPageLogin.Margin = new Padding(5, 3, 5, 3);
            tabPageLogin.Name = "tabPageLogin";
            tabPageLogin.Padding = new Padding(5, 3, 5, 3);
            tabPageLogin.Size = new Size(480, 179);
            tabPageLogin.TabIndex = 0;
            tabPageLogin.Text = "Login";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(txtUsername);
            groupBox5.Controls.Add(label5);
            groupBox5.Controls.Add(label2);
            groupBox5.Controls.Add(txtPassword);
            groupBox5.Controls.Add(BtnLogin);
            groupBox5.Location = new Point(106, 3);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(248, 170);
            groupBox5.TabIndex = 7;
            groupBox5.TabStop = false;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(76, 19);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(113, 25);
            txtUsername.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 11.25F);
            label5.Location = new Point(19, 26);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(47, 18);
            label5.TabIndex = 6;
            label5.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 11.25F);
            label2.Location = new Point(12, 78);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(54, 18);
            label2.TabIndex = 1;
            label2.Text = "Senha";
            // 
            // txtPassword
            // 
            txtPassword.ForeColor = SystemColors.ActiveCaptionText;
            txtPassword.Location = new Point(76, 76);
            txtPassword.Margin = new Padding(5, 3, 5, 3);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(113, 25);
            txtPassword.TabIndex = 3;
            // 
            // BtnLogin
            // 
            BtnLogin.ForeColor = SystemColors.ActiveCaptionText;
            BtnLogin.Location = new Point(88, 122);
            BtnLogin.Margin = new Padding(5, 3, 5, 3);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(85, 31);
            BtnLogin.TabIndex = 4;
            BtnLogin.Text = "Login";
            BtnLogin.UseVisualStyleBackColor = false;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // label4
            // 
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(100, 21);
            label4.TabIndex = 0;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(115, 26);
            label1.TabIndex = 5;
            // 
            // tabPageProcess
            // 
            tabPageProcess.Controls.Add(groupBox4);
            tabPageProcess.Controls.Add(groupBox3);
            tabPageProcess.ForeColor = SystemColors.ActiveCaptionText;
            tabPageProcess.Location = new Point(4, 24);
            tabPageProcess.Margin = new Padding(5, 3, 5, 3);
            tabPageProcess.Name = "tabPageProcess";
            tabPageProcess.Padding = new Padding(5, 3, 5, 3);
            tabPageProcess.Size = new Size(480, 181);
            tabPageProcess.TabIndex = 1;
            tabPageProcess.Text = "Injetar";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label3);
            groupBox4.Controls.Add(txtProcessName);
            groupBox4.Controls.Add(BtnAttachProcess);
            groupBox4.ForeColor = SystemColors.ActiveCaptionText;
            groupBox4.Location = new Point(247, 6);
            groupBox4.Margin = new Padding(5, 3, 5, 3);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(5, 3, 5, 3);
            groupBox4.Size = new Size(183, 165);
            groupBox4.TabIndex = 7;
            groupBox4.TabStop = false;
            groupBox4.Text = "Anexar ao processo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 32);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(126, 17);
            label3.TabIndex = 0;
            label3.Text = "Nome do Processo:";
            // 
            // txtProcessName
            // 
            txtProcessName.ForeColor = SystemColors.ActiveCaptionText;
            txtProcessName.Location = new Point(35, 77);
            txtProcessName.Margin = new Padding(5, 3, 5, 3);
            txtProcessName.Name = "txtProcessName";
            txtProcessName.Size = new Size(121, 25);
            txtProcessName.TabIndex = 1;
            // 
            // BtnAttachProcess
            // 
            BtnAttachProcess.ForeColor = SystemColors.ActiveCaptionText;
            BtnAttachProcess.Location = new Point(33, 130);
            BtnAttachProcess.Margin = new Padding(5, 3, 5, 3);
            BtnAttachProcess.Name = "BtnAttachProcess";
            BtnAttachProcess.Size = new Size(123, 26);
            BtnAttachProcess.TabIndex = 2;
            BtnAttachProcess.Text = "Anexar";
            BtnAttachProcess.UseVisualStyleBackColor = false;
            BtnAttachProcess.Click += BtnAttachProcess_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(listBoxProcessos);
            groupBox3.Controls.Add(txtPesquisarProcesso);
            groupBox3.Controls.Add(btnAtualizarProcessos);
            groupBox3.ForeColor = SystemColors.ActiveCaptionText;
            groupBox3.Location = new Point(49, 6);
            groupBox3.Margin = new Padding(5, 3, 5, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(5, 3, 5, 3);
            groupBox3.Size = new Size(191, 165);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Procurar o processo:";
            // 
            // listBoxProcessos
            // 
            listBoxProcessos.ForeColor = SystemColors.ActiveCaptionText;
            listBoxProcessos.FormattingEnabled = true;
            listBoxProcessos.ItemHeight = 17;
            listBoxProcessos.Location = new Point(7, 25);
            listBoxProcessos.Margin = new Padding(5, 3, 5, 3);
            listBoxProcessos.Name = "listBoxProcessos";
            listBoxProcessos.Size = new Size(173, 89);
            listBoxProcessos.TabIndex = 3;
            listBoxProcessos.SelectedIndexChanged += ListBoxProcessos_SelectedIndexChanged;
            // 
            // txtPesquisarProcesso
            // 
            txtPesquisarProcesso.ForeColor = SystemColors.ActiveCaptionText;
            txtPesquisarProcesso.Location = new Point(95, 133);
            txtPesquisarProcesso.Margin = new Padding(5, 3, 5, 3);
            txtPesquisarProcesso.Name = "txtPesquisarProcesso";
            txtPesquisarProcesso.Size = new Size(85, 25);
            txtPesquisarProcesso.TabIndex = 5;
            txtPesquisarProcesso.Tag = "";
            txtPesquisarProcesso.Text = "Game";
            txtPesquisarProcesso.TextChanged += txtPesquisarProcesso_TextChanged_1;
            // 
            // btnAtualizarProcessos
            // 
            btnAtualizarProcessos.ForeColor = SystemColors.ActiveCaptionText;
            btnAtualizarProcessos.Location = new Point(7, 133);
            btnAtualizarProcessos.Margin = new Padding(5, 3, 5, 3);
            btnAtualizarProcessos.Name = "btnAtualizarProcessos";
            btnAtualizarProcessos.Size = new Size(81, 26);
            btnAtualizarProcessos.TabIndex = 4;
            btnAtualizarProcessos.Text = "Atualizar";
            btnAtualizarProcessos.UseVisualStyleBackColor = false;
            btnAtualizarProcessos.Click += BtnAtualizarProcessos_Click;
            // 
            // tabPageCheats
            // 
            tabPageCheats.Controls.Add(label6);
            tabPageCheats.Controls.Add(label7);
            tabPageCheats.Controls.Add(groupBox2);
            tabPageCheats.Controls.Add(groupBox1);
            tabPageCheats.ForeColor = SystemColors.ActiveCaptionText;
            tabPageCheats.Location = new Point(4, 24);
            tabPageCheats.Margin = new Padding(5, 3, 5, 3);
            tabPageCheats.Name = "tabPageCheats";
            tabPageCheats.Padding = new Padding(5, 3, 5, 3);
            tabPageCheats.Size = new Size(480, 181);
            tabPageCheats.TabIndex = 2;
            tabPageCheats.Text = "Cheat";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 149);
            label6.Name = "label6";
            label6.Size = new Size(106, 17);
            label6.TabIndex = 4;
            label6.Text = "(88) 9 9807-2532";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(31, 132);
            label7.Name = "label7";
            label7.Size = new Size(59, 17);
            label7.TabIndex = 3;
            label7.Text = "Suporte:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxValue7);
            groupBox2.Controls.Add(checkBox9);
            groupBox2.Controls.Add(textBoxValue6);
            groupBox2.Controls.Add(checkBox8);
            groupBox2.Controls.Add(textBoxValue5);
            groupBox2.Controls.Add(checkBox7);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(checkBox6);
            groupBox2.Controls.Add(textBoxValue4);
            groupBox2.Controls.Add(checkBox5);
            groupBox2.Controls.Add(textBoxValue3);
            groupBox2.Controls.Add(checkBox4);
            groupBox2.Controls.Add(textBoxValue2);
            groupBox2.Controls.Add(textBoxValue1);
            groupBox2.Controls.Add(checkBoxValue2);
            groupBox2.Controls.Add(checkBoxValue1);
            groupBox2.ForeColor = SystemColors.ActiveCaptionText;
            groupBox2.Location = new Point(128, 22);
            groupBox2.Margin = new Padding(5, 3, 5, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(5, 3, 5, 3);
            groupBox2.Size = new Size(342, 151);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Editar Status";
            // 
            // textBoxValue7
            // 
            textBoxValue7.Location = new Point(266, 111);
            textBoxValue7.Name = "textBoxValue7";
            textBoxValue7.Size = new Size(41, 25);
            textBoxValue7.TabIndex = 16;
            // 
            // checkBox9
            // 
            checkBox9.AutoSize = true;
            checkBox9.Location = new Point(165, 113);
            checkBox9.Name = "checkBox9";
            checkBox9.Size = new Size(91, 21);
            checkBox9.TabIndex = 15;
            checkBox9.Text = "Add. Block";
            checkBox9.UseVisualStyleBackColor = true;
            checkBox9.CheckedChanged += checkBox9_CheckedChanged;
            // 
            // textBoxValue6
            // 
            textBoxValue6.Location = new Point(104, 111);
            textBoxValue6.Name = "textBoxValue6";
            textBoxValue6.Size = new Size(39, 25);
            textBoxValue6.TabIndex = 14;
            // 
            // checkBox8
            // 
            checkBox8.AutoSize = true;
            checkBox8.Location = new Point(7, 113);
            checkBox8.Name = "checkBox8";
            checkBox8.Size = new Size(97, 21);
            checkBox8.TabIndex = 13;
            checkBox8.Text = "Add. Crítico";
            checkBox8.UseVisualStyleBackColor = true;
            checkBox8.CheckedChanged += checkBox8_CheckedChanged;
            // 
            // textBoxValue5
            // 
            textBoxValue5.Location = new Point(266, 83);
            textBoxValue5.Name = "textBoxValue5";
            textBoxValue5.Size = new Size(41, 25);
            textBoxValue5.TabIndex = 12;
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.Location = new Point(165, 86);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(79, 21);
            checkBox7.TabIndex = 11;
            checkBox7.Text = "Vel. Bota";
            checkBox7.UseVisualStyleBackColor = true;
            checkBox7.CheckedChanged += checkBox7_CheckedChanged;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(266, 54);
            comboBox1.Name = "comboBox1";
            comboBox1.RightToLeft = RightToLeft.No;
            comboBox1.Size = new Size(41, 25);
            comboBox1.TabIndex = 10;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(165, 57);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(95, 21);
            checkBox6.TabIndex = 9;
            checkBox6.Text = "Vel. Ataque";
            checkBox6.UseVisualStyleBackColor = true;
            checkBox6.CheckedChanged += checkBox6_CheckedChanged;
            // 
            // textBoxValue4
            // 
            textBoxValue4.Location = new Point(266, 24);
            textBoxValue4.Name = "textBoxValue4";
            textBoxValue4.Size = new Size(41, 25);
            textBoxValue4.TabIndex = 8;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(165, 26);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(77, 21);
            checkBox5.TabIndex = 7;
            checkBox5.Text = "Add. HP";
            checkBox5.UseVisualStyleBackColor = true;
            checkBox5.CheckedChanged += checkBox5_CheckedChanged;
            // 
            // textBoxValue3
            // 
            textBoxValue3.Location = new Point(104, 82);
            textBoxValue3.Name = "textBoxValue3";
            textBoxValue3.Size = new Size(39, 25);
            textBoxValue3.TabIndex = 5;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(7, 86);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(84, 21);
            checkBox4.TabIndex = 4;
            checkBox4.Text = "Absorção";
            checkBox4.UseVisualStyleBackColor = true;
            checkBox4.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // textBoxValue2
            // 
            textBoxValue2.ForeColor = SystemColors.ActiveCaptionText;
            textBoxValue2.Location = new Point(104, 54);
            textBoxValue2.Margin = new Padding(5, 3, 5, 3);
            textBoxValue2.Name = "textBoxValue2";
            textBoxValue2.Size = new Size(39, 25);
            textBoxValue2.TabIndex = 3;
            // 
            // textBoxValue1
            // 
            textBoxValue1.Location = new Point(104, 24);
            textBoxValue1.Name = "textBoxValue1";
            textBoxValue1.Size = new Size(39, 25);
            textBoxValue1.TabIndex = 6;
            // 
            // checkBoxValue2
            // 
            checkBoxValue2.AutoSize = true;
            checkBoxValue2.Location = new Point(7, 57);
            checkBoxValue2.Margin = new Padding(5, 3, 5, 3);
            checkBoxValue2.Name = "checkBoxValue2";
            checkBoxValue2.Size = new Size(92, 21);
            checkBoxValue2.TabIndex = 1;
            checkBoxValue2.Text = "Max. Dano";
            checkBoxValue2.UseVisualStyleBackColor = true;
            checkBoxValue2.CheckedChanged += checkBoxValue2_CheckedChanged;
            // 
            // checkBoxValue1
            // 
            checkBoxValue1.AutoSize = true;
            checkBoxValue1.Location = new Point(7, 26);
            checkBoxValue1.Margin = new Padding(5, 3, 5, 3);
            checkBoxValue1.Name = "checkBoxValue1";
            checkBoxValue1.Size = new Size(89, 21);
            checkBoxValue1.TabIndex = 0;
            checkBoxValue1.Text = "Min. Dano";
            checkBoxValue1.UseVisualStyleBackColor = true;
            checkBoxValue1.CheckedChanged += checkBoxValue1_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBox3);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(7, 22);
            groupBox1.Margin = new Padding(5, 3, 5, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5, 3, 5, 3);
            groupBox1.Size = new Size(115, 107);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Trava";
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.ForeColor = SystemColors.ActiveCaptionText;
            checkBox3.Location = new Point(24, 76);
            checkBox3.Margin = new Padding(5, 3, 5, 3);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(49, 21);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "RES";
            checkBox3.UseVisualStyleBackColor = false;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.ForeColor = SystemColors.ActiveCaptionText;
            checkBox2.Location = new Point(24, 48);
            checkBox2.Margin = new Padding(5, 3, 5, 3);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(67, 21);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "MANA";
            checkBox2.UseVisualStyleBackColor = false;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.ForeColor = SystemColors.ActiveCaptionText;
            checkBox1.Location = new Point(24, 19);
            checkBox1.Margin = new Padding(5, 3, 5, 3);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(45, 21);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "HP";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // comboBoxValue1
            // 
            comboBoxValue1.Location = new Point(0, 0);
            comboBoxValue1.Name = "comboBoxValue1";
            comboBoxValue1.Size = new Size(121, 23);
            comboBoxValue1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(512, 218);
            Controls.Add(TabControl);
            Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ButtonFace;
            HelpButton = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 3, 5, 3);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cheat VIP";
            TabControl.ResumeLayout(false);
            tabPageLogin.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            tabPageProcess.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            tabPageCheats.ResumeLayout(false);
            tabPageCheats.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl TabControl;
        private TabPage tabPageLogin;
        private TabPage tabPageProcess;
        private TabPage tabPageCheats;
        private Label label1;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label label2;
        private Button BtnLogin;
        private Button BtnAttachProcess;
        private TextBox txtProcessName;
        private Label label3;
        private GroupBox groupBox1;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private GroupBox groupBox2;
        private TextBox textBoxValue2;
        private TextBox textBoxValue1;
        private CheckBox checkBoxValue2;
        private CheckBox checkBoxValue1;
        private Button btnAtualizarProcessos;
        private ListBox listBoxProcessos;
        private Label label4;
        private GroupBox groupBox3;
        private TextBox txtPesquisarProcesso;
        private GroupBox groupBox4;
        private Label label5;
        private TextBox textBoxValue3;
        private CheckBox checkBox4;
        private TextBox textBoxValue4;
        private CheckBox checkBox5;
        private CheckBox checkBox6;
        private ComboBox comboBoxValue1;
        public ComboBox comboBox1;
        private TextBox textBoxValue5;
        private CheckBox checkBox7;
        private TextBox textBoxValue6;
        private CheckBox checkBox8;
        private TextBox textBoxValue7;
        private CheckBox checkBox9;
        private Label label6;
        private Label label7;
        private GroupBox groupBox5;
    }
}
