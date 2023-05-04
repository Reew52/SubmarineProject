namespace SubmarineProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            submarinUpDown = new AGauge();
            TxT_Error = new Label();
            TxT_submarinUpDown1 = new Label();
            hScrollBar1 = new HScrollBar();
            TxT_submarinUpDown = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ArduinoConnect = new Button();
            TxT_ArduinoConnect = new TextBox();
            SendButton_Click = new Button();
            SuspendLayout();
            // 
            // submarinUpDown
            // 
            submarinUpDown.BaseArcColor = Color.Gray;
            submarinUpDown.BaseArcRadius = 80;
            submarinUpDown.BaseArcStart = 135;
            submarinUpDown.BaseArcSweep = 270;
            submarinUpDown.BaseArcWidth = 2;
            submarinUpDown.Center = new Point(150, 150);
            submarinUpDown.Location = new Point(895, 29);
            submarinUpDown.Margin = new Padding(3, 4, 3, 4);
            submarinUpDown.MaxValue = 180F;
            submarinUpDown.MinValue = -180F;
            submarinUpDown.Name = "submarinUpDown";
            submarinUpDown.NeedleColor1 = AGaugeNeedleColor.Gray;
            submarinUpDown.NeedleColor2 = Color.DimGray;
            submarinUpDown.NeedleRadius = 110;
            submarinUpDown.NeedleType = NeedleType.Advance;
            submarinUpDown.NeedleWidth = 2;
            submarinUpDown.ScaleLinesInterColor = Color.Black;
            submarinUpDown.ScaleLinesInterInnerRadius = 110;
            submarinUpDown.ScaleLinesInterOuterRadius = 120;
            submarinUpDown.ScaleLinesInterWidth = 1;
            submarinUpDown.ScaleLinesMajorColor = Color.Black;
            submarinUpDown.ScaleLinesMajorInnerRadius = 110;
            submarinUpDown.ScaleLinesMajorOuterRadius = 120;
            submarinUpDown.ScaleLinesMajorStepValue = 10F;
            submarinUpDown.ScaleLinesMajorWidth = 2;
            submarinUpDown.ScaleLinesMinorColor = Color.Gray;
            submarinUpDown.ScaleLinesMinorInnerRadius = 115;
            submarinUpDown.ScaleLinesMinorOuterRadius = 120;
            submarinUpDown.ScaleLinesMinorTicks = 9;
            submarinUpDown.ScaleLinesMinorWidth = 1;
            submarinUpDown.ScaleNumbersColor = Color.Black;
            submarinUpDown.ScaleNumbersFormat = null;
            submarinUpDown.ScaleNumbersRadius = 135;
            submarinUpDown.ScaleNumbersRotation = 0;
            submarinUpDown.ScaleNumbersStartScaleLine = 0;
            submarinUpDown.ScaleNumbersStepScaleLines = 1;
            submarinUpDown.Size = new Size(359, 387);
            submarinUpDown.TabIndex = 0;
            submarinUpDown.Value = 0F;
            submarinUpDown.ValueInRangeChanged += aGauge1_ValueInRangeChanged;
            // 
            // TxT_Error
            // 
            TxT_Error.AutoSize = true;
            TxT_Error.Location = new Point(1347, 503);
            TxT_Error.Name = "TxT_Error";
            TxT_Error.Size = new Size(41, 20);
            TxT_Error.TabIndex = 2;
            TxT_Error.Text = "Error";
            TxT_Error.Click += TxT_Error_Click;
            // 
            // TxT_submarinUpDown1
            // 
            TxT_submarinUpDown1.AutoSize = true;
            TxT_submarinUpDown1.Location = new Point(928, 378);
            TxT_submarinUpDown1.Name = "TxT_submarinUpDown1";
            TxT_submarinUpDown1.Size = new Size(45, 20);
            TxT_submarinUpDown1.TabIndex = 3;
            TxT_submarinUpDown1.Text = "Value";
            TxT_submarinUpDown1.Click += TxT_submarinUpDown_Click;
            // 
            // hScrollBar1
            // 
            hScrollBar1.Location = new Point(2011, 475);
            hScrollBar1.Name = "hScrollBar1";
            hScrollBar1.Size = new Size(9, 8);
            hScrollBar1.TabIndex = 4;
            // 
            // TxT_submarinUpDown
            // 
            TxT_submarinUpDown.Enabled = false;
            TxT_submarinUpDown.Location = new Point(999, 371);
            TxT_submarinUpDown.Margin = new Padding(3, 4, 3, 4);
            TxT_submarinUpDown.Name = "TxT_submarinUpDown";
            TxT_submarinUpDown.Size = new Size(114, 27);
            TxT_submarinUpDown.TabIndex = 5;
            TxT_submarinUpDown.TextChanged += textBox1_TextChanged_1;
            // 
            // ArduinoConnect
            // 
            ArduinoConnect.Location = new Point(25, 28);
            ArduinoConnect.Margin = new Padding(3, 4, 3, 4);
            ArduinoConnect.Name = "ArduinoConnect";
            ArduinoConnect.Size = new Size(86, 31);
            ArduinoConnect.TabIndex = 6;
            ArduinoConnect.Text = "Connect";
            ArduinoConnect.UseVisualStyleBackColor = true;
            ArduinoConnect.Click += ArduinoConnect_Click;
            // 
            // TxT_ArduinoConnect
            // 
            TxT_ArduinoConnect.Location = new Point(25, 119);
            TxT_ArduinoConnect.Margin = new Padding(3, 4, 3, 4);
            TxT_ArduinoConnect.Name = "TxT_ArduinoConnect";
            TxT_ArduinoConnect.Size = new Size(114, 27);
            TxT_ArduinoConnect.TabIndex = 7;
            TxT_ArduinoConnect.TextChanged += TxT_ArduinoConnect_TextChanged;
            // 
            // SendButton_Click
            // 
            SendButton_Click.Location = new Point(178, 119);
            SendButton_Click.Margin = new Padding(3, 4, 3, 4);
            SendButton_Click.Name = "SendButton_Click";
            SendButton_Click.Size = new Size(86, 31);
            SendButton_Click.TabIndex = 8;
            SendButton_Click.Text = "Send";
            SendButton_Click.UseVisualStyleBackColor = true;
            SendButton_Click.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1055);
            Controls.Add(SendButton_Click);
            Controls.Add(TxT_ArduinoConnect);
            Controls.Add(ArduinoConnect);
            Controls.Add(TxT_submarinUpDown);
            Controls.Add(hScrollBar1);
            Controls.Add(TxT_submarinUpDown1);
            Controls.Add(TxT_Error);
            Controls.Add(submarinUpDown);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private AGauge submarinUpDown;
        private Label TxT_Error;
        private Label TxT_submarinUpDown1;
        private HScrollBar hScrollBar1;
        private TextBox TxT_submarinUpDown;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button ArduinoConnect;
        private TextBox TxT_ArduinoConnect;
        private Button SendButton_Click;
    }
}