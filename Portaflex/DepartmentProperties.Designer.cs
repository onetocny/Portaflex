﻿namespace Portaflex
{
    partial class DepartmentProperties
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.OKbutton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.procUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.pwdProtectLabel = new System.Windows.Forms.Label();
            this.pwdCheckBox = new System.Windows.Forms.CheckBox();
            this.pwdLabel = new System.Windows.Forms.Label();
            this.pwd2Label = new System.Windows.Forms.Label();
            this.pwdTextBox = new System.Windows.Forms.TextBox();
            this.pwd2TextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.procUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(283, 102);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // OKbutton
            // 
            this.OKbutton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKbutton.Location = new System.Drawing.Point(43, 171);
            this.OKbutton.Name = "OKbutton";
            this.OKbutton.Size = new System.Drawing.Size(75, 23);
            this.OKbutton.TabIndex = 4;
            this.OKbutton.Text = "OK";
            this.OKbutton.UseVisualStyleBackColor = true;
            this.OKbutton.Click += new System.EventHandler(this.OKbutton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(135, 171);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Zrušit";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // procUpDown
            // 
            this.procUpDown.DecimalPlaces = 2;
            this.procUpDown.Location = new System.Drawing.Point(120, 42);
            this.procUpDown.Name = "procUpDown";
            this.procUpDown.Size = new System.Drawing.Size(120, 20);
            this.procUpDown.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Jmémo střediska:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "% z firemní režie:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(120, 9);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(120, 20);
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameLabel_TextChanged);
            // 
            // pwdProtectLabel
            // 
            this.pwdProtectLabel.AutoSize = true;
            this.pwdProtectLabel.Location = new System.Drawing.Point(13, 80);
            this.pwdProtectLabel.Name = "pwdProtectLabel";
            this.pwdProtectLabel.Size = new System.Drawing.Size(92, 13);
            this.pwdProtectLabel.TabIndex = 7;
            this.pwdProtectLabel.Text = "Chráněno heslem:";
            // 
            // pwdCheckBox
            // 
            this.pwdCheckBox.AutoSize = true;
            this.pwdCheckBox.Location = new System.Drawing.Point(120, 80);
            this.pwdCheckBox.Name = "pwdCheckBox";
            this.pwdCheckBox.Size = new System.Drawing.Size(15, 14);
            this.pwdCheckBox.TabIndex = 3;
            this.pwdCheckBox.UseVisualStyleBackColor = true;
            this.pwdCheckBox.CheckedChanged += new System.EventHandler(this.pwdCheckBox_CheckedChanged);
            // 
            // pwdLabel
            // 
            this.pwdLabel.AutoSize = true;
            this.pwdLabel.Enabled = false;
            this.pwdLabel.Location = new System.Drawing.Point(13, 110);
            this.pwdLabel.Name = "pwdLabel";
            this.pwdLabel.Size = new System.Drawing.Size(37, 13);
            this.pwdLabel.TabIndex = 9;
            this.pwdLabel.Text = "Heslo:";
            // 
            // pwd2Label
            // 
            this.pwd2Label.AutoSize = true;
            this.pwd2Label.Enabled = false;
            this.pwd2Label.Location = new System.Drawing.Point(13, 140);
            this.pwd2Label.Name = "pwd2Label";
            this.pwd2Label.Size = new System.Drawing.Size(79, 13);
            this.pwd2Label.TabIndex = 10;
            this.pwd2Label.Text = "Heslo podruhé:";
            // 
            // pwdTextBox
            // 
            this.pwdTextBox.Enabled = false;
            this.pwdTextBox.Location = new System.Drawing.Point(120, 107);
            this.pwdTextBox.Name = "pwdTextBox";
            this.pwdTextBox.PasswordChar = '*';
            this.pwdTextBox.Size = new System.Drawing.Size(120, 20);
            this.pwdTextBox.TabIndex = 6;
            this.pwdTextBox.EnabledChanged += new System.EventHandler(this.pwdTextBox_EnabledChanged);
            this.pwdTextBox.TextChanged += new System.EventHandler(this.pwdTextBox_TextChanged);
            // 
            // pwd2TextBox
            // 
            this.pwd2TextBox.Enabled = false;
            this.pwd2TextBox.Location = new System.Drawing.Point(120, 137);
            this.pwd2TextBox.Name = "pwd2TextBox";
            this.pwd2TextBox.PasswordChar = '*';
            this.pwd2TextBox.Size = new System.Drawing.Size(120, 20);
            this.pwd2TextBox.TabIndex = 7;
            this.pwd2TextBox.EnabledChanged += new System.EventHandler(this.pwd2TextBox_EnabledChanged);
            this.pwd2TextBox.TextChanged += new System.EventHandler(this.pwd2TextBox_TextChanged);
            // 
            // DepartmentProperties
            // 
            this.AcceptButton = this.OKbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(252, 212);
            this.ControlBox = false;
            this.Controls.Add(this.pwd2TextBox);
            this.Controls.Add(this.pwdTextBox);
            this.Controls.Add(this.pwd2Label);
            this.Controls.Add(this.pwdLabel);
            this.Controls.Add(this.pwdCheckBox);
            this.Controls.Add(this.pwdProtectLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.procUpDown);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.OKbutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DepartmentProperties";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Vlastnosti";
            this.Shown += new System.EventHandler(this.DepartmentProperties_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.procUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button OKbutton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.NumericUpDown procUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label pwdProtectLabel;
        private System.Windows.Forms.CheckBox pwdCheckBox;
        private System.Windows.Forms.Label pwdLabel;
        private System.Windows.Forms.Label pwd2Label;
        private System.Windows.Forms.TextBox pwdTextBox;
        private System.Windows.Forms.TextBox pwd2TextBox;
    }
}