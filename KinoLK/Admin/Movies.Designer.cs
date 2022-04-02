
namespace KinoLK.Administrator
{
    partial class Movies
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
            this.DGVmovies = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CheckboxForAdult = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnAddMovie = new System.Windows.Forms.Button();
            this.BtnEditMovie = new System.Windows.Forms.Button();
            this.BtnRemovieMovie = new System.Windows.Forms.Button();
            this.TextboxTitle = new System.Windows.Forms.TextBox();
            this.TextboxDirector = new System.Windows.Forms.TextBox();
            this.NumerUpDownDuration = new System.Windows.Forms.NumericUpDown();
            this.TextboxSpecies = new System.Windows.Forms.TextBox();
            this.NumerUpDownPurchase = new System.Windows.Forms.NumericUpDown();
            this.DateTimePickerYearProduction = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVmovies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumerUpDownDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumerUpDownPurchase)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVmovies
            // 
            this.DGVmovies.AllowUserToAddRows = false;
            this.DGVmovies.AllowUserToDeleteRows = false;
            this.DGVmovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVmovies.Location = new System.Drawing.Point(0, 12);
            this.DGVmovies.Name = "DGVmovies";
            this.DGVmovies.Size = new System.Drawing.Size(834, 238);
            this.DGVmovies.TabIndex = 0;
            this.DGVmovies.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVmovies_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tytuł";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 360);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Reżyer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(275, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Gatunek";
            // 
            // CheckboxForAdult
            // 
            this.CheckboxForAdult.AutoSize = true;
            this.CheckboxForAdult.Location = new System.Drawing.Point(460, 297);
            this.CheckboxForAdult.Name = "CheckboxForAdult";
            this.CheckboxForAdult.Size = new System.Drawing.Size(102, 17);
            this.CheckboxForAdult.TabIndex = 5;
            this.CheckboxForAdult.Text = "dla pełnoletnich";
            this.CheckboxForAdult.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 399);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Czas trwania";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(275, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Cena licencji";
            // 
            // BtnAddMovie
            // 
            this.BtnAddMovie.Location = new System.Drawing.Point(622, 357);
            this.BtnAddMovie.Name = "BtnAddMovie";
            this.BtnAddMovie.Size = new System.Drawing.Size(162, 23);
            this.BtnAddMovie.TabIndex = 8;
            this.BtnAddMovie.Text = "Dodaj film";
            this.BtnAddMovie.UseVisualStyleBackColor = true;
            this.BtnAddMovie.Click += new System.EventHandler(this.BtnAddMovie_Click);
            // 
            // BtnEditMovie
            // 
            this.BtnEditMovie.Location = new System.Drawing.Point(622, 386);
            this.BtnEditMovie.Name = "BtnEditMovie";
            this.BtnEditMovie.Size = new System.Drawing.Size(162, 23);
            this.BtnEditMovie.TabIndex = 9;
            this.BtnEditMovie.Text = "Edytuj";
            this.BtnEditMovie.UseVisualStyleBackColor = true;
            this.BtnEditMovie.Click += new System.EventHandler(this.BtnEditMovie_Click);
            // 
            // BtnRemovieMovie
            // 
            this.BtnRemovieMovie.Location = new System.Drawing.Point(622, 415);
            this.BtnRemovieMovie.Name = "BtnRemovieMovie";
            this.BtnRemovieMovie.Size = new System.Drawing.Size(162, 23);
            this.BtnRemovieMovie.TabIndex = 10;
            this.BtnRemovieMovie.Text = "Usuń";
            this.BtnRemovieMovie.UseVisualStyleBackColor = true;
            this.BtnRemovieMovie.Click += new System.EventHandler(this.BtnRemovieMovie_Click);
            // 
            // TextboxTitle
            // 
            this.TextboxTitle.Location = new System.Drawing.Point(54, 298);
            this.TextboxTitle.Name = "TextboxTitle";
            this.TextboxTitle.Size = new System.Drawing.Size(216, 20);
            this.TextboxTitle.TabIndex = 11;
            // 
            // TextboxDirector
            // 
            this.TextboxDirector.Location = new System.Drawing.Point(54, 376);
            this.TextboxDirector.Name = "TextboxDirector";
            this.TextboxDirector.Size = new System.Drawing.Size(216, 20);
            this.TextboxDirector.TabIndex = 12;
            // 
            // NumerUpDownDuration
            // 
            this.NumerUpDownDuration.Location = new System.Drawing.Point(54, 420);
            this.NumerUpDownDuration.Name = "NumerUpDownDuration";
            this.NumerUpDownDuration.Size = new System.Drawing.Size(120, 20);
            this.NumerUpDownDuration.TabIndex = 15;
            // 
            // TextboxSpecies
            // 
            this.TextboxSpecies.Location = new System.Drawing.Point(278, 297);
            this.TextboxSpecies.Name = "TextboxSpecies";
            this.TextboxSpecies.Size = new System.Drawing.Size(176, 20);
            this.TextboxSpecies.TabIndex = 17;
            // 
            // NumerUpDownPurchase
            // 
            this.NumerUpDownPurchase.Location = new System.Drawing.Point(278, 337);
            this.NumerUpDownPurchase.Name = "NumerUpDownPurchase";
            this.NumerUpDownPurchase.Size = new System.Drawing.Size(176, 20);
            this.NumerUpDownPurchase.TabIndex = 18;
            // 
            // DateTimePickerYearProduction
            // 
            this.DateTimePickerYearProduction.Location = new System.Drawing.Point(54, 337);
            this.DateTimePickerYearProduction.Name = "DateTimePickerYearProduction";
            this.DateTimePickerYearProduction.Size = new System.Drawing.Size(216, 20);
            this.DateTimePickerYearProduction.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 321);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Data produkcji";
            // 
            // Movies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 511);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DateTimePickerYearProduction);
            this.Controls.Add(this.NumerUpDownPurchase);
            this.Controls.Add(this.TextboxSpecies);
            this.Controls.Add(this.NumerUpDownDuration);
            this.Controls.Add(this.TextboxDirector);
            this.Controls.Add(this.TextboxTitle);
            this.Controls.Add(this.BtnRemovieMovie);
            this.Controls.Add(this.BtnEditMovie);
            this.Controls.Add(this.BtnAddMovie);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CheckboxForAdult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DGVmovies);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Movies";
            this.Text = "Movies";
            this.Load += new System.EventHandler(this.Movies_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVmovies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumerUpDownDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumerUpDownPurchase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVmovies;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox CheckboxForAdult;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnAddMovie;
        private System.Windows.Forms.Button BtnEditMovie;
        private System.Windows.Forms.Button BtnRemovieMovie;
        private System.Windows.Forms.TextBox TextboxTitle;
        private System.Windows.Forms.TextBox TextboxDirector;
        private System.Windows.Forms.NumericUpDown NumerUpDownDuration;
        private System.Windows.Forms.TextBox TextboxSpecies;
        private System.Windows.Forms.NumericUpDown NumerUpDownPurchase;
        private System.Windows.Forms.DateTimePicker DateTimePickerYearProduction;
        private System.Windows.Forms.Label label7;
    }
}