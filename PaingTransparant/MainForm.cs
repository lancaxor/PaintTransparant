using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace PaingTransparant
{
    public partial class MainForm : Form
    {
        TransparantForm transparant;
        double ratio = 1.0;
        public MainForm()
        {
            InitializeComponent();
            transparant = new TransparantForm();
            transparant.Show();
            this.SetTransparantSizeToMain();
        }

        #region handlers
        private void MainForm_Move(object sender, EventArgs e)
        {
            this.SetTransparantSizeToMain();
        }
        private void MainForm_Resize(object sender, EventArgs e)
        {
            this.SetTransparantSizeToMain();
        }

        private void tbWidth_Scroll(object sender, EventArgs e)
        {
            this.setTransparantWidth();
        }

        private void tbHeight_Scroll(object sender, EventArgs e)
        {
            this.setTransparantHeight();
        }

        private void tbOpacity_Scroll(object sender, EventArgs e)
        {
            this.transparant.Opacity = this.tbOpacity.Value / 100.0;
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPEG|*.jpg| PNG |*.png|Bitmap|*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var image = Image.FromFile(ofd.FileName);
                this.setImage(image);
                
            }
        }
        private void setImage(Image image)
        {
            this.transparant.BackgroundImage = image;

            if (image.Height > 0 && image.Height < this.tbHeight.Maximum && image.Width < this.tbWidth.Maximum && image.Width > 0)
            {
                this.countRatio(image.Width, image.Height);
                this.setTransparantSize(image.Width, image.Height);
            }
        }

        private void cbSaveProportions_CheckedChanged(object sender, EventArgs e)
        {
            this.countRatio();
        }
        #endregion
        private void countRatio(int width = 0, int height = 0)
        {
            if (height == 0 && width == 0)
            {
                this.ratio = (double)this.tbWidth.Value / (double)this.tbHeight.Value;
            }
            else
            {
                this.ratio = (double)width / (double)height;
            }
        }
        private void SetTransparantSizeToMain()
        {
            this.transparant.Left = this.Left - transparant.Width;
            this.transparant.Top = this.Top;
            //transparant.Height = this.Height;
        }

        private void setTransparantWidth(bool manual = false)
        {
            this.transparant.Width = this.tbWidth.Value;

            if (!manual && this.cbSaveProportions.Checked)
            {
                int newHeightValue = (int)(this.tbWidth.Value / this.ratio);
                if (newHeightValue < this.tbHeight.Maximum)
                {
                    this.tbHeight.Value = newHeightValue;
                    this.setTransparantHeight(true);
                }
            }
            this.SetTransparantSizeToMain();
        }

        private void setTransparantHeight(bool manual = false)
        {
            this.transparant.Height = this.tbHeight.Value;
            if (!manual && this.cbSaveProportions.Checked)
            {
                int newWidthValue = (int)(this.tbHeight.Value * this.ratio);
                if (newWidthValue < this.tbWidth.Maximum)
                {
                    this.tbWidth.Value = newWidthValue;
                    this.setTransparantWidth(true);
                }
            }
            this.SetTransparantSizeToMain();
        }

        private void setTransparantSize(int width, int height)
        {
            this.transparant.Width = width;
            this.tbWidth.Value = width;
            this.transparant.Height = height;
            this.tbHeight.Value = height;
            this.SetTransparantSizeToMain();
        }

        private void btnShowHideTransparant_Click(object sender, EventArgs e)
        {
            if (this.transparant.Visible)
            {
                this.transparant.Hide();
                (sender as Button).Text = "<<";
            }
            else
            {
                this.transparant.Show();
                (sender as Button).Text = ">>";
            }
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            string url = tbImageUrl.Text;
            try
            {
                var request = WebRequest.Create(url);
                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                {
                    this.setImage(Bitmap.FromStream(stream));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
