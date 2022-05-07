
namespace KinoLK.Administrator
{
    partial class Bilans
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
            this.DGVbilans = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.DGVbilans)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVbilans
            // 
            this.DGVbilans.AllowUserToAddRows = false;
            this.DGVbilans.AllowUserToDeleteRows = false;
            this.DGVbilans.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVbilans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVbilans.Location = new System.Drawing.Point(50, 137);
            this.DGVbilans.Name = "DGVbilans";
            this.DGVbilans.Size = new System.Drawing.Size(726, 317);
            this.DGVbilans.TabIndex = 3;
            this.DGVbilans.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVbilans_CellContentClick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(50, 88);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(189, 20);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Bilans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 511);
            this.Controls.Add(this.DGVbilans);
            this.Controls.Add(this.dateTimePicker1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Bilans";
            this.Text = "Bilans";
            this.Load += new System.EventHandler(this.Bilans_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVbilans)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVbilans;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}