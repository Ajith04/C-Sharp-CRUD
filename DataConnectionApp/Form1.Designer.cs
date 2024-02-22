namespace DataConnectionApp
{
    partial class frmabccompany
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmabccompany));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnremove = new Button();
            btnedit = new Button();
            btnview = new Button();
            btnadd = new Button();
            txtcity = new TextBox();
            txtaddress = new TextBox();
            txtphoneno = new TextBox();
            txtemail = new TextBox();
            txtlastname = new TextBox();
            txtfirstname = new TextBox();
            txtcustomerid = new TextBox();
            label10 = new Label();
            label8 = new Label();
            label9 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            btnremoveproduct = new Button();
            btnsavechanges = new Button();
            btnviewproductdetails = new Button();
            btnaddproduct = new Button();
            txtdescription = new TextBox();
            txtsupplier = new TextBox();
            txtquantity = new TextBox();
            txtprice = new TextBox();
            txtcategory = new TextBox();
            txtproductname = new TextBox();
            txtproductid = new TextBox();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            tabPage3 = new TabPage();
            label42 = new Label();
            btnremoveorder = new Button();
            btnsaveedited = new Button();
            btnvieworderdetails = new Button();
            btnaddorder = new Button();
            txttotalamount = new TextBox();
            txtorderquantity = new TextBox();
            txtorderdate = new TextBox();
            txtorderproductid = new TextBox();
            txtordercustomerid = new TextBox();
            txtorderid = new TextBox();
            label19 = new Label();
            label21 = new Label();
            label22 = new Label();
            label23 = new Label();
            label24 = new Label();
            label25 = new Label();
            label26 = new Label();
            tabPage4 = new TabPage();
            btnremoveemployee = new Button();
            btnesavechanges = new Button();
            btnviewemployeedetails = new Button();
            btnaddemployee = new Button();
            txtdepartment = new TextBox();
            txtsalary = new TextBox();
            txtposition = new TextBox();
            txtage = new TextBox();
            txtelastname = new TextBox();
            txtefirstname = new TextBox();
            txtemployerid = new TextBox();
            label20 = new Label();
            label27 = new Label();
            label28 = new Label();
            label29 = new Label();
            label30 = new Label();
            label31 = new Label();
            label32 = new Label();
            label33 = new Label();
            tabPage5 = new TabPage();
            btnremovesupplier = new Button();
            b = new Button();
            btnviewsupplierdetails = new Button();
            btnaddsupplier = new Button();
            txtscity = new TextBox();
            txtsaddress = new TextBox();
            txtsphone = new TextBox();
            txtsemail = new TextBox();
            txtcontactname = new TextBox();
            txtsuppliername = new TextBox();
            txtsupplierid = new TextBox();
            label34 = new Label();
            label35 = new Label();
            label36 = new Label();
            label37 = new Label();
            label38 = new Label();
            label39 = new Label();
            label40 = new Label();
            label41 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            tabPage5.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.ShowToolTips = true;
            tabControl1.Size = new Size(844, 474);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Brown;
            tabPage1.Controls.Add(btnremove);
            tabPage1.Controls.Add(btnedit);
            tabPage1.Controls.Add(btnview);
            tabPage1.Controls.Add(btnadd);
            tabPage1.Controls.Add(txtcity);
            tabPage1.Controls.Add(txtaddress);
            tabPage1.Controls.Add(txtphoneno);
            tabPage1.Controls.Add(txtemail);
            tabPage1.Controls.Add(txtlastname);
            tabPage1.Controls.Add(txtfirstname);
            tabPage1.Controls.Add(txtcustomerid);
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(836, 446);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Customers";
            tabPage1.Click += tabPage1_Click;
            // 
            // btnremove
            // 
            btnremove.BackColor = Color.Red;
            btnremove.FlatAppearance.BorderColor = Color.White;
            btnremove.FlatStyle = FlatStyle.Flat;
            btnremove.Font = new Font("Source Sans Pro", 15F, FontStyle.Bold);
            btnremove.ForeColor = SystemColors.ButtonHighlight;
            btnremove.Location = new Point(622, 321);
            btnremove.Name = "btnremove";
            btnremove.Size = new Size(182, 43);
            btnremove.TabIndex = 11;
            btnremove.Text = "Remove Customer";
            btnremove.UseVisualStyleBackColor = false;
            btnremove.Click += btnremove_Click;
            // 
            // btnedit
            // 
            btnedit.BackColor = Color.Orange;
            btnedit.FlatAppearance.BorderColor = Color.White;
            btnedit.FlatStyle = FlatStyle.Flat;
            btnedit.Font = new Font("Source Sans Pro", 15F, FontStyle.Bold);
            btnedit.ForeColor = SystemColors.ButtonHighlight;
            btnedit.Location = new Point(443, 320);
            btnedit.Name = "btnedit";
            btnedit.Size = new Size(158, 44);
            btnedit.TabIndex = 10;
            btnedit.Text = "Save Changes";
            btnedit.UseVisualStyleBackColor = false;
            btnedit.Click += btnedit_Click;
            // 
            // btnview
            // 
            btnview.BackColor = Color.RoyalBlue;
            btnview.FlatAppearance.BorderColor = Color.White;
            btnview.FlatStyle = FlatStyle.Flat;
            btnview.Font = new Font("Source Sans Pro", 15F, FontStyle.Bold);
            btnview.ForeColor = SystemColors.ButtonHighlight;
            btnview.Location = new Point(498, 259);
            btnview.Name = "btnview";
            btnview.Size = new Size(226, 44);
            btnview.TabIndex = 9;
            btnview.Text = "View Customer Details";
            btnview.UseVisualStyleBackColor = false;
            btnview.Click += btnview_Click;
            // 
            // btnadd
            // 
            btnadd.BackColor = Color.ForestGreen;
            btnadd.FlatAppearance.BorderColor = Color.White;
            btnadd.FlatStyle = FlatStyle.Flat;
            btnadd.Font = new Font("Source Sans Pro", 15F, FontStyle.Bold);
            btnadd.ForeColor = SystemColors.ButtonHighlight;
            btnadd.Location = new Point(535, 200);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(157, 42);
            btnadd.TabIndex = 8;
            btnadd.Text = "Add Customer";
            btnadd.UseVisualStyleBackColor = false;
            btnadd.Click += btnadd_Click;
            // 
            // txtcity
            // 
            txtcity.Location = new Point(572, 158);
            txtcity.Name = "txtcity";
            txtcity.Size = new Size(173, 23);
            txtcity.TabIndex = 7;
            // 
            // txtaddress
            // 
            txtaddress.Location = new Point(572, 99);
            txtaddress.Name = "txtaddress";
            txtaddress.Size = new Size(173, 23);
            txtaddress.TabIndex = 6;
            // 
            // txtphoneno
            // 
            txtphoneno.Location = new Point(226, 341);
            txtphoneno.Name = "txtphoneno";
            txtphoneno.Size = new Size(173, 23);
            txtphoneno.TabIndex = 5;
            // 
            // txtemail
            // 
            txtemail.Location = new Point(226, 283);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(173, 23);
            txtemail.TabIndex = 4;
            // 
            // txtlastname
            // 
            txtlastname.Location = new Point(226, 222);
            txtlastname.Name = "txtlastname";
            txtlastname.Size = new Size(173, 23);
            txtlastname.TabIndex = 3;
            // 
            // txtfirstname
            // 
            txtfirstname.Location = new Point(226, 164);
            txtfirstname.Name = "txtfirstname";
            txtfirstname.Size = new Size(173, 23);
            txtfirstname.TabIndex = 2;
            // 
            // txtcustomerid
            // 
            txtcustomerid.Location = new Point(226, 99);
            txtcustomerid.Name = "txtcustomerid";
            txtcustomerid.Size = new Size(173, 23);
            txtcustomerid.TabIndex = 1;
            txtcustomerid.TextChanged += txtcustomerid_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Source Sans Pro", 15F, FontStyle.Bold);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(715, -202);
            label10.Name = "label10";
            label10.Size = new Size(67, 25);
            label10.TabIndex = 1;
            label10.Text = "label1";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Source Sans Pro", 15F, FontStyle.Bold);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(792, -97);
            label8.Name = "label8";
            label8.Size = new Size(67, 25);
            label8.TabIndex = 1;
            label8.Text = "label1";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Source Sans Pro", 20F, FontStyle.Bold);
            label9.ForeColor = Color.Gold;
            label9.Location = new Point(301, 20);
            label9.Name = "label9";
            label9.Size = new Size(219, 34);
            label9.TabIndex = 1;
            label9.Text = "Customer Details";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Source Sans Pro", 15F, FontStyle.Bold);
            label7.ForeColor = Color.Cyan;
            label7.Location = new Point(460, 158);
            label7.Name = "label7";
            label7.Size = new Size(48, 25);
            label7.TabIndex = 1;
            label7.Text = "City";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Source Sans Pro", 15F, FontStyle.Bold);
            label6.ForeColor = Color.Cyan;
            label6.Location = new Point(460, 94);
            label6.Name = "label6";
            label6.Size = new Size(81, 25);
            label6.TabIndex = 1;
            label6.Text = "Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Source Sans Pro", 15F, FontStyle.Bold);
            label5.ForeColor = Color.Cyan;
            label5.Location = new Point(85, 336);
            label5.Name = "label5";
            label5.Size = new Size(95, 25);
            label5.TabIndex = 1;
            label5.Text = "Phone No";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Source Sans Pro", 15F, FontStyle.Bold);
            label4.ForeColor = Color.Cyan;
            label4.Location = new Point(85, 278);
            label4.Name = "label4";
            label4.Size = new Size(70, 25);
            label4.TabIndex = 1;
            label4.Text = "E-mail";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Source Sans Pro", 15F, FontStyle.Bold);
            label3.ForeColor = Color.Cyan;
            label3.Location = new Point(85, 217);
            label3.Name = "label3";
            label3.Size = new Size(105, 25);
            label3.TabIndex = 1;
            label3.Text = "Last Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Source Sans Pro", 15F, FontStyle.Bold);
            label2.ForeColor = Color.Cyan;
            label2.Location = new Point(85, 159);
            label2.Name = "label2";
            label2.Size = new Size(108, 25);
            label2.TabIndex = 1;
            label2.Text = "First Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Source Sans Pro", 15F, FontStyle.Bold);
            label1.ForeColor = Color.Cyan;
            label1.Location = new Point(85, 97);
            label1.Name = "label1";
            label1.Size = new Size(121, 25);
            label1.TabIndex = 1;
            label1.Text = "Customer ID";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.DarkOliveGreen;
            tabPage2.Controls.Add(btnremoveproduct);
            tabPage2.Controls.Add(btnsavechanges);
            tabPage2.Controls.Add(btnviewproductdetails);
            tabPage2.Controls.Add(btnaddproduct);
            tabPage2.Controls.Add(txtdescription);
            tabPage2.Controls.Add(txtsupplier);
            tabPage2.Controls.Add(txtquantity);
            tabPage2.Controls.Add(txtprice);
            tabPage2.Controls.Add(txtcategory);
            tabPage2.Controls.Add(txtproductname);
            tabPage2.Controls.Add(txtproductid);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(label14);
            tabPage2.Controls.Add(label15);
            tabPage2.Controls.Add(label16);
            tabPage2.Controls.Add(label17);
            tabPage2.Controls.Add(label18);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(836, 446);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Products";
            tabPage2.Click += tabPage2_Click;
            // 
            // btnremoveproduct
            // 
            btnremoveproduct.BackColor = Color.Red;
            btnremoveproduct.FlatAppearance.BorderColor = Color.White;
            btnremoveproduct.FlatStyle = FlatStyle.Flat;
            btnremoveproduct.Font = new Font("Source Sans Pro", 15F, FontStyle.Bold);
            btnremoveproduct.ForeColor = SystemColors.ButtonHighlight;
            btnremoveproduct.Location = new Point(622, 321);
            btnremoveproduct.Name = "btnremoveproduct";
            btnremoveproduct.Size = new Size(182, 43);
            btnremoveproduct.TabIndex = 30;
            btnremoveproduct.Text = "Remove Product";
            btnremoveproduct.UseVisualStyleBackColor = false;
            btnremoveproduct.Click += btnremoveproduct_Click;
            // 
            // btnsavechanges
            // 
            btnsavechanges.BackColor = Color.Orange;
            btnsavechanges.FlatAppearance.BorderColor = Color.White;
            btnsavechanges.FlatStyle = FlatStyle.Flat;
            btnsavechanges.Font = new Font("Source Sans Pro", 15F, FontStyle.Bold);
            btnsavechanges.ForeColor = SystemColors.ButtonHighlight;
            btnsavechanges.Location = new Point(443, 320);
            btnsavechanges.Name = "btnsavechanges";
            btnsavechanges.Size = new Size(158, 44);
            btnsavechanges.TabIndex = 29;
            btnsavechanges.Text = "Save Changes";
            btnsavechanges.UseVisualStyleBackColor = false;
            btnsavechanges.Click += btnsavechanges_Click;
            // 
            // btnviewproductdetails
            // 
            btnviewproductdetails.BackColor = Color.RoyalBlue;
            btnviewproductdetails.FlatAppearance.BorderColor = Color.White;
            btnviewproductdetails.FlatStyle = FlatStyle.Flat;
            btnviewproductdetails.Font = new Font("Source Sans Pro", 15F, FontStyle.Bold);
            btnviewproductdetails.ForeColor = SystemColors.ButtonHighlight;
            btnviewproductdetails.Location = new Point(498, 259);
            btnviewproductdetails.Name = "btnviewproductdetails";
            btnviewproductdetails.Size = new Size(226, 44);
            btnviewproductdetails.TabIndex = 28;
            btnviewproductdetails.Text = "View Product Details";
            btnviewproductdetails.UseVisualStyleBackColor = false;
            btnviewproductdetails.Click += btnviewproductdetails_Click;
            // 
            // btnaddproduct
            // 
            btnaddproduct.BackColor = Color.ForestGreen;
            btnaddproduct.FlatAppearance.BorderColor = Color.White;
            btnaddproduct.FlatStyle = FlatStyle.Flat;
            btnaddproduct.Font = new Font("Source Sans Pro", 15F, FontStyle.Bold);
            btnaddproduct.ForeColor = SystemColors.ButtonHighlight;
            btnaddproduct.Location = new Point(535, 200);
            btnaddproduct.Name = "btnaddproduct";
            btnaddproduct.Size = new Size(157, 42);
            btnaddproduct.TabIndex = 27;
            btnaddproduct.Text = "Add Product";
            btnaddproduct.UseVisualStyleBackColor = false;
            btnaddproduct.Click += btnaddproduct_Click;
            // 
            // txtdescription
            // 
            txtdescription.Location = new Point(572, 158);
            txtdescription.Name = "txtdescription";
            txtdescription.Size = new Size(173, 23);
            txtdescription.TabIndex = 26;
            // 
            // txtsupplier
            // 
            txtsupplier.Location = new Point(572, 99);
            txtsupplier.Name = "txtsupplier";
            txtsupplier.Size = new Size(173, 23);
            txtsupplier.TabIndex = 25;
            // 
            // txtquantity
            // 
            txtquantity.Location = new Point(226, 341);
            txtquantity.Name = "txtquantity";
            txtquantity.Size = new Size(173, 23);
            txtquantity.TabIndex = 24;
            // 
            // txtprice
            // 
            txtprice.Location = new Point(226, 283);
            txtprice.Name = "txtprice";
            txtprice.Size = new Size(173, 23);
            txtprice.TabIndex = 23;
            // 
            // txtcategory
            // 
            txtcategory.Location = new Point(226, 222);
            txtcategory.Name = "txtcategory";
            txtcategory.Size = new Size(173, 23);
            txtcategory.TabIndex = 22;
            // 
            // txtproductname
            // 
            txtproductname.Location = new Point(226, 164);
            txtproductname.Name = "txtproductname";
            txtproductname.Size = new Size(173, 23);
            txtproductname.TabIndex = 21;
            // 
            // txtproductid
            // 
            txtproductid.Location = new Point(226, 99);
            txtproductid.Name = "txtproductid";
            txtproductid.Size = new Size(173, 23);
            txtproductid.TabIndex = 19;
            txtproductid.TextChanged += txtproductid_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Source Sans Pro", 20F, FontStyle.Bold);
            label11.ForeColor = Color.Gold;
            label11.Location = new Point(301, 20);
            label11.Name = "label11";
            label11.Size = new Size(210, 34);
            label11.TabIndex = 18;
            label11.Text = "Products Details";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Source Sans Pro", 15F, FontStyle.Bold);
            label12.ForeColor = Color.Cyan;
            label12.Location = new Point(460, 158);
            label12.Name = "label12";
            label12.Size = new Size(114, 25);
            label12.TabIndex = 17;
            label12.Text = "Description";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Source Sans Pro", 15F, FontStyle.Bold);
            label13.ForeColor = Color.Cyan;
            label13.Location = new Point(460, 94);
            label13.Name = "label13";
            label13.Size = new Size(86, 25);
            label13.TabIndex = 16;
            label13.Text = "Supplier";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Source Sans Pro", 15F, FontStyle.Bold);
            label14.ForeColor = Color.Cyan;
            label14.Location = new Point(85, 336);
            label14.Name = "label14";
            label14.Size = new Size(91, 25);
            label14.TabIndex = 15;
            label14.Text = "Quantity";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Source Sans Pro", 15F, FontStyle.Bold);
            label15.ForeColor = Color.Cyan;
            label15.Location = new Point(85, 278);
            label15.Name = "label15";
            label15.Size = new Size(56, 25);
            label15.TabIndex = 14;
            label15.Text = "Price";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Source Sans Pro", 15F, FontStyle.Bold);
            label16.ForeColor = Color.Cyan;
            label16.Location = new Point(85, 217);
            label16.Name = "label16";
            label16.Size = new Size(93, 25);
            label16.TabIndex = 13;
            label16.Text = "Category";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Source Sans Pro", 15F, FontStyle.Bold);
            label17.ForeColor = Color.Cyan;
            label17.Location = new Point(85, 159);
            label17.Name = "label17";
            label17.Size = new Size(137, 25);
            label17.TabIndex = 20;
            label17.Text = "Product Name";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Source Sans Pro", 15F, FontStyle.Bold);
            label18.ForeColor = Color.Cyan;
            label18.Location = new Point(85, 97);
            label18.Name = "label18";
            label18.Size = new Size(105, 25);
            label18.TabIndex = 12;
            label18.Text = "Product ID";
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.DarkSlateGray;
            tabPage3.Controls.Add(label42);
            tabPage3.Controls.Add(btnremoveorder);
            tabPage3.Controls.Add(btnsaveedited);
            tabPage3.Controls.Add(btnvieworderdetails);
            tabPage3.Controls.Add(btnaddorder);
            tabPage3.Controls.Add(txttotalamount);
            tabPage3.Controls.Add(txtorderquantity);
            tabPage3.Controls.Add(txtorderdate);
            tabPage3.Controls.Add(txtorderproductid);
            tabPage3.Controls.Add(txtordercustomerid);
            tabPage3.Controls.Add(txtorderid);
            tabPage3.Controls.Add(label19);
            tabPage3.Controls.Add(label21);
            tabPage3.Controls.Add(label22);
            tabPage3.Controls.Add(label23);
            tabPage3.Controls.Add(label24);
            tabPage3.Controls.Add(label25);
            tabPage3.Controls.Add(label26);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(836, 446);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Orders";
            // 
            // label42
            // 
            label42.AutoSize = true;
            label42.Font = new Font("Segoe UI", 10F);
            label42.ForeColor = SystemColors.ControlDark;
            label42.Location = new Point(264, 262);
            label42.Name = "label42";
            label42.Size = new Size(97, 19);
            label42.TabIndex = 50;
            label42.Text = "DD/MM/YYYY";
            // 
            // btnremoveorder
            // 
            btnremoveorder.BackColor = Color.Red;
            btnremoveorder.FlatAppearance.BorderColor = Color.White;
            btnremoveorder.FlatStyle = FlatStyle.Flat;
            btnremoveorder.Font = new Font("Source Sans Pro", 15F, FontStyle.Bold);
            btnremoveorder.ForeColor = SystemColors.ButtonHighlight;
            btnremoveorder.Location = new Point(642, 293);
            btnremoveorder.Name = "btnremoveorder";
            btnremoveorder.Size = new Size(182, 43);
            btnremoveorder.TabIndex = 49;
            btnremoveorder.Text = "Remove Order";
            btnremoveorder.UseVisualStyleBackColor = false;
            btnremoveorder.Click += btnremoveorder_Click;
            // 
            // btnsaveedited
            // 
            btnsaveedited.BackColor = Color.Orange;
            btnsaveedited.FlatAppearance.BorderColor = Color.White;
            btnsaveedited.FlatStyle = FlatStyle.Flat;
            btnsaveedited.Font = new Font("Source Sans Pro", 15F, FontStyle.Bold);
            btnsaveedited.ForeColor = SystemColors.ButtonHighlight;
            btnsaveedited.Location = new Point(463, 292);
            btnsaveedited.Name = "btnsaveedited";
            btnsaveedited.Size = new Size(158, 44);
            btnsaveedited.TabIndex = 48;
            btnsaveedited.Text = "Save Changes";
            btnsaveedited.UseVisualStyleBackColor = false;
            btnsaveedited.Click += btnsaveedited_Click;
            // 
            // btnvieworderdetails
            // 
            btnvieworderdetails.BackColor = Color.RoyalBlue;
            btnvieworderdetails.FlatAppearance.BorderColor = Color.White;
            btnvieworderdetails.FlatStyle = FlatStyle.Flat;
            btnvieworderdetails.Font = new Font("Source Sans Pro", 15F, FontStyle.Bold);
            btnvieworderdetails.ForeColor = SystemColors.ButtonHighlight;
            btnvieworderdetails.Location = new Point(518, 231);
            btnvieworderdetails.Name = "btnvieworderdetails";
            btnvieworderdetails.Size = new Size(226, 44);
            btnvieworderdetails.TabIndex = 47;
            btnvieworderdetails.Text = "View Order Details";
            btnvieworderdetails.UseVisualStyleBackColor = false;
            btnvieworderdetails.Click += btnvieworderdetails_Click;
            // 
            // btnaddorder
            // 
            btnaddorder.BackColor = Color.ForestGreen;
            btnaddorder.FlatAppearance.BorderColor = Color.White;
            btnaddorder.FlatStyle = FlatStyle.Flat;
            btnaddorder.Font = new Font("Source Sans Pro", 15F, FontStyle.Bold);
            btnaddorder.ForeColor = SystemColors.ButtonHighlight;
            btnaddorder.Location = new Point(555, 172);
            btnaddorder.Name = "btnaddorder";
            btnaddorder.Size = new Size(157, 42);
            btnaddorder.TabIndex = 46;
            btnaddorder.Text = "Add Order";
            btnaddorder.UseVisualStyleBackColor = false;
            btnaddorder.Click += btnaddorder_Click;
            // 
            // txttotalamount
            // 
            txttotalamount.Location = new Point(612, 99);
            txttotalamount.Name = "txttotalamount";
            txttotalamount.Size = new Size(173, 23);
            txttotalamount.TabIndex = 44;
            // 
            // txtorderquantity
            // 
            txtorderquantity.Location = new Point(226, 341);
            txtorderquantity.Name = "txtorderquantity";
            txtorderquantity.Size = new Size(173, 23);
            txtorderquantity.TabIndex = 43;
            // 
            // txtorderdate
            // 
            txtorderdate.Location = new Point(226, 283);
            txtorderdate.Name = "txtorderdate";
            txtorderdate.Size = new Size(173, 23);
            txtorderdate.TabIndex = 42;
            // 
            // txtorderproductid
            // 
            txtorderproductid.Location = new Point(226, 222);
            txtorderproductid.Name = "txtorderproductid";
            txtorderproductid.Size = new Size(173, 23);
            txtorderproductid.TabIndex = 41;
            // 
            // txtordercustomerid
            // 
            txtordercustomerid.Location = new Point(226, 164);
            txtordercustomerid.Name = "txtordercustomerid";
            txtordercustomerid.Size = new Size(173, 23);
            txtordercustomerid.TabIndex = 40;
            // 
            // txtorderid
            // 
            txtorderid.Location = new Point(226, 99);
            txtorderid.Name = "txtorderid";
            txtorderid.Size = new Size(173, 23);
            txtorderid.TabIndex = 38;
            txtorderid.TextChanged += txtorderid_TextChanged;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Source Sans Pro", 20F, FontStyle.Bold);
            label19.ForeColor = Color.Gold;
            label19.Location = new Point(301, 20);
            label19.Name = "label19";
            label19.Size = new Size(172, 34);
            label19.TabIndex = 37;
            label19.Text = "Order Details";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Source Sans Pro", 15F, FontStyle.Bold);
            label21.ForeColor = Color.Cyan;
            label21.Location = new Point(460, 94);
            label21.Name = "label21";
            label21.Size = new Size(130, 25);
            label21.TabIndex = 35;
            label21.Text = "Total Amount";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Source Sans Pro", 15F, FontStyle.Bold);
            label22.ForeColor = Color.Cyan;
            label22.Location = new Point(85, 336);
            label22.Name = "label22";
            label22.Size = new Size(91, 25);
            label22.TabIndex = 34;
            label22.Text = "Quantity";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Source Sans Pro", 15F, FontStyle.Bold);
            label23.ForeColor = Color.Cyan;
            label23.Location = new Point(85, 278);
            label23.Name = "label23";
            label23.Size = new Size(109, 25);
            label23.TabIndex = 33;
            label23.Text = "Oredr Date";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Source Sans Pro", 15F, FontStyle.Bold);
            label24.ForeColor = Color.Cyan;
            label24.Location = new Point(85, 217);
            label24.Name = "label24";
            label24.Size = new Size(105, 25);
            label24.TabIndex = 32;
            label24.Text = "Product ID";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Source Sans Pro", 15F, FontStyle.Bold);
            label25.ForeColor = Color.Cyan;
            label25.Location = new Point(85, 159);
            label25.Name = "label25";
            label25.Size = new Size(121, 25);
            label25.TabIndex = 39;
            label25.Text = "Customer ID";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Source Sans Pro", 15F, FontStyle.Bold);
            label26.ForeColor = Color.Cyan;
            label26.Location = new Point(85, 97);
            label26.Name = "label26";
            label26.Size = new Size(86, 25);
            label26.TabIndex = 31;
            label26.Text = "Order ID";
            // 
            // tabPage4
            // 
            tabPage4.BackColor = Color.DimGray;
            tabPage4.Controls.Add(btnremoveemployee);
            tabPage4.Controls.Add(btnesavechanges);
            tabPage4.Controls.Add(btnviewemployeedetails);
            tabPage4.Controls.Add(btnaddemployee);
            tabPage4.Controls.Add(txtdepartment);
            tabPage4.Controls.Add(txtsalary);
            tabPage4.Controls.Add(txtposition);
            tabPage4.Controls.Add(txtage);
            tabPage4.Controls.Add(txtelastname);
            tabPage4.Controls.Add(txtefirstname);
            tabPage4.Controls.Add(txtemployerid);
            tabPage4.Controls.Add(label20);
            tabPage4.Controls.Add(label27);
            tabPage4.Controls.Add(label28);
            tabPage4.Controls.Add(label29);
            tabPage4.Controls.Add(label30);
            tabPage4.Controls.Add(label31);
            tabPage4.Controls.Add(label32);
            tabPage4.Controls.Add(label33);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(836, 446);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Employees";
            // 
            // btnremoveemployee
            // 
            btnremoveemployee.BackColor = Color.Red;
            btnremoveemployee.FlatAppearance.BorderColor = Color.White;
            btnremoveemployee.FlatStyle = FlatStyle.Flat;
            btnremoveemployee.Font = new Font("Source Sans Pro", 15F, FontStyle.Bold);
            btnremoveemployee.ForeColor = SystemColors.ButtonHighlight;
            btnremoveemployee.Location = new Point(622, 321);
            btnremoveemployee.Name = "btnremoveemployee";
            btnremoveemployee.Size = new Size(182, 43);
            btnremoveemployee.TabIndex = 49;
            btnremoveemployee.Text = "Remove Employee";
            btnremoveemployee.UseVisualStyleBackColor = false;
            btnremoveemployee.Click += btnremoveemployee_Click;
            // 
            // btnesavechanges
            // 
            btnesavechanges.BackColor = Color.Orange;
            btnesavechanges.FlatAppearance.BorderColor = Color.White;
            btnesavechanges.FlatStyle = FlatStyle.Flat;
            btnesavechanges.Font = new Font("Source Sans Pro", 15F, FontStyle.Bold);
            btnesavechanges.ForeColor = SystemColors.ButtonHighlight;
            btnesavechanges.Location = new Point(443, 320);
            btnesavechanges.Name = "btnesavechanges";
            btnesavechanges.Size = new Size(158, 44);
            btnesavechanges.TabIndex = 48;
            btnesavechanges.Text = "Save Changes";
            btnesavechanges.UseVisualStyleBackColor = false;
            btnesavechanges.Click += btnesavechanges_Click;
            // 
            // btnviewemployeedetails
            // 
            btnviewemployeedetails.BackColor = Color.RoyalBlue;
            btnviewemployeedetails.FlatAppearance.BorderColor = Color.White;
            btnviewemployeedetails.FlatStyle = FlatStyle.Flat;
            btnviewemployeedetails.Font = new Font("Source Sans Pro", 15F, FontStyle.Bold);
            btnviewemployeedetails.ForeColor = SystemColors.ButtonHighlight;
            btnviewemployeedetails.Location = new Point(498, 259);
            btnviewemployeedetails.Name = "btnviewemployeedetails";
            btnviewemployeedetails.Size = new Size(226, 44);
            btnviewemployeedetails.TabIndex = 47;
            btnviewemployeedetails.Text = "View Employee Details";
            btnviewemployeedetails.UseVisualStyleBackColor = false;
            btnviewemployeedetails.Click += btnviewemployeedetails_Click;
            // 
            // btnaddemployee
            // 
            btnaddemployee.BackColor = Color.ForestGreen;
            btnaddemployee.FlatAppearance.BorderColor = Color.White;
            btnaddemployee.FlatStyle = FlatStyle.Flat;
            btnaddemployee.Font = new Font("Source Sans Pro", 15F, FontStyle.Bold);
            btnaddemployee.ForeColor = SystemColors.ButtonHighlight;
            btnaddemployee.Location = new Point(535, 200);
            btnaddemployee.Name = "btnaddemployee";
            btnaddemployee.Size = new Size(157, 42);
            btnaddemployee.TabIndex = 46;
            btnaddemployee.Text = "Add Employee";
            btnaddemployee.UseVisualStyleBackColor = false;
            btnaddemployee.Click += btnaddemployee_Click;
            // 
            // txtdepartment
            // 
            txtdepartment.Location = new Point(585, 158);
            txtdepartment.Name = "txtdepartment";
            txtdepartment.Size = new Size(173, 23);
            txtdepartment.TabIndex = 45;
            // 
            // txtsalary
            // 
            txtsalary.Location = new Point(585, 99);
            txtsalary.Name = "txtsalary";
            txtsalary.Size = new Size(173, 23);
            txtsalary.TabIndex = 44;
            // 
            // txtposition
            // 
            txtposition.Location = new Point(226, 341);
            txtposition.Name = "txtposition";
            txtposition.Size = new Size(173, 23);
            txtposition.TabIndex = 43;
            // 
            // txtage
            // 
            txtage.Location = new Point(226, 283);
            txtage.Name = "txtage";
            txtage.Size = new Size(173, 23);
            txtage.TabIndex = 42;
            // 
            // txtelastname
            // 
            txtelastname.Location = new Point(226, 222);
            txtelastname.Name = "txtelastname";
            txtelastname.Size = new Size(173, 23);
            txtelastname.TabIndex = 41;
            // 
            // txtefirstname
            // 
            txtefirstname.Location = new Point(226, 164);
            txtefirstname.Name = "txtefirstname";
            txtefirstname.Size = new Size(173, 23);
            txtefirstname.TabIndex = 40;
            // 
            // txtemployerid
            // 
            txtemployerid.Location = new Point(226, 99);
            txtemployerid.Name = "txtemployerid";
            txtemployerid.Size = new Size(173, 23);
            txtemployerid.TabIndex = 38;
            txtemployerid.TextChanged += txtemployerid_TextChanged;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Source Sans Pro", 20F, FontStyle.Bold);
            label20.ForeColor = Color.Gold;
            label20.Location = new Point(301, 20);
            label20.Name = "label20";
            label20.Size = new Size(233, 34);
            label20.TabIndex = 37;
            label20.Text = "Employees Details";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Source Sans Pro", 15F, FontStyle.Bold);
            label27.ForeColor = Color.Cyan;
            label27.Location = new Point(460, 158);
            label27.Name = "label27";
            label27.Size = new Size(119, 25);
            label27.TabIndex = 36;
            label27.Text = "Department";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Source Sans Pro", 15F, FontStyle.Bold);
            label28.ForeColor = Color.Cyan;
            label28.Location = new Point(460, 94);
            label28.Name = "label28";
            label28.Size = new Size(69, 25);
            label28.TabIndex = 35;
            label28.Text = "Salary";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Font = new Font("Source Sans Pro", 15F, FontStyle.Bold);
            label29.ForeColor = Color.Cyan;
            label29.Location = new Point(85, 336);
            label29.Name = "label29";
            label29.Size = new Size(86, 25);
            label29.TabIndex = 34;
            label29.Text = "Position";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Source Sans Pro", 15F, FontStyle.Bold);
            label30.ForeColor = Color.Cyan;
            label30.Location = new Point(85, 278);
            label30.Name = "label30";
            label30.Size = new Size(44, 25);
            label30.TabIndex = 33;
            label30.Text = "Age";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Source Sans Pro", 15F, FontStyle.Bold);
            label31.ForeColor = Color.Cyan;
            label31.Location = new Point(85, 217);
            label31.Name = "label31";
            label31.Size = new Size(105, 25);
            label31.TabIndex = 32;
            label31.Text = "Last Name";
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Font = new Font("Source Sans Pro", 15F, FontStyle.Bold);
            label32.ForeColor = Color.Cyan;
            label32.Location = new Point(85, 159);
            label32.Name = "label32";
            label32.Size = new Size(108, 25);
            label32.TabIndex = 39;
            label32.Text = "First Name";
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Font = new Font("Source Sans Pro", 15F, FontStyle.Bold);
            label33.ForeColor = Color.Cyan;
            label33.Location = new Point(85, 97);
            label33.Name = "label33";
            label33.Size = new Size(119, 25);
            label33.TabIndex = 31;
            label33.Text = "Employer ID";
            // 
            // tabPage5
            // 
            tabPage5.BackColor = Color.Teal;
            tabPage5.Controls.Add(btnremovesupplier);
            tabPage5.Controls.Add(b);
            tabPage5.Controls.Add(btnviewsupplierdetails);
            tabPage5.Controls.Add(btnaddsupplier);
            tabPage5.Controls.Add(txtscity);
            tabPage5.Controls.Add(txtsaddress);
            tabPage5.Controls.Add(txtsphone);
            tabPage5.Controls.Add(txtsemail);
            tabPage5.Controls.Add(txtcontactname);
            tabPage5.Controls.Add(txtsuppliername);
            tabPage5.Controls.Add(txtsupplierid);
            tabPage5.Controls.Add(label34);
            tabPage5.Controls.Add(label35);
            tabPage5.Controls.Add(label36);
            tabPage5.Controls.Add(label37);
            tabPage5.Controls.Add(label38);
            tabPage5.Controls.Add(label39);
            tabPage5.Controls.Add(label40);
            tabPage5.Controls.Add(label41);
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(836, 446);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Suppliers";
            // 
            // btnremovesupplier
            // 
            btnremovesupplier.BackColor = Color.Red;
            btnremovesupplier.FlatAppearance.BorderColor = Color.White;
            btnremovesupplier.FlatStyle = FlatStyle.Flat;
            btnremovesupplier.Font = new Font("Source Sans Pro", 15F, FontStyle.Bold);
            btnremovesupplier.ForeColor = SystemColors.ButtonHighlight;
            btnremovesupplier.Location = new Point(622, 321);
            btnremovesupplier.Name = "btnremovesupplier";
            btnremovesupplier.Size = new Size(182, 43);
            btnremovesupplier.TabIndex = 49;
            btnremovesupplier.Text = "Remove Supplier";
            btnremovesupplier.UseVisualStyleBackColor = false;
            btnremovesupplier.Click += btnremovesupplier_Click;
            // 
            // b
            // 
            b.BackColor = Color.Orange;
            b.FlatAppearance.BorderColor = Color.White;
            b.FlatStyle = FlatStyle.Flat;
            b.Font = new Font("Source Sans Pro", 15F, FontStyle.Bold);
            b.ForeColor = SystemColors.ButtonHighlight;
            b.Location = new Point(443, 320);
            b.Name = "b";
            b.Size = new Size(158, 44);
            b.TabIndex = 48;
            b.Text = "Save Changes";
            b.UseVisualStyleBackColor = false;
            b.Click += b_Click;
            // 
            // btnviewsupplierdetails
            // 
            btnviewsupplierdetails.BackColor = Color.RoyalBlue;
            btnviewsupplierdetails.FlatAppearance.BorderColor = Color.White;
            btnviewsupplierdetails.FlatStyle = FlatStyle.Flat;
            btnviewsupplierdetails.Font = new Font("Source Sans Pro", 15F, FontStyle.Bold);
            btnviewsupplierdetails.ForeColor = SystemColors.ButtonHighlight;
            btnviewsupplierdetails.Location = new Point(498, 259);
            btnviewsupplierdetails.Name = "btnviewsupplierdetails";
            btnviewsupplierdetails.Size = new Size(226, 44);
            btnviewsupplierdetails.TabIndex = 47;
            btnviewsupplierdetails.Text = "View Supplier Details";
            btnviewsupplierdetails.UseVisualStyleBackColor = false;
            btnviewsupplierdetails.Click += btnviewsupplierdetails_Click;
            // 
            // btnaddsupplier
            // 
            btnaddsupplier.BackColor = Color.ForestGreen;
            btnaddsupplier.FlatAppearance.BorderColor = Color.White;
            btnaddsupplier.FlatStyle = FlatStyle.Flat;
            btnaddsupplier.Font = new Font("Source Sans Pro", 15F, FontStyle.Bold);
            btnaddsupplier.ForeColor = SystemColors.ButtonHighlight;
            btnaddsupplier.Location = new Point(535, 200);
            btnaddsupplier.Name = "btnaddsupplier";
            btnaddsupplier.Size = new Size(157, 42);
            btnaddsupplier.TabIndex = 46;
            btnaddsupplier.Text = "Add Supplier";
            btnaddsupplier.UseVisualStyleBackColor = false;
            btnaddsupplier.Click += btnaddsupplier_Click;
            // 
            // txtscity
            // 
            txtscity.Location = new Point(572, 158);
            txtscity.Name = "txtscity";
            txtscity.Size = new Size(173, 23);
            txtscity.TabIndex = 45;
            // 
            // txtsaddress
            // 
            txtsaddress.Location = new Point(572, 99);
            txtsaddress.Name = "txtsaddress";
            txtsaddress.Size = new Size(173, 23);
            txtsaddress.TabIndex = 44;
            // 
            // txtsphone
            // 
            txtsphone.Location = new Point(226, 341);
            txtsphone.Name = "txtsphone";
            txtsphone.Size = new Size(173, 23);
            txtsphone.TabIndex = 43;
            // 
            // txtsemail
            // 
            txtsemail.Location = new Point(226, 283);
            txtsemail.Name = "txtsemail";
            txtsemail.Size = new Size(173, 23);
            txtsemail.TabIndex = 42;
            // 
            // txtcontactname
            // 
            txtcontactname.Location = new Point(226, 222);
            txtcontactname.Name = "txtcontactname";
            txtcontactname.Size = new Size(173, 23);
            txtcontactname.TabIndex = 41;
            // 
            // txtsuppliername
            // 
            txtsuppliername.Location = new Point(226, 164);
            txtsuppliername.Name = "txtsuppliername";
            txtsuppliername.Size = new Size(173, 23);
            txtsuppliername.TabIndex = 40;
            // 
            // txtsupplierid
            // 
            txtsupplierid.Location = new Point(226, 99);
            txtsupplierid.Name = "txtsupplierid";
            txtsupplierid.Size = new Size(173, 23);
            txtsupplierid.TabIndex = 38;
            txtsupplierid.TextChanged += txtsupplierid_TextChanged;
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Font = new Font("Source Sans Pro", 20F, FontStyle.Bold);
            label34.ForeColor = Color.Gold;
            label34.Location = new Point(301, 20);
            label34.Name = "label34";
            label34.Size = new Size(215, 34);
            label34.TabIndex = 37;
            label34.Text = "Suppliers Details";
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Font = new Font("Source Sans Pro", 15F, FontStyle.Bold);
            label35.ForeColor = Color.Cyan;
            label35.Location = new Point(460, 158);
            label35.Name = "label35";
            label35.Size = new Size(48, 25);
            label35.TabIndex = 36;
            label35.Text = "City";
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Font = new Font("Source Sans Pro", 15F, FontStyle.Bold);
            label36.ForeColor = Color.Cyan;
            label36.Location = new Point(460, 94);
            label36.Name = "label36";
            label36.Size = new Size(81, 25);
            label36.TabIndex = 35;
            label36.Text = "Address";
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Font = new Font("Source Sans Pro", 15F, FontStyle.Bold);
            label37.ForeColor = Color.Cyan;
            label37.Location = new Point(85, 336);
            label37.Name = "label37";
            label37.Size = new Size(67, 25);
            label37.TabIndex = 34;
            label37.Text = "Phone";
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.Font = new Font("Source Sans Pro", 15F, FontStyle.Bold);
            label38.ForeColor = Color.Cyan;
            label38.Location = new Point(85, 278);
            label38.Name = "label38";
            label38.Size = new Size(63, 25);
            label38.TabIndex = 33;
            label38.Text = "Email";
            // 
            // label39
            // 
            label39.AutoSize = true;
            label39.Font = new Font("Source Sans Pro", 15F, FontStyle.Bold);
            label39.ForeColor = Color.Cyan;
            label39.Location = new Point(85, 217);
            label39.Name = "label39";
            label39.Size = new Size(137, 25);
            label39.TabIndex = 32;
            label39.Text = "Contact Name";
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.Font = new Font("Source Sans Pro", 15F, FontStyle.Bold);
            label40.ForeColor = Color.Cyan;
            label40.Location = new Point(85, 159);
            label40.Name = "label40";
            label40.Size = new Size(141, 25);
            label40.TabIndex = 39;
            label40.Text = "Supplier Name";
            // 
            // label41
            // 
            label41.AutoSize = true;
            label41.Font = new Font("Source Sans Pro", 15F, FontStyle.Bold);
            label41.ForeColor = Color.Cyan;
            label41.Location = new Point(85, 97);
            label41.Name = "label41";
            label41.Size = new Size(109, 25);
            label41.TabIndex = 31;
            label41.Text = "Supplier ID";
            // 
            // frmabccompany
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(841, 471);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmabccompany";
            Text = "ABC Company";
            Load += frmabccompany_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private Button btnadd;
        private TextBox txtcustomerid;
        private Label label1;
        private Button btnremove;
        private Button btnedit;
        private Button btnview;
        private TextBox txtcity;
        private TextBox txtaddress;
        private TextBox txtphoneno;
        private TextBox txtemail;
        private TextBox txtlastname;
        private TextBox txtfirstname;
        private Label label10;
        private Label label8;
        private Label label9;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnremoveproduct;
        private Button btnsavechanges;
        private Button btnviewproductdetails;
        private Button btnaddproduct;
        private TextBox txtdescription;
        private TextBox txtsupplier;
        private TextBox txtquantity;
        private TextBox txtprice;
        private TextBox txtcategory;
        private TextBox txtproductname;
        private TextBox txtproductid;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Button btnremoveorder;
        private Button btnsaveedited;
        private Button btnvieworderdetails;
        private Button btnaddorder;
        private TextBox txttotalamount;
        private TextBox txtorderquantity;
        private TextBox txtorderdate;
        private TextBox txtorderproductid;
        private TextBox txtordercustomerid;
        private TextBox txtorderid;
        private Label label19;
        private Label label21;
        private Label label22;
        private Label label23;
        private Label label24;
        private Label label25;
        private Label label26;
        private Button btnremoveemployee;
        private Button btnesavechanges;
        private Button btnviewemployeedetails;
        private Button btnaddemployee;
        private TextBox txtdepartment;
        private TextBox txtsalary;
        private TextBox txtposition;
        private TextBox txtage;
        private TextBox txtelastname;
        private TextBox txtefirstname;
        private TextBox txtemployerid;
        private Label label20;
        private Label label27;
        private Label label28;
        private Label label29;
        private Label label30;
        private Label label31;
        private Label label32;
        private Label label33;
        private Button btnremovesupplier;
        private Button b;
        private Button btnviewsupplierdetails;
        private Button btnaddsupplier;
        private TextBox txtscity;
        private TextBox txtsaddress;
        private TextBox txtsphone;
        private TextBox txtsemail;
        private TextBox txtcontactname;
        private TextBox txtsuppliername;
        private TextBox txtsupplierid;
        private Label label34;
        private Label label35;
        private Label label36;
        private Label label37;
        private Label label38;
        private Label label39;
        private Label label40;
        private Label label41;
        private Label label42;
    }
}
