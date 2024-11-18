namespace Personel.EFCore.UI
{
    partial class Form4
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
            cmb_tab = new ComboBox();
            cmb_sut = new ComboBox();
            txt_ArSi = new TextBox();
            btn_kayget = new Button();
            dataGridView2 = new DataGridView();
            dataGridView1 = new DataGridView();
            btn_sil = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // cmb_tab
            // 
            cmb_tab.FormattingEnabled = true;
            cmb_tab.Location = new Point(88, 61);
            cmb_tab.Name = "cmb_tab";
            cmb_tab.Size = new Size(151, 28);
            cmb_tab.TabIndex = 11;
            cmb_tab.SelectedIndexChanged += cmb_tab_SelectedIndexChanged;
            // 
            // cmb_sut
            // 
            cmb_sut.FormattingEnabled = true;
            cmb_sut.Location = new Point(245, 61);
            cmb_sut.Name = "cmb_sut";
            cmb_sut.Size = new Size(151, 28);
            cmb_sut.TabIndex = 10;
            cmb_sut.SelectedIndexChanged += cmb_sut_SelectedIndexChanged;
            // 
            // txt_ArSi
            // 
            txt_ArSi.Location = new Point(402, 62);
            txt_ArSi.Name = "txt_ArSi";
            txt_ArSi.Size = new Size(125, 27);
            txt_ArSi.TabIndex = 9;
            // 
            // btn_kayget
            // 
            btn_kayget.Location = new Point(533, 61);
            btn_kayget.Name = "btn_kayget";
            btn_kayget.Size = new Size(94, 29);
            btn_kayget.TabIndex = 8;
            btn_kayget.Text = "Kayıt Getir";
            btn_kayget.UseVisualStyleBackColor = true;
            btn_kayget.Click += button1_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(402, 155);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(386, 279);
            dataGridView2.TabIndex = 7;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 155);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(384, 279);
            dataGridView1.TabIndex = 6;
            // 
            // btn_sil
            // 
            btn_sil.Location = new Point(633, 61);
            btn_sil.Name = "btn_sil";
            btn_sil.Size = new Size(94, 29);
            btn_sil.TabIndex = 12;
            btn_sil.Text = "Sil";
            btn_sil.UseVisualStyleBackColor = true;
            btn_sil.Click += btn_sil_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(134, 28);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 13;
            label1.Text = "Tablo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(293, 28);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 14;
            label2.Text = "Sutun";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(391, 28);
            label3.Name = "label3";
            label3.Size = new Size(153, 20);
            label3.TabIndex = 15;
            label3.Text = "Silinecek ID Numarası";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(179, 116);
            label4.Name = "label4";
            label4.Size = new Size(451, 20);
            label4.TabIndex = 16;
            label4.Text = "NOT: KAYIT SILMEK ICIN SADECE ID NUMARASINI YAZMALISINIZ !!";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_sil);
            Controls.Add(cmb_tab);
            Controls.Add(cmb_sut);
            Controls.Add(txt_ArSi);
            Controls.Add(btn_kayget);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Name = "Form4";
            Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmb_tab;
        private ComboBox cmb_sut;
        private TextBox txt_ArSi;
        private Button btn_kayget;
        private DataGridView dataGridView2;
        private DataGridView dataGridView1;
        private Button btn_sil;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}