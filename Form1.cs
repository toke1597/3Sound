using AudioSwitcher.AudioApi.CoreAudio;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace _3Sound
{
    public partial class Form1 : Form
    {
        public static double Volume { get; set; }

        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex= 3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int volume1 = comboBox1.SelectedIndex;

            CoreAudioDevice defaultPlaybackDevice = new CoreAudioController().DefaultPlaybackDevice;
            defaultPlaybackDevice.Volume = volume1;
            label2.Text = "Current Volume:" + defaultPlaybackDevice.Volume;
                
            

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }
    }
}
