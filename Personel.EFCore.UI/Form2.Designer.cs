namespace Personel.EFCore.UI
{
    partial class Form2
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
            dataGridView1 = new DataGridView();
            btn_KayitGet = new Button();
            txt_ara = new TextBox();
            cmb_sutun = new ComboBox();
            cmb_tabl = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dataGridView2 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 144);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(385, 294);
            dataGridView1.TabIndex = 0;
            // 
            // btn_KayitGet
            // 
            btn_KayitGet.Location = new Point(534, 38);
            btn_KayitGet.Name = "btn_KayitGet";
            btn_KayitGet.Size = new Size(94, 29);
            btn_KayitGet.TabIndex = 2;
            btn_KayitGet.Text = "Kayıt Getir";
            btn_KayitGet.UseVisualStyleBackColor = true;
            btn_KayitGet.Click += button1_Click;
            // 
            // txt_ara
            // 
            txt_ara.Location = new Point(403, 38);
            txt_ara.Name = "txt_ara";
            txt_ara.Size = new Size(125, 27);
            txt_ara.TabIndex = 3;
            // 
            // cmb_sutun
            // 
            cmb_sutun.FormattingEnabled = true;
            cmb_sutun.Location = new Point(246, 37);
            cmb_sutun.Name = "cmb_sutun";
            cmb_sutun.Size = new Size(151, 28);
            cmb_sutun.TabIndex = 4;
            // 
            // cmb_tabl
            // 
            cmb_tabl.FormattingEnabled = true;
            cmb_tabl.Location = new Point(89, 37);
            cmb_tabl.Name = "cmb_tabl";
            cmb_tabl.Size = new Size(151, 28);
            cmb_tabl.TabIndex = 5;
            cmb_tabl.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(126, 9);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 6;
            label1.Text = "Tablo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(288, 9);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 7;
            label2.Text = "Sutun";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(404, 9);
            label3.Name = "label3";
            label3.Size = new Size(124, 20);
            label3.TabIndex = 8;
            label3.Text = "Aranacak \"Metin\"";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(413, 144);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(385, 294);
            dataGridView2.TabIndex = 9;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmb_tabl);
            Controls.Add(cmb_sutun);
            Controls.Add(txt_ara);
            Controls.Add(btn_KayitGet);
            Controls.Add(dataGridView1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btn_KayitGet;
        private TextBox txt_ara;
        private ComboBox cmb_sutun;
        private ComboBox cmb_tabl;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView dataGridView2;
    }
}