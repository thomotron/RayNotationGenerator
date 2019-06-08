using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace RayNotationGenerator
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        public void Encode()
        {
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(textbox.Text);
            List<Image> images = new List<Image>();

            int imageSize = (int) SizeSelect.Value;

            int iter = 1;

            foreach (byte b in bytes)
            {
                // Create a new image
                Image img = new Bitmap(imageSize, imageSize);

                Graphics drawing = Graphics.FromImage(img);

                // Paint the background
                drawing.Clear(Color.FromArgb(0, 33, 33, 33));

                // QR-like rectangles
                Point centre     = new Point(img.Width / 2, img.Height / 2);

                Point pos0Finish    = new Point(img.Width/2     , 0             );
                Point pos1Finish    = new Point(img.Width       , 0             );
                Point pos2Finish    = new Point(img.Width       , img.Height/2  );
                Point pos3Finish    = new Point(img.Width       , img.Height    );
                Point pos4Finish    = new Point(img.Width/2     , img.Height    );
                Point pos5Finish    = new Point(0               , img.Height    );
                Point pos6Finish    = new Point(0               , img.Height/2  );
                Point pos7Finish    = new Point(0               , 0             );
                
                // Determine what colour everything is
                Pen pos0C = (b & (1 << 0)) != 0 ? new Pen(Color.FromArgb(255, 0, 0, 0), imageSize/10) : new Pen(Color.FromArgb(0, 0, 0, 0), imageSize / 10);
                Pen pos1C = (b & (1 << 1)) != 0 ? new Pen(Color.FromArgb(255, 0, 0, 0), imageSize / 10) : new Pen(Color.FromArgb(0, 0, 0, 0), imageSize / 10);
                Pen pos2C = (b & (1 << 2)) != 0 ? new Pen(Color.FromArgb(255, 0, 0, 0), imageSize / 10) : new Pen(Color.FromArgb(0, 0, 0, 0), imageSize / 10);
                Pen pos3C = (b & (1 << 3)) != 0 ? new Pen(Color.FromArgb(255, 0, 0, 0), imageSize / 10) : new Pen(Color.FromArgb(0, 0, 0, 0), imageSize / 10);
                Pen pos4C = (b & (1 << 4)) != 0 ? new Pen(Color.FromArgb(255, 0, 0, 0), imageSize / 10) : new Pen(Color.FromArgb(0, 0, 0, 0), imageSize / 10);
                Pen pos5C = (b & (1 << 5)) != 0 ? new Pen(Color.FromArgb(255, 0, 0, 0), imageSize / 10) : new Pen(Color.FromArgb(0, 0, 0, 0), imageSize / 10);
                Pen pos6C = (b & (1 << 6)) != 0 ? new Pen(Color.FromArgb(255, 0, 0, 0), imageSize / 10) : new Pen(Color.FromArgb(0, 0, 0, 0), imageSize / 10);
                Pen pos7C = (b & (1 << 7)) != 0 ? new Pen(Color.FromArgb(255, 0, 0, 0), imageSize / 10) : new Pen(Color.FromArgb(0, 0, 0, 0), imageSize / 10);

                // Draw rectangles and text
                drawing.DrawLine(pos0C, centre, pos0Finish);
                drawing.DrawLine(pos1C, centre, pos1Finish);
                drawing.DrawLine(pos2C, centre, pos2Finish);
                drawing.DrawLine(pos3C, centre, pos3Finish);
                drawing.DrawLine(pos4C, centre, pos4Finish);
                drawing.DrawLine(pos5C, centre, pos5Finish);
                drawing.DrawLine(pos6C, centre, pos6Finish);
                drawing.DrawLine(pos7C, centre, pos7Finish);

                // Finalise drawing
                drawing.Save();

                // Dispose of unused objects
                pos0C.Dispose();
                pos1C.Dispose();
                pos2C.Dispose();
                pos3C.Dispose();
                pos4C.Dispose();
                pos5C.Dispose();
                pos6C.Dispose();
                pos7C.Dispose();

                drawing.Dispose();

                images.Add(img);

                iter++;
            }



            Image combined = new Bitmap((images.Count * imageSize) + (images.Count * (imageSize / 8)), imageSize);
            Graphics combinedDrawing = Graphics.FromImage(combined);

            int x = 0;
            foreach (Image img in images)
            {
                combinedDrawing.DrawImage(img, x, 0);
                x += imageSize + imageSize / 8;
            }
            combinedDrawing.Save();
            combinedDrawing.Dispose();

            FileDialog fd = new SaveFileDialog();
            fd.Filter = "PNG|*.png";
            fd.ShowDialog();

           combined.Save(fd.FileName, System.Drawing.Imaging.ImageFormat.Png);
        }

        private void Encode(object sender, EventArgs e)
        {
            if (textbox.Text == "")
            {
                MessageBox.Show("Enter something to encode!");
            } else
            {
                Encode();
            }
        }
    }
}
