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
            this.button1 = new System.Windows.Forms.Button();
            this.fsw_VP = new System.IO.FileSystemWatcher();
            this.fsw_GAS = new System.IO.FileSystemWatcher();
            this.fsw_WI1WITH = new System.IO.FileSystemWatcher();
            this.fsw_WISTART = new System.IO.FileSystemWatcher();
            this.fsw_IP = new System.IO.FileSystemWatcher();
            this.fsw_DF = new System.IO.FileSystemWatcher();
            this.fsw_TEMP = new System.IO.FileSystemWatcher();
            this.fsw_IOT = new System.IO.FileSystemWatcher();
            this.fsw_PAN = new System.IO.FileSystemWatcher();
            this.fsw_CAMBACK = new System.IO.FileSystemWatcher();
            this.fsw_CAMFRONT = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.fsw_VP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fsw_GAS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fsw_WI1WITH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fsw_WISTART)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fsw_IP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fsw_DF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fsw_TEMP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fsw_IOT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fsw_PAN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fsw_CAMBACK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fsw_CAMFRONT)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(95, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            //this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fsw_VP
            // 
            this.fsw_VP.EnableRaisingEvents = true;
            this.fsw_VP.Filter = "*.csv*";
            this.fsw_VP.IncludeSubdirectories = true;
            this.fsw_VP.SynchronizingObject = this;
            this.fsw_VP.Created += new System.IO.FileSystemEventHandler(this.fsw_VP_Created);
            // 
            // fsw_GAS
            // 
            this.fsw_GAS.EnableRaisingEvents = true;
            this.fsw_GAS.Filter = "*.csv*";
            this.fsw_GAS.IncludeSubdirectories = true;
            this.fsw_GAS.SynchronizingObject = this;
            // 
            // fsw_WI1WITH
            // 
            this.fsw_WI1WITH.EnableRaisingEvents = true;
            this.fsw_WI1WITH.Filter = "*.csv*";
            this.fsw_WI1WITH.IncludeSubdirectories = true;
            this.fsw_WI1WITH.SynchronizingObject = this;
            // 
            // fsw_WISTART
            // 
            this.fsw_WISTART.EnableRaisingEvents = true;
            this.fsw_WISTART.Filter = "*.csv*";
            this.fsw_WISTART.IncludeSubdirectories = true;
            this.fsw_WISTART.SynchronizingObject = this;
            // 
            // fsw_IP
            // 
            this.fsw_IP.EnableRaisingEvents = true;
            this.fsw_IP.Filter = "*.csv*";
            this.fsw_IP.IncludeSubdirectories = true;
            this.fsw_IP.SynchronizingObject = this;
            // 
            // fsw_DF
            // 
            this.fsw_DF.EnableRaisingEvents = true;
            this.fsw_DF.Filter = "*.csv*";
            this.fsw_DF.IncludeSubdirectories = true;
            this.fsw_DF.SynchronizingObject = this;
            // 
            // fsw_TEMP
            // 
            this.fsw_TEMP.EnableRaisingEvents = true;
            this.fsw_TEMP.Filter = "*.csv*";
            this.fsw_TEMP.IncludeSubdirectories = true;
            this.fsw_TEMP.SynchronizingObject = this;
            // 
            // fsw_IOT
            // 
            this.fsw_IOT.EnableRaisingEvents = true;
            this.fsw_IOT.Filter = "*.csv*";
            this.fsw_IOT.IncludeSubdirectories = true;
            this.fsw_IOT.SynchronizingObject = this;
            // 
            // fsw_PAN
            // 
            this.fsw_PAN.EnableRaisingEvents = true;
            this.fsw_PAN.Filter = "*.csv*";
            this.fsw_PAN.IncludeSubdirectories = true;
            this.fsw_PAN.SynchronizingObject = this;
            // 
            // fsw_CAMBACK
            // 
            this.fsw_CAMBACK.EnableRaisingEvents = true;
            this.fsw_CAMBACK.Filter = "*.csv*";
            this.fsw_CAMBACK.IncludeSubdirectories = true;
            this.fsw_CAMBACK.SynchronizingObject = this;
            // 
            // fsw_CAMFRONT
            // 
            this.fsw_CAMFRONT.EnableRaisingEvents = true;
            this.fsw_CAMFRONT.Filter = "*.csv*";
            this.fsw_CAMFRONT.IncludeSubdirectories = true;
            this.fsw_CAMFRONT.SynchronizingObject = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 277);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.fsw_VP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fsw_GAS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fsw_WI1WITH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fsw_WISTART)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fsw_IP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fsw_DF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fsw_TEMP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fsw_IOT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fsw_PAN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fsw_CAMBACK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fsw_CAMFRONT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.IO.FileSystemWatcher fsw_VP;
        private System.IO.FileSystemWatcher fsw_GAS;
        private System.IO.FileSystemWatcher fsw_WI1WITH;
        private System.IO.FileSystemWatcher fsw_WISTART;
        private System.IO.FileSystemWatcher fsw_IP;
        private System.IO.FileSystemWatcher fsw_DF;
        private System.IO.FileSystemWatcher fsw_TEMP;
        private System.IO.FileSystemWatcher fsw_IOT;
        private System.IO.FileSystemWatcher fsw_PAN;
        private System.IO.FileSystemWatcher fsw_CAMBACK;
        private System.IO.FileSystemWatcher fsw_CAMFRONT;
    }
}

