using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;


namespace DRAW
{
    [Serializable]
    class LineShape : BaseShape
    {
        public override BaseShape copySelf()		//重写身复制方法
        {
            LineShape copyLineShape = new LineShape();
            copyLineShape.setP1(this.getP1());		//复制起点
            copyLineShape.setP2(this.getP2());		//复制终点
            copyLineShape.penColor = this.penColor;
            copyLineShape.penwidth = this.penwidth;
            return copyLineShape;
        }
        public override bool catchShape(Point p3)        
        {
    	    Point p1 = this.getP1();//开始点
    	    Point p2 = this.getP2();//结束点
    	    double iLen1 = Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2);
    	    double iLen2 = Math.Pow(p1.X - p3.X, 2) + Math.Pow(p1.Y - p3.Y, 2);
    	    double iLen3 = Math.Pow(p2.X - p3.X, 2) + Math.Pow(p2.Y - p3.Y, 2);
    	    if (Math.Pow(iLen2, 0.5) + Math.Pow(iLen3, 0.5) - Math.Pow(iLen1, 0.5) < 0.1)
    	    {	return true;		}
    	    else
    	    {	return false;	}
        }

    }
}
