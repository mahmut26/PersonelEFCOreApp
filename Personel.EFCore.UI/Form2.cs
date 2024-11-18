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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            cmb_tabl.Items.Add("Personel");
            cmb_tabl.Items.Add("PersonelDetail");



        }

        private void button1_Click(object sender, EventArgs e)
        {

            Personel.EFCore.BAL.BAL businessLayer = new Personel.EFCore.BAL.BAL();

            object sut = cmb_sutun.SelectedItem;
            object tab = cmb_tabl.SelectedItem;

            object ara = txt_ara.Text;
            (dataGridView1.DataSource,dataGridView2.DataSource) = businessLayer.Arama(ara.ToString(), tab.ToString(), sut.ToString());
             
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_tabl.SelectedIndex == 0)
            {
                cmb_sutun.Items.Clear();
                
                cmb_sutun.Items.Add("FirstName");
                cmb_sutun.Items.Add("LastName");
                cmb_sutun.Items.Add("IdentityNumber");
                cmb_sutun.Items.Add("Department");
            }
            else if (cmb_tabl.SelectedIndex == 1) 
            {
                cmb_sutun.Items.Clear();
                
                cmb_sutun.Items.Add("Email");
                cmb_sutun.Items.Add("Phone");
                cmb_sutun.Items.Add("Address");
            }
        }
    }
}
