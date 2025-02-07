namespace Calendar
{
    partial class MonthCalendar
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
            tableCalendar = new TableLayoutPanel();
            SuspendLayout();
            // 
            // tableCalendar
            // 
            tableCalendar.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableCalendar.ColumnCount = 7;
            tableCalendar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableCalendar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableCalendar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableCalendar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableCalendar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableCalendar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableCalendar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableCalendar.Dock = DockStyle.Fill;
            tableCalendar.Location = new Point(3, 3);
            tableCalendar.Name = "tableCalendar";
            tableCalendar.Padding = new Padding(3);
            tableCalendar.RowCount = 6;
            tableCalendar.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableCalendar.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableCalendar.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableCalendar.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableCalendar.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableCalendar.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableCalendar.Size = new Size(1112, 578);
            tableCalendar.TabIndex = 0;
            // 
            // MonthCalendar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableCalendar);
            Name = "MonthCalendar";
            Padding = new Padding(3);
            Size = new Size(1118, 584);
            Load += MonthCalendar_Load;
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableCalendar;
    }
}
