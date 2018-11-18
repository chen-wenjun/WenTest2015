namespace WindowsFormsTest
{
    partial class AsyncAwaitTastFormOptimized
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
            this.syncExecuteBtn = new System.Windows.Forms.Button();
            this.asyncExecuteBtn = new System.Windows.Forms.Button();
            this.resultTBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // syncExecuteBtn
            // 
            this.syncExecuteBtn.Location = new System.Drawing.Point(12, 38);
            this.syncExecuteBtn.Name = "syncExecuteBtn";
            this.syncExecuteBtn.Size = new System.Drawing.Size(639, 30);
            this.syncExecuteBtn.TabIndex = 0;
            this.syncExecuteBtn.Text = "Sync Execute";
            this.syncExecuteBtn.UseVisualStyleBackColor = true;
            this.syncExecuteBtn.Click += new System.EventHandler(this.syncExecuteBtn_Click);
            // 
            // asyncExecuteBtn
            // 
            this.asyncExecuteBtn.Location = new System.Drawing.Point(12, 74);
            this.asyncExecuteBtn.Name = "asyncExecuteBtn";
            this.asyncExecuteBtn.Size = new System.Drawing.Size(639, 28);
            this.asyncExecuteBtn.TabIndex = 1;
            this.asyncExecuteBtn.Text = "Async Execute";
            this.asyncExecuteBtn.UseVisualStyleBackColor = true;
            this.asyncExecuteBtn.Click += new System.EventHandler(this.asyncExecuteBtn_Click);
            // 
            // resultTBox
            // 
            this.resultTBox.Location = new System.Drawing.Point(12, 108);
            this.resultTBox.Multiline = true;
            this.resultTBox.Name = "resultTBox";
            this.resultTBox.Size = new System.Drawing.Size(639, 249);
            this.resultTBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Simple Async Demo App";
            // 
            // AsyncAwaitTastFormOptimized
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 374);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultTBox);
            this.Controls.Add(this.asyncExecuteBtn);
            this.Controls.Add(this.syncExecuteBtn);
            this.Name = "AsyncAwaitTastFormOptimized";
            this.Text = "AsyncAwaitTastFormOptimized";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button syncExecuteBtn;
        private System.Windows.Forms.Button asyncExecuteBtn;
        private System.Windows.Forms.TextBox resultTBox;
        private System.Windows.Forms.Label label1;
    }
}