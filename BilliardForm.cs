using System;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;

namespace BilliradGame
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class BilliardForm : System.Windows.Forms.Form
	{
		private FormRandomDistribution formDistribution ;

     
        

		private int numBalls;
		private float radius;
		private float maxSpeed;
		private float minSpeed;
		private float mueG;
		private bool isRandomColor;
		private bool isBlueColor  ;

		private bool isCaughtBall = false;
		private int intballCaught;
		private float dx, dy;


		public static float height;
		public static float width;

		private Table myTable;
		private Ball[] balls;
		private Ball[] tempBalls;
		private Timer timer;
		private int interval;
		private float dt;
		

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button buttonStart;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItemFile;
		private System.Windows.Forms.Button buttonPause;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.HScrollBar hScrollBartimer;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.HScrollBar hScrollBardt;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.MenuItem menueItemManual;
		private System.Windows.Forms.MenuItem menuItemDistribution;
		private System.Windows.Forms.MenuItem menuItemRandom;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.MenuItem menuItemExit;
		private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MenuItem menuItemRegular;
		private System.ComponentModel.IContainer components;

		public BilliardForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//

			ValueOfFasting();
			ValueOfPrecision();


			timer = new Timer();
			timer.Interval = interval;
			width = pictureBox1.Width;
			height= pictureBox1.Height;
			myTable = new Table(width, height);
			Default();

			CreateRegularBalls();
			
			pictureBox1.Paint+=new PaintEventHandler(pictureBox1_Paint);

			TurnOnAllMouseHandle();

			string aboutballs = "Press left button and hold it to moving the ball."+
				"\r\n"+ "Press right button to changing the ball's properties."  ;
			toolTip1.SetToolTip(pictureBox1, aboutballs);
			
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BilliardForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItemFile = new System.Windows.Forms.MenuItem();
            this.menuItemExit = new System.Windows.Forms.MenuItem();
            this.menuItemDistribution = new System.Windows.Forms.MenuItem();
            this.menuItemRandom = new System.Windows.Forms.MenuItem();
            this.menueItemManual = new System.Windows.Forms.MenuItem();
            this.menuItemRegular = new System.Windows.Forms.MenuItem();
            this.buttonPause = new System.Windows.Forms.Button();
            this.hScrollBartimer = new System.Windows.Forms.HScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.hScrollBardt = new System.Windows.Forms.HScrollBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(16, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 500);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.SystemColors.Control;
            this.buttonStart.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.ForeColor = System.Drawing.Color.Black;
            this.buttonStart.Location = new System.Drawing.Point(136, 40);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(80, 24);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemFile,
            this.menuItemDistribution});
            // 
            // menuItemFile
            // 
            this.menuItemFile.Index = 0;
            this.menuItemFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemExit});
            this.menuItemFile.Text = "&File";
            // 
            // menuItemExit
            // 
            this.menuItemExit.Index = 0;
            this.menuItemExit.Text = "Exit";
            this.menuItemExit.Click += new System.EventHandler(this.menuItemExit_Click);
            // 
            // menuItemDistribution
            // 
            this.menuItemDistribution.Index = 1;
            this.menuItemDistribution.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemRandom,
            this.menueItemManual,
            this.menuItemRegular});
            this.menuItemDistribution.Text = "&Distribution";
            // 
            // menuItemRandom
            // 
            this.menuItemRandom.Index = 0;
            this.menuItemRandom.Text = "Random";
            this.menuItemRandom.Click += new System.EventHandler(this.menuItemRandom_Click_1);
            // 
            // menueItemManual
            // 
            this.menueItemManual.Index = 1;
            this.menueItemManual.Text = "Manual";
            this.menueItemManual.Click += new System.EventHandler(this.menueItemManual_Click);
            // 
            // menuItemRegular
            // 
            this.menuItemRegular.Index = 2;
            this.menuItemRegular.Text = "Regular";
            this.menuItemRegular.Click += new System.EventHandler(this.menuItemRegular_Click);
            // 
            // buttonPause
            // 
            this.buttonPause.BackColor = System.Drawing.SystemColors.Control;
            this.buttonPause.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonPause.Enabled = false;
            this.buttonPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPause.ForeColor = System.Drawing.Color.Black;
            this.buttonPause.Location = new System.Drawing.Point(232, 40);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(80, 24);
            this.buttonPause.TabIndex = 2;
            this.buttonPause.Text = "Pause";
            this.buttonPause.UseVisualStyleBackColor = false;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // hScrollBartimer
            // 
            this.hScrollBartimer.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.hScrollBartimer.LargeChange = 1;
            this.hScrollBartimer.Location = new System.Drawing.Point(32, 24);
            this.hScrollBartimer.Maximum = 20;
            this.hScrollBartimer.Name = "hScrollBartimer";
            this.hScrollBartimer.Size = new System.Drawing.Size(136, 16);
            this.hScrollBartimer.TabIndex = 6;
            this.hScrollBartimer.Value = 17;
            this.hScrollBartimer.ValueChanged += new System.EventHandler(this.hScrollBartimer_ValueChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 24);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(29, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Slow";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(168, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fast";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.hScrollBardt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.hScrollBartimer);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(544, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(272, 72);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Animation of Balls";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(192, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Precision";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(192, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Timer";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hScrollBardt
            // 
            this.hScrollBardt.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.hScrollBardt.LargeChange = 1;
            this.hScrollBardt.Location = new System.Drawing.Point(32, 48);
            this.hScrollBardt.Maximum = 39;
            this.hScrollBardt.Name = "hScrollBardt";
            this.hScrollBardt.Size = new System.Drawing.Size(136, 16);
            this.hScrollBardt.TabIndex = 7;
            this.hScrollBardt.Value = 21;
            this.hScrollBardt.ValueChanged += new System.EventHandler(this.hScrollBardt_ValueChanged);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label3.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(8, 48);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(24, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Less";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label4.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(168, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "More";
            // 
            // checkBox1
            // 
            this.checkBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.checkBox1.ForeColor = System.Drawing.Color.Black;
            this.checkBox1.Location = new System.Drawing.Point(8, 48);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(202, 24);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Show the number of each balls";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(16, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "x ------>";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 10;
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 10;
            this.toolTip1.ReshowDelay = 2;
            // 
            // checkBox2
            // 
            this.checkBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.checkBox2.ForeColor = System.Drawing.Color.Black;
            this.checkBox2.Location = new System.Drawing.Point(8, 24);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(184, 24);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "Showing  3D";
            this.checkBox2.UseVisualStyleBackColor = false;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(320, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(216, 74);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Graphics";
            // 
            // BilliardForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(830, 595);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonPause);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.Silver;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Menu = this.mainMenu1;
            this.Name = "BilliardForm";
            this.Text = "Billiard Elastic Balls ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

        
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new BilliardForm());
		}
        
//------------------------------------------------------------
		private void Default()
		{
			numBalls = 100;
			radius   = 10;
			maxSpeed = 50;
			minSpeed = 40;
			mueG     = 0.00F;
			isBlueColor   = true;
			isRandomColor = false;
		}

//-----------------------------------------------------------
		private void GetDataFromDistributionForm()
		{
			numBalls = formDistribution.numBalls;
			radius   = formDistribution.radius;
			maxSpeed = formDistribution.maxSpeed;
			minSpeed = formDistribution.minSpeed;
			mueG     = formDistribution.mueG;
			isBlueColor   = formDistribution.isBlueColor;
			isRandomColor = formDistribution.isRandomColor;

		}

		private void SetDataToDistributionForm()
		{
			formDistribution.numBalls = numBalls ;
			formDistribution.radius   = radius   ;
			formDistribution.maxSpeed = maxSpeed ;
			formDistribution.minSpeed = minSpeed;
			formDistribution.mueG     =  mueG   ;
			formDistribution.isBlueColor   = isBlueColor;
			formDistribution.isRandomColor = isRandomColor;

		}
//----------------------------

		private bool IsAllBallsStoped()
		{

			for(int i=0; i<balls.Length; i++)
			{
				if(balls[i] == null)
					break;

				if(balls[i].V != 0 )
					return false;
			}

			return true;
		}
//-------------------------
		private void CreationBalls()
		{
			this.Cursor = Cursors.WaitCursor;

			balls = new Ball[numBalls];
			tempBalls = new Ball[numBalls];



			Random rand = new Random();

			
			for(int i=0; i<balls.Length; i++)
			{
				uint counter=0;

			loop1:
				
				float p = rand.Next((int)radius+1, (int)(width-radius)-1);
				float q = rand.Next((int)radius+1, (int)(height-radius)-1);
				float theta = rand.Next(1001)/167F;
				float v = rand.Next( (int)minSpeed,(int)maxSpeed +1);


				Color color ;
				if(isRandomColor)
					color = Color.FromArgb(rand.Next(256),rand.Next(256),rand.Next(256));	
				else 
					color = Color.Blue;

				balls[i] = new Ball(p,q,radius,theta,v,mueG,color,myTable);
				tempBalls[i] =new Ball(p,q,radius,theta,v,mueG,color,myTable);

				

				for(int j=0;j<i;j++)
					if(Ball.IsContactedTwoBall(balls[i],balls[j]))
					{
						counter++;
						if(counter >= 1000000)
						{
							pictureBox1.Invalidate();

							MessageBox.Show("Just "+Convert.ToString(i)+" balls can been in this Table !",
							"Warning",MessageBoxButtons.OK,MessageBoxIcon.Information);

							balls[i] = null;
							tempBalls[i] = null;
	
							goto loop2;
						}
						else
							goto loop1;
	
					}
				
			}// End for

		loop2:
			this.Cursor = Cursors.Default;
			
		}// end Creation Balls

//------------------------------------------------------
		private void CreateRegularBalls()
		{
			const float c = 1.5F;
			numBalls = 16;
			balls = new Ball[numBalls];
			tempBalls = new Ball[numBalls];
			float r = 25;
			Color color = Color.Blue;

			PointF[][] apfs = new PointF[5][];

			for(int i=0; i<apfs.GetLength(0); i++)
			{
				apfs[i] = new PointF[i+1];

				if( (apfs[i].Length % 2) !=0)
				{
					for(int j=0; j<apfs[i].Length; j++)
					{
						apfs[i][j] = new PointF(
							width/2  + (i)*2*(r-2),
							height/2 - (apfs[i].Length-1)*(r+c) +  2*(r+c)*j);
					}
				}
				else
				{
					for(int j=0; j<apfs[i].Length; j++)
					{
						apfs[i][j] = new PointF(
							width/2  +  (i)*2*(r-2),
							height/2 - (apfs[i].Length-1)*(r+c) +  2*(r+c)*j);
					}
				}
			}


			int k =1;
			float v =0;
			for(int i = 0 ;i<apfs.GetLength(0) ; i++)
			{
				for(int j=0; j< apfs[i].Length; j++)
				{
					balls[k] = new Ball(apfs[i][j].X, apfs[i][j].Y, r, 0, v, 20, color, myTable);
					tempBalls[k] = new Ball(apfs[i][j].X, apfs[i][j].Y, r, 0, v, 20, color, myTable);

					k++;
				}

			}

			color = Color.Purple;
			v = 400;
			balls[0] = new Ball(2+r, height/2, r, 0, v, 20, color, myTable);
			tempBalls[0] = new Ball(2+r, height/2, r, 0, v, 20, color, myTable);
				
//			loop2 :
//				float p = rand.Next((int)r+1, (int)(width-r)-1);
//				float q = rand.Next((int)r+1, (int)(height-r)-1);
//				float v =0;
//				if(i ==0)
//					v = 400;
//
//				balls[i]     = new Ball(p, q, r, 0, v, 10, color, myTable); 
//				tempBalls[i] = new Ball(p, q, r, 0, v, 10, color, myTable); 
//
//				for(int j=0;j<i;j++)
//					if(Ball.IsContactedTwoBall(balls[i],balls[j]))
//					{
//						goto loop2;	
//					}
			

		
		
		} // End CreateShuffleBalls

//----------------------------------------------
		private void ValueOfFasting()
		{
			for(int i=0;i<=hScrollBartimer.Maximum; i++)
				if(hScrollBartimer.Value == i)
					interval = 101 - 5*i;
			
		}

		private void ValueOfPrecision()
		{
			for(int i=0;i<=hScrollBardt.Maximum; i++)
			
				if(hScrollBardt.Value ==i)
				{
					if(i <=12)
						dt = (float)(0.7 - i/20.0);
					else if(i<=21)
						dt = (float)(0.1 - (i-12)/100.0);
					else if(i<=30)
						dt = (float)(0.01 - (i-21)/1000.0);
					else if(i<=39)
						dt = (float)(0.001 - (i-30)/10000.0);
				}		
		}
//------------------------------------------------------

		private void timer_Tick(object sender, EventArgs e)
		{		
			
			Ball.UpadateMovingBalls(balls,dt);

			if(IsAllBallsStoped())
			{
				
				timer.Tick -=new EventHandler(timer_Tick);
				MessageBox.Show(" All balls are in Stationary.");
				buttonStart.Text = "Reset";
				buttonPause.Text = "Continue";
				TurnOffAllMouseHandle();
				TurnOnAllMouseHandle();


			}

			pictureBox1.Invalidate();

		}


		private void pictureBox1_Paint(object sender, PaintEventArgs pea)
		{
			Graphics g = pea.Graphics;
			
			for(int i =0 ;i<balls.Length; i++)
			{
				if(balls[i]== null)
					break;

				if(checkBox2.Checked)
					balls[i].Paint3D(g);
				else
					balls[i].Paint(g);	
				

				if(checkBox1.Checked)
				{
					string st = Convert.ToString(i+1);
					Font font = new Font("Microsoft Sans Serif", balls[i].Radius/1.7F,FontStyle.Regular);
					g.DrawString(st,font,new SolidBrush(Color.White),balls[i].X-balls[i].Radius/2,
						balls[i].Y-balls[i].Radius/2);
				}

			}

		}



		private void buttonStart_Click(object sender, System.EventArgs e)
		{
			TurnOffAllMouseHandle();
			toolTip1.RemoveAll();

			if(((Button)sender).Text == "Start")
			{	
				buttonPause.Text = "Pause";
				buttonPause.Enabled= true;
				buttonStart.Text = "Stop";				
				
				timer.Tick +=new EventHandler(timer_Tick);
				timer.Start();
			}		
			else if( ((Button)sender).Text == "Stop")
			{
				buttonPause.Text = "Pause";
				buttonPause.Enabled  = true;
				buttonStart.Text = "Reset";

				timer.Tick -=new EventHandler(timer_Tick);
		
			}
			else if(((Button)sender).Text == "Reset")
			{
				string aboutballs = "Press left button and hold it to moving the ball."+
					"\r\n"+ "Press right button to changing the ball's properties."  ;
				toolTip1.SetToolTip(pictureBox1, aboutballs);


				buttonPause.Text = "Pause";
				buttonPause.Enabled  = false;
				buttonStart.Text = "Start";


				for(int i =0; i<balls.Length; i++)
				{
					if(tempBalls[i] != null)
					{
						balls[i] = new Ball(tempBalls[i].X,tempBalls[i].Y,tempBalls[i].Radius,
							tempBalls[i].Theta,tempBalls[i].V,tempBalls[i].MueG,
							tempBalls[i].Color,tempBalls[i].GetSetTable);
					}
				}

				TurnOnAllMouseHandle();
				
				
			}		
			pictureBox1.Invalidate();
		}

		
		
		private void buttonPause_Click(object sender, System.EventArgs e)
		{
			TurnOffAllMouseHandle();

			if(((Button)sender).Text == "Pause")
			{
				buttonPause.Text = "Continue";
				timer.Tick -=new EventHandler(timer_Tick);


			}
			else if(((Button)sender).Text == "Continue")
			{
				buttonStart.Text = "Stop";

				buttonPause.Text = "Pause";
				timer.Tick +=new EventHandler(timer_Tick);
			}
		
		}

		private void hScrollBartimer_ValueChanged(object sender, System.EventArgs e)
		{
			int i = ((HScrollBar)sender).Value;
			interval = 101 - 5*i;
			timer.Interval = interval;
		}

//------------------------

			
		

		private void hScrollBardt_ValueChanged(object sender, System.EventArgs e)
		{
			int i = ((HScrollBar)sender).Value;
			if(i <=12)
				dt = (float)(0.7 - i/20.0);
			else if(i<=21)
				dt = (float)(0.1 - (i-12)/100.0);
			else if(i<=30)
				dt = (float)(0.01 - (i-21)/1000.0);
			else if(i<=39)
				dt = (float)(0.001 - (i-30)/10000.0);

		
		}

		private void menueItemManual_Click(object sender, System.EventArgs e)
		{
			timer.Tick -=new EventHandler(timer_Tick);
			

			FormManual formManual = new FormManual();
			formManual.ShowDialog();

			if(formManual.isPresedFinish)
			{
				TurnOffAllMouseHandle();

				balls = new Ball[formManual.myballs.Length];
				tempBalls = new Ball[balls.Length];

				for(int i=0; i<balls.Length; i++)
				{
					balls[i] = formManual.myballs[i];
					tempBalls[i] = new Ball(balls[i].X,balls[i].Y,balls[i].Radius,
						balls[i].Theta,balls[i].V,balls[i].MueG,
						balls[i].Color,balls[i].GetSetTable);
				}

				buttonStart.Text = "Start";

				TurnOnAllMouseHandle();
			}
			else// isPresedFinish = false
			{
				buttonPause.Text = "Continue";
				buttonStart.Text = "Reset";

			}

			pictureBox1.Invalidate();

		
		}

		private void menuItemRandom_Click_1(object sender, System.EventArgs e)
		{
			timer.Tick -=new EventHandler(timer_Tick);
			


			formDistribution = new FormRandomDistribution(numBalls,radius,maxSpeed,minSpeed,mueG,isRandomColor,isBlueColor);

		    
			formDistribution.ShowDialog();


			if(formDistribution.isOkPerresdFormRandomDistribution)
			{
				TurnOffAllMouseHandle();

				GetDataFromDistributionForm();
				CreationBalls();
				buttonPause.Enabled = false;
				buttonStart.Enabled = true;
				buttonStart.Text = "Start";

				TurnOnAllMouseHandle();
			}
			else
			{
				buttonPause.Enabled = true;
				buttonPause.Text = "Continue";
				buttonStart.Text = "Reset";


			}
			pictureBox1.Invalidate();
		
		}

		private void menuItemRegular_Click(object sender, System.EventArgs e)
		{
			timer.Tick -=new EventHandler(timer_Tick);
			TurnOffAllMouseHandle();
			isCaughtBall = false;

			buttonPause.Enabled = false;
			buttonStart.Enabled = true;
			buttonStart.Text = "Start";

			CreateRegularBalls();

			TurnOnAllMouseHandle();

			pictureBox1.Invalidate();
		
		}

		
		private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
		{
			if(e.Button == MouseButtons.Left)
			{
				for(int i=0; i<balls.Length; i++)
					if(balls[i] != null && balls[i].IsContainThisPoint(e.X, e.Y))
					{

						isCaughtBall  = true;
						intballCaught = i;

						dx = e.X - balls[i].X;
						dy = e.Y - balls[i].Y;
						break;
					}
			}
			else if(e.Button == MouseButtons.Right)
			{
				int i;
				for(i=0; i<balls.Length; i++)
					if(balls[i] != null && balls[i].IsContainThisPoint(e.X, e.Y))
					{
						float speed = balls[i].V;
						float angle = balls[i].Theta;
						float mueg  = balls[i].MueG;
						float radius= balls[i].Radius;
						float xcenter = balls[i].X;
						float ycenter = balls[i].Y;

						Color color = balls[i].Color ;

						FormForEachBall formforEachball = new FormForEachBall(i+1,radius,speed,angle
							,mueg,color, xcenter,ycenter);
				
						formforEachball.Location = pictureBox1.PointToScreen(new Point(e.X,e.Y));
						formforEachball.ShowDialog();

						balls[i].V = formforEachball.speed;
						balls[i].Theta = formforEachball.angle;
						balls[i].MueG  = formforEachball.mueg;
						balls[i].Color = formforEachball.color;
						balls[i].Radius= formforEachball.radius;

						for(int j=0; j<balls.Length; j++)
							if( j!=i && balls[j]!=null &&
										(Ball.IsContactedTwoBall(balls[i],balls[j]) ||
										! balls[i].IsBallInsideTable(balls[i].GetSetTable)) )
							{
								balls[i].Radius = radius;
								break;
							}
						

								break;
					}// for i

			
			}// end else
			pictureBox1.Invalidate();
			
			
		}

		private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
		{

			if(!isCaughtBall)
			{
				bool changing = false;

				for(int i=0; i<balls.Length; i++)
				{
					if(balls[i] != null && balls[i].IsContainThisPoint(e.X, e.Y))
					{
						changing = true;
						this.Cursor = Cursors.Hand;

						
						break;
					}
					
				}
				if(! changing)
					this.Cursor = Cursors.Arrow;
			}
			

			if( e.Button == MouseButtons.Left  && isCaughtBall)
			{
				this.Cursor = Cursors.Cross;

				balls[intballCaught].X = e.X - dx;
				balls[intballCaught].Y = e.Y - dy;
				
				
				if(balls[intballCaught].X+ balls[intballCaught].Radius > width)
					Cursor.Position = pictureBox1.PointToScreen(new Point(e.X-2,e.Y));
				if(balls[intballCaught].Y+ balls[intballCaught].Radius > height)
					Cursor.Position = pictureBox1.PointToScreen(new Point(e.X,e.Y-2));
				if(balls[intballCaught].X - balls[intballCaught].Radius < 0)
					Cursor.Position = pictureBox1.PointToScreen(new Point(e.X+2,e.Y));
				if(balls[intballCaught].Y - balls[intballCaught].Radius < 0)
					Cursor.Position = pictureBox1.PointToScreen(new Point(e.X,e.Y+2));
				


				for(int j =0 ; j<balls.Length; j++)
				{
					if(balls[j] == null)
						break;

					if(j != intballCaught && Ball.IsContactedTwoBall(balls[intballCaught], balls[j]))
					{
						float x1F,y1F;
						PushBackCurser(balls[intballCaught], balls[j], out x1F,out y1F);
						Cursor.Position = pictureBox1.PointToScreen(new Point((int)(x1F+dx),
							(int)(y1F+dy) ) );
					}

				}// for
				
			}// if outer

			pictureBox1.Invalidate();

		}
//---------------------------------------------
		private void PushBackCurser(Ball ball1, Ball ball2, out float x1F, out float y1F)
		{
			float r1 = ball1.Radius;
			float r2 = ball2.Radius;
			float r  = (float)Math.Sqrt( Math.Pow(ball2.X-ball1.X,2) + Math.Pow(ball2.Y-ball1.Y,2) );

			float phi = (float)Math.Atan((ball2.Y - ball1.Y) /(ball2.X - ball1.X));

			float dr = (r1+r2 - r)+1 ;
			float cosPhi = (float)Math.Abs(Math.Cos(phi));
			float sinPhi = 1 - cosPhi*cosPhi;

			
			if(ball1.X > ball2.X)
			{
				x1F = ball1.X + dr*cosPhi;

			}
			else
			{
				x1F = ball1.X - dr*cosPhi;
			}
			
			if(ball1.Y > ball2.Y)
			{
				y1F = ball1.Y + dr*sinPhi;
			}
			else
			{
				y1F = ball1.Y - dr*sinPhi;
			}//

		}

		private void TurnOffAllMouseHandle()
		{
			pictureBox1.MouseDown -=new MouseEventHandler(pictureBox1_MouseDown);
			pictureBox1.MouseUp   -=new MouseEventHandler(pictureBox1_MouseUp);
			
			pictureBox1.MouseMove -=new MouseEventHandler(pictureBox1_MouseMove);

		}
		private void TurnOnAllMouseHandle()
		{
			pictureBox1.MouseDown +=new MouseEventHandler(pictureBox1_MouseDown);
			pictureBox1.MouseUp   +=new MouseEventHandler(pictureBox1_MouseUp);
			
			pictureBox1.MouseMove +=new MouseEventHandler(pictureBox1_MouseMove);

		}
//----------------------------------------
		private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
		{
			this.Cursor = Cursors.Arrow;

			if(isCaughtBall && e.Button == MouseButtons.Left)
			{
				for(int i=0; i<balls.Length; i++)
					if(balls[i] != null && balls[i].IsContainThisPoint(e.X, e.Y))
					{
						isCaughtBall  = false;
						break;
					}
			}

			pictureBox1.Invalidate();

		}

		private void checkBox2_CheckedChanged(object sender, System.EventArgs e)
		{
			pictureBox1.Invalidate();
		}

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			pictureBox1.Invalidate();
		}

		private void menuItemExit_Click(object sender, System.EventArgs e)
		{
			DialogResult key = MessageBox.Show("Are you want to exit?","Exit?",
				MessageBoxButtons.OKCancel,MessageBoxIcon.Question,
				MessageBoxDefaultButton.Button2);

			if(key == DialogResult.OK)
				Application.Exit();
		}

		
//***************************************************
//*************************************************
//***************************************************
	}// End BilliardGame
}//End NmaeSpace
