using Alturos.Yolo;
using Alturos.Yolo.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace yolo_image_detection
{
    public partial class Form1 : Form
    {
        YoloWrapper yoloWrapper;
        string _fileName;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var configurationDetector = new ConfigurationDetector();
            var config = configurationDetector.Detect();
            yoloWrapper = new YoloWrapper(config);
        }

        private void btn_Image_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                _fileName = openFile.FileName;
                pBox_image.Image = new Bitmap(_fileName);
            }
        }

        private void btn_Detect_Click(object sender, EventArgs e)
        {
            var items = yoloWrapper.Detect(_fileName);
            DrawBorderResult(items.ToList(), _fileName);
        }
        private void DrawBorderResult(List<YoloItem> items, string fileName)
        {
            var image = Image.FromFile(fileName);
            Random rnd = new Random();
            using (var canvas = Graphics.FromImage(image))
            {
                foreach (var item in items)
                {
                    var x = item.X;
                    var y = item.Y;

                    var width = item.Width;
                    var height = item.Height;

                    var confidence = item.Confidence.ToString("P", CultureInfo.InvariantCulture);

                    Color color = Color.FromArgb(200, rnd.Next(100, 200), rnd.Next(100, 200));
                    SolidBrush shadowBrush = new SolidBrush(color);
                    using (Pen pen = new Pen(color, 3))
                    {
                        canvas.DrawRectangle(pen, x, y, width, height);
                        canvas.FillRectangle(shadowBrush, new Rectangle(new Point(x, y), new Size(width, 22)));
                        canvas.DrawString(item.Type + " " + confidence, new Font("Arial", 12), new SolidBrush(Color.White), x, y);
                        canvas.Flush();
                    }
                }
                pBox_image.Image = image;
            }
        }
    }
}
