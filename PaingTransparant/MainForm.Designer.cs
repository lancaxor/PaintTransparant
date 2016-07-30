namespace PaingTransparant
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbWidth = new System.Windows.Forms.TrackBar();
            this.tbHeight = new System.Windows.Forms.TrackBar();
            this.tbOpacity = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.cbSaveProportions = new System.Windows.Forms.CheckBox();
            this.btnShowHideTransparant = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbOpacity)).BeginInit();
            this.SuspendLayout();
            // 
            // tbWidth
            // 
            this.tbWidth.Location = new System.Drawing.Point(59, 47);
            this.tbWidth.Maximum = 2048;
            this.tbWidth.Minimum = 1;
            this.tbWidth.Name = "tbWidth";
            this.tbWidth.Size = new System.Drawing.Size(340, 45);
            this.tbWidth.TabIndex = 0;
            this.tbWidth.TickFrequency = 100;
            this.tbWidth.Value = 1;
            this.tbWidth.Scroll += new System.EventHandler(this.tbWidth_Scroll);
            // 
            // tbHeight
            // 
            this.tbHeight.Location = new System.Drawing.Point(59, 98);
            this.tbHeight.Maximum = 2048;
            this.tbHeight.Minimum = 1;
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.Size = new System.Drawing.Size(342, 45);
            this.tbHeight.TabIndex = 1;
            this.tbHeight.TickFrequency = 100;
            this.tbHeight.Value = 1;
            this.tbHeight.Scroll += new System.EventHandler(this.tbHeight_Scroll);
            // 
            // tbOpacity
            // 
            this.tbOpacity.Location = new System.Drawing.Point(59, 149);
            this.tbOpacity.Maximum = 100;
            this.tbOpacity.Name = "tbOpacity";
            this.tbOpacity.Size = new System.Drawing.Size(340, 45);
            this.tbOpacity.TabIndex = 2;
            this.tbOpacity.TickFrequency = 10;
            this.tbOpacity.Value = 50;
            this.tbOpacity.Scroll += new System.EventHandler(this.tbOpacity_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Height:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Width:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Opacity:";
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(324, 200);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(75, 23);
            this.btnOpenFile.TabIndex = 6;
            this.btnOpenFile.Text = "Open File";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // cbSaveProportions
            // 
            this.cbSaveProportions.AutoSize = true;
            this.cbSaveProportions.Location = new System.Drawing.Point(15, 200);
            this.cbSaveProportions.Name = "cbSaveProportions";
            this.cbSaveProportions.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbSaveProportions.Size = new System.Drawing.Size(106, 17);
            this.cbSaveProportions.TabIndex = 7;
            this.cbSaveProportions.Text = "Save proportions";
            this.cbSaveProportions.UseVisualStyleBackColor = true;
            this.cbSaveProportions.CheckedChanged += new System.EventHandler(this.cbSaveProportions_CheckedChanged);
            // 
            // btnShowHideTransparant
            // 
            this.btnShowHideTransparant.Location = new System.Drawing.Point(12, 12);
            this.btnShowHideTransparant.Name = "btnShowHideTransparant";
            this.btnShowHideTransparant.Size = new System.Drawing.Size(75, 23);
            this.btnShowHideTransparant.TabIndex = 8;
            this.btnShowHideTransparant.Text = ">>";
            this.btnShowHideTransparant.UseVisualStyleBackColor = true;
            this.btnShowHideTransparant.Click += new System.EventHandler(this.btnShowHideTransparant_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 352);
            this.Controls.Add(this.btnShowHideTransparant);
            this.Controls.Add(this.cbSaveProportions);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbOpacity);
            this.Controls.Add(this.tbHeight);
            this.Controls.Add(this.tbWidth);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Picture Control";
            this.TopMost = true;
            this.Move += new System.EventHandler(this.MainForm_Move);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.tbWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbOpacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar tbWidth;
        private System.Windows.Forms.TrackBar tbHeight;
        private System.Windows.Forms.TrackBar tbOpacity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.CheckBox cbSaveProportions;
        private System.Windows.Forms.Button btnShowHideTransparant;
    }
}