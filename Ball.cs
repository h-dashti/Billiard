using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace BilliradGame
{
	/// <summary>
	/// Summary description for Ball.
	/// </summary>
	public class Ball
	{
		private float x,y,v,theta,radius,mueG;
		private Color color;
		private Table table;


		public  Ball()
		{			
		}
		public Ball(float x,float y,float radius,float theta,float v,
									float mueG, Color color,Table table)
		{
			this.x = x;
			this.y = y;
			this.v = v;
			this.theta = theta;
			this.radius= radius;
			this.mueG  = mueG;
			this.color = color;
			this.table = table;

//			if( !table.Contains(this.x-this.radius,this.y-this.radius) ||
//				!table.Contains(this.x+this.radius,this.y+this.radius))
//				throw new Exception("The position of ball must be inside Table.");
		}
		public float X
		{
			get{return this.x;}
			set{this.x = value;}
		}
		public float Y
		{
			get{return this.y;}
			set{this.y = value;}
		}
		public float V
		{
			get{return this.v;}
			set{this.v = value;}
		}
		public float Theta
		{
			get{return this.theta;}
			set{this.theta = value;}
		}
		public float Radius
		{
			get{return this.radius;}
			set{this.radius = value;}
		}
		public float MueG
		{
			get{return this.mueG;}
			set{this.mueG = value;}
		}
		public Color Color
		{
			get{return this.color;}
			set{this.color = value;}
		}
		public Table GetSetTable
		{
			get{return this.table;}
			set{this.table = value;}
		}
		public void SetState(float x,float y,float v,float theta)
		{
			this.x = x;
			this.y = y;
			this.v = v;
			this.theta = theta;
		}
		

		private void Move(float dt)
		{
			if(this.v>0)
			{
				this.x += (this.v*dt - this.mueG*dt*dt/2) * (float)Math.Cos(this.theta) ;
				this.y += (this.v*dt - this.mueG*dt*dt/2) * (float)Math.Sin(this.theta) ;
				this.v += -this.mueG * dt;
			}
			else
			{
				this.v = 0;
			}	

			if( !table.Contains(this.x-this.radius ,this.y-this.radius ) ||
				!table.Contains(this.x+this.radius ,this.y+this.radius ))

						this.table.Reflect(this);
			
		}//End Move Ball

		public void Paint(Graphics g)
		{

			g.FillEllipse(new SolidBrush(this.color), this.x - this.radius,
						  this.y - this.radius, 2*this.radius,2*this.radius);
		}

		
		public void Paint3D(Graphics g)
		{
			RectangleF rect = new RectangleF(this.x - this.radius,
				this.y - this.radius, 2*this.radius,2*this.radius);

			GraphicsPath graphPath = new GraphicsPath();
			graphPath.AddEllipse(rect);

			
			PathGradientBrush pathGradienBrush = new PathGradientBrush(graphPath);


			pathGradienBrush.CenterPoint = new PointF(
				(rect.Left + rect.Width/3),
				(rect.Top  + rect.Height/3));

		
			pathGradienBrush.CenterColor = Color.White;
			pathGradienBrush.SurroundColors = new Color[]{this.color};

			g.FillRectangle(pathGradienBrush,rect);
		}
//----------------------------------------------	
		public static bool IsContactedTwoBall(Ball ball1, Ball ball2)
		{
			return (float)Math.Sqrt( Math.Pow(ball2.x-ball1.x,2) +
									 Math.Pow(ball2.y-ball1.y,2) ) <=
				   ball1.radius + ball2.radius ;
				
			
		}

//-----------------------------------------------

		private static void ContactTwoBalls(Ball ball1, Ball ball2)
		{
			float phi = (float)Math.Atan((ball2.y - ball1.y) /(ball2.x - ball1.x));
	
			
			// the velocity in new cordinate System(normal to our original refrence)
			float v1xr = (float)(ball1.v * Math.Cos(ball1.theta - phi));
			float v1yr = (float)(ball1.v * Math.Sin(ball1.theta - phi));
			float v2xr = (float)(ball2.v * Math.Cos(ball2.theta - phi));
			float v2yr = (float)(ball2.v * Math.Sin(ball2.theta - phi));

			float m1 = (float)Math.Pow(ball1.radius,3);
			float m2 = (float)Math.Pow(ball2.radius,3);


			// the finali velocity afther colision in new cordinate
			float v1FxR = ((m1-m2)*v1xr+(m2+m2)*v2xr)/(m1+m2) ;
			float v2FxR = ((m1+m1)*v1xr+(m2-m1)*v2xr)/(m1+m2) ;
			float v1FyR = v1yr;
			float v2FyR = v2yr;


			// the finali velocity in original system
			float v1Fx  = (float)Math.Cos(phi)*v1FxR+(float)Math.Cos(phi + Math.PI/2)*v1FyR ;
			float v1Fy  = (float)Math.Sin(phi)*v1FxR+(float)Math.Sin(phi + Math.PI/2)*v1FyR ;
			float v2Fx  = (float)Math.Cos(phi)*v2FxR+(float)Math.Cos(phi + Math.PI/2)*v2FyR ;
			float v2Fy  = (float)Math.Sin(phi)*v2FxR+(float)Math.Sin(phi + Math.PI/2)*v2FyR ;



			float v1F = (float)Math.Sqrt(v1Fx*v1Fx + v1Fy*v1Fy) ;
			float v2F = (float)Math.Sqrt(v2Fx*v2Fx + v2Fy*v2Fy) ;

			float theta1F = (float)Math.Atan2(v1Fy, v1Fx );
			float theta2F = (float)Math.Atan2(v2Fy, v2Fx );


			// the location of balls
			float r1 = ball1.radius;
			float r2 = ball2.radius;
			float r  = (float)Math.Sqrt( Math.Pow(ball2.x-ball1.x,2) + Math.Pow(ball2.y-ball1.y,2) );

			float dr = (r1+r2 - r)/2 ;
			float cosPhi = (float)Math.Abs(Math.Cos(phi));
			float sinPhi = 1 - cosPhi*cosPhi;

			float x1F,x2F,y1F,y2F;
			
			if(ball1.x > ball2.x)
			{
				x1F = ball1.x + dr*cosPhi;
				x2F = ball2.x - dr*cosPhi;

			}
			else
			{
				x1F = ball1.x - dr*cosPhi;
				x2F = ball2.x + dr*cosPhi;
			}
			
			if(ball1.y > ball2.y)
			{
				y1F = ball1.y + dr*sinPhi;
				y2F = ball2.y - dr*sinPhi;
			}
			else
			{
				y1F = ball1.y - dr*sinPhi;
				y2F = ball2.y + dr*sinPhi;
			}//



			ball1.SetState(x1F, y1F, v1F, theta1F);
			ball2.SetState(x2F, y2F, v2F, theta2F);
			


		}// End Contact Two balls

		public static bool IsDistributionCorrect(Ball[] myBall)
		{

			for(int i=0; i<myBall.Length-1; i++)
				for(int j=i+1; j<myBall.Length; j++)
					if(IsContactedTwoBall(myBall[i], myBall[j]))
						return false;		

			return true;

		}// End IsDistributionCorrect

//----------------------------------------

		//
		public static void UpadateMovingBalls(Ball[] balls, float dt)
		{
			for(int i =0 ;i<balls.Length; i++)
				if(balls[i] != null)
					balls[i].Move(dt);



			byte[] bytes = new byte[balls.Length];

			for(int i = 0; i<balls.Length-1; i++)
			{
				if(balls[i] == null)
					break;

				if(bytes[i] == 1)
					continue;   // if a Ball is collided

				for(int j=i+1; j<balls.Length; j++)
				{
					if(balls[j] == null)
						break;

					if(bytes[j] ==1)
						continue;

					if(Ball.IsContactedTwoBall(balls[i], balls[j]))
					{
						bytes[i] = 1;
						bytes[j] = 1;

						Ball.ContactTwoBalls(balls[i], balls[j]);
					}
				}
			}// i

		} // End UpadateMovingBalls
//-------------------------------------------------------------
		public bool IsContainThisPoint(float p, float q)
		{
			float r = (float)Math.Sqrt((this.x-p)*(this.x - p) + (this.y -q)*(this.y - q));

			if(r <= this.radius)
				return true;
			else
				return false;

		}// End IsContainThisPoint

		public bool IsBallInsideTable(Table table1)
		{
			if( table1.Contains(this.x-this.radius ,this.y-this.radius ) &&
				table1.Contains(this.x+this.radius ,this.y+this.radius ))
				return true;
			else
				return false;

		}

//---------------------------------------------------------


	}// End Billiard Class
}// End NameSapce
