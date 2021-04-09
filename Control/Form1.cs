using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btPort_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen) serialPort1.Close();

            serialPort1.PortName = txtPort.Text;

            try
            {
                serialPort1.Open();
                btStart.Enabled = true;
                btStop.Enabled = true;
                btRevese.Enabled = true;
                hsTocdo.Enabled = true;
                MessageBox.Show("Connect!");

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        //private void timer1_Tick(object sender, EventArgs e)
        //{
        //    if (serialPort1.IsOpen)
        //        if (serialPort1.BytesToRead > 0)
        //        {
        //            txtReceive.Text = serialPort1.ReadExisting();
        //        }
        //}

        //private void btSend_Click(object sender, EventArgs e)
        //{
        //    if (serialPort1.IsOpen)
        //    {
        //        serialPort1.WriteLine(txtSend.Text);
        //    }
        //}

        private void btStart_Click(object sender, EventArgs e)
        {
            txtStatus.Text = "Start";
            if (serialPort1.IsOpen)
            {
                serialPort1.Write(txtStatus.Text);
            }
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            txtStatus.Text = "Stop";
            if (serialPort1.IsOpen)
            {
                serialPort1.Write(txtStatus.Text);
            }
        }

        private void btRevese_Click(object sender, EventArgs e)
        {
            txtStatus.Text = "Reverse";
            if (serialPort1.IsOpen)
            {
                serialPort1.Write(txtStatus.Text);
            }
        }

        private void hsTocdo_Scroll(object sender, ScrollEventArgs e)
        {
            txtSpeed.Text = hsTocdo.Value.ToString();
            if (serialPort1.IsOpen)
            {
                serialPort1.Write(txtSpeed.Text);
            }
        }
    }
}
