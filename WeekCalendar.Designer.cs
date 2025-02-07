namespace Calendar
{
    partial class WeekCalendar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableWeek = new TableLayoutPanel();
            SuspendLayout();
            // 
            // tableWeek
            // 
            tableWeek.AutoScroll = true;
            tableWeek.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableWeek.ColumnCount = 8;
            tableWeek.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableWeek.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableWeek.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableWeek.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableWeek.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableWeek.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableWeek.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableWeek.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableWeek.Dock = DockStyle.Fill;
            tableWeek.Location = new Point(0, 0);
            tableWeek.Name = "tableWeek";
            tableWeek.Padding = new Padding(3);
            tableWeek.RowCount = 25;
            tableWeek.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableWeek.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableWeek.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableWeek.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableWeek.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableWeek.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableWeek.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableWeek.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableWeek.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableWeek.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableWeek.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableWeek.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableWeek.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableWeek.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableWeek.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableWeek.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableWeek.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableWeek.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableWeek.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableWeek.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableWeek.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableWeek.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableWeek.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableWeek.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableWeek.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableWeek.Size = new Size(1101, 567);
            tableWeek.TabIndex = 0;
            // 
            // WeekCalendarControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(tableWeek);
            Name = "WeekCalendarControl";
            Size = new Size(1101, 567);
            Load += WeekCalendar_Load;
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableWeek;
    }
}
