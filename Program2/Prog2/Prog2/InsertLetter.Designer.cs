namespace Prog2
{
    partial class InsertLetter
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
            this.btnLetterInsert = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFixedCost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbDestinationAddress = new System.Windows.Forms.ComboBox();
            this.cbOriginAddress = new System.Windows.Forms.ComboBox();
            this.errorProviderOrigin = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDestination = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderCost = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderOrigin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDestination)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCost)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLetterInsert
            // 
            this.btnLetterInsert.Location = new System.Drawing.Point(327, 196);
            this.btnLetterInsert.Name = "btnLetterInsert";
            this.btnLetterInsert.Size = new System.Drawing.Size(101, 40);
            this.btnLetterInsert.TabIndex = 15;
            this.btnLetterInsert.Text = "Insert";
            this.btnLetterInsert.UseVisualStyleBackColor = true;
            this.btnLetterInsert.Click += new System.EventHandler(this.btnLetterInsert_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(123, 196);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(101, 40);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Fixed Cost ($):";
            // 
            // txtFixedCost
            // 
            this.txtFixedCost.Location = new System.Drawing.Point(271, 136);
            this.txtFixedCost.Name = "txtFixedCost";
            this.txtFixedCost.Size = new System.Drawing.Size(100, 20);
            this.txtFixedCost.TabIndex = 12;
            this.txtFixedCost.Validating += new System.ComponentModel.CancelEventHandler(this.txtFixedCost_Validating);
            this.txtFixedCost.Validated += new System.EventHandler(this.txtFixedCost_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Destination Address:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Origin Address:";
            // 
            // cbDestinationAddress
            // 
            this.cbDestinationAddress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDestinationAddress.FormattingEnabled = true;
            this.cbDestinationAddress.Location = new System.Drawing.Point(162, 82);
            this.cbDestinationAddress.Name = "cbDestinationAddress";
            this.cbDestinationAddress.Size = new System.Drawing.Size(344, 21);
            this.cbDestinationAddress.TabIndex = 9;
            this.cbDestinationAddress.Validating += new System.ComponentModel.CancelEventHandler(this.cbDestinationAddress_Validating);
            this.cbDestinationAddress.Validated += new System.EventHandler(this.cbDestinationAddress_Validated);
            // 
            // cbOriginAddress
            // 
            this.cbOriginAddress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOriginAddress.FormattingEnabled = true;
            this.cbOriginAddress.Location = new System.Drawing.Point(162, 37);
            this.cbOriginAddress.Name = "cbOriginAddress";
            this.cbOriginAddress.Size = new System.Drawing.Size(344, 21);
            this.cbOriginAddress.TabIndex = 8;
            this.cbOriginAddress.Validating += new System.ComponentModel.CancelEventHandler(this.cbOriginAddress_Validating);
            this.cbOriginAddress.Validated += new System.EventHandler(this.cbOriginAddress_Validated);
            // 
            // errorProviderOrigin
            // 
            this.errorProviderOrigin.ContainerControl = this;
            // 
            // errorProviderDestination
            // 
            this.errorProviderDestination.ContainerControl = this;
            // 
            // errorProviderCost
            // 
            this.errorProviderCost.ContainerControl = this;
            // 
            // InsertLetter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 273);
            this.Controls.Add(this.btnLetterInsert);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFixedCost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbDestinationAddress);
            this.Controls.Add(this.cbOriginAddress);
            this.Name = "InsertLetter";
            this.Text = "InsertLetter";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderOrigin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDestination)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLetterInsert;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFixedCost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbDestinationAddress;
        private System.Windows.Forms.ComboBox cbOriginAddress;
        private System.Windows.Forms.ErrorProvider errorProviderOrigin;
        private System.Windows.Forms.ErrorProvider errorProviderDestination;
        private System.Windows.Forms.ErrorProvider errorProviderCost;
    }
}