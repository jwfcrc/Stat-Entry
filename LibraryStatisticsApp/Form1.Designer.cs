namespace LibraryStatisticsApp
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
            this.LocationComboBox = new System.Windows.Forms.ComboBox();
            this.DateLabel = new System.Windows.Forms.Label();
            this.LocationLabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.DoorCountInput = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.DoorCountLabel = new System.Windows.Forms.Label();
            this.EContCountLabel = new System.Windows.Forms.Label();
            this.TeleCountLabel = new System.Windows.Forms.Label();
            this.TechCountLabel = new System.Windows.Forms.Label();
            this.DirectionCountLabel = new System.Windows.Forms.Label();
            this.InfoEnquiriesCountLabel = new System.Windows.Forms.Label();
            this.PlusEcontentButton = new System.Windows.Forms.Button();
            this.PlusTeleButton = new System.Windows.Forms.Button();
            this.PlusTechButton = new System.Windows.Forms.Button();
            this.PlusDirectButton = new System.Windows.Forms.Button();
            this.PlusInfoButton = new System.Windows.Forms.Button();
            this.EContentEnquiriesLabel = new System.Windows.Forms.Label();
            this.TeleEnquiriesLabel = new System.Windows.Forms.Label();
            this.TechEnquiriesLabel = new System.Windows.Forms.Label();
            this.DirectionEnquiriesLabel = new System.Windows.Forms.Label();
            this.InfoEnquiriesLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MinusEcontentButton = new System.Windows.Forms.Button();
            this.MinusTeleButton = new System.Windows.Forms.Button();
            this.MinusTechButton = new System.Windows.Forms.Button();
            this.MinusDirectButton = new System.Windows.Forms.Button();
            this.MinusInfoButton = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LocationComboBox
            // 
            this.LocationComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LocationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LocationComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocationComboBox.FormattingEnabled = true;
            this.LocationComboBox.Items.AddRange(new object[] {
            "BH-Circulation",
            "HB-Circulation",
            "HB-Info",
            "HW-Circulation",
            "MB-Circulation",
            "MB-Info",
            "MB-Toy",
            "TR-Circulation"});
            this.LocationComboBox.Location = new System.Drawing.Point(159, 21);
            this.LocationComboBox.Name = "LocationComboBox";
            this.LocationComboBox.Size = new System.Drawing.Size(119, 28);
            this.LocationComboBox.Sorted = true;
            this.LocationComboBox.TabIndex = 2;
            this.LocationComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(0, 0);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(48, 20);
            this.DateLabel.TabIndex = 3;
            this.DateLabel.Text = "Date";
            this.DateLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // LocationLabel
            // 
            this.LocationLabel.AutoSize = true;
            this.LocationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocationLabel.Location = new System.Drawing.Point(155, 0);
            this.LocationLabel.Name = "LocationLabel";
            this.LocationLabel.Size = new System.Drawing.Size(78, 20);
            this.LocationLabel.TabIndex = 4;
            this.LocationLabel.Text = "Location";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.SkyBlue;
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(4, 22);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(134, 26);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.StartButton);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ResetButton);
            this.groupBox1.Controls.Add(this.DoorCountInput);
            this.groupBox1.Controls.Add(this.SaveButton);
            this.groupBox1.Controls.Add(this.DoorCountLabel);
            this.groupBox1.Controls.Add(this.EContCountLabel);
            this.groupBox1.Controls.Add(this.TeleCountLabel);
            this.groupBox1.Controls.Add(this.TechCountLabel);
            this.groupBox1.Controls.Add(this.DirectionCountLabel);
            this.groupBox1.Controls.Add(this.InfoEnquiriesCountLabel);
            this.groupBox1.Controls.Add(this.PlusEcontentButton);
            this.groupBox1.Controls.Add(this.PlusTeleButton);
            this.groupBox1.Controls.Add(this.PlusTechButton);
            this.groupBox1.Controls.Add(this.PlusDirectButton);
            this.groupBox1.Controls.Add(this.PlusInfoButton);
            this.groupBox1.Controls.Add(this.EContentEnquiriesLabel);
            this.groupBox1.Controls.Add(this.TeleEnquiriesLabel);
            this.groupBox1.Controls.Add(this.TechEnquiriesLabel);
            this.groupBox1.Controls.Add(this.DirectionEnquiriesLabel);
            this.groupBox1.Controls.Add(this.InfoEnquiriesLabel);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 330);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enquiry Counters";
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.SkyBlue;
            this.StartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartButton.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.StartButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(0, -2);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(274, 332);
            this.StartButton.TabIndex = 26;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(6, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 2);
            this.label5.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(0, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(274, 2);
            this.label4.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(0, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 2);
            this.label3.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(0, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 2);
            this.label2.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(0, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 2);
            this.label1.TabIndex = 20;
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.SkyBlue;
            this.ResetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.Location = new System.Drawing.Point(6, 287);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 37);
            this.ResetButton.TabIndex = 9;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            this.ResetButton.MouseHover += new System.EventHandler(this.ResetButton_MouseHover);
            // 
            // DoorCountInput
            // 
            this.DoorCountInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoorCountInput.Location = new System.Drawing.Point(121, 253);
            this.DoorCountInput.MaxLength = 4;
            this.DoorCountInput.Name = "DoorCountInput";
            this.DoorCountInput.ShortcutsEnabled = false;
            this.DoorCountInput.Size = new System.Drawing.Size(75, 29);
            this.DoorCountInput.TabIndex = 11;
            this.DoorCountInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DoorCountInput_KeyPress);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.SkyBlue;
            this.SaveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(79, 287);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(138, 37);
            this.SaveButton.TabIndex = 8;
            this.SaveButton.Text = "Save+Close";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            this.SaveButton.MouseHover += new System.EventHandler(this.SaveButton_MouseHover);
            // 
            // DoorCountLabel
            // 
            this.DoorCountLabel.AutoSize = true;
            this.DoorCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoorCountLabel.Location = new System.Drawing.Point(4, 258);
            this.DoorCountLabel.Name = "DoorCountLabel";
            this.DoorCountLabel.Size = new System.Drawing.Size(116, 24);
            this.DoorCountLabel.TabIndex = 10;
            this.DoorCountLabel.Text = "Door Count";
            this.DoorCountLabel.MouseHover += new System.EventHandler(this.DoorCountLabel_MouseHover);
            // 
            // EContCountLabel
            // 
            this.EContCountLabel.AutoSize = true;
            this.EContCountLabel.Location = new System.Drawing.Point(219, 214);
            this.EContCountLabel.Name = "EContCountLabel";
            this.EContCountLabel.Size = new System.Drawing.Size(21, 24);
            this.EContCountLabel.TabIndex = 19;
            this.EContCountLabel.Text = "0";
            // 
            // TeleCountLabel
            // 
            this.TeleCountLabel.AutoSize = true;
            this.TeleCountLabel.Location = new System.Drawing.Point(219, 169);
            this.TeleCountLabel.Name = "TeleCountLabel";
            this.TeleCountLabel.Size = new System.Drawing.Size(21, 24);
            this.TeleCountLabel.TabIndex = 18;
            this.TeleCountLabel.Text = "0";
            // 
            // TechCountLabel
            // 
            this.TechCountLabel.AutoSize = true;
            this.TechCountLabel.Location = new System.Drawing.Point(219, 124);
            this.TechCountLabel.Name = "TechCountLabel";
            this.TechCountLabel.Size = new System.Drawing.Size(21, 24);
            this.TechCountLabel.TabIndex = 17;
            this.TechCountLabel.Text = "0";
            // 
            // DirectionCountLabel
            // 
            this.DirectionCountLabel.AutoSize = true;
            this.DirectionCountLabel.Location = new System.Drawing.Point(219, 79);
            this.DirectionCountLabel.Name = "DirectionCountLabel";
            this.DirectionCountLabel.Size = new System.Drawing.Size(21, 24);
            this.DirectionCountLabel.TabIndex = 16;
            this.DirectionCountLabel.Text = "0";
            // 
            // InfoEnquiriesCountLabel
            // 
            this.InfoEnquiriesCountLabel.AutoSize = true;
            this.InfoEnquiriesCountLabel.Location = new System.Drawing.Point(219, 34);
            this.InfoEnquiriesCountLabel.Name = "InfoEnquiriesCountLabel";
            this.InfoEnquiriesCountLabel.Size = new System.Drawing.Size(21, 24);
            this.InfoEnquiriesCountLabel.TabIndex = 15;
            this.InfoEnquiriesCountLabel.Text = "0";
            this.InfoEnquiriesCountLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // PlusEcontentButton
            // 
            this.PlusEcontentButton.BackColor = System.Drawing.Color.SkyBlue;
            this.PlusEcontentButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlusEcontentButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PlusEcontentButton.Location = new System.Drawing.Point(121, 208);
            this.PlusEcontentButton.Name = "PlusEcontentButton";
            this.PlusEcontentButton.Size = new System.Drawing.Size(75, 37);
            this.PlusEcontentButton.TabIndex = 14;
            this.PlusEcontentButton.Text = "+";
            this.PlusEcontentButton.UseVisualStyleBackColor = false;
            this.PlusEcontentButton.Click += new System.EventHandler(this.PlusEcontentButton_Click);
            this.PlusEcontentButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PlusEcontentButton_MouseClick);
            // 
            // PlusTeleButton
            // 
            this.PlusTeleButton.BackColor = System.Drawing.Color.SkyBlue;
            this.PlusTeleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlusTeleButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PlusTeleButton.Location = new System.Drawing.Point(121, 163);
            this.PlusTeleButton.Name = "PlusTeleButton";
            this.PlusTeleButton.Size = new System.Drawing.Size(75, 37);
            this.PlusTeleButton.TabIndex = 13;
            this.PlusTeleButton.Text = "+";
            this.PlusTeleButton.UseVisualStyleBackColor = false;
            this.PlusTeleButton.Click += new System.EventHandler(this.button7_Click);
            this.PlusTeleButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PlusTeleButton_MouseClick);
            // 
            // PlusTechButton
            // 
            this.PlusTechButton.BackColor = System.Drawing.Color.SkyBlue;
            this.PlusTechButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlusTechButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PlusTechButton.Location = new System.Drawing.Point(121, 118);
            this.PlusTechButton.Name = "PlusTechButton";
            this.PlusTechButton.Size = new System.Drawing.Size(75, 37);
            this.PlusTechButton.TabIndex = 12;
            this.PlusTechButton.Text = "+";
            this.PlusTechButton.UseVisualStyleBackColor = false;
            this.PlusTechButton.Click += new System.EventHandler(this.PlusTechButton_Click);
            this.PlusTechButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PlusTechButton_MouseClick);
            // 
            // PlusDirectButton
            // 
            this.PlusDirectButton.BackColor = System.Drawing.Color.SkyBlue;
            this.PlusDirectButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlusDirectButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PlusDirectButton.Location = new System.Drawing.Point(121, 73);
            this.PlusDirectButton.Name = "PlusDirectButton";
            this.PlusDirectButton.Size = new System.Drawing.Size(75, 37);
            this.PlusDirectButton.TabIndex = 7;
            this.PlusDirectButton.Text = "+";
            this.PlusDirectButton.UseVisualStyleBackColor = false;
            this.PlusDirectButton.Click += new System.EventHandler(this.PlusDirectButton_Click);
            this.PlusDirectButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PlusDirectButton_MouseClick);
            // 
            // PlusInfoButton
            // 
            this.PlusInfoButton.BackColor = System.Drawing.Color.SkyBlue;
            this.PlusInfoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlusInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PlusInfoButton.Location = new System.Drawing.Point(121, 28);
            this.PlusInfoButton.Name = "PlusInfoButton";
            this.PlusInfoButton.Size = new System.Drawing.Size(75, 37);
            this.PlusInfoButton.TabIndex = 5;
            this.PlusInfoButton.Text = "+";
            this.PlusInfoButton.UseVisualStyleBackColor = false;
            this.PlusInfoButton.Click += new System.EventHandler(this.PlusInfoButton_Click);
            this.PlusInfoButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PlusInfoButton_MouseClick);
            // 
            // EContentEnquiriesLabel
            // 
            this.EContentEnquiriesLabel.AutoSize = true;
            this.EContentEnquiriesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EContentEnquiriesLabel.Location = new System.Drawing.Point(9, 214);
            this.EContentEnquiriesLabel.Name = "EContentEnquiriesLabel";
            this.EContentEnquiriesLabel.Size = new System.Drawing.Size(94, 24);
            this.EContentEnquiriesLabel.TabIndex = 4;
            this.EContentEnquiriesLabel.Text = "E-Content";
            // 
            // TeleEnquiriesLabel
            // 
            this.TeleEnquiriesLabel.AutoSize = true;
            this.TeleEnquiriesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeleEnquiriesLabel.Location = new System.Drawing.Point(9, 168);
            this.TeleEnquiriesLabel.Name = "TeleEnquiriesLabel";
            this.TeleEnquiriesLabel.Size = new System.Drawing.Size(103, 24);
            this.TeleEnquiriesLabel.TabIndex = 3;
            this.TeleEnquiriesLabel.Text = "Telephone";
            // 
            // TechEnquiriesLabel
            // 
            this.TechEnquiriesLabel.AutoSize = true;
            this.TechEnquiriesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TechEnquiriesLabel.Location = new System.Drawing.Point(9, 123);
            this.TechEnquiriesLabel.Name = "TechEnquiriesLabel";
            this.TechEnquiriesLabel.Size = new System.Drawing.Size(93, 24);
            this.TechEnquiriesLabel.TabIndex = 2;
            this.TechEnquiriesLabel.Text = "Technical";
            // 
            // DirectionEnquiriesLabel
            // 
            this.DirectionEnquiriesLabel.AutoSize = true;
            this.DirectionEnquiriesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DirectionEnquiriesLabel.Location = new System.Drawing.Point(9, 78);
            this.DirectionEnquiriesLabel.Name = "DirectionEnquiriesLabel";
            this.DirectionEnquiriesLabel.Size = new System.Drawing.Size(98, 24);
            this.DirectionEnquiriesLabel.TabIndex = 1;
            this.DirectionEnquiriesLabel.Text = "Directional";
            // 
            // InfoEnquiriesLabel
            // 
            this.InfoEnquiriesLabel.AutoSize = true;
            this.InfoEnquiriesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoEnquiriesLabel.Location = new System.Drawing.Point(9, 33);
            this.InfoEnquiriesLabel.Name = "InfoEnquiriesLabel";
            this.InfoEnquiriesLabel.Size = new System.Drawing.Size(102, 24);
            this.InfoEnquiriesLabel.TabIndex = 0;
            this.InfoEnquiriesLabel.Text = "Information";
            this.InfoEnquiriesLabel.Click += new System.EventHandler(this.InfoEnquiriesLabel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(196, 185);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // MinusEcontentButton
            // 
            this.MinusEcontentButton.Enabled = false;
            this.MinusEcontentButton.Location = new System.Drawing.Point(472, 295);
            this.MinusEcontentButton.Name = "MinusEcontentButton";
            this.MinusEcontentButton.Size = new System.Drawing.Size(75, 37);
            this.MinusEcontentButton.TabIndex = 11;
            this.MinusEcontentButton.Text = "-";
            this.MinusEcontentButton.UseVisualStyleBackColor = true;
            this.MinusEcontentButton.Visible = false;
            this.MinusEcontentButton.Click += new System.EventHandler(this.MinusEcontentButton_Click);
            // 
            // MinusTeleButton
            // 
            this.MinusTeleButton.Enabled = false;
            this.MinusTeleButton.Location = new System.Drawing.Point(472, 243);
            this.MinusTeleButton.Name = "MinusTeleButton";
            this.MinusTeleButton.Size = new System.Drawing.Size(75, 37);
            this.MinusTeleButton.TabIndex = 10;
            this.MinusTeleButton.Text = "-";
            this.MinusTeleButton.UseVisualStyleBackColor = true;
            this.MinusTeleButton.Visible = false;
            this.MinusTeleButton.Click += new System.EventHandler(this.MinusTeleButton_Click);
            // 
            // MinusTechButton
            // 
            this.MinusTechButton.Enabled = false;
            this.MinusTechButton.Location = new System.Drawing.Point(472, 191);
            this.MinusTechButton.Name = "MinusTechButton";
            this.MinusTechButton.Size = new System.Drawing.Size(75, 37);
            this.MinusTechButton.TabIndex = 9;
            this.MinusTechButton.Text = "-";
            this.MinusTechButton.UseVisualStyleBackColor = true;
            this.MinusTechButton.Visible = false;
            this.MinusTechButton.Click += new System.EventHandler(this.MinusTechButton_Click);
            // 
            // MinusDirectButton
            // 
            this.MinusDirectButton.Enabled = false;
            this.MinusDirectButton.Location = new System.Drawing.Point(472, 140);
            this.MinusDirectButton.Name = "MinusDirectButton";
            this.MinusDirectButton.Size = new System.Drawing.Size(75, 37);
            this.MinusDirectButton.TabIndex = 8;
            this.MinusDirectButton.Text = "-";
            this.MinusDirectButton.UseVisualStyleBackColor = true;
            this.MinusDirectButton.Visible = false;
            this.MinusDirectButton.Click += new System.EventHandler(this.MinusDirectButton_Click);
            // 
            // MinusInfoButton
            // 
            this.MinusInfoButton.Enabled = false;
            this.MinusInfoButton.Location = new System.Drawing.Point(472, 90);
            this.MinusInfoButton.Name = "MinusInfoButton";
            this.MinusInfoButton.Size = new System.Drawing.Size(75, 37);
            this.MinusInfoButton.TabIndex = 6;
            this.MinusInfoButton.Text = "-";
            this.MinusInfoButton.UseVisualStyleBackColor = true;
            this.MinusInfoButton.Visible = false;
            this.MinusInfoButton.Click += new System.EventHandler(this.MinusInfoButton_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.LoadButton.Enabled = false;
            this.LoadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadButton.Location = new System.Drawing.Point(467, 337);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(80, 37);
            this.LoadButton.TabIndex = 25;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Visible = false;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            this.LoadButton.MouseHover += new System.EventHandler(this.LoadButton_MouseHover);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(184, -2);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(84, 13);
            this.linkLabel1.TabIndex = 28;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Docs #3512115";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(283, 386);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.LocationLabel);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.LocationComboBox);
            this.Controls.Add(this.MinusTechButton);
            this.Controls.Add(this.MinusEcontentButton);
            this.Controls.Add(this.MinusInfoButton);
            this.Controls.Add(this.MinusTeleButton);
            this.Controls.Add(this.MinusDirectButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(1380, 200);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Library Statistics";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox LocationComboBox;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label LocationLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button PlusEcontentButton;
        private System.Windows.Forms.Button PlusTeleButton;
        private System.Windows.Forms.Button PlusTechButton;
        private System.Windows.Forms.Button MinusEcontentButton;
        private System.Windows.Forms.Button MinusTeleButton;
        private System.Windows.Forms.Button MinusTechButton;
        private System.Windows.Forms.Button MinusDirectButton;
        private System.Windows.Forms.Button PlusDirectButton;
        private System.Windows.Forms.Button MinusInfoButton;
        private System.Windows.Forms.Button PlusInfoButton;
        private System.Windows.Forms.Label EContentEnquiriesLabel;
        private System.Windows.Forms.Label TeleEnquiriesLabel;
        private System.Windows.Forms.Label TechEnquiriesLabel;
        private System.Windows.Forms.Label DirectionEnquiriesLabel;
        private System.Windows.Forms.Label InfoEnquiriesLabel;
        private System.Windows.Forms.Label InfoEnquiriesCountLabel;
        private System.Windows.Forms.Label EContCountLabel;
        private System.Windows.Forms.Label TeleCountLabel;
        private System.Windows.Forms.Label TechCountLabel;
        private System.Windows.Forms.Label DirectionCountLabel;
        private System.Windows.Forms.Label DoorCountLabel;
        private System.Windows.Forms.TextBox DoorCountInput;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

