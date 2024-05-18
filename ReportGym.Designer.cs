using System.Windows.Forms;
using System.Drawing;
namespace Database_Project
{
    partial class ReportGym
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportGym));
            this.member_label = new System.Windows.Forms.Label();
            this.trainer_label = new System.Windows.Forms.Label();
            this.retentionrate_label = new System.Windows.Forms.Label();
            this.membership_label = new System.Windows.Forms.Label();
            this.membercount_label = new System.Windows.Forms.Label();
            this.trainercount_label = new System.Windows.Forms.Label();
            this.retentionval_label = new System.Windows.Forms.Label();
            this.membergrowthval_label = new System.Windows.Forms.Label();
            this.trainercount = new System.Windows.Forms.PictureBox();
            this.membership_growth = new System.Windows.Forms.PictureBox();
            this.retentionrate = new System.Windows.Forms.PictureBox();
            this.membercount = new System.Windows.Forms.PictureBox();
            this.gymdetails_panel = new System.Windows.Forms.Panel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.revenue_Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gymname_label = new System.Windows.Forms.Label();
            this.totalrevenue_label = new System.Windows.Forms.Label();
            this.location_label = new System.Windows.Forms.Label();
            this.email_label = new System.Windows.Forms.Label();
            this.contact_no_label = new System.Windows.Forms.Label();
            this.location_value_label = new System.Windows.Forms.Label();
            this.revenue_value_label = new System.Windows.Forms.Label();
            this.email_value_label = new System.Windows.Forms.Label();
            this.contactno_value_label = new System.Windows.Forms.Label();
            this.ownername_label = new System.Windows.Forms.Label();
            this.ownername_value_label = new System.Windows.Forms.Label();
            this.revenue = new System.Windows.Forms.PictureBox();
            this.Regno_label = new System.Windows.Forms.Label();
            this.regnoval_label = new System.Windows.Forms.Label();
            this.zip_label = new System.Windows.Forms.Label();
            this.zipvalue_label = new System.Windows.Forms.Label();
            this.gyminfo_panel = new System.Windows.Forms.Panel();
            this.customer_satisfaction_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gymratings_panel = new System.Windows.Forms.Panel();
            this.star5 = new System.Windows.Forms.PictureBox();
            this.star4 = new System.Windows.Forms.PictureBox();
            this.star3 = new System.Windows.Forms.PictureBox();
            this.star2 = new System.Windows.Forms.PictureBox();
            this.star1 = new System.Windows.Forms.PictureBox();
            this.gym_ratings = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trainercount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membership_growth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.retentionrate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membercount)).BeginInit();
            this.gymdetails_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.revenue_Chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.revenue)).BeginInit();
            this.gyminfo_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customer_satisfaction_chart)).BeginInit();
            this.gymratings_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.star5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.star4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.star3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.star2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.star1)).BeginInit();
            this.SuspendLayout();
            // 
            // member_label
            // 
            this.member_label.AutoSize = true;
            this.member_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.member_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.member_label.Location = new System.Drawing.Point(109, 10);
            this.member_label.Name = "member_label";
            this.member_label.Size = new System.Drawing.Size(89, 20);
            this.member_label.TabIndex = 4;
            this.member_label.Text = " Members:";
            // 
            // trainer_label
            // 
            this.trainer_label.AutoSize = true;
            this.trainer_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trainer_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.trainer_label.Location = new System.Drawing.Point(111, 86);
            this.trainer_label.Name = "trainer_label";
            this.trainer_label.Size = new System.Drawing.Size(76, 20);
            this.trainer_label.TabIndex = 4;
            this.trainer_label.Text = "Trainers:";
            // 
            // retentionrate_label
            // 
            this.retentionrate_label.AutoSize = true;
            this.retentionrate_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retentionrate_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.retentionrate_label.Location = new System.Drawing.Point(342, 10);
            this.retentionrate_label.Name = "retentionrate_label";
            this.retentionrate_label.Size = new System.Drawing.Size(130, 20);
            this.retentionrate_label.TabIndex = 7;
            this.retentionrate_label.Text = " Retention Rate:";
            // 
            // membership_label
            // 
            this.membership_label.AutoSize = true;
            this.membership_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.membership_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.membership_label.Location = new System.Drawing.Point(339, 98);
            this.membership_label.Name = "membership_label";
            this.membership_label.Size = new System.Drawing.Size(165, 20);
            this.membership_label.TabIndex = 8;
            this.membership_label.Text = "Membership Growth:";
            // 
            // membercount_label
            // 
            this.membercount_label.AutoSize = true;
            this.membercount_label.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.membercount_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.membercount_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.membercount_label.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.membercount_label.Location = new System.Drawing.Point(115, 37);
            this.membercount_label.Name = "membercount_label";
            this.membercount_label.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.membercount_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.membercount_label.Size = new System.Drawing.Size(55, 25);
            this.membercount_label.TabIndex = 9;
            this.membercount_label.Text = "200";
            // 
            // trainercount_label
            // 
            this.trainercount_label.AutoSize = true;
            this.trainercount_label.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.trainercount_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trainercount_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.trainercount_label.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.trainercount_label.Location = new System.Drawing.Point(115, 116);
            this.trainercount_label.Name = "trainercount_label";
            this.trainercount_label.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.trainercount_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.trainercount_label.Size = new System.Drawing.Size(44, 25);
            this.trainercount_label.TabIndex = 10;
            this.trainercount_label.Text = "25";
            // 
            // retentionval_label
            // 
            this.retentionval_label.AutoSize = true;
            this.retentionval_label.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.retentionval_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retentionval_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.retentionval_label.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.retentionval_label.Location = new System.Drawing.Point(361, 44);
            this.retentionval_label.Name = "retentionval_label";
            this.retentionval_label.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.retentionval_label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.retentionval_label.Size = new System.Drawing.Size(62, 25);
            this.retentionval_label.TabIndex = 12;
            this.retentionval_label.Text = "15%";
            // 
            // membergrowthval_label
            // 
            this.membergrowthval_label.AutoSize = true;
            this.membergrowthval_label.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.membergrowthval_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.membergrowthval_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.membergrowthval_label.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.membergrowthval_label.Location = new System.Drawing.Point(366, 125);
            this.membergrowthval_label.Name = "membergrowthval_label";
            this.membergrowthval_label.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.membergrowthval_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.membergrowthval_label.Size = new System.Drawing.Size(67, 25);
            this.membergrowthval_label.TabIndex = 13;
            this.membergrowthval_label.Text = "1.5%";
            // 
            // trainercount
            // 
           // this.trainercount.Image = global::Database_Project.Properties.Resources.no_of_trainers_icon_removebg_preview_removebg_preview;
            this.trainercount.Location = new System.Drawing.Point(17, 73);
            this.trainercount.Margin = new System.Windows.Forms.Padding(0);
            this.trainercount.Name = "trainercount";
            this.trainercount.Size = new System.Drawing.Size(85, 79);
            this.trainercount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trainercount.TabIndex = 15;
            this.trainercount.TabStop = false;
            // 
            // membership_growth
            // 
            this.membership_growth.AccessibleName = "membership growth";
           // this.membership_growth.Image = global::Database_Project.Properties.Resources.membership_growth_removebg_preview_removebg_preview;
            this.membership_growth.Location = new System.Drawing.Point(261, 93);
            this.membership_growth.Name = "membership_growth";
            this.membership_growth.Size = new System.Drawing.Size(72, 59);
            this.membership_growth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.membership_growth.TabIndex = 15;
            this.membership_growth.TabStop = false;
            // 
            // retentionrate
            // 
            this.retentionrate.AccessibleName = "retention rate";
           // this.retentionrate.Image = global::Database_Project.Properties.Resources.retention_rate_removebg_preview_removebg_preview;
            this.retentionrate.Location = new System.Drawing.Point(270, 3);
            this.retentionrate.Name = "retentionrate";
            this.retentionrate.Size = new System.Drawing.Size(66, 63);
            this.retentionrate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.retentionrate.TabIndex = 16;
            this.retentionrate.TabStop = false;
            // 
            // membercount
            // 
          //  this.membercount.Image = global::Database_Project.Properties.Resources.no_of_member_icon_removebg_preview_removebg_preview;
            this.membercount.Location = new System.Drawing.Point(9, 3);
            this.membercount.Margin = new System.Windows.Forms.Padding(0);
            this.membercount.Name = "membercount";
            this.membercount.Size = new System.Drawing.Size(97, 60);
            this.membercount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.membercount.TabIndex = 17;
            this.membercount.TabStop = false;
            // 
            // gymdetails_panel
            // 
            this.gymdetails_panel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gymdetails_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gymdetails_panel.Controls.Add(this.membercount);
            this.gymdetails_panel.Controls.Add(this.retentionrate);
            this.gymdetails_panel.Controls.Add(this.membership_growth);
            this.gymdetails_panel.Controls.Add(this.trainercount);
            this.gymdetails_panel.Controls.Add(this.membergrowthval_label);
            this.gymdetails_panel.Controls.Add(this.retentionval_label);
            this.gymdetails_panel.Controls.Add(this.trainercount_label);
            this.gymdetails_panel.Controls.Add(this.membercount_label);
            this.gymdetails_panel.Controls.Add(this.membership_label);
            this.gymdetails_panel.Controls.Add(this.retentionrate_label);
            this.gymdetails_panel.Controls.Add(this.trainer_label);
            this.gymdetails_panel.Controls.Add(this.member_label);
            this.gymdetails_panel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gymdetails_panel.Location = new System.Drawing.Point(14, 462);
            this.gymdetails_panel.Name = "gymdetails_panel";
            this.gymdetails_panel.Size = new System.Drawing.Size(549, 160);
            this.gymdetails_panel.TabIndex = 20;
            // 
            // revenue_Chart
            // 
            this.revenue_Chart.AntiAliasing = System.Windows.Forms.DataVisualization.Charting.AntiAliasingStyles.Text;
            this.revenue_Chart.BackColor = System.Drawing.SystemColors.ControlLight;
            this.revenue_Chart.BackImageTransparentColor = System.Drawing.Color.White;
            chartArea1.AxisX.InterlacedColor = System.Drawing.Color.White;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.IsMarginVisible = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.LineWidth = 0;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisX.MajorGrid.LineWidth = 0;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea1.AxisX.MajorTickMark.LineWidth = 2;
            chartArea1.AxisX.MajorTickMark.Size = 0F;
            chartArea1.AxisX.ScaleBreakStyle.Spacing = 1D;
            chartArea1.AxisX.ScaleBreakStyle.StartFromZero = System.Windows.Forms.DataVisualization.Charting.StartFromZero.Yes;
            chartArea1.AxisX.TitleForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            chartArea1.AxisX2.MaximumAutoSize = 100F;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.LabelStyle.Format = "${0:0,}K";
            chartArea1.AxisY.LineColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.AxisY.LineWidth = 0;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisY.MajorTickMark.LineWidth = 0;
            chartArea1.AxisY.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.BackColor = System.Drawing.SystemColors.ControlLight;
            chartArea1.BorderColor = System.Drawing.Color.Transparent;
            chartArea1.CursorX.LineColor = System.Drawing.Color.Silver;
            chartArea1.Name = "ChartArea1";
            this.revenue_Chart.ChartAreas.Add(chartArea1);
            this.revenue_Chart.ImeMode = System.Windows.Forms.ImeMode.Off;
            legend1.Alignment = System.Drawing.StringAlignment.Far;
            legend1.Enabled = false;
            legend1.IsDockedInsideChartArea = false;
            legend1.Name = "Legend1";
            this.revenue_Chart.Legends.Add(legend1);
            this.revenue_Chart.Location = new System.Drawing.Point(14, 199);
            this.revenue_Chart.Name = "revenue_Chart";
            this.revenue_Chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            series1.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series1.Color = System.Drawing.Color.MediumVioletRed;
            series1.CustomProperties = "DoughnutRadius=40";
            series1.Legend = "Legend1";
            series1.Name = "date 1";
            this.revenue_Chart.Series.Add(series1);
            this.revenue_Chart.Size = new System.Drawing.Size(549, 240);
            this.revenue_Chart.TabIndex = 18;
            this.revenue_Chart.Text = "performance";
            title1.Alignment = System.Drawing.ContentAlignment.BottomLeft;
            title1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            title1.DockedToChartArea = "ChartArea1";
            title1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            title1.IsDockedInsideChartArea = false;
            title1.Name = "Title1";
            title1.Text = "Gross Revenue";
            title2.Name = "Title2";
            this.revenue_Chart.Titles.Add(title1);
            this.revenue_Chart.Titles.Add(title2);
            // 
            // gymname_label
            // 
            this.gymname_label.AutoSize = true;
            this.gymname_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gymname_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gymname_label.Location = new System.Drawing.Point(14, 16);
            this.gymname_label.Name = "gymname_label";
            this.gymname_label.Size = new System.Drawing.Size(163, 32);
            this.gymname_label.TabIndex = 5;
            this.gymname_label.Text = "Gym Name";
            // 
            // totalrevenue_label
            // 
            this.totalrevenue_label.AutoSize = true;
            this.totalrevenue_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalrevenue_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.totalrevenue_label.Location = new System.Drawing.Point(395, 11);
            this.totalrevenue_label.Name = "totalrevenue_label";
            this.totalrevenue_label.Size = new System.Drawing.Size(107, 18);
            this.totalrevenue_label.TabIndex = 4;
            this.totalrevenue_label.Text = "Total Revenue:";
            // 
            // location_label
            // 
            this.location_label.AutoSize = true;
            this.location_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.location_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.location_label.Location = new System.Drawing.Point(16, 71);
            this.location_label.Name = "location_label";
            this.location_label.Size = new System.Drawing.Size(69, 18);
            this.location_label.TabIndex = 6;
            this.location_label.Text = "Location:";
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.email_label.Location = new System.Drawing.Point(14, 103);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(49, 18);
            this.email_label.TabIndex = 7;
            this.email_label.Text = "Email:";
            // 
            // contact_no_label
            // 
            this.contact_no_label.AutoSize = true;
            this.contact_no_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contact_no_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.contact_no_label.Location = new System.Drawing.Point(269, 76);
            this.contact_no_label.Name = "contact_no_label";
            this.contact_no_label.Size = new System.Drawing.Size(121, 18);
            this.contact_no_label.TabIndex = 9;
            this.contact_no_label.Text = "Contact Number:";
            // 
            // location_value_label
            // 
            this.location_value_label.AutoSize = true;
            this.location_value_label.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.location_value_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.location_value_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.location_value_label.Location = new System.Drawing.Point(133, 75);
            this.location_value_label.Name = "location_value_label";
            this.location_value_label.Size = new System.Drawing.Size(115, 18);
            this.location_value_label.TabIndex = 10;
            this.location_value_label.Text = "XYZ,  Islamabad";
            // 
            // revenue_value_label
            // 
            this.revenue_value_label.AutoSize = true;
            this.revenue_value_label.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.revenue_value_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.revenue_value_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.revenue_value_label.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.revenue_value_label.Location = new System.Drawing.Point(396, 29);
            this.revenue_value_label.Name = "revenue_value_label";
            this.revenue_value_label.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.revenue_value_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.revenue_value_label.Size = new System.Drawing.Size(80, 22);
            this.revenue_value_label.TabIndex = 11;
            this.revenue_value_label.Text = "150000";
            // 
            // email_value_label
            // 
            this.email_value_label.AutoSize = true;
            this.email_value_label.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.email_value_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.email_value_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.email_value_label.Location = new System.Drawing.Point(102, 107);
            this.email_value_label.Name = "email_value_label";
            this.email_value_label.Size = new System.Drawing.Size(147, 18);
            this.email_value_label.TabIndex = 11;
            this.email_value_label.Text = "example@gmail.com";
            // 
            // contactno_value_label
            // 
            this.contactno_value_label.AutoSize = true;
            this.contactno_value_label.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.contactno_value_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.contactno_value_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.contactno_value_label.Location = new System.Drawing.Point(426, 79);
            this.contactno_value_label.Name = "contactno_value_label";
            this.contactno_value_label.Size = new System.Drawing.Size(88, 18);
            this.contactno_value_label.TabIndex = 13;
            this.contactno_value_label.Text = "1234567890";
            // 
            // ownername_label
            // 
            this.ownername_label.AutoSize = true;
            this.ownername_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ownername_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ownername_label.Location = new System.Drawing.Point(269, 107);
            this.ownername_label.Name = "ownername_label";
            this.ownername_label.Size = new System.Drawing.Size(100, 18);
            this.ownername_label.TabIndex = 14;
            this.ownername_label.Text = "Owner Name:";
            // 
            // ownername_value_label
            // 
            this.ownername_value_label.AutoSize = true;
            this.ownername_value_label.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ownername_value_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.ownername_value_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ownername_value_label.Location = new System.Drawing.Point(444, 110);
            this.ownername_value_label.Name = "ownername_value_label";
            this.ownername_value_label.Size = new System.Drawing.Size(66, 18);
            this.ownername_value_label.TabIndex = 15;
            this.ownername_value_label.Text = "ABCXYZ";
            // 
            // revenue
            // 
          //  this.revenue.Image = global::Database_Project.Properties.Resources.revenue_removebg_preview_removebg_preview;
            this.revenue.Location = new System.Drawing.Point(326, 16);
            this.revenue.Margin = new System.Windows.Forms.Padding(0);
            this.revenue.Name = "revenue";
            this.revenue.Size = new System.Drawing.Size(55, 48);
            this.revenue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.revenue.TabIndex = 18;
            this.revenue.TabStop = false;
            // 
            // Regno_label
            // 
            this.Regno_label.AutoSize = true;
            this.Regno_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Regno_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Regno_label.Location = new System.Drawing.Point(14, 135);
            this.Regno_label.Name = "Regno_label";
            this.Regno_label.Size = new System.Drawing.Size(64, 18);
            this.Regno_label.TabIndex = 19;
            this.Regno_label.Text = "Regno. :";
            // 
            // regnoval_label
            // 
            this.regnoval_label.AutoSize = true;
            this.regnoval_label.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.regnoval_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.regnoval_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.regnoval_label.Location = new System.Drawing.Point(178, 139);
            this.regnoval_label.Name = "regnoval_label";
            this.regnoval_label.Size = new System.Drawing.Size(64, 18);
            this.regnoval_label.TabIndex = 20;
            this.regnoval_label.Text = "5784378";
            // 
            // zip_label
            // 
            this.zip_label.AutoSize = true;
            this.zip_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zip_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.zip_label.Location = new System.Drawing.Point(269, 139);
            this.zip_label.Name = "zip_label";
            this.zip_label.Size = new System.Drawing.Size(76, 18);
            this.zip_label.TabIndex = 21;
            this.zip_label.Text = "Zip Code: ";
            // 
            // zipvalue_label
            // 
            this.zipvalue_label.AutoSize = true;
            this.zipvalue_label.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.zipvalue_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.zipvalue_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.zipvalue_label.Location = new System.Drawing.Point(457, 142);
            this.zipvalue_label.Name = "zipvalue_label";
            this.zipvalue_label.Size = new System.Drawing.Size(48, 18);
            this.zipvalue_label.TabIndex = 22;
            this.zipvalue_label.Text = "46000";
            // 
            // gyminfo_panel
            // 
            this.gyminfo_panel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gyminfo_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gyminfo_panel.Controls.Add(this.zipvalue_label);
            this.gyminfo_panel.Controls.Add(this.zip_label);
            this.gyminfo_panel.Controls.Add(this.regnoval_label);
            this.gyminfo_panel.Controls.Add(this.Regno_label);
            this.gyminfo_panel.Controls.Add(this.revenue);
            this.gyminfo_panel.Controls.Add(this.ownername_value_label);
            this.gyminfo_panel.Controls.Add(this.ownername_label);
            this.gyminfo_panel.Controls.Add(this.contactno_value_label);
            this.gyminfo_panel.Controls.Add(this.email_value_label);
            this.gyminfo_panel.Controls.Add(this.revenue_value_label);
            this.gyminfo_panel.Controls.Add(this.location_value_label);
            this.gyminfo_panel.Controls.Add(this.contact_no_label);
            this.gyminfo_panel.Controls.Add(this.email_label);
            this.gyminfo_panel.Controls.Add(this.location_label);
            this.gyminfo_panel.Controls.Add(this.totalrevenue_label);
            this.gyminfo_panel.Controls.Add(this.gymname_label);
            this.gyminfo_panel.Location = new System.Drawing.Point(14, 15);
            this.gyminfo_panel.Name = "gyminfo_panel";
            this.gyminfo_panel.Size = new System.Drawing.Size(537, 168);
            this.gyminfo_panel.TabIndex = 22;
            // 
            // customer_satisfaction_chart
            // 
            this.customer_satisfaction_chart.BackColor = System.Drawing.SystemColors.ControlLight;
            this.customer_satisfaction_chart.BackImageTransparentColor = System.Drawing.Color.White;
            this.customer_satisfaction_chart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.customer_satisfaction_chart.BorderlineWidth = 0;
            chartArea2.BackColor = System.Drawing.SystemColors.ControlLight;
            chartArea2.Name = "ChartArea1";
            this.customer_satisfaction_chart.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.BorderColor = System.Drawing.Color.White;
            legend2.DockedToChartArea = "ChartArea1";
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.InterlacedRows = true;
            legend2.InterlacedRowsColor = System.Drawing.Color.White;
            legend2.ItemColumnSeparatorColor = System.Drawing.Color.White;
            legend2.ItemColumnSpacing = 40;
            legend2.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
            legend2.Name = "Legend1";
            legend2.TableStyle = System.Windows.Forms.DataVisualization.Charting.LegendTableStyle.Wide;
            legend2.TitleAlignment = System.Drawing.StringAlignment.Near;
            this.customer_satisfaction_chart.Legends.Add(legend2);
            this.customer_satisfaction_chart.Location = new System.Drawing.Point(586, 147);
            this.customer_satisfaction_chart.Name = "customer_satisfaction_chart";
            this.customer_satisfaction_chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.customer_satisfaction_chart.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(160)))), ((int)(((byte)(139))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(188)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(88)))), ((int)(((byte)(127))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(220)))), ((int)(((byte)(205))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(225))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(155)))))};
            series2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            series2.BackSecondaryColor = System.Drawing.Color.LightPink;
            series2.BorderColor = System.Drawing.SystemColors.ControlLight;
            series2.BorderWidth = 4;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.CustomProperties = "DoughnutRadius=70";
            series2.IsValueShownAsLabel = true;
            series2.LabelBorderColor = System.Drawing.Color.Transparent;
            series2.LabelForeColor = System.Drawing.Color.White;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.YValuesPerPoint = 10;
            this.customer_satisfaction_chart.Series.Add(series2);
            this.customer_satisfaction_chart.Size = new System.Drawing.Size(256, 422);
            this.customer_satisfaction_chart.TabIndex = 19;
            this.customer_satisfaction_chart.Text = "chart2";
            title3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            title3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title3.Name = "Title1";
            title3.Text = "Customer Satisfaction";
            this.customer_satisfaction_chart.Titles.Add(title3);
            // 
            // gymratings_panel
            // 
            this.gymratings_panel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gymratings_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gymratings_panel.Controls.Add(this.star5);
            this.gymratings_panel.Controls.Add(this.star4);
            this.gymratings_panel.Controls.Add(this.star3);
            this.gymratings_panel.Controls.Add(this.star2);
            this.gymratings_panel.Controls.Add(this.star1);
            this.gymratings_panel.Controls.Add(this.gym_ratings);
            this.gymratings_panel.Location = new System.Drawing.Point(581, 45);
            this.gymratings_panel.Name = "gymratings_panel";
            this.gymratings_panel.Size = new System.Drawing.Size(264, 80);
            this.gymratings_panel.TabIndex = 23;
            // 
            // star5
            // 
            //this.star5.Image = global::Database_Project.Properties.Resources.grey_star;
            this.star5.Location = new System.Drawing.Point(211, 39);
            this.star5.Name = "star5";
            this.star5.Size = new System.Drawing.Size(38, 33);
            this.star5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.star5.TabIndex = 14;
            this.star5.TabStop = false;
            // 
            // star4
            // 
            this.star4.Image = ((System.Drawing.Image)(resources.GetObject("star4.Image")));
            this.star4.Location = new System.Drawing.Point(162, 40);
            this.star4.Name = "star4";
            this.star4.Size = new System.Drawing.Size(38, 33);
            this.star4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.star4.TabIndex = 13;
            this.star4.TabStop = false;
            // 
            // star3
            // 
            this.star3.Image = ((System.Drawing.Image)(resources.GetObject("star3.Image")));
            this.star3.Location = new System.Drawing.Point(112, 40);
            this.star3.Name = "star3";
            this.star3.Size = new System.Drawing.Size(38, 33);
            this.star3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.star3.TabIndex = 12;
            this.star3.TabStop = false;
            // 
            // star2
            // 
            this.star2.Image = ((System.Drawing.Image)(resources.GetObject("star2.Image")));
            this.star2.Location = new System.Drawing.Point(62, 40);
            this.star2.Name = "star2";
            this.star2.Size = new System.Drawing.Size(38, 33);
            this.star2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.star2.TabIndex = 11;
            this.star2.TabStop = false;
            // 
            // star1
            // 
            this.star1.Image = ((System.Drawing.Image)(resources.GetObject("star1.Image")));
            this.star1.Location = new System.Drawing.Point(13, 39);
            this.star1.Name = "star1";
            this.star1.Size = new System.Drawing.Size(38, 33);
            this.star1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.star1.TabIndex = 10;
            this.star1.TabStop = false;
            // 
            // gym_ratings
            // 
            this.gym_ratings.AutoSize = true;
            this.gym_ratings.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gym_ratings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gym_ratings.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gym_ratings.Location = new System.Drawing.Point(82, 10);
            this.gym_ratings.Name = "gym_ratings";
            this.gym_ratings.Size = new System.Drawing.Size(106, 20);
            this.gym_ratings.TabIndex = 9;
            this.gym_ratings.Text = "Gym Ratings";
            // 
            // GymReportUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.gymratings_panel);
            this.Controls.Add(this.gyminfo_panel);
            this.Controls.Add(this.customer_satisfaction_chart);
            this.Controls.Add(this.revenue_Chart);
            this.Controls.Add(this.gymdetails_panel);
            this.Name = "GymReportUserControl";
            this.Size = new System.Drawing.Size(987, 718);
            ((System.ComponentModel.ISupportInitialize)(this.trainercount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membership_growth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.retentionrate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membercount)).EndInit();
            this.gymdetails_panel.ResumeLayout(false);
            this.gymdetails_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.revenue_Chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.revenue)).EndInit();
            this.gyminfo_panel.ResumeLayout(false);
            this.gyminfo_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customer_satisfaction_chart)).EndInit();
            this.gymratings_panel.ResumeLayout(false);
            this.gymratings_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.star5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.star4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.star3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.star2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.star1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label member_label;
        private System.Windows.Forms.Label trainer_label;
        private System.Windows.Forms.Label retentionrate_label;
        private System.Windows.Forms.Label membership_label;
        private System.Windows.Forms.Label membercount_label;
        private System.Windows.Forms.Label trainercount_label;
        private System.Windows.Forms.Label retentionval_label;
        private System.Windows.Forms.Label membergrowthval_label;
        private System.Windows.Forms.PictureBox trainercount;
        private System.Windows.Forms.PictureBox membership_growth;
        private System.Windows.Forms.PictureBox retentionrate;
        private System.Windows.Forms.PictureBox membercount;
        private System.Windows.Forms.Panel gymdetails_panel;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.DataVisualization.Charting.Chart revenue_Chart;
        private System.Windows.Forms.Label gymname_label;
        private System.Windows.Forms.Label totalrevenue_label;
        private System.Windows.Forms.Label location_label;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.Label contact_no_label;
        private System.Windows.Forms.Label location_value_label;
        private System.Windows.Forms.Label revenue_value_label;
        private System.Windows.Forms.Label email_value_label;
        private System.Windows.Forms.Label contactno_value_label;
        private System.Windows.Forms.Label ownername_label;
        private System.Windows.Forms.Label ownername_value_label;
        private System.Windows.Forms.PictureBox revenue;
        private System.Windows.Forms.Label Regno_label;
        private System.Windows.Forms.Label regnoval_label;
        private System.Windows.Forms.Label zip_label;
        private System.Windows.Forms.Label zipvalue_label;
        private System.Windows.Forms.Panel gyminfo_panel;
        private System.Windows.Forms.DataVisualization.Charting.Chart customer_satisfaction_chart;
        private System.Windows.Forms.Panel gymratings_panel;
        private System.Windows.Forms.PictureBox star5;
        private System.Windows.Forms.PictureBox star4;
        private System.Windows.Forms.PictureBox star3;
        private System.Windows.Forms.PictureBox star2;
        private System.Windows.Forms.PictureBox star1;
        private System.Windows.Forms.Label gym_ratings;
    }
}
