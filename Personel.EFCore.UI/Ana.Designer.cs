namespace Personel.EFCore.UI
{
    partial class Ana
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
            btn_kayit = new Button();
            txt_pna = new TextBox();
            txt_plna = new TextBox();
            txt_pde = new TextBox();
            txt_pIN = new TextBox();
            btn_kayGet = new Button();
            btn_arama = new Button();
            btn_deg = new Button();
            dateTimePicker1 = new DateTimePicker();
            chk_il = new CheckBox();
            chk_ik = new CheckBox();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            btn_sil = new Button();
            label1 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txt_pdm = new TextBox();
            txt_pmm = new TextBox();
            txt_pda = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // btn_kayit
            // 
            btn_kayit.Location = new Point(274, 12);
            btn_kayit.Name = "btn_kayit";
            btn_kayit.Size = new Size(94, 29);
            btn_kayit.TabIndex = 1;
            btn_kayit.Text = "Kaydet";
            btn_kayit.UseVisualStyleBackColor = true;
            btn_kayit.Click += button1_Click;
            // 
            // txt_pna
            // 
            txt_pna.Location = new Point(6, 54);
            txt_pna.Name = "txt_pna";
            txt_pna.Size = new Size(125, 27);
            txt_pna.TabIndex = 2;
            // 
            // txt_plna
            // 
            txt_plna.Location = new Point(7, 118);
            txt_plna.Name = "txt_plna";
            txt_plna.Size = new Size(125, 27);
            txt_plna.TabIndex = 3;
            // 
            // txt_pde
            // 
            txt_pde.Location = new Point(6, 171);
            txt_pde.Name = "txt_pde";
            txt_pde.Size = new Size(125, 27);
            txt_pde.TabIndex = 4;
            // 
            // txt_pIN
            // 
            txt_pIN.Location = new Point(6, 221);
            txt_pIN.Name = "txt_pIN";
            txt_pIN.Size = new Size(125, 27);
            txt_pIN.TabIndex = 5;
            // 
            // btn_kayGet
            // 
            btn_kayGet.Location = new Point(274, 64);
            btn_kayGet.Name = "btn_kayGet";
            btn_kayGet.Size = new Size(94, 29);
            btn_kayGet.TabIndex = 11;
            btn_kayGet.Text = "Kayıt Getir";
            btn_kayGet.UseVisualStyleBackColor = true;
            btn_kayGet.Click += button2_Click;
            // 
            // btn_arama
            // 
            btn_arama.Location = new Point(274, 125);
            btn_arama.Name = "btn_arama";
            btn_arama.Size = new Size(94, 29);
            btn_arama.TabIndex = 12;
            btn_arama.Text = "Arama";
            btn_arama.UseVisualStyleBackColor = true;
            btn_arama.Click += button3_Click;
            // 
            // btn_deg
            // 
            btn_deg.Location = new Point(274, 218);
            btn_deg.Name = "btn_deg";
            btn_deg.Size = new Size(94, 29);
            btn_deg.TabIndex = 13;
            btn_deg.Text = "Değiştir";
            btn_deg.UseVisualStyleBackColor = true;
            btn_deg.Click += button4_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 326);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 16;
            // 
            // chk_il
            // 
            chk_il.AutoSize = true;
            chk_il.Location = new Point(12, 384);
            chk_il.Name = "chk_il";
            chk_il.Size = new Size(82, 24);
            chk_il.TabIndex = 17;
            chk_il.Text = "IsActive";
            chk_il.UseVisualStyleBackColor = true;
            // 
            // chk_ik
            // 
            chk_ik.AutoSize = true;
            chk_ik.Location = new Point(120, 384);
            chk_ik.Name = "chk_ik";
            chk_ik.Size = new Size(79, 24);
            chk_ik.TabIndex = 18;
            chk_ik.Text = "Gender";
            chk_ik.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(374, 202);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(414, 236);
            dataGridView1.TabIndex = 19;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToOrderColumns = true;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(374, 8);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(414, 188);
            dataGridView2.TabIndex = 20;
            // 
            // btn_sil
            // 
            btn_sil.Location = new Point(274, 281);
            btn_sil.Name = "btn_sil";
            btn_sil.Size = new Size(94, 29);
            btn_sil.TabIndex = 21;
            btn_sil.Text = "Sil";
            btn_sil.UseVisualStyleBackColor = true;
            btn_sil.Click += button1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(85, 285);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 22;
            label1.Text = "Doğum Tarihi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 31);
            label5.Name = "label5";
            label5.Size = new Size(76, 20);
            label5.TabIndex = 26;
            label5.Text = "FirstName";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 92);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
            label6.TabIndex = 27;
            label6.Text = "LastName";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(7, 148);
            label7.Name = "label7";
            label7.Size = new Size(82, 20);
            label7.TabIndex = 28;
            label7.Text = "ID Number";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 201);
            label8.Name = "label8";
            label8.Size = new Size(89, 20);
            label8.TabIndex = 29;
            label8.Text = "Department";
            // 
            // txt_pdm
            // 
            txt_pdm.Location = new Point(137, 118);
            txt_pdm.Name = "txt_pdm";
            txt_pdm.Size = new Size(125, 27);
            txt_pdm.TabIndex = 8;
            // 
            // txt_pmm
            // 
            txt_pmm.Location = new Point(137, 171);
            txt_pmm.Name = "txt_pmm";
            txt_pmm.Size = new Size(125, 27);
            txt_pmm.TabIndex = 9;
            // 
            // txt_pda
            // 
            txt_pda.Location = new Point(137, 224);
            txt_pda.Name = "txt_pda";
            txt_pda.Size = new Size(125, 27);
            txt_pda.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(137, 92);
            label9.Name = "label9";
            label9.Size = new Size(46, 20);
            label9.TabIndex = 30;
            label9.Text = "Email";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(137, 148);
            label10.Name = "label10";
            label10.Size = new Size(50, 20);
            label10.TabIndex = 31;
            label10.Text = "Phone";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(137, 201);
            label11.Name = "label11";
            label11.Size = new Size(62, 20);
            label11.TabIndex = 32;
            label11.Text = "Address";
            // 
            // Ana
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(btn_sil);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(chk_ik);
            Controls.Add(chk_il);
            Controls.Add(dateTimePicker1);
            Controls.Add(btn_deg);
            Controls.Add(btn_arama);
            Controls.Add(btn_kayGet);
            Controls.Add(txt_pda);
            Controls.Add(txt_pmm);
            Controls.Add(txt_pdm);
            Controls.Add(txt_pIN);
            Controls.Add(txt_pde);
            Controls.Add(txt_plna);
            Controls.Add(txt_pna);
            Controls.Add(btn_kayit);
            Name = "Ana";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_kayit;
        private TextBox txt_pna;
        private TextBox txt_plna;
        private TextBox txt_pde;
        private TextBox txt_pIN;
        private Button btn_kayGet;
        private Button btn_arama;
        private Button btn_deg;
        private DateTimePicker dateTimePicker1;
        private CheckBox chk_il;
        private CheckBox chk_ik;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Button btn_sil;
        private Label label1;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txt_pdm;
        private TextBox txt_pmm;
        private TextBox txt_pda;
        private Label label9;
        private Label label10;
        private Label label11;
    }
}
