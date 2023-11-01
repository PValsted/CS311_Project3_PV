namespace CS311_Project3_PV
{
    partial class PizzaApp
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
            pictPizza = new PictureBox();
            lblTitle = new Label();
            cboSize = new ComboBox();
            grpCrust = new GroupBox();
            rdoReg = new RadioButton();
            rdoThick = new RadioButton();
            rdoThin = new RadioButton();
            lblSize = new Label();
            pnlBorder = new Panel();
            ckbMushroom = new CheckBox();
            ckbCheese = new CheckBox();
            ckbJalepeno = new CheckBox();
            ckbBanPepper = new CheckBox();
            ckbGrnOlive = new CheckBox();
            ckbBlOlive = new CheckBox();
            ckbGrnPepper = new CheckBox();
            ckbOnion = new CheckBox();
            ckbSpicySausage = new CheckBox();
            ckbCBacon = new CheckBox();
            ckbSausage = new CheckBox();
            ckbPepperoni = new CheckBox();
            lblToppings = new Label();
            lblSummary = new Label();
            rtfSummary = new RichTextBox();
            lblSub = new Label();
            lblTax = new Label();
            lblTotal = new Label();
            txtSub = new TextBox();
            txtTax = new TextBox();
            txtTotal = new TextBox();
            btnCalculate = new Button();
            ((System.ComponentModel.ISupportInitialize)pictPizza).BeginInit();
            grpCrust.SuspendLayout();
            pnlBorder.SuspendLayout();
            SuspendLayout();
            // 
            // pictPizza
            // 
            pictPizza.Image = Properties.Resources.pepperoni_pizza_slice;
            pictPizza.Location = new Point(86, 35);
            pictPizza.Name = "pictPizza";
            pictPizza.Size = new Size(146, 129);
            pictPizza.SizeMode = PictureBoxSizeMode.StretchImage;
            pictPizza.TabIndex = 0;
            pictPizza.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Snap ITC", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.Location = new Point(259, 70);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(445, 63);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Alfredo's Pizza";
            // 
            // cboSize
            // 
            cboSize.FormattingEnabled = true;
            cboSize.Items.AddRange(new object[] { "Small", "Medium", "Large", "X-Large", "Ginormous" });
            cboSize.Location = new Point(83, 35);
            cboSize.Name = "cboSize";
            cboSize.Size = new Size(165, 23);
            cboSize.TabIndex = 2;
            // 
            // grpCrust
            // 
            grpCrust.Controls.Add(rdoReg);
            grpCrust.Controls.Add(rdoThick);
            grpCrust.Controls.Add(rdoThin);
            grpCrust.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            grpCrust.Location = new Point(329, 31);
            grpCrust.Name = "grpCrust";
            grpCrust.RightToLeft = RightToLeft.No;
            grpCrust.Size = new Size(348, 38);
            grpCrust.TabIndex = 3;
            grpCrust.TabStop = false;
            grpCrust.Text = "Crust Type:";
            // 
            // rdoReg
            // 
            rdoReg.AutoSize = true;
            rdoReg.Location = new Point(207, 4);
            rdoReg.Name = "rdoReg";
            rdoReg.Size = new Size(68, 19);
            rdoReg.TabIndex = 2;
            rdoReg.TabStop = true;
            rdoReg.Text = "Regular";
            rdoReg.UseVisualStyleBackColor = true;
            // 
            // rdoThick
            // 
            rdoThick.AutoSize = true;
            rdoThick.Location = new Point(146, 4);
            rdoThick.Name = "rdoThick";
            rdoThick.Size = new Size(55, 19);
            rdoThick.TabIndex = 1;
            rdoThick.TabStop = true;
            rdoThick.Text = "Thick";
            rdoThick.UseVisualStyleBackColor = true;
            // 
            // rdoThin
            // 
            rdoThin.AutoSize = true;
            rdoThin.Location = new Point(91, 4);
            rdoThin.Name = "rdoThin";
            rdoThin.Size = new Size(49, 19);
            rdoThin.TabIndex = 0;
            rdoThin.TabStop = true;
            rdoThin.Text = "Thin";
            rdoThin.UseVisualStyleBackColor = true;
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSize.Location = new Point(35, 39);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(33, 15);
            lblSize.TabIndex = 4;
            lblSize.Text = "Size:";
            // 
            // pnlBorder
            // 
            pnlBorder.BorderStyle = BorderStyle.FixedSingle;
            pnlBorder.Controls.Add(ckbMushroom);
            pnlBorder.Controls.Add(ckbCheese);
            pnlBorder.Controls.Add(ckbJalepeno);
            pnlBorder.Controls.Add(ckbBanPepper);
            pnlBorder.Controls.Add(ckbGrnOlive);
            pnlBorder.Controls.Add(ckbBlOlive);
            pnlBorder.Controls.Add(ckbGrnPepper);
            pnlBorder.Controls.Add(ckbOnion);
            pnlBorder.Controls.Add(ckbSpicySausage);
            pnlBorder.Controls.Add(ckbCBacon);
            pnlBorder.Controls.Add(ckbSausage);
            pnlBorder.Controls.Add(ckbPepperoni);
            pnlBorder.Controls.Add(lblToppings);
            pnlBorder.Controls.Add(grpCrust);
            pnlBorder.Controls.Add(lblSize);
            pnlBorder.Controls.Add(cboSize);
            pnlBorder.Location = new Point(86, 201);
            pnlBorder.Name = "pnlBorder";
            pnlBorder.Size = new Size(769, 223);
            pnlBorder.TabIndex = 5;
            // 
            // ckbMushroom
            // 
            ckbMushroom.AutoSize = true;
            ckbMushroom.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ckbMushroom.Location = new Point(364, 186);
            ckbMushroom.Name = "ckbMushroom";
            ckbMushroom.Size = new Size(86, 19);
            ckbMushroom.TabIndex = 17;
            ckbMushroom.Text = "Mushroom";
            ckbMushroom.UseVisualStyleBackColor = true;
            // 
            // ckbCheese
            // 
            ckbCheese.AutoSize = true;
            ckbCheese.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ckbCheese.Location = new Point(364, 161);
            ckbCheese.Name = "ckbCheese";
            ckbCheese.Size = new Size(98, 19);
            ckbCheese.TabIndex = 16;
            ckbCheese.Text = "Extra Cheese";
            ckbCheese.UseVisualStyleBackColor = true;
            // 
            // ckbJalepeno
            // 
            ckbJalepeno.AutoSize = true;
            ckbJalepeno.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ckbJalepeno.Location = new Point(364, 136);
            ckbJalepeno.Name = "ckbJalepeno";
            ckbJalepeno.Size = new Size(75, 19);
            ckbJalepeno.TabIndex = 15;
            ckbJalepeno.Text = "Jalepeno";
            ckbJalepeno.UseVisualStyleBackColor = true;
            // 
            // ckbBanPepper
            // 
            ckbBanPepper.AutoSize = true;
            ckbBanPepper.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ckbBanPepper.Location = new Point(364, 111);
            ckbBanPepper.Name = "ckbBanPepper";
            ckbBanPepper.Size = new Size(114, 19);
            ckbBanPepper.TabIndex = 14;
            ckbBanPepper.Text = "Banana Peppers";
            ckbBanPepper.UseVisualStyleBackColor = true;
            // 
            // ckbGrnOlive
            // 
            ckbGrnOlive.AutoSize = true;
            ckbGrnOlive.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ckbGrnOlive.Location = new Point(211, 186);
            ckbGrnOlive.Name = "ckbGrnOlive";
            ckbGrnOlive.Size = new Size(98, 19);
            ckbGrnOlive.TabIndex = 13;
            ckbGrnOlive.Text = "Green Olives";
            ckbGrnOlive.UseVisualStyleBackColor = true;
            // 
            // ckbBlOlive
            // 
            ckbBlOlive.AutoSize = true;
            ckbBlOlive.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ckbBlOlive.Location = new Point(211, 161);
            ckbBlOlive.Name = "ckbBlOlive";
            ckbBlOlive.Size = new Size(93, 19);
            ckbBlOlive.TabIndex = 12;
            ckbBlOlive.Text = "Black Olives";
            ckbBlOlive.UseVisualStyleBackColor = true;
            // 
            // ckbGrnPepper
            // 
            ckbGrnPepper.AutoSize = true;
            ckbGrnPepper.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ckbGrnPepper.Location = new Point(211, 136);
            ckbGrnPepper.Name = "ckbGrnPepper";
            ckbGrnPepper.Size = new Size(109, 19);
            ckbGrnPepper.TabIndex = 11;
            ckbGrnPepper.Text = "Green Peppers";
            ckbGrnPepper.UseVisualStyleBackColor = true;
            // 
            // ckbOnion
            // 
            ckbOnion.AutoSize = true;
            ckbOnion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ckbOnion.Location = new Point(211, 111);
            ckbOnion.Name = "ckbOnion";
            ckbOnion.Size = new Size(59, 19);
            ckbOnion.TabIndex = 10;
            ckbOnion.Text = "Onion";
            ckbOnion.UseVisualStyleBackColor = true;
            // 
            // ckbSpicySausage
            // 
            ckbSpicySausage.AutoSize = true;
            ckbSpicySausage.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ckbSpicySausage.Location = new Point(35, 186);
            ckbSpicySausage.Name = "ckbSpicySausage";
            ckbSpicySausage.Size = new Size(140, 19);
            ckbSpicySausage.TabIndex = 9;
            ckbSpicySausage.Text = "Spicy Italian Sausage";
            ckbSpicySausage.UseVisualStyleBackColor = true;
            // 
            // ckbCBacon
            // 
            ckbCBacon.AutoSize = true;
            ckbCBacon.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ckbCBacon.Location = new Point(35, 161);
            ckbCBacon.Name = "ckbCBacon";
            ckbCBacon.Size = new Size(112, 19);
            ckbCBacon.TabIndex = 8;
            ckbCBacon.Text = "Canadian Bacon";
            ckbCBacon.UseVisualStyleBackColor = true;
            // 
            // ckbSausage
            // 
            ckbSausage.AutoSize = true;
            ckbSausage.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ckbSausage.Location = new Point(35, 136);
            ckbSausage.Name = "ckbSausage";
            ckbSausage.Size = new Size(71, 19);
            ckbSausage.TabIndex = 7;
            ckbSausage.Text = "Sausage";
            ckbSausage.UseVisualStyleBackColor = true;
            // 
            // ckbPepperoni
            // 
            ckbPepperoni.AutoSize = true;
            ckbPepperoni.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ckbPepperoni.Location = new Point(35, 111);
            ckbPepperoni.Name = "ckbPepperoni";
            ckbPepperoni.Size = new Size(83, 19);
            ckbPepperoni.TabIndex = 6;
            ckbPepperoni.Text = "Pepperoni";
            ckbPepperoni.UseVisualStyleBackColor = true;
            // 
            // lblToppings
            // 
            lblToppings.AutoSize = true;
            lblToppings.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblToppings.Location = new Point(9, 74);
            lblToppings.Name = "lblToppings";
            lblToppings.Size = new Size(59, 15);
            lblToppings.TabIndex = 5;
            lblToppings.Text = "Toppings:";
            // 
            // lblSummary
            // 
            lblSummary.AutoSize = true;
            lblSummary.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSummary.Location = new Point(56, 457);
            lblSummary.Name = "lblSummary";
            lblSummary.Size = new Size(99, 15);
            lblSummary.TabIndex = 6;
            lblSummary.Text = "Order Summary:";
            // 
            // rtfSummary
            // 
            rtfSummary.Location = new Point(161, 440);
            rtfSummary.Name = "rtfSummary";
            rtfSummary.Size = new Size(500, 169);
            rtfSummary.TabIndex = 7;
            rtfSummary.Text = "";
            // 
            // lblSub
            // 
            lblSub.AutoSize = true;
            lblSub.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSub.Location = new Point(679, 442);
            lblSub.Name = "lblSub";
            lblSub.Size = new Size(58, 15);
            lblSub.TabIndex = 8;
            lblSub.Text = "SubTotal:";
            // 
            // lblTax
            // 
            lblTax.AutoSize = true;
            lblTax.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTax.Location = new Point(708, 471);
            lblTax.Name = "lblTax";
            lblTax.Size = new Size(29, 15);
            lblTax.TabIndex = 9;
            lblTax.Text = "Tax:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal.Location = new Point(700, 500);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(37, 15);
            lblTotal.TabIndex = 10;
            lblTotal.Text = "Total:";
            // 
            // txtSub
            // 
            txtSub.Location = new Point(743, 439);
            txtSub.Name = "txtSub";
            txtSub.Size = new Size(112, 23);
            txtSub.TabIndex = 11;
            // 
            // txtTax
            // 
            txtTax.Location = new Point(743, 468);
            txtTax.Name = "txtTax";
            txtTax.Size = new Size(112, 23);
            txtTax.TabIndex = 12;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(743, 497);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(112, 23);
            txtTotal.TabIndex = 13;
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = SystemColors.ButtonFace;
            btnCalculate.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            btnCalculate.Location = new Point(667, 536);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(188, 73);
            btnCalculate.TabIndex = 14;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // PizzaApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(987, 640);
            Controls.Add(btnCalculate);
            Controls.Add(txtTotal);
            Controls.Add(txtTax);
            Controls.Add(txtSub);
            Controls.Add(lblTotal);
            Controls.Add(lblTax);
            Controls.Add(lblSub);
            Controls.Add(rtfSummary);
            Controls.Add(lblSummary);
            Controls.Add(pnlBorder);
            Controls.Add(lblTitle);
            Controls.Add(pictPizza);
            Name = "PizzaApp";
            Text = " Alfredo's Pizza";
            ((System.ComponentModel.ISupportInitialize)pictPizza).EndInit();
            grpCrust.ResumeLayout(false);
            grpCrust.PerformLayout();
            pnlBorder.ResumeLayout(false);
            pnlBorder.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictPizza;
        private Label lblTitle;
        private ComboBox cboSize;
        private GroupBox grpCrust;
        private RadioButton rdoReg;
        private RadioButton rdoThick;
        private RadioButton rdoThin;
        private Label lblSize;
        private Panel pnlBorder;
        private CheckBox ckbCBacon;
        private CheckBox ckbSausage;
        private CheckBox ckbPepperoni;
        private Label lblToppings;
        private CheckBox ckbBanPepper;
        private CheckBox ckbGrnOlive;
        private CheckBox ckbBlOlive;
        private CheckBox ckbGrnPepper;
        private CheckBox ckbOnion;
        private CheckBox ckbSpicySausage;
        private CheckBox ckbCheese;
        private CheckBox ckbJalepeno;
        private CheckBox ckbMushroom;
        private Label lblSummary;
        private RichTextBox rtfSummary;
        private Label lblSub;
        private Label lblTax;
        private Label lblTotal;
        private TextBox txtSub;
        private TextBox txtTax;
        private TextBox txtTotal;
        private Button btnCalculate;
    }
}