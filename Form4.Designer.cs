
namespace Calculator_WinForms
{
    partial class Form4
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
            this.GooglelinkLabel = new System.Windows.Forms.LinkLabel();
            this.PassingData = new System.Windows.Forms.LinkLabel();
            this.Radio_Button_Control = new System.Windows.Forms.LinkLabel();
            this.CheckBox = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // GooglelinkLabel
            // 
            this.GooglelinkLabel.AutoSize = true;
            this.GooglelinkLabel.BackColor = System.Drawing.Color.Transparent;
            this.GooglelinkLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GooglelinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.GooglelinkLabel.LinkColor = System.Drawing.Color.Blue;
            this.GooglelinkLabel.Location = new System.Drawing.Point(26, 54);
            this.GooglelinkLabel.Name = "GooglelinkLabel";
            this.GooglelinkLabel.Size = new System.Drawing.Size(310, 28);
            this.GooglelinkLabel.TabIndex = 0;
            this.GooglelinkLabel.TabStop = true;
            this.GooglelinkLabel.Text = "Click This Link To Open Google ";
            this.GooglelinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GooglelinkLabel.VisitedLinkColor = System.Drawing.Color.ForestGreen;
            this.GooglelinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GooglelinkLabel_LinkClicked);
            // 
            // PassingData
            // 
            this.PassingData.AutoSize = true;
            this.PassingData.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PassingData.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.PassingData.Location = new System.Drawing.Point(26, 103);
            this.PassingData.Name = "PassingData";
            this.PassingData.Size = new System.Drawing.Size(359, 28);
            this.PassingData.TabIndex = 1;
            this.PassingData.TabStop = true;
            this.PassingData.Text = "Go To Another Form To Passing Data";
            this.PassingData.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.PassingData_LinkClicked);
            // 
            // Radio_Button_Control
            // 
            this.Radio_Button_Control.AutoSize = true;
            this.Radio_Button_Control.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Radio_Button_Control.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.Radio_Button_Control.Location = new System.Drawing.Point(26, 153);
            this.Radio_Button_Control.Name = "Radio_Button_Control";
            this.Radio_Button_Control.Size = new System.Drawing.Size(273, 28);
            this.Radio_Button_Control.TabIndex = 2;
            this.Radio_Button_Control.TabStop = true;
            this.Radio_Button_Control.Text = "Go To Radio Button Control";
            this.Radio_Button_Control.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Radio_Button_Control_LinkClicked);
            // 
            // CheckBox
            // 
            this.CheckBox.AutoSize = true;
            this.CheckBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CheckBox.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.CheckBox.Location = new System.Drawing.Point(26, 207);
            this.CheckBox.Name = "CheckBox";
            this.CheckBox.Size = new System.Drawing.Size(246, 28);
            this.CheckBox.TabIndex = 3;
            this.CheckBox.TabStop = true;
            this.CheckBox.Text = "Go To CheckBox Control ";
            this.CheckBox.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CheckBox_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.Location = new System.Drawing.Point(26, 264);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.linkLabel1.Size = new System.Drawing.Size(267, 28);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Error Provider ControlPage";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.CheckBox);
            this.Controls.Add(this.Radio_Button_Control);
            this.Controls.Add(this.PassingData);
            this.Controls.Add(this.GooglelinkLabel);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Link Label Control Page";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel GooglelinkLabel;
        private System.Windows.Forms.LinkLabel PassingData;
        private System.Windows.Forms.LinkLabel Radio_Button_Control;
        private System.Windows.Forms.LinkLabel CheckBox;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}