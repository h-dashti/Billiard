using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace BilliradGame
{
	/// <summary>
	/// Summary description for FormManual.
	/// </summary>
	public class FormManual : System.Windows.Forms.Form
	{
		public bool isPresedFinish = false;
		public bool isPresedOk = false;
		public Ball[] myballs;
		private int numBalls;	
		private Label[,] arrlables;
		private TextBox[,] arrtextBoxes;


		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxNumBalls;
		private System.Windows.Forms.Button buttonOk;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.Button buttonFinish;
		private System.Windows.Forms.Label labelsize;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FormManual()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//

			isPresedFinish = false;
			isPresedOk = false;
			numBalls = -1;
	
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
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxNumBalls = new System.Windows.Forms.TextBox();
			this.buttonOk = new System.Windows.Forms.Button();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider();
			this.buttonFinish = new System.Windows.Forms.Button();
			this.labelsize = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(8, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(168, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Enter the number of Balls :";
			// 
			// textBoxNumBalls
			// 
			this.textBoxNumBalls.Location = new System.Drawing.Point(168, 16);
			this.textBoxNumBalls.Name = "textBoxNumBalls";
			this.textBoxNumBalls.Size = new System.Drawing.Size(64, 20);
			this.textBoxNumBalls.TabIndex = 1;
			this.textBoxNumBalls.Text = "";
			// 
			// buttonOk
			// 
			this.buttonOk.Location = new System.Drawing.Point(264, 16);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(48, 24);
			this.buttonOk.TabIndex = 2;
			this.buttonOk.Text = "Ok";
			this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
			// 
			// errorProvider1
			// 
			this.errorProvider1.BlinkRate = 300;
			this.errorProvider1.ContainerControl = this;
			// 
			// buttonFinish
			// 
			this.buttonFinish.Location = new System.Drawing.Point(264, 48);
			this.buttonFinish.Name = "buttonFinish";
			this.buttonFinish.Size = new System.Drawing.Size(48, 24);
			this.buttonFinish.TabIndex = 3;
			this.buttonFinish.Text = "Finish";
			this.buttonFinish.Visible = false;
			this.buttonFinish.Click += new System.EventHandler(this.buttonFinish_Click);
			// 
			// labelsize
			// 
			this.labelsize.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelsize.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(128)), ((System.Byte)(128)), ((System.Byte)(255)));
			this.labelsize.Location = new System.Drawing.Point(8, 48);
			this.labelsize.Name = "labelsize";
			this.labelsize.Size = new System.Drawing.Size(256, 24);
			this.labelsize.TabIndex = 4;
			// 
			// FormManual
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.AutoScroll = true;
			this.AutoScrollMargin = new System.Drawing.Size(0, 10);
			this.ClientSize = new System.Drawing.Size(322, 88);
			this.Controls.Add(this.labelsize);
			this.Controls.Add(this.buttonFinish);
			this.Controls.Add(this.buttonOk);
			this.Controls.Add(this.textBoxNumBalls);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "FormManual";
			this.Text = "Manual Form";
			this.ResumeLayout(false);

		}
		#endregion

//*************************************************
//------------------------------------------------

		private void Initialize(int num)
		{
			this.ClientSize = new Size(520,400);

			arrlables    = new Label[num,7];
			arrtextBoxes = new TextBox[num,6];	

			for(int i=0; i<num; i++)
			{
				for(int j=0;j<6;j++)
				{
					arrlables[i,j] = new Label();
					arrtextBoxes[i,j] = new TextBox();
					this.Controls.Add(arrlables[i,j]);
					this.Controls.Add(arrtextBoxes[i,j]);


					arrlables[i,j].Size    = new Size(56, 16);
					arrtextBoxes[i,j].Size = new Size(56,16);

					arrtextBoxes[i,j].Text = "";


					arrlables[i,j].Location    = new Point(72*j+80,  50*i +70);
					arrtextBoxes[i,j].Location = new Point(72*j+80, 18+50*i +70);
				}
				
				arrlables[i,6] = new Label();
				this.Controls.Add(arrlables[i,6]);

				arrlables[i,6].Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
				arrlables[i,6].Location = new Point(8,18+50*i +70);
				arrlables[i,6].Size = new Size(56,16);
				arrlables[i,6].Text = "Ball "+ Convert.ToString(i+1)+"th :";

				arrlables[i,0].Text = "xCenter";
				arrlables[i,1].Text = "yCenter";
				arrlables[i,2].Text = "radius";
				arrlables[i,3].Text = "angle(rad)";
				arrlables[i,4].Text = "speed";
				arrlables[i,5].Text = "mue*g";

			}


			//
			// buttonFinish
			buttonFinish.Location = new Point(this.ClientSize.Width/2, 50*num + 70);
			buttonFinish.Size = new Size(arrtextBoxes[num-1,5].Location.X + 56 -
										 this.ClientSize.Width/2 ,24);
			buttonFinish.Text = "Finish";
			buttonFinish.Visible = true;

			
		}// End Initilaize

//---------------------------------------------------
		private void RemoveControls()
		{
			for(int i=numBalls-1; i>=0; i--)
			{
				for(int j=5; j>=0; j--)
				{
					this.Controls.Remove(arrlables[i,j]);
					this.Controls.Remove(arrtextBoxes[i,j]);
				}

				this.Controls.Remove(arrlables[i,6]);
					
			}

		}//End RemoveControls

//--------------------------------------------
		private void ChekingBallsDontContact()
		{

			for(int i=0; i< myballs.Length-1; i++)
				for(int j=i+1; j<myballs.Length; j++)
					if(Ball.IsContactedTwoBall(myballs[i],myballs[j]))
					{
						errorProvider1.SetError(arrlables[i,6],"This ball is Contacted with another ball");
						errorProvider1.SetError(arrlables[j,6],"This ball is Contacted with another ball");
						isPresedFinish = false;
					}
			

			
		}// End ChekingBallsDontContact
//-------------------------------------------------

		private bool IsValidData(int num)
		{
			float x,y,radius,angle,v,mueg;
			bool isEveryThingCorrect = true;
			

			for(int i=0; i<num; i++)
			{
				bool isXNumber = true;
				bool isYNumber = true;

				try
				{
					x = float.Parse(arrtextBoxes[i,0].Text);
					if(x<0 || x> BilliardForm.width)
					{
						errorProvider1.SetError(arrtextBoxes[i,0],"Center of ball is Out of table!");
						isEveryThingCorrect = false;
						isXNumber = false;
					}
				}
				catch
				{
					errorProvider1.SetError(arrtextBoxes[i,0],"Bad value!");
					isEveryThingCorrect = false;
					isXNumber = false;
				}//x



				try
				{
					y = float.Parse(arrtextBoxes[i,1].Text);
					if(y<0 || y> BilliardForm.height)
					{
						errorProvider1.SetError(arrtextBoxes[i,1],"Center of ball is Out of table!");
						isEveryThingCorrect = false;
						isYNumber = false;
					}
				}
				catch
				{
					errorProvider1.SetError(arrtextBoxes[i,1],"Bad value!");
					isEveryThingCorrect = false;
					isYNumber = false;
				}//y




				try
				{
					radius = float.Parse(arrtextBoxes[i,2].Text);
					if(radius<=0)
					{
						errorProvider1.SetError(arrtextBoxes[i,2],"Radius must be positive!");
						isEveryThingCorrect = false;
					}

					else
					{
						if( isXNumber && (float.Parse(arrtextBoxes[i,0].Text)-radius<0 || 
							float.Parse(arrtextBoxes[i,0].Text)+radius > BilliardForm.width) )
						{
							errorProvider1.SetError(arrtextBoxes[i,0],"Some part of ball is outside table!");
							errorProvider1.SetError(arrtextBoxes[i,2],"Some part of ball is outside table!");
							isEveryThingCorrect = false;
						}

						if( isYNumber && (float.Parse(arrtextBoxes[i,1].Text)-radius<0 ||
							float.Parse(arrtextBoxes[i,1].Text)+radius > BilliardForm.height) )
						{
							errorProvider1.SetError(arrtextBoxes[i,1],"Some part of ball is outside table!");
							errorProvider1.SetError(arrtextBoxes[i,2],"Some part of ball is outside table!");
							isEveryThingCorrect = false;
						}
					}


				}
				catch
				{
					errorProvider1.SetError(arrtextBoxes[i,2],"Bad value!");
					isEveryThingCorrect = false;
				}// Radius

				

				try
				{
					angle = float.Parse(arrtextBoxes[i,3].Text);
					
				}
				catch
				{
					errorProvider1.SetError(arrtextBoxes[i,3],"Bad value!");
					isEveryThingCorrect = false;
				}//angle


				try
				{
					v = float.Parse(arrtextBoxes[i,4].Text);
					if(v<0)
					{
						errorProvider1.SetError(arrtextBoxes[i,4],"Speed must be a positive value!");
						isEveryThingCorrect = false;
					}
					
				}
				catch
				{
					errorProvider1.SetError(arrtextBoxes[i,4],"Bad value!");
					isEveryThingCorrect = false;
				}//v


				try
				{
					mueg = float.Parse(arrtextBoxes[i,5].Text);
					if(mueg<0)
					{
						errorProvider1.SetError(arrtextBoxes[i,5],"It must be a positive value!");
						isEveryThingCorrect = false;
					}
					
				}
				catch
				{
					errorProvider1.SetError(arrtextBoxes[i,5],"Bad value!");
					isEveryThingCorrect = false;
				}//mueg


			}// for


			return isEveryThingCorrect;
			

		}// isValidData


//----------------------------------------------

		private void buttonOk_Click(object sender, System.EventArgs e)
		{
			errorProvider1.Dispose();
			labelsize.Text = "";

			if(numBalls>0)
			{
				RemoveControls();// remove last TextBoxes & Lables
				buttonFinish.Visible = false;
			}
			
			
			try 
			{
				numBalls = int.Parse(textBoxNumBalls.Text);
				if(numBalls>0)
				{
					labelsize.Text = "Table.Width = "+BilliardForm.width+"    "+
						"Table.Height = "+BilliardForm.height;

					Initialize(numBalls);
				}
				else
					errorProvider1.SetError(textBoxNumBalls,"It must be positive!");		
			}
			catch
			{
				errorProvider1.SetError(textBoxNumBalls,"Bad Number!");

			}
						
		
		}
//--------------------------------------------

		private void buttonFinish_Click(object sender, System.EventArgs e)
		{
			isPresedFinish = true;
			errorProvider1.Dispose();


			
			if(IsValidData(numBalls))
			{

				myballs = new Ball[numBalls];
				for(int i=0; i<numBalls; i++)
				{

					myballs[i] = new Ball(float.Parse(arrtextBoxes[i,0].Text),
						float.Parse(arrtextBoxes[i,1].Text),
						float.Parse(arrtextBoxes[i,2].Text),
						float.Parse(arrtextBoxes[i,3].Text),
						float.Parse(arrtextBoxes[i,4].Text),
						float.Parse(arrtextBoxes[i,5].Text),
						Color.Blue,new Table(BilliardForm.width,BilliardForm.height));
				}

				ChekingBallsDontContact();
			}
			else
				isPresedFinish = false;

			if(isPresedFinish)
				this.Close();
		
		}
//***************************************************
//***************************************************
	}
}
