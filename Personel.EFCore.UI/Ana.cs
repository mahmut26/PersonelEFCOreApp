using Personel.EFCore.BAL;
using Personel.EFCore.Domain;
using System.Drawing;
using System;
using Microsoft.Extensions.Options;

namespace Personel.EFCore.UI
{
    public partial class Ana : Form
    {
        public Personel.EFCore.Domain.Personel Personel = new Domain.Personel();
        public PersonelDetail PersonelDetail = new PersonelDetail();
        public Ana()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Personel.FirstName = txt_pna.Text;
                Personel.LastName = txt_plna.Text;
                Personel.IdentityNumber = txt_pIN.Text;
                Personel.Department = txt_pdm.Text;

                DateTime? myDate = dateTimePicker1.Value.Date;
                Personel.BirthDate = myDate;

                if (chk_il.Checked == true)
                {
                    Personel.IsActive = true;
                }
                if (chk_ik.Checked == true)
                {
                    Personel.Gender = true;
                }


                PersonelDetail.Email = txt_pdm.Text;
                PersonelDetail.Phone = txt_pmm.Text;
                PersonelDetail.Address = txt_pda.Text;


                Personel.EFCore.BAL.BAL businessLayer = new Personel.EFCore.BAL.BAL();


                businessLayer.SQLYAZ(Personel);
                int c = businessLayer.IndexBul();
                int d = c;
                PersonelDetail.PersonelID = d;
                businessLayer.SQLYAZ(PersonelDetail);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir Hata Oluþtu {ex.Message} - Programý Tekrardan baþlatýnýz. Sorun aynýsýný tekrardan giriþ yapmanýzdan kaynaklanýyor olabilir !!");

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Personel.EFCore.BAL.BAL businessLayer = new Personel.EFCore.BAL.BAL();
            
            (dataGridView1.DataSource,dataGridView2.DataSource) = businessLayer.Yazdýr();
             
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
