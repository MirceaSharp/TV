using System;
using System.Windows.Forms;

namespace TV
{
    public partial class TV : Form
    {
        Television TV1 = new Television(0, 0);




        public TV()
        {

            InitializeComponent();
        }

        private void btnIncrease_Click(object sender, EventArgs e)
        {

            if (TV1.Channel == 30)
            {
                MessageBox.Show("Channel cannot be higher than 30");
                if (TV1.Volume != 10)
                {
                    TV1.IncreaseVolume();
                    lblChannelVolume.Text = TV1.ShowData();
                }


                lblChannelVolume.Text = TV1.ShowData();

            }
            else if (TV1.Volume == 10)
            {
                TV1.IncreaseChannel();
                MessageBox.Show("Volume cannot be higher than 10");
                lblChannelVolume.Text = TV1.ShowData();

            }
            else
            {
                TV1.IncreaseChannel();
                TV1.IncreaseVolume();
                lblChannelVolume.Text = TV1.ShowData();

            }




        }

        private void btnDecrease_Click(object sender, EventArgs e)
        {
            if (TV1.Channel == 0)
            {
                if (TV1.Channel == 0 & TV1.Volume == 0)
                {
                    MessageBox.Show("Channel and volume cannot be lower than 0");
                }

                else if (TV1.Volume != 0)
                {
                    MessageBox.Show("Channel cannot be lower than 0");
                    TV1.DecreaseVolume();
                    lblChannelVolume.Text = TV1.ShowData();
                }
                lblChannelVolume.Text = TV1.ShowData();


            }
            else if (TV1.Volume == 0)
            {
                MessageBox.Show("Volume cannot be lower than 0");

                if (TV1.Channel != 0)
                {
                    TV1.DecreaseChannel();
                    lblChannelVolume.Text = TV1.ShowData();
                }
                lblChannelVolume.Text = TV1.ShowData();


            }


            else
            {
                TV1.DecreaseChannel();
                TV1.DecreaseVolume();
                lblChannelVolume.Text = TV1.ShowData();

            }


        }
    }
}
