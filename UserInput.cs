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
    public partial class UserInput : Form
    {
        private DateTime selectedDateTime;

        public static List<Task> tasks = new List<Task>();
        public static List<Appointment> appointments = new List<Appointment>();
        public static List<Event> events = new List<Event>();

        private string baseDirectory;
        private string folderPath;
        private string filePath;

        public UserInput(DateTime dateTime, int selectedTypeIndex)
        {
            InitializeComponent();
            hideControls();
            selectedDateTime = dateTime;

            cmbxType.SelectedIndex = selectedTypeIndex;
            cmbxType_SelectedIndexChanged(this, EventArgs.Empty);
        }

        private void UserInput_Load(object sender, EventArgs e)
        {
            cmbxType_SelectedIndexChanged(this, EventArgs.Empty);

            dtTaskDate.Value = selectedDateTime;
            tbxTaskTime.Text = selectedDateTime.ToString("HH:mm");

            dtADate.Value = selectedDateTime;
            tbxAStart.Text = selectedDateTime.ToString("HH:mm");

            dtEDate.Value = selectedDateTime;
            tbxEStart.Text = selectedDateTime.ToString("HH:mm");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnWindow_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
        }

        private void cmbxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            hideControls();

            if (cmbxType.SelectedItem == null) return;

            if (cmbxType.SelectedItem.ToString() == "Task")
            {
                showTask();
            }
            else if (cmbxType.SelectedItem.ToString() == "Appointment")
            {
                showAppointment();
            }
            else if (cmbxType.SelectedItem.ToString() == "Event")
            {
                showEvent();
            }
        }

        private void hideControls()
        {
            lblTitle.Visible = false;
            tbxTitle.Visible = false;
            btnSaveT.Visible = false;
            btnSaveA.Visible = false;
            btnSaveE.Visible = false;

            lblTaskDT.Visible = false;
            dtTaskDate.Visible = false;
            lblTaskTime.Visible = false;
            tbxTaskTime.Visible = false;
            lblTaskPriority.Visible = false;
            rbtnLow.Visible = false;
            rbtnMedium.Visible = false;
            rbtnHigh.Visible = false;

            lblADate.Visible = false;
            dtADate.Visible = false;
            lblADuration.Visible = false;
            nADuration.Visible = false;
            lblAStart.Visible = false;
            tbxAStart.Visible = false;
            lblAEnd.Visible = false;
            tbxAEnd.Visible = false;

            lblLocation.Visible = false;
            tbxLocation.Visible = false;
            lblEDate.Visible = false;
            dtEDate.Visible = false;
            lblEDuration.Visible = false;
            nEDuration.Visible = false;
            lblEStart.Visible = false;
            tbxEStart.Visible = false;
            lblEEnd.Visible = false;
            tbxEEnd.Visible = false;
            lblEPurpose.Visible = false;
            cmbxEPurpose.Visible = false;

            rbtnLow.Checked = false;
            rbtnMedium.Checked = false;
            rbtnHigh.Checked = false;

            nADuration.Value = 0;
            tbxLocation.Text = string.Empty;
            tbxEEnd.Text = string.Empty;
            nEDuration.Value = 0;
        }

        private void showTask()
        {
            lblTitle.Visible = true;
            tbxTitle.Visible = true;
            lblTaskDT.Visible = true;
            dtTaskDate.Visible = true;
            lblTaskTime.Visible = true;
            tbxTaskTime.Visible = true;
            lblTaskPriority.Visible = true;
            rbtnLow.Visible = true;
            rbtnMedium.Visible = true;
            rbtnHigh.Visible = true;
            btnSaveT.Visible = true;
        }

        private void showAppointment()
        {
            lblTitle.Visible = true;
            tbxTitle.Visible = true;
            lblADate.Visible = true;
            dtADate.Visible = true;
            lblADuration.Visible = true;
            nADuration.Visible = true;
            lblAStart.Visible = true;
            tbxAStart.Visible = true;
            lblAEnd.Visible = true;
            tbxAEnd.Visible = true;
            btnSaveA.Visible = true;
        }

        private void showEvent()
        {
            lblTitle.Visible = true;
            tbxTitle.Visible = true;
            lblLocation.Visible = true;
            tbxLocation.Visible = true;
            lblEDate.Visible = true;
            dtEDate.Visible = true;
            lblEDuration.Visible = true;
            nEDuration.Visible = true;
            lblEStart.Visible = true;
            tbxEStart.Visible = true;
            lblEEnd.Visible = true;
            tbxEEnd.Visible = true;
            lblEPurpose.Visible = true;
            cmbxEPurpose.Visible = true;
            btnSaveE.Visible = true;
        }

        private void btnSaveT_Click(object sender, EventArgs e)
        {
            baseDirectory = AppContext.BaseDirectory;
            folderPath = Path.Combine(baseDirectory, "User_Inputs");
            filePath = Path.Combine(folderPath, "Tasks.txt");

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
            }

            List<string> errors = new List<string>();

            if (string.IsNullOrWhiteSpace(tbxTitle.Text))
            {
                errors.Add("Task title is required.");
            }

            DateTime dueTime;
            string dueTimeText = tbxTaskTime.Text;
            if (!DateTime.TryParseExact(dueTimeText, "HH:mm", null, System.Globalization.DateTimeStyles.None, out dueTime))
            {
                errors.Add("Invalid time format.");
            }

            string priority = rbtnLow.Checked ? "Low" : rbtnMedium.Checked ? "Medium" : rbtnHigh.Checked ? "High" : string.Empty;
            if (string.IsNullOrEmpty(priority))
            {
                errors.Add("Priority is required.");
            }

            if (errors.Any())
            {
                MessageBox.Show(string.Join("\n", errors), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            TimeSpan taskTime = dueTime.TimeOfDay;

            Task newTask = new Task
            {
                Title = tbxTitle.Text,
                Date = dtTaskDate.Value.Date,
                Time = taskTime,
                Priority = priority
            };
            tasks.Add(newTask);

            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine($"Task,{tbxTitle.Text},{dtTaskDate.Value:MM-dd-yyyy},{tbxTaskTime.Text},{priority},Pending");
            }

            MessageBox.Show("Task saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnSaveA_Click(object sender, EventArgs e)
        {
            baseDirectory = AppContext.BaseDirectory;
            folderPath = Path.Combine(baseDirectory, "User_Inputs");
            filePath = Path.Combine(folderPath, "Appointments.txt");

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
            }

            List<string> errors = new List<string>();

            if (string.IsNullOrWhiteSpace(tbxTitle.Text))
            {
                errors.Add("Appointment title is required.");
            }

            DateTime startTime;
            string startTimeText = tbxAStart.Text;
            if (!DateTime.TryParseExact(startTimeText, "HH:mm", null, System.Globalization.DateTimeStyles.None, out startTime))
            {
                errors.Add("Invalid start time format.");
            }

            DateTime endTime = DateTime.MinValue;
            string endTimeText = tbxAEnd.Text;
            if (string.IsNullOrWhiteSpace(endTimeText))
            {
                errors.Add("End time is required.");
            }
            else if (!DateTime.TryParseExact(endTimeText, "HH:mm", null, System.Globalization.DateTimeStyles.None, out endTime))
            {
                errors.Add("Invalid end time format.");
            }

            if (endTime != DateTime.MinValue && endTime <= startTime)
            {
                errors.Add("End time must be later than the start time.");
            }

            if (nADuration.Value <= 0)
            {
                errors.Add("Duration must be greater than 0.");
            }

            if (errors.Any())
            {
                MessageBox.Show(string.Join("\n", errors), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            TimeSpan startTimeSpan = startTime.TimeOfDay;
            TimeSpan endTimeSpan = endTime.TimeOfDay;

            Appointment newAppointment = new Appointment
            {
                Title = tbxTitle.Text,
                Date = dtADate.Value.Date,
                StartTime = startTimeSpan,
                EndTime = endTimeSpan
            };
            appointments.Add(newAppointment);

            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine($"Appointment,{tbxTitle.Text},{dtADate.Value:MM-dd-yyyy},{tbxAStart.Text},{tbxAEnd.Text},{nADuration.Value},Upcoming");
            }

            MessageBox.Show("Appointment saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnSaveE_Click(object sender, EventArgs e)
        {
            baseDirectory = AppContext.BaseDirectory;
            folderPath = Path.Combine(baseDirectory, "User_Inputs");
            filePath = Path.Combine(folderPath, "Events.txt");

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
            }

            List<string> errors = new List<string>();

            if (string.IsNullOrWhiteSpace(tbxTitle.Text))
            {
                errors.Add("Event title is required.");
            }

            if (string.IsNullOrWhiteSpace(tbxLocation.Text))
            {
                errors.Add("Location is required.");
            }

            DateTime startTime;

            string startTimeText = tbxEStart.Text;
            if (!DateTime.TryParseExact(startTimeText, "HH:mm", null, System.Globalization.DateTimeStyles.None, out startTime))
            {
                errors.Add("Invalid start time format.");
            }

            DateTime endTime = DateTime.MinValue;
            string endTimeText = tbxEEnd.Text;
            if (string.IsNullOrWhiteSpace(endTimeText))
            {
                errors.Add("End time is required.");
            }
            else if (!DateTime.TryParseExact(endTimeText, "HH:mm", null, System.Globalization.DateTimeStyles.None, out endTime))
            {
                errors.Add("Invalid end time format.");
            }

            if (endTime != DateTime.MinValue && endTime <= startTime)
            {
                errors.Add("End time must be later than the start time.");
            }

            if (nEDuration.Value <= 0)
            {
                errors.Add("Duration must be greater than 0.");
            }

            string purpose = cmbxEPurpose.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(purpose))
            {
                errors.Add("Purpose is required.");
            }

            if (errors.Any())
            {
                MessageBox.Show(string.Join("\n", errors), "Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            TimeSpan startTimeSpan = startTime.TimeOfDay;
            TimeSpan endTimeSpan = endTime.TimeOfDay;

            Event newEvent = new Event
            {
                Title = tbxTitle.Text,
                Location = tbxLocation.Text,
                Date = dtEDate.Value.Date,
                StartTime = startTimeSpan,
                EndTime = endTimeSpan,
                Purpose = cmbxEPurpose.SelectedItem?.ToString() ?? "Personal"
            };
            events.Add(newEvent);

            double durationHours = nEDuration.Value / 60.0;

            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine($"Event,{tbxTitle.Text},{dtEDate.Value:MM-dd-yyyy},{tbxEStart.Text},{tbxEEnd.Text},{nEDuration.Value},{tbxLocation.Text},{purpose}");
            }

            MessageBox.Show("Event saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }

    public class Task
    {
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public string Priority { get; set; }
    }

    public class Appointment
    {
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
    }

    public class Event
    {
        public string Title { get; set; }
        public string Location { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public string Purpose { get; set; }
    }
}
