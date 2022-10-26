
namespace MW2_Fov_Changer
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
            this.fpsVal = new System.Windows.Forms.TextBox();
            this.setFPS = new System.Windows.Forms.CheckBox();
            this.setFOV = new System.Windows.Forms.CheckBox();
            this.fovVal = new System.Windows.Forms.TextBox();
            this.Fov = new System.Windows.Forms.Timer(this.components);
            this.gameStatusLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.FPSTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.minimiseButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fpsVal
            // 
            this.fpsVal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.fpsVal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fpsVal.Font = new System.Drawing.Font("BankGothic", 12F);
            this.fpsVal.ForeColor = System.Drawing.Color.White;
            this.fpsVal.Location = new System.Drawing.Point(12, 40);
            this.fpsVal.Name = "fpsVal";
            this.fpsVal.Size = new System.Drawing.Size(100, 24);
            this.fpsVal.TabIndex = 0;
            this.fpsVal.Text = "125";
            // 
            // setFPS
            // 
            this.setFPS.AutoSize = true;
            this.setFPS.FlatAppearance.BorderSize = 0;
            this.setFPS.Font = new System.Drawing.Font("Carbon Regular", 9.749999F, System.Drawing.FontStyle.Bold);
            this.setFPS.Location = new System.Drawing.Point(118, 45);
            this.setFPS.Name = "setFPS";
            this.setFPS.Size = new System.Drawing.Size(79, 17);
            this.setFPS.TabIndex = 1;
            this.setFPS.Text = "Set FPS";
            this.setFPS.UseVisualStyleBackColor = true;
            this.setFPS.CheckedChanged += new System.EventHandler(this.setFPS_CheckedChanged);
            // 
            // setFOV
            // 
            this.setFOV.AutoSize = true;
            this.setFOV.Font = new System.Drawing.Font("Carbon Regular", 9.749999F, System.Drawing.FontStyle.Bold);
            this.setFOV.Location = new System.Drawing.Point(118, 70);
            this.setFOV.Name = "setFOV";
            this.setFOV.Size = new System.Drawing.Size(78, 17);
            this.setFOV.TabIndex = 3;
            this.setFOV.Text = "Set Fov";
            this.setFOV.UseVisualStyleBackColor = true;
            this.setFOV.CheckedChanged += new System.EventHandler(this.setFOV_CheckedChanged);
            // 
            // fovVal
            // 
            this.fovVal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.fovVal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fovVal.Font = new System.Drawing.Font("BankGothic", 12F);
            this.fovVal.ForeColor = System.Drawing.Color.White;
            this.fovVal.Location = new System.Drawing.Point(12, 66);
            this.fovVal.Name = "fovVal";
            this.fovVal.Size = new System.Drawing.Size(100, 24);
            this.fovVal.TabIndex = 2;
            this.fovVal.Text = "80";
            // 
            // Fov
            // 
            this.Fov.Interval = 40;
            this.Fov.Tick += new System.EventHandler(this.Fov_Tick);
            // 
            // gameStatusLabel
            // 
            this.gameStatusLabel.AutoSize = true;
            this.gameStatusLabel.Font = new System.Drawing.Font("BankGothic", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameStatusLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.gameStatusLabel.Location = new System.Drawing.Point(210, 99);
            this.gameStatusLabel.Name = "gameStatusLabel";
            this.gameStatusLabel.Size = new System.Drawing.Size(74, 12);
            this.gameStatusLabel.TabIndex = 4;
            this.gameStatusLabel.Text = "Not Found";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // FPSTimer
            // 
            this.FPSTimer.Tick += new System.EventHandler(this.FPS_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 27);
            this.panel1.TabIndex = 29;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.closeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(25)))));
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.Black;
            this.closeButton.Location = new System.Drawing.Point(251, 0);
            this.closeButton.Margin = new System.Windows.Forms.Padding(0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(47, 27);
            this.closeButton.TabIndex = 32;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // minimiseButton
            // 
            this.minimiseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.minimiseButton.FlatAppearance.BorderSize = 0;
            this.minimiseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimiseButton.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimiseButton.ForeColor = System.Drawing.Color.Black;
            this.minimiseButton.Location = new System.Drawing.Point(205, 0);
            this.minimiseButton.Margin = new System.Windows.Forms.Padding(0);
            this.minimiseButton.Name = "minimiseButton";
            this.minimiseButton.Size = new System.Drawing.Size(46, 27);
            this.minimiseButton.TabIndex = 31;
            this.minimiseButton.Text = "—";
            this.minimiseButton.UseVisualStyleBackColor = false;
            this.minimiseButton.Click += new System.EventHandler(this.minimiseButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("BankGothic", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 12);
            this.label1.TabIndex = 33;
            this.label1.Text = "Status:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("BankGothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 12);
            this.label2.TabIndex = 34;
            this.label2.Text = "Made By ItLooksSad";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(298, 120);
            this.Controls.Add(this.gameStatusLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.minimiseButton);
            this.Controls.Add(this.setFOV);
            this.Controls.Add(this.fovVal);
            this.Controls.Add(this.setFPS);
            this.Controls.Add(this.fpsVal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "MW2 FPS Changer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fpsVal;
        private System.Windows.Forms.CheckBox setFPS;
        private System.Windows.Forms.CheckBox setFOV;
        private System.Windows.Forms.TextBox fovVal;
        private System.Windows.Forms.Timer Fov;
        private System.Windows.Forms.Label gameStatusLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer FPSTimer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button minimiseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

