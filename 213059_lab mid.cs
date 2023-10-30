using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QNO1
{
    private void CalculateTotalButton_Click(object sender, EventArgs e)
    {
        decimal totalAmount = 0;

        totalAmount += CalculateGroupTotal(groupBoxStarter);
        totalAmount += CalculateGroupTotal(groupBoxMainCourse);
        totalAmount += CalculateGroupTotal(groupBoxSweetDish);

        txtTotalAmount.Text = totalAmount.ToString("C");
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            private decimal CalculateGroupTotal(GroupBox groupBox)
            {
                decimal groupTotal = 0;

                foreach (Control control in groupBox.Controls)
                {
                    if (control is CheckBox checkbox)
                    {
                        if (checkbox.Checked)
                        {
                            string itemName = checkbox.Text;
                            decimal itemPrice = GetItemPrice(groupBox, itemName);
                            decimal quantity = GetItemQuantity(groupBox, itemName);

                            groupTotal += itemPrice * quantity;
                        }
                    }
                }

                return groupTotal;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            foreach (Control control in groupBox.Controls)
            {
                if (control is Label label && label.Text.Contains(itemName))
                {
                    string[] parts = label.Text.Split('$');
                    if (parts.Length > 1 && decimal.TryParse(parts[1], out decimal price))
                    {
                        return price;
                    }
                }
            }

            return 0;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            private decimal GetItemQuantity(GroupBox groupBox, string itemName)
            {
                foreach (Control control in groupBox.Controls)
                {
                    if (control is TextBox textBox && textBox.Name.Contains(itemName))
                    {
                        if (decimal.TryParse(textBox.Text, out decimal quantity))
                        {
                            return quantity;
                        }
                    }
                }

                return 0;
            }
        }
    }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }









  

    

 