using System;
using System.Windows.Forms;

namespace Calendar
{
    public partial class Calendar : Form
    {
        private string baseDirectory;
        private string filePath;

        private bool tasksLoaded = false;
        private bool appointmentsLoaded = false;
        private bool eventsLoaded = false;

        public enum CalendarView
        {
            Day,
            Week,
            Month,
            Year
        }

        private DateTime currentDate = DateTime.Now;
        private CalendarView currentView = CalendarView.Month;

        private DayCalendar dayCalendar;
        private WeekCalendar weekCalendar;
        private MonthCalendar monthCalendar;
        private YearCalendar yearCalendar;

        private string taskFilter = "pending";
        private string appointmentFilter = "upcoming";
        private string eventFilter = "all";

        public Calendar()
        {
            InitializeComponent();
            updateMonth();

            loadTasks(taskFilter);
            loadAppointments(appointmentFilter);
            loadEvents(eventFilter);
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

        private void tbxSearch_Enter(object sender, EventArgs e)
        {
            if (tbxSearch.Text == "Search")
            {
                tbxSearch.Text = "";
            }
        }

        private void tbxSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxSearch.Text))
            {
                tbxSearch.Text = "Search";
            }
        }

        private void btnDay_Click(object sender, EventArgs e)
        {
            if (currentView != CalendarView.Day || currentDate != DateTime.Today)
                currentDate = DateTime.Today;

            flpCalendar.AutoScroll = true;
            lblMon.Visible = false;
            lblTue.Visible = false;
            lblWed.Visible = false;
            lblThu.Visible = false;
            lblFri.Visible = false;
            lblSat.Visible = false;
            lblSun.Visible = false;

            currentView = CalendarView.Day;
            updateDay();
        }

        private void btnWeek_Click(object sender, EventArgs e)
        {
            if (currentView != CalendarView.Week || currentDate != DateTime.Today)
                currentDate = DateTime.Today;

            flpCalendar.AutoScroll = true;
            lblMon.Visible = true;
            lblTue.Visible = true;
            lblWed.Visible = true;
            lblThu.Visible = true;
            lblFri.Visible = true;
            lblSat.Visible = true;
            lblSun.Visible = true;

            currentView = CalendarView.Week;
            updateWeek();
        }

        private void btnMonth_Click(object sender, EventArgs e)
        {
            if (currentView != CalendarView.Month || currentDate.Month != DateTime.Today.Month || currentDate.Year != DateTime.Today.Year)
                currentDate = DateTime.Today;

            flpCalendar.AutoScroll = false;
            lblMon.Visible = true;
            lblTue.Visible = true;
            lblWed.Visible = true;
            lblThu.Visible = true;
            lblFri.Visible = true;
            lblSat.Visible = true;
            lblSun.Visible = true;

            currentView = CalendarView.Month;
            updateMonth();
        }

        private void btnYear_Click(object sender, EventArgs e)
        {
            if (currentView != CalendarView.Year || currentDate.Year != DateTime.Today.Year)
                currentDate = DateTime.Today;

            flpCalendar.AutoScroll = false;
            lblMon.Visible = false;
            lblTue.Visible = false;
            lblWed.Visible = false;
            lblThu.Visible = false;
            lblFri.Visible = false;
            lblSat.Visible = false;
            lblSun.Visible = false;

            currentView = CalendarView.Year;
            updateYear();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (currentView == CalendarView.Day)
            {
                currentDate = currentDate.AddDays(-1);
                updateDay();
            }
            else if (currentView == CalendarView.Week)
            {
                currentDate = currentDate.AddDays(-7);
                updateWeek();
            }
            else if (currentView == CalendarView.Month)
            {
                currentDate = currentDate.AddMonths(-1);
                updateMonth();
            }
            else if (currentView == CalendarView.Year)
            {
                currentDate = currentDate.AddYears(-1);
                updateYear();
            }
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            if (currentView == CalendarView.Day)
            {
                currentDate = DateTime.Now;
                updateDay();
            }
            else if (currentView == CalendarView.Week)
            {
                currentDate = DateTime.Now;
                updateWeek();
            }
            else if (currentView == CalendarView.Month && currentDate.Month != DateTime.Now.Month)
            {
                currentDate = DateTime.Now;
                updateMonth();
            }
            else if (currentView == CalendarView.Year)
            {
                currentDate = DateTime.Now;
                updateYear();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentView == CalendarView.Day)
            {
                currentDate = currentDate.AddDays(1);
                updateDay();
            }
            else if (currentView == CalendarView.Week)
            {
                currentDate = currentDate.AddDays(7);
                updateWeek();
            }
            else if (currentView == CalendarView.Month)
            {
                currentDate = currentDate.AddMonths(1);
                updateMonth();
            }
            else if (currentView == CalendarView.Year)
            {
                currentDate = currentDate.AddYears(1);
                updateYear();
            }
        }

        private void updateDate(DateTime date)
        {
            switch (currentView)
            {
                case CalendarView.Day:
                    lblDate.Text = date.ToString("dddd, d MMMM yyyy");
                    break;

                case CalendarView.Week:
                    DateTime weekStart = date.AddDays(-(int)date.DayOfWeek + (int)DayOfWeek.Monday);
                    DateTime weekEnd = weekStart.AddDays(6);
                    lblDate.Text = $"{weekStart:MMM d} - {weekEnd:MMM d, yyyy}";
                    break;

                case CalendarView.Month:
                    lblDate.Text = date.ToString("MMMM yyyy");
                    break;

                case CalendarView.Year:
                    lblDate.Text = date.ToString("yyyy");
                    break;
            }
        }

        private void updateDay()
        {
            flpCalendar.Controls.Clear();
            dayCalendar = new DayCalendar(currentDate);
            flpCalendar.Controls.Add(dayCalendar);
            updateDate(currentDate);
            tasksLoaded = false;
            loadTasks(taskFilter);
            appointmentsLoaded = false;
            loadAppointments(appointmentFilter);
            eventsLoaded = false;
            loadEvents(eventFilter);
        }

        private void updateWeek()
        {
            flpCalendar.Controls.Clear();
            weekCalendar = new WeekCalendar(currentDate);
            flpCalendar.Controls.Add(weekCalendar);
            updateDate(currentDate);
            tasksLoaded = false;
            loadTasks(taskFilter);
            appointmentsLoaded = false;
            loadAppointments(appointmentFilter);
            eventsLoaded = false;
            loadEvents(eventFilter);
        }

        private void updateMonth()
        {
            flpCalendar.Controls.Clear();
            monthCalendar = new MonthCalendar(currentDate);
            flpCalendar.Controls.Add(monthCalendar);
            updateDate(currentDate);
            tasksLoaded = false;
            loadTasks(taskFilter);
            appointmentsLoaded = false;
            loadAppointments(appointmentFilter);
            eventsLoaded = false;
            loadEvents(eventFilter);
        }

        private void updateYear()
        {
            flpCalendar.Controls.Clear();
            yearCalendar = new YearCalendar(currentDate);
            flpCalendar.Controls.Add(yearCalendar);
            updateDate(currentDate);
            tasksLoaded = false;
            loadTasks(taskFilter);
            appointmentsLoaded = false;
            loadAppointments(appointmentFilter);
            eventsLoaded = false;
            loadEvents(eventFilter);
        }

        private void loadTasks(string filterStatus)
        {
            tasksLoaded = false;

            if (tasksLoaded) return;

            baseDirectory = AppContext.BaseDirectory;
            filePath = Path.Combine(baseDirectory, "User_Inputs", "Tasks.txt");

            if (!File.Exists(filePath))
            {
                MessageBox.Show("Tasks.txt not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            tableTasks.Controls.Clear();
            tableTasks.RowCount = 1;

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length < 3) continue;

                    string title = parts[1];
                    string date = parts[2];
                    string status = parts[5];

                    if (filterStatus.ToLower() == "pending" && status.ToLower() == "pending")
                    {
                        addTask(title, date);
                    }
                    else if (filterStatus.ToLower() == "completed" && status.ToLower() == "completed")
                    {
                        addTask(title, date);
                    }
                    else if (filterStatus.ToLower() == "all")
                    {
                        addTask(title, date);
                    }
                }
            }

            tasksLoaded = true;
        }

        private void addTask(string title, string date)
        {
            int rowIndex = tableTasks.RowCount - 1;
            tableTasks.RowCount++;

            Label titleLabel = new Label
            {
                Text = title,
                AutoSize = true,
                ContextMenuStrip = cmsTasks,
                Tag = new { Title = title, Date = date }
            };

            Label dateLabel = new Label
            {
                Text = date,
                AutoSize = true,
                ContextMenuStrip = cmsTasks,
                Tag = new { Title = title, Date = date }
            };

            titleLabel.MouseDown += task_MouseDown;
            dateLabel.MouseDown += task_MouseDown;

            tableTasks.Controls.Add(titleLabel, 0, rowIndex);
            tableTasks.Controls.Add(dateLabel, 1, rowIndex);
            tableTasks.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        }

        private void task_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && sender is Label label && label.Tag is not null)
            {
                dynamic taskData = label.Tag;

                viewTask.Tag = taskData;
                deleteTask.Tag = taskData;
                macTask.Tag = taskData;
            }
        }

        private void TN_Click(object sender, EventArgs e)
        {
            UserInput userInputForm = new UserInput(currentDate, 0);
            userInputForm.ShowDialog();
        }

        private void TFA_Click(object sender, EventArgs e)
        {
            taskFilter = "all";
            loadTasks(taskFilter);
        }

        private void TFP_Click(object sender, EventArgs e)
        {
            taskFilter = "pending";
            loadTasks(taskFilter);
        }

        private void TFC_Click(object sender, EventArgs e)
        {
            taskFilter = "completed";
            loadTasks(taskFilter);
        }

        private void TSD_Click(object sender, EventArgs e)
        {
            baseDirectory = AppContext.BaseDirectory;
            filePath = Path.Combine(baseDirectory, "User_Inputs", "Tasks.txt");

            if (!File.Exists(filePath))
            {
                MessageBox.Show("Tasks.txt not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<TaskList> taskList = new List<TaskList>();

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');

                    if (parts.Length < 3) continue;

                    string title = parts[1];
                    DateTime date;

                    if (!DateTime.TryParse(parts[2], out date)) continue;

                    taskList.Add(new TaskList { Title = title, Date = date });
                }
            }

            taskList = taskList.OrderBy(task => task.Date).ToList();

            tableTasks.Controls.Clear();
            tableTasks.RowCount = 1;

            foreach (var task in taskList)
            {
                addTask(task.Title, task.Date.ToString("MM-dd-yyyy"));
            }
        }

        private void TSP_Click(object sender, EventArgs e)
        {
            baseDirectory = AppContext.BaseDirectory;
            filePath = Path.Combine(baseDirectory, "User_Inputs", "Tasks.txt");

            if (!File.Exists(filePath))
            {
                MessageBox.Show("Tasks.txt not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<TaskList> taskList = new List<TaskList>();

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');

                    if (parts.Length < 3) continue;

                    string title = parts[1];
                    DateTime date;

                    if (!DateTime.TryParse(parts[2], out date)) continue;

                    string priorityString = parts[4].Trim().ToLower();

                    int priority = priorityString switch
                    {
                        "high" => 3,
                        "medium" => 2,
                        "low" => 1,
                        _ => 1
                    };

                    taskList.Add(new TaskList { Title = title, Date = date, Priority = priority });
                }
            }

            taskList = taskList.OrderByDescending(task => task.Priority).ToList();

            tableTasks.Controls.Clear();
            tableTasks.RowCount = 1;

            foreach (var task in taskList)
            {
                addTask(task.Title, task.Date.ToString("MM-dd-yyyy"));
            }
        }

        private void TST_Click(object sender, EventArgs e)
        {

        }

        private void viewTask_Click(object sender, EventArgs e)
        {
            var menuItem = (ToolStripMenuItem)sender;
            var taskDetails = menuItem.Tag as dynamic;

            if (taskDetails != null)
            {
                string title = taskDetails.Title;
                string date = taskDetails.Date;

                string taskInfo = taskInformation(title, date);
                if (!string.IsNullOrEmpty(taskInfo))
                {
                    MessageBox.Show(taskInfo, "Task Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Task not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private string taskInformation(string title, string date)
        {
            baseDirectory = AppContext.BaseDirectory;
            filePath = Path.Combine(baseDirectory, "User_Inputs", "Tasks.txt");

            string taskDetails = string.Empty;

            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');

                        if (parts.Length >= 6 && parts[1] == title && parts[2] == date)
                        {
                            taskDetails = $"Title: {parts[1]}\nDue Date: {parts[2]}\nDue Time: {parts[3]}\nPriority: {parts[4]}\nStatus: {parts[5]}";
                            break;
                        }
                    }
                }
            }

            return taskDetails;
        }

        private void deleteTask_Click(object sender, EventArgs e)
        {
            baseDirectory = AppContext.BaseDirectory;
            filePath = Path.Combine(baseDirectory, "User_Inputs", "Tasks.txt");

            var menuItem = (ToolStripMenuItem)sender;
            var taskDetails = menuItem.Tag as dynamic;

            string title = taskDetails.Title;
            string date = taskDetails.Date;

            var lines = File.ReadAllLines(filePath).ToList();
            var taskLine = lines.FirstOrDefault(line => line.Contains(title) && line.Contains(date));
            if (taskLine != null)
            {
                lines.Remove(taskLine);
                File.WriteAllLines(filePath, lines);
                MessageBox.Show("Task deleted successfully!", "Task Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                loadTasks("all");
            }
        }

        private void macTask_Click(object sender, EventArgs e)
        {
            baseDirectory = AppContext.BaseDirectory;
            filePath = Path.Combine(baseDirectory, "User_Inputs", "Tasks.txt");

            var menuItem = (ToolStripMenuItem)sender;
            var taskDetails = menuItem.Tag as dynamic;

            string title = taskDetails.Title;
            string date = taskDetails.Date;

            var lines = File.ReadAllLines(filePath).ToList();

            var taskLineIndex = lines.FindIndex(line => line.Contains(title) && line.Contains(date));
            if (taskLineIndex != -1)
            {
                var taskLine = lines[taskLineIndex];
                string[] parts = taskLine.Split(',');

                parts[5] = "Completed";
                lines[taskLineIndex] = string.Join(",", parts);

                File.WriteAllLines(filePath, lines);
                MessageBox.Show("Task marked as completed!", "Task Status Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

                loadTasks("all");
            }
        }

        private void loadAppointments(string filterStatus)
        {
            appointmentsLoaded = false;

            if (appointmentsLoaded) return;

            baseDirectory = AppContext.BaseDirectory;
            filePath = Path.Combine(baseDirectory, "User_Inputs", "Appointments.txt");

            if (!File.Exists(filePath))
            {
                MessageBox.Show("Appointments.txt not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            tableAppointments.Controls.Clear();
            tableAppointments.RowCount = 1;

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length < 3) continue;

                    string title = parts[1];
                    string date = parts[2];
                    string status = parts[6];

                    if (filterStatus.ToLower() == "upcoming" && status.ToLower() == "upcoming")
                    {
                        addAppointment(title, date);
                    }
                    else if (filterStatus.ToLower() == "completed" && status.ToLower() == "completed")
                    {
                        addAppointment(title, date);
                    }
                    else if (filterStatus.ToLower() == "canceled" && status.ToLower() == "canceled")
                    {
                        addAppointment(title, date);
                    }
                    else if (filterStatus.ToLower() == "all")
                    {
                        addAppointment(title, date);
                    }
                }
            }

            appointmentsLoaded = true;
        }

        private void addAppointment(string title, string date)
        {
            int rowIndex = tableAppointments.RowCount - 1;
            tableAppointments.RowCount++;

            Label titleLabel = new Label
            {
                Text = title,
                AutoSize = true,
                ContextMenuStrip = cmsAppointments,
                Tag = new { Title = title, Date = date }
            };

            Label dateLabel = new Label
            {
                Text = date,
                AutoSize = true,
                ContextMenuStrip = cmsAppointments,
                Tag = new { Title = title, Date = date }
            };

            titleLabel.MouseDown += appointment_MouseDown;
            dateLabel.MouseDown += appointment_MouseDown;

            tableAppointments.Controls.Add(titleLabel, 0, rowIndex);
            tableAppointments.Controls.Add(dateLabel, 1, rowIndex);
            tableAppointments.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        }

        private void appointment_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && sender is Label label && label.Tag is not null)
            {
                dynamic appointmentData = label.Tag;

                viewA.Tag = appointmentData;
                deleteA.Tag = appointmentData;
                macoA.Tag = appointmentData;
                macaA.Tag = appointmentData;
            }
        }

        private void AN_Click(object sender, EventArgs e)
        {
            UserInput userInputForm = new UserInput(currentDate, 1);
            userInputForm.ShowDialog();
        }

        private void AFU_Click(object sender, EventArgs e)
        {
            appointmentFilter = "upcoming";
            loadAppointments(appointmentFilter);
        }

        private void AFCO_Click(object sender, EventArgs e)
        {
            appointmentFilter = "completed";
            loadAppointments(appointmentFilter);
        }

        private void AFCA_Click(object sender, EventArgs e)
        {
            appointmentFilter = "canceled";
            loadAppointments(appointmentFilter);
        }

        private void AFA_Click(object sender, EventArgs e)
        {
            appointmentFilter = "all";
            loadAppointments(appointmentFilter);
        }

        private void viewA_Click(object sender, EventArgs e)
        {
            var menuItem = (ToolStripMenuItem)sender;
            var appointmentDetails = menuItem.Tag as dynamic;

            if (appointmentDetails != null)
            {
                string title = appointmentDetails.Title;
                string date = appointmentDetails.Date;

                string appointmentInfo = appointmentInformation(title, date);
                if (!string.IsNullOrEmpty(appointmentInfo))
                {
                    MessageBox.Show(appointmentInfo, "Appointment Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Appointment not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private string appointmentInformation(string title, string date)
        {
            baseDirectory = AppContext.BaseDirectory;
            filePath = Path.Combine(baseDirectory, "User_Inputs", "Appointments.txt");

            string appointmentDetails = string.Empty;

            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');

                        if (parts.Length >= 7 && parts[1] == title && parts[2] == date)
                        {
                            appointmentDetails = $"Title: {parts[1]}\nDate: {parts[2]}\nStart Time: {parts[3]}\nEnd Time: {parts[4]}\nDuration: {parts[5]}\nStatus: {parts[6]}";
                            break;
                        }
                    }
                }
            }

            return appointmentDetails;
        }

        private void deleteA_Click(object sender, EventArgs e)
        {
            baseDirectory = AppContext.BaseDirectory;
            filePath = Path.Combine(baseDirectory, "User_Inputs", "Appointments.txt");

            var menuItem = (ToolStripMenuItem)sender;
            var appointmentDetails = menuItem.Tag as dynamic;

            string title = appointmentDetails.Title;
            string date = appointmentDetails.Date;

            var lines = File.ReadAllLines(filePath).ToList();
            var appointmentLine = lines.FirstOrDefault(line => line.Contains(title) && line.Contains(date));
            if (appointmentLine != null)
            {
                lines.Remove(appointmentLine);
                File.WriteAllLines(filePath, lines);
                MessageBox.Show("Appointment deleted successfully!", "Appointment Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                loadAppointments("all");
            }
        }

        private void macoA_Click(object sender, EventArgs e)
        {
            baseDirectory = AppContext.BaseDirectory;
            filePath = Path.Combine(baseDirectory, "User_Inputs", "Appointments.txt");

            var menuItem = (ToolStripMenuItem)sender;
            var appointmentDetails = menuItem.Tag as dynamic;

            string title = appointmentDetails.Title;
            string date = appointmentDetails.Date;

            var lines = File.ReadAllLines(filePath).ToList();

            var appointmentLineIndex = lines.FindIndex(line => line.Contains(title) && line.Contains(date));
            if (appointmentLineIndex != -1)
            {
                var appointmentLine = lines[appointmentLineIndex];
                string[] parts = appointmentLine.Split(',');

                parts[6] = "Completed";
                lines[appointmentLineIndex] = string.Join(",", parts);

                File.WriteAllLines(filePath, lines);
                MessageBox.Show("Appointment marked as completed!", "Appointment Status Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

                loadAppointments("all");
            }
        }

        private void macaA_Click(object sender, EventArgs e)
        {
            baseDirectory = AppContext.BaseDirectory;
            filePath = Path.Combine(baseDirectory, "User_Inputs", "Appointments.txt");

            var menuItem = (ToolStripMenuItem)sender;
            var appointmentDetails = menuItem.Tag as dynamic;

            string title = appointmentDetails.Title;
            string date = appointmentDetails.Date;

            var lines = File.ReadAllLines(filePath).ToList();

            var appointmentLineIndex = lines.FindIndex(line => line.Contains(title) && line.Contains(date));
            if (appointmentLineIndex != -1)
            {
                var appointmentLine = lines[appointmentLineIndex];
                string[] parts = appointmentLine.Split(',');

                parts[6] = "Canceled";
                lines[appointmentLineIndex] = string.Join(",", parts);

                File.WriteAllLines(filePath, lines);
                MessageBox.Show("Appointment marked as canceled!", "Appointment Status Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

                loadAppointments("all");
            }
        }

        private void loadEvents(string filterType)
        {
            eventsLoaded = false;

            if (eventsLoaded) return;

            baseDirectory = AppContext.BaseDirectory;
            filePath = Path.Combine(baseDirectory, "User_Inputs", "Events.txt");

            if (!File.Exists(filePath))
            {
                MessageBox.Show("Events.txt not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            tableEvents.Controls.Clear();
            tableEvents.RowCount = 1;

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length < 3) continue;

                    string title = parts[1];
                    string date = parts[2];
                    string type = parts[7];

                    if (filterType.ToLower() == "personal" && type.ToLower() == "personal")
                    {
                        addEvent(title, date);
                    }
                    else if (filterType.ToLower() == "social" && type.ToLower() == "social")
                    {
                        addEvent(title, date);
                    }
                    else if (filterType.ToLower() == "school" && type.ToLower() == "school")
                    {
                        addEvent(title, date);
                    }
                    else if (filterType.ToLower() == "work" && type.ToLower() == "work")
                    {
                        addEvent(title, date);
                    }
                    else if (filterType.ToLower() == "all")
                    {
                        addEvent(title, date);
                    }
                }
            }

            eventsLoaded = true;
        }

        private void addEvent(string title, string date)
        {
            int rowIndex = tableEvents.RowCount - 1;
            tableEvents.RowCount++;

            Label titleLabel = new Label
            {
                Text = title,
                AutoSize = true,
                ContextMenuStrip = cmsEvents,
                Tag = new { Title = title, Date = date }
            };

            Label dateLabel = new Label
            {
                Text = date,
                AutoSize = true,
                ContextMenuStrip = cmsEvents,
                Tag = new { Title = title, Date = date }
            };

            titleLabel.MouseDown += event_MouseDown;
            dateLabel.MouseDown += event_MouseDown;

            tableEvents.Controls.Add(titleLabel, 0, rowIndex);
            tableEvents.Controls.Add(dateLabel, 1, rowIndex);
            tableEvents.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        }

        private void event_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && sender is Label label && label.Tag is not null)
            {
                dynamic eventData = label.Tag;

                viewEvent.Tag = eventData;
                deleteEvent.Tag = eventData;
            }
        }

        private void EN_Click(object sender, EventArgs e)
        {
            UserInput userInputForm = new UserInput(currentDate, 2);
            userInputForm.ShowDialog();
        }

        private void viewEvent_Click(object sender, EventArgs e)
        {
            var menuItem = (ToolStripMenuItem)sender;
            var eventDetails = menuItem.Tag as dynamic;

            if (eventDetails != null)
            {
                string title = eventDetails.Title;
                string date = eventDetails.Date;

                string eventInfo = eventInformation(title, date);
                if (!string.IsNullOrEmpty(eventInfo))
                {
                    MessageBox.Show(eventInfo, "Event Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Event not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private string eventInformation(string title, string date)
        {
            baseDirectory = AppContext.BaseDirectory;
            filePath = Path.Combine(baseDirectory, "User_Inputs", "Events.txt");

            string eventDetails = string.Empty;

            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');

                        if (parts.Length >= 8 && parts[1] == title && parts[2] == date)
                        {
                            eventDetails = $"Title: {parts[1]}\nDate: {parts[2]}\nStart Time: {parts[3]}\nEnd Time: {parts[4]}\nDuration: {parts[5]}\nLocation: {parts[6]}\nType: {parts[7]}";
                            break;
                        }
                    }
                }
            }

            return eventDetails;
        }

        private void deleteEvent_Click(object sender, EventArgs e)
        {
            baseDirectory = AppContext.BaseDirectory;
            filePath = Path.Combine(baseDirectory, "User_Inputs", "Events.txt");

            var menuItem = (ToolStripMenuItem)sender;
            var eventDetails = menuItem.Tag as dynamic;

            string title = eventDetails.Title;
            string date = eventDetails.Date;

            var lines = File.ReadAllLines(filePath).ToList();
            var eventLine = lines.FirstOrDefault(line => line.Contains(title) && line.Contains(date));
            if (eventLine != null)
            {
                lines.Remove(eventLine);
                File.WriteAllLines(filePath, lines);
                MessageBox.Show("Event deleted successfully!", "Event Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                loadEvents("all");
            }
        }

        private void EFP_Click(object sender, EventArgs e)
        {
            eventFilter = "personal";
            loadEvents(eventFilter);
        }

        private void EFSO_Click(object sender, EventArgs e)
        {
            eventFilter = "social";
            loadEvents(eventFilter);
        }

        private void EFSC_Click(object sender, EventArgs e)
        {
            eventFilter = "school";
            loadEvents(eventFilter);
        }

        private void EFW_Click(object sender, EventArgs e)
        {
            eventFilter = "work";
            loadEvents(eventFilter);
        }

        private void EFA_Click(object sender, EventArgs e)
        {
            eventFilter = "all";
            loadEvents(eventFilter);
        }
    }

    class TaskList
    {
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public int Priority { get; set; }
    }
}
