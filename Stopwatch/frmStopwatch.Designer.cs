namespace Stopwatch
{
    partial class frmStopwatch
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnSplit = new System.Windows.Forms.Button();
            this.tmrPress = new System.Windows.Forms.Timer(this.components);
            this.pnlTime = new System.Windows.Forms.Panel();
            this.lblHoursSplit = new System.Windows.Forms.Label();
            this.lblHoursDelimiterSplit = new System.Windows.Forms.Label();
            this.lblMinuteTensSplit = new System.Windows.Forms.Label();
            this.lblMinutesSplit = new System.Windows.Forms.Label();
            this.lblMinutesDelimiterSplit = new System.Windows.Forms.Label();
            this.lblSecondTensSplit = new System.Windows.Forms.Label();
            this.lblSecondsSplit = new System.Windows.Forms.Label();
            this.lblSecondsDelimiterSplit = new System.Windows.Forms.Label();
            this.lblTenthSecondsSplit = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblHoursDelimiter = new System.Windows.Forms.Label();
            this.lblMinuteTens = new System.Windows.Forms.Label();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.lblMinutesDelimiter = new System.Windows.Forms.Label();
            this.lblSecondTens = new System.Windows.Forms.Label();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.lblSecondsDelimiter = new System.Windows.Forms.Label();
            this.lblTenthSeconds = new System.Windows.Forms.Label();
            this.pnlTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(414, 26);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(89, 40);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start/Continue";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(414, 210);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(89, 40);
            this.btnQuit.TabIndex = 5;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(414, 164);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(89, 40);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(414, 118);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(89, 40);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnSplit
            // 
            this.btnSplit.Location = new System.Drawing.Point(414, 72);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(89, 40);
            this.btnSplit.TabIndex = 2;
            this.btnSplit.Text = "Split";
            this.btnSplit.UseVisualStyleBackColor = true;
            this.btnSplit.Click += new System.EventHandler(this.btnSplit_Click);
            // 
            // tmrPress
            // 
            this.tmrPress.Tick += new System.EventHandler(this.tmrPress_Tick);
            // 
            // pnlTime
            // 
            this.pnlTime.Controls.Add(this.lblHoursSplit);
            this.pnlTime.Controls.Add(this.lblHoursDelimiterSplit);
            this.pnlTime.Controls.Add(this.lblMinuteTensSplit);
            this.pnlTime.Controls.Add(this.lblMinutesSplit);
            this.pnlTime.Controls.Add(this.lblMinutesDelimiterSplit);
            this.pnlTime.Controls.Add(this.lblSecondTensSplit);
            this.pnlTime.Controls.Add(this.lblSecondsSplit);
            this.pnlTime.Controls.Add(this.lblSecondsDelimiterSplit);
            this.pnlTime.Controls.Add(this.lblTenthSecondsSplit);
            this.pnlTime.Controls.Add(this.lblHours);
            this.pnlTime.Controls.Add(this.lblHoursDelimiter);
            this.pnlTime.Controls.Add(this.lblMinuteTens);
            this.pnlTime.Controls.Add(this.lblMinutes);
            this.pnlTime.Controls.Add(this.lblMinutesDelimiter);
            this.pnlTime.Controls.Add(this.lblSecondTens);
            this.pnlTime.Controls.Add(this.lblSeconds);
            this.pnlTime.Controls.Add(this.lblSecondsDelimiter);
            this.pnlTime.Controls.Add(this.lblTenthSeconds);
            this.pnlTime.Location = new System.Drawing.Point(12, 12);
            this.pnlTime.Name = "pnlTime";
            this.pnlTime.Size = new System.Drawing.Size(396, 238);
            this.pnlTime.TabIndex = 0;
            // 
            // lblHoursSplit
            // 
            this.lblHoursSplit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHoursSplit.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoursSplit.Location = new System.Drawing.Point(3, 60);
            this.lblHoursSplit.Name = "lblHoursSplit";
            this.lblHoursSplit.Size = new System.Drawing.Size(43, 40);
            this.lblHoursSplit.TabIndex = 0;
            this.lblHoursSplit.Text = "0";
            this.lblHoursSplit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHoursDelimiterSplit
            // 
            this.lblHoursDelimiterSplit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHoursDelimiterSplit.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoursDelimiterSplit.Location = new System.Drawing.Point(46, 60);
            this.lblHoursDelimiterSplit.Name = "lblHoursDelimiterSplit";
            this.lblHoursDelimiterSplit.Size = new System.Drawing.Size(43, 40);
            this.lblHoursDelimiterSplit.TabIndex = 0;
            this.lblHoursDelimiterSplit.Text = ":";
            this.lblHoursDelimiterSplit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMinuteTensSplit
            // 
            this.lblMinuteTensSplit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMinuteTensSplit.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinuteTensSplit.Location = new System.Drawing.Point(89, 60);
            this.lblMinuteTensSplit.Name = "lblMinuteTensSplit";
            this.lblMinuteTensSplit.Size = new System.Drawing.Size(43, 40);
            this.lblMinuteTensSplit.TabIndex = 0;
            this.lblMinuteTensSplit.Text = "0";
            this.lblMinuteTensSplit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMinutesSplit
            // 
            this.lblMinutesSplit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMinutesSplit.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinutesSplit.Location = new System.Drawing.Point(132, 60);
            this.lblMinutesSplit.Name = "lblMinutesSplit";
            this.lblMinutesSplit.Size = new System.Drawing.Size(43, 40);
            this.lblMinutesSplit.TabIndex = 0;
            this.lblMinutesSplit.Text = "0";
            this.lblMinutesSplit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMinutesDelimiterSplit
            // 
            this.lblMinutesDelimiterSplit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMinutesDelimiterSplit.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinutesDelimiterSplit.Location = new System.Drawing.Point(175, 60);
            this.lblMinutesDelimiterSplit.Name = "lblMinutesDelimiterSplit";
            this.lblMinutesDelimiterSplit.Size = new System.Drawing.Size(43, 40);
            this.lblMinutesDelimiterSplit.TabIndex = 0;
            this.lblMinutesDelimiterSplit.Text = ":";
            this.lblMinutesDelimiterSplit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSecondTensSplit
            // 
            this.lblSecondTensSplit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSecondTensSplit.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondTensSplit.Location = new System.Drawing.Point(218, 60);
            this.lblSecondTensSplit.Name = "lblSecondTensSplit";
            this.lblSecondTensSplit.Size = new System.Drawing.Size(43, 40);
            this.lblSecondTensSplit.TabIndex = 0;
            this.lblSecondTensSplit.Text = "0";
            this.lblSecondTensSplit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSecondsSplit
            // 
            this.lblSecondsSplit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSecondsSplit.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondsSplit.Location = new System.Drawing.Point(261, 60);
            this.lblSecondsSplit.Name = "lblSecondsSplit";
            this.lblSecondsSplit.Size = new System.Drawing.Size(43, 40);
            this.lblSecondsSplit.TabIndex = 0;
            this.lblSecondsSplit.Text = "0";
            this.lblSecondsSplit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSecondsDelimiterSplit
            // 
            this.lblSecondsDelimiterSplit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSecondsDelimiterSplit.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondsDelimiterSplit.Location = new System.Drawing.Point(304, 60);
            this.lblSecondsDelimiterSplit.Name = "lblSecondsDelimiterSplit";
            this.lblSecondsDelimiterSplit.Size = new System.Drawing.Size(43, 40);
            this.lblSecondsDelimiterSplit.TabIndex = 0;
            this.lblSecondsDelimiterSplit.Text = ":";
            this.lblSecondsDelimiterSplit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTenthSecondsSplit
            // 
            this.lblTenthSecondsSplit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTenthSecondsSplit.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenthSecondsSplit.Location = new System.Drawing.Point(347, 60);
            this.lblTenthSecondsSplit.Name = "lblTenthSecondsSplit";
            this.lblTenthSecondsSplit.Size = new System.Drawing.Size(43, 40);
            this.lblTenthSecondsSplit.TabIndex = 0;
            this.lblTenthSecondsSplit.Text = "0";
            this.lblTenthSecondsSplit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHours
            // 
            this.lblHours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHours.Location = new System.Drawing.Point(3, 8);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(43, 40);
            this.lblHours.TabIndex = 0;
            this.lblHours.Text = "0";
            this.lblHours.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHours.TextChanged += new System.EventHandler(this.lblHours_TextChanged);
            // 
            // lblHoursDelimiter
            // 
            this.lblHoursDelimiter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHoursDelimiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoursDelimiter.Location = new System.Drawing.Point(46, 8);
            this.lblHoursDelimiter.Name = "lblHoursDelimiter";
            this.lblHoursDelimiter.Size = new System.Drawing.Size(43, 40);
            this.lblHoursDelimiter.TabIndex = 0;
            this.lblHoursDelimiter.Text = ":";
            this.lblHoursDelimiter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMinuteTens
            // 
            this.lblMinuteTens.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMinuteTens.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinuteTens.Location = new System.Drawing.Point(89, 8);
            this.lblMinuteTens.Name = "lblMinuteTens";
            this.lblMinuteTens.Size = new System.Drawing.Size(43, 40);
            this.lblMinuteTens.TabIndex = 0;
            this.lblMinuteTens.Text = "0";
            this.lblMinuteTens.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMinuteTens.TextChanged += new System.EventHandler(this.lblMinuteTens_TextChanged);
            // 
            // lblMinutes
            // 
            this.lblMinutes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinutes.Location = new System.Drawing.Point(132, 8);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(43, 40);
            this.lblMinutes.TabIndex = 0;
            this.lblMinutes.Text = "0";
            this.lblMinutes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMinutes.TextChanged += new System.EventHandler(this.lblMinutes_TextChanged);
            // 
            // lblMinutesDelimiter
            // 
            this.lblMinutesDelimiter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMinutesDelimiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinutesDelimiter.Location = new System.Drawing.Point(175, 8);
            this.lblMinutesDelimiter.Name = "lblMinutesDelimiter";
            this.lblMinutesDelimiter.Size = new System.Drawing.Size(43, 40);
            this.lblMinutesDelimiter.TabIndex = 0;
            this.lblMinutesDelimiter.Text = ":";
            this.lblMinutesDelimiter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSecondTens
            // 
            this.lblSecondTens.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSecondTens.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondTens.Location = new System.Drawing.Point(218, 8);
            this.lblSecondTens.Name = "lblSecondTens";
            this.lblSecondTens.Size = new System.Drawing.Size(43, 40);
            this.lblSecondTens.TabIndex = 0;
            this.lblSecondTens.Text = "0";
            this.lblSecondTens.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSecondTens.TextChanged += new System.EventHandler(this.lblSecondTens_TextChanged);
            // 
            // lblSeconds
            // 
            this.lblSeconds.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeconds.Location = new System.Drawing.Point(261, 8);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(43, 40);
            this.lblSeconds.TabIndex = 0;
            this.lblSeconds.Text = "0";
            this.lblSeconds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSeconds.TextChanged += new System.EventHandler(this.lblSeconds_TextChanged);
            // 
            // lblSecondsDelimiter
            // 
            this.lblSecondsDelimiter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSecondsDelimiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondsDelimiter.Location = new System.Drawing.Point(304, 8);
            this.lblSecondsDelimiter.Name = "lblSecondsDelimiter";
            this.lblSecondsDelimiter.Size = new System.Drawing.Size(43, 40);
            this.lblSecondsDelimiter.TabIndex = 0;
            this.lblSecondsDelimiter.Text = ":";
            this.lblSecondsDelimiter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTenthSeconds
            // 
            this.lblTenthSeconds.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTenthSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenthSeconds.Location = new System.Drawing.Point(347, 8);
            this.lblTenthSeconds.Name = "lblTenthSeconds";
            this.lblTenthSeconds.Size = new System.Drawing.Size(43, 40);
            this.lblTenthSeconds.TabIndex = 0;
            this.lblTenthSeconds.Text = "0";
            this.lblTenthSeconds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTenthSeconds.TextChanged += new System.EventHandler(this.lblTenthSeconds_TextChanged);
            // 
            // frmStopwatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(515, 274);
            this.Controls.Add(this.pnlTime);
            this.Controls.Add(this.btnSplit);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStopwatch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stopwatch";
            this.pnlTime.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnSplit;
        private System.Windows.Forms.Timer tmrPress;
        private System.Windows.Forms.Panel pnlTime;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label lblHoursDelimiter;
        private System.Windows.Forms.Label lblMinuteTens;
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.Label lblMinutesDelimiter;
        private System.Windows.Forms.Label lblSecondTens;
        private System.Windows.Forms.Label lblSeconds;
        private System.Windows.Forms.Label lblSecondsDelimiter;
        private System.Windows.Forms.Label lblTenthSeconds;
        private System.Windows.Forms.Label lblHoursSplit;
        private System.Windows.Forms.Label lblHoursDelimiterSplit;
        private System.Windows.Forms.Label lblMinuteTensSplit;
        private System.Windows.Forms.Label lblMinutesSplit;
        private System.Windows.Forms.Label lblMinutesDelimiterSplit;
        private System.Windows.Forms.Label lblSecondTensSplit;
        private System.Windows.Forms.Label lblSecondsSplit;
        private System.Windows.Forms.Label lblSecondsDelimiterSplit;
        private System.Windows.Forms.Label lblTenthSecondsSplit;
    }
}

