namespace DeviceChangeDetection
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.FindDevicesButton = new System.Windows.Forms.Button();
            this.StopWatching = new System.Windows.Forms.Button();
            this.device_label = new System.Windows.Forms.Label();
            this.number_of_devices_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.watcher_status_label = new System.Windows.Forms.Label();
            this.updatedDevicesView = new System.Windows.Forms.DataGridView();
            this.DeviceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsEnabled = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.updatedDevicesView)).BeginInit();
            this.SuspendLayout();
            // 
            // FindDevicesButton
            // 
            this.FindDevicesButton.Location = new System.Drawing.Point(12, 52);
            this.FindDevicesButton.Name = "FindDevicesButton";
            this.FindDevicesButton.Size = new System.Drawing.Size(211, 23);
            this.FindDevicesButton.TabIndex = 0;
            this.FindDevicesButton.Text = "Watch Devices";
            this.FindDevicesButton.UseVisualStyleBackColor = true;
            this.FindDevicesButton.Click += new System.EventHandler(this.StartWatching_Click);
            // 
            // StopWatching
            // 
            this.StopWatching.Location = new System.Drawing.Point(12, 81);
            this.StopWatching.Name = "StopWatching";
            this.StopWatching.Size = new System.Drawing.Size(211, 23);
            this.StopWatching.TabIndex = 1;
            this.StopWatching.Text = "Stop Watching";
            this.StopWatching.UseVisualStyleBackColor = true;
            this.StopWatching.Click += new System.EventHandler(this.StopWatching_Click);
            // 
            // device_label
            // 
            this.device_label.AutoSize = true;
            this.device_label.Location = new System.Drawing.Point(12, 25);
            this.device_label.Name = "device_label";
            this.device_label.Size = new System.Drawing.Size(82, 13);
            this.device_label.TabIndex = 2;
            this.device_label.Text = "Devices Found:";
            // 
            // number_of_devices_label
            // 
            this.number_of_devices_label.AutoSize = true;
            this.number_of_devices_label.Location = new System.Drawing.Point(101, 25);
            this.number_of_devices_label.Name = "number_of_devices_label";
            this.number_of_devices_label.Size = new System.Drawing.Size(13, 13);
            this.number_of_devices_label.TabIndex = 3;
            this.number_of_devices_label.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Status:";
            // 
            // watcher_status_label
            // 
            this.watcher_status_label.AutoSize = true;
            this.watcher_status_label.Location = new System.Drawing.Point(58, 12);
            this.watcher_status_label.Name = "watcher_status_label";
            this.watcher_status_label.Size = new System.Drawing.Size(27, 13);
            this.watcher_status_label.TabIndex = 5;
            this.watcher_status_label.Text = "N/A";
            // 
            // updatedDevicesView
            // 
            this.updatedDevicesView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.updatedDevicesView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DeviceName,
            this.ID,
            this.IsEnabled,
            this.Type});
            this.updatedDevicesView.Location = new System.Drawing.Point(229, 12);
            this.updatedDevicesView.Name = "updatedDevicesView";
            this.updatedDevicesView.Size = new System.Drawing.Size(593, 427);
            this.updatedDevicesView.TabIndex = 6;
            this.updatedDevicesView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // DeviceName
            // 
            this.DeviceName.HeaderText = "Device Name";
            this.DeviceName.Name = "DeviceName";
            this.DeviceName.Width = 200;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // IsEnabled
            // 
            this.IsEnabled.HeaderText = "IsEnabled";
            this.IsEnabled.Name = "IsEnabled";
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.updatedDevicesView);
            this.Controls.Add(this.watcher_status_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.number_of_devices_label);
            this.Controls.Add(this.device_label);
            this.Controls.Add(this.StopWatching);
            this.Controls.Add(this.FindDevicesButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "Device Change Detector";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.updatedDevicesView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FindDevicesButton;
        private System.Windows.Forms.Button StopWatching;
        private System.Windows.Forms.Label device_label;
        private System.Windows.Forms.Label number_of_devices_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label watcher_status_label;
        private System.Windows.Forms.DataGridView updatedDevicesView;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeviceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsEnabled;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
    }
}

