namespace WordCounting
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
            this.tBox_TextToCount = new System.Windows.Forms.TextBox();
            this.dataGridView_SortCount = new System.Windows.Forms.DataGridView();
            this.btn_CountWords = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.Column_Word = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SortCount)).BeginInit();
            this.SuspendLayout();
            // 
            // tBox_TextToCount
            // 
            this.tBox_TextToCount.Location = new System.Drawing.Point(12, 12);
            this.tBox_TextToCount.Multiline = true;
            this.tBox_TextToCount.Name = "tBox_TextToCount";
            this.tBox_TextToCount.Size = new System.Drawing.Size(314, 426);
            this.tBox_TextToCount.TabIndex = 0;
            // 
            // dataGridView_SortCount
            // 
            this.dataGridView_SortCount.AllowUserToAddRows = false;
            this.dataGridView_SortCount.AllowUserToDeleteRows = false;
            this.dataGridView_SortCount.AllowUserToResizeColumns = false;
            this.dataGridView_SortCount.AllowUserToResizeRows = false;
            this.dataGridView_SortCount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_SortCount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_SortCount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Word,
            this.Column_Count});
            this.dataGridView_SortCount.Location = new System.Drawing.Point(430, 12);
            this.dataGridView_SortCount.Name = "dataGridView_SortCount";
            this.dataGridView_SortCount.RowHeadersVisible = false;
            this.dataGridView_SortCount.Size = new System.Drawing.Size(358, 426);
            this.dataGridView_SortCount.TabIndex = 1;
            // 
            // btn_CountWords
            // 
            this.btn_CountWords.Location = new System.Drawing.Point(332, 12);
            this.btn_CountWords.Name = "btn_CountWords";
            this.btn_CountWords.Size = new System.Drawing.Size(92, 27);
            this.btn_CountWords.TabIndex = 2;
            this.btn_CountWords.Text = "Count Words";
            this.btn_CountWords.UseVisualStyleBackColor = true;
            this.btn_CountWords.Click += new System.EventHandler(this.btn_CountWords_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(332, 415);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(92, 23);
            this.btn_Reset.TabIndex = 3;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // Column_Word
            // 
            this.Column_Word.HeaderText = "Word";
            this.Column_Word.Name = "Column_Word";
            this.Column_Word.ReadOnly = true;
            // 
            // Column_Count
            // 
            this.Column_Count.FillWeight = 35F;
            this.Column_Count.HeaderText = "Count";
            this.Column_Count.Name = "Column_Count";
            this.Column_Count.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_CountWords);
            this.Controls.Add(this.dataGridView_SortCount);
            this.Controls.Add(this.tBox_TextToCount);
            this.Name = "Form1";
            this.Text = "Main Window";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SortCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBox_TextToCount;
        private System.Windows.Forms.DataGridView dataGridView_SortCount;
        private System.Windows.Forms.Button btn_CountWords;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Word;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Count;
    }
}

