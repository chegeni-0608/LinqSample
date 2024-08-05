namespace LinqSample
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
            this.btnLinqSample01 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSample02 = new System.Windows.Forms.Button();
            this.btnLinqSample3 = new System.Windows.Forms.Button();
            this.LinqSample04 = new System.Windows.Forms.Button();
            this.btnLinqSample4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLinqSample01
            // 
            this.btnLinqSample01.Location = new System.Drawing.Point(47, 32);
            this.btnLinqSample01.Name = "btnLinqSample01";
            this.btnLinqSample01.Size = new System.Drawing.Size(158, 42);
            this.btnLinqSample01.TabIndex = 0;
            this.btnLinqSample01.Text = "LinqSample01";
            this.btnLinqSample01.UseVisualStyleBackColor = true;
            this.btnLinqSample01.Click += new System.EventHandler(this.btnLinqSample01_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(595, 52);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(193, 384);
            this.listBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(591, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Result :";
            // 
            // btnSample02
            // 
            this.btnSample02.Location = new System.Drawing.Point(47, 97);
            this.btnSample02.Name = "btnSample02";
            this.btnSample02.Size = new System.Drawing.Size(158, 42);
            this.btnSample02.TabIndex = 3;
            this.btnSample02.Text = "LinqSample02";
            this.btnSample02.UseVisualStyleBackColor = true;
            this.btnSample02.Click += new System.EventHandler(this.btnSample02_Click);
            // 
            // btnLinqSample3
            // 
            this.btnLinqSample3.Location = new System.Drawing.Point(47, 162);
            this.btnLinqSample3.Name = "btnLinqSample3";
            this.btnLinqSample3.Size = new System.Drawing.Size(158, 42);
            this.btnLinqSample3.TabIndex = 4;
            this.btnLinqSample3.Text = "LinqSample03";
            this.btnLinqSample3.UseVisualStyleBackColor = true;
            this.btnLinqSample3.Click += new System.EventHandler(this.btnLinqSample3_Click);
            // 
            // LinqSample04
            // 
            this.LinqSample04.Location = new System.Drawing.Point(47, 228);
            this.LinqSample04.Name = "LinqSample04";
            this.LinqSample04.Size = new System.Drawing.Size(158, 42);
            this.LinqSample04.TabIndex = 5;
            this.LinqSample04.Text = "LinqSample03+3";
            this.LinqSample04.UseVisualStyleBackColor = true;
            this.LinqSample04.Click += new System.EventHandler(this.LinqSample04_Click);
            // 
            // btnLinqSample4
            // 
            this.btnLinqSample4.Location = new System.Drawing.Point(47, 290);
            this.btnLinqSample4.Name = "btnLinqSample4";
            this.btnLinqSample4.Size = new System.Drawing.Size(158, 42);
            this.btnLinqSample4.TabIndex = 6;
            this.btnLinqSample4.Text = "LinqSample04";
            this.btnLinqSample4.UseVisualStyleBackColor = true;
            this.btnLinqSample4.Click += new System.EventHandler(this.btnLinqSample4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLinqSample4);
            this.Controls.Add(this.LinqSample04);
            this.Controls.Add(this.btnLinqSample3);
            this.Controls.Add(this.btnSample02);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnLinqSample01);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLinqSample01;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSample02;
        private System.Windows.Forms.Button btnLinqSample3;
        private System.Windows.Forms.Button LinqSample04;
        private System.Windows.Forms.Button btnLinqSample4;
    }
}

