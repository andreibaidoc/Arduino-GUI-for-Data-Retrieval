using System;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;

namespace Arduino_GUI_for_Data_Retrieval
{
    public partial class Form1 : Form
    {
        // Variables
        private bool connected_usb = false;
        private bool connected_bluetooth = false;

        public Form1()
        {
            InitializeComponent();
            InitializeParameters();
        }

        private void InitializeParameters()
        {
            status_label.Visible = false; // make the status label invisible at the start - status label for USB connection
            bluetooth_status_label.Visible = false; // make the bluetooth status label invisible at the start - status label for Bluetooth connection
        }

        private void PopulatePortLists()
        {
            // get ALL COM ports
            var ports = SerialPort.GetPortNames();

            // USB list
            comboBoxUsbPorts.Items.Clear();
            comboBoxUsbPorts.Items.AddRange(ports);
            if (comboBoxUsbPorts.Items.Count > 0)
                comboBoxUsbPorts.SelectedIndex = 0;

            // BT list (same ports – after you pair your HC-05 it shows up here too)
            comboBoxBTPorts.Items.Clear();
            comboBoxBTPorts.Items.AddRange(ports);
            if (comboBoxBTPorts.Items.Count > 0)
                comboBoxBTPorts.SelectedIndex = 0;
        }

        private void connect_usb_button_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = comboBoxUsbPorts.Text;
                serialPort1.BaudRate = 9600;
                serialPort1.Open();

                status_label.Text = "Status: Connected!";
                status_label.ForeColor = Color.Green;
                status_label.Visible = true;
                connected_usb = true;
            }
            catch (Exception ex)
            {
                status_label.Text = $"Could not open USB port: {ex.Message}";
                status_label.ForeColor = Color.Red;
                status_label.Visible = true;
            }
        }

        private void connect_bluetooth_button_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort2.PortName = comboBoxBTPorts.Text;
                serialPort2.BaudRate = 9600;
                serialPort2.Open();

                bluetooth_status_label.Text = "BT: Connected!";
                bluetooth_status_label.ForeColor = Color.Green;
                bluetooth_status_label.Visible = true;
                connected_bluetooth = true;
            }
            catch (Exception ex)
            {
                bluetooth_status_label.Text = $"Could not open BT port: {ex.Message}";
                bluetooth_status_label.ForeColor = Color.Red;
                bluetooth_status_label.Visible = true;
            }
        }

        private void refresh_com_list_button_Click(object sender, EventArgs e)
        {
            PopulatePortLists();
        }
    }
}
