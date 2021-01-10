using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace Leitor_QR_Code {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
//baixar referencias do nuget AForge , ZXing.Net in C# .NET Windows Forms Application

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        
        private void Form1_Load(object sender, EventArgs e) {

            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in filterInfoCollection)
                cboCamera.Items.Add(Device.Name);
            cboCamera.SelectedIndex = 0;
            videoCaptureDevice = new VideoCaptureDevice();

        }


        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs) {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void button1_Click(object sender, EventArgs e) {
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cboCamera.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += FinalFrame_NewFrame;
            videoCaptureDevice.Start();
            timer1.Start();
            txtResult.Clear();
        }



        private void timer1_Tick(object sender, EventArgs e) {

            string image = "C:/leitor/visto.png";


            if (pictureBox1.Image != null) {
                BarcodeReader Reader = new BarcodeReader();
                Result result = Reader.Decode((Bitmap)pictureBox1.Image);
                if (result != null) {
                    txtResult.Text = result.ToString();
                    timer1.Stop();

                    if (videoCaptureDevice.IsRunning)
                        videoCaptureDevice.Stop();
                }
            }

        }

        private void btnDecode_Click(object sender, EventArgs e) {
            timer1.Start();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            if (videoCaptureDevice.IsRunning == true)
                videoCaptureDevice.Stop();

        }


    }
}
