
namespace Control
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
            this.btStart = new System.Windows.Forms.Button();
            this.btStop = new System.Windows.Forms.Button();
            this.btRevese = new System.Windows.Forms.Button();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.btPort = new System.Windows.Forms.Button();
            this.hsTocdo = new System.Windows.Forms.HScrollBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtSpeed = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btStart
            // 
            this.btStart.Enabled = false;
            this.btStart.Location = new System.Drawing.Point(226, 14);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(75, 23);
            this.btStart.TabIndex = 0;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // btStop
            // 
            this.btStop.Enabled = false;
            this.btStop.Location = new System.Drawing.Point(307, 14);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(75, 23);
            this.btStop.TabIndex = 1;
            this.btStop.Text = "Stop";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // btRevese
            // 
            this.btRevese.Enabled = false;
            this.btRevese.Location = new System.Drawing.Point(226, 69);
            this.btRevese.Name = "btRevese";
            this.btRevese.Size = new System.Drawing.Size(156, 23);
            this.btRevese.TabIndex = 2;
            this.btRevese.Text = "Reverse";
            this.btRevese.UseVisualStyleBackColor = true;
            this.btRevese.Click += new System.EventHandler(this.btRevese_Click);
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(12, 12);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(100, 20);
            this.txtPort.TabIndex = 11;
            this.txtPort.Text = "COM1";
            // 
            // btPort
            // 
            this.btPort.Location = new System.Drawing.Point(118, 12);
            this.btPort.Name = "btPort";
            this.btPort.Size = new System.Drawing.Size(75, 23);
            this.btPort.TabIndex = 10;
            this.btPort.Text = "Port";
            this.btPort.UseVisualStyleBackColor = true;
            this.btPort.Click += new System.EventHandler(this.btPort_Click);
            // 
            // hsTocdo
            // 
            this.hsTocdo.Enabled = false;
            this.hsTocdo.Location = new System.Drawing.Point(226, 43);
            this.hsTocdo.Maximum = 1000;
            this.hsTocdo.Minimum = 1;
            this.hsTocdo.Name = "hsTocdo";
            this.hsTocdo.Size = new System.Drawing.Size(156, 17);
            this.hsTocdo.TabIndex = 15;
            this.hsTocdo.Value = 1;
            this.hsTocdo.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsTocdo_Scroll);
            // 
            // timer1
            // 
            this.timer1.Interval = 200;

            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(226, 98);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(156, 20);
            this.txtStatus.TabIndex = 16;
            // 
            // txtSpeed
            // 
            this.txtSpeed.Location = new System.Drawing.Point(226, 124);
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.ReadOnly = true;
            this.txtSpeed.Size = new System.Drawing.Size(156, 20);
            this.txtSpeed.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 310);
            this.Controls.Add(this.txtSpeed);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.hsTocdo);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.btPort);
            this.Controls.Add(this.btRevese);
            this.Controls.Add(this.btStop);
            this.Controls.Add(this.btStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Button btRevese;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Button btPort;
        private System.Windows.Forms.HScrollBar hsTocdo;
        private System.Windows.Forms.Timer timer1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtSpeed;
    }
}

