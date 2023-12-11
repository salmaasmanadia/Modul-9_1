namespace Modul_9_1
{
    public partial class Form1 : Form
    {
        Akun akun1 = new AkunPremium(20000, "hiyahiyahiya");

        public Form1()
        {
            InitializeComponent();
            label1.Text = akun1.Saldo.ToString();
        }

        private void TarikSaldo(int total)
        {
            akun1.Tarik(total);
            label1.Text = akun1.Saldo.ToString();
        }

        private void SetorSaldo(int total)
        {
            akun1.Setor(total);
            label1.Text = akun1.Saldo.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLanjut_Click(object sender, EventArgs e)
        {
            /*//menamahkan event click
            if(rbSetor.Checked)
            {
                SetorSaldo(int.Parse(tbJU.Text));
            }
            else if(rbTarik.Checked)
            {
                TarikSaldo(int.Parse(tbJU.Text));
            }*/

            //ganti dengan memakai method yg sudah dibuat
            if(akun1.PasswordTervalidasi(tbPass.Text))
            {
                if(rbSetor.Checked)
                {
                    SetorSaldo(int.Parse(tbJU.Text));
                }
                else if(rbTarik.Checked)
                {
                    TarikSaldo(int.Parse(tbJU.Text));  
                }
            }
            else
            {
                MessageBox.Show("Password Salah");
            }
        }
    }
}