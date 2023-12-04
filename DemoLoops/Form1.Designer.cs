namespace DemoLoops
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserEntry = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboLoopType = new System.Windows.Forms.ComboBox();
            this.cboActions = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Number > 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Result";
            // 
            // txtUserEntry
            // 
            this.txtUserEntry.Location = new System.Drawing.Point(210, 12);
            this.txtUserEntry.Name = "txtUserEntry";
            this.txtUserEntry.Size = new System.Drawing.Size(100, 26);
            this.txtUserEntry.TabIndex = 2;
            // 
            // txtResult
            // 
            this.txtResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResult.Location = new System.Drawing.Point(141, 198);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(170, 40);
            this.txtResult.TabIndex = 3;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(432, 15);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(150, 41);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.Location = new System.Drawing.Point(149, 272);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(739, 37);
            this.lblErrorMessage.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Select Loop";
            // 
            // cboLoopType
            // 
            this.cboLoopType.FormattingEnabled = true;
            this.cboLoopType.Items.AddRange(new object[] {
            "",
            "For",
            "While",
            "Dowhile",
            "Foreach"});
            this.cboLoopType.Location = new System.Drawing.Point(189, 54);
            this.cboLoopType.Name = "cboLoopType";
            this.cboLoopType.Size = new System.Drawing.Size(121, 28);
            this.cboLoopType.TabIndex = 7;
            this.cboLoopType.SelectedIndexChanged += new System.EventHandler(this.cboLoopType_SelectedIndexChanged);
            // 
            // cboActions
            // 
            this.cboActions.FormattingEnabled = true;
            this.cboActions.Items.AddRange(new object[] {
            "",
            "Sum all numbers",
            "Sum even numbers",
            "Sum odd numbers"});
            this.cboActions.Location = new System.Drawing.Point(189, 103);
            this.cboActions.Name = "cboActions";
            this.cboActions.Size = new System.Drawing.Size(122, 28);
            this.cboActions.TabIndex = 8;
            this.cboActions.SelectedIndexChanged += new System.EventHandler(this.cboActions_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Select Action";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 407);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboActions);
            this.Controls.Add(this.cboLoopType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblErrorMessage);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtUserEntry);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserEntry;
        private System.Windows.Forms.Label txtResult;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblErrorMessage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboLoopType;
        private System.Windows.Forms.ComboBox cboActions;
        private System.Windows.Forms.Label label4;
    }
}

