namespace opulencia_binary
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
            this.panelArray = new System.Windows.Forms.FlowLayoutPanel();
            this.txtTarget = new System.Windows.Forms.TextBox();
            this.timerStep = new System.Windows.Forms.Timer(this.components);
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblStatus2 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtArray = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // panelArray
            // 
            this.panelArray.Location = new System.Drawing.Point(87, 59);
            this.panelArray.Name = "panelArray";
            this.panelArray.Size = new System.Drawing.Size(491, 43);
            this.panelArray.TabIndex = 0;
            // 
            // txtTarget
            // 
            this.txtTarget.Location = new System.Drawing.Point(87, 124);
            this.txtTarget.Name = "txtTarget";
            this.txtTarget.Size = new System.Drawing.Size(299, 20);
            this.txtTarget.TabIndex = 1;
            // 
            // timerStep
            // 
            this.timerStep.Tick += new System.EventHandler(this.timerStep_Tick);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(97, 211);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(50, 13);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "RESULT";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(423, 126);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(124, 40);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblStatus2
            // 
            this.lblStatus2.AutoSize = true;
            this.lblStatus2.Location = new System.Drawing.Point(97, 180);
            this.lblStatus2.Name = "lblStatus2";
            this.lblStatus2.Size = new System.Drawing.Size(35, 13);
            this.lblStatus2.TabIndex = 4;
            this.lblStatus2.Text = "status";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(100, 244);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(32, 13);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "result";
            // 
            // txtArray
            // 
            this.txtArray.Location = new System.Drawing.Point(87, 17);
            this.txtArray.Name = "txtArray";
            this.txtArray.Size = new System.Drawing.Size(201, 20);
            this.txtArray.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtArray);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblStatus2);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtTarget);
            this.Controls.Add(this.panelArray);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panelArray;
        private System.Windows.Forms.TextBox txtTarget;
        private System.Windows.Forms.Timer timerStep;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblStatus2;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtArray;
    }
}

