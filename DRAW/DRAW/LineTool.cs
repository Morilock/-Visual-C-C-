using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace DRAW
{
    class LineTool:BaseTool
    {
        public override void mouseDown(object sender, MouseEventArgs e, DRAWForm drawForm)
        {
            this.setOperShape(new LineShape());     				//新建一个线型对象
            this.getOperShape().setP1(this.getDownPoint());		//设置起始点
            this.getOperShape().penColor = drawForm.clr;		//设置颜色
            this.getOperShape().penwidth = drawForm.lineWidth;	//设置线条宽度
            /*在当前图形集合中添加这条图形*/
            this.getRefDRAWPanel().getCurrentShapes().Add(this.getOperShape());
        }
        public override void mouseDrag(object sender, MouseEventArgs e)//重写线的鼠标拖动
        {
            this.getOperShape().setP2(this.getNewDragPoint()); 	//设置终点
            this.getRefDRAWPanel().Refresh();               		//刷新画板
        }

    }
}
