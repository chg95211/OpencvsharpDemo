using OpenCvSharp;
using OpenCvSharp.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpencvsharpDemo
{
    public partial class Form1 : Form
    {
        private Rect select;
        private bool select_flag = false;
        private Mat img, showImg;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "请选择文件夹";
            dialog.Filter = "所有文件(*.*)|*.*";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                openfile(dialog.FileName);
            }
        }

        private void openfile(string fileName)
        {
            img = new Mat(fileName, ImreadModes.GrayScale);
            showImg = img.Clone();
            Mat dst = new Mat();
            IntPtr ptr = img.Ptr(0);
            Cv2.Canny(img, dst, 50, 200);
            pictureBox1.Image = img.ToBitmap();
            using (new Window("src image", showImg))
            using (new Window("dst image", dst))
            {
                Cv2.SetMouseCallback("src image", onMouse);
                //Cv2.WaitKey();
            }
        }

        private void onMouse(MouseEvent @event, int x, int y, MouseEvent flags)
        {
            Point p1, p2;
            if (@event == MouseEvent.LButtonDown)
            {
                select.X = x;
                select.Y = y;
                select_flag = true;
            }
            else if (select_flag && @event == MouseEvent.MouseMove)
            {
                img.CopyTo(showImg);
                p1 = new Point(select.X, select.Y);
                p2 = new Point(x, y);
                Cv2.Rectangle(showImg, p1, p2, Scalar.FromRgb(0, 255, 0), 2);
                Cv2.ImShow("src image", showImg);
            }
            else if (select_flag && @event == MouseEvent.LButtonUp)

            {
                select_flag = false;
            }
        }
    }
}
