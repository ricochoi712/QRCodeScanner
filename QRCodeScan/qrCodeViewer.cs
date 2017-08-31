using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QRCodeScan
{
    public partial class qrCodeViewer : Panel
    {
        int x = 0, y = 0;
        public Timer _timer;

        public qrCodeViewer()
        {
            InitializeComponent();
            /*_timer = new Timer();
            _timer.Start();
            _timer.Interval = 50;
            _timer.Tick += new EventHandler(_timer_Tick);*/
        }

        public void _timer_Tick(object sender, EventArgs e)
        {
            y += 10;
            if (y >= 300)
            {
                y = 0;
            }
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            Graphics g = pe.Graphics;
            g.DrawLine(new Pen(Color.Red, 2f), new Point(0, y), new Point(360, y));
        }
    }
}
