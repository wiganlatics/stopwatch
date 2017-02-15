using System;
using System.Windows.Forms;

namespace Stopwatch
{
    public partial class frmStopwatch : Form
    {
        /// <summary>
        /// Form Constructor.
        /// </summary>
        public frmStopwatch()
        {
            InitializeComponent();

            btnSplit.Enabled = false;
            btnStop.Enabled = false;
            btnReset.Enabled = false;
        }

        /// <summary>
        /// Event handler for the start button click event.
        /// </summary>
        /// <param name="sender">The event sender object.</param>
        /// <param name="e">The event arguments.</param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            tmrPress.Enabled = true;
            btnStart.Enabled = false;
            btnSplit.Enabled = true;
            btnStop.Enabled = true;
            btnReset.Enabled = false;
            btnStop.Focus();
        }

        /// <summary>
        /// Event handler for the split button click event.
        /// </summary>
        /// <param name="sender">The event sender object.</param>
        /// <param name="e">The event arguments.</param>
        private void btnSplit_Click(object sender, EventArgs e)
        {
            lblHoursSplit.Text = lblHours.Text;
            lblMinuteTensSplit.Text = lblMinuteTens.Text;
            lblMinutesSplit.Text = lblMinutes.Text;
            lblSecondTensSplit.Text = lblSecondTens.Text;
            lblSecondsSplit.Text = lblSeconds.Text;
            lblTenthSecondsSplit.Text = lblTenthSeconds.Text;
            btnSplit.Focus();
        }

        /// <summary>
        /// Event Handler for the stop button click event.
        /// </summary>
        /// <param name="sender">The event sender object.</param>
        /// <param name="e">The event arguments.</param>
        private void btnStop_Click(object sender, EventArgs e)
        {
            tmrPress.Enabled = false;
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            btnReset.Enabled = true;
            btnStart.Focus();
        }

        /// <summary>
        /// Event handler for the reset button click event.
        /// </summary>
        /// <param name="sender">The event sender object.</param>
        /// <param name="e">The event arguments.</param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            lblTenthSeconds.Text = "0";
            lblSeconds.Text = "0";
            lblSecondTens.Text = "0";
            lblMinutes.Text = "0";
            lblMinuteTens.Text = "0";
            lblHours.Text = "0";
            lblTenthSecondsSplit.Text = "0";
            lblSecondsSplit.Text = "0";
            lblSecondTensSplit.Text = "0";
            lblMinutesSplit.Text = "0";
            lblMinuteTensSplit.Text = "0";
            lblHoursSplit.Text = "0";
            btnSplit.Enabled = false;
            btnStop.Enabled = false;
            btnReset.Enabled = false;
            btnStart.Focus();
        }
        
        /// <summary>
        /// Event Handler for the quit button click event.
        /// </summary>
        /// <param name="sender">The event sender object.</param>
        /// <param name="e">The event arguments.</param>
        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Event Handler for the timer tick event.
        /// </summary>
        /// <param name="sender">The event sender object.</param>
        /// <param name="e">The event arguments.</param>
        private void tmrPress_Tick(object sender, EventArgs e)
        {
            lblTenthSeconds.Text = (int.Parse(lblTenthSeconds.Text) + 1).ToString();
        }

        /// <summary>
        /// Event Handler for the hours label text changed event.
        /// </summary>
        /// <param name="sender">The event sender object.</param>
        /// <param name="e">The event arguments.</param>
        private void lblHours_TextChanged(object sender, EventArgs e)
        {
            if (lblHours.Text == "10")
            {
                lblHours.Text = "0";
            }
        }

        /// <summary>
        /// Event Handler for the tens of minutes label text changed event.
        /// </summary>
        /// <param name="sender">The event sender object.</param>
        /// <param name="e">The event arguments.</param>
        private void lblMinuteTens_TextChanged(object sender, EventArgs e)
        {
            updateLabel(lblMinuteTens, lblHours, "6");
        }

        /// <summary>
        /// Event Handler for the minutes label text changed event.
        /// </summary>
        /// <param name="sender">The event sender object.</param>
        /// <param name="e">The event arguments.</param>
        private void lblMinutes_TextChanged(object sender, EventArgs e)
        {
            updateLabel(lblMinutes, lblMinuteTens, "10");
        }

        /// <summary>
        /// Event Handler for the tens of seconds label text changed event.
        /// </summary>
        /// <param name="sender">The event sender object.</param>
        /// <param name="e">The event arguments.</param>
        private void lblSecondTens_TextChanged(object sender, EventArgs e)
        {
            updateLabel(lblSecondTens, lblMinutes, "6");
        }

        /// <summary>
        /// Event Handler for the seconds label text changed event.
        /// </summary>
        /// <param name="sender">The event sender object.</param>
        /// <param name="e">The event arguments.</param>
        private void lblSeconds_TextChanged(object sender, EventArgs e)
        {
            updateLabel(lblSeconds, lblSecondTens, "10");
        }

        /// <summary>
        /// Event Handler for the tenths of seconds label text changed event.
        /// </summary>
        /// <param name="sender">The event sender object.</param>
        /// <param name="e">The event arguments.</param>
        private void lblTenthSeconds_TextChanged(object sender, EventArgs e)
        {
            updateLabel(lblTenthSeconds, lblSeconds, "10");
        }

        /// <summary>
        /// Triggers the parent label back to zero and increments child label if trigger value is reached.
        /// </summary>
        /// <param name="parent">The label to reset if it reaches trigger value.</param>
        /// <param name="child">The label to increment if parent reaches trigger value.</param>
        /// <param name="triggerValue">Reset parent to zero if it has reached this value.</param>
        private void updateLabel(Label parent, Label child, string triggerValue)
        {
            if (parent.Text == triggerValue)
            {
                parent.Text = "0";
                child.Text = (Int32.Parse(child.Text) + 1).ToString();
            }
        }
    }
}
