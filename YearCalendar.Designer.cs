namespace Calendar
{
    partial class YearCalendar
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
            tableYear = new TableLayoutPanel();
            SuspendLayout();
            // 
            // tableYear
            // 
            tableYear.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableYear.ColumnCount = 4;
            tableYear.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableYear.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableYear.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableYear.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableYear.Dock = DockStyle.Fill;
            tableYear.Location = new Point(0, 0);
            tableYear.Name = "tableYear";
            tableYear.Padding = new Padding(3);
            tableYear.RowCount = 3;
            tableYear.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableYear.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableYear.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableYear.Size = new Size(1112, 578);
            tableYear.TabIndex = 0;
            // 
            // YearCalendar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableYear);
            Name = "YearCalendar";
            Size = new Size(1112, 578);
            Load += YearCalendar_Load;
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableYear;
    }
}
