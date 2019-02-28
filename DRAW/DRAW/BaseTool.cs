using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;


namespace DRAW
{
    public abstract class BaseTool
    {
        /*鼠标按下的处理*/
        public abstract void mouseDown(object sender, MouseEventArgs e, DRAWForm drawForm);
        public abstract void mouseDrag(object sender, MouseEventArgs e);      //鼠标拖动的处理
    
        private DRAWForm refDRAWPanel = null;       		//当前画板
        private Point downPoint = new Point();      			//鼠标按下点
        private Point newDragPoint = new Point();   			//新的鼠标拖动点
        private Point oldDragPoint = new Point();   				//旧的鼠标拖动点
        private BaseShape operShape = null;         			//操作图形
        /*获取和设置字段*/
        public Point getDownPoint()                 			//获取鼠标按下点
        { return downPoint; }
        public void setDownPoint(Point downPoint)   			//设置鼠标按下点
        { this.downPoint = downPoint; }
        public Point getNewDragPoint()          				//获取新的鼠标拖动点
        { return newDragPoint; }
        public void setNewDragPoint(Point newDragPoint)			//设置新的鼠标拖动点
        { this.newDragPoint = newDragPoint; }
        public Point getOldDragPoint()						//获取旧的鼠标拖动点
        { return oldDragPoint; }
        public void setOldDragPoint(Point oldDragPoint)			//设置旧的鼠标拖动点
        { this.oldDragPoint = oldDragPoint; }
        public DRAWForm getRefDRAWPanel()                	//获取画板
        { return refDRAWPanel; }
        public void setRefDRAWPanel(DRAWForm refDRAWPanel) 	//关联画板
        { this.refDRAWPanel = refDRAWPanel; }
        public BaseShape getOperShape()                 		//获取操作图形
        { return operShape; }
        public void setOperShape(BaseShape operShape)   		//设置操作图形
        { this.operShape = operShape; }
        public void superMouseUp(object sender, MouseEventArgs e)		//公共鼠标释放
        {
            this.setDownPoint(new Point());     					//鼠标按下点的设定
            this.setOldDragPoint(new Point());  					//旧的鼠标拖动点的设定
            this.setNewDragPoint(new Point());  					//新的鼠标拖动点的设定
            this.getRefDRAWPanel().record();    					//保存
            this.getRefDRAWPanel().Refresh();   					//刷新画板
        }
        public void superMouseDown(object sender, MouseEventArgs e, DRAWForm drawForm)//公共鼠标按下
        {
            this.setDownPoint(new Point(e.X, e.Y)); 				//鼠标按下点的设定
            this.setOldDragPoint(new Point(e.X, e.Y));				//旧的鼠标拖动点的设定
            this.setNewDragPoint(new Point(e.X, e.Y));				//新的鼠标拖动点的设定
            this.mouseDown(sender, e, drawForm);      			//鼠标按下的处理
        }
        public void superMouseDrag(object sender, MouseEventArgs e)	//公共鼠标拖动
        {
            this.setNewDragPoint(new Point(e.X, e.Y));				//新的鼠标拖动点的设定
            this.mouseDrag(sender, e);                			//鼠标拖动
            this.setOldDragPoint(this.getNewDragPoint());			//旧的鼠标拖动点的设定
        }

    }

}
