using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DRAW
{
    class RectangleTool:BaseTool
    {
        public override void mouseDown(object sender, MouseEventArgs e, DRAWForm drawForm)
        {
            this.setOperShape(new RectangleShape());
            this.getOperShape().setP1(this.getDownPoint());
            this.getOperShape().penColor = drawForm.clr;
            this.getOperShape().penwidth = drawForm.lineWidth;
            this.getRefDRAWPanel().getCurrentShapes().Add(this.getOperShape());
        }
        public override void mouseDrag(object sender, MouseEventArgs e)//重写长方形的鼠标拖动
        {
            this.getOperShape().setP2(this.getNewDragPoint()); 	 	//设置终点
            this.getRefDRAWPanel().Refresh();               			//刷新画板
        }
    }
}
