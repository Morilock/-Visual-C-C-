using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;


namespace DRAW
{
    [Serializable]
    public abstract class BaseShape
    {
        public abstract BaseShape copySelf();       		         //复制自身
        public abstract bool catchShape(Point testPoint);//判断是否可以抓取图形
        private bool isSelected = false;		//标识图形是否被选中
        private Point p1;       			//第一个热点
        private Point p2;       			//第二个热点
        public Color penColor;  			//画笔的颜色
        public int penwidth;    			//画笔的宽度
        public void setSelected()			//设置为选中状态
        { this.isSelected = true; }
        public void setUnSelected()			//设置为非选中状态
        { this.isSelected = false; }
        public Point getP1()        		//获取第一个热点
        { return p1; }
        public void setP1(Point p1) 			//设置第一个热点
        { this.p1 = p1; }
        public Point getP2()				//获取第二个热点
        { return p2; }
        public void setP2(Point p2)			//设置第二个热点
        { this.p2 = p2; }
        public void setHitPoint(int hitPointIndex, Point newPoint)			//设置热点
        {
            switch (hitPointIndex)
            {
                case 0:
                    {
                        Point tempPoint = new Point();            	//0索引相对的坐标
                        tempPoint.X = this.getP1().X + newPoint.X;		//加上X坐标的增量
                        tempPoint.Y = this.getP1().Y + newPoint.Y;		//加上Y坐标的增量
                        this.setP1(tempPoint);
                        tempPoint = new Point();
                        tempPoint.X = this.getP2().X + newPoint.X;
                        tempPoint.Y = this.getP2().Y + newPoint.Y;
                        this.setP2(tempPoint);
                        break;
                    }
                case 1:
                    {
                        this.setP1(newPoint);						//设置P1的热点
                        break;
                    }
                case 2:
                    {
                        this.setP2(newPoint);						//设置P2的热点
                        break;
                    }
            }
        }
        public void superDraw(Graphics g)       //公共画法,如果被选中则画所有的热点
        {
            if (this.isSelected)
            {
                Point[] allHitPoint = this.getAllHitPoint();
                for (int i = 0; i < 2; i++)
                {
                    g.DrawEllipse(new Pen(Color.Red, 1), allHitPoint[i].X - 3, allHitPoint[i].Y - 3, 6, 6);
                }
            }
        }
        private Point[] getAllHitPoint() 					//获取所有的热点
        {
   	        Point[] allHitPoint = new Point[2];
    	    allHitPoint[0] = this.getP1();
    	    allHitPoint[1] = this.getP2();
    	    return allHitPoint;
        }
        public int catchShapPoint(Point testPoint)			//抓取图形返回热点索引数
        {
   	        int hitPointIndex = -1;
    	    Point[] allHitPoint = this.getAllHitPoint();		//调用获取所有的热点方法
    	    for (int i = 0; i < allHitPoint.Length; i++)		//循环捕捉并判断
    	    {
    	        if (Math.Pow((allHitPoint[i].X - testPoint.X), 2) + Math.Pow((allHitPoint[i].Y - testPoint.Y), 2) 				< 36)
        	    {	return i + 1;   }				//如果捕捉到了热点，返回热点的索引
    	    }
    	    if (this.catchShape(testPoint))
    	        {	return 0;    }					//没有捕捉到热点，捕捉到了图形，返回特别热点
    	    return hitPointIndex;					//返回捕捉到的热点
        }

    }
}
