using System;
using System.Windows.Forms;

namespace TcMernisControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            long kimlikNo = long.Parse(txtTC.Text);
            int yil = int.Parse(txtDate.Text);

            bool durum;

            try
            {
                using (TCMernis.KPSPublicSoapClient service = new TCMernis.KPSPublicSoapClient { })
                {
                    durum = service.TCKimlikNoDogrula(kimlikNo, txtName.Text, txtSurname.Text, yil);

                }


            }
            catch (Exception)
            {

                throw;
            }

            MessageBox.Show(durum.ToString());
        }
    }
}
