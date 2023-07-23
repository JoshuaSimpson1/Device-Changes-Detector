using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Windows.Devices.Enumeration;

namespace DeviceChangeDetection
{
    public partial class MainWindow : Form
    { 
        DeviceWatcher watcher;
        List<DeviceInformation> devices = new List<DeviceInformation>();
        List<DeviceInformation> updatedDevices = new List<DeviceInformation>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void StartWatching_Click(object sender, EventArgs e)
        {
            if (watcher != null && watcher.Status == DeviceWatcherStatus.EnumerationCompleted)
            {
                watcher_status_label.Text = "Watcher Already Started";
                return;
            }
            // Creates a watcher for all device types
            watcher = DeviceInformation.CreateWatcher();
            watcher_status_label.Text = "Watcher Started";
            // Register Events for our watcher, since the start will fire
            // the add event until we are done finding all devices
            watcher.Added += Watcher_Added;
            watcher.Removed += Watcher_Removed;
            watcher.Updated += Watcher_Updated;
            watcher.EnumerationCompleted += Watcher_EnumerationCompleted;

            // Start the process of watching all found devices
            watcher.Start();
        }

        private void Watcher_Updated(DeviceWatcher sender, DeviceInformationUpdate args)
        {
            foreach(DeviceInformation device in devices)
            {
                // We have the same device that was changed then update it and add it
                // to the changed list
                if(device.Id == args.Id)
                {
                    device.Update(args);
                    updatedDevices.Add(device);
                    updatedDevicesView.Invoke(new MethodInvoker(delegate
                    {
                        updatedDevicesView.Rows.Add(device.Name, device.Id, device.IsEnabled, device.Kind);
                    }));

                }
            }
        }

        private void Watcher_Removed(DeviceWatcher sender, DeviceInformationUpdate args)
        {
            throw new NotImplementedException();
        }

        private void Watcher_EnumerationCompleted(DeviceWatcher sender, object args)
        {

            number_of_devices_label.Invoke(new MethodInvoker(delegate
            {
                number_of_devices_label.Text = devices.Count.ToString();
            }));

            if (watcher.Status == DeviceWatcherStatus.EnumerationCompleted)
            {
                watcher_status_label.Invoke(new MethodInvoker(delegate
                {
                    watcher_status_label.Text = "Watcher Enumeration Complete";
                }));
            }
        }

        private void Watcher_Added(DeviceWatcher sender, DeviceInformation args)
        {
            devices.Add(args);
        }

        private void StopWatching_Click(object sender, EventArgs e)
        {
            if(watcher.Status == DeviceWatcherStatus.Stopped)
            {
                watcher_status_label.Text = "Watcher Already Stopped";
            } else
            {
                watcher.Stop();
                devices.Clear();
                number_of_devices_label.Text = devices.Count.ToString();
                watcher_status_label.Text = "Watcher Stopped";
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
