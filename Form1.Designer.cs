
namespace Calculator_WinForms
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.SubtractButton = new System.Windows.Forms.Button();
            this.MultiplicationButton = new System.Windows.Forms.Button();
            this.DivisoonButton = new System.Windows.Forms.Button();
            this.Resultlbl = new System.Windows.Forms.Label();
            this.AnotherPageBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(990, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(222, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "My Calculator App";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(55, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter First Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(55, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Enter Second Number";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(330, 159);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(386, 27);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(330, 216);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(386, 27);
            this.textBox2.TabIndex = 5;
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddButton.Location = new System.Drawing.Point(55, 290);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 43);
            this.AddButton.TabIndex = 6;
            this.AddButton.Text = "ADD";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SubtractButton
            // 
            this.SubtractButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SubtractButton.Location = new System.Drawing.Point(164, 290);
            this.SubtractButton.Name = "SubtractButton";
            this.SubtractButton.Size = new System.Drawing.Size(139, 43);
            this.SubtractButton.TabIndex = 7;
            this.SubtractButton.Text = "SUBTRACT";
            this.SubtractButton.UseVisualStyleBackColor = true;
            this.SubtractButton.Click += new System.EventHandler(this.SubtractButton_Click);
            // 
            // MultiplicationButton
            // 
            this.MultiplicationButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MultiplicationButton.Location = new System.Drawing.Point(331, 290);
            this.MultiplicationButton.Name = "MultiplicationButton";
            this.MultiplicationButton.Size = new System.Drawing.Size(208, 43);
            this.MultiplicationButton.TabIndex = 8;
            this.MultiplicationButton.Text = "MULTIPLICATION";
            this.MultiplicationButton.UseVisualStyleBackColor = true;
            this.MultiplicationButton.Click += new System.EventHandler(this.MultiplicationButton_Click);
            // 
            // DivisoonButton
            // 
            this.DivisoonButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DivisoonButton.Location = new System.Drawing.Point(563, 290);
            this.DivisoonButton.Name = "DivisoonButton";
            this.DivisoonButton.Size = new System.Drawing.Size(153, 43);
            this.DivisoonButton.TabIndex = 9;
            this.DivisoonButton.Text = "DIVISION";
            this.DivisoonButton.UseVisualStyleBackColor = true;
            this.DivisoonButton.Click += new System.EventHandler(this.DivisoonButton_Click);
            // 
            // Resultlbl
            // 
            this.Resultlbl.AutoSize = true;
            this.Resultlbl.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Resultlbl.Location = new System.Drawing.Point(282, 402);
            this.Resultlbl.Name = "Resultlbl";
            this.Resultlbl.Size = new System.Drawing.Size(116, 45);
            this.Resultlbl.TabIndex = 10;
            this.Resultlbl.Text = "Result";
            this.Resultlbl.Visible = false;
            // 
            // AnotherPageBtn
            // 
            this.AnotherPageBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AnotherPageBtn.Location = new System.Drawing.Point(604, 457);
            this.AnotherPageBtn.Name = "AnotherPageBtn";
            this.AnotherPageBtn.Size = new System.Drawing.Size(272, 43);
            this.AnotherPageBtn.TabIndex = 11;
            this.AnotherPageBtn.Text = "Go To  ListBox Page ";
            this.AnotherPageBtn.UseVisualStyleBackColor = true;
            this.AnotherPageBtn.Click += new System.EventHandler(this.AnotherPageBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 512);
            this.Controls.Add(this.AnotherPageBtn);
            this.Controls.Add(this.Resultlbl);
            this.Controls.Add(this.DivisoonButton);
            this.Controls.Add(this.MultiplicationButton);
            this.Controls.Add(this.SubtractButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button SubtractButton;
        private System.Windows.Forms.Button MultiplicationButton;
        private System.Windows.Forms.Button DivisoonButton;
        private System.Windows.Forms.Label Resultlbl;
        private System.Windows.Forms.Button AnotherPageBtn;
    }
}

