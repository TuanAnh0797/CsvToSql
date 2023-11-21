namespace InsertToSql
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
            this.fsw_CAMFRONT = new System.IO.FileSystemWatcher();
            this.Time_VP = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.Timer_GAS = new System.Windows.Forms.Timer(this.components);
            this.Timer_WI1WITH = new System.Windows.Forms.Timer(this.components);
            this.Timer_WI1START = new System.Windows.Forms.Timer(this.components);
            this.Timer_IP = new System.Windows.Forms.Timer(this.components);
            this.Timer_DF = new System.Windows.Forms.Timer(this.components);
            this.Timer_WI2 = new System.Windows.Forms.Timer(this.components);
            this.Timer_PAN = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fsw_CAMFRONT)).BeginInit();
            this.SuspendLayout();
            // 
            // fsw_CAMFRONT
            // 
            this.fsw_CAMFRONT.EnableRaisingEvents = true;
            this.fsw_CAMFRONT.Filter = "*.csv*";
            this.fsw_CAMFRONT.IncludeSubdirectories = true;
            this.fsw_CAMFRONT.SynchronizingObject = this;
            // 
            // Time_VP
            // 
            this.Time_VP.Interval = 5000;
            this.Time_VP.Tick += new System.EventHandler(this.Time_VP_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // Timer_GAS
            // 
            this.Timer_GAS.Interval = 5000;
            this.Timer_GAS.Tick += new System.EventHandler(this.Timer_GAS_Tick);
            // 
            // Timer_WI1WITH
            // 
            this.Timer_WI1WITH.Interval = 5000;
            this.Timer_WI1WITH.Tick += new System.EventHandler(this.Timer_WI1WITH_Tick);
            // 
            // Timer_WI1START
            // 
            this.Timer_WI1START.Interval = 5000;
            this.Timer_WI1START.Tick += new System.EventHandler(this.Timer_WI1START_Tick);
            // 
            // Timer_IP
            // 
            this.Timer_IP.Interval = 5000;
            this.Timer_IP.Tick += new System.EventHandler(this.Timer_IP_Tick);
            // 
            // Timer_DF
            // 
            this.Timer_DF.Interval = 5000;
            this.Timer_DF.Tick += new System.EventHandler(this.Timer_DF_Tick);
            // 
            // Timer_WI2
            // 
            this.Timer_WI2.Interval = 5000;
            this.Timer_WI2.Tick += new System.EventHandler(this.Timer_WI2_Tick);
            // 
            // Timer_PAN
            // 
            this.Timer_PAN.Interval = 5000;
            this.Timer_PAN.Tick += new System.EventHandler(this.Timer_PAN_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 417);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.fsw_CAMFRONT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.IO.FileSystemWatcher fsw_CAMFRONT;
        private System.Windows.Forms.Timer Time_VP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer Timer_GAS;
        private System.Windows.Forms.Timer Timer_WI1WITH;
        private System.Windows.Forms.Timer Timer_WI1START;
        private System.Windows.Forms.Timer Timer_IP;
        private System.Windows.Forms.Timer Timer_DF;
        private System.Windows.Forms.Timer Timer_WI2;
        private System.Windows.Forms.Timer Timer_PAN;
    }
}

