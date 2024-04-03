
namespace Calculator_WinForms
{
    partial class ComboBox
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
            this.HobbiesComboBox = new System.Windows.Forms.ComboBox();
            this.hobbylbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabelbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HobbiesComboBox
            // 
            this.HobbiesComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.HobbiesComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.HobbiesComboBox.BackColor = System.Drawing.Color.LightGray;
            this.HobbiesComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HobbiesComboBox.ForeColor = System.Drawing.Color.Black;
            this.HobbiesComboBox.FormattingEnabled = true;
            this.HobbiesComboBox.Items.AddRange(new object[] {
            "WRITING",
            "READING ",
            "RECIETING",
            "SWIMING",
            "EATING",
            "GOSSOPING",
            "LISTENING",
            "CRICKET",
            "FOOTBAL",
            "WALKING",
            "RUNNING",
            "RIDING"});
            this.HobbiesComboBox.Location = new System.Drawing.Point(270, 96);
            this.HobbiesComboBox.Name = "HobbiesComboBox";
            this.HobbiesComboBox.Size = new System.Drawing.Size(502, 36);
            this.HobbiesComboBox.TabIndex = 0;
            this.HobbiesComboBox.SelectedIndexChanged += new System.EventHandler(this.HobbiesComboBox_SelectedIndexChanged);
            // 
            // hobbylbl
            // 
            this.hobbylbl.AutoSize = true;
            this.hobbylbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.hobbylbl.Location = new System.Drawing.Point(136, 99);
            this.hobbylbl.Name = "hobbylbl";
            this.hobbylbl.Size = new System.Drawing.Size(96, 28);
            this.hobbylbl.TabIndex = 1;
            this.hobbylbl.Text = "HOBBIES";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(136, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add Items ";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(270, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(350, 34);
            this.textBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(626, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 36);
            this.button1.TabIndex = 4;
            this.button1.Tag = "";
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(136, 138);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(636, 38);
            this.button2.TabIndex = 5;
            this.button2.Text = "Count Items";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(136, 192);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(636, 38);
            this.button3.TabIndex = 6;
            this.button3.Text = "Remove Specific  Item";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(136, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // linkLabelbutton
            // 
            this.linkLabelbutton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.linkLabelbutton.Location = new System.Drawing.Point(459, 329);
            this.linkLabelbutton.Name = "linkLabelbutton";
            this.linkLabelbutton.Size = new System.Drawing.Size(313, 42);
            this.linkLabelbutton.TabIndex = 8;
            this.linkLabelbutton.Text = "Go To Link Label Page";
            this.linkLabelbutton.UseVisualStyleBackColor = true;
            this.linkLabelbutton.Click += new System.EventHandler(this.linkLabelbutton_Click);
            // 
            // ComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabelbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hobbylbl);
            this.Controls.Add(this.HobbiesComboBox);
            this.MaximizeBox = false;
            this.Name = "ComboBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ComboBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox HobbiesComboBox;
        private System.Windows.Forms.Label hobbylbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button linkLabelbutton;
    }
}