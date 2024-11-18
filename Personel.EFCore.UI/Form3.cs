using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personel.EFCore.UI
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            

            cmb_Tablo.Items.Add("Personel");
            cmb_Tablo.Items.Add("PersonelDetail");

            cmb_tab.Items.Add("Personel");
            cmb_tab.Items.Add("PersonelDetail");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Personel.EFCore.BAL.BAL businessLayer = new Personel.EFCore.BAL.BAL();

            object sutt = cmb_Sutun.SelectedItem;
            object tabb = cmb_Tablo.SelectedItem;

            (dataGridView1.DataSource,dataGridView2.DataSource) = businessLayer.Arama(txt_aranacak.ToString(), tabb.ToString(),sutt.ToString());

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Tablo.SelectedIndex == 0)
            {
                cmb_Sutun.Items.Clear();
                
                cmb_Sutun.Items.Add("FirstName");
                cmb_Sutun.Items.Add("LastName");
                cmb_Sutun.Items.Add("IdentityNumber");
                cmb_Sutun.Items.Add("Department");
            }
            else if (cmb_Tablo.SelectedIndex == 1)
            {
                cmb_Sutun.Items.Clear();
                
                cmb_Sutun.Items.Add("Email");
                cmb_Sutun.Items.Add("Phone");
                cmb_Sutun.Items.Add("Address");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Personel.EFCore.BAL.BAL businessLayer = new Personel.EFCore.BAL.BAL();

            object sut = cmb_sut.SelectedItem;
            object tab = cmb_tab.SelectedItem;

            string input = txt_degdeg.Text;

            if (int.TryParse(input, out int result))
            { MessageBox.Show("işlem yapılıyor"); }
            else
            {
                MessageBox.Show("Hatalı Giriş !!");
            }
            businessLayer.Degistir(txt_degis.Text, tab.ToString(), sut.ToString(), result);

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_tab.SelectedIndex == 0)
            {
                cmb_sut.Items.Clear();
                
                cmb_sut.Items.Add("FirstName");
                cmb_sut.Items.Add("LastName");
                cmb_sut.Items.Add("IdentityNumber");
                cmb_sut.Items.Add("Department");
            }
            else if (cmb_tab.SelectedIndex == 1)
            {
                cmb_sut.Items.Clear();
                
                cmb_sut.Items.Add("Email");
                cmb_sut.Items.Add("Phone");
                cmb_sut.Items.Add("Address");
            }
        }
    }
}
