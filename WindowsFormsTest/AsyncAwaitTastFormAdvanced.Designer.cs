namespace WindowsFormsTest
{
    partial class AsyncAwaitTastFormAdvanced
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
            this.cancelAsyncBtn = new System.Windows.Forms.Button();
            this.parallelAsyncExecuteBtn = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.parallelSyncExecute = new System.Windows.Forms.Button();
            this.parallelAsyncExecute2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // syncExecuteBtn
            // 
            this.syncExecuteBtn.Location = new System.Drawing.Point(12, 38);
            this.syncExecuteBtn.Name = "syncExecuteBtn";
            this.syncExecuteBtn.Size = new System.Drawing.Size(190, 30);
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
            this.resultTBox.Location = new System.Drawing.Point(12, 205);
            this.resultTBox.Multiline = true;
            this.resultTBox.Name = "resultTBox";
            this.resultTBox.Size = new System.Drawing.Size(639, 225);
            this.resultTBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Advanced Async Demo App";
            // 
            // cancelAsyncBtn
            // 
            this.cancelAsyncBtn.Location = new System.Drawing.Point(12, 142);
            this.cancelAsyncBtn.Name = "cancelAsyncBtn";
            this.cancelAsyncBtn.Size = new System.Drawing.Size(639, 28);
            this.cancelAsyncBtn.TabIndex = 4;
            this.cancelAsyncBtn.Text = "Cancel Async Operation";
            this.cancelAsyncBtn.UseVisualStyleBackColor = true;
            this.cancelAsyncBtn.Click += new System.EventHandler(this.cancelAsyncBtn_Click);
            // 
            // parallelAsyncExecuteBtn
            // 
            this.parallelAsyncExecuteBtn.Location = new System.Drawing.Point(12, 108);
            this.parallelAsyncExecuteBtn.Name = "parallelAsyncExecuteBtn";
            this.parallelAsyncExecuteBtn.Size = new System.Drawing.Size(639, 28);
            this.parallelAsyncExecuteBtn.TabIndex = 5;
            this.parallelAsyncExecuteBtn.Text = "Parallel Async Execute";
            this.parallelAsyncExecuteBtn.UseVisualStyleBackColor = true;
            this.parallelAsyncExecuteBtn.Click += new System.EventHandler(this.parallelAsyncExecuteBtn_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 176);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(639, 23);
            this.progressBar1.TabIndex = 6;
            // 
            // parallelSyncExecute
            // 
            this.parallelSyncExecute.Location = new System.Drawing.Point(208, 38);
            this.parallelSyncExecute.Name = "parallelSyncExecute";
            this.parallelSyncExecute.Size = new System.Drawing.Size(202, 30);
            this.parallelSyncExecute.TabIndex = 7;
            this.parallelSyncExecute.Text = "Parallel Sync Execute";
            this.parallelSyncExecute.UseVisualStyleBackColor = true;
            this.parallelSyncExecute.Click += new System.EventHandler(this.parallelSyncExecute_Click);
            // 
            // parallelAsyncExecute2
            // 
            this.parallelAsyncExecute2.Location = new System.Drawing.Point(416, 38);
            this.parallelAsyncExecute2.Name = "parallelAsyncExecute2";
            this.parallelAsyncExecute2.Size = new System.Drawing.Size(235, 30);
            this.parallelAsyncExecute2.TabIndex = 8;
            this.parallelAsyncExecute2.Text = "Parallel Async Execute";
            this.parallelAsyncExecute2.UseVisualStyleBackColor = true;
            this.parallelAsyncExecute2.Click += new System.EventHandler(this.parallelAsyncExecute2_Click);
            // 
            // AsyncAwaitTastFormAdvanced
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 442);
            this.Controls.Add(this.parallelAsyncExecute2);
            this.Controls.Add(this.parallelSyncExecute);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.parallelAsyncExecuteBtn);
            this.Controls.Add(this.cancelAsyncBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultTBox);
            this.Controls.Add(this.asyncExecuteBtn);
            this.Controls.Add(this.syncExecuteBtn);
            this.Name = "AsyncAwaitTastFormAdvanced";
            this.Text = "AsyncAwaitTastFormAdvanced";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button syncExecuteBtn;
        private System.Windows.Forms.Button asyncExecuteBtn;
        private System.Windows.Forms.TextBox resultTBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelAsyncBtn;
        private System.Windows.Forms.Button parallelAsyncExecuteBtn;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button parallelSyncExecute;
        private System.Windows.Forms.Button parallelAsyncExecute2;
    }
}