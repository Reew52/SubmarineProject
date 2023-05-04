using Google.Protobuf.WellKnownTypes;
using SubmarineProject.Methods;
using System.Net.Sockets;
using System.Reflection;
using System.Text;

namespace SubmarineProject
{
    public partial class Form1 : Form
    {
        private TcpClient client;
        private NetworkStream stream;
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
        }



        private void aGauge1_ValueInRangeChanged(object sender, ValueInRangeChangedEventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void TxT_Error_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxT_submarinUpDown1.Text))
            {
                TxT_Error.Text = "Cannot be null at UpdownSubMarin";
            }
        }
        protected override bool IsInputKey(Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Up:
                    submarinUpDown.Value++;
                    break;
                case Keys.Down:
                    submarinUpDown.Value++;
                    break;
                default:
                    break;
            }
            return base.IsInputKey(keyData);
        }

        private void TxT_submarinUpDown_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Up)
            {
                submarinUpDown.Value += 10.0f;
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Down)
            {
                submarinUpDown.Value -= 10.0f;
                e.Handled = true;
            }
            TxT_submarinUpDown.Text = submarinUpDown.Value.ToString();
        }

        private void ArduinoConnect_Click(object sender, EventArgs e)
        {
            try
            {
                // Connect to the Arduino Ethernet Shield
                client = new TcpClient("10.11.12.10", 23);
                stream = client.GetStream();

                // Enable all controls
                EnableControls(true);

                // Start receiving data from the Arduino
                ReceiveData();

                // Send a message to the server
                string message = "Hello, Arduino!";
                byte[] data = Encoding.ASCII.GetBytes(message);
                stream.Write(data, 0, data.Length);
            }
            catch
            {
                // Unable to connect to the Arduino, disable all controls
                EnableControls(false);
            }

        }
        private async void ReceiveData()
        {
            // Continuously receive data from the Arduino
            while (true)
            {
                try
                {
                    byte[] buffer = new byte[1024];
                    int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);

                    if (bytesRead > 0)
                    {
                        string data = System.Text.Encoding.ASCII.GetString(buffer, 0, bytesRead);
                        // Process received data here
                        // ...
                    }
                }
                catch
                {
                    // Disconnected from the Arduino, disable all controls
                    EnableControls(false);
                    break;
                }
            }
        }

        private void EnableControls(bool enable)
        {
            // Enable or disable all controls on the form except the Connect button
            foreach (Control control in Controls)
            {
                if (control != ArduinoConnect)
                {
                    control.Enabled = enable;
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Disconnect from the Arduino when the form is closed
            if (client != null)
            {
                client.Close();
            }
        }

        private void TxT_ArduinoConnect_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the text from the TextBox
                string message = TxT_ArduinoConnect.Text;

                // Send the message to the Arduino
                byte[] data = Encoding.ASCII.GetBytes(message);
                stream.Write(data, 0, data.Length);
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                Console.WriteLine(ex.Message);
            }
        }
    }
}