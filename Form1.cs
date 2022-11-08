using Changing_Opacity.Properties;
using System.Drawing.Imaging;

namespace Changing_Opacity
{
    public partial class Form1 : Form
    {
        int opacity = 255;
        public Form1()
        {
            InitializeComponent();
        }


        static Bitmap SetAlpha(Bitmap bmpIn, int alpha)
        {
            Bitmap bmpOut = new Bitmap(bmpIn.Width, bmpIn.Height);
            float a = alpha / 255f;
            Rectangle r = new Rectangle(0, 0, bmpIn.Width, bmpIn.Height);

            float[][] matrixItems = {
        new float[] {1, 0, 0, 0, 0},
        new float[] {0, 1, 0, 0, 0},
        new float[] {0, 0, 1, 0, 0},
        new float[] {0, 0, 0, a, 0},
        new float[] {0, 0, 0, 0, 1}};

            ColorMatrix colorMatrix = new ColorMatrix(matrixItems);

            ImageAttributes imageAtt = new ImageAttributes();
            imageAtt.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

            using (Graphics g = Graphics.FromImage(bmpOut))
                g.DrawImage(bmpIn, r, r.X, r.Y, r.Width, r.Height, GraphicsUnit.Pixel, imageAtt);

            return bmpOut;
        }

       
        private void btnFadeOut_Click(object sender, EventArgs e)
        {
            if (!tmrFadeIn.Enabled)     // Only allows this if it is not already fading in
                tmrFadeOut.Enabled = true;
        }

        private void btnFadeIn_Click(object sender, EventArgs e)
        {
            if (!tmrFadeOut.Enabled)    // Only allows this if it is not already fading out
                tmrFadeIn.Enabled = true;
        }

        private void btnAppear_Click(object sender, EventArgs e)
        {
            if (!tmrFadeIn.Enabled && !tmrFadeOut.Enabled)
            {
                imgSlimer.Image.Dispose();
                imgSlimer.Image = Resources.slimer;
                opacity = 255;
            }
            
        }

        private void tmrFadeOut_Tick(object sender, EventArgs e)
        {
            opacity -= 15;
            if (opacity < 0)    // Ensure opacity never drops below zero
            {
                opacity = 0;
                tmrFadeOut.Enabled = false;
            }
               
            imgSlimer.Image = SetAlpha(Resources.slimer, opacity);
        
        
        }

        private void tmrFadeIn_Tick(object sender, EventArgs e)
        {
            opacity += 15;
            if (opacity > 255)    // Ensure opacity never drops below zero
            {
                opacity = 255;
                tmrFadeIn.Enabled = false;
            }

            imgSlimer.Image = SetAlpha(Resources.slimer, opacity);
        }
    }
}