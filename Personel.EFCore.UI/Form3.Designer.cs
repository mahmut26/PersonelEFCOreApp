namespace Personel.EFCore.UI
{
    partial class Form3
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
            cmb_Tablo = new ComboBox();
            cmb_Sutun = new ComboBox();
            txt_aranacak = new TextBox();
            btn_sor = new Button();
            dataGridView1 = new DataGridView();
            cmb_tab = new ComboBox();
            cmb_sut = new ComboBox();
            txt_degis = new TextBox();
            btn_isle = new Button();
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            txt_degdeg = new TextBox();
            dataGridView2 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // cmb_Tablo
            // 
            cmb_Tablo.FormattingEnabled = true;
            cmb_Tablo.Location = new Point(18, 52);
            cmb_Tablo.Name = "cmb_Tablo";
            cmb_Tablo.Size = new Size(151, 28);
            cmb_Tablo.TabIndex = 11;
            cmb_Tablo.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // cmb_Sutun
            // 
            cmb_Sutun.FormattingEnabled = true;
            cmb_Sutun.Location = new Point(261, 52);
            cmb_Sutun.Name = "cmb_Sutun";
            cmb_Sutun.Size = new Size(151, 28);
            cmb_Sutun.TabIndex = 10;
            // 
            // txt_aranacak
            // 
            txt_aranacak.Location = new Point(465, 54);
            txt_aranacak.Name = "txt_aranacak";
            txt_aranacak.Size = new Size(125, 27);
            txt_aranacak.TabIndex = 9;
            // 
            // btn_sor
            // 
            btn_sor.Location = new Point(660, 52);
            btn_sor.Name = "btn_sor";
            btn_sor.Size = new Size(94, 29);
            btn_sor.TabIndex = 8;
            btn_sor.Text = "Sorgu";
            btn_sor.UseVisualStyleBackColor = true;
            btn_sor.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(41, 163);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(342, 194);
            dataGridView1.TabIndex = 6;
            // 
            // cmb_tab
            // 
            cmb_tab.FormattingEnabled = true;
            cmb_tab.Location = new Point(7, 62);
            cmb_tab.Name = "cmb_tab";
            cmb_tab.Size = new Size(151, 28);
            cmb_tab.TabIndex = 15;
            cmb_tab.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // cmb_sut
            // 
            cmb_sut.FormattingEnabled = true;
            cmb_sut.Location = new Point(197, 62);
            cmb_sut.Name = "cmb_sut";
            cmb_sut.Size = new Size(151, 28);
            cmb_sut.TabIndex = 14;
            // 
            // txt_degis
            // 
            txt_degis.Location = new Point(534, 63);
            txt_degis.Name = "txt_degis";
            txt_degis.Size = new Size(125, 27);
            txt_degis.TabIndex = 13;
            // 
            // btn_isle
            // 
            btn_isle.Location = new Point(666, 60);
            btn_isle.Name = "btn_isle";
            btn_isle.Size = new Size(94, 29);
            btn_isle.TabIndex = 12;
            btn_isle.Text = "İşle";
            btn_isle.UseVisualStyleBackColor = true;
            btn_isle.Click += button2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cmb_Tablo);
            groupBox1.Controls.Add(cmb_Sutun);
            groupBox1.Controls.Add(txt_aranacak);
            groupBox1.Controls.Add(btn_sor);
            groupBox1.Location = new Point(41, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(760, 118);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Bul ve Getir";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(465, 31);
            label3.Name = "label3";
            label3.Size = new Size(124, 20);
            label3.TabIndex = 14;
            label3.Text = "Aranacak \"Metin\"";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(313, 30);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 13;
            label2.Text = "Sutun";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 30);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 12;
            label1.Text = "Tablo";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txt_degdeg);
            groupBox2.Controls.Add(cmb_tab);
            groupBox2.Controls.Add(cmb_sut);
            groupBox2.Controls.Add(txt_degis);
            groupBox2.Controls.Add(btn_isle);
            groupBox2.Location = new Point(35, 363);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(766, 131);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            groupBox2.Text = "Değiştir";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(402, 25);
            label7.Name = "label7";
            label7.Size = new Size(91, 20);
            label7.TabIndex = 20;
            label7.Text = "ID Numarası";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(545, 25);
            label6.Name = "label6";
            label6.Size = new Size(101, 20);
            label6.TabIndex = 19;
            label6.Text = "Değişecek Yer";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(249, 25);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 18;
            label5.Text = "Sutun";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(60, 25);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 15;
            label4.Text = "Tablo";
            // 
            // txt_degdeg
            // 
            txt_degdeg.Location = new Point(388, 63);
            txt_degdeg.Name = "txt_degdeg";
            txt_degdeg.Size = new Size(125, 27);
            txt_degdeg.TabIndex = 17;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(453, 163);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(342, 194);
            dataGridView2.TabIndex = 18;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(814, 506);
            Controls.Add(dataGridView2);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmb_Tablo;
        private ComboBox cmb_Sutun;
        private TextBox txt_aranacak;
        private Button btn_sor;
        private DataGridView dataGridView1;
        private ComboBox cmb_tab;
        private ComboBox cmb_sut;
        private TextBox txt_degis;
        private Button btn_isle;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txt_degdeg;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private DataGridView dataGridView2;
    }
}