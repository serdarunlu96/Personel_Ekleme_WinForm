using System.Text;

namespace Personel_Ekleme_WinForm
{
    public partial class Form1 : Form
    {
        List<Personel> kisiler = new List<Personel>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbDepartmanlar.Items.AddRange(Enum.GetNames(typeof(Departman)));
            cmbDepartmanlar.SelectedIndex = 0;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Personel yeniPersonel = new Personel()
            {
                Ad = txtAd.Text,
                Bolum = (Departman)Enum.Parse(typeof(Departman), cmbDepartmanlar.Text)
            };
            kisiler.Add(yeniPersonel);
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var kisi in kisiler)
            {
                sb.AppendLine(kisi.Ad + " " + kisi.Bolum);

                MessageBox.Show(sb.ToString());
            }
        }
    }
}