namespace Arduino_GUI_for_Data_Retrieval
{
    partial class Form1
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
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.connect_usb_button = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.SubtitleDescriptionLabel = new System.Windows.Forms.Label();
            this.connections_label = new System.Windows.Forms.Label();
            this.status_label = new System.Windows.Forms.Label();
            this.connect_bluetooth_button = new System.Windows.Forms.Button();
            this.bluetooth_status_label = new System.Windows.Forms.Label();
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.comboBoxUsbPorts = new System.Windows.Forms.ComboBox();
            this.comboBoxBTPorts = new System.Windows.Forms.ComboBox();
            this.refresh_com_list_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM3";
            // 
            // connect_usb_button
            // 
            this.connect_usb_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connect_usb_button.Location = new System.Drawing.Point(56, 246);
            this.connect_usb_button.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.connect_usb_button.Name = "connect_usb_button";
            this.connect_usb_button.Size = new System.Drawing.Size(242, 40);
            this.connect_usb_button.TabIndex = 0;
            this.connect_usb_button.Text = "Connect via USB";
            this.connect_usb_button.UseVisualStyleBackColor = true;
            this.connect_usb_button.Click += new System.EventHandler(this.connect_usb_button_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(35, 44);
            this.Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(364, 32);
            this.Title.TabIndex = 1;
            this.Title.Text = "Explorover Data Retriever";
            // 
            // SubtitleDescriptionLabel
            // 
            this.SubtitleDescriptionLabel.AutoSize = true;
            this.SubtitleDescriptionLabel.Location = new System.Drawing.Point(35, 85);
            this.SubtitleDescriptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SubtitleDescriptionLabel.Name = "SubtitleDescriptionLabel";
            this.SubtitleDescriptionLabel.Size = new System.Drawing.Size(584, 69);
            this.SubtitleDescriptionLabel.TabIndex = 2;
            this.SubtitleDescriptionLabel.Text = "This program lets the user retrieve the data from the ExploRover \r\nthrough difere" +
    "nt methods, such that the user can import, visualize \r\nand examine the humidity," +
    " temperature and pressure parameters.";
            // 
            // connections_label
            // 
            this.connections_label.AutoSize = true;
            this.connections_label.Location = new System.Drawing.Point(35, 195);
            this.connections_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.connections_label.Name = "connections_label";
            this.connections_label.Size = new System.Drawing.Size(182, 23);
            this.connections_label.TabIndex = 3;
            this.connections_label.Text = "Connection options:";
            // 
            // status_label
            // 
            this.status_label.AutoSize = true;
            this.status_label.Location = new System.Drawing.Point(327, 255);
            this.status_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.status_label.Name = "status_label";
            this.status_label.Size = new System.Drawing.Size(72, 23);
            this.status_label.TabIndex = 4;
            this.status_label.Text = "Status:";
            // 
            // connect_bluetooth_button
            // 
            this.connect_bluetooth_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connect_bluetooth_button.Location = new System.Drawing.Point(56, 350);
            this.connect_bluetooth_button.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.connect_bluetooth_button.Name = "connect_bluetooth_button";
            this.connect_bluetooth_button.Size = new System.Drawing.Size(242, 40);
            this.connect_bluetooth_button.TabIndex = 5;
            this.connect_bluetooth_button.Text = "Connect via Bluetooth";
            this.connect_bluetooth_button.UseVisualStyleBackColor = true;
            this.connect_bluetooth_button.Click += new System.EventHandler(this.connect_bluetooth_button_Click);
            // 
            // bluetooth_status_label
            // 
            this.bluetooth_status_label.AutoSize = true;
            this.bluetooth_status_label.Location = new System.Drawing.Point(327, 359);
            this.bluetooth_status_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bluetooth_status_label.Name = "bluetooth_status_label";
            this.bluetooth_status_label.Size = new System.Drawing.Size(72, 23);
            this.bluetooth_status_label.TabIndex = 6;
            this.bluetooth_status_label.Text = "Status:";
            // 
            // comboBoxUsbPorts
            // 
            this.comboBoxUsbPorts.FormattingEnabled = true;
            this.comboBoxUsbPorts.Location = new System.Drawing.Point(56, 292);
            this.comboBoxUsbPorts.Name = "comboBoxUsbPorts";
            this.comboBoxUsbPorts.Size = new System.Drawing.Size(242, 31);
            this.comboBoxUsbPorts.TabIndex = 7;
            // 
            // comboBoxBTPorts
            // 
            this.comboBoxBTPorts.FormattingEnabled = true;
            this.comboBoxBTPorts.Location = new System.Drawing.Point(56, 397);
            this.comboBoxBTPorts.Name = "comboBoxBTPorts";
            this.comboBoxBTPorts.Size = new System.Drawing.Size(242, 31);
            this.comboBoxBTPorts.TabIndex = 8;
            // 
            // refresh_com_list_button
            // 
            this.refresh_com_list_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh_com_list_button.Location = new System.Drawing.Point(56, 470);
            this.refresh_com_list_button.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.refresh_com_list_button.Name = "refresh_com_list_button";
            this.refresh_com_list_button.Size = new System.Drawing.Size(242, 40);
            this.refresh_com_list_button.TabIndex = 9;
            this.refresh_com_list_button.Text = "Refresh COM List";
            this.refresh_com_list_button.UseVisualStyleBackColor = true;
            this.refresh_com_list_button.Click += new System.EventHandler(this.refresh_com_list_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1178, 744);
            this.Controls.Add(this.refresh_com_list_button);
            this.Controls.Add(this.comboBoxBTPorts);
            this.Controls.Add(this.comboBoxUsbPorts);
            this.Controls.Add(this.bluetooth_status_label);
            this.Controls.Add(this.connect_bluetooth_button);
            this.Controls.Add(this.status_label);
            this.Controls.Add(this.connections_label);
            this.Controls.Add(this.SubtitleDescriptionLabel);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.connect_usb_button);
            this.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Explorover Data Retriever";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button connect_usb_button;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label SubtitleDescriptionLabel;
        private System.Windows.Forms.Label connections_label;
        private System.Windows.Forms.Label status_label;
        private System.Windows.Forms.Button connect_bluetooth_button;
        private System.Windows.Forms.Label bluetooth_status_label;
        private System.IO.Ports.SerialPort serialPort2;
        private System.Windows.Forms.ComboBox comboBoxUsbPorts;
        private System.Windows.Forms.ComboBox comboBoxBTPorts;
        private System.Windows.Forms.Button refresh_com_list_button;
    }
}

