namespace Prog2
{
    partial class InsertAddress
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
            this.components = new System.ComponentModel.Container();
            this.btnAddInsert = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboState = new System.Windows.Forms.ComboBox();
            this.txtZIP = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtAddressLine2 = new System.Windows.Forms.TextBox();
            this.txtAddressLine1 = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.errorProviderName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderAL1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderCity = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderState = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderZip = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAL1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderZip)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddInsert
            // 
            this.btnAddInsert.Location = new System.Drawing.Point(151, 292);
            this.btnAddInsert.Name = "btnAddInsert";
            this.btnAddInsert.Size = new System.Drawing.Size(105, 43);
            this.btnAddInsert.TabIndex = 27;
            this.btnAddInsert.Text = "Insert";
            this.btnAddInsert.UseVisualStyleBackColor = true;
            this.btnAddInsert.Click += new System.EventHandler(this.btnAddInsert_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(30, 292);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 43);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Zip:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "State:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "City:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Address Line 2:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Address Line 1:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Name:";
            // 
            // cboState
            // 
            this.cboState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboState.FormattingEnabled = true;
            this.cboState.Items.AddRange(new object[] {
            "AL",
            "AK",
            "AZ",
            "AR",
            "CA",
            "CO",
            "CT",
            "DE",
            "FL",
            "GA",
            "HA",
            "ID",
            "IL",
            "IN",
            "IA",
            "KS",
            "KY",
            "LA",
            "ME",
            "MD",
            "MA",
            "MI",
            "MN",
            "MS",
            "MO",
            "MT",
            "NE",
            "NV",
            "ND",
            "NM",
            "NY",
            "NC",
            "OH",
            "OK",
            "OR",
            "PA",
            "RI",
            "SC",
            "SD",
            "TN",
            "TX",
            "UT",
            "VT",
            "VA",
            "WA",
            "WV",
            "WI",
            "WY"});
            this.cboState.Location = new System.Drawing.Point(151, 191);
            this.cboState.Name = "cboState";
            this.cboState.Size = new System.Drawing.Size(116, 21);
            this.cboState.TabIndex = 18;
            this.cboState.Validating += new System.ComponentModel.CancelEventHandler(this.cbState_Validating);
            this.cboState.Validated += new System.EventHandler(this.cbState_Validated);
            // 
            // txtZIP
            // 
            this.txtZIP.Location = new System.Drawing.Point(151, 231);
            this.txtZIP.Name = "txtZIP";
            this.txtZIP.Size = new System.Drawing.Size(100, 20);
            this.txtZIP.TabIndex = 19;
            this.txtZIP.Validating += new System.ComponentModel.CancelEventHandler(this.txtZIP_Validating);
            this.txtZIP.Validated += new System.EventHandler(this.txtZIP_Validated);
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(151, 152);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 20);
            this.txtCity.TabIndex = 17;
            this.txtCity.Validating += new System.ComponentModel.CancelEventHandler(this.txtCity_Validating);
            this.txtCity.Validated += new System.EventHandler(this.txtCity_Validated);
            // 
            // txtAddressLine2
            // 
            this.txtAddressLine2.Location = new System.Drawing.Point(151, 113);
            this.txtAddressLine2.Name = "txtAddressLine2";
            this.txtAddressLine2.Size = new System.Drawing.Size(100, 20);
            this.txtAddressLine2.TabIndex = 16;
            // 
            // txtAddressLine1
            // 
            this.txtAddressLine1.Location = new System.Drawing.Point(151, 74);
            this.txtAddressLine1.Name = "txtAddressLine1";
            this.txtAddressLine1.Size = new System.Drawing.Size(100, 20);
            this.txtAddressLine1.TabIndex = 15;
            this.txtAddressLine1.Validating += new System.ComponentModel.CancelEventHandler(this.txtAddressLine1_Validating);
            this.txtAddressLine1.Validated += new System.EventHandler(this.txtAddressLine1_Validated);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(151, 35);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 14;
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.txtName_Validating);
            this.txtName.Validated += new System.EventHandler(this.txtName_Validated);
            // 
            // errorProviderName
            // 
            this.errorProviderName.ContainerControl = this;
            // 
            // errorProviderAL1
            // 
            this.errorProviderAL1.ContainerControl = this;
            // 
            // errorProviderCity
            // 
            this.errorProviderCity.ContainerControl = this;
            // 
            // errorProviderState
            // 
            this.errorProviderState.ContainerControl = this;
            // 
            // errorProviderZip
            // 
            this.errorProviderZip.ContainerControl = this;
            // 
            // InsertAddress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 380);
            this.Controls.Add(this.btnAddInsert);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboState);
            this.Controls.Add(this.txtZIP);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtAddressLine2);
            this.Controls.Add(this.txtAddressLine1);
            this.Controls.Add(this.txtName);
            this.Name = "InsertAddress";
            this.Text = "InsertAddress";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAL1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderZip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddInsert;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboState;
        private System.Windows.Forms.TextBox txtZIP;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtAddressLine2;
        private System.Windows.Forms.TextBox txtAddressLine1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ErrorProvider errorProviderName;
        private System.Windows.Forms.ErrorProvider errorProviderAL1;
        private System.Windows.Forms.ErrorProvider errorProviderCity;
        private System.Windows.Forms.ErrorProvider errorProviderState;
        private System.Windows.Forms.ErrorProvider errorProviderZip;
    }
}