namespace Modul_9_1
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
            lbSAU = new Label();
            rbSetor = new RadioButton();
            lbAction = new Label();
            lbJU = new Label();
            lbPass = new Label();
            rbTarik = new RadioButton();
            tbJU = new TextBox();
            tbPass = new TextBox();
            btnLanjut = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lbSAU
            // 
            lbSAU.AutoSize = true;
            lbSAU.Location = new Point(154, 21);
            lbSAU.Name = "lbSAU";
            lbSAU.Size = new Size(110, 15);
            lbSAU.TabIndex = 0;
            lbSAU.Text = "Saldo Akun Umum ";
            // 
            // rbSetor
            // 
            rbSetor.AutoSize = true;
            rbSetor.Location = new Point(145, 123);
            rbSetor.Name = "rbSetor";
            rbSetor.Size = new Size(52, 19);
            rbSetor.TabIndex = 1;
            rbSetor.TabStop = true;
            rbSetor.Text = "Setor";
            rbSetor.UseVisualStyleBackColor = true;
            // 
            // lbAction
            // 
            lbAction.AutoSize = true;
            lbAction.Location = new Point(81, 125);
            lbAction.Name = "lbAction";
            lbAction.Size = new Size(48, 15);
            lbAction.TabIndex = 2;
            lbAction.Text = "Action :";
            // 
            // lbJU
            // 
            lbJU.AutoSize = true;
            lbJU.Location = new Point(47, 172);
            lbJU.Name = "lbJU";
            lbJU.Size = new Size(82, 15);
            lbJU.TabIndex = 3;
            lbJU.Text = "Jumlah Uang :";
            // 
            // lbPass
            // 
            lbPass.AutoSize = true;
            lbPass.Location = new Point(66, 219);
            lbPass.Name = "lbPass";
            lbPass.Size = new Size(63, 15);
            lbPass.TabIndex = 4;
            lbPass.Text = "Password :";
            // 
            // rbTarik
            // 
            rbTarik.AutoSize = true;
            rbTarik.Location = new Point(215, 123);
            rbTarik.Name = "rbTarik";
            rbTarik.Size = new Size(49, 19);
            rbTarik.TabIndex = 5;
            rbTarik.TabStop = true;
            rbTarik.Text = "Tarik";
            rbTarik.UseVisualStyleBackColor = true;
            // 
            // tbJU
            // 
            tbJU.Location = new Point(145, 169);
            tbJU.Name = "tbJU";
            tbJU.Size = new Size(119, 23);
            tbJU.TabIndex = 7;
            // 
            // tbPass
            // 
            tbPass.Location = new Point(145, 211);
            tbPass.Name = "tbPass";
            tbPass.Size = new Size(119, 23);
            tbPass.TabIndex = 8;
            // 
            // btnLanjut
            // 
            btnLanjut.BackColor = SystemColors.ScrollBar;
            btnLanjut.Location = new Point(288, 203);
            btnLanjut.Name = "btnLanjut";
            btnLanjut.Size = new Size(83, 31);
            btnLanjut.TabIndex = 9;
            btnLanjut.Text = "Lanjut";
            btnLanjut.UseVisualStyleBackColor = false;
            btnLanjut.Click += btnLanjut_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(173, 59);
            label1.Name = "label1";
            label1.Size = new Size(72, 30);
            label1.TabIndex = 10;
            label1.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(418, 278);
            Controls.Add(label1);
            Controls.Add(btnLanjut);
            Controls.Add(tbPass);
            Controls.Add(tbJU);
            Controls.Add(rbTarik);
            Controls.Add(lbPass);
            Controls.Add(lbJU);
            Controls.Add(lbAction);
            Controls.Add(rbSetor);
            Controls.Add(lbSAU);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbSAU;
        private RadioButton rbSetor;
        private Label lbAction;
        private Label lbJU;
        private Label lbPass;
        private RadioButton rbTarik;
        private TextBox tbJU;
        private TextBox tbPass;
        private Button btnLanjut;
        private Label label1;
    }
}