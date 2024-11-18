using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Personel.EFCore.UI
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            cmb_tab.Items.Add("Personel");
            cmb_tab.Items.Add("PersonelDetail");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Personel.EFCore.BAL.BAL businessLayer = new Personel.EFCore.BAL.BAL();
            
            object tablo = cmb_tab.SelectedItem;

            object sutun = cmb_sut.SelectedItem;

            string AR = txt_ArSi.Text;
            
            (dataGridView1.DataSource,dataGridView2.DataSource) = businessLayer.Arama(AR, tablo.ToString(),sutun.ToString());


        }
            private void btn_sil_Click(object sender, EventArgs e)
        {
            Personel.EFCore.BAL.BAL businessLayer = new Personel.EFCore.BAL.BAL();

            string input = txt_ArSi.Text;

            if (int.TryParse(input, out int result))
            { MessageBox.Show("işlem yapılıyor"); }
            else
            {
                MessageBox.Show("Hatalı Giriş !!");
            }

            businessLayer.Sil(result);

        }

        private void cmb_sut_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_tab_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_tab.SelectedIndex == 0)
            {
                cmb_sut.Items.Clear();
                
                cmb_sut.Items.Add("FirstName");
                cmb_sut.Items.Add("LastName");
                cmb_sut.Items.Add("IdentityNumber");
                cmb_sut.Items.Add("Department");
            }
            if (cmb_tab.SelectedIndex == 1)
            {
                cmb_sut.Items.Clear();
                
                cmb_sut.Items.Add("Email");
                cmb_sut.Items.Add("Phone");
                cmb_sut.Items.Add("Address");
            }
        }
    }
}
