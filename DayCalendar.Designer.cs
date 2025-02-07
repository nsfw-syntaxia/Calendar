namespace Calendar
{
    partial class DayCalendar
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
            tableDay = new TableLayoutPanel();
            SuspendLayout();
            // 
            // tableDay
            // 
            tableDay.AutoScroll = true;
            tableDay.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableDay.ColumnCount = 2;
            tableDay.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableDay.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85F));
            tableDay.Dock = DockStyle.Fill;
            tableDay.Location = new Point(0, 0);
            tableDay.Name = "tableDay";
            tableDay.Padding = new Padding(3);
            tableDay.RowCount = 24;
            tableDay.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableDay.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableDay.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableDay.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableDay.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableDay.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableDay.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableDay.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableDay.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableDay.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableDay.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableDay.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableDay.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableDay.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableDay.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableDay.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableDay.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableDay.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableDay.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableDay.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableDay.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableDay.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableDay.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableDay.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableDay.Size = new Size(1118, 584);
            tableDay.TabIndex = 1;
            // 
            // DayCalendar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableDay);
            Name = "DayCalendar";
            Size = new Size(1118, 584);
            Load += DayCalendar_Load;
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableDay;
    }
}
