using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace BilliradGame
{
	/// <summary>
	/// Summary description for FormDistribution.
	/// </summary>
	public class FormRandomDistribution : System.Windows.Forms.Form
	{
		public int numBalls;
		public float radius;
		public float maxSpeed;
		public float minSpeed;
		public float mueG;
		public bool isRandomColor;
		public bool isBlueColor  ;
		private bool isEveryThingCorrect;
		public bool isOkPerresdFormRandomDistribution;


		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxNumBalls;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxMaxSpeed;
		private System.Windows.Forms.Button buttonOk;
		private System.Windows.Forms.Button buttonDefault;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxRadius;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.TextBox textBoxMueG;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.TextBox textBoxminSpeed;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FormRandomDistribution(int numBalls,float radius,float maxSpeed,float minSpeed,float mueG,
										 bool isRandomColor, bool isBlueColor  )
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
	
			isOkPerresdFormRandomDistribution = false;

			this.label6.Text = "Table.Width = "+BilliardForm.width.ToString()+ "   "+
							   "Table.Height = "+BilliardForm.height.ToString();

			this.numBalls = numBalls;
			this.radius   = radius;
			this.maxSpeed = maxSpeed;
			this.minSpeed = minSpeed;
			this.mueG     = mueG;
			this.isRandomColor = isRandomColor;
			this.isBlueColor   = isBlueColor;


			if(isBlueColor) 
				radioButton1.Checked = true;
			else if(isRandomColor)
				radioButton2.Checked = true;;

			
			TextBoxesData();
			buttonOk.Focus();
			
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FormRandomDistribution));
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxNumBalls = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxMaxSpeed = new System.Windows.Forms.TextBox();
			this.buttonOk = new System.Windows.Forms.Button();
			this.buttonDefault = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxRadius = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxMueG = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider();
			this.textBoxminSpeed = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(16, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(104, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Number of Balls :";
			// 
			// textBoxNumBalls
			// 
			this.textBoxNumBalls.Location = new System.Drawing.Point(120, 48);
			this.textBoxNumBalls.Name = "textBoxNumBalls";
			this.textBoxNumBalls.Size = new System.Drawing.Size(120, 20);
			this.textBoxNumBalls.TabIndex = 1;
			this.textBoxNumBalls.Text = "";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(16, 112);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(184, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "Maximum Speed of each Balls  :";
			// 
			// textBoxMaxSpeed
			// 
			this.textBoxMaxSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxMaxSpeed.Location = new System.Drawing.Point(200, 112);
			this.textBoxMaxSpeed.Name = "textBoxMaxSpeed";
			this.textBoxMaxSpeed.Size = new System.Drawing.Size(40, 20);
			this.textBoxMaxSpeed.TabIndex = 3;
			this.textBoxMaxSpeed.Text = "";
			// 
			// buttonOk
			// 
			this.buttonOk.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonOk.Location = new System.Drawing.Point(192, 208);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(48, 24);
			this.buttonOk.TabIndex = 9;
			this.buttonOk.Text = "Ok";
			this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
			// 
			// buttonDefault
			// 
			this.buttonDefault.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonDefault.Location = new System.Drawing.Point(192, 248);
			this.buttonDefault.Name = "buttonDefault";
			this.buttonDefault.Size = new System.Drawing.Size(48, 24);
			this.buttonDefault.TabIndex = 10;
			this.buttonDefault.Text = "Default";
			this.buttonDefault.Click += new System.EventHandler(this.buttonDefault_Click);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(16, 80);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(152, 16);
			this.label3.TabIndex = 6;
			this.label3.Text = "The Radius of ecah Balls :";
			// 
			// textBoxRadius
			// 
			this.textBoxRadius.Location = new System.Drawing.Point(168, 80);
			this.textBoxRadius.Name = "textBoxRadius";
			this.textBoxRadius.Size = new System.Drawing.Size(72, 20);
			this.textBoxRadius.TabIndex = 2;
			this.textBoxRadius.Text = "";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.Location = new System.Drawing.Point(16, 168);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(184, 16);
			this.label4.TabIndex = 8;
			this.label4.Text = "Coefficient  of  Friction  (mue*g) :";
			// 
			// textBoxMueG
			// 
			this.textBoxMueG.Location = new System.Drawing.Point(200, 168);
			this.textBoxMueG.Name = "textBoxMueG";
			this.textBoxMueG.Size = new System.Drawing.Size(40, 20);
			this.textBoxMueG.TabIndex = 5;
			this.textBoxMueG.Text = "";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.radioButton2);
			this.groupBox1.Controls.Add(this.radioButton1);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(16, 200);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(96, 72);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Ball\'s Color";
			// 
			// radioButton2
			// 
			this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.radioButton2.Location = new System.Drawing.Point(16, 48);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(64, 16);
			this.radioButton2.TabIndex = 7;
			this.radioButton2.Text = "Random";
			// 
			// radioButton1
			// 
			this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.radioButton1.Location = new System.Drawing.Point(16, 24);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(64, 16);
			this.radioButton1.TabIndex = 6;
			this.radioButton1.Text = "Blue";
			// 
			// errorProvider1
			// 
			this.errorProvider1.BlinkRate = 300;
			this.errorProvider1.ContainerControl = this;
			// 
			// textBoxminSpeed
			// 
			this.textBoxminSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxminSpeed.Location = new System.Drawing.Point(200, 136);
			this.textBoxminSpeed.Name = "textBoxminSpeed";
			this.textBoxminSpeed.Size = new System.Drawing.Size(40, 20);
			this.textBoxminSpeed.TabIndex = 4;
			this.textBoxminSpeed.Text = "";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.Location = new System.Drawing.Point(16, 136);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(184, 16);
			this.label5.TabIndex = 11;
			this.label5.Text = "Minimum  Speed of each Balls  :";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(128)), ((System.Byte)(128)), ((System.Byte)(255)));
			this.label6.Location = new System.Drawing.Point(8, 8);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(240, 24);
			this.label6.TabIndex = 12;
			this.label6.Text = "label6";
			// 
			// FormRandomDistribution
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(258, 284);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.textBoxminSpeed);
			this.Controls.Add(this.textBoxMueG);
			this.Controls.Add(this.textBoxRadius);
			this.Controls.Add(this.textBoxMaxSpeed);
			this.Controls.Add(this.textBoxNumBalls);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.buttonDefault);
			this.Controls.Add(this.buttonOk);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormRandomDistribution";
			this.Text = "Random Distribution Form";
			this.Closed += new System.EventHandler(this.FormDistribution_Closed);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

//----------------------------------------------------
		private void Default()
		{
			numBalls = 100;
			radius   = 10;
			maxSpeed = 50;
			minSpeed = 40;
			mueG     = 0.00F;
			isBlueColor = true;
			isRandomColor= false;
		}

		private void TextBoxesData()
		{
			textBoxNumBalls.Text = numBalls.ToString();
			textBoxRadius.Text   = radius.ToString();
			textBoxMaxSpeed.Text = maxSpeed.ToString("f");
			textBoxminSpeed.Text = minSpeed.ToString("f");
			textBoxMueG.Text     = mueG.ToString();
		}

		private void buttonOk_Click(object sender, System.EventArgs e)
		{
			errorProvider1.Dispose();
			isOkPerresdFormRandomDistribution = false;


			isEveryThingCorrect = true;
			
//----------------------------------------
			try
			{
				numBalls = int.Parse(textBoxNumBalls.Text);
				if(numBalls<=0)
				{
					isEveryThingCorrect = false;
					errorProvider1.SetError(textBoxNumBalls, "Bad value!");
					
				}
			}
			catch 
			{
				isEveryThingCorrect = false;
				errorProvider1.SetError(textBoxNumBalls, "Bad value!");
			}




			try
			{
				radius = float.Parse(textBoxRadius.Text);
				if(radius<=0)
				{
					isEveryThingCorrect = false;
					errorProvider1.SetError(textBoxRadius, "Bad value!");
				}
			
			}
			catch 
			{
				isEveryThingCorrect = false;
				errorProvider1.SetError(textBoxRadius, "Bad value!");
			}

			if( numBalls*2*radius*2*radius >= BilliardForm.height * BilliardForm.width -
										Math.Min(BilliardForm.height ,BilliardForm.width)*radius )
			{
				isEveryThingCorrect = false;
				errorProvider1.SetError(textBoxNumBalls,"Bad value!");
				errorProvider1.SetError(textBoxRadius,"Bad Value!");

				string error = "This balls can not been in Table."+ 
						"\r\nThe Size of form is :\r\n" +"Width = " +
						   BilliardForm.width.ToString()+"  Height = "+
						   BilliardForm.height.ToString();
				MessageBox.Show(error,"Warning",MessageBoxButtons.OK,MessageBoxIcon.Error);

			}



			try
			{
				maxSpeed = float.Parse(textBoxMaxSpeed.Text);
				if(maxSpeed<0)
				{
					isEveryThingCorrect = false;
					errorProvider1.SetError(textBoxMaxSpeed, "Bad value!");
				}
			}
			catch 
			{
				isEveryThingCorrect = false;
				errorProvider1.SetError(textBoxMaxSpeed, "Bad value!");
			}
			try
			{
				minSpeed = float.Parse(textBoxminSpeed.Text);
				if(minSpeed<0 ||  minSpeed>maxSpeed)
				{
					isEveryThingCorrect = false;
					errorProvider1.SetError(textBoxminSpeed, "Bad value!");
				}
			}
			catch 
			{
				isEveryThingCorrect = false;
				errorProvider1.SetError(textBoxminSpeed, "Bad value!");
			}





			try
			{
				mueG = float.Parse(textBoxMueG.Text);
				if(mueG<0)
				{
					isEveryThingCorrect = false;
					errorProvider1.SetError(textBoxMueG, "Bad value!");
				}
			}
			catch 
			{
				isEveryThingCorrect = false;
				errorProvider1.SetError(textBoxMueG, "Bad value!");
			}
//-----------------------

			
			isRandomColor = radioButton2.Checked;
			isBlueColor   =  radioButton1.Checked;

			if(isEveryThingCorrect)
			{
				isOkPerresdFormRandomDistribution = true;
				this.Close();	
				
			}
			

		
		}

		private void buttonDefault_Click(object sender, System.EventArgs e)
		{
			Default();
			TextBoxesData();
		}

		private void FormDistribution_Closed(object sender, System.EventArgs e)
		{
			isRandomColor = radioButton2.Checked;
			isBlueColor  =  radioButton1.Checked;
		}



		
	}// End Call FormDistribution
}// End NameSpace
