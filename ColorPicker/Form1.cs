using System;
using System.Drawing;
using System.Windows.Forms;

//Reddit: u/MDNick2000

namespace ColorPicker
{
     public partial class ColorPickerForm : Form
     {
          //Function that colors that one windows whose color you change
          void PickColor()
          {
               panel1.BackColor = Color.FromArgb(
                    Convert.ToInt32(textBoxRed.Text), 
                    Convert.ToInt32(textBoxGreen.Text), 
                    Convert.ToInt32(textBoxBlue.Text)
                    );
               Refresh();
          }

          //Things here are executed on launch. 
          //Particularly, texts inside tet boxes are set to be the respective slider's value.
          public ColorPickerForm()
          {
               InitializeComponent();
               textBoxRed.Text = trackBarRed.Value.ToString();
               textBoxGreen.Text = trackBarGreen.Value.ToString();
               textBoxBlue.Text = trackBarBlue.Value.ToString();
          }

          //Slider values handlers. 
          private void trackBarRed_Scroll(object sender, EventArgs e)
          {
               textBoxRed.Text = trackBarRed.Value.ToString();
               PickColor();
          }

          private void trackBarGreen_Scroll(object sender, EventArgs e)
          {
               textBoxGreen.Text = trackBarGreen.Value.ToString();
               PickColor();
          }

          private void trackBarBlue_Scroll(object sender, EventArgs e)
          {
               textBoxBlue.Text = trackBarBlue.Value.ToString();
               PickColor();
          }

          //Text box values handlers.
          //Values will be accounted when moving focus from active box or when Enter is pressed.
          //Slider positions will be modified on input.
          //Safety checks: only integer values, only values between 0-255 (0 and 255 included).

          string regex = "^([0-9]{1,2}|1[0-9]{2}|2[0-4][0-9]|25[0-5])$"; //Yeah, I know, I know.
          private void textBoxRed_KeyPress(object sender, KeyPressEventArgs e)
          {
               if (e.KeyChar == (char)13)
               {
                    if (System.Text.RegularExpressions.Regex.IsMatch(textBoxRed.Text, regex))
                    {
                         if (Convert.ToInt32(textBoxRed.Text) >= 0 && Convert.ToInt32(textBoxRed.Text) <= 255)
                         {
                              trackBarRed.Value = Convert.ToInt32(textBoxRed.Text);
                              PickColor();
                         }
                         else textBoxRed.Text = trackBarRed.Value.ToString();
                    }
                    else textBoxRed.Text = trackBarRed.Value.ToString();
               } 
          }
          private void textBoxRed_Leave(object sender, EventArgs e)
          {
               if (System.Text.RegularExpressions.Regex.IsMatch(textBoxRed.Text, regex))
               {
                    if (Convert.ToInt32(textBoxRed.Text) >= 0 && Convert.ToInt32(textBoxRed.Text) <= 255)
                    {
                         trackBarRed.Value = Convert.ToInt32(textBoxRed.Text);
                         PickColor();
                    }
                    else textBoxRed.Text = trackBarRed.Value.ToString();
               }
               else textBoxRed.Text = trackBarRed.Value.ToString();
          }

          private void textBoxGreen_KeyPress(object sender, KeyPressEventArgs e)
          {
               if (e.KeyChar == (char)13)
               {
                    if (System.Text.RegularExpressions.Regex.IsMatch(textBoxGreen.Text, regex))
                    {
                         if (Convert.ToInt32(textBoxGreen.Text) >= 0 && Convert.ToInt32(textBoxGreen.Text) <= 255)
                         {
                              trackBarGreen.Value = Convert.ToInt32(textBoxGreen.Text);
                              PickColor();
                         }
                         else textBoxGreen.Text = trackBarGreen.Value.ToString();
                    }
                    else textBoxGreen.Text = trackBarGreen.Value.ToString();
               }
          }
          private void textBoxGreen_Leave(object sender, EventArgs e)
          {
               if (System.Text.RegularExpressions.Regex.IsMatch(textBoxGreen.Text, regex))
               {
                    if (Convert.ToInt32(textBoxGreen.Text) >= 0 && Convert.ToInt32(textBoxGreen.Text) <= 255)
                    {
                         trackBarGreen.Value = Convert.ToInt32(textBoxGreen.Text);
                         PickColor();
                    }
                    else textBoxGreen.Text = trackBarGreen.Value.ToString();
               }
               else textBoxGreen.Text = trackBarGreen.Value.ToString();
          }

          private void textBoxBlue_KeyPress(object sender, KeyPressEventArgs e)
          {
               if (e.KeyChar == (char)13)
               {
                    if (System.Text.RegularExpressions.Regex.IsMatch(textBoxBlue.Text, regex))
                    {
                         if (Convert.ToInt32(textBoxBlue.Text) >= 0 && Convert.ToInt32(textBoxBlue.Text) <= 255)
                         {
                              trackBarBlue.Value = Convert.ToInt32(textBoxBlue.Text);
                              PickColor();
                         }
                         else textBoxBlue.Text = trackBarBlue.Value.ToString();
                    }
                    else textBoxBlue.Text = trackBarBlue.Value.ToString();
               }
          }
          private void textBoxBlue_Leave(object sender, EventArgs e)
          {
               if (System.Text.RegularExpressions.Regex.IsMatch(textBoxBlue.Text, regex))
               {
                    if (Convert.ToInt32(textBoxBlue.Text) >= 0 && Convert.ToInt32(textBoxBlue.Text) <= 255)
                    {
                         trackBarBlue.Value = Convert.ToInt32(textBoxBlue.Text);
                         PickColor();
                    }
                    else textBoxBlue.Text = trackBarBlue.Value.ToString();
               }
               else textBoxBlue.Text = trackBarBlue.Value.ToString();
          }
     }
}
