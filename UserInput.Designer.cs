namespace Calendar
{
    partial class UserInput
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInput));
            toolStripWindow = new ReaLTaiizor.Controls.CrownToolStrip();
            btnClose = new ToolStripButton();
            btnMinimize = new ToolStripButton();
            btnWindow = new ToolStripButton();
            cmbxType = new ReaLTaiizor.Controls.DungeonComboBox();
            panelInput = new Panel();
            btnSaveA = new Button();
            btnSaveT = new Button();
            lblEPurpose = new Label();
            btnSaveE = new Button();
            lblEEnd = new Label();
            tbxEEnd = new ReaLTaiizor.Controls.SmallTextBox();
            lblLocation = new Label();
            tbxLocation = new ReaLTaiizor.Controls.SmallTextBox();
            lblAEnd = new Label();
            tbxAEnd = new ReaLTaiizor.Controls.SmallTextBox();
            lblAStart = new Label();
            tbxAStart = new ReaLTaiizor.Controls.SmallTextBox();
            dtADate = new DateTimePicker();
            lblADate = new Label();
            rbtnHigh = new RadioButton();
            rbtnMedium = new RadioButton();
            rbtnLow = new RadioButton();
            lblTaskPriority = new Label();
            dtTaskDate = new DateTimePicker();
            lblTaskTime = new Label();
            tbxTaskTime = new ReaLTaiizor.Controls.SmallTextBox();
            lblTaskDT = new Label();
            lblTitle = new Label();
            tbxTitle = new ReaLTaiizor.Controls.SmallTextBox();
            cmbxEPurpose = new ComboBox();
            lblEDate = new Label();
            dtEDate = new DateTimePicker();
            lblADuration = new Label();
            nADuration = new ReaLTaiizor.Controls.DungeonNumeric();
            lblEDuration = new Label();
            nEDuration = new ReaLTaiizor.Controls.DungeonNumeric();
            lblEStart = new Label();
            tbxEStart = new ReaLTaiizor.Controls.SmallTextBox();
            toolStripWindow.SuspendLayout();
            panelInput.SuspendLayout();
            SuspendLayout();
            // 
            // toolStripWindow
            // 
            toolStripWindow.AutoSize = false;
            toolStripWindow.BackColor = Color.FromArgb(60, 63, 65);
            toolStripWindow.ForeColor = Color.FromArgb(220, 220, 220);
            toolStripWindow.GripStyle = ToolStripGripStyle.Hidden;
            toolStripWindow.Items.AddRange(new ToolStripItem[] { btnClose, btnMinimize, btnWindow });
            toolStripWindow.Location = new Point(0, 0);
            toolStripWindow.Name = "toolStripWindow";
            toolStripWindow.Padding = new Padding(5, 0, 1, 0);
            toolStripWindow.Size = new Size(479, 25);
            toolStripWindow.TabIndex = 2;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(60, 63, 65);
            btnClose.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnClose.ForeColor = Color.FromArgb(220, 220, 220);
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.ImageTransparentColor = Color.Magenta;
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(23, 22);
            btnClose.Click += btnClose_Click;
            // 
            // btnMinimize
            // 
            btnMinimize.BackColor = Color.FromArgb(60, 63, 65);
            btnMinimize.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnMinimize.ForeColor = Color.FromArgb(220, 220, 220);
            btnMinimize.Image = (Image)resources.GetObject("btnMinimize.Image");
            btnMinimize.ImageTransparentColor = Color.Magenta;
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(23, 22);
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnWindow
            // 
            btnWindow.BackColor = Color.FromArgb(60, 63, 65);
            btnWindow.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnWindow.ForeColor = Color.FromArgb(220, 220, 220);
            btnWindow.Image = (Image)resources.GetObject("btnWindow.Image");
            btnWindow.ImageTransparentColor = Color.Magenta;
            btnWindow.Name = "btnWindow";
            btnWindow.Size = new Size(23, 22);
            btnWindow.Click += btnWindow_Click;
            // 
            // cmbxType
            // 
            cmbxType.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbxType.BackColor = Color.FromArgb(246, 246, 246);
            cmbxType.ColorA = Color.RoyalBlue;
            cmbxType.ColorB = Color.RoyalBlue;
            cmbxType.ColorC = Color.FromArgb(242, 241, 240);
            cmbxType.ColorD = Color.FromArgb(253, 252, 252);
            cmbxType.ColorE = Color.FromArgb(239, 237, 236);
            cmbxType.ColorF = Color.FromArgb(180, 180, 180);
            cmbxType.ColorG = Color.FromArgb(119, 119, 118);
            cmbxType.ColorH = Color.FromArgb(224, 222, 220);
            cmbxType.ColorI = Color.FromArgb(250, 249, 249);
            cmbxType.DrawMode = DrawMode.OwnerDrawFixed;
            cmbxType.DropDownHeight = 100;
            cmbxType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbxType.Font = new Font("ISOCPEUR", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbxType.ForeColor = Color.FromArgb(76, 76, 97);
            cmbxType.FormattingEnabled = true;
            cmbxType.HoverSelectionColor = Color.Empty;
            cmbxType.IntegralHeight = false;
            cmbxType.ItemHeight = 20;
            cmbxType.Items.AddRange(new object[] { "Task", "Appointment", "Event" });
            cmbxType.Location = new Point(12, 41);
            cmbxType.Name = "cmbxType";
            cmbxType.Size = new Size(455, 26);
            cmbxType.StartIndex = 0;
            cmbxType.TabIndex = 6;
            cmbxType.SelectedIndexChanged += cmbxType_SelectedIndexChanged;
            // 
            // panelInput
            // 
            panelInput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelInput.Controls.Add(btnSaveA);
            panelInput.Controls.Add(btnSaveT);
            panelInput.Controls.Add(lblEPurpose);
            panelInput.Controls.Add(btnSaveE);
            panelInput.Controls.Add(lblEEnd);
            panelInput.Controls.Add(tbxEEnd);
            panelInput.Controls.Add(lblLocation);
            panelInput.Controls.Add(tbxLocation);
            panelInput.Controls.Add(lblAEnd);
            panelInput.Controls.Add(tbxAEnd);
            panelInput.Controls.Add(lblAStart);
            panelInput.Controls.Add(tbxAStart);
            panelInput.Controls.Add(dtADate);
            panelInput.Controls.Add(lblADate);
            panelInput.Controls.Add(rbtnHigh);
            panelInput.Controls.Add(rbtnMedium);
            panelInput.Controls.Add(rbtnLow);
            panelInput.Controls.Add(lblTaskPriority);
            panelInput.Controls.Add(dtTaskDate);
            panelInput.Controls.Add(lblTaskTime);
            panelInput.Controls.Add(tbxTaskTime);
            panelInput.Controls.Add(lblTaskDT);
            panelInput.Controls.Add(lblTitle);
            panelInput.Controls.Add(tbxTitle);
            panelInput.Controls.Add(cmbxEPurpose);
            panelInput.Controls.Add(lblEDate);
            panelInput.Controls.Add(dtEDate);
            panelInput.Controls.Add(lblADuration);
            panelInput.Controls.Add(nADuration);
            panelInput.Controls.Add(lblEDuration);
            panelInput.Controls.Add(nEDuration);
            panelInput.Controls.Add(lblEStart);
            panelInput.Controls.Add(tbxEStart);
            panelInput.Font = new Font("ISOCPEUR", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panelInput.Location = new Point(12, 73);
            panelInput.Name = "panelInput";
            panelInput.Size = new Size(455, 397);
            panelInput.TabIndex = 7;
            // 
            // btnSaveA
            // 
            btnSaveA.ForeColor = Color.FromArgb(60, 63, 65);
            btnSaveA.Location = new Point(191, 257);
            btnSaveA.Name = "btnSaveA";
            btnSaveA.Size = new Size(75, 30);
            btnSaveA.TabIndex = 32;
            btnSaveA.Text = "Save";
            btnSaveA.UseVisualStyleBackColor = true;
            btnSaveA.Click += btnSaveA_Click;
            // 
            // btnSaveT
            // 
            btnSaveT.ForeColor = Color.FromArgb(60, 63, 65);
            btnSaveT.Location = new Point(191, 221);
            btnSaveT.Name = "btnSaveT";
            btnSaveT.Size = new Size(75, 30);
            btnSaveT.TabIndex = 33;
            btnSaveT.Text = "Save";
            btnSaveT.UseVisualStyleBackColor = true;
            btnSaveT.Click += btnSaveT_Click;
            // 
            // lblEPurpose
            // 
            lblEPurpose.AutoSize = true;
            lblEPurpose.Font = new Font("ISOCPEUR", 12F);
            lblEPurpose.ForeColor = Color.FromArgb(60, 63, 65);
            lblEPurpose.Location = new Point(82, 302);
            lblEPurpose.Name = "lblEPurpose";
            lblEPurpose.Size = new Size(59, 21);
            lblEPurpose.TabIndex = 44;
            lblEPurpose.Text = "Purpose";
            lblEPurpose.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnSaveE
            // 
            btnSaveE.ForeColor = Color.FromArgb(60, 63, 65);
            btnSaveE.Location = new Point(191, 350);
            btnSaveE.Name = "btnSaveE";
            btnSaveE.Size = new Size(75, 30);
            btnSaveE.TabIndex = 42;
            btnSaveE.Text = "Save";
            btnSaveE.UseVisualStyleBackColor = true;
            btnSaveE.Click += btnSaveE_Click;
            // 
            // lblEEnd
            // 
            lblEEnd.AutoSize = true;
            lblEEnd.Font = new Font("ISOCPEUR", 12F);
            lblEEnd.ForeColor = Color.FromArgb(60, 63, 65);
            lblEEnd.Location = new Point(59, 256);
            lblEEnd.Name = "lblEEnd";
            lblEEnd.Size = new Size(82, 21);
            lblEEnd.TabIndex = 41;
            lblEEnd.Text = "End (HH:MM)";
            lblEEnd.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tbxEEnd
            // 
            tbxEEnd.BackColor = Color.Transparent;
            tbxEEnd.BorderColor = Color.FromArgb(180, 180, 180);
            tbxEEnd.CustomBGColor = Color.White;
            tbxEEnd.Font = new Font("ISOCPEUR", 12F);
            tbxEEnd.ForeColor = Color.DimGray;
            tbxEEnd.Location = new Point(157, 247);
            tbxEEnd.MaxLength = 32767;
            tbxEEnd.Multiline = false;
            tbxEEnd.Name = "tbxEEnd";
            tbxEEnd.ReadOnly = false;
            tbxEEnd.Size = new Size(227, 30);
            tbxEEnd.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            tbxEEnd.TabIndex = 40;
            tbxEEnd.TextAlignment = HorizontalAlignment.Left;
            tbxEEnd.UseSystemPasswordChar = false;
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.Font = new Font("ISOCPEUR", 12F);
            lblLocation.ForeColor = Color.FromArgb(60, 63, 65);
            lblLocation.Location = new Point(81, 81);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(60, 21);
            lblLocation.TabIndex = 35;
            lblLocation.Text = "Location";
            lblLocation.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tbxLocation
            // 
            tbxLocation.BackColor = Color.Transparent;
            tbxLocation.BorderColor = Color.FromArgb(180, 180, 180);
            tbxLocation.CustomBGColor = Color.White;
            tbxLocation.Font = new Font("ISOCPEUR", 12F);
            tbxLocation.ForeColor = Color.DimGray;
            tbxLocation.Location = new Point(157, 72);
            tbxLocation.MaxLength = 32767;
            tbxLocation.Multiline = false;
            tbxLocation.Name = "tbxLocation";
            tbxLocation.ReadOnly = false;
            tbxLocation.Size = new Size(227, 30);
            tbxLocation.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            tbxLocation.TabIndex = 34;
            tbxLocation.TextAlignment = HorizontalAlignment.Left;
            tbxLocation.UseSystemPasswordChar = false;
            // 
            // lblAEnd
            // 
            lblAEnd.AutoSize = true;
            lblAEnd.Font = new Font("ISOCPEUR", 12F);
            lblAEnd.ForeColor = Color.FromArgb(60, 63, 65);
            lblAEnd.Location = new Point(59, 210);
            lblAEnd.Name = "lblAEnd";
            lblAEnd.Size = new Size(82, 21);
            lblAEnd.TabIndex = 27;
            lblAEnd.Text = "End (HH:MM)";
            lblAEnd.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tbxAEnd
            // 
            tbxAEnd.BackColor = Color.Transparent;
            tbxAEnd.BorderColor = Color.FromArgb(180, 180, 180);
            tbxAEnd.CustomBGColor = Color.White;
            tbxAEnd.Font = new Font("ISOCPEUR", 12F);
            tbxAEnd.ForeColor = Color.DimGray;
            tbxAEnd.Location = new Point(157, 201);
            tbxAEnd.MaxLength = 32767;
            tbxAEnd.Multiline = false;
            tbxAEnd.Name = "tbxAEnd";
            tbxAEnd.ReadOnly = false;
            tbxAEnd.Size = new Size(227, 30);
            tbxAEnd.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            tbxAEnd.TabIndex = 26;
            tbxAEnd.TextAlignment = HorizontalAlignment.Left;
            tbxAEnd.UseSystemPasswordChar = false;
            // 
            // lblAStart
            // 
            lblAStart.AutoSize = true;
            lblAStart.Font = new Font("ISOCPEUR", 12F);
            lblAStart.ForeColor = Color.FromArgb(60, 63, 65);
            lblAStart.Location = new Point(47, 169);
            lblAStart.Name = "lblAStart";
            lblAStart.Size = new Size(94, 21);
            lblAStart.TabIndex = 25;
            lblAStart.Text = "Start (HH:MM)";
            lblAStart.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tbxAStart
            // 
            tbxAStart.BackColor = Color.Transparent;
            tbxAStart.BorderColor = Color.FromArgb(180, 180, 180);
            tbxAStart.CustomBGColor = Color.White;
            tbxAStart.Font = new Font("ISOCPEUR", 12F);
            tbxAStart.ForeColor = Color.DimGray;
            tbxAStart.Location = new Point(157, 160);
            tbxAStart.MaxLength = 32767;
            tbxAStart.Multiline = false;
            tbxAStart.Name = "tbxAStart";
            tbxAStart.ReadOnly = false;
            tbxAStart.Size = new Size(227, 30);
            tbxAStart.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            tbxAStart.TabIndex = 24;
            tbxAStart.TextAlignment = HorizontalAlignment.Left;
            tbxAStart.UseSystemPasswordChar = false;
            // 
            // dtADate
            // 
            dtADate.CalendarForeColor = Color.FromArgb(60, 63, 65);
            dtADate.CalendarTitleForeColor = Color.FromArgb(60, 63, 65);
            dtADate.Location = new Point(157, 75);
            dtADate.Name = "dtADate";
            dtADate.Size = new Size(227, 27);
            dtADate.TabIndex = 23;
            // 
            // lblADate
            // 
            lblADate.AutoSize = true;
            lblADate.Font = new Font("ISOCPEUR", 12F);
            lblADate.ForeColor = Color.FromArgb(60, 63, 65);
            lblADate.Location = new Point(103, 81);
            lblADate.Name = "lblADate";
            lblADate.Size = new Size(38, 21);
            lblADate.TabIndex = 22;
            lblADate.Text = "Date";
            lblADate.TextAlign = ContentAlignment.MiddleRight;
            // 
            // rbtnHigh
            // 
            rbtnHigh.AutoSize = true;
            rbtnHigh.ForeColor = Color.FromArgb(60, 63, 65);
            rbtnHigh.Location = new Point(334, 167);
            rbtnHigh.Name = "rbtnHigh";
            rbtnHigh.Size = new Size(53, 25);
            rbtnHigh.TabIndex = 19;
            rbtnHigh.TabStop = true;
            rbtnHigh.Text = "High";
            rbtnHigh.UseVisualStyleBackColor = true;
            // 
            // rbtnMedium
            // 
            rbtnMedium.AutoSize = true;
            rbtnMedium.ForeColor = Color.FromArgb(60, 63, 65);
            rbtnMedium.Location = new Point(234, 167);
            rbtnMedium.Name = "rbtnMedium";
            rbtnMedium.Size = new Size(70, 25);
            rbtnMedium.TabIndex = 18;
            rbtnMedium.TabStop = true;
            rbtnMedium.Text = "Medium";
            rbtnMedium.UseVisualStyleBackColor = true;
            // 
            // rbtnLow
            // 
            rbtnLow.AutoSize = true;
            rbtnLow.ForeColor = Color.FromArgb(60, 63, 65);
            rbtnLow.Location = new Point(160, 167);
            rbtnLow.Name = "rbtnLow";
            rbtnLow.Size = new Size(51, 25);
            rbtnLow.TabIndex = 17;
            rbtnLow.TabStop = true;
            rbtnLow.Text = "Low";
            rbtnLow.UseVisualStyleBackColor = true;
            // 
            // lblTaskPriority
            // 
            lblTaskPriority.AutoSize = true;
            lblTaskPriority.Font = new Font("ISOCPEUR", 12F);
            lblTaskPriority.ForeColor = Color.FromArgb(60, 63, 65);
            lblTaskPriority.Location = new Point(85, 169);
            lblTaskPriority.Name = "lblTaskPriority";
            lblTaskPriority.Size = new Size(56, 21);
            lblTaskPriority.TabIndex = 16;
            lblTaskPriority.Text = "Priority";
            lblTaskPriority.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dtTaskDate
            // 
            dtTaskDate.CalendarForeColor = Color.FromArgb(60, 63, 65);
            dtTaskDate.CalendarTitleForeColor = Color.FromArgb(60, 63, 65);
            dtTaskDate.Location = new Point(157, 75);
            dtTaskDate.Name = "dtTaskDate";
            dtTaskDate.Size = new Size(227, 27);
            dtTaskDate.TabIndex = 15;
            // 
            // lblTaskTime
            // 
            lblTaskTime.AutoSize = true;
            lblTaskTime.Font = new Font("ISOCPEUR", 12F);
            lblTaskTime.ForeColor = Color.FromArgb(60, 63, 65);
            lblTaskTime.Location = new Point(25, 127);
            lblTaskTime.Name = "lblTaskTime";
            lblTaskTime.Size = new Size(116, 21);
            lblTaskTime.TabIndex = 14;
            lblTaskTime.Text = "Due Time (HH:MM)";
            lblTaskTime.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tbxTaskTime
            // 
            tbxTaskTime.BackColor = Color.Transparent;
            tbxTaskTime.BorderColor = Color.FromArgb(180, 180, 180);
            tbxTaskTime.CustomBGColor = Color.White;
            tbxTaskTime.Font = new Font("ISOCPEUR", 12F);
            tbxTaskTime.ForeColor = Color.DimGray;
            tbxTaskTime.Location = new Point(157, 119);
            tbxTaskTime.MaxLength = 32767;
            tbxTaskTime.Multiline = false;
            tbxTaskTime.Name = "tbxTaskTime";
            tbxTaskTime.ReadOnly = false;
            tbxTaskTime.Size = new Size(227, 30);
            tbxTaskTime.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            tbxTaskTime.TabIndex = 13;
            tbxTaskTime.TextAlignment = HorizontalAlignment.Left;
            tbxTaskTime.UseSystemPasswordChar = false;
            // 
            // lblTaskDT
            // 
            lblTaskDT.AutoSize = true;
            lblTaskDT.Font = new Font("ISOCPEUR", 12F);
            lblTaskDT.ForeColor = Color.FromArgb(60, 63, 65);
            lblTaskDT.Location = new Point(75, 81);
            lblTaskDT.Name = "lblTaskDT";
            lblTaskDT.Size = new Size(66, 21);
            lblTaskDT.TabIndex = 12;
            lblTaskDT.Text = "Due Date";
            lblTaskDT.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("ISOCPEUR", 12F);
            lblTitle.ForeColor = Color.FromArgb(60, 63, 65);
            lblTitle.Location = new Point(103, 37);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(38, 21);
            lblTitle.TabIndex = 10;
            lblTitle.Text = "Title";
            lblTitle.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tbxTitle
            // 
            tbxTitle.BackColor = Color.Transparent;
            tbxTitle.BorderColor = Color.FromArgb(180, 180, 180);
            tbxTitle.CustomBGColor = Color.White;
            tbxTitle.Font = new Font("ISOCPEUR", 12F);
            tbxTitle.ForeColor = Color.DimGray;
            tbxTitle.Location = new Point(157, 28);
            tbxTitle.MaxLength = 32767;
            tbxTitle.Multiline = false;
            tbxTitle.Name = "tbxTitle";
            tbxTitle.ReadOnly = false;
            tbxTitle.Size = new Size(227, 30);
            tbxTitle.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            tbxTitle.TabIndex = 9;
            tbxTitle.TextAlignment = HorizontalAlignment.Left;
            tbxTitle.UseSystemPasswordChar = false;
            // 
            // cmbxEPurpose
            // 
            cmbxEPurpose.FormattingEnabled = true;
            cmbxEPurpose.Items.AddRange(new object[] { "Personal", "Social", "School", "Work" });
            cmbxEPurpose.Location = new Point(157, 294);
            cmbxEPurpose.Name = "cmbxEPurpose";
            cmbxEPurpose.Size = new Size(227, 29);
            cmbxEPurpose.TabIndex = 45;
            // 
            // lblEDate
            // 
            lblEDate.AutoSize = true;
            lblEDate.Font = new Font("ISOCPEUR", 12F);
            lblEDate.ForeColor = Color.FromArgb(60, 63, 65);
            lblEDate.Location = new Point(103, 128);
            lblEDate.Name = "lblEDate";
            lblEDate.Size = new Size(38, 21);
            lblEDate.TabIndex = 34;
            lblEDate.Text = "Date";
            lblEDate.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dtEDate
            // 
            dtEDate.CalendarForeColor = Color.FromArgb(60, 63, 65);
            dtEDate.CalendarTitleForeColor = Color.FromArgb(60, 63, 65);
            dtEDate.Location = new Point(157, 122);
            dtEDate.Name = "dtEDate";
            dtEDate.Size = new Size(227, 27);
            dtEDate.TabIndex = 35;
            // 
            // lblADuration
            // 
            lblADuration.AutoSize = true;
            lblADuration.Font = new Font("ISOCPEUR", 12F);
            lblADuration.ForeColor = Color.FromArgb(60, 63, 65);
            lblADuration.Location = new Point(38, 128);
            lblADuration.Name = "lblADuration";
            lblADuration.Size = new Size(103, 21);
            lblADuration.TabIndex = 28;
            lblADuration.Text = "Duration (Hour)";
            lblADuration.TextAlign = ContentAlignment.MiddleRight;
            // 
            // nADuration
            // 
            nADuration.BackColor = Color.Transparent;
            nADuration.BackColorA = Color.FromArgb(246, 246, 246);
            nADuration.BackColorB = Color.FromArgb(254, 254, 254);
            nADuration.BorderColor = Color.FromArgb(180, 180, 180);
            nADuration.ButtonForeColorA = Color.FromArgb(75, 75, 75);
            nADuration.ButtonForeColorB = Color.FromArgb(75, 75, 75);
            nADuration.Font = new Font("ISOCPEUR", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nADuration.ForeColor = Color.FromArgb(60, 63, 65);
            nADuration.Location = new Point(157, 121);
            nADuration.Maximum = 100L;
            nADuration.Minimum = 0L;
            nADuration.MinimumSize = new Size(93, 28);
            nADuration.Name = "nADuration";
            nADuration.Size = new Size(227, 28);
            nADuration.TabIndex = 31;
            nADuration.TextAlignment = ReaLTaiizor.Controls.DungeonNumeric._TextAlignment.Near;
            nADuration.Value = 0L;
            // 
            // lblEDuration
            // 
            lblEDuration.AutoSize = true;
            lblEDuration.Font = new Font("ISOCPEUR", 12F);
            lblEDuration.ForeColor = Color.FromArgb(60, 63, 65);
            lblEDuration.Location = new Point(38, 169);
            lblEDuration.Name = "lblEDuration";
            lblEDuration.Size = new Size(103, 21);
            lblEDuration.TabIndex = 36;
            lblEDuration.Text = "Duration (Hour)";
            lblEDuration.TextAlign = ContentAlignment.MiddleRight;
            // 
            // nEDuration
            // 
            nEDuration.BackColor = Color.Transparent;
            nEDuration.BackColorA = Color.FromArgb(246, 246, 246);
            nEDuration.BackColorB = Color.FromArgb(254, 254, 254);
            nEDuration.BorderColor = Color.FromArgb(180, 180, 180);
            nEDuration.ButtonForeColorA = Color.FromArgb(75, 75, 75);
            nEDuration.ButtonForeColorB = Color.FromArgb(75, 75, 75);
            nEDuration.Font = new Font("ISOCPEUR", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nEDuration.ForeColor = Color.FromArgb(60, 63, 65);
            nEDuration.Location = new Point(157, 162);
            nEDuration.Maximum = 100L;
            nEDuration.Minimum = 0L;
            nEDuration.MinimumSize = new Size(93, 28);
            nEDuration.Name = "nEDuration";
            nEDuration.Size = new Size(227, 28);
            nEDuration.TabIndex = 37;
            nEDuration.TextAlignment = ReaLTaiizor.Controls.DungeonNumeric._TextAlignment.Near;
            nEDuration.Value = 0L;
            // 
            // lblEStart
            // 
            lblEStart.AutoSize = true;
            lblEStart.Font = new Font("ISOCPEUR", 12F);
            lblEStart.ForeColor = Color.FromArgb(60, 63, 65);
            lblEStart.Location = new Point(47, 210);
            lblEStart.Name = "lblEStart";
            lblEStart.Size = new Size(94, 21);
            lblEStart.TabIndex = 39;
            lblEStart.Text = "Start (HH:MM)";
            lblEStart.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tbxEStart
            // 
            tbxEStart.BackColor = Color.Transparent;
            tbxEStart.BorderColor = Color.FromArgb(180, 180, 180);
            tbxEStart.CustomBGColor = Color.White;
            tbxEStart.Font = new Font("ISOCPEUR", 12F);
            tbxEStart.ForeColor = Color.DimGray;
            tbxEStart.Location = new Point(157, 201);
            tbxEStart.MaxLength = 32767;
            tbxEStart.Multiline = false;
            tbxEStart.Name = "tbxEStart";
            tbxEStart.ReadOnly = false;
            tbxEStart.Size = new Size(227, 30);
            tbxEStart.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            tbxEStart.TabIndex = 38;
            tbxEStart.TextAlignment = HorizontalAlignment.Left;
            tbxEStart.UseSystemPasswordChar = false;
            // 
            // UserInput
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(479, 479);
            ControlBox = false;
            Controls.Add(panelInput);
            Controls.Add(cmbxType);
            Controls.Add(toolStripWindow);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "UserInput";
            Load += UserInput_Load;
            toolStripWindow.ResumeLayout(false);
            toolStripWindow.PerformLayout();
            panelInput.ResumeLayout(false);
            panelInput.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.CrownToolStrip toolStripWindow;
        private ToolStripButton btnClose;
        private ToolStripButton btnMinimize;
        private ToolStripButton btnWindow;
        private ReaLTaiizor.Controls.DungeonComboBox cmbxType;
        private Panel panelInput;
        private Button btnSaveA;
        private Button btnSaveT;
        private Label lblEPurpose;
        private Button btnSaveE;
        private Label lblEEnd;
        private ReaLTaiizor.Controls.SmallTextBox tbxEEnd;
        private Label lblLocation;
        private ReaLTaiizor.Controls.SmallTextBox tbxLocation;
        private Label lblAEnd;
        private ReaLTaiizor.Controls.SmallTextBox tbxAEnd;
        private Label lblAStart;
        private ReaLTaiizor.Controls.SmallTextBox tbxAStart;
        private DateTimePicker dtADate;
        private Label lblADate;
        private RadioButton rbtnHigh;
        private RadioButton rbtnMedium;
        private RadioButton rbtnLow;
        private Label lblTaskPriority;
        private DateTimePicker dtTaskDate;
        private Label lblTaskTime;
        private ReaLTaiizor.Controls.SmallTextBox tbxTaskTime;
        private Label lblTaskDT;
        private Label lblTitle;
        private ReaLTaiizor.Controls.SmallTextBox tbxTitle;
        private ComboBox cmbxEPurpose;
        private Label lblEDate;
        private DateTimePicker dtEDate;
        private Label lblADuration;
        private ReaLTaiizor.Controls.DungeonNumeric nADuration;
        private Label lblEDuration;
        private ReaLTaiizor.Controls.DungeonNumeric nEDuration;
        private Label lblEStart;
        private ReaLTaiizor.Controls.SmallTextBox tbxEStart;
    }
}