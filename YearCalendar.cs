using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
    public partial class YearCalendar : UserControl
    {
        public event Action<DateTime> monthSlot;
        private DateTime currentDate = DateTime.Now;

        public YearCalendar(DateTime currentDate)
        {
            InitializeComponent();
            YearCalendarView(currentDate);
        }

        private void YearCalendar_Load(object sender, EventArgs e)
        {

        }

        private void YearCalendarView(DateTime currentDate)
        {
            tableYear.Controls.Clear();

            tableYear.ColumnCount = 4;
            tableYear.RowCount = 3;

            for (int i = 0; i < 4; i++)
                tableYear.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25f));

            for (int i = 0; i < 3; i++)
                tableYear.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33f));

            for (int month = 1; month <= 12; month++)
            {
                DateTime firstDayOfMonth = new DateTime(currentDate.Year, month, 1);
                int startDay = (int)firstDayOfMonth.DayOfWeek;
                startDay = (startDay == 0) ? 6 : startDay - 1;
                int daysInMonth = DateTime.DaysInMonth(currentDate.Year, month);

                Panel monthPanel = new Panel
                {
                    BorderStyle = BorderStyle.FixedSingle,
                    Dock = DockStyle.Fill,
                    BackColor = Color.White
                };

                Label monthLabel = new Label
                {
                    Text = firstDayOfMonth.ToString("MMMM"),
                    Dock = DockStyle.Top,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Bahnschrift SemiLight", 12, FontStyle.Bold),
                    ForeColor = ColorTranslator.FromHtml("#3C3F41")
                };

                monthPanel.Controls.Add(monthLabel);

                TableLayoutPanel monthDaysTable = new TableLayoutPanel
                {
                    ColumnCount = 7,
                    RowCount = 8,
                    Dock = DockStyle.Fill,
                    AutoSize = true
                };

                for (int i = 0; i < 7; i++)
                    monthDaysTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.28f));

                for (int i = 0; i < 8; i++)
                    monthDaysTable.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5f));

                string[] dayNames = { "M", "T", "W", "T", "F", "S", "S" };
                for (int i = 0; i < 7; i++)
                {
                    monthDaysTable.Controls.Add(new Label
                    {
                        Text = dayNames[i],
                        Dock = DockStyle.Fill,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Font = new Font("Bahnschrift SemiLight", 12),
                        ForeColor = ColorTranslator.FromHtml("#3C3F41")
                    }, i, 1);
                }

                int day = 1;
                for (int row = 2; row < 8 && day <= daysInMonth; row++)
                {
                    for (int col = 0; col < 7; col++)
                    {
                        if ((row == 2 && col >= startDay) || (row > 2 && day <= daysInMonth))
                        {
                            Label dayLabel = new Label
                            {
                                Text = day.ToString(),
                                Dock = DockStyle.Fill,
                                TextAlign = ContentAlignment.MiddleCenter,
                                Font = new Font("Bahnschrift SemiLight", 12),
                                ForeColor = ColorTranslator.FromHtml("#3C3F41")
                            };

                            if (day == currentDate.Day && currentDate.Month == month && currentDate.Year == DateTime.Now.Year)
                            {
                                dayLabel.BackColor = Color.IndianRed;
                                dayLabel.ForeColor = Color.White;
                            }

                            monthDaysTable.Controls.Add(dayLabel, col, row);
                            day++;
                        }
                    }
                }

                monthPanel.Controls.Add(monthDaysTable);
                tableYear.Controls.Add(monthPanel, (month - 1) % 4, (month - 1) / 4);
            }
        }
    }
}
