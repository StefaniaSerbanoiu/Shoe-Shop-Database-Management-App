
namespace ShoeShopApp
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
            this.managerButton1 = new System.Windows.Forms.Button();
            this.deleteWorkerTextBox = new System.Windows.Forms.TextBox();
            this.managerLabel1 = new System.Windows.Forms.Label();
            this.managerDataGridView = new System.Windows.Forms.DataGridView();
            this.workerDataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.deleteManagerTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.managerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // managerButton1
            // 
            this.managerButton1.Location = new System.Drawing.Point(215, 31);
            this.managerButton1.Name = "managerButton1";
            this.managerButton1.Size = new System.Drawing.Size(75, 23);
            this.managerButton1.TabIndex = 0;
            this.managerButton1.Text = "Save";
            this.managerButton1.UseVisualStyleBackColor = true;
            this.managerButton1.Click += new System.EventHandler(this.managerButton1_Click);
            // 
            // deleteWorkerTextBox
            // 
            this.deleteWorkerTextBox.Location = new System.Drawing.Point(513, 60);
            this.deleteWorkerTextBox.Name = "deleteWorkerTextBox";
            this.deleteWorkerTextBox.Size = new System.Drawing.Size(100, 22);
            this.deleteWorkerTextBox.TabIndex = 1;
            // 
            // managerLabel1
            // 
            this.managerLabel1.AutoSize = true;
            this.managerLabel1.Location = new System.Drawing.Point(13, 31);
            this.managerLabel1.Name = "managerLabel1";
            this.managerLabel1.Size = new System.Drawing.Size(46, 17);
            this.managerLabel1.TabIndex = 2;
            this.managerLabel1.Text = "label1";
            // 
            // managerDataGridView
            // 
            this.managerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.managerDataGridView.Location = new System.Drawing.Point(32, 113);
            this.managerDataGridView.Name = "managerDataGridView";
            this.managerDataGridView.RowHeadersWidth = 51;
            this.managerDataGridView.RowTemplate.Height = 24;
            this.managerDataGridView.Size = new System.Drawing.Size(513, 590);
            this.managerDataGridView.TabIndex = 3;
            this.managerDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.managerDataGridView_CellContentClick);
            // 
            // workerDataGridView
            // 
            this.workerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.workerDataGridView.Location = new System.Drawing.Point(581, 113);
            this.workerDataGridView.Name = "workerDataGridView";
            this.workerDataGridView.RowHeadersWidth = 51;
            this.workerDataGridView.RowTemplate.Height = 24;
            this.workerDataGridView.Size = new System.Drawing.Size(697, 590);
            this.workerDataGridView.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(312, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Delete Manager";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(492, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Delete Worker";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // deleteManagerTextBox
            // 
            this.deleteManagerTextBox.Location = new System.Drawing.Point(331, 60);
            this.deleteManagerTextBox.Name = "deleteManagerTextBox";
            this.deleteManagerTextBox.Size = new System.Drawing.Size(100, 22);
            this.deleteManagerTextBox.TabIndex = 7;
            this.deleteManagerTextBox.Visible = false;
            this.deleteManagerTextBox.TextChanged += new System.EventHandler(this.deleteManagerTextBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 740);
            this.Controls.Add(this.deleteManagerTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.workerDataGridView);
            this.Controls.Add(this.managerDataGridView);
            this.Controls.Add(this.managerLabel1);
            this.Controls.Add(this.deleteWorkerTextBox);
            this.Controls.Add(this.managerButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.managerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button managerButton1;
        private System.Windows.Forms.TextBox deleteWorkerTextBox;
        private System.Windows.Forms.Label managerLabel1;
        private System.Windows.Forms.DataGridView managerDataGridView;
        private System.Windows.Forms.DataGridView workerDataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox deleteManagerTextBox;
    }
}

