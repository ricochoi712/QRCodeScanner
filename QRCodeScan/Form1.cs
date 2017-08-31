using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;

namespace QRCodeScan
{
    public partial class Form1 : Form
    {
        private Capture cap = null;
        Timer _timer;
        private delegate void InvokeFunction(string msg);
        qrCodeViewer qrRealTime;
        PictureBox _pictureBox = new PictureBox();

        public Form1()
        {
            InitializeComponent();
            _timer = new Timer();
            _timer.Interval = 100;
            qrRealTime = new qrCodeViewer
            {
                Name = "qrCodeScan",
                Size = new Size(360, 280),
                Location = new Point(12, 69),
                BackColor = Color.Gray,
            };
            this.Controls.Add(qrRealTime);
            _pictureBox.Size = new System.Drawing.Size(360, 280);
            _pictureBox.Location = new Point(0, 0);
            _pictureBox.SendToBack();
            qrRealTime.Controls.Add(_pictureBox);
        }

        private void TrueFunction(string msg)
        {
            //this.qrCodeText.Text = msg;
            MessageBox.Show(msg);
        } 

        private void TimerEventProcessor(object sender, EventArgs e)
        {
            Image<Bgr, Byte> frame = new Image<Bgr, Byte>(360, 280);
            frame = cap.QueryFrame();
            _pictureBox.Image = frame.ToBitmap();

            ZXing.IBarcodeReader reader = new ZXing.BarcodeReader();

            ZXing.Result result = reader.Decode(frame.ToBitmap());

            qrRealTime._timer.Tick += new EventHandler(qrRealTime._timer_Tick);

            if (result != null)
            {
                _timer.Stop();
                _pictureBox.Image = null;
                MessageBox.Show(result.Text);
                qrRealTime._timer.Stop();
            }
        }

        private void openWebCam()
        {
            if (cap == null)
            {
                try
                {
                    cap = new Capture();
                }
                catch (NullReferenceException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void readQR_Click(object sender, EventArgs e)
        {
            openWebCam();
            _timer.Start();
            _timer.Tick += new EventHandler(TimerEventProcessor);
            qrRealTime._timer = new Timer();
            qrRealTime._timer.Start();
            qrRealTime._timer.Interval = 50;
            qrRealTime._timer.Tick += new EventHandler(qrRealTime._timer_Tick);
        }
    }
}
