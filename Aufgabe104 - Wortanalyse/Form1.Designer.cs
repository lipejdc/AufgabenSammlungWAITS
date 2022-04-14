namespace Aufgabe104___Wortanalyse
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
            this.components = new System.ComponentModel.Container();
            this.Words = new System.Windows.Forms.ListBox();
            this.txtAdd = new System.Windows.Forms.Button();
            this.Results = new System.Windows.Forms.ListBox();
            this.wortAnalyse = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.txtClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Words
            // 
            this.Words.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Words.FormattingEnabled = true;
            this.Words.ItemHeight = 24;
            this.Words.Location = new System.Drawing.Point(12, 12);
            this.Words.Name = "Words";
            this.Words.Size = new System.Drawing.Size(286, 268);
            this.Words.TabIndex = 0;
            this.Words.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // txtAdd
            // 
            this.txtAdd.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdd.Location = new System.Drawing.Point(12, 357);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(90, 37);
            this.txtAdd.TabIndex = 1;
            this.txtAdd.Text = "Add";
            this.txtAdd.UseVisualStyleBackColor = true;
            this.txtAdd.Click += new System.EventHandler(this.txtAdd_Click);
            // 
            // Results
            // 
            this.Results.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Results.FormattingEnabled = true;
            this.Results.ItemHeight = 24;
            this.Results.Location = new System.Drawing.Point(304, 12);
            this.Results.Name = "Results";
            this.Results.Size = new System.Drawing.Size(467, 268);
            this.Results.TabIndex = 2;
            // 
            // wortAnalyse
            // 
            this.wortAnalyse.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wortAnalyse.Location = new System.Drawing.Point(318, 357);
            this.wortAnalyse.Name = "wortAnalyse";
            this.wortAnalyse.Size = new System.Drawing.Size(138, 37);
            this.wortAnalyse.TabIndex = 3;
            this.wortAnalyse.Text = "Wortanalyse";
            this.wortAnalyse.UseVisualStyleBackColor = true;
            this.wortAnalyse.Click += new System.EventHandler(this.wortAnalyse_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 300);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(286, 22);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // timer
            // 
            this.timer.Interval = 5000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // txtClear
            // 
            this.txtClear.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClear.Location = new System.Drawing.Point(135, 357);
            this.txtClear.Name = "txtClear";
            this.txtClear.Size = new System.Drawing.Size(102, 37);
            this.txtClear.TabIndex = 5;
            this.txtClear.Text = "Clear";
            this.txtClear.UseVisualStyleBackColor = true;
            this.txtClear.Click += new System.EventHandler(this.txtClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtClear);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.wortAnalyse);
            this.Controls.Add(this.Results);
            this.Controls.Add(this.txtAdd);
            this.Controls.Add(this.Words);
            this.Name = "Form1";
            this.Text = "Wortanalyse";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Words;
        private System.Windows.Forms.Button txtAdd;
        private System.Windows.Forms.ListBox Results;
        private System.Windows.Forms.Button wortAnalyse;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button txtClear;
    }
}

