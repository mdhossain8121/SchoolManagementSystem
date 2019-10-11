using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace SchoolManagementSystem.Class
{
    class Utilities
    {
        private static ErrorProvider ep = new ErrorProvider();
        public static void EmptyAllControls(Control form)
        {
            foreach (Control control in form.Controls)
            {
                if (control.HasChildren)
                {
                    EmptyAllControls(control);
                }
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Text = null;
                }
                if (control is Button)
                {
                    Button btn = (Button)control;
                    btn.Tag = null;
                }
                else if (control is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)control;
                    comboBox.SelectedIndex = -1;
                }
                else if (control is CheckBox)
                {
                    Console.WriteLine("Checkbox");
                    CheckBox checkBox = (CheckBox)control;
                    checkBox.Checked = false;
                }
                else if (control is ListBox)
                {
                    ListBox listBox = (ListBox)control;
                    listBox.ClearSelected();
                }
                else if (control is PictureBox)
                {
                    PictureBox pictureBox = (PictureBox)control;
                    pictureBox.BackgroundImage = null;
                }
                else if (control is DateTimePicker)
                {
                    DateTimePicker dateTimePicker = (DateTimePicker)control;
                    if(dateTimePicker.Checked)
                    {
                        dateTimePicker.Value = DateTime.Now.Date;
                    }

                    if (dateTimePicker.ShowCheckBox)
                    {
                        dateTimePicker.Checked = false;
                    }

                }
            }
        }

        public static void ResetComboBox(ComboBox cmb)
        {
            cmb.DataSource = null;
            cmb.Items.Clear();
            cmb.IntegralHeight = false;
        }

        public static bool EmptyRequiredField(Control form)
        {
            
            bool Empty = false;
            ep.Clear();
            foreach (Control c in form.Controls)
            {
                if (c is TextBox)
                {
                    if (c.Text.Trim().Equals("") && c.Tag!=null && c.Tag.ToString().Trim().Equals("Required"))
                    {
                        ep.SetError(c, "Required");
                        Empty = true;
                    }
                }
                else if (c is DateTimePicker)
                {
                    if (c.Text.Trim().Equals("") && c.Tag != null && c.Tag.ToString().Trim().Equals("Required"))
                    {
                        ep.SetError(c, "Required");
                        Empty = true;
                    }
                }
                else if (c is ComboBox)
                {
                    if (((ComboBox)c).SelectedIndex < 0)
                    {
                        ep.SetError(c, "Required");
                        Empty = true;
                    }
                }
                if (c is PictureBox)
                {
                    if (c.BackgroundImage.ToString().Trim().Equals("") && c.Tag != null && c.Tag.ToString().Trim().Equals("Required"))
                    {
                        ep.SetError(c, "Required");
                        Empty = true;
                    }
                }
            }

            return Empty;

            //foreach (Control control in form.Controls)
            //{
            //    if (control is TextBox)
            //    {
            //        TextBox textBox = (TextBox)control;
            //        textBox.Text = null;
            //    }

            //    if (control is ComboBox)
            //    {
            //        ComboBox comboBox = (ComboBox)control;
            //        if (comboBox.Items.Count > 0)
            //            comboBox.SelectedIndex = 0;
            //    }

            //    if (control is CheckBox)
            //    {
            //        CheckBox checkBox = (CheckBox)control;
            //        checkBox.Checked = false;
            //    }

            //    if (control is ListBox)
            //    {
            //        ListBox listBox = (ListBox)control;
            //        listBox.ClearSelected();
            //    }
            //}
        }
    }
}
