namespace WindowsFormsTest
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
            this.DoTimeConsumingWorkBtn = new System.Windows.Forms.Button();
            this.showBtn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.timeLbl = new System.Windows.Forms.Label();
            this.asyncBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DoTimeConsumingWorkBtn
            // 
            this.DoTimeConsumingWorkBtn.Location = new System.Drawing.Point(12, 12);
            this.DoTimeConsumingWorkBtn.Name = "DoTimeConsumingWorkBtn";
            this.DoTimeConsumingWorkBtn.Size = new System.Drawing.Size(151, 23);
            this.DoTimeConsumingWorkBtn.TabIndex = 0;
            this.DoTimeConsumingWorkBtn.Text = "Do time consuming work";
            this.DoTimeConsumingWorkBtn.UseVisualStyleBackColor = true;
            this.DoTimeConsumingWorkBtn.Click += new System.EventHandler(this.DoTimeConsumingWorkBtn_Click);
            // 
            // showBtn
            // 
            this.showBtn.Location = new System.Drawing.Point(12, 41);
            this.showBtn.Name = "showBtn";
            this.showBtn.Size = new System.Drawing.Size(151, 23);
            this.showBtn.TabIndex = 1;
            this.showBtn.Text = "Show Time";
            this.showBtn.UseVisualStyleBackColor = true;
            this.showBtn.Click += new System.EventHandler(this.showBtn_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 96);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(485, 292);
            this.listBox1.TabIndex = 2;
            // 
            // timeLbl
            // 
            this.timeLbl.AutoSize = true;
            this.timeLbl.Location = new System.Drawing.Point(12, 67);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(46, 17);
            this.timeLbl.TabIndex = 3;
            this.timeLbl.Text = "label1";
            // 
            // asyncBtn
            // 
            this.asyncBtn.Location = new System.Drawing.Point(12, 407);
            this.asyncBtn.Name = "asyncBtn";
            this.asyncBtn.Size = new System.Drawing.Size(151, 23);
            this.asyncBtn.TabIndex = 4;
            this.asyncBtn.Text = "Async call";
            this.asyncBtn.UseVisualStyleBackColor = true;
            this.asyncBtn.Click += new System.EventHandler(this.asyncBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 799);
            this.Controls.Add(this.asyncBtn);
            this.Controls.Add(this.timeLbl);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.showBtn);
            this.Controls.Add(this.DoTimeConsumingWorkBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DoTimeConsumingWorkBtn;
        private System.Windows.Forms.Button showBtn;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label timeLbl;
        private System.Windows.Forms.Button asyncBtn;
    }
}

