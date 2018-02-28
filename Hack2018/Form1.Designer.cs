namespace Hack2018 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.labelLat = new System.Windows.Forms.Label();
            this.labelLon = new System.Windows.Forms.Label();
            this.textBoxLat = new System.Windows.Forms.TextBox();
            this.textBoxLon = new System.Windows.Forms.TextBox();
            this.textBoxZoom = new System.Windows.Forms.TextBox();
            this.labelZoom = new System.Windows.Forms.Label();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.pictureBoxStart = new System.Windows.Forms.PictureBox();
            this.pictureBoxEnd = new System.Windows.Forms.PictureBox();
            this.buttonRun = new System.Windows.Forms.Button();
            this.checkBoxChange = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnd)).BeginInit();
            this.SuspendLayout();
            // 
            // labelLat
            // 
            this.labelLat.AutoSize = true;
            this.labelLat.Location = new System.Drawing.Point(12, 9);
            this.labelLat.Name = "labelLat";
            this.labelLat.Size = new System.Drawing.Size(63, 17);
            this.labelLat.TabIndex = 0;
            this.labelLat.Text = "Latitude:";
            // 
            // labelLon
            // 
            this.labelLon.AutoSize = true;
            this.labelLon.Location = new System.Drawing.Point(12, 37);
            this.labelLon.Name = "labelLon";
            this.labelLon.Size = new System.Drawing.Size(75, 17);
            this.labelLon.TabIndex = 1;
            this.labelLon.Text = "Longitude:";
            // 
            // textBoxLat
            // 
            this.textBoxLat.Location = new System.Drawing.Point(93, 6);
            this.textBoxLat.Name = "textBoxLat";
            this.textBoxLat.Size = new System.Drawing.Size(100, 22);
            this.textBoxLat.TabIndex = 2;
            this.textBoxLat.Text = "37.7795";
            // 
            // textBoxLon
            // 
            this.textBoxLon.Location = new System.Drawing.Point(93, 34);
            this.textBoxLon.Name = "textBoxLon";
            this.textBoxLon.Size = new System.Drawing.Size(100, 22);
            this.textBoxLon.TabIndex = 3;
            this.textBoxLon.Text = "-122.4205";
            // 
            // textBoxZoom
            // 
            this.textBoxZoom.Location = new System.Drawing.Point(93, 63);
            this.textBoxZoom.Name = "textBoxZoom";
            this.textBoxZoom.Size = new System.Drawing.Size(100, 22);
            this.textBoxZoom.TabIndex = 5;
            this.textBoxZoom.Text = "0.05";
            // 
            // labelZoom
            // 
            this.labelZoom.AutoSize = true;
            this.labelZoom.Location = new System.Drawing.Point(12, 66);
            this.labelZoom.Name = "labelZoom";
            this.labelZoom.Size = new System.Drawing.Size(48, 17);
            this.labelZoom.TabIndex = 4;
            this.labelZoom.Text = "Zoom:";
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.CustomFormat = "";
            this.dateTimePickerStart.Location = new System.Drawing.Point(315, 6);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerStart.TabIndex = 6;
            this.dateTimePickerStart.Value = new System.DateTime(2014, 1, 1, 0, 0, 0, 0);
            // 
            // labelStartDate
            // 
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.Location = new System.Drawing.Point(212, 9);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(76, 17);
            this.labelStartDate.TabIndex = 7;
            this.labelStartDate.Text = "Start Date:";
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.Location = new System.Drawing.Point(212, 37);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(71, 17);
            this.labelEndDate.TabIndex = 8;
            this.labelEndDate.Text = "End Date:";
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Location = new System.Drawing.Point(315, 34);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerEnd.TabIndex = 9;
            this.dateTimePickerEnd.Value = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            // 
            // pictureBoxStart
            // 
            this.pictureBoxStart.Location = new System.Drawing.Point(12, 104);
            this.pictureBoxStart.Name = "pictureBoxStart";
            this.pictureBoxStart.Size = new System.Drawing.Size(472, 472);
            this.pictureBoxStart.TabIndex = 10;
            this.pictureBoxStart.TabStop = false;
            // 
            // pictureBoxEnd
            // 
            this.pictureBoxEnd.Location = new System.Drawing.Point(502, 104);
            this.pictureBoxEnd.Name = "pictureBoxEnd";
            this.pictureBoxEnd.Size = new System.Drawing.Size(472, 472);
            this.pictureBoxEnd.TabIndex = 11;
            this.pictureBoxEnd.TabStop = false;
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(641, 26);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(193, 55);
            this.buttonRun.TabIndex = 12;
            this.buttonRun.Text = "Run";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // checkBoxChange
            // 
            this.checkBoxChange.AutoSize = true;
            this.checkBoxChange.Location = new System.Drawing.Point(315, 65);
            this.checkBoxChange.Name = "checkBoxChange";
            this.checkBoxChange.Size = new System.Drawing.Size(117, 21);
            this.checkBoxChange.TabIndex = 13;
            this.checkBoxChange.Text = "Show Change";
            this.checkBoxChange.UseVisualStyleBackColor = true;
            this.checkBoxChange.CheckedChanged += new System.EventHandler(this.checkBoxChange_CheckedChanged);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(986, 588);
            this.Controls.Add(this.checkBoxChange);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.pictureBoxEnd);
            this.Controls.Add(this.pictureBoxStart);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.labelEndDate);
            this.Controls.Add(this.labelStartDate);
            this.Controls.Add(this.dateTimePickerStart);
            this.Controls.Add(this.textBoxZoom);
            this.Controls.Add(this.labelZoom);
            this.Controls.Add(this.textBoxLon);
            this.Controls.Add(this.textBoxLat);
            this.Controls.Add(this.labelLon);
            this.Controls.Add(this.labelLat);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLat;
        private System.Windows.Forms.Label labelLon;
        private System.Windows.Forms.TextBox textBoxLat;
        private System.Windows.Forms.TextBox textBoxLon;
        private System.Windows.Forms.TextBox textBoxZoom;
        private System.Windows.Forms.Label labelZoom;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.PictureBox pictureBoxStart;
        private System.Windows.Forms.PictureBox pictureBoxEnd;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.CheckBox checkBoxChange;
    }
}

