using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using Emgu.CV;
using Emgu.CV.UI;
using Emgu.CV.Structure;
using Xamarin.Forms;
using Emgu.Util;
using Emgu.CV.Util;


namespace Emg
{
    public class cap
    {

        VideoCapture capture;
        public cap()
        {
            if (capture == null)
            {
                capture = new Emgu.CV.VideoCapture(0);
            }
            capture.ImageGrabbed += Capture_ImageGrabbed;
            capture.Start();
        }

        private void Capture_ImageGrabbed(object sender, EventArgs e)
        {
            try
            {
                ImageBox img = new ImageBox();
               Emgu.CV.Image<Bgr, Byte> imagez = capture.QueryFrame().ToImage<Bgr, Byte>();
            //    img.Image = imagez.ToBitmap();
            //    img.Image = Emgu.CV.IImage(imagez);
            }
            catch (Exception)
            {

            }
        }
    }
    public class Page1 : ContentPage
    {
        public Page1()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello Page" }
                }
            };
        }
    }
}