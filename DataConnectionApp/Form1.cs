using System.Data.SqlClient;


namespace DataConnectionApp
{
    public partial class frmabccompany : Form
    {
        public frmabccompany()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-GHFGR6A\SQLEXPRESS;Initial Catalog=abccompany;Integrated Security=True");

        private void btnadd_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Customers values (@customerid, @firstname, @lastname, @email, @phoneno, @address, @city)", con);
            cmd.Parameters.AddWithValue("@customerid", int.Parse(txtcustomerid.Text));
            cmd.Parameters.AddWithValue("@firstname", txtfirstname.Text);
            cmd.Parameters.AddWithValue("@lastname", txtlastname.Text);
            cmd.Parameters.AddWithValue("@email", txtemail.Text);
            cmd.Parameters.AddWithValue("@phoneno", txtphoneno.Text);
            cmd.Parameters.AddWithValue("@address", txtaddress.Text);
            cmd.Parameters.AddWithValue("@city", txtcity.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully added", "Congratulations!");
            txtcustomerid.Clear();
            txtfirstname.Clear();
            txtlastname.Clear();
            txtemail.Clear();
            txtphoneno.Clear();
            txtaddress.Clear();
            txtcity.Clear();
            txtcustomerid.Select();
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Customers where [Customer ID] = @customerid", con);
            cmd.Parameters.AddWithValue("@customerid", int.Parse(txtcustomerid.Text));

            SqlDataReader da = cmd.ExecuteReader();
            if (da.Read())
            {
                txtfirstname.Text = da.GetValue(1).ToString();
                txtlastname.Text = da.GetValue(2).ToString();
                txtemail.Text = da.GetValue(3).ToString();
                txtphoneno.Text = da.GetValue(4).ToString();
                txtaddress.Text = da.GetValue(5).ToString();
                txtcity.Text = da.GetValue(6).ToString();
            }
            else
            {
                txtfirstname.Clear();
                txtlastname.Clear();
                txtemail.Clear();
                txtphoneno.Clear();
                txtaddress.Clear();
                txtcity.Clear();
                txtcustomerid.Select();
                MessageBox.Show("There is no customer with this Customer ID", "Caution");
                txtcustomerid.Clear();

            }
            con.Close();
        }



        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void frmabccompany_Load(object sender, EventArgs e)
        {
            txtcustomerid.Select();
        }

        private void txtcustomerid_TextChanged(object sender, EventArgs e)
        {
            txtfirstname.Clear();
            txtlastname.Clear();
            txtemail.Clear();
            txtphoneno.Clear();
            txtaddress.Clear();
            txtcity.Clear();
            txtcustomerid.Select();
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("delete Customers where [Customer ID] = @customerid", con);
            cmd.Parameters.AddWithValue("@customerid", int.Parse(txtcustomerid.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            txtcustomerid.Clear();
            txtfirstname.Clear();
            txtlastname.Clear();
            txtemail.Clear();
            txtphoneno.Clear();
            txtaddress.Clear();
            txtcity.Clear();
            txtcustomerid.Select();
            MessageBox.Show("Successfully removed", "Done!");

        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update Customers set [First Name]=@firstname, [Last Name]=@lastname, [E-mail]=@email, [Phone No]=@phoneno, [Address]=@address, [City]=@city where [Customer ID]=@customerid", con);
            cmd.Parameters.AddWithValue("@customerid", int.Parse(txtcustomerid.Text));
            cmd.Parameters.AddWithValue("@firstname", txtfirstname.Text);
            cmd.Parameters.AddWithValue("@lastname", txtlastname.Text);
            cmd.Parameters.AddWithValue("@email", txtemail.Text);
            cmd.Parameters.AddWithValue("@phoneno", txtphoneno.Text);
            cmd.Parameters.AddWithValue("@address", txtaddress.Text);
            cmd.Parameters.AddWithValue("@city", txtcity.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("The customer details are updated", "Success!");
            txtcustomerid.Clear();
            txtfirstname.Clear();
            txtlastname.Clear();
            txtemail.Clear();
            txtphoneno.Clear();
            txtaddress.Clear();
            txtcity.Clear();
            txtcustomerid.Select();
        }

        private void btnaddproduct_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Products values (@productid, @productname, @category, @price, @quantity, @supplier, @description)", con);
            cmd.Parameters.AddWithValue("@productid", int.Parse(txtproductid.Text));
            cmd.Parameters.AddWithValue("@productname", txtproductname.Text);
            cmd.Parameters.AddWithValue("@category", txtcategory.Text);
            cmd.Parameters.AddWithValue("@price", int.Parse(txtprice.Text));
            cmd.Parameters.AddWithValue("@quantity", int.Parse(txtquantity.Text));
            cmd.Parameters.AddWithValue("@supplier", txtsupplier.Text);
            cmd.Parameters.AddWithValue("@description", txtdescription.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully added", "Nice work!");
            txtproductid.Clear();
            txtproductname.Clear();
            txtcategory.Clear();
            txtprice.Clear();
            txtquantity.Clear();
            txtsupplier.Clear();
            txtdescription.Clear();
            txtproductid.Select();
        }

        private void btnaddsupplier_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Suppliers values (@supplierid, @suppliername, @contactname, @semail, @sphone, @saddress, @scity)", con);
            cmd.Parameters.AddWithValue("@supplierid", int.Parse(txtsupplierid.Text));
            cmd.Parameters.AddWithValue("@suppliername", txtsuppliername.Text);
            cmd.Parameters.AddWithValue("@contactname", txtcontactname.Text);
            cmd.Parameters.AddWithValue("@semail", txtsemail.Text);
            cmd.Parameters.AddWithValue("@sphone", txtsphone.Text);
            cmd.Parameters.AddWithValue("@saddress", txtsaddress.Text);
            cmd.Parameters.AddWithValue("@scity", txtscity.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully added", "Done");
            txtsupplierid.Clear();
            txtsuppliername.Clear();
            txtcontactname.Clear();
            txtsemail.Clear();
            txtsphone.Clear();
            txtsaddress.Clear();
            txtscity.Clear();
            txtsupplierid.Select();
        }

        private void btnviewproductdetails_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Products where [Product ID] = @productid", con);
            cmd.Parameters.AddWithValue("@productid", int.Parse(txtproductid.Text));

            SqlDataReader da = cmd.ExecuteReader();
            if (da.Read())
            {
                txtproductname.Text = da.GetValue(1).ToString();
                txtcategory.Text = da.GetValue(2).ToString();
                txtprice.Text = da.GetValue(3).ToString();
                txtquantity.Text = da.GetValue(4).ToString();
                txtsupplier.Text = da.GetValue(5).ToString();
                txtdescription.Text = da.GetValue(6).ToString();
            }
            else
            {

                MessageBox.Show("No such Product", "Caution");
                txtproductid.Clear();

            }
            con.Close();
        }

        private void txtproductid_TextChanged(object sender, EventArgs e)
        {
            txtproductname.Clear();
            txtcategory.Clear();
            txtprice.Clear();
            txtquantity.Clear();
            txtsupplier.Clear();
            txtdescription.Clear();
        }

        private void btnsavechanges_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update Products set [Product Name]=@productname, [Category]=@category, [Price]=@price, [Quantity]=@quantity, [Supplier]=@supplier, [Description]=@description where [Product Id]=@productid", con);
            cmd.Parameters.AddWithValue("@productid", int.Parse(txtproductid.Text));
            cmd.Parameters.AddWithValue("@productname", txtproductname.Text);
            cmd.Parameters.AddWithValue("@category", txtcategory.Text);
            cmd.Parameters.AddWithValue("@price", int.Parse(txtprice.Text));
            cmd.Parameters.AddWithValue("@quantity", int.Parse(txtquantity.Text));
            cmd.Parameters.AddWithValue("@supplier", txtsupplier.Text);
            cmd.Parameters.AddWithValue("@description", txtdescription.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully saved", "Good!");
            txtproductid.Clear();
            txtproductname.Clear();
            txtcategory.Clear();
            txtprice.Clear();
            txtquantity.Clear();
            txtsupplier.Clear();
            txtdescription.Clear();
        }

        private void btnremoveproduct_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("delete Products where [Product Id]=@productid", con);
            cmd.Parameters.AddWithValue("@productid", int.Parse(txtproductid.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            txtproductid.Clear();
            txtproductname.Clear();
            txtcategory.Clear();
            txtprice.Clear();
            txtquantity.Clear();
            txtsupplier.Clear();
            txtdescription.Clear();
            MessageBox.Show("Successfully removed", "Done");
        }

        private void btnaddorder_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into orders values (@orderid,@ordercustomerid,@orderproductid,@orderdate,@orderquantity,@totalamount)", con);
            cmd.Parameters.AddWithValue("@orderid", int.Parse(txtorderid.Text));
            cmd.Parameters.AddWithValue("@ordercustomerid", int.Parse(txtordercustomerid.Text));
            cmd.Parameters.AddWithValue("@orderproductid", int.Parse(txtorderproductid.Text));
            cmd.Parameters.AddWithValue("@orderdate", txtorderdate.Text);
            cmd.Parameters.AddWithValue("@orderquantity", int.Parse(txtorderquantity.Text));
            cmd.Parameters.AddWithValue("@totalamount", int.Parse(txttotalamount.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully added", "Good job");
            txtorderid.Clear();
            txtordercustomerid.Clear();
            txtorderproductid.Clear();
            txtorderdate.Clear();
            txtorderquantity.Clear();
            txttotalamount.Clear();
        }

        private void btnvieworderdetails_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from orders where [Order ID]=@orderid", con);
            cmd.Parameters.AddWithValue("@orderid", int.Parse(txtorderid.Text));

            SqlDataReader da = cmd.ExecuteReader();
            if (da.Read())
            {
                txtordercustomerid.Text = da.GetValue(1).ToString();
                txtorderproductid.Text = da.GetValue(2).ToString();
                txtorderdate.Text = da.GetValue(3).ToString();
                txtorderquantity.Text = da.GetValue(4).ToString();
                txttotalamount.Text = da.GetValue(5).ToString();
            }
            else
            {
                MessageBox.Show("No such record", "Sorry");
                txtorderid.Clear();
            }
            con.Close();
        }

        private void txtorderid_TextChanged(object sender, EventArgs e)
        {
            txtordercustomerid.Clear();
            txtorderproductid.Clear();
            txtorderdate.Clear();
            txtorderquantity.Clear();
            txttotalamount.Clear();
        }

        private void btnsaveedited_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update orders set [Customer ID]=@ordercustomerid, [Product ID]=@orderproductid, [Order Date]=@orderdate, [Quantity]=@orderquantity, [Total Amount]=@totalamount where [Order ID]=@orderid", con);
            cmd.Parameters.AddWithValue("@orderid", int.Parse(txtorderid.Text));
            cmd.Parameters.AddWithValue("@ordercustomerid", int.Parse(txtordercustomerid.Text));
            cmd.Parameters.AddWithValue("@orderproductid", int.Parse(txtorderproductid.Text));
            cmd.Parameters.AddWithValue("@orderdate", txtorderdate.Text);
            cmd.Parameters.AddWithValue("@orderquantity", int.Parse(txtordercustomerid.Text));
            cmd.Parameters.AddWithValue("@totalamount", int.Parse(txttotalamount.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("successfully updated", "Done");
            txtorderid.Clear();
            txtordercustomerid.Clear();
            txtorderproductid.Clear();
            txtorderdate.Clear();
            txtorderquantity.Clear();
            txttotalamount.Clear();
        }

        private void btnremoveorder_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("delete orders where [Order ID]=@orderid", con);
            cmd.Parameters.AddWithValue("@orderid", int.Parse(txtorderid.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            txtorderid.Clear();
            txtordercustomerid.Clear();
            txtorderproductid.Clear();
            txtorderdate.Clear();
            txtquantity.Clear();
            txttotalamount.Clear();
            MessageBox.Show("Successfully removed", "Done!");
        }

        private void btnaddemployee_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Employees values (@employerid, @efirstname, @elastname, @age, @position, @salary, @department)", con);
            cmd.Parameters.AddWithValue("@employerid", int.Parse(txtemployerid.Text));
            cmd.Parameters.AddWithValue("@efirstname", txtefirstname.Text);
            cmd.Parameters.AddWithValue("@elastname", txtelastname.Text);
            cmd.Parameters.AddWithValue("@age", int.Parse(txtage.Text));
            cmd.Parameters.AddWithValue("@position", txtposition.Text);
            cmd.Parameters.AddWithValue("@salary", int.Parse(txtsalary.Text));
            cmd.Parameters.AddWithValue("@department", txtdepartment.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully added", "Done");
            txtemployerid.Clear();
            txtefirstname.Clear();
            txtelastname.Clear();
            txtage.Clear();
            txtposition.Clear();
            txtsalary.Clear();
            txtdepartment.Clear();
        }

        private void btnviewemployeedetails_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Employees where [Employee ID]=@employerid", con);
            cmd.Parameters.AddWithValue("@employerid", int.Parse(txtemployerid.Text));

            SqlDataReader da = cmd.ExecuteReader();
            if (da.Read())
            {
                txtefirstname.Text = da.GetValue(1).ToString();
                txtelastname.Text = da.GetValue(2).ToString();
                txtage.Text = da.GetValue(3).ToString();
                txtposition.Text = da.GetValue(4).ToString();
                txtsalary.Text = da.GetValue(5).ToString();
                txtdepartment.Text = da.GetValue(6).ToString();
            }
            else
            {
                MessageBox.Show("No such record", "oops");
                txtemployerid.Clear();
            }
            con.Close();
        }

        private void txtemployerid_TextChanged(object sender, EventArgs e)
        {
            txtefirstname.Clear();
            txtelastname.Clear();
            txtage.Clear();
            txtposition.Clear();
            txtsalary.Clear();
            txtdepartment.Clear();
        }

        private void btnesavechanges_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update Employees set [Employee ID]=@employerid, [First Name]=@efirstname, [Last Name]=@elastname, [Age]=@age, [Position]=@position, [Salary]=@salary, [Department]=@department where [Employee ID]=@employerid", con);
            cmd.Parameters.AddWithValue("@employerid", int.Parse(txtemployerid.Text));
            cmd.Parameters.AddWithValue("@efirstname", txtefirstname.Text);
            cmd.Parameters.AddWithValue("@elastname", txtelastname.Text);
            cmd.Parameters.AddWithValue("@age", int.Parse(txtage.Text));
            cmd.Parameters.AddWithValue("@position", txtposition.Text);
            cmd.Parameters.AddWithValue("@salary", int.Parse(txtsalary.Text));
            cmd.Parameters.AddWithValue("@department", txtdepartment.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully updated", "Done");
            txtemployerid.Clear();
            txtefirstname.Clear();
            txtelastname.Clear();
            txtage.Clear();
            txtposition.Clear();
            txtsalary.Clear();
            txtdepartment.Clear();
        }

        private void btnremoveemployee_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("delete Employees where [Employee ID]=@employerid", con);
            cmd.Parameters.AddWithValue("@employerid", int.Parse(txtemployerid.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            txtemployerid.Clear();
            txtefirstname.Clear();
            txtelastname.Clear();
            txtage.Clear();
            txtposition.Clear();
            txtsalary.Clear();
            txtdepartment.Clear();

            MessageBox.Show("Successfully deleted", "Alert");

        }

        private void btnviewsupplierdetails_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Suppliers where [Supplier ID]=@supplierid", con);
            cmd.Parameters.AddWithValue("@supplierid", int.Parse(txtsupplierid.Text));

            SqlDataReader da = cmd.ExecuteReader();
            if (da.Read())
            {
                txtsuppliername.Text = da.GetValue(1).ToString();
                txtcontactname.Text = da.GetValue(2).ToString();
                txtsemail.Text = da.GetValue(3).ToString();
                txtsphone.Text = da.GetValue(4).ToString();
                txtsaddress.Text = da.GetValue(5).ToString();
                txtscity.Text = da.GetValue(6).ToString();
            }
            else
            {
                MessageBox.Show("No such record brother", "Hey dude!");
                txtsupplierid.Clear();
            }
            con.Close();
        }

        private void txtsupplierid_TextChanged(object sender, EventArgs e)
        {
            txtsuppliername.Clear();
            txtcontactname.Clear();
            txtsemail.Clear();
            txtsphone.Clear();
            txtsaddress.Clear();
            txtscity.Clear();
        }

        private void b_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update Suppliers set [Supplier ID]=@supplierid, []Supplier Name]=@suuppliername, [Contact Name]=@contactname, [E-mail]=@semail, [Phone]=@sphone, [Address]=@saddress, [City]=@scity where [Supplier ID]=@supplierid", con);
            cmd.Parameters.AddWithValue("@supplierid", int.Parse(txtsupplierid.Text));
            cmd.Parameters.AddWithValue("@suppliername", txtsuppliername.Text);
            cmd.Parameters.AddWithValue("@contactname", txtcontactname.Text);
            cmd.Parameters.AddWithValue("@semail", txtsemail.Text);
            cmd.Parameters.AddWithValue("@sphone", txtsphone.Text);
            cmd.Parameters.AddWithValue("@saddress", txtsaddress.Text);
            cmd.Parameters.AddWithValue("@scity", txtscity.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully updated", "Success");
            txtsupplierid.Clear();
            txtsuppliername.Clear();
            txtcontactname.Clear();
            txtsemail.Clear();
            txtsphone.Clear();
            txtsaddress.Clear();
            txtscity.Clear();
        }

        private void btnremovesupplier_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("delete Suppliers where [Supplier ID]=@supplierid", con);
            cmd.Parameters.AddWithValue("@supplierid", int.Parse(txtsupplierid.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully deleted", "Done");
            txtsupplierid.Clear();
            txtsuppliername.Clear();
            txtcontactname.Clear();
            txtsemail.Clear();
            txtsphone.Clear();
            txtsaddress.Clear();
            txtscity.Clear();
        }
    }
}
