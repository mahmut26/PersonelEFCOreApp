using Personel.EFCore.UI;

namespace Personel.EFCore.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
          

            string kullaniciAdi = txtKullaniciAdi.Text.Trim();
            string parola = txtParola.Text.Trim();

            if (kullaniciAdi == "admin" && parola == "admin")
            {
                Ana ana = new Ana();
                ana.ShowDialog();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
}
