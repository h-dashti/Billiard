using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace BilliradGame
{
	/// <summary>
	/// Summary description for FormForEachBall.
	/// </summary>
	public class FormForEachBall : System.Windows.Forms.Form
	{

		public float speed, angle,mueg,radius;
		public Color color;

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxSpeed;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxAngle;
		private System.Windows.Forms.ColorDialog colorDialog1;
		private System.Windows.Forms.Button buttonColor;
		private System.Windows.Forms.Button buttonOk;
		private System.Windows.Forms.TextBox textBoxmueG;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBoxRadius;
		private System.Windows.Forms.Button buttonExit;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBoxCenter;
		private System.ComponentModel.IContainer components;

		public FormForEachBall(int ilable,float radius ,float speed, float angle,float mueg ,
			Color color,float xcenter, float ycetner)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//

			toolTip1.SetToolTip(buttonExit, "press to exit without any changing");

			this.speed = speed;
			this.radius = radius;
			this.angle  = angle;
			this.mueg   = mueg;
			this.color = color;

			label1.Text = ilable.ToString();
			textBoxSpeed.Text = speed.ToString("f");
			textBoxAngle.Text = angle.ToString("f");
			textBoxmueG.Text = mueg.ToString();
			textBoxRadius.Text = radius.ToString();
			textBoxCenter.Text = ((int)xcenter).ToString() +"; "+ ((int)ycetner).ToString();

			colorDialog1.Color = color;
			label1.ForeColor = color;

		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxSpeed = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxAngle = new System.Windows.Forms.TextBox();
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.buttonColor = new System.Windows.Forms.Button();
			this.buttonOk = new System.Windows.Forms.Button();
			this.textBoxmueG = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider();
			this.textBoxRadius = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.buttonExit = new System.Windows.Forms.Button();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.label6 = new System.Windows.Forms.Label();
			this.textBoxCenter = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(4, 4);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 28);
			this.label1.TabIndex = 0;
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "speed = ";
			// 
			// textBoxSpeed
			// 
			this.textBoxSpeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBoxSpeed.Location = new System.Drawing.Point(48, 40);
			this.textBoxSpeed.Name = "textBoxSpeed";
			this.textBoxSpeed.Size = new System.Drawing.Size(48, 18);
			this.textBoxSpeed.TabIndex = 2;
			this.textBoxSpeed.Text = "";
			this.textBoxSpeed.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormForEachBall_KeyDown);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 56);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(40, 16);
			this.label3.TabIndex = 3;
			this.label3.Text = "angle  =";
			// 
			// textBoxAngle
			// 
			this.textBoxAngle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBoxAngle.Location = new System.Drawing.Point(48, 56);
			this.textBoxAngle.Name = "textBoxAngle";
			this.textBoxAngle.Size = new System.Drawing.Size(48, 18);
			this.textBoxAngle.TabIndex = 4;
			this.textBoxAngle.Text = "";
			this.textBoxAngle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormForEachBall_KeyDown);
			// 
			// colorDialog1
			// 
			this.colorDialog1.AnyColor = true;
			this.colorDialog1.Color = System.Drawing.Color.Blue;
			// 
			// buttonColor
			// 
			this.buttonColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonColor.Location = new System.Drawing.Point(48, 2);
			this.buttonColor.Name = "buttonColor";
			this.buttonColor.Size = new System.Drawing.Size(48, 20);
			this.buttonColor.TabIndex = 10;
			this.buttonColor.Text = "Color";
			this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
			this.buttonColor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormForEachBall_KeyDown);
			// 
			// buttonOk
			// 
			this.buttonOk.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
			this.buttonOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonOk.Location = new System.Drawing.Point(48, 107);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(48, 22);
			this.buttonOk.TabIndex = 9;
			this.buttonOk.Text = "Ok";
			this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
			this.buttonOk.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormForEachBall_KeyDown);
			// 
			// textBoxmueG
			// 
			this.textBoxmueG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBoxmueG.Location = new System.Drawing.Point(48, 72);
			this.textBoxmueG.Name = "textBoxmueG";
			this.textBoxmueG.Size = new System.Drawing.Size(48, 18);
			this.textBoxmueG.TabIndex = 6;
			this.textBoxmueG.Text = "";
			this.textBoxmueG.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormForEachBall_KeyDown);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(8, 72);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(40, 16);
			this.label4.TabIndex = 7;
			this.label4.Text = "mueg =";
			// 
			// errorProvider1
			// 
			this.errorProvider1.BlinkRate = 300;
			this.errorProvider1.ContainerControl = this;
			// 
			// textBoxRadius
			// 
			this.textBoxRadius.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBoxRadius.Location = new System.Drawing.Point(48, 88);
			this.textBoxRadius.Name = "textBoxRadius";
			this.textBoxRadius.Size = new System.Drawing.Size(48, 18);
			this.textBoxRadius.TabIndex = 8;
			this.textBoxRadius.Text = "";
			this.textBoxRadius.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormForEachBall_KeyDown);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(8, 88);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(40, 16);
			this.label5.TabIndex = 10;
			this.label5.Text = "radius=";
			// 
			// buttonExit
			// 
			this.buttonExit.BackColor = System.Drawing.SystemColors.ControlLight;
			this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonExit.ForeColor = System.Drawing.Color.Blue;
			this.buttonExit.Location = new System.Drawing.Point(104, 1);
			this.buttonExit.Name = "buttonExit";
			this.buttonExit.Size = new System.Drawing.Size(16, 16);
			this.buttonExit.TabIndex = 11;
			this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
			this.buttonExit.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonExit_Paint);
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(8, 24);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(40, 16);
			this.label6.TabIndex = 12;
			this.label6.Text = "center=";
			// 
			// textBoxCenter
			// 
			this.textBoxCenter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBoxCenter.Location = new System.Drawing.Point(48, 24);
			this.textBoxCenter.Name = "textBoxCenter";
			this.textBoxCenter.ReadOnly = true;
			this.textBoxCenter.Size = new System.Drawing.Size(48, 18);
			this.textBoxCenter.TabIndex = 0;
			this.textBoxCenter.Text = "";
			this.textBoxCenter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormForEachBall_KeyDown);
			// 
			// FormForEachBall
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(4, 11);
			this.ClientSize = new System.Drawing.Size(122, 131);
			this.ControlBox = false;
			this.Controls.Add(this.textBoxCenter);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.buttonExit);
			this.Controls.Add(this.textBoxRadius);
			this.Controls.Add(this.textBoxmueG);
			this.Controls.Add(this.textBoxAngle);
			this.Controls.Add(this.textBoxSpeed);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.buttonOk);
			this.Controls.Add(this.buttonColor);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(100, 100);
			this.Name = "FormForEachBall";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormForEachBall_KeyDown);
			this.ResumeLayout(false);

		}
		#endregion

		

		private void buttonColor_Click(object sender, System.EventArgs e)
		{
			if(colorDialog1.ShowDialog() == DialogResult.OK)
			{
				this.color = colorDialog1.Color;
			}
			label1.ForeColor = this.color;
		}

		

		private void buttonOk_Click(object sender, System.EventArgs e)
		{
			bool iseveryThingCorrect = true;
			errorProvider1.Dispose();

			try
			{
				this.speed = float.Parse(textBoxSpeed.Text);
				if(this.speed <0)
				{
					iseveryThingCorrect = false;
					errorProvider1.SetError(textBoxSpeed, "Speed must be positive!");
				}
			}
			catch
			{
				iseveryThingCorrect = false;
				errorProvider1.SetError(textBoxSpeed, "Bad value!");
			}

			try
			{
				this.angle = float.Parse(textBoxAngle.Text);
			}
			catch
			{
				iseveryThingCorrect = false;
				errorProvider1.SetError(textBoxAngle, "Bad value!");
			}

			try
			{
				this.mueg  = float.Parse(textBoxmueG.Text);
				if(this.mueg <0)
				{
					iseveryThingCorrect = false;
					errorProvider1.SetError(textBoxmueG, "Coefficient must be positive!");
				}
				
			}
			catch
			{
				iseveryThingCorrect = false;
				errorProvider1.SetError(textBoxmueG, "Bad value!");
			}

			try
			{
				this.radius = float.Parse(textBoxRadius.Text);
				if(this.radius <=0 )
				{
					iseveryThingCorrect = false;
					errorProvider1.SetError(textBoxRadius, "Radius must be positive!");
				}
			}
			catch
			{
				iseveryThingCorrect = false;
				errorProvider1.SetError(textBoxRadius, "Bad value!");
			}


			this.color = colorDialog1.Color;

			if(iseveryThingCorrect)
				this.Close();
		}

		private void buttonExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void buttonExit_Paint(object sender, System.Windows.Forms.PaintEventArgs pea)
		{
			Graphics g = pea.Graphics;

//			g.FillEllipse(Brushes.Red, 2,2,((Button)sender).Width-4,((Button)sender).Height-4);
			g.DrawLine(new Pen(Color.Red,2),3,3,((Button)sender).Width-4,((Button)sender).Height-4);
			g.DrawLine(new Pen(Color.Red,2),3,((Button)sender).Height-4,((Button)sender).Width-4,3);
		
		}

		private void FormForEachBall_KeyDown(object sender, System.Windows.Forms.KeyEventArgs kea)
		{
			if(kea.KeyCode == Keys.Escape)
				this.Close();
		
		}
//*****************************************
//******************************************
	}
}
