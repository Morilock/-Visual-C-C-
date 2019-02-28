using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;


namespace DRAW
{
    class HandTool:BaseTool
    {	
        public int catchPointIndex = -1;   //捕捉热点的索引  
        public override void mouseDown(object sender, MouseEventArgs e, DRAWForm drawForm)
        {
    	    catchPointIndex = -1;						//重置捕捉热点的索引
    	    if (this.getOperShape() != null)
    	    {	this.getOperShape().setUnSelected();	}	//清除前操作对象中选中的状态
    	    ArrayList allShapes = this.getRefDRAWPanel().getCurrentShapes();		//得到画板上的所有图形
    	    int catchPoint = -1;
    	    int i = 0;
   	        for (; i < allShapes.Count; i++)				//对每个图形进行捕捉测试
    	    {
		        /*捕捉集合中的一个图形*/
        	    catchPoint = ((BaseShape)allShapes[i]).catchShapPoint(this.getOldDragPoint());
        	    if (catchPoint > -1)
         	    {	break;	}					//捕获到后，跳出循环
    	    }
   	        if (catchPoint > -1)
   	        {
         	    catchPointIndex = catchPoint;			//捕获到后，将临时的热点设置到工具属性中
        	    ((BaseShape)allShapes[i]).setSelected();		//设置捕捉到的图形为选中状态
         	    this.setOperShape(((BaseShape)allShapes[i]));//选中的图形设定到本类的操作图形的状态中
    	    }
   	        this.getRefDRAWPanel().Refresh();			//刷新画板
        }
        public override void mouseDrag(object sender, MouseEventArgs e)
        {
            if (this.getOperShape() != null)						//当有选中的图形时
            {
                Point setPoint = this.getNewDragPoint();
                if (catchPointIndex == 0)						//如果捕捉到移动点时
                {
                    setPoint = new Point();
                    setPoint.X = this.getNewDragPoint().X - this.getOldDragPoint().X;	//计算X增量点
                    setPoint.Y = this.getNewDragPoint().Y - this.getOldDragPoint().Y;	//计算Y增量点
                }
                this.getOperShape().setHitPoint(catchPointIndex, setPoint);			//设置热点
                this.getRefDRAWPanel().Refresh();												//刷新画板
            }
        }

    
    }		

}
