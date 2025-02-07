using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
    public partial class WeekCalendar : UserControl
    {
        public event Action<DateTime> daySlot;
        private DateTime currentDate = DateTime.Now;

        public WeekCalendar(DateTime currentDate)
        {
            InitializeComponent();
            WeekCalendarView(currentDate);
        }

        private void WeekCalendar_Load(object sender, EventArgs e)
        {

        }

        private void WeekCalendarView(DateTime currentDate)
        {
            tableWeek.Controls.Clear();

            tableWeek.ColumnCount = 8;
            tableWeek.RowCount = 25;

            tableWeek.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60));
            for (int i = 0; i < 7; i++)
                tableWeek.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.28f));

            for (int i = 0; i < 25; i++)
                tableWeek.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));

            for (int i = 0; i < 7; i++)
            {
                DateTime dayDate = currentDate.AddDays(i - (int)currentDate.DayOfWeek + (int)DayOfWeek.Monday);

                Label dayLabel = new Label
                {
                    Text = dayDate.ToString("d MMM"),
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Bahnschrift SemiLight", 12),
                    ForeColor = ColorTranslator.FromHtml("#3C3F41")
                };

                tableWeek.Controls.Add(dayLabel, i + 1, 0);
            }

            for (int hour = 0; hour < 24; hour++)
            {
                Label hourLabel = new Label
                {
                    Text = $"{hour:00}:00",
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Bahnschrift SemiLight", 12),
                    ForeColor = ColorTranslator.FromHtml("#3C3F41")
                };
                tableWeek.Controls.Add(hourLabel, 0, hour + 1);

                for (int i = 0; i < 7; i++)
                {
                    DateTime baseDate = currentDate.Date;
                    DateTime timeDate = baseDate.AddDays(i - (int)baseDate.DayOfWeek + (int)DayOfWeek.Monday).AddHours(hour);
                    Panel dayPanel = new Panel
                    {
                        BorderStyle = BorderStyle.FixedSingle,
                        Dock = DockStyle.Fill,
                        BackColor = Color.White
                    };

                    if (timeDate.Date == DateTime.Today && timeDate.Hour == DateTime.Now.Hour)
                    {
                        dayPanel.BackColor = Color.LightSkyBlue;
                    }

                    dayPanel.Click += (sender, e) =>
                    {
                        daySlot?.Invoke(timeDate);

                        UserInput userInput = new UserInput(timeDate, -1);
                        userInput.ShowDialog();
                    };

                    tableWeek.Controls.Add(dayPanel, i + 1, hour + 1);
                }
            }
        }
    }
}
