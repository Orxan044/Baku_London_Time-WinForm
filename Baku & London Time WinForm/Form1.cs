namespace Baku___London_Time_WinForm
{
    public partial class Form1 : Form
    {
        Image imageBaku = Properties.Resources.Baku;
        Image imageLondon = Properties.Resources.London;
        private void BakuImageView()
        {
            lblPicture.Image = imageBaku;
            DateTimeOffset bakuTime = DateTimeOffset.UtcNow.ToOffset(TimeSpan.FromHours(4));
            lblTime.Text = bakuTime.ToString("yyyy-MM-dd HH:mm:ss");
        }
        private void LondonImageView()
        {
            lblPicture.Image = imageLondon;
            DateTimeOffset londonTime = DateTimeOffset.UtcNow.ToOffset(TimeSpan.FromHours(0));
            lblTime.Text = londonTime.ToString("yyyy-MM-dd HH:mm:ss");
        }

        public Form1()
        {
            InitializeComponent();
            BakuImageView();
        }
        private void btnBaku_Click(object sender, EventArgs e)
        {BakuImageView();}

        private void btnLondon_Click(object sender, EventArgs e)
        {LondonImageView();}


    }
}
