namespace BankForm
{
    partial class Form1
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
            this.lsbCustomer = new System.Windows.Forms.ListBox();
            this.lsbAccounts = new System.Windows.Forms.ListBox();
            this.txbDeposit = new System.Windows.Forms.TextBox();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.txbWithdraw = new System.Windows.Forms.TextBox();
            this.btnWithdrawal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.btnBalance = new System.Windows.Forms.Button();
            this.lblDeposit = new System.Windows.Forms.Label();
            this.lblWithdraw = new System.Windows.Forms.Label();
            this.lsbTransaction = new System.Windows.Forms.ListBox();
            this.btnTransaction = new System.Windows.Forms.Button();
            this.btnInterest = new System.Windows.Forms.Button();
            this.lblTransaction = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lsbCustomer
            // 
            this.lsbCustomer.FormattingEnabled = true;
            this.lsbCustomer.Items.AddRange(new object[] {
            "Customer1"});
            this.lsbCustomer.Location = new System.Drawing.Point(40, 73);
            this.lsbCustomer.Name = "lsbCustomer";
            this.lsbCustomer.Size = new System.Drawing.Size(116, 186);
            this.lsbCustomer.TabIndex = 0;
            // 
            // lsbAccounts
            // 
            this.lsbAccounts.FormattingEnabled = true;
            this.lsbAccounts.Items.AddRange(new object[] {
            "Everyday1",
            "Invest1",
            "Omni1"});
            this.lsbAccounts.Location = new System.Drawing.Point(185, 73);
            this.lsbAccounts.Name = "lsbAccounts";
            this.lsbAccounts.Size = new System.Drawing.Size(231, 186);
            this.lsbAccounts.TabIndex = 1;
            // 
            // txbDeposit
            // 
            this.txbDeposit.Location = new System.Drawing.Point(142, 325);
            this.txbDeposit.Name = "txbDeposit";
            this.txbDeposit.Size = new System.Drawing.Size(100, 20);
            this.txbDeposit.TabIndex = 2;
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(260, 322);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(75, 23);
            this.btnDeposit.TabIndex = 3;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // txbWithdraw
            // 
            this.txbWithdraw.Location = new System.Drawing.Point(142, 374);
            this.txbWithdraw.Name = "txbWithdraw";
            this.txbWithdraw.Size = new System.Drawing.Size(100, 20);
            this.txbWithdraw.TabIndex = 4;
            // 
            // btnWithdrawal
            // 
            this.btnWithdrawal.Location = new System.Drawing.Point(260, 374);
            this.btnWithdrawal.Name = "btnWithdrawal";
            this.btnWithdrawal.Size = new System.Drawing.Size(75, 23);
            this.btnWithdrawal.TabIndex = 5;
            this.btnWithdrawal.Text = "Withdrawal";
            this.btnWithdrawal.UseVisualStyleBackColor = true;
            this.btnWithdrawal.Click += new System.EventHandler(this.btnWithdrawal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter deposit amount:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 381);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Enter withdrawal amount:";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(119, 284);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(10, 13);
            this.lblBalance.TabIndex = 8;
            this.lblBalance.Text = " ";
            // 
            // btnBalance
            // 
            this.btnBalance.Location = new System.Drawing.Point(15, 274);
            this.btnBalance.Name = "btnBalance";
            this.btnBalance.Size = new System.Drawing.Size(98, 23);
            this.btnBalance.TabIndex = 9;
            this.btnBalance.Text = "Check Balance";
            this.btnBalance.UseVisualStyleBackColor = true;
            this.btnBalance.Click += new System.EventHandler(this.btnBalance_Click);
            // 
            // lblDeposit
            // 
            this.lblDeposit.AutoSize = true;
            this.lblDeposit.Location = new System.Drawing.Point(353, 331);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(10, 13);
            this.lblDeposit.TabIndex = 10;
            this.lblDeposit.Text = " ";
            // 
            // lblWithdraw
            // 
            this.lblWithdraw.AutoSize = true;
            this.lblWithdraw.Location = new System.Drawing.Point(356, 381);
            this.lblWithdraw.Name = "lblWithdraw";
            this.lblWithdraw.Size = new System.Drawing.Size(13, 13);
            this.lblWithdraw.TabIndex = 11;
            this.lblWithdraw.Text = "  ";
            // 
            // lsbTransaction
            // 
            this.lsbTransaction.FormattingEnabled = true;
            this.lsbTransaction.Items.AddRange(new object[] {
            "   "});
            this.lsbTransaction.Location = new System.Drawing.Point(457, 73);
            this.lsbTransaction.Name = "lsbTransaction";
            this.lsbTransaction.Size = new System.Drawing.Size(286, 43);
            this.lsbTransaction.TabIndex = 12;
            // 
            // btnTransaction
            // 
            this.btnTransaction.Location = new System.Drawing.Point(457, 235);
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Size = new System.Drawing.Size(97, 23);
            this.btnTransaction.TabIndex = 13;
            this.btnTransaction.Text = "Last Transaction";
            this.btnTransaction.UseVisualStyleBackColor = true;
            this.btnTransaction.Click += new System.EventHandler(this.btnTransaction_Click);
            // 
            // btnInterest
            // 
            this.btnInterest.Location = new System.Drawing.Point(457, 273);
            this.btnInterest.Name = "btnInterest";
            this.btnInterest.Size = new System.Drawing.Size(97, 23);
            this.btnInterest.TabIndex = 14;
            this.btnInterest.Text = "Calculate Interest";
            this.btnInterest.UseVisualStyleBackColor = true;
            this.btnInterest.Click += new System.EventHandler(this.btnInterest_Click);
            // 
            // lblTransaction
            // 
            this.lblTransaction.AutoSize = true;
            this.lblTransaction.Location = new System.Drawing.Point(560, 278);
            this.lblTransaction.Name = "lblTransaction";
            this.lblTransaction.Size = new System.Drawing.Size(13, 13);
            this.lblTransaction.TabIndex = 15;
            this.lblTransaction.Text = "  ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTransaction);
            this.Controls.Add(this.btnInterest);
            this.Controls.Add(this.btnTransaction);
            this.Controls.Add(this.lsbTransaction);
            this.Controls.Add(this.lblWithdraw);
            this.Controls.Add(this.lblDeposit);
            this.Controls.Add(this.btnBalance);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnWithdrawal);
            this.Controls.Add(this.txbWithdraw);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.txbDeposit);
            this.Controls.Add(this.lsbAccounts);
            this.Controls.Add(this.lsbCustomer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsbCustomer;
        private System.Windows.Forms.ListBox lsbAccounts;
        private System.Windows.Forms.TextBox txbDeposit;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.TextBox txbWithdraw;
        private System.Windows.Forms.Button btnWithdrawal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Button btnBalance;
        private System.Windows.Forms.Label lblDeposit;
        private System.Windows.Forms.Label lblWithdraw;
        private System.Windows.Forms.ListBox lsbTransaction;
        private System.Windows.Forms.Button btnTransaction;
        private System.Windows.Forms.Button btnInterest;
        private System.Windows.Forms.Label lblTransaction;
    }
}

