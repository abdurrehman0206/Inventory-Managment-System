
using Project.Controllers;
using Project.Models;
using System.Net;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
namespace Project.Pages.SuppliersForms
{
    public partial class AddSupplierForm : Form
    {
        public AddSupplierForm()
        {
            InitializeComponent();
        }

        //txtName Events
        private void txtName_MouseClick(object sender, MouseEventArgs e)
        {
            pnlName.BorderStyle = BorderStyle.FixedSingle;
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            pnlName.BorderStyle = BorderStyle.None;
        }

        //txtNum Events
        private void txtNum_MouseClick(object sender, MouseEventArgs e)
        {
            pnlNum.BorderStyle = BorderStyle.FixedSingle;
        }

        private void txtNum_Leave(object sender, EventArgs e)
        {
            pnlNum.BorderStyle = BorderStyle.None;
        }
        private void txtNum_TextChanged(object sender, EventArgs e)
        {
            txtNum.Text = new string(txtNum.Text.Where(char.IsDigit).ToArray());
        }

        //txtEmail Events
        private void txtEmail_MouseClick(object sender, MouseEventArgs e)
        {
            pnlEmail.BorderStyle = BorderStyle.FixedSingle;
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            pnlEmail.BorderStyle = BorderStyle.None;
        }
        private void txtEmail_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtEmail.Text.Length > 0)
            {
                string emailPattern = @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$";
                Regex regex = new Regex(emailPattern);
                pnlEmail.BackColor = Color.FromArgb(225, 217, 242);
                txtEmail.BackColor = Color.FromArgb(225, 217, 242);
                if (!regex.IsMatch(txtEmail.Text))
                {



                    pnlEmail.BackColor = Color.FromArgb(255, 190, 190);
                    txtEmail.BackColor = Color.FromArgb(255, 190, 190);

                }

            }
            else
            {
                pnlEmail.BackColor = Color.FromArgb(225, 217, 242);
                txtEmail.BackColor = Color.FromArgb(225, 217, 242);

            }
        }

        //txtAddress Events
        private void txtAddress_MouseClick(object sender, MouseEventArgs e)
        {
            txtAddress.BorderStyle = BorderStyle.FixedSingle;
        }

        private void txtAddress_Leave(object sender, EventArgs e)
        {
            txtAddress.BorderStyle = BorderStyle.None;
        }


        //btnSupplier 
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string supplierName = txtName.Text;
            string supplierContactNumber = txtNum.Text;
            string supplierEmail = txtEmail.Text;
            string supplierAddress = txtAddress.Text;

            Supplier newSup = new Supplier
            {
                Name = supplierName,
                ContactNumber = supplierContactNumber,
                Email = supplierEmail,
                Address = supplierAddress


            };

            SupplierController supController = new SupplierController();
            supController.AddSupplier(newSup);
            MessageBox.Show("Supplier added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        ClearTextFields();
        
        }


        //Clear textFields 

        private void ClearTextFields()
        {
            txtName.Text = string.Empty;
            txtNum.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtAddress.Text = string.Empty;
            
        }

    }
}
