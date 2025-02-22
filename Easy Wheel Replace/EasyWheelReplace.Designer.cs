﻿
namespace Easy_Wheel_Replace
{
    partial class EasyWheelReplace
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
            this.OpenFH5Folder = new System.Windows.Forms.OpenFileDialog();
            this.BTN_GameFolder = new System.Windows.Forms.Button();
            this.TXT_Gamepath = new System.Windows.Forms.TextBox();
            this.LST_WantedWheels = new System.Windows.Forms.ComboBox();
            this.LST_TargetWheels = new System.Windows.Forms.ComboBox();
            this.BTN_ReplaceWheels = new System.Windows.Forms.Button();
            this.Log = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // OpenFH5Folder
            // 
            this.OpenFH5Folder.Title = "Select Any File In the FH5 Game Folder";
            // 
            // BTN_GameFolder
            // 
            this.BTN_GameFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BTN_GameFolder.FlatAppearance.BorderSize = 0;
            this.BTN_GameFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_GameFolder.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_GameFolder.Location = new System.Drawing.Point(14, 17);
            this.BTN_GameFolder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 13);
            this.BTN_GameFolder.Name = "BTN_GameFolder";
            this.BTN_GameFolder.Size = new System.Drawing.Size(354, 89);
            this.BTN_GameFolder.TabIndex = 0;
            this.BTN_GameFolder.Text = "Select Game Location";
            this.BTN_GameFolder.UseVisualStyleBackColor = false;
            this.BTN_GameFolder.Click += new System.EventHandler(this.button1_Click);
            // 
            // TXT_Gamepath
            // 
            this.TXT_Gamepath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.TXT_Gamepath.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TXT_Gamepath.ForeColor = System.Drawing.Color.White;
            this.TXT_Gamepath.Location = new System.Drawing.Point(14, 133);
            this.TXT_Gamepath.Margin = new System.Windows.Forms.Padding(3, 13, 3, 13);
            this.TXT_Gamepath.Name = "TXT_Gamepath";
            this.TXT_Gamepath.ReadOnly = true;
            this.TXT_Gamepath.Size = new System.Drawing.Size(354, 32);
            this.TXT_Gamepath.TabIndex = 1;
            // 
            // LST_WantedWheels
            // 
            this.LST_WantedWheels.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.LST_WantedWheels.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LST_WantedWheels.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LST_WantedWheels.ForeColor = System.Drawing.Color.White;
            this.LST_WantedWheels.FormattingEnabled = true;
            this.LST_WantedWheels.Location = new System.Drawing.Point(14, 196);
            this.LST_WantedWheels.Margin = new System.Windows.Forms.Padding(3, 13, 3, 13);
            this.LST_WantedWheels.Name = "LST_WantedWheels";
            this.LST_WantedWheels.Size = new System.Drawing.Size(354, 33);
            this.LST_WantedWheels.TabIndex = 2;
            this.LST_WantedWheels.Text = "Wanted Wheels";
            this.LST_WantedWheels.SelectedIndexChanged += new System.EventHandler(this.LST_WantedWheels_SelectedIndexChanged);
            // 
            // LST_TargetWheels
            // 
            this.LST_TargetWheels.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.LST_TargetWheels.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LST_TargetWheels.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LST_TargetWheels.ForeColor = System.Drawing.Color.White;
            this.LST_TargetWheels.FormattingEnabled = true;
            this.LST_TargetWheels.Location = new System.Drawing.Point(14, 260);
            this.LST_TargetWheels.Margin = new System.Windows.Forms.Padding(3, 13, 3, 13);
            this.LST_TargetWheels.Name = "LST_TargetWheels";
            this.LST_TargetWheels.Size = new System.Drawing.Size(354, 33);
            this.LST_TargetWheels.TabIndex = 3;
            this.LST_TargetWheels.Text = "Target Wheels";
            this.LST_TargetWheels.SelectedIndexChanged += new System.EventHandler(this.LST_TargetWheels_SelectedIndexChanged);
            // 
            // BTN_ReplaceWheels
            // 
            this.BTN_ReplaceWheels.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BTN_ReplaceWheels.FlatAppearance.BorderSize = 0;
            this.BTN_ReplaceWheels.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_ReplaceWheels.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_ReplaceWheels.Location = new System.Drawing.Point(14, 320);
            this.BTN_ReplaceWheels.Margin = new System.Windows.Forms.Padding(3, 13, 3, 13);
            this.BTN_ReplaceWheels.Name = "BTN_ReplaceWheels";
            this.BTN_ReplaceWheels.Size = new System.Drawing.Size(354, 89);
            this.BTN_ReplaceWheels.TabIndex = 4;
            this.BTN_ReplaceWheels.Text = "Replace Wheels";
            this.BTN_ReplaceWheels.UseVisualStyleBackColor = false;
            this.BTN_ReplaceWheels.Click += new System.EventHandler(this.BTN_ReplaceWheels_Click);
            // 
            // Log
            // 
            this.Log.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Log.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.Log.FormattingEnabled = true;
            this.Log.ItemHeight = 20;
            this.Log.Location = new System.Drawing.Point(414, 17);
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(309, 384);
            this.Log.TabIndex = 5;
            this.Log.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // EasyWheelReplace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(763, 435);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.BTN_ReplaceWheels);
            this.Controls.Add(this.LST_TargetWheels);
            this.Controls.Add(this.LST_WantedWheels);
            this.Controls.Add(this.TXT_Gamepath);
            this.Controls.Add(this.BTN_GameFolder);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EasyWheelReplace";
            this.Text = "Easy Wheel Swap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog OpenFH5Folder;
        private System.Windows.Forms.Button BTN_GameFolder;
        private System.Windows.Forms.TextBox TXT_Gamepath;
        private System.Windows.Forms.ComboBox LST_WantedWheels;
        private System.Windows.Forms.ComboBox LST_TargetWheels;
        private System.Windows.Forms.Button BTN_ReplaceWheels;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox Log;
    }
}

