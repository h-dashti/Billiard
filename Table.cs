using System;

namespace BilliradGame
{
	/// <summary>
	/// Summary description for Table.
	/// </summary>
	public class Table
	{
		private float width,height;

		public Table(float width,float height)
		{
			if(width<=0 && height<=0)
				throw new Exception("Table dimentions must be positive.");
			this.width  = width;
			this.height = height;
		}

		public float getWidth
		{
			get{return width;}
		}
		public float getHeight
		{
			get{return height;}
		}


		public bool Contains(float p, float q)
		{
			return (p >=0) && (q>=0) && (p<=width) && (q<=height) ;
		}


		public void Reflect(Ball ball)
		{
			float x = ball.X;
			float y = ball.Y;
			float v = ball.V;
			float theta = ball.Theta;
			float radius= ball.Radius;

			if( x-radius <=0)
			{
                x = radius;
				theta = (float)Math.PI - theta;
			}
			else if(x+radius >= ball.GetSetTable.getWidth)
			{
				x = ball.GetSetTable.getWidth -radius;
				
				theta = (float)Math.PI - theta;
			}

			if(y-radius  <= 0)
			{
				y = radius;
				
				theta = -theta;
			}
			else if(y+radius >= ball.GetSetTable.getHeight)
			{
				y = ball.GetSetTable.getHeight - radius;
				
				theta = -theta;
			}

			ball.SetState(x,y,v,theta);

		}// End Rfelect

	}//End Class
}// End NameSpace
