﻿
namespace SantaFactory
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
            this.CreateTimer = new System.Windows.Forms.Timer(this.components);
            this.mainPanel = new System.Windows.Forms.Panel();
            this.ConveyorTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // CreateTimer
            // 
            this.CreateTimer.Enabled = true;
            this.CreateTimer.Tick += new System.EventHandler(this.CreateTimer_Tick);
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.Location = new System.Drawing.Point(3, 61);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(785, 377);
            this.mainPanel.TabIndex = 0;
            // 
            // ConveyorTimer
            // 
            this.ConveyorTimer.Enabled = true;
            this.ConveyorTimer.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer CreateTimer;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Timer ConveyorTimer;
    }
}

