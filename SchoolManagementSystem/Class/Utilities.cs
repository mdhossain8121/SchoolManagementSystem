using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Data;


namespace SchoolManagementSystem.Class
{
    class Utilities
    {
        private static ErrorProvider ep = new ErrorProvider();
        public static void EmptyAllControls(Control form)
        {
            foreach (Control control in form.Controls)
            {
                //if (control.HasChildren)
                //{
                //    EmptyAllControls(control);
                //}
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Text = null;
                }
                else if (control is Button)
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
                    CheckBox checkBox = (CheckBox)control;
                    checkBox.Checked = false;
                }
                else if (control is DataGridView)
                {
                    DataGridView dgv = (DataGridView)control;
                    dgv.DataSource = null;
                }
                else if (control is ListBox)
                {
                    ListBox listBox = (ListBox)control;
                    listBox.ClearSelected();
                }
                else if (control is PictureBox)
                {
                    PictureBox pictureBox = (PictureBox)control;
                    pictureBox.BackgroundImage = pictureBox.InitialImage;
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
            cmb.DataBindings.Clear();
            cmb.DataSource = null;
            cmb.Items.Clear();
            cmb.IntegralHeight = false;
        }



        public static bool EmptyRequiredField(Control form)
        {
            bool EmptyInputField = false;
            ep.Clear();

            foreach (Control c in form.Controls)
            {
                //if (c.HasChildren)
                //{
                //    EmptyRequiredField(c);
                //}
                if (c is TextBox)
                {
                    if (c.Text.Trim().Equals("") && c.Tag != null && c.Tag.ToString().Trim().Equals("Required"))
                    {
                        ep.SetError(c, "Required");
                        EmptyInputField = true;
                    }
                }
                else if (c is DateTimePicker)
                {
                    if (c.Text.Trim().Equals("") && c.Tag != null && c.Tag.ToString().Trim().Equals("Required"))
                    {
                        ep.SetError(c, "Required");
                        EmptyInputField = true;
                    }
                }
                else if (c is ComboBox)
                {
                    if (((ComboBox)c).SelectedIndex < 0 && c.Tag != null && c.Tag.ToString().Trim().Equals("Required"))
                    {
                        ep.SetError(c, "Required");
                        EmptyInputField = true;
                    }
                }
                else if (c is PictureBox)
                {
                    if (c.BackgroundImage.ToString().Trim().Equals("") && c.Tag != null && c.Tag.ToString().Trim().Equals("Required"))
                    {
                        ep.SetError(c, "Required");
                        EmptyInputField = true;
                    }
                }
                else if (c is DataGridView && c.Tag.ToString()!=null && c.Tag.ToString() == "Required")
                {
                    if (((DataGridView)c).Rows.Count <= 0)
                    {
                        ep.SetError(c, "Required");
                        EmptyInputField = true;
                    }
                    foreach (DataGridViewRow row in ((DataGridView)c).Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            if (cell.ReadOnly == false && String.IsNullOrEmpty(Convert.ToString(cell.Value)))
                            {
                                cell.Style.BackColor = Color.Maroon;
                                ep.SetError(c, "Required");
                                EmptyInputField = true;
                            }
                        }
                    }
                }
            }
            return EmptyInputField;
        }


        public static bool EmptyDataGridViewRequiredCell(Control form)
        {
            bool EmptyTable = false;
            ep.Clear();
            if (form is DataGridView && form.Tag.ToString()=="Required")
            {
                if (((DataGridView)form).Rows.Count <= 0)
                {
                    ep.SetError(form, "Required");
                    return EmptyTable = true;
                }
                foreach (DataGridViewRow row in ((DataGridView)form).Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.ReadOnly == false && String.IsNullOrEmpty(Convert.ToString(cell.Value)))
                        {
                            cell.Style.BackColor = Color.Maroon;
                            ep.SetError(form, "Required");
                            EmptyTable = true;
                        }
                    }
                }
            }
            return EmptyTable;
        }
    }
}
