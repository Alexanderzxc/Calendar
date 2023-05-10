using System.Reflection.Metadata.Ecma335;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        calendar cal = new calendar();
        public Form1()
        {
            InitializeComponent();
            int[] years = new int[15];
            for (int i = 0; i < 15; i++)
            {
                years[i] = 2017 + i;
            }
            foreach (int year in years)
            {
                YearBox.Items.Add(year);
            }
            YearBox.SelectedIndex = 0;
            int[] months = new int[12];
            for (int i = 0; i < 12; i++)
            {
                months[i] = i + 1;
            }
            foreach (int month in months)
            {
                MonthBox.Items.Add(month);
            }
            MonthBox.SelectedIndex = 0;
            int[] days = new int[31];
            for (int i = 0; i < 31; i++)
            {
                days[i] = i + 1;
            }
            foreach (int day in days)
            {
                DayBox.Items.Add(day);
            }
            DayBox.SelectedIndex = 0;
            FirstLabel.Text = cal.GetDate(Convert.ToInt32(DayBox.Text), Convert.ToInt32(MonthBox.Text), Convert.ToInt32(YearBox.Text));
            if (MonthBox.Items.Count != 12)
            {
                MonthBox.Items.Clear();
                foreach (int month in months)
                {
                    MonthBox.Items.Add(month);
                }
            }
            if (DayBox.Items.Count >31)
            {
                DayBox.Items.Clear();
                foreach (int day in days)
                {
                    DayBox.Items.Add(day);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MonthBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DayBox.Items.Clear();
            switch (MonthBox.SelectedIndex)
            {
                case 1:
                    
                    if (YearBox.SelectedIndex % 4 == 3)
                    {
                        int[] days = new int[29];
                        for (int i = 0; i < 29; i++)
                        {
                            days[i] = i + 1;
                        }
                        foreach (int day in days)
                        {
                            DayBox.Items.Add(day);
                        }
                    }
                    else
                    {
                        int[] days = new int[28];
                        for (int i = 0; i < 28; i++)
                        {
                            days[i] = i + 1;
                        }
                        foreach (int day in days)
                        {
                            DayBox.Items.Add(day);
                        }
                    }
                    DayBox.SelectedIndex = 0;
                    if (YearBox.Text != "")
                    {

                        YearBox.Text = YearBox.Text;
                    }
                    else
                    {
                        YearBox.SelectedIndex = 0;
                    }
                    return;
                case (0 or 2 or 4 or 6 or 7 or 9 or 11):
                    int[] days_2 = new int[31];
                    for (int i = 0; i < 31; i++)
                    {
                        days_2[i] = i + 1;
                    }
                    foreach (int day in days_2)
                    {
                        DayBox.Items.Add(day);
                    }
                    if (YearBox.Text != "")
                    {

                        YearBox.Text = YearBox.Text;
                    }
                    else
                    {
                        YearBox.SelectedIndex = 0;
                    }
                    DayBox.SelectedIndex = 0;
                    return;
                default:
                    int[] days_3 = new int[30];
                    for (int i = 0; i < 30; i++)
                    {
                        days_3[i] = i + 1;
                    }
                    foreach (int day in days_3)
                    {
                        DayBox.Items.Add(day);
                    }
                    DayBox.SelectedIndex = 0;
                    if (YearBox.Text != "")
                    {

                        YearBox.Text = YearBox.Text;
                    }
                    else
                    {
                        YearBox.SelectedIndex = 0;
                    }
                    return;
            }
        }

        private void YearBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DayBox.Items.Clear();
            int[] months = new int[12];
            for (int i = 0; i < 12; i++)
            {
                months[i] = i + 1;
            }
            foreach (int month in months)
            {
                MonthBox.Items.Add(month);
            }
            MonthBox.SelectedIndex = 0;
            bool vis = false;
            if (YearBox.SelectedIndex % 4 == 3)
            {
                vis = true;
            }
            else
            {
                vis = false;
            }
            if ((MonthBox.SelectedIndex == 1) & (vis))
            {
                DayBox.Items.Clear();
                int[] days_for_vis = new int[29];
                for (int i = 0; i < 29; i++)
                {
                    days_for_vis[i] = i + 1;
                }
                foreach (int day in days_for_vis)
                {
                    DayBox.Items.Add(day);
                }
                DayBox.SelectedIndex = 0;
                FirstLabel.Text = cal.GetDate(Convert.ToInt32(DayBox.Text), Convert.ToInt32(MonthBox.Text), Convert.ToInt32(YearBox.Text));
                if (MonthBox.Items.Count != 12)
                {
                    MonthBox.Items.Clear();
                    foreach (int month in months)
                    {
                        MonthBox.Items.Add(month);
                    }
                }


            }
            else
            {
                DayBox.Items.Clear();
                switch (MonthBox.SelectedIndex)
                {
                    case 1:
                        int[] days = new int[28];
                        for (int i = 0; i < 28; i++)
                        {
                            days[i] = i + 1;
                        }
                        foreach (int day in days)
                        {
                            DayBox.Items.Add(day);
                        }
                        DayBox.SelectedIndex = 0;
                        FirstLabel.Text = cal.GetDate(Convert.ToInt32(DayBox.Text), Convert.ToInt32(MonthBox.Text), Convert.ToInt32(YearBox.Text));
                        if (MonthBox.Items.Count != 12)
                        {
                            MonthBox.Items.Clear();
                            foreach (int month in months)
                            {
                                MonthBox.Items.Add(month);
                            }
                        }
                        return;
                    case (0 or 2 or 4 or 6 or 7 or 9 or 11):
                        int[] days_2 = new int[31];
                        for (int i = 0; i < 31; i++)
                        {
                            days_2[i] = i + 1;
                        }
                        foreach (int day in days_2)
                        {
                            DayBox.Items.Add(day);
                        }
                        DayBox.SelectedIndex = 0;
                        FirstLabel.Text = cal.GetDate(Convert.ToInt32(DayBox.Text), Convert.ToInt32(MonthBox.Text), Convert.ToInt32(YearBox.Text));
                        if (MonthBox.Items.Count != 12)
                        {
                            MonthBox.Items.Clear();
                            foreach (int month in months)
                            {
                                MonthBox.Items.Add(month);
                            }
                        }
                        return;
                    default:
                        int[] days_3 = new int[30];
                        for (int i = 0; i < 30; i++)
                        {
                            days_3[i] = i + 1;
                        }
                        foreach (int day in days_3)
                        {
                            DayBox.Items.Add(day);
                        }
                        DayBox.SelectedIndex = 0;
                        FirstLabel.Text = cal.GetDate(Convert.ToInt32(DayBox.Text), Convert.ToInt32(MonthBox.Text), Convert.ToInt32(YearBox.Text));
                        if (MonthBox.Items.Count != 12)
                        {
                            MonthBox.Items.Clear();
                            foreach (int month in months)
                            {
                                MonthBox.Items.Add(month);
                            }
                        }
                        return;
                }
            }

        }

        private void DayBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int day = Convert.ToInt32(DayBox.Text);
            int month = Convert.ToInt32(MonthBox.Text);
            int year = Convert.ToInt32(YearBox.Text);
            FirstLabel.Text = cal.GetDate(day, month, year);
        }

        private void NextBut_Click(object sender, EventArgs e)
        {
            if (DayBox.Items.Count > Convert.ToInt32(DayBox.Text))
            {
                DayBox.SelectedIndex = Convert.ToInt32(DayBox.Text);
            }
            else
            {
                if (MonthBox.Text != "12")
                {
                    if (MonthBox.Text == "1")
                    {
                        MonthBox.SelectedIndex = 1;
                        DayBox.SelectedIndex = 0;
                    }
                    else
                    {
                        MonthBox.SelectedIndex += 1;
                        DayBox.SelectedIndex = 0;
                    }
                }
                else
                {
                    MonthBox.SelectedIndex = 0;
                    DayBox.SelectedIndex = 0;
                    YearBox.SelectedIndex += 1;
                }
            }
            int day = Convert.ToInt32(DayBox.Text);
            int month = Convert.ToInt32(MonthBox.Text);
            int year = Convert.ToInt32(YearBox.Text);
        }
    }
}