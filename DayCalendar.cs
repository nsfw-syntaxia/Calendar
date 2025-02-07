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
    public partial class DayCalendar : UserControl
    {
        public event Action<DateTime> timeSlot;
        private DateTime currentDate = DateTime.Now;

        public DayCalendar(DateTime currentDate)
        {
            InitializeComponent();
            DayCalendarView(currentDate);
        }

        private void DayCalendar_Load(object sender, EventArgs e)
        {

        }

        private void DayCalendarView(DateTime currentDate)
        {
            tableDay.Controls.Clear();

            tableDay.ColumnCount = 2;
            tableDay.RowCount = 24;

            for (int i = 0; i < 24; i++)
            {
                tableDay.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));

                DateTime timeDate = currentDate.Date.AddHours(i);

                Label timeLabel = new Label
                {
                    Text = $"{i:D2}:00",
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Bahnschrift SemiLight", 12, FontStyle.Regular),
                    ForeColor = ColorTranslator.FromHtml("#3C3F41")
                };

                Panel timeSlotPanel = new Panel
                {
                    BorderStyle = BorderStyle.FixedSingle,
                    Dock = DockStyle.Fill,
                    BackColor = Color.White
                };

                if (timeDate.Date == DateTime.Today && i == DateTime.Now.Hour)
                {
                    timeSlotPanel.BackColor = Color.LightSkyBlue;
                }

                timeSlotPanel.Click += (sender, e) =>
                {
                    timeSlot?.Invoke(timeDate);

                    UserInput userInput = new UserInput(timeDate, -1);
                    userInput.ShowDialog();
                };

                tableDay.Controls.Add(timeLabel, 0, i);
                tableDay.Controls.Add(timeSlotPanel, 1, i);
            }
        }
    }
}
