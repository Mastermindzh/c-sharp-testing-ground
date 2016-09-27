namespace WindsorGUI
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.btn_get_data = new System.Windows.Forms.Button();
			this.lbl_SpaceBase = new System.Windows.Forms.Label();
			this.lbl_SpaceShip = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btn_get_data
			// 
			this.btn_get_data.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_get_data.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_get_data.Location = new System.Drawing.Point(54, 58);
			this.btn_get_data.Name = "btn_get_data";
			this.btn_get_data.Size = new System.Drawing.Size(57, 23);
			this.btn_get_data.TabIndex = 0;
			this.btn_get_data.Text = "Get data";
			this.btn_get_data.UseVisualStyleBackColor = true;
			this.btn_get_data.Click += new System.EventHandler(this.btn_get_data_Click);
			// 
			// lbl_SpaceBase
			// 
			this.lbl_SpaceBase.AutoSize = true;
			this.lbl_SpaceBase.BackColor = System.Drawing.Color.Transparent;
			this.lbl_SpaceBase.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.lbl_SpaceBase.Location = new System.Drawing.Point(12, 9);
			this.lbl_SpaceBase.Name = "lbl_SpaceBase";
			this.lbl_SpaceBase.Size = new System.Drawing.Size(62, 13);
			this.lbl_SpaceBase.TabIndex = 1;
			this.lbl_SpaceBase.Text = "SpaceBase";
			// 
			// lbl_SpaceShip
			// 
			this.lbl_SpaceShip.AutoSize = true;
			this.lbl_SpaceShip.BackColor = System.Drawing.Color.Transparent;
			this.lbl_SpaceShip.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.lbl_SpaceShip.Location = new System.Drawing.Point(12, 33);
			this.lbl_SpaceShip.Name = "lbl_SpaceShip";
			this.lbl_SpaceShip.Size = new System.Drawing.Size(59, 13);
			this.lbl_SpaceShip.TabIndex = 2;
			this.lbl_SpaceShip.Text = "SpaceShip";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::WindsorGUI.Properties.Resources.space_624054_640;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(123, 93);
			this.Controls.Add(this.lbl_SpaceShip);
			this.Controls.Add(this.lbl_SpaceBase);
			this.Controls.Add(this.btn_get_data);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Space!!";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_get_data;
		private System.Windows.Forms.Label lbl_SpaceBase;
		private System.Windows.Forms.Label lbl_SpaceShip;
	}
}

