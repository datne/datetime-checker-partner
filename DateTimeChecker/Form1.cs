using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTimeChecker
{
    public partial class frmDTC : Form
    {

        public frmDTC()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //private void txtDay_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
        //    {
        //        MessageBox.Show("Input data for DAY is incorrect format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        e.Handled = true;
        //    }
        //}

        //private void txtMonth_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
        //    {
        //        MessageBox.Show("Input data for MONTH is incorrect format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        e.Handled = true;
        //    }
        //}

        //private void txtYear_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
        //    {
        //        MessageBox.Show("Input data for YEAR is incorrect format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        e.Handled = true;
        //    }
        //}

        //private void txtDay_Leave(object sender, EventArgs e)
        //{

        //    if(txtDay.Text=="")
        //    {
        //        MessageBox.Show("dd/mm/yyyy is NOT correct date time!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        txtDay.Focus();
        //    }
        //    else
        //    {
        //        int i;
        //        i = int.Parse(txtDay.Text);
        //        if(i<1 || i>31)
        //        {
        //            DialogResult res = MessageBox.Show("Input data for DAY is out of range!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            txtDay.Focus();
        //            txtDay.Text = "";
        //        }
        //    }
        //}

        //private void txtMonth_Leave(object sender, EventArgs e)
        //{
        //    if (txtMonth.Text == "")
        //    {
        //        MessageBox.Show("dd/mm/yyyy is NOT correct date time!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        txtMonth.Focus();
        //    }
        //    else
        //    {
        //        int i;
        //        i = int.Parse(txtMonth.Text);
        //        if (i < 1 || i > 12)
        //        {
        //            DialogResult res = MessageBox.Show("Input data for MONTH is out of range!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            txtMonth.Focus();
        //            txtMonth.Text = "";
        //        }
        //    }
        //}

        //private void txtYear_Leave(object sender, EventArgs e)
        //{
        //    if (txtYear.Text == "")
        //    {
        //        MessageBox.Show("dd/mm/yyyy is NOT correct date time!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        txtYear.Focus();
        //    }
        //    else
        //    {
        //        int i;
        //        i = int.Parse(txtYear.Text);
        //        if (i < 1000 || i > 3000)
        //        {
        //            DialogResult res = MessageBox.Show("Input data for YEAR is out of range!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            txtYear.Focus();
        //            txtYear.Text = "";
        //        }
        //    }
        //}

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (txtDay.Text == "" && txtMonth.Text == "" && txtYear.Text == "")
            {
                MessageBox.Show("Nothing to clear!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                txtDay.Clear();
                txtMonth.Clear();
                txtYear.Clear();
                txtDay.Focus();
            }

        }

        public int DaysInMonth(ushort year, byte month)
        {
            switch(month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 4:
                case 6:
                case 9:
                case 11:
                    return 30;
                case 2:
                    if (year % 400 == 0)
                        return 29;
                    if (year % 100 == 0)
                        return 28;
                    if (year % 4 == 0)
                        return 29;
                    return 28;
                default:
                    return 0;
            }
        }
        public bool IsValidDate(ushort year, byte month, byte day)
        {
            if (month > 0 && month < 13)
				if(year>1000 && year <3000)
					if (day > 0)
						if (day <= DaysInMonth(year, month))
							return true;
            return false;
        }

        public bool CheckNumber(string str)
        {
            try
            {
                int num = int.Parse(str);
                return true;
            }
            catch
            {
                return false;
            }
        }

        
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure to exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (res == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (!CheckNumber(txtDay.Text))
            {
                MessageBox.Show("Input data for Day is incorrect format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDay.Focus();
                return;
            }
            if (!CheckNumber(txtMonth.Text))
            {
                MessageBox.Show("Input data for Month is incorrect format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMonth.Focus();
                return;
                
            }
            if (!CheckNumber(txtYear.Text))
            {
                MessageBox.Show("Input data for Year is incorrect format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtYear.Focus();
                return;
                
            }
            byte day = byte.Parse(txtDay.Text);
            byte month = byte.Parse(txtMonth.Text);
            ushort year = ushort.Parse(txtYear.Text);
            if (day < 1 || day > 31)
            {
                MessageBox.Show("Input data for Day is out of range!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDay.Focus();
                return;
                
            }
            if (month < 1 || month > 12)
            {
                MessageBox.Show("Input data for Month is out of range!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMonth.Focus();
                return;
                
            }
            if (year < 1000 || year > 3000)
            {
                MessageBox.Show("Input data for Year is out of range!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtYear.Focus();
                return;
                
            }
            string ngay = txtDay.Text;
            string thang = txtMonth.Text;
            if (ngay.Length == 1)
                ngay = '0' + ngay;
            if (thang.Length == 1)
                thang = '0' + thang;
            if (IsValidDate(year, month, day))
                MessageBox.Show(ngay + "/" + thang + "/" + year + " is correct date time!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(ngay + "/" + thang + "/" + year + " is NOT correct date time!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void txtDay_TextChanged(object sender, EventArgs e)
        {
            if (CheckNumber(txtDay.Text))
            {
                int a = int.Parse(txtDay.Text);
                if (a < 0)
                {
                    MessageBox.Show("Input data for Day is out of range!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDay.Text = "";
                    txtDay.Focus();
                }
            }
        }

        private void txtDay_Leave(object sender, EventArgs e)
        {
           
                
        }

        private void txtMonth_TextChanged(object sender, EventArgs e)
        {
            if (CheckNumber(txtMonth.Text))
            {
                int a = int.Parse(txtMonth.Text);
                if (a < 0)
                {
                    MessageBox.Show("Input data for Month is out of range!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMonth.Text = "";
                    txtMonth.Focus();
                }
            }
        }

        private void txtYear_TextChanged(object sender, EventArgs e)
        {
            if (CheckNumber(txtYear.Text))
            {
                int a = int.Parse(txtYear.Text);
                if (a < 0)
                {
                    MessageBox.Show("Input data for Year is out of range!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtYear.Text = "";
                    txtYear.Focus();
                }
            }
        }
    }
}
