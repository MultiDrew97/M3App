using System;
using System.Windows.Forms;
using SPPBC.M3Tools.Events.Listeners;

namespace SPPBC.M3Tools
{

    public partial class DisplayListenersCtrl
    {
        public event ListenerEventHandler RemoveListener;
        public event ListenerEventHandler UpdateListener;
        public event ListenerEventHandler AddListener;
        //public event RefreshDisplayEventHandler RefreshDisplay;

        //public delegate void RefreshDisplayEventHandler();
        public event SendEmailsEventHandler SendEmails;

        public delegate void SendEmailsEventHandler();

        public string CountTemplate { get; set; }

        public BindingSource DataSource
        {
            get
            {
                return ldg_Listeners.DataSource;
            }
            set
            {
                ldg_Listeners.DataSource = value;
            }
        }

        public DisplayListenersCtrl()
        {
            InitializeComponent();
        }

        public void Reload()
        {
            tsl_Count.Text = string.Format(CountTemplate, ldg_Listeners.Listeners.Count);
        }

        private void NewListener(object sender, EventArgs e)
        {
            using (var @add = new Dialogs.AddListenerDialog())
            {
                var res = @add.ShowDialog();

                if (!(res == DialogResult.OK))
                {
                    return;
                }

                AddListener?.Invoke(this, new ListenerEventArgs(@add.Listener));
            }
        }

        private void FilterUpdated(object sender, EventArgs e)
        {
            ldg_Listeners.Filter = txt_Filter.Text;
        }

        private void ImportListeners(object sender, EventArgs e)
        {
            using (var import = new Dialogs.ImportListenersDialog())
            {
                var res = import.ShowDialog();

                if (!(res == DialogResult.OK))
                {
                    return;
                }

                // Using stream
                // TODO: Implement this error handling in all ctrl controls in all places an event is raised by me (i.e customer, orders, inventory)
                // TODO: Properly handle different error types that would prevent listener from being added
                foreach (Types.Listener listener in import.Listeners)
                {
                    try
                    {
                        AddListener?.Invoke(this, new ListenerEventArgs(listener));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Unable to add {listener.Name}", "Listeners Creation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Console.WriteLine(ex.Message);
                        // TODO: Write to output file of failed additions
                    }
                }
                // End Using
            }
        }

        private void DeleteListener(object sender, ListenerEventArgs e)
        {
            var res = MessageBox.Show("Are you sure you want to remove this listener?", "Remove listener", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (!(res == DialogResult.Yes))
            {
                return;
            }

            RemoveListener?.Invoke(sender, e);
        }

        private void OpenEmails(object sender, EventArgs e)
        {
            SendEmails?.Invoke();
        }

        private void EditListener(object sender, ListenerEventArgs e)
        {
            using (var edit = new Dialogs.EditListenerDialog(e.Listener))
            {
                var res = edit.ShowDialog();

                if (!(res == DialogResult.OK))
                {
                    return;
                }

                UpdateListener?.Invoke(this, new ListenerEventArgs(edit.Listener));
            }
        }
    }
}
