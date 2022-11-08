namespace Changing_Opacity
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.imgSlimer = new System.Windows.Forms.PictureBox();
            this.btnFadeIn = new System.Windows.Forms.Button();
            this.btnFadeOut = new System.Windows.Forms.Button();
            this.btnAppear = new System.Windows.Forms.Button();
            this.tmrFadeOut = new System.Windows.Forms.Timer(this.components);
            this.tmrFadeIn = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imgSlimer)).BeginInit();
            this.SuspendLayout();
            // 
            // imgSlimer
            // 
            this.imgSlimer.BackColor = System.Drawing.Color.Transparent;
            this.imgSlimer.Image = global::Changing_Opacity.Properties.Resources.slimer;
            this.imgSlimer.Location = new System.Drawing.Point(119, 10);
            this.imgSlimer.Name = "imgSlimer";
            this.imgSlimer.Size = new System.Drawing.Size(283, 274);
            this.imgSlimer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgSlimer.TabIndex = 0;
            this.imgSlimer.TabStop = false;
            // 
            // btnFadeIn
            // 
            this.btnFadeIn.Location = new System.Drawing.Point(12, 10);
            this.btnFadeIn.Name = "btnFadeIn";
            this.btnFadeIn.Size = new System.Drawing.Size(75, 23);
            this.btnFadeIn.TabIndex = 1;
            this.btnFadeIn.Text = "Fade In";
            this.btnFadeIn.UseVisualStyleBackColor = true;
            this.btnFadeIn.Click += new System.EventHandler(this.btnFadeIn_Click);
            // 
            // btnFadeOut
            // 
            this.btnFadeOut.Location = new System.Drawing.Point(12, 49);
            this.btnFadeOut.Name = "btnFadeOut";
            this.btnFadeOut.Size = new System.Drawing.Size(75, 23);
            this.btnFadeOut.TabIndex = 2;
            this.btnFadeOut.Text = "Fade Out";
            this.btnFadeOut.UseVisualStyleBackColor = true;
            this.btnFadeOut.Click += new System.EventHandler(this.btnFadeOut_Click);
            // 
            // btnAppear
            // 
            this.btnAppear.Location = new System.Drawing.Point(12, 92);
            this.btnAppear.Name = "btnAppear";
            this.btnAppear.Size = new System.Drawing.Size(75, 23);
            this.btnAppear.TabIndex = 3;
            this.btnAppear.Text = "Appear";
            this.btnAppear.UseVisualStyleBackColor = true;
            this.btnAppear.Click += new System.EventHandler(this.btnAppear_Click);
            // 
            // tmrFadeOut
            // 
            this.tmrFadeOut.Tick += new System.EventHandler(this.tmrFadeOut_Tick);
            // 
            // tmrFadeIn
            // 
            this.tmrFadeIn.Tick += new System.EventHandler(this.tmrFadeIn_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Changing_Opacity.Properties.Resources.haunted_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(492, 322);
            this.Controls.Add(this.btnAppear);
            this.Controls.Add(this.btnFadeOut);
            this.Controls.Add(this.btnFadeIn);
            this.Controls.Add(this.imgSlimer);
            this.Name = "Form1";
            this.Text = "Changing Opacity";
            ((System.ComponentModel.ISupportInitialize)(this.imgSlimer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox imgSlimer;
        private Button btnFadeIn;
        private Button btnFadeOut;
        private Button btnAppear;
        private System.Windows.Forms.Timer tmrFadeOut;
        private System.Windows.Forms.Timer tmrFadeIn;
    }
}