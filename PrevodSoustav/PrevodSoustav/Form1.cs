namespace PrevodSoustav
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBoxVstup_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(comboBoxVstup.SelectedIndex)
            {
                case 0:
                    //decim�ln�
                    maskedTextBoxVstup.Mask = "0000.0000.0000.0000";
                    break;
                case 1:
                    //bin�rn�
                    textBoxVystup.Text = "1";
                    break;
                case 2:
                    //hexadecim�ln�
                    textBoxVystup.Text = "2";
                    break;
            }
        }

        private void comboBoxVystup_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxIp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void ZmenMasku()
        {
            //ipv4 255.255.255.255 1(8).1(8).1(8).1(8) ff.ff.ff.ff
            //ipv6
        }
    }
}