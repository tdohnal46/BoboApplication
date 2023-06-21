namespace State_bobo
{
    partial class Cumunikator
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cumunikator));
            this.IP_text = new Guna.UI2.WinForms.Guna2TextBox();
            this.indikator = new Guna.UI2.WinForms.Guna2ProgressIndicator();
            this.start_btn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.konzole = new System.Windows.Forms.RichTextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.nacitani = new System.Windows.Forms.Timer(this.components);
            this.Check_timer = new System.Windows.Forms.Timer(this.components);
            this.hod1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.min1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.min2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.hod2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.save = new Guna.UI2.WinForms.Guna2Button();
            this.Slider_tick = new System.Windows.Forms.Timer(this.components);
            this.slider = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            this.guna2GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // IP_text
            // 
            this.IP_text.BorderRadius = 10;
            this.IP_text.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IP_text.DefaultText = "10.0.0.140";
            this.IP_text.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.IP_text.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.IP_text.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.IP_text.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.IP_text.Enabled = false;
            this.IP_text.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IP_text.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.IP_text.ForeColor = System.Drawing.Color.Black;
            this.IP_text.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IP_text.Location = new System.Drawing.Point(19, 7);
            this.IP_text.Name = "IP_text";
            this.IP_text.PasswordChar = '\0';
            this.IP_text.PlaceholderText = "";
            this.IP_text.SelectedText = "";
            this.IP_text.Size = new System.Drawing.Size(202, 37);
            this.IP_text.TabIndex = 0;
            // 
            // indikator
            // 
            this.indikator.AutoStart = true;
            this.indikator.BackColor = System.Drawing.Color.Transparent;
            this.indikator.Location = new System.Drawing.Point(184, 7);
            this.indikator.Name = "indikator";
            this.indikator.ProgressColor = System.Drawing.Color.Yellow;
            this.indikator.Size = new System.Drawing.Size(37, 37);
            this.indikator.TabIndex = 1;
            this.indikator.UseTransparentBackground = true;
            // 
            // start_btn
            // 
            this.start_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.start_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.start_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.start_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.start_btn.FillColor = System.Drawing.Color.Red;
            this.start_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.start_btn.ForeColor = System.Drawing.Color.White;
            this.start_btn.Location = new System.Drawing.Point(120, 48);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(101, 45);
            this.start_btn.TabIndex = 2;
            this.start_btn.Text = "Zastavit";
            this.start_btn.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(19, 48);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(101, 45);
            this.guna2Button2.TabIndex = 3;
            this.guna2Button2.Text = "Uložit IP";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // konzole
            // 
            this.konzole.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.konzole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.konzole.ForeColor = System.Drawing.SystemColors.Info;
            this.konzole.Location = new System.Drawing.Point(19, 96);
            this.konzole.Name = "konzole";
            this.konzole.ReadOnly = true;
            this.konzole.Size = new System.Drawing.Size(202, 101);
            this.konzole.TabIndex = 4;
            this.konzole.Text = "Probíhá připojování...";
            this.konzole.TextChanged += new System.EventHandler(this.konzole_TextChanged);
            // 
            // timer
            // 
            this.timer.Interval = 20000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // nacitani
            // 
            this.nacitani.Interval = 1000;
            this.nacitani.Tick += new System.EventHandler(this.nacitani_Tick);
            // 
            // Check_timer
            // 
            this.Check_timer.Interval = 60000;
            this.Check_timer.Tick += new System.EventHandler(this.Check_timer_Tick);
            // 
            // hod1
            // 
            this.hod1.BorderRadius = 10;
            this.hod1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.hod1.DefaultText = "09";
            this.hod1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.hod1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.hod1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.hod1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.hod1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.hod1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.hod1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.hod1.Location = new System.Drawing.Point(17, 24);
            this.hod1.Name = "hod1";
            this.hod1.PasswordChar = '\0';
            this.hod1.PlaceholderText = "";
            this.hod1.SelectedText = "";
            this.hod1.Size = new System.Drawing.Size(33, 24);
            this.hod1.TabIndex = 7;
            this.hod1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // min1
            // 
            this.min1.BorderRadius = 10;
            this.min1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.min1.DefaultText = "00";
            this.min1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.min1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.min1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.min1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.min1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.min1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.min1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.min1.Location = new System.Drawing.Point(68, 24);
            this.min1.Name = "min1";
            this.min1.PasswordChar = '\0';
            this.min1.PlaceholderText = "";
            this.min1.SelectedText = "";
            this.min1.Size = new System.Drawing.Size(33, 24);
            this.min1.TabIndex = 10;
            this.min1.TextChanged += new System.EventHandler(this.min1_TextChanged);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(56, 27);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(6, 15);
            this.guna2HtmlLabel2.TabIndex = 11;
            this.guna2HtmlLabel2.Text = ":";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(11, 8);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(98, 15);
            this.guna2HtmlLabel4.TabIndex = 15;
            this.guna2HtmlLabel4.Text = "Alarm zadání obědů";
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(56, 73);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(6, 15);
            this.guna2HtmlLabel6.TabIndex = 19;
            this.guna2HtmlLabel6.Text = ":";
            // 
            // min2
            // 
            this.min2.BorderRadius = 10;
            this.min2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.min2.DefaultText = "21";
            this.min2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.min2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.min2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.min2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.min2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.min2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.min2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.min2.Location = new System.Drawing.Point(68, 70);
            this.min2.Name = "min2";
            this.min2.PasswordChar = '\0';
            this.min2.PlaceholderText = "";
            this.min2.SelectedText = "";
            this.min2.Size = new System.Drawing.Size(33, 24);
            this.min2.TabIndex = 18;
            // 
            // hod2
            // 
            this.hod2.BorderRadius = 10;
            this.hod2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.hod2.DefaultText = "10";
            this.hod2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.hod2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.hod2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.hod2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.hod2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.hod2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.hod2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.hod2.Location = new System.Drawing.Point(17, 70);
            this.hod2.Name = "hod2";
            this.hod2.PasswordChar = '\0';
            this.hod2.PlaceholderText = "";
            this.hod2.SelectedText = "";
            this.hod2.Size = new System.Drawing.Size(33, 24);
            this.hod2.TabIndex = 17;
            this.hod2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.hod2.TextChanged += new System.EventHandler(this.hod2_TextChanged);
            // 
            // save
            // 
            this.save.BorderRadius = 5;
            this.save.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.save.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.save.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.save.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.save.FillColor = System.Drawing.Color.DimGray;
            this.save.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.save.ForeColor = System.Drawing.Color.White;
            this.save.Location = new System.Drawing.Point(3, 43);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(105, 50);
            this.save.TabIndex = 20;
            this.save.Text = "Uložit nastavení";
            this.save.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // Slider_tick
            // 
            this.Slider_tick.Interval = 1;
            this.Slider_tick.Tick += new System.EventHandler(this.Slider_tick_Tick);
            // 
            // slider
            // 
            this.slider.BackColor = System.Drawing.Color.Transparent;
            this.slider.BorderColor = System.Drawing.Color.DarkGray;
            this.slider.BorderRadius = 10;
            this.slider.BorderThickness = 1;
            this.slider.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.slider.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.slider.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.slider.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.slider.FillColor = System.Drawing.Color.White;
            this.slider.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.slider.ForeColor = System.Drawing.Color.White;
            this.slider.Image = global::State_bobo.Properties.Resources.icons8_setting_50;
            this.slider.ImageSize = new System.Drawing.Size(50, 50);
            this.slider.Location = new System.Drawing.Point(236, 2);
            this.slider.Name = "slider";
            this.slider.Size = new System.Drawing.Size(99, 45);
            this.slider.TabIndex = 6;
            this.slider.UseTransparentBackground = true;
            this.slider.Click += new System.EventHandler(this.slider_Click);
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2GroupBox2);
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(344, 2);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(359, 195);
            this.guna2CustomGradientPanel1.TabIndex = 21;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(6, 52);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(113, 15);
            this.guna2HtmlLabel1.TabIndex = 15;
            this.guna2HtmlLabel1.Text = "Alarm objednání obědů";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 5;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.DimGray;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(3, 97);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(105, 50);
            this.guna2Button1.TabIndex = 21;
            this.guna2Button1.Text = "Výchozí nastavení";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.min2);
            this.panel1.Controls.Add(this.guna2HtmlLabel4);
            this.panel1.Controls.Add(this.guna2HtmlLabel1);
            this.panel1.Controls.Add(this.guna2HtmlLabel6);
            this.panel1.Controls.Add(this.guna2HtmlLabel2);
            this.panel1.Controls.Add(this.hod1);
            this.panel1.Controls.Add(this.min1);
            this.panel1.Controls.Add(this.hod2);
            this.panel1.Location = new System.Drawing.Point(9, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(122, 98);
            this.panel1.TabIndex = 22;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.panel1);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(206, 40);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(140, 155);
            this.guna2GroupBox1.TabIndex = 22;
            this.guna2GroupBox1.Text = "Upomínka";
            this.guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.Controls.Add(this.guna2GroupBox1);
            this.guna2GroupBox2.Controls.Add(this.save);
            this.guna2GroupBox2.Controls.Add(this.guna2Button1);
            this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.LightSkyBlue;
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox2.Location = new System.Drawing.Point(0, 0);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.Size = new System.Drawing.Size(359, 195);
            this.guna2GroupBox2.TabIndex = 23;
            this.guna2GroupBox2.Text = "Nastavení";
            // 
            // Cumunikator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(338, 219);
            this.Controls.Add(this.slider);
            this.Controls.Add(this.konzole);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.start_btn);
            this.Controls.Add(this.indikator);
            this.Controls.Add(this.IP_text);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(722, 258);
            this.MinimumSize = new System.Drawing.Size(354, 258);
            this.Name = "Cumunikator";
            this.Text = "BoboApp.Comm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox IP_text;
        private Guna.UI2.WinForms.Guna2ProgressIndicator indikator;
        private Guna.UI2.WinForms.Guna2Button start_btn;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private System.Windows.Forms.RichTextBox konzole;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer nacitani;
        private System.Windows.Forms.Timer Check_timer;
        private Guna.UI2.WinForms.Guna2Button slider;
        private Guna.UI2.WinForms.Guna2TextBox hod1;
        private Guna.UI2.WinForms.Guna2TextBox min1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2TextBox min2;
        private Guna.UI2.WinForms.Guna2TextBox hod2;
        private Guna.UI2.WinForms.Guna2Button save;
        private System.Windows.Forms.Timer Slider_tick;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
    }
}

