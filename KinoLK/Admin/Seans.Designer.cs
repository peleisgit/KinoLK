
namespace KinoLK.Admin
{
    partial class Seans
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
            this.DGVrooms = new System.Windows.Forms.DataGridView();
            this.DGVmovies = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.DGVseanses = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.NumerucUpDownHour = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.NumerucUpDownMinute = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.DGVrooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVmovies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVseanses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumerucUpDownHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumerucUpDownMinute)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVrooms
            // 
            this.DGVrooms.AllowUserToAddRows = false;
            this.DGVrooms.AllowUserToDeleteRows = false;
            this.DGVrooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVrooms.Location = new System.Drawing.Point(12, 12);
            this.DGVrooms.Name = "DGVrooms";
            this.DGVrooms.Size = new System.Drawing.Size(379, 150);
            this.DGVrooms.TabIndex = 0;
            this.DGVrooms.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVrooms_CellClick);
            // 
            // DGVmovies
            // 
            this.DGVmovies.AllowUserToAddRows = false;
            this.DGVmovies.AllowUserToDeleteRows = false;
            this.DGVmovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVmovies.Location = new System.Drawing.Point(397, 12);
            this.DGVmovies.Name = "DGVmovies";
            this.DGVmovies.Size = new System.Drawing.Size(391, 150);
            this.DGVmovies.TabIndex = 2;
            this.DGVmovies.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVmovies_CellClick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(466, 185);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(466, 357);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(296, 23);
            this.BtnAdd.TabIndex = 25;
            this.BtnAdd.Text = "Dodaj";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnRemove
            // 
            this.BtnRemove.Location = new System.Drawing.Point(466, 386);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(296, 23);
            this.BtnRemove.TabIndex = 26;
            this.BtnRemove.Text = "Usuń";
            this.BtnRemove.UseVisualStyleBackColor = true;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // DGVseanses
            // 
            this.DGVseanses.AllowUserToAddRows = false;
            this.DGVseanses.AllowUserToDeleteRows = false;
            this.DGVseanses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVseanses.Location = new System.Drawing.Point(12, 185);
            this.DGVseanses.Name = "DGVseanses";
            this.DGVseanses.Size = new System.Drawing.Size(448, 253);
            this.DGVseanses.TabIndex = 27;
            this.DGVseanses.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVseanses_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(672, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Godzina";
            // 
            // NumerucUpDownHour
            // 
            this.NumerucUpDownHour.Location = new System.Drawing.Point(675, 209);
            this.NumerucUpDownHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.NumerucUpDownHour.Name = "NumerucUpDownHour";
            this.NumerucUpDownHour.Size = new System.Drawing.Size(87, 20);
            this.NumerucUpDownHour.TabIndex = 29;
            this.NumerucUpDownHour.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(672, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Minuta";
            // 
            // NumerucUpDownMinute
            // 
            this.NumerucUpDownMinute.Location = new System.Drawing.Point(675, 259);
            this.NumerucUpDownMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.NumerucUpDownMinute.Name = "NumerucUpDownMinute";
            this.NumerucUpDownMinute.Size = new System.Drawing.Size(87, 20);
            this.NumerucUpDownMinute.TabIndex = 31;
            // 
            // Seans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NumerucUpDownMinute);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NumerucUpDownHour);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGVseanses);
            this.Controls.Add(this.BtnRemove);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.DGVmovies);
            this.Controls.Add(this.DGVrooms);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Seans";
            this.Text = "Seans";
            this.Load += new System.EventHandler(this.Seans_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVrooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVmovies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVseanses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumerucUpDownHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumerucUpDownMinute)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVrooms;
        private System.Windows.Forms.DataGridView DGVmovies;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnRemove;
        private System.Windows.Forms.DataGridView DGVseanses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NumerucUpDownHour;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NumerucUpDownMinute;
    }
}