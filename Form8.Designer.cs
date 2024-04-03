
namespace Calculator_WinForms
{
    partial class Form8
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
            this.Samsung = new System.Windows.Forms.CheckBox();
            this.Shawami = new System.Windows.Forms.CheckBox();
            this.Oppo = new System.Windows.Forms.CheckBox();
            this.Redme = new System.Windows.Forms.CheckBox();
            this.Iphone = new System.Windows.Forms.CheckBox();
            this.Nokia = new System.Windows.Forms.CheckBox();
            this.MOBILEBtn = new System.Windows.Forms.Button();
            this.Enable = new System.Windows.Forms.CheckBox();
            this.MyBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(194, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(498, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "SELECT YOUR FAVORITE MOBILE COMPANIES";
            // 
            // Samsung
            // 
            this.Samsung.AutoSize = true;
            this.Samsung.Location = new System.Drawing.Point(194, 117);
            this.Samsung.Name = "Samsung";
            this.Samsung.Size = new System.Drawing.Size(117, 27);
            this.Samsung.TabIndex = 1;
            this.Samsung.Text = "SAMSUNG";
            this.Samsung.UseVisualStyleBackColor = true;
            this.Samsung.CheckedChanged += new System.EventHandler(this.Samsung_CheckedChanged);
            // 
            // Shawami
            // 
            this.Shawami.AutoSize = true;
            this.Shawami.Location = new System.Drawing.Point(194, 150);
            this.Shawami.Name = "Shawami";
            this.Shawami.Size = new System.Drawing.Size(104, 27);
            this.Shawami.TabIndex = 1;
            this.Shawami.Text = "SHAWMI";
            this.Shawami.UseVisualStyleBackColor = true;
            this.Shawami.CheckedChanged += new System.EventHandler(this.Shawami_CheckedChanged);
            // 
            // Oppo
            // 
            this.Oppo.AutoSize = true;
            this.Oppo.Location = new System.Drawing.Point(194, 183);
            this.Oppo.Name = "Oppo";
            this.Oppo.Size = new System.Drawing.Size(78, 27);
            this.Oppo.TabIndex = 1;
            this.Oppo.Text = "OPPO";
            this.Oppo.UseVisualStyleBackColor = true;
            this.Oppo.CheckedChanged += new System.EventHandler(this.Oppo_CheckedChanged);
            // 
            // Redme
            // 
            this.Redme.AutoSize = true;
            this.Redme.Location = new System.Drawing.Point(194, 216);
            this.Redme.Name = "Redme";
            this.Redme.Size = new System.Drawing.Size(90, 27);
            this.Redme.TabIndex = 1;
            this.Redme.Text = "REDME";
            this.Redme.UseVisualStyleBackColor = true;
            this.Redme.CheckedChanged += new System.EventHandler(this.Redme_CheckedChanged);
            // 
            // Iphone
            // 
            this.Iphone.AutoSize = true;
            this.Iphone.Location = new System.Drawing.Point(194, 249);
            this.Iphone.Name = "Iphone";
            this.Iphone.Size = new System.Drawing.Size(95, 27);
            this.Iphone.TabIndex = 1;
            this.Iphone.Text = "IPHONE";
            this.Iphone.UseVisualStyleBackColor = true;
            this.Iphone.CheckedChanged += new System.EventHandler(this.Iphone_CheckedChanged);
            // 
            // Nokia
            // 
            this.Nokia.AutoSize = true;
            this.Nokia.Location = new System.Drawing.Point(194, 282);
            this.Nokia.Name = "Nokia";
            this.Nokia.Size = new System.Drawing.Size(86, 27);
            this.Nokia.TabIndex = 1;
            this.Nokia.Text = "NOKIA";
            this.Nokia.UseVisualStyleBackColor = true;
            this.Nokia.CheckedChanged += new System.EventHandler(this.Nokia_CheckedChanged);
            // 
            // MOBILEBtn
            // 
            this.MOBILEBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.MOBILEBtn.Location = new System.Drawing.Point(194, 329);
            this.MOBILEBtn.Name = "MOBILEBtn";
            this.MOBILEBtn.Size = new System.Drawing.Size(104, 41);
            this.MOBILEBtn.TabIndex = 2;
            this.MOBILEBtn.Text = "SUBMIT";
            this.MOBILEBtn.UseVisualStyleBackColor = false;
            this.MOBILEBtn.Click += new System.EventHandler(this.MOBILEBtn_Click);
            // 
            // Enable
            // 
            this.Enable.AutoSize = true;
            this.Enable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Enable.Location = new System.Drawing.Point(194, 424);
            this.Enable.Name = "Enable";
            this.Enable.Size = new System.Drawing.Size(97, 32);
            this.Enable.TabIndex = 3;
            this.Enable.Text = "Enable";
            this.Enable.UseVisualStyleBackColor = true;
            this.Enable.CheckedChanged += new System.EventHandler(this.Enable_CheckedChanged);
            // 
            // MyBtn
            // 
            this.MyBtn.BackColor = System.Drawing.Color.Transparent;
            this.MyBtn.Enabled = false;
            this.MyBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MyBtn.ForeColor = System.Drawing.Color.Red;
            this.MyBtn.Location = new System.Drawing.Point(348, 424);
            this.MyBtn.Name = "MyBtn";
            this.MyBtn.Size = new System.Drawing.Size(127, 41);
            this.MyBtn.TabIndex = 4;
            this.MyBtn.Text = "MyButton";
            this.MyBtn.UseVisualStyleBackColor = false;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1043, 518);
            this.Controls.Add(this.MyBtn);
            this.Controls.Add(this.Enable);
            this.Controls.Add(this.MOBILEBtn);
            this.Controls.Add(this.Nokia);
            this.Controls.Add(this.Iphone);
            this.Controls.Add(this.Redme);
            this.Controls.Add(this.Oppo);
            this.Controls.Add(this.Shawami);
            this.Controls.Add(this.Samsung);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form8";
            this.Text = "CheckBox Control Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox Samsung;
        private System.Windows.Forms.CheckBox Shawami;
        private System.Windows.Forms.CheckBox Oppo;
        private System.Windows.Forms.CheckBox Redme;
        private System.Windows.Forms.CheckBox Iphone;
        private System.Windows.Forms.CheckBox Nokia;
        private System.Windows.Forms.Button MOBILEBtn;
        private System.Windows.Forms.CheckBox Enable;
        private System.Windows.Forms.Button MyBtn;
    }
}