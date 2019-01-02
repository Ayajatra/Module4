using System;
using System.IO;
using System.Data;
using System.Linq;
using Microsoft.Reporting.WinForms;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Module4
{
    public partial class MainForm : CoreForm
    {
        private Session4Entities db = new Session4Entities();
        private Timer timer = new Timer();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            timer.Start();
            timer.Tick += timer_Tick;

            LoadTimePeriod();
            LoadGender();
            LoadAge();

            LoadDetailed();
        }

        private void LoadTimePeriod()
        {
            var q = db.Surveys
                .GroupBy(x => x.Date)
                .Select(x => x.FirstOrDefault()).ToList()
                .Select(x => x.Date).ToList();

            var r = new List<string>();
            r.Add("All Time Period");
            foreach (var i in q)
            {
                r.Add(i.Value.ToString("MMMM yyyy"));
            }

            cbTimePeriod.DataSource = r;
        }

        private void LoadGender()
        {
            var g = new List<string>
            {
                "All Genders",
                "Male",
                "Female"
            };

            cbGender.DataSource = g;
        }

        private void LoadAge()
        {
            var a = new List<string>
            {
                "All Ages",
                "18-24",
                "25-39",
                "40-59",
                "60+"
            };

            cbAge.DataSource = a;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (cbxAge.Checked)
                cbAge.Enabled = false;
            else
                cbAge.Enabled = true;

            if (cbxGender.Checked)
                cbGender.Enabled = false;
            else
                cbGender.Enabled = true;
        }

        private void viewResultsSummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadSummary();
        }

        private void viewDetailedResultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadDetailed();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoadSummary()
        {
            labelTimePeriod.Enabled = false;
            cbTimePeriod.Enabled = false;
            cbAge.Enabled = false;
            cbxAge.Enabled = false;
            cbGender.Enabled = false;
            cbxGender.Enabled = false;

            var s = db.Surveys.ToList();
            var q = s.Select(x => new SummaryModel
            {
                Gender = GetGender(x.Gender),
                Age = x.Age.HasValue ? GetAge(x.Age.Value) : "",
                CabinType = x.CabinType ?? "",
                Arrival = x.Arrival ?? ""
            }).ToList();

            rv.Reset();
            rv.LocalReport.ReportEmbeddedResource = "Module4.SummaryReport.rdlc";
            rv.LocalReport.SetParameters(new ReportParameter("FieldWork", $"Fieldwork: {s.Min(x => x.Date).Value.ToString("MMMM yyyy")} - {s.Max(x => x.Date).Value.ToString("MMMM yyyy")}"));
            rv.LocalReport.SetParameters(new ReportParameter("Size", $"Sample Size: {s.Count} Adults"));
            rv.LocalReport.DataSources.Add(new ReportDataSource("SummaryDataSet", q));
            rv.RefreshReport();
        }

        private string GetGender(string gender)
        {
            if (gender == "F")
                return "Female";
            else if (gender == "M")
                return "Male";
            else
                return "";
        }

        private string GetAge(int age)
        {
            // R mean Remove which will be processed in the DetailedReport.rdlc
            if (age >= 18 && age <= 24)
                return "18-24";
            else if (age >= 25 && age <= 39)
                return "25-39";
            else if (age >= 40 && age <= 59)
                return "40-59";
            else if (age >= 60)
                return "60+";
            else if (age == -1)
                return "R";
            else
                return "";
        }

        private void LoadDetailed()
        {
            labelTimePeriod.Enabled = true;
            cbTimePeriod.Enabled = true;
            cbAge.Enabled = true;
            cbxAge.Enabled = true;
            cbGender.Enabled = true;
            cbxGender.Enabled = true;

            List<Survey> surveys;
            if (cbTimePeriod.Text == "All Time Period")
            {
                surveys = db.Surveys.ToList();
            }
            else
            {
                DateTime timePeriod = DateTime.ParseExact(cbTimePeriod.Text, "MMMM yyyy", null);
                surveys = db.Surveys.Where(x => x.Date.Value.Month == timePeriod.Month).ToList();
            }

            // NOT WORKING
            //if (cbxGender.Checked)
            //{
            //    // R mean Remove which will be processed in the DetailedReport.rdlc
            //    if (cbGender.Text == "Male")
            //    {
            //        for (int i = 0; i < surveys.Count; i++)
            //        {
            //            if (surveys[i].Gender == "F")
            //                surveys[i].Gender = "R";
            //        }
            //    }
            //    else if (cbGender.Text == "Female")
            //    {
            //        for (int i = 0; i < surveys.Count; i++)
            //        {
            //            if (surveys[i].Gender == "M")
            //                surveys[i].Gender = "R";
            //        }
            //    }
            //}
            //else
            //{
            //    for (int i = 0; i < surveys.Count; i++)
            //    {
            //        surveys[i].Gender = "R";
            //    }
            //}

            //if (cbxAge.Checked)
            //{
            //    if (cbAge.Text == "18-24")
            //    {
            //        for (int i = 0; i < surveys.Count; i++)
            //        {
            //            if (surveys[i].Age >= 18 && surveys[i].Age <= 24)
            //                surveys[i].Age = -1;
            //        }
            //    }
            //    else if (cbAge.Text == "25-39")
            //    {
            //        for (int i = 0; i < surveys.Count; i++)
            //        {
            //            if (surveys[i].Age >= 25 && surveys[i].Age <= 39)
            //                surveys[i].Age = -1;
            //        }
            //    }
            //    else if (cbAge.Text == "40-59")
            //    {
            //        for (int i = 0; i < surveys.Count; i++)
            //        {
            //            if (surveys[i].Age >= 40 && surveys[i].Age <= 59)
            //                surveys[i].Age = -1;
            //        }
            //    }
            //    else if (cbAge.Text == "60+")
            //    {
            //        for (int i = 0; i < surveys.Count; i++)
            //        {
            //            if (surveys[i].Age >= 60)
            //                surveys[i].Age = -1;
            //        }
            //    }
            //}
            //else
            //{
            //    // -1 mean Remove which will be processed in the GetAge function
            //    for (int i = 0; i < surveys.Count; i++)
            //    {
            //        surveys[i].Age = -1;
            //    }
            //}

            var results = new List<DetailedModel>();
            foreach (var survey in surveys)
            {
                var details = db.SurveysDetails.Where(x => x.SurveyID == survey.ID).OrderBy(x => x.QuestionID).ToList();
                foreach (var detail in details)
                {
                    results.Add(new DetailedModel
                    {
                        Gender = GetGender(survey.Gender),
                        Age = survey.Age.HasValue ? GetAge(survey.Age.Value) : "",
                        CabinType = survey.CabinType ?? "",
                        Arrival = survey.Arrival ?? "",
                        Rating = detail.Answer.Answer1,
                        Question = detail.Question.Question1
                    });
                }
            }

            rv.Reset();
            rv.LocalReport.ReportEmbeddedResource = "Module4.DetailedReport.rdlc";
            rv.LocalReport.DataSources.Add(new ReportDataSource("DetailedDataSet", results));
            rv.RefreshReport();
        }

        private void DetailedChanged(object sender, EventArgs e)
        {
            LoadDetailed();
        }
    }
}