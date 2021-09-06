
namespace ColorPicker
{
     partial class ColorPickerForm
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
               this.pictureBoxRed = new System.Windows.Forms.PictureBox();
               this.pictureBoxBlue = new System.Windows.Forms.PictureBox();
               this.pictureBoxGreen = new System.Windows.Forms.PictureBox();
               this.labelRed0 = new System.Windows.Forms.Label();
               this.labelGreen0 = new System.Windows.Forms.Label();
               this.labelBlue0 = new System.Windows.Forms.Label();
               this.trackBarRed = new System.Windows.Forms.TrackBar();
               this.trackBarGreen = new System.Windows.Forms.TrackBar();
               this.trackBarBlue = new System.Windows.Forms.TrackBar();
               this.labelRed255 = new System.Windows.Forms.Label();
               this.labelGreen255 = new System.Windows.Forms.Label();
               this.labelBlue255 = new System.Windows.Forms.Label();
               this.textBoxRed = new System.Windows.Forms.TextBox();
               this.textBoxGreen = new System.Windows.Forms.TextBox();
               this.textBoxBlue = new System.Windows.Forms.TextBox();
               this.panel1 = new System.Windows.Forms.Panel();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRed)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlue)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGreen)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).BeginInit();
               this.SuspendLayout();
               // 
               // pictureBoxRed
               // 
               this.pictureBoxRed.BackColor = System.Drawing.Color.Red;
               this.pictureBoxRed.Location = new System.Drawing.Point(33, 26);
               this.pictureBoxRed.Name = "pictureBoxRed";
               this.pictureBoxRed.Size = new System.Drawing.Size(34, 34);
               this.pictureBoxRed.TabIndex = 0;
               this.pictureBoxRed.TabStop = false;
               // 
               // pictureBoxBlue
               // 
               this.pictureBoxBlue.BackColor = System.Drawing.Color.Blue;
               this.pictureBoxBlue.Location = new System.Drawing.Point(33, 154);
               this.pictureBoxBlue.Name = "pictureBoxBlue";
               this.pictureBoxBlue.Size = new System.Drawing.Size(32, 32);
               this.pictureBoxBlue.TabIndex = 1;
               this.pictureBoxBlue.TabStop = false;
               // 
               // pictureBoxGreen
               // 
               this.pictureBoxGreen.BackColor = System.Drawing.Color.Lime;
               this.pictureBoxGreen.Location = new System.Drawing.Point(35, 89);
               this.pictureBoxGreen.Name = "pictureBoxGreen";
               this.pictureBoxGreen.Size = new System.Drawing.Size(32, 32);
               this.pictureBoxGreen.TabIndex = 2;
               this.pictureBoxGreen.TabStop = false;
               // 
               // labelRed0
               // 
               this.labelRed0.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
               this.labelRed0.AutoSize = true;
               this.labelRed0.Location = new System.Drawing.Point(95, 43);
               this.labelRed0.Name = "labelRed0";
               this.labelRed0.Size = new System.Drawing.Size(16, 17);
               this.labelRed0.TabIndex = 3;
               this.labelRed0.Text = "0";
               this.labelRed0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
               // 
               // labelGreen0
               // 
               this.labelGreen0.AutoSize = true;
               this.labelGreen0.Location = new System.Drawing.Point(95, 104);
               this.labelGreen0.Name = "labelGreen0";
               this.labelGreen0.Size = new System.Drawing.Size(16, 17);
               this.labelGreen0.TabIndex = 4;
               this.labelGreen0.Text = "0";
               this.labelGreen0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
               // 
               // labelBlue0
               // 
               this.labelBlue0.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
               this.labelBlue0.AutoSize = true;
               this.labelBlue0.Location = new System.Drawing.Point(95, 169);
               this.labelBlue0.Name = "labelBlue0";
               this.labelBlue0.Size = new System.Drawing.Size(16, 17);
               this.labelBlue0.TabIndex = 5;
               this.labelBlue0.Text = "0";
               this.labelBlue0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
               // 
               // trackBarRed
               // 
               this.trackBarRed.Location = new System.Drawing.Point(117, 43);
               this.trackBarRed.Maximum = 255;
               this.trackBarRed.Name = "trackBarRed";
               this.trackBarRed.Size = new System.Drawing.Size(305, 56);
               this.trackBarRed.TabIndex = 6;
               this.trackBarRed.Scroll += new System.EventHandler(this.trackBarRed_Scroll);
               // 
               // trackBarGreen
               // 
               this.trackBarGreen.Location = new System.Drawing.Point(117, 105);
               this.trackBarGreen.Maximum = 255;
               this.trackBarGreen.Name = "trackBarGreen";
               this.trackBarGreen.Size = new System.Drawing.Size(305, 56);
               this.trackBarGreen.TabIndex = 7;
               this.trackBarGreen.Scroll += new System.EventHandler(this.trackBarGreen_Scroll);
               // 
               // trackBarBlue
               // 
               this.trackBarBlue.Location = new System.Drawing.Point(117, 167);
               this.trackBarBlue.Maximum = 255;
               this.trackBarBlue.Name = "trackBarBlue";
               this.trackBarBlue.Size = new System.Drawing.Size(305, 56);
               this.trackBarBlue.TabIndex = 8;
               this.trackBarBlue.Scroll += new System.EventHandler(this.trackBarBlue_Scroll);
               // 
               // labelRed255
               // 
               this.labelRed255.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
               this.labelRed255.AutoSize = true;
               this.labelRed255.Location = new System.Drawing.Point(428, 43);
               this.labelRed255.Name = "labelRed255";
               this.labelRed255.Size = new System.Drawing.Size(32, 17);
               this.labelRed255.TabIndex = 9;
               this.labelRed255.Text = "255";
               this.labelRed255.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
               // 
               // labelGreen255
               // 
               this.labelGreen255.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
               this.labelGreen255.AutoSize = true;
               this.labelGreen255.Location = new System.Drawing.Point(428, 105);
               this.labelGreen255.Name = "labelGreen255";
               this.labelGreen255.Size = new System.Drawing.Size(32, 17);
               this.labelGreen255.TabIndex = 10;
               this.labelGreen255.Text = "255";
               this.labelGreen255.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
               // 
               // labelBlue255
               // 
               this.labelBlue255.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
               this.labelBlue255.AutoSize = true;
               this.labelBlue255.Location = new System.Drawing.Point(428, 169);
               this.labelBlue255.Name = "labelBlue255";
               this.labelBlue255.Size = new System.Drawing.Size(32, 17);
               this.labelBlue255.TabIndex = 11;
               this.labelBlue255.Text = "255";
               this.labelBlue255.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
               // 
               // textBoxRed
               // 
               this.textBoxRed.Location = new System.Drawing.Point(477, 43);
               this.textBoxRed.MaxLength = 3;
               this.textBoxRed.Name = "textBoxRed";
               this.textBoxRed.Size = new System.Drawing.Size(63, 22);
               this.textBoxRed.TabIndex = 12;
               this.textBoxRed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
               this.textBoxRed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRed_KeyPress);
               this.textBoxRed.Leave += new System.EventHandler(this.textBoxRed_Leave);
               // 
               // textBoxGreen
               // 
               this.textBoxGreen.Location = new System.Drawing.Point(477, 105);
               this.textBoxGreen.MaxLength = 3;
               this.textBoxGreen.Name = "textBoxGreen";
               this.textBoxGreen.Size = new System.Drawing.Size(63, 22);
               this.textBoxGreen.TabIndex = 13;
               this.textBoxGreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
               this.textBoxGreen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxGreen_KeyPress);
               this.textBoxGreen.Leave += new System.EventHandler(this.textBoxGreen_Leave);
               // 
               // textBoxBlue
               // 
               this.textBoxBlue.Location = new System.Drawing.Point(477, 169);
               this.textBoxBlue.MaxLength = 3;
               this.textBoxBlue.Name = "textBoxBlue";
               this.textBoxBlue.Size = new System.Drawing.Size(63, 22);
               this.textBoxBlue.TabIndex = 14;
               this.textBoxBlue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
               this.textBoxBlue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBlue_KeyPress);
               this.textBoxBlue.Leave += new System.EventHandler(this.textBoxBlue_Leave);
               // 
               // panel1
               // 
               this.panel1.BackColor = System.Drawing.Color.Black;
               this.panel1.ForeColor = System.Drawing.Color.Black;
               this.panel1.Location = new System.Drawing.Point(266, 229);
               this.panel1.Name = "panel1";
               this.panel1.Size = new System.Drawing.Size(64, 64);
               this.panel1.TabIndex = 16;
               // 
               // ColorPickerForm
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(569, 327);
               this.Controls.Add(this.panel1);
               this.Controls.Add(this.textBoxBlue);
               this.Controls.Add(this.textBoxGreen);
               this.Controls.Add(this.textBoxRed);
               this.Controls.Add(this.labelBlue255);
               this.Controls.Add(this.labelGreen255);
               this.Controls.Add(this.labelRed255);
               this.Controls.Add(this.trackBarBlue);
               this.Controls.Add(this.trackBarGreen);
               this.Controls.Add(this.trackBarRed);
               this.Controls.Add(this.labelBlue0);
               this.Controls.Add(this.labelGreen0);
               this.Controls.Add(this.labelRed0);
               this.Controls.Add(this.pictureBoxGreen);
               this.Controls.Add(this.pictureBoxBlue);
               this.Controls.Add(this.pictureBoxRed);
               this.Name = "ColorPickerForm";
               this.Text = "Color Picker";
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRed)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlue)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGreen)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.PictureBox pictureBoxRed;
          private System.Windows.Forms.PictureBox pictureBoxBlue;
          private System.Windows.Forms.PictureBox pictureBoxGreen;
          private System.Windows.Forms.Label labelRed0;
          private System.Windows.Forms.Label labelGreen0;
          private System.Windows.Forms.Label labelBlue0;
          private System.Windows.Forms.TrackBar trackBarRed;
          private System.Windows.Forms.TrackBar trackBarGreen;
          private System.Windows.Forms.TrackBar trackBarBlue;
          private System.Windows.Forms.Label labelRed255;
          private System.Windows.Forms.Label labelGreen255;
          private System.Windows.Forms.Label labelBlue255;
          private System.Windows.Forms.TextBox textBoxGreen;
          private System.Windows.Forms.TextBox textBoxBlue;
          private System.Windows.Forms.TextBox textBoxRed;
          private System.Windows.Forms.Panel panel1;
     }
}

