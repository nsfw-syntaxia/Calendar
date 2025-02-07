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
    public partial class MonthCalendar : UserControl
    {
        public event Action<DateTime> daySlot;
        private DateTime currentDate = DateTime.Now;

        public MonthCalendar(DateTime currentDate)
        {
            InitializeComponent();
            MonthCalendarView(currentDate);
        }

        private void MonthCalendar_Load(object sender, EventArgs e)
        {

        }

        private void MonthCalendarView(DateTime currentDate)
        {
            tableCalendar.Controls.Clear();

            DateTime firstDayOfMonth = new DateTime(currentDate.Year, currentDate.Month, 1);

            int startDay = (int)firstDayOfMonth.DayOfWeek;
            startDay = (startDay == 0) ? 6 : startDay - 1;

            DateTime firstVisibleDay = firstDayOfMonth.AddDays(-startDay);

            tableCalendar.Controls.Clear();

            for (int i = 0; i < 42; i++)
            {
                DateTime dayDate = firstVisibleDay.AddDays(i);

                Panel dayPanel = new Panel
                {
                    BorderStyle = BorderStyle.FixedSingle,
                    Dock = DockStyle.Fill,
                    BackColor = (dayDate.Month == currentDate.Month) ? Color.White : Color.LightGray
                };

                Label dayLabel = new Label
                {
                    Text = dayDate.Day.ToString(),
                    Dock = DockStyle.Top,
                    TextAlign = ContentAlignment.MiddleRight,
                    Font = new Font("Bahnschrift SemiLight", 12, FontStyle.Regular),
                    ForeColor = (dayDate.Month == currentDate.Month) ? ColorTranslator.FromHtml("#3C3F41") : Color.Gray
                };

                if (dayDate.Date == DateTime.Today)
                {
                    dayPanel.BackColor = Color.IndianRed;
                    dayLabel.Font = new Font("Bahnschrift SemiLight", 12, FontStyle.Regular);
                    dayLabel.ForeColor = Color.White;
                }

                dayPanel.Click += (sender, e) =>
                {
                    daySlot?.Invoke(dayDate);

                    UserInput userInput = new UserInput(dayDate, -1);
                    userInput.ShowDialog();
                };

                dayPanel.Controls.Add(dayLabel);
                tableCalendar.Controls.Add(dayPanel);
            }
        }
    }
}
