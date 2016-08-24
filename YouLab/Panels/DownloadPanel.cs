using System;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Controls;
using Transitions;
using MetroFramework;

namespace YouLab.Panels
{
    public partial class DownloadPanel : MetroUserControl
    {
        private Form mainForm;
        private bool loaded;

        public event EventHandler Shown;
        public event EventHandler Closed;

        public DownloadPanel()
        {
            InitializeComponent();
            this.CancelDownload = false;
        }

        public DownloadPanel(Form mainForm)
            : this()
        {
            this.Visible = false;

            this.mainForm = mainForm;
            this.mainForm.Controls.Add(this);
            this.BringToFront();

            ResizePanel();
        }

        public bool CancelDownload { get; set; }

        public MetroProgressBar PrograssBar { get { return this.progressBar; } }

        public MetroLabel DownloadStatus { get { return this.downloadingStatusLabel; } }

        public MetroLabel TotalDownload { get { return this.totalDownloadLabel; } }

        public MetroLabel DownloadPercents { get { return this.downloadPercentage; } }

        public MetroProgressSpinner Spinner { get { return this.metroProgressSpinner1; } }

        public MetroLabel StatusLabel { get { return this.statusLabel; } set { this.statusLabel = value; } }

        public MetroGrid StatusGrid { get { return this.metroGrid1; } }

        public MetroLink BackLink { get { return this.backLink; } }

        private void ResizePanel()
        {
            this.Width = this.mainForm.Width;
            this.Height = this.mainForm.Height;
            this.Location = new Point(this.loaded ? 0 : this.mainForm.Width, 125);
        }
        
        public void Swipe(bool show = true)
        {
           
            this.Visible = true;
            Transition transition = new Transition(new TransitionType_Acceleration(1000));
            transition.add(this, "Left", show ? 0 : this.mainForm.Width);
            transition.run();

            while (this.Left != (show ? 0 : this.Width))
            {
                Application.DoEvents();
            }

            if (!show)
            {
                closed(new EventArgs());
                this.mainForm.Controls.Remove(this);
                this.Dispose();
            }
            else
            {
                this.loaded = true;
                this.ResizePanel();
                shown(new EventArgs());
            }
        }

        protected virtual void closed(EventArgs e)
        {
            EventHandler handler = Closed;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        protected virtual void shown(EventArgs e)
        {
            EventHandler handler = Shown;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        private void closeLinkLabel_Click(object sender, EventArgs e)
        {
            this.CancelDownload = true;
        }

        private void backLink_Click(object sender, EventArgs e)
        {
            this.Swipe(false);
        }
    }
}