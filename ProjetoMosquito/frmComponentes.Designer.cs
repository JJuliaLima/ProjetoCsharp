
namespace ProjetoMosquito
{
    partial class frmComponentes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmComponentes));
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.rdbViajar = new System.Windows.Forms.RadioButton();
            this.rdbComer = new System.Windows.Forms.RadioButton();
            this.rdbMega = new System.Windows.Forms.RadioButton();
            this.rdbAviao = new System.Windows.Forms.RadioButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(30, 46);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(55, 24);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "livro";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(30, 69);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(76, 24);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "pescar";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(30, 95);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(72, 24);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "dormir";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(30, 122);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(59, 24);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "café";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // rdbViajar
            // 
            this.rdbViajar.AutoSize = true;
            this.rdbViajar.BackColor = System.Drawing.SystemColors.Control;
            this.rdbViajar.Location = new System.Drawing.Point(17, 35);
            this.rdbViajar.Name = "rdbViajar";
            this.rdbViajar.Size = new System.Drawing.Size(63, 24);
            this.rdbViajar.TabIndex = 4;
            this.rdbViajar.TabStop = true;
            this.rdbViajar.Text = "viajar";
            this.rdbViajar.UseVisualStyleBackColor = false;
            // 
            // rdbComer
            // 
            this.rdbComer.AutoSize = true;
            this.rdbComer.Location = new System.Drawing.Point(17, 59);
            this.rdbComer.Name = "rdbComer";
            this.rdbComer.Size = new System.Drawing.Size(71, 24);
            this.rdbComer.TabIndex = 5;
            this.rdbComer.TabStop = true;
            this.rdbComer.Text = "comer";
            this.rdbComer.UseVisualStyleBackColor = true;
            // 
            // rdbMega
            // 
            this.rdbMega.AutoSize = true;
            this.rdbMega.Location = new System.Drawing.Point(17, 82);
            this.rdbMega.Name = "rdbMega";
            this.rdbMega.Size = new System.Drawing.Size(67, 24);
            this.rdbMega.TabIndex = 6;
            this.rdbMega.TabStop = true;
            this.rdbMega.Text = "mega";
            this.rdbMega.UseVisualStyleBackColor = true;
            // 
            // rdbAviao
            // 
            this.rdbAviao.AutoSize = true;
            this.rdbAviao.Location = new System.Drawing.Point(17, 105);
            this.rdbAviao.Name = "rdbAviao";
            this.rdbAviao.Size = new System.Drawing.Size(64, 24);
            this.rdbAviao.TabIndex = 7;
            this.rdbAviao.TabStop = true;
            this.rdbAviao.Text = "avião";
            this.rdbAviao.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Items.AddRange(new object[] {
            "Correr",
            "Andar",
            "Sentar",
            "Levantar",
            "Treinar"});
            this.listBox1.Location = new System.Drawing.Point(513, 38);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(175, 104);
            this.listBox1.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Futebol",
            "Basquete",
            "Vôlei",
            "Golf",
            "Truco",
            "Uno",
            "Sinuca",
            "Dominó"});
            this.comboBox1.Location = new System.Drawing.Point(513, 177);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(176, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(59, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(165, 187);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Escolha";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbViajar);
            this.groupBox2.Controls.Add(this.rdbComer);
            this.groupBox2.Controls.Add(this.rdbMega);
            this.groupBox2.Controls.Add(this.rdbAviao);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(253, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(164, 187);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Você prefere";
            // 
            // frmComponentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmComponentes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SistemaABC - Componentes";
            this.Load += new System.EventHandler(this.frmComponentes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.RadioButton rdbViajar;
        private System.Windows.Forms.RadioButton rdbComer;
        private System.Windows.Forms.RadioButton rdbMega;
        private System.Windows.Forms.RadioButton rdbAviao;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}