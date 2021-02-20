using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TV
{
   
    class Television
    {

        private int _channel;
        private int _volume;
        public int Channel { get; set; }
        public int Volume { get; set; }

        public Television(int channel, int volume)
        {
            this.Channel = channel;
            this.Volume = volume;


        }


        public void IncreaseChannel()
        {
           
            Channel++;
           

        }
        public void DecreaseChannel()
        {
           
            Channel--;
        }

        public void IncreaseVolume()
        {
           
            Volume++;

        }
        public void DecreaseVolume()
        {
            
            Volume--;
        }

       public virtual string ShowData()
        {
            return "Channel:" + Channel + "Volume" + Volume.ToString();

        }








    }
}
