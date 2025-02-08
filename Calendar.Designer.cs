namespace Calendar
{
    partial class Calendar
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calendar));
            toopStripControls = new ReaLTaiizor.Controls.CrownToolStrip();
            btnClose = new ToolStripButton();
            btnMinimize = new ToolStripButton();
            btnWindow = new ToolStripButton();
            panelSide = new Panel();
            panelE = new Panel();
            flpEvent = new FlowLayoutPanel();
            lblEventHeader = new Label();
            tableEvents = new TableLayoutPanel();
            toolStripE = new ReaLTaiizor.Controls.ParrotToolStrip();
            tsEvent = new ToolStripSplitButton();
            EN = new ToolStripMenuItem();
            EF = new ToolStripMenuItem();
            EFA = new ToolStripMenuItem();
            EFSO = new ToolStripMenuItem();
            EFSC = new ToolStripMenuItem();
            EFW = new ToolStripMenuItem();
            ES = new ToolStripMenuItem();
            ESD = new ToolStripMenuItem();
            ESL = new ToolStripMenuItem();
            ESTT = new ToolStripMenuItem();
            panelA = new Panel();
            flpAppointment = new FlowLayoutPanel();
            lblAppointmentHeader = new Label();
            tableAppointments = new TableLayoutPanel();
            toolStripA = new ReaLTaiizor.Controls.ParrotToolStrip();
            tsAppointment = new ToolStripSplitButton();
            AN = new ToolStripMenuItem();
            AF = new ToolStripMenuItem();
            AFA = new ToolStripMenuItem();
            AFU = new ToolStripMenuItem();
            AFCO = new ToolStripMenuItem();
            AFCA = new ToolStripMenuItem();
            AS = new ToolStripMenuItem();
            ASD = new ToolStripMenuItem();
            AST = new ToolStripMenuItem();
            ASTT = new ToolStripMenuItem();
            panelT = new Panel();
            flpTask = new FlowLayoutPanel();
            lblTaskHeader = new Label();
            flpTasks = new FlowLayoutPanel();
            tableTasks = new TableLayoutPanel();
            toolStripT = new ReaLTaiizor.Controls.ParrotToolStrip();
            tsTask = new ToolStripSplitButton();
            TN = new ToolStripMenuItem();
            TF = new ToolStripMenuItem();
            TFA = new ToolStripMenuItem();
            TFP = new ToolStripMenuItem();
            TFC = new ToolStripMenuItem();
            TS = new ToolStripMenuItem();
            TSD = new ToolStripMenuItem();
            TSP = new ToolStripMenuItem();
            TST = new ToolStripMenuItem();
            cmsEvents = new ContextMenuStrip(components);
            viewEvent = new ToolStripMenuItem();
            deleteEvent = new ToolStripMenuItem();
            cmsAppointments = new ContextMenuStrip(components);
            viewA = new ToolStripMenuItem();
            deleteA = new ToolStripMenuItem();
            macoA = new ToolStripMenuItem();
            macaA = new ToolStripMenuItem();
            cmsTasks = new ContextMenuStrip(components);
            viewTask = new ToolStripMenuItem();
            deleteTask = new ToolStripMenuItem();
            macTask = new ToolStripMenuItem();
            panelView = new TableLayoutPanel();
            btnDay = new Button();
            btnWeek = new Button();
            btnMonth = new Button();
            btnYear = new Button();
            btnNext = new Button();
            btnToday = new Button();
            btnPrev = new Button();
            btnSearch = new Button();
            pcbxSearch = new PictureBox();
            tbxSearch = new TextBox();
            lblDate = new Label();
            tableDays = new TableLayoutPanel();
            lblSun = new Label();
            lblMon = new Label();
            lblSat = new Label();
            lblTue = new Label();
            lblFri = new Label();
            lblThu = new Label();
            lblWed = new Label();
            flpCalendar = new FlowLayoutPanel();
            panelCalendar = new Panel();
            toopStripControls.SuspendLayout();
            panelSide.SuspendLayout();
            panelE.SuspendLayout();
            flpEvent.SuspendLayout();
            toolStripE.SuspendLayout();
            panelA.SuspendLayout();
            flpAppointment.SuspendLayout();
            toolStripA.SuspendLayout();
            panelT.SuspendLayout();
            flpTask.SuspendLayout();
            flpTasks.SuspendLayout();
            toolStripT.SuspendLayout();
            cmsEvents.SuspendLayout();
            cmsAppointments.SuspendLayout();
            cmsTasks.SuspendLayout();
            panelView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbxSearch).BeginInit();
            tableDays.SuspendLayout();
            panelCalendar.SuspendLayout();
            SuspendLayout();
            // 
            // toopStripControls
            // 
            toopStripControls.AutoSize = false;
            toopStripControls.BackColor = Color.FromArgb(60, 63, 65);
            toopStripControls.ForeColor = Color.FromArgb(220, 220, 220);
            toopStripControls.GripStyle = ToolStripGripStyle.Hidden;
            toopStripControls.Items.AddRange(new ToolStripItem[] { btnClose, btnMinimize, btnWindow });
            toopStripControls.Location = new Point(0, 0);
            toopStripControls.Name = "toopStripControls";
            toopStripControls.Padding = new Padding(5, 0, 1, 0);
            toopStripControls.Size = new Size(1404, 25);
            toopStripControls.TabIndex = 1;
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
            // panelSide
            // 
            panelSide.BackColor = Color.FromArgb(223, 223, 223);
            panelSide.Controls.Add(panelE);
            panelSide.Controls.Add(panelA);
            panelSide.Controls.Add(panelT);
            panelSide.Dock = DockStyle.Left;
            panelSide.Location = new Point(0, 25);
            panelSide.Name = "panelSide";
            panelSide.Size = new Size(275, 706);
            panelSide.TabIndex = 2;
            // 
            // panelE
            // 
            panelE.Controls.Add(flpEvent);
            panelE.Controls.Add(toolStripE);
            panelE.Location = new Point(3, 471);
            panelE.Name = "panelE";
            panelE.Size = new Size(269, 228);
            panelE.TabIndex = 4;
            // 
            // flpEvent
            // 
            flpEvent.Controls.Add(lblEventHeader);
            flpEvent.Controls.Add(tableEvents);
            flpEvent.Location = new Point(3, 41);
            flpEvent.Name = "flpEvent";
            flpEvent.Size = new Size(263, 184);
            flpEvent.TabIndex = 52;
            // 
            // lblEventHeader
            // 
            lblEventHeader.AutoSize = true;
            lblEventHeader.BackColor = Color.FromArgb(60, 63, 65);
            lblEventHeader.Font = new Font("ISOCPEUR", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEventHeader.ForeColor = Color.FromArgb(223, 223, 223);
            lblEventHeader.Location = new Point(3, 0);
            lblEventHeader.Name = "lblEventHeader";
            lblEventHeader.Padding = new Padding(7, 3, 0, 3);
            lblEventHeader.Size = new Size(257, 27);
            lblEventHeader.TabIndex = 2;
            lblEventHeader.Text = "Title                  Date        ";
            // 
            // tableEvents
            // 
            tableEvents.AutoScroll = true;
            tableEvents.ColumnCount = 2;
            tableEvents.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableEvents.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableEvents.Dock = DockStyle.Top;
            tableEvents.Font = new Font("ISOCPEUR", 12F);
            tableEvents.ForeColor = Color.FromArgb(60, 63, 65);
            tableEvents.Location = new Point(3, 30);
            tableEvents.Name = "tableEvents";
            tableEvents.RowCount = 3;
            tableEvents.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableEvents.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableEvents.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableEvents.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableEvents.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableEvents.Size = new Size(257, 152);
            tableEvents.TabIndex = 54;
            // 
            // toolStripE
            // 
            toolStripE.BackColor = Color.Transparent;
            toolStripE.BorderColor = Color.Transparent;
            toolStripE.ForeColor = Color.Black;
            toolStripE.GripStyle = ToolStripGripStyle.Hidden;
            toolStripE.Items.AddRange(new ToolStripItem[] { tsEvent });
            toolStripE.Location = new Point(0, 0);
            toolStripE.Name = "toolStripE";
            toolStripE.Padding = new Padding(10, 10, 1, 0);
            toolStripE.Size = new Size(269, 38);
            toolStripE.TabIndex = 3;
            // 
            // tsEvent
            // 
            tsEvent.DropDownItems.AddRange(new ToolStripItem[] { EN, EF, ES });
            tsEvent.Font = new Font("ISOCPEUR", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tsEvent.ForeColor = Color.FromArgb(60, 63, 65);
            tsEvent.Image = (Image)resources.GetObject("tsEvent.Image");
            tsEvent.ImageTransparentColor = Color.Magenta;
            tsEvent.Name = "tsEvent";
            tsEvent.Size = new Size(76, 25);
            tsEvent.Text = "Event";
            tsEvent.ToolTipText = "Event";
            // 
            // EN
            // 
            EN.ForeColor = Color.FromArgb(60, 63, 65);
            EN.Name = "EN";
            EN.Size = new Size(113, 26);
            EN.Text = "New";
            EN.Click += EN_Click;
            // 
            // EF
            // 
            EF.DropDownItems.AddRange(new ToolStripItem[] { EFA, EFSO, EFSC, EFW });
            EF.ForeColor = Color.FromArgb(60, 63, 65);
            EF.Name = "EF";
            EF.Size = new Size(113, 26);
            EF.Text = "Filter";
            // 
            // EFA
            // 
            EFA.ForeColor = Color.FromArgb(60, 63, 65);
            EFA.Name = "EFA";
            EFA.Size = new Size(119, 26);
            EFA.Text = "All";
            EFA.Click += EFA_Click;
            // 
            // EFSO
            // 
            EFSO.ForeColor = Color.FromArgb(60, 63, 65);
            EFSO.Name = "EFSO";
            EFSO.Size = new Size(119, 26);
            EFSO.Text = "Social";
            EFSO.Click += EFSO_Click;
            // 
            // EFSC
            // 
            EFSC.ForeColor = Color.FromArgb(60, 63, 65);
            EFSC.Name = "EFSC";
            EFSC.Size = new Size(119, 26);
            EFSC.Text = "School";
            EFSC.Click += EFSC_Click;
            // 
            // EFW
            // 
            EFW.ForeColor = Color.FromArgb(60, 63, 65);
            EFW.Name = "EFW";
            EFW.Size = new Size(119, 26);
            EFW.Text = "Work";
            EFW.Click += EFW_Click;
            // 
            // ES
            // 
            ES.DropDownItems.AddRange(new ToolStripItem[] { ESD, ESL, ESTT });
            ES.ForeColor = Color.FromArgb(60, 63, 65);
            ES.Name = "ES";
            ES.Size = new Size(113, 26);
            ES.Text = "Sort";
            // 
            // ESD
            // 
            ESD.ForeColor = Color.FromArgb(60, 63, 65);
            ESD.Name = "ESD";
            ESD.Size = new Size(130, 26);
            ESD.Text = "Date";
            // 
            // ESL
            // 
            ESL.ForeColor = Color.FromArgb(60, 63, 65);
            ESL.Name = "ESL";
            ESL.Size = new Size(130, 26);
            ESL.Text = "Location";
            // 
            // ESTT
            // 
            ESTT.ForeColor = Color.FromArgb(60, 63, 65);
            ESTT.Name = "ESTT";
            ESTT.Size = new Size(130, 26);
            ESTT.Text = "Title";
            // 
            // panelA
            // 
            panelA.Controls.Add(flpAppointment);
            panelA.Controls.Add(toolStripA);
            panelA.Location = new Point(3, 237);
            panelA.Name = "panelA";
            panelA.Size = new Size(269, 228);
            panelA.TabIndex = 3;
            // 
            // flpAppointment
            // 
            flpAppointment.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flpAppointment.Controls.Add(lblAppointmentHeader);
            flpAppointment.Controls.Add(tableAppointments);
            flpAppointment.Location = new Point(3, 41);
            flpAppointment.Name = "flpAppointment";
            flpAppointment.Size = new Size(263, 184);
            flpAppointment.TabIndex = 52;
            // 
            // lblAppointmentHeader
            // 
            lblAppointmentHeader.AutoSize = true;
            lblAppointmentHeader.BackColor = Color.FromArgb(60, 63, 65);
            lblAppointmentHeader.Font = new Font("ISOCPEUR", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAppointmentHeader.ForeColor = Color.FromArgb(223, 223, 223);
            lblAppointmentHeader.Location = new Point(3, 0);
            lblAppointmentHeader.Name = "lblAppointmentHeader";
            lblAppointmentHeader.Padding = new Padding(7, 3, 0, 3);
            lblAppointmentHeader.Size = new Size(257, 27);
            lblAppointmentHeader.TabIndex = 1;
            lblAppointmentHeader.Text = "Title                  Date        ";
            // 
            // tableAppointments
            // 
            tableAppointments.AutoScroll = true;
            tableAppointments.ColumnCount = 2;
            tableAppointments.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableAppointments.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableAppointments.Dock = DockStyle.Top;
            tableAppointments.Font = new Font("ISOCPEUR", 12F);
            tableAppointments.ForeColor = Color.FromArgb(60, 63, 65);
            tableAppointments.Location = new Point(3, 30);
            tableAppointments.Name = "tableAppointments";
            tableAppointments.RowCount = 3;
            tableAppointments.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableAppointments.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableAppointments.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableAppointments.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableAppointments.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableAppointments.Size = new Size(257, 152);
            tableAppointments.TabIndex = 53;
            // 
            // toolStripA
            // 
            toolStripA.BackColor = Color.Transparent;
            toolStripA.BorderColor = Color.Transparent;
            toolStripA.ForeColor = Color.Black;
            toolStripA.GripStyle = ToolStripGripStyle.Hidden;
            toolStripA.Items.AddRange(new ToolStripItem[] { tsAppointment });
            toolStripA.Location = new Point(0, 0);
            toolStripA.Name = "toolStripA";
            toolStripA.Padding = new Padding(10, 10, 1, 0);
            toolStripA.Size = new Size(269, 38);
            toolStripA.TabIndex = 2;
            // 
            // tsAppointment
            // 
            tsAppointment.DropDownItems.AddRange(new ToolStripItem[] { AN, AF, AS });
            tsAppointment.Font = new Font("ISOCPEUR", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tsAppointment.ForeColor = Color.FromArgb(60, 63, 65);
            tsAppointment.Image = (Image)resources.GetObject("tsAppointment.Image");
            tsAppointment.ImageTransparentColor = Color.Magenta;
            tsAppointment.Name = "tsAppointment";
            tsAppointment.Size = new Size(117, 25);
            tsAppointment.Text = "Appointment";
            tsAppointment.ToolTipText = "Appointment";
            // 
            // AN
            // 
            AN.ForeColor = Color.FromArgb(60, 63, 65);
            AN.Name = "AN";
            AN.Size = new Size(113, 26);
            AN.Text = "New";
            AN.Click += AN_Click;
            // 
            // AF
            // 
            AF.DropDownItems.AddRange(new ToolStripItem[] { AFA, AFU, AFCO, AFCA });
            AF.ForeColor = Color.FromArgb(60, 63, 65);
            AF.Name = "AF";
            AF.Size = new Size(113, 26);
            AF.Text = "Filter";
            // 
            // AFA
            // 
            AFA.ForeColor = Color.FromArgb(60, 63, 65);
            AFA.Name = "AFA";
            AFA.Size = new Size(141, 26);
            AFA.Text = "All";
            AFA.Click += AFA_Click;
            // 
            // AFU
            // 
            AFU.ForeColor = Color.FromArgb(60, 63, 65);
            AFU.Name = "AFU";
            AFU.Size = new Size(141, 26);
            AFU.Text = "Upcoming";
            AFU.Click += AFU_Click;
            // 
            // AFCO
            // 
            AFCO.ForeColor = Color.FromArgb(60, 63, 65);
            AFCO.Name = "AFCO";
            AFCO.Size = new Size(141, 26);
            AFCO.Text = "Completed";
            AFCO.Click += AFCO_Click;
            // 
            // AFCA
            // 
            AFCA.ForeColor = Color.FromArgb(60, 63, 65);
            AFCA.Name = "AFCA";
            AFCA.Size = new Size(141, 26);
            AFCA.Text = "Canceled";
            AFCA.Click += AFCA_Click;
            // 
            // AS
            // 
            AS.DropDownItems.AddRange(new ToolStripItem[] { ASD, AST, ASTT });
            AS.ForeColor = Color.FromArgb(60, 63, 65);
            AS.Name = "AS";
            AS.Size = new Size(113, 26);
            AS.Text = "Sort";
            // 
            // ASD
            // 
            ASD.ForeColor = Color.FromArgb(60, 63, 65);
            ASD.Name = "ASD";
            ASD.Size = new Size(108, 26);
            ASD.Text = "Date";
            // 
            // AST
            // 
            AST.ForeColor = Color.FromArgb(60, 63, 65);
            AST.Name = "AST";
            AST.Size = new Size(108, 26);
            AST.Text = "Time";
            // 
            // ASTT
            // 
            ASTT.ForeColor = Color.FromArgb(60, 63, 65);
            ASTT.Name = "ASTT";
            ASTT.Size = new Size(108, 26);
            ASTT.Text = "Title";
            // 
            // panelT
            // 
            panelT.Controls.Add(flpTask);
            panelT.Controls.Add(toolStripT);
            panelT.Location = new Point(3, 3);
            panelT.Name = "panelT";
            panelT.Size = new Size(269, 228);
            panelT.TabIndex = 2;
            // 
            // flpTask
            // 
            flpTask.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flpTask.Controls.Add(lblTaskHeader);
            flpTask.Controls.Add(flpTasks);
            flpTask.Location = new Point(3, 41);
            flpTask.Name = "flpTask";
            flpTask.Size = new Size(263, 184);
            flpTask.TabIndex = 52;
            // 
            // lblTaskHeader
            // 
            lblTaskHeader.AutoSize = true;
            lblTaskHeader.BackColor = Color.FromArgb(60, 63, 65);
            lblTaskHeader.Font = new Font("ISOCPEUR", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTaskHeader.ForeColor = Color.FromArgb(223, 223, 223);
            lblTaskHeader.Location = new Point(3, 0);
            lblTaskHeader.Name = "lblTaskHeader";
            lblTaskHeader.Padding = new Padding(7, 3, 0, 3);
            lblTaskHeader.Size = new Size(257, 27);
            lblTaskHeader.TabIndex = 0;
            lblTaskHeader.Text = "Title                  Date        ";
            // 
            // flpTasks
            // 
            flpTasks.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flpTasks.Controls.Add(tableTasks);
            flpTasks.Font = new Font("ISOCPEUR", 12F);
            flpTasks.ForeColor = Color.FromArgb(60, 63, 65);
            flpTasks.Location = new Point(3, 30);
            flpTasks.Name = "flpTasks";
            flpTasks.Size = new Size(260, 155);
            flpTasks.TabIndex = 1;
            // 
            // tableTasks
            // 
            tableTasks.AutoScroll = true;
            tableTasks.ColumnCount = 2;
            tableTasks.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableTasks.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableTasks.Dock = DockStyle.Top;
            tableTasks.Location = new Point(3, 3);
            tableTasks.Name = "tableTasks";
            tableTasks.RowCount = 3;
            tableTasks.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableTasks.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableTasks.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableTasks.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableTasks.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableTasks.Size = new Size(257, 152);
            tableTasks.TabIndex = 52;
            // 
            // toolStripT
            // 
            toolStripT.BackColor = Color.Transparent;
            toolStripT.BorderColor = Color.Transparent;
            toolStripT.ForeColor = Color.Black;
            toolStripT.GripStyle = ToolStripGripStyle.Hidden;
            toolStripT.Items.AddRange(new ToolStripItem[] { tsTask });
            toolStripT.Location = new Point(0, 0);
            toolStripT.Name = "toolStripT";
            toolStripT.Padding = new Padding(10, 10, 1, 0);
            toolStripT.Size = new Size(269, 38);
            toolStripT.TabIndex = 1;
            // 
            // tsTask
            // 
            tsTask.DropDownItems.AddRange(new ToolStripItem[] { TN, TF, TS });
            tsTask.Font = new Font("ISOCPEUR", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tsTask.ForeColor = Color.FromArgb(60, 63, 65);
            tsTask.Image = (Image)resources.GetObject("tsTask.Image");
            tsTask.ImageTransparentColor = Color.Magenta;
            tsTask.Name = "tsTask";
            tsTask.Size = new Size(71, 25);
            tsTask.Text = "Task";
            tsTask.ToolTipText = "Task";
            // 
            // TN
            // 
            TN.ForeColor = Color.FromArgb(60, 63, 65);
            TN.Name = "TN";
            TN.Size = new Size(113, 26);
            TN.Text = "New";
            TN.Click += TN_Click;
            // 
            // TF
            // 
            TF.DropDownItems.AddRange(new ToolStripItem[] { TFA, TFP, TFC });
            TF.ForeColor = Color.FromArgb(60, 63, 65);
            TF.Name = "TF";
            TF.Size = new Size(113, 26);
            TF.Text = "Filter";
            // 
            // TFA
            // 
            TFA.ForeColor = Color.FromArgb(60, 63, 65);
            TFA.Name = "TFA";
            TFA.Size = new Size(141, 26);
            TFA.Text = "All";
            TFA.Click += TFA_Click;
            // 
            // TFP
            // 
            TFP.ForeColor = Color.FromArgb(60, 63, 65);
            TFP.Name = "TFP";
            TFP.Size = new Size(141, 26);
            TFP.Text = "Pending";
            TFP.Click += TFP_Click;
            // 
            // TFC
            // 
            TFC.ForeColor = Color.FromArgb(60, 63, 65);
            TFC.Name = "TFC";
            TFC.Size = new Size(141, 26);
            TFC.Text = "Completed";
            TFC.Click += TFC_Click;
            // 
            // TS
            // 
            TS.DropDownItems.AddRange(new ToolStripItem[] { TSD, TSP, TST });
            TS.ForeColor = Color.FromArgb(60, 63, 65);
            TS.Name = "TS";
            TS.Size = new Size(113, 26);
            TS.Text = "Sort";
            // 
            // TSD
            // 
            TSD.ForeColor = Color.FromArgb(60, 63, 65);
            TSD.Name = "TSD";
            TSD.Size = new Size(126, 26);
            TSD.Text = "Date";
            // 
            // TSP
            // 
            TSP.ForeColor = Color.FromArgb(60, 63, 65);
            TSP.Name = "TSP";
            TSP.Size = new Size(126, 26);
            TSP.Text = "Priority";
            // 
            // TST
            // 
            TST.ForeColor = Color.FromArgb(60, 63, 65);
            TST.Name = "TST";
            TST.Size = new Size(126, 26);
            TST.Text = "Title";
            // 
            // cmsEvents
            // 
            cmsEvents.Font = new Font("ISOCPEUR", 12F);
            cmsEvents.Items.AddRange(new ToolStripItem[] { viewEvent, deleteEvent });
            cmsEvents.Name = "cmsTasks";
            cmsEvents.Size = new Size(160, 56);
            // 
            // viewEvent
            // 
            viewEvent.ForeColor = Color.FromArgb(60, 63, 65);
            viewEvent.Name = "viewEvent";
            viewEvent.Size = new Size(159, 26);
            viewEvent.Text = "View Event";
            viewEvent.Click += viewEvent_Click;
            // 
            // deleteEvent
            // 
            deleteEvent.ForeColor = Color.FromArgb(60, 63, 65);
            deleteEvent.Name = "deleteEvent";
            deleteEvent.Size = new Size(159, 26);
            deleteEvent.Text = "Delete Event";
            deleteEvent.Click += deleteEvent_Click;
            // 
            // cmsAppointments
            // 
            cmsAppointments.Font = new Font("ISOCPEUR", 12F);
            cmsAppointments.Items.AddRange(new ToolStripItem[] { viewA, deleteA, macoA, macaA });
            cmsAppointments.Name = "cmsTasks";
            cmsAppointments.Size = new Size(201, 108);
            // 
            // viewA
            // 
            viewA.ForeColor = Color.FromArgb(60, 63, 65);
            viewA.Name = "viewA";
            viewA.Size = new Size(200, 26);
            viewA.Text = "View Appointment";
            viewA.Click += viewA_Click;
            // 
            // deleteA
            // 
            deleteA.ForeColor = Color.FromArgb(60, 63, 65);
            deleteA.Name = "deleteA";
            deleteA.Size = new Size(200, 26);
            deleteA.Text = "Delete Appointment";
            deleteA.Click += deleteA_Click;
            // 
            // macoA
            // 
            macoA.ForeColor = Color.FromArgb(60, 63, 65);
            macoA.Name = "macoA";
            macoA.Size = new Size(200, 26);
            macoA.Text = "Mark as Completed";
            macoA.Click += macoA_Click;
            // 
            // macaA
            // 
            macaA.ForeColor = Color.FromArgb(60, 63, 65);
            macaA.Name = "macaA";
            macaA.Size = new Size(200, 26);
            macaA.Text = "Mark as Canceled";
            macaA.Click += macaA_Click;
            // 
            // cmsTasks
            // 
            cmsTasks.Font = new Font("ISOCPEUR", 12F);
            cmsTasks.Items.AddRange(new ToolStripItem[] { viewTask, deleteTask, macTask });
            cmsTasks.Name = "cmsTasks";
            cmsTasks.Size = new Size(197, 82);
            // 
            // viewTask
            // 
            viewTask.ForeColor = Color.FromArgb(60, 63, 65);
            viewTask.Name = "viewTask";
            viewTask.Size = new Size(196, 26);
            viewTask.Text = "View Task";
            viewTask.Click += viewTask_Click;
            // 
            // deleteTask
            // 
            deleteTask.ForeColor = Color.FromArgb(60, 63, 65);
            deleteTask.Name = "deleteTask";
            deleteTask.Size = new Size(196, 26);
            deleteTask.Text = "Delete Task";
            deleteTask.Click += deleteTask_Click;
            // 
            // macTask
            // 
            macTask.ForeColor = Color.FromArgb(60, 63, 65);
            macTask.Name = "macTask";
            macTask.Size = new Size(196, 26);
            macTask.Text = "Mark as Completed";
            macTask.Click += macTask_Click;
            // 
            // panelView
            // 
            panelView.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelView.ColumnCount = 18;
            panelView.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.55555534F));
            panelView.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.55555534F));
            panelView.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.55555534F));
            panelView.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.55555534F));
            panelView.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.55555534F));
            panelView.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.55555534F));
            panelView.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.55555534F));
            panelView.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.55555534F));
            panelView.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.55555534F));
            panelView.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.55555534F));
            panelView.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.55555534F));
            panelView.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.55555534F));
            panelView.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.55555534F));
            panelView.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.55555534F));
            panelView.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.55555534F));
            panelView.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.55555534F));
            panelView.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.55555534F));
            panelView.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.55555534F));
            panelView.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            panelView.Controls.Add(btnDay, 6, 0);
            panelView.Controls.Add(btnWeek, 7, 0);
            panelView.Controls.Add(btnMonth, 8, 0);
            panelView.Controls.Add(btnYear, 9, 0);
            panelView.Location = new Point(281, 33);
            panelView.Name = "panelView";
            panelView.RowCount = 1;
            panelView.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            panelView.Size = new Size(1118, 35);
            panelView.TabIndex = 41;
            // 
            // btnDay
            // 
            btnDay.BackColor = Color.White;
            btnDay.Dock = DockStyle.Fill;
            btnDay.Font = new Font("ISOCPEUR", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDay.ForeColor = Color.FromArgb(60, 63, 65);
            btnDay.Location = new Point(375, 3);
            btnDay.Name = "btnDay";
            btnDay.Size = new Size(56, 29);
            btnDay.TabIndex = 33;
            btnDay.Text = "Day";
            btnDay.UseVisualStyleBackColor = false;
            btnDay.Click += btnDay_Click;
            // 
            // btnWeek
            // 
            btnWeek.BackColor = Color.White;
            btnWeek.Dock = DockStyle.Fill;
            btnWeek.Font = new Font("ISOCPEUR", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnWeek.ForeColor = Color.FromArgb(60, 63, 65);
            btnWeek.Location = new Point(437, 3);
            btnWeek.Name = "btnWeek";
            btnWeek.Size = new Size(56, 29);
            btnWeek.TabIndex = 34;
            btnWeek.Text = "Week";
            btnWeek.UseVisualStyleBackColor = false;
            btnWeek.Click += btnWeek_Click;
            // 
            // btnMonth
            // 
            btnMonth.BackColor = Color.White;
            btnMonth.Dock = DockStyle.Fill;
            btnMonth.Font = new Font("ISOCPEUR", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMonth.ForeColor = Color.FromArgb(60, 63, 65);
            btnMonth.Location = new Point(499, 3);
            btnMonth.Name = "btnMonth";
            btnMonth.Size = new Size(56, 29);
            btnMonth.TabIndex = 35;
            btnMonth.Text = "Month";
            btnMonth.UseVisualStyleBackColor = false;
            btnMonth.Click += btnMonth_Click;
            // 
            // btnYear
            // 
            btnYear.BackColor = Color.White;
            btnYear.Dock = DockStyle.Fill;
            btnYear.Font = new Font("ISOCPEUR", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnYear.ForeColor = Color.FromArgb(60, 63, 65);
            btnYear.Location = new Point(561, 3);
            btnYear.Name = "btnYear";
            btnYear.Size = new Size(56, 29);
            btnYear.TabIndex = 36;
            btnYear.Text = "Year";
            btnYear.UseVisualStyleBackColor = false;
            btnYear.Click += btnYear_Click;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.White;
            btnNext.Image = (Image)resources.GetObject("btnNext.Image");
            btnNext.Location = new Point(383, 36);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(34, 29);
            btnNext.TabIndex = 44;
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // btnToday
            // 
            btnToday.BackColor = Color.White;
            btnToday.Font = new Font("ISOCPEUR", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnToday.ForeColor = Color.FromArgb(60, 63, 65);
            btnToday.Location = new Point(322, 36);
            btnToday.Name = "btnToday";
            btnToday.Size = new Size(56, 29);
            btnToday.TabIndex = 43;
            btnToday.Text = "Today";
            btnToday.UseVisualStyleBackColor = false;
            btnToday.Click += btnToday_Click;
            // 
            // btnPrev
            // 
            btnPrev.BackColor = Color.White;
            btnPrev.Image = (Image)resources.GetObject("btnPrev.Image");
            btnPrev.Location = new Point(283, 36);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(34, 29);
            btnPrev.TabIndex = 42;
            btnPrev.UseVisualStyleBackColor = false;
            btnPrev.Click += btnPrev_Click;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.BackColor = Color.White;
            btnSearch.Font = new Font("ISOCPEUR", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(1102, 36);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(293, 29);
            btnSearch.TabIndex = 45;
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // pcbxSearch
            // 
            pcbxSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pcbxSearch.BackColor = Color.White;
            pcbxSearch.BackgroundImageLayout = ImageLayout.Zoom;
            pcbxSearch.Image = (Image)resources.GetObject("pcbxSearch.Image");
            pcbxSearch.Location = new Point(1109, 40);
            pcbxSearch.Name = "pcbxSearch";
            pcbxSearch.Size = new Size(21, 21);
            pcbxSearch.TabIndex = 46;
            pcbxSearch.TabStop = false;
            // 
            // tbxSearch
            // 
            tbxSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbxSearch.BackColor = Color.White;
            tbxSearch.BorderStyle = BorderStyle.None;
            tbxSearch.Font = new Font("ISOCPEUR", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxSearch.ForeColor = Color.FromArgb(60, 63, 65);
            tbxSearch.Location = new Point(1136, 40);
            tbxSearch.Multiline = true;
            tbxSearch.Name = "tbxSearch";
            tbxSearch.Size = new Size(251, 21);
            tbxSearch.TabIndex = 47;
            tbxSearch.Text = "Search";
            tbxSearch.Enter += tbxSearch_Enter;
            tbxSearch.Leave += tbxSearch_Leave;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Bahnschrift", 25F, FontStyle.Bold);
            lblDate.ForeColor = Color.FromArgb(60, 63, 65);
            lblDate.Location = new Point(281, 71);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(155, 41);
            lblDate.TabIndex = 48;
            lblDate.Text = "Calendar";
            // 
            // tableDays
            // 
            tableDays.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableDays.ColumnCount = 7;
            tableDays.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableDays.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableDays.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableDays.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableDays.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableDays.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableDays.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableDays.Controls.Add(lblSun, 6, 0);
            tableDays.Controls.Add(lblMon, 0, 0);
            tableDays.Controls.Add(lblSat, 5, 0);
            tableDays.Controls.Add(lblTue, 1, 0);
            tableDays.Controls.Add(lblFri, 4, 0);
            tableDays.Controls.Add(lblThu, 3, 0);
            tableDays.Controls.Add(lblWed, 2, 0);
            tableDays.Location = new Point(281, 115);
            tableDays.Name = "tableDays";
            tableDays.RowCount = 1;
            tableDays.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableDays.Size = new Size(1118, 29);
            tableDays.TabIndex = 50;
            // 
            // lblSun
            // 
            lblSun.AutoSize = true;
            lblSun.Dock = DockStyle.Fill;
            lblSun.Font = new Font("Bahnschrift Light", 11F);
            lblSun.ForeColor = Color.FromArgb(60, 63, 65);
            lblSun.Location = new Point(957, 0);
            lblSun.Name = "lblSun";
            lblSun.Size = new Size(158, 29);
            lblSun.TabIndex = 57;
            lblSun.Text = "SUN";
            lblSun.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblMon
            // 
            lblMon.AutoSize = true;
            lblMon.Dock = DockStyle.Fill;
            lblMon.Font = new Font("Bahnschrift Light", 11F);
            lblMon.ForeColor = Color.FromArgb(60, 63, 65);
            lblMon.Location = new Point(3, 0);
            lblMon.Name = "lblMon";
            lblMon.Size = new Size(153, 29);
            lblMon.TabIndex = 51;
            lblMon.Text = "MON";
            lblMon.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblSat
            // 
            lblSat.AutoSize = true;
            lblSat.Dock = DockStyle.Fill;
            lblSat.Font = new Font("Bahnschrift Light", 11F);
            lblSat.ForeColor = Color.FromArgb(60, 63, 65);
            lblSat.Location = new Point(798, 0);
            lblSat.Name = "lblSat";
            lblSat.Size = new Size(153, 29);
            lblSat.TabIndex = 56;
            lblSat.Text = "SAT";
            lblSat.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTue
            // 
            lblTue.AutoSize = true;
            lblTue.Dock = DockStyle.Fill;
            lblTue.Font = new Font("Bahnschrift Light", 11F);
            lblTue.ForeColor = Color.FromArgb(60, 63, 65);
            lblTue.Location = new Point(162, 0);
            lblTue.Name = "lblTue";
            lblTue.Size = new Size(153, 29);
            lblTue.TabIndex = 52;
            lblTue.Text = "TUE";
            lblTue.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblFri
            // 
            lblFri.AutoSize = true;
            lblFri.Dock = DockStyle.Fill;
            lblFri.Font = new Font("Bahnschrift Light", 11F);
            lblFri.ForeColor = Color.FromArgb(60, 63, 65);
            lblFri.Location = new Point(639, 0);
            lblFri.Name = "lblFri";
            lblFri.Size = new Size(153, 29);
            lblFri.TabIndex = 54;
            lblFri.Text = "FRI";
            lblFri.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblThu
            // 
            lblThu.AutoSize = true;
            lblThu.Dock = DockStyle.Fill;
            lblThu.Font = new Font("Bahnschrift Light", 11F);
            lblThu.ForeColor = Color.FromArgb(60, 63, 65);
            lblThu.Location = new Point(480, 0);
            lblThu.Name = "lblThu";
            lblThu.Size = new Size(153, 29);
            lblThu.TabIndex = 55;
            lblThu.Text = "THU";
            lblThu.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblWed
            // 
            lblWed.AutoSize = true;
            lblWed.Dock = DockStyle.Fill;
            lblWed.Font = new Font("Bahnschrift Light", 11F);
            lblWed.ForeColor = Color.FromArgb(60, 63, 65);
            lblWed.Location = new Point(321, 0);
            lblWed.Name = "lblWed";
            lblWed.Size = new Size(153, 29);
            lblWed.TabIndex = 53;
            lblWed.Text = "WED";
            lblWed.TextAlign = ContentAlignment.MiddleRight;
            // 
            // flpCalendar
            // 
            flpCalendar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flpCalendar.Location = new Point(0, 0);
            flpCalendar.Name = "flpCalendar";
            flpCalendar.Size = new Size(1118, 584);
            flpCalendar.TabIndex = 49;
            // 
            // panelCalendar
            // 
            panelCalendar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelCalendar.Controls.Add(flpCalendar);
            panelCalendar.Location = new Point(281, 147);
            panelCalendar.Name = "panelCalendar";
            panelCalendar.Size = new Size(1118, 584);
            panelCalendar.TabIndex = 51;
            // 
            // Calendar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1404, 731);
            ControlBox = false;
            Controls.Add(panelCalendar);
            Controls.Add(tableDays);
            Controls.Add(lblDate);
            Controls.Add(tbxSearch);
            Controls.Add(pcbxSearch);
            Controls.Add(btnSearch);
            Controls.Add(btnNext);
            Controls.Add(btnToday);
            Controls.Add(btnPrev);
            Controls.Add(panelView);
            Controls.Add(panelSide);
            Controls.Add(toopStripControls);
            ForeColor = Color.FromArgb(60, 63, 65);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Calendar";
            toopStripControls.ResumeLayout(false);
            toopStripControls.PerformLayout();
            panelSide.ResumeLayout(false);
            panelE.ResumeLayout(false);
            panelE.PerformLayout();
            flpEvent.ResumeLayout(false);
            flpEvent.PerformLayout();
            toolStripE.ResumeLayout(false);
            toolStripE.PerformLayout();
            panelA.ResumeLayout(false);
            panelA.PerformLayout();
            flpAppointment.ResumeLayout(false);
            flpAppointment.PerformLayout();
            toolStripA.ResumeLayout(false);
            toolStripA.PerformLayout();
            panelT.ResumeLayout(false);
            panelT.PerformLayout();
            flpTask.ResumeLayout(false);
            flpTask.PerformLayout();
            flpTasks.ResumeLayout(false);
            toolStripT.ResumeLayout(false);
            toolStripT.PerformLayout();
            cmsEvents.ResumeLayout(false);
            cmsAppointments.ResumeLayout(false);
            cmsTasks.ResumeLayout(false);
            panelView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pcbxSearch).EndInit();
            tableDays.ResumeLayout(false);
            tableDays.PerformLayout();
            panelCalendar.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.CrownToolStrip toopStripControls;
        private ToolStripButton btnClose;
        private ToolStripButton btnMinimize;
        private ToolStripButton btnWindow;
        private Panel panelSide;
        private TableLayoutPanel panelView;
        private Button btnYear;
        private Button btnMonth;
        private Button btnWeek;
        private Button btnDay;
        private Button btnNext;
        private Button btnToday;
        private Button btnPrev;
        private Button btnSearch;
        private PictureBox pcbxSearch;
        private TextBox tbxSearch;
        private Label lblDate;
        private TableLayoutPanel tableDays;
        private Label lblMon;
        private Label lblTue;
        private Label lblWed;
        private Label lblFri;
        private Label lblThu;
        private Label lblSat;
        private Label lblSun;
        private FlowLayoutPanel flpCalendar;
        private Panel panelCalendar;
        private Panel panelT;
        private ReaLTaiizor.Controls.ParrotToolStrip toolStripT;
        private ToolStripSplitButton tsTask;
        private ToolStripMenuItem TN;
        private ToolStripMenuItem TF;
        private ToolStripMenuItem TFP;
        private ToolStripMenuItem TFC;
        private ToolStripMenuItem TS;
        private ToolStripMenuItem TSD;
        private ToolStripMenuItem TSP;
        private ToolStripMenuItem TST;
        private Panel panelA;
        private ReaLTaiizor.Controls.ParrotToolStrip toolStripA;
        private ToolStripSplitButton tsAppointment;
        private ToolStripMenuItem AN;
        private ToolStripMenuItem AF;
        private ToolStripMenuItem AFU;
        private ToolStripMenuItem AFCO;
        private ToolStripMenuItem AFCA;
        private ToolStripMenuItem AS;
        private ToolStripMenuItem ASD;
        private ToolStripMenuItem AST;
        private ToolStripMenuItem ASTT;
        private Panel panelE;
        private ReaLTaiizor.Controls.ParrotToolStrip toolStripE;
        private ToolStripSplitButton tsEvent;
        private ToolStripMenuItem EN;
        private ToolStripMenuItem EF;
        private ToolStripMenuItem EFA;
        private ToolStripMenuItem EFSO;
        private ToolStripMenuItem EFSC;
        private ToolStripMenuItem EFW;
        private ToolStripMenuItem ES;
        private ToolStripMenuItem ESD;
        private ToolStripMenuItem ESL;
        private ToolStripMenuItem ESTT;
        private FlowLayoutPanel flpTask;
        private FlowLayoutPanel flpEvent;
        private FlowLayoutPanel flpAppointment;
        private Label lblTaskHeader;
        private FlowLayoutPanel flpTasks;
        private TableLayoutPanel tableTasks;
        private Label lblAppointmentHeader;
        private TableLayoutPanel tableAppointments;
        private Label lblEventHeader;
        private TableLayoutPanel tableEvents;
        private ContextMenuStrip cmsTasks;
        private ToolStripMenuItem viewTask;
        private ToolStripMenuItem deleteTask;
        private ToolStripMenuItem macTask;
        private ContextMenuStrip cmsAppointments;
        private ToolStripMenuItem viewA;
        private ToolStripMenuItem deleteA;
        private ToolStripMenuItem macoA;
        private ToolStripMenuItem macaA;
        private ContextMenuStrip cmsEvents;
        private ToolStripMenuItem viewEvent;
        private ToolStripMenuItem deleteEvent;
        private ToolStripMenuItem TFA;
        private ToolStripMenuItem AFA;
    }
}
