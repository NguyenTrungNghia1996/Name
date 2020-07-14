namespace Name
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnOpen = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.listFile = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbSub6 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbSub5 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbSub4 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbSub3 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbSub2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSub1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMain = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.Drive = new System.Windows.Forms.Label();
            this.txtDrive = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(12, 494);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(176, 13);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(693, 504);
            this.axWindowsMediaPlayer1.TabIndex = 3;
            // 
            // listFile
            // 
            this.listFile.FormattingEnabled = true;
            this.listFile.Location = new System.Drawing.Point(12, 13);
            this.listFile.Name = "listFile";
            this.listFile.Size = new System.Drawing.Size(158, 472);
            this.listFile.TabIndex = 4;
            this.listFile.SelectedIndexChanged += new System.EventHandler(this.listFile_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(875, 343);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 20);
            this.label7.TabIndex = 45;
            this.label7.Text = "Sub Category 6";
            // 
            // cbSub6
            // 
            this.cbSub6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSub6.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSub6.FormattingEnabled = true;
            this.cbSub6.Location = new System.Drawing.Point(875, 366);
            this.cbSub6.Name = "cbSub6";
            this.cbSub6.Size = new System.Drawing.Size(210, 29);
            this.cbSub6.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(875, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 20);
            this.label6.TabIndex = 43;
            this.label6.Text = "Sub Category 5";
            // 
            // cbSub5
            // 
            this.cbSub5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSub5.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSub5.FormattingEnabled = true;
            this.cbSub5.Location = new System.Drawing.Point(875, 311);
            this.cbSub5.Name = "cbSub5";
            this.cbSub5.Size = new System.Drawing.Size(210, 29);
            this.cbSub5.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(875, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 41;
            this.label5.Text = "Sub Category 4";
            // 
            // cbSub4
            // 
            this.cbSub4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSub4.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSub4.FormattingEnabled = true;
            this.cbSub4.Location = new System.Drawing.Point(875, 256);
            this.cbSub4.Name = "cbSub4";
            this.cbSub4.Size = new System.Drawing.Size(210, 29);
            this.cbSub4.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(875, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 39;
            this.label4.Text = "Sub Category 3";
            // 
            // cbSub3
            // 
            this.cbSub3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSub3.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSub3.FormattingEnabled = true;
            this.cbSub3.Location = new System.Drawing.Point(875, 201);
            this.cbSub3.Name = "cbSub3";
            this.cbSub3.Size = new System.Drawing.Size(210, 29);
            this.cbSub3.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(875, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "Sub Category 2";
            // 
            // cbSub2
            // 
            this.cbSub2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSub2.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSub2.FormattingEnabled = true;
            this.cbSub2.Location = new System.Drawing.Point(875, 146);
            this.cbSub2.Name = "cbSub2";
            this.cbSub2.Size = new System.Drawing.Size(210, 29);
            this.cbSub2.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(875, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Sub Category 1";
            // 
            // cbSub1
            // 
            this.cbSub1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSub1.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSub1.FormattingEnabled = true;
            this.cbSub1.Location = new System.Drawing.Point(875, 91);
            this.cbSub1.Name = "cbSub1";
            this.cbSub1.Size = new System.Drawing.Size(210, 29);
            this.cbSub1.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(875, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Main Category";
            // 
            // cbMain
            // 
            this.cbMain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMain.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMain.FormattingEnabled = true;
            this.cbMain.Location = new System.Drawing.Point(875, 36);
            this.cbMain.Name = "cbMain";
            this.cbMain.Size = new System.Drawing.Size(210, 29);
            this.cbMain.TabIndex = 32;
            this.cbMain.SelectedIndexChanged += new System.EventHandler(this.cbMain_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1009, 401);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 46;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Drive
            // 
            this.Drive.AutoSize = true;
            this.Drive.Location = new System.Drawing.Point(876, 457);
            this.Drive.Name = "Drive";
            this.Drive.Size = new System.Drawing.Size(35, 13);
            this.Drive.TabIndex = 47;
            this.Drive.Text = "Drive:";
            // 
            // txtDrive
            // 
            this.txtDrive.Location = new System.Drawing.Point(914, 454);
            this.txtDrive.Name = "txtDrive";
            this.txtDrive.Size = new System.Drawing.Size(100, 20);
            this.txtDrive.TabIndex = 48;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 527);
            this.Controls.Add(this.txtDrive);
            this.Controls.Add(this.Drive);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbSub6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbSub5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbSub4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbSub3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbSub2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbSub1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbMain);
            this.Controls.Add(this.listFile);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.btnOpen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOpen;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.ListBox listFile;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbSub6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbSub5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbSub4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbSub3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbSub2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSub1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMain;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label Drive;
        private System.Windows.Forms.TextBox txtDrive;
    }
}

