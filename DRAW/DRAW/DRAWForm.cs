using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace DRAW
{
    public partial class DRAWForm : Form
    {
        public DRAWForm()
        {
            InitializeComponent();
            currentShapes = new ArrayList();         		//实例当前显示的图形集合对象
            historyShapes = new ArrayList();         		//历史图形的快照集合对象
        }

        private void DRAWForm_Load(object sender, EventArgs e)			//加载窗体时显示画笔宽度
        {
            txtLineWidth_TextChanged(null, null);
            this.getHistoryShape().Add(this.cloneShapArray(this.getCurrentShapes()));
        }

        private BaseTool currentTool = null;        			//当前的应用工具
        private ArrayList currentShapes = null;     			//当前显示的图形集合
        private ArrayList historyShapes = null;     			//历史图形的快照集合
        public Color clr = Color.Black;             		//当前画笔的颜色
        public int lineWidth = 1;                   		//当前画笔的粗细
        private int undoIndex = 0;                  		//回退的索引
        private bool isMouseDown = false;           		//鼠标是否单击了画板
        /*设置和获取字段值*/
        public ArrayList getCurrentShapes()          		//获取当前图形集合
        { return currentShapes; }
        public void setCurrentShapes(ArrayList currentShapes)	//设置当前图形集合
        { this.currentShapes = currentShapes; }
        public BaseTool getCurrentTool()            		//获取当前画图工具
        { return currentTool; }
        public void setCurrentTool(BaseTool currentTool)		//设置当前画图工具
        { this.currentTool = currentTool; }
        public ArrayList getHistoryShape()             		//获取历史图形快照集合
        { return historyShapes; }
        public void setHistoryShapes(ArrayList historyShapes)	//设置历史图形快照集合
        { this.historyShapes = historyShapes; }

        private void Cyan_Click(object sender, EventArgs e)
        {
            clr = Color.Cyan;
            picCurrentColor.BackColor = clr;
        }

        private void Red_Click(object sender, EventArgs e)
        {
            clr = Color.Red;
            picCurrentColor.BackColor = clr;
        }

        private void Black_Click(object sender, EventArgs e)
        {
            clr = Color.Black;
            picCurrentColor.BackColor = clr;
        }

        private void Magente_Click(object sender, EventArgs e)
        {
            clr = Color.Magenta;
            picCurrentColor.BackColor = clr;
        }

        private void Green_Click(object sender, EventArgs e)
        {
            clr = Color.Green;
            picCurrentColor.BackColor = clr;
        }

        private void Orange_Click(object sender, EventArgs e)
        {
            clr = Color.Orange;
            picCurrentColor.BackColor = clr;
        }

        private void Yellow_Click(object sender, EventArgs e)
        {
            clr = Color.Yellow;
            picCurrentColor.BackColor = clr;
        }

        private void Blue_Click(object sender, EventArgs e)
        {
            clr = Color.Blue;
            picCurrentColor.BackColor = clr;
        }

        private void btnMoreColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                clr = colorDialog1.Color;
                picCurrentColor.BackColor = clr;
            }
        }
        private void tbarLineWidth_Scroll(object sender, EventArgs e)			//显示画笔宽度
        { this.txtLineWidth.Text = tbarLineWidth.Value.ToString(); }
        private void txtLineWidth_TextChanged(object sender, EventArgs e)   	//当数值发生改变时
        {
            Bitmap bit = new Bitmap(picLineWidth.Width, picLineWidth.Height);
            Graphics g = Graphics.FromImage(bit);
            Pen pen = new Pen(clr, int.Parse(this.txtLineWidth.Text));
            Point p1 = new Point();
            Point p2 = new Point();
            p1.X = 0;
            p1.Y = picLineWidth.Height / 2;
            p2.X = picLineWidth.Width;
            p2.Y = picLineWidth.Height / 2;
            g.DrawLine(pen, p1, p2);
            picLineWidth.Image = bit;
            lineWidth = int.Parse(this.txtLineWidth.Text);
        }
        public ArrayList cloneShapArray(ArrayList shapeArrayList)			//图形集合身复制
        {
            ArrayList returnShapeArrayList = new ArrayList();
            for (int i = 0; i < shapeArrayList.Count; i++)
            { returnShapeArrayList.Add(((BaseShape)shapeArrayList[i]).copySelf()); }
            return returnShapeArrayList;
        }

        private void picCurrentColor_Paint(object sender, PaintEventArgs e)	  //画笔的颜色改变时重新绘制线条
        { txtLineWidth_TextChanged(null, null); }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            BaseTool setTool = (BaseTool)new CircleTool();		//加载现在要用的圆工具
            if (setTool != null)
            {
                this.setCurrentTool(setTool);				//装载工具
                setTool.setRefDRAWPanel(this);
                picCurrentTool.Image = btnCircle.Image;
            }
        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            BaseTool setTool = (BaseTool)new LineTool();		//加载现在要用的直线工具
            if (setTool != null)
            {
                this.setCurrentTool(setTool);				//装载工具
                setTool.setRefDRAWPanel(this);
                picCurrentTool.Image = btnLine.Image;
            }
        }
        
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)		//按下鼠标
        {
   	        isMouseDown = true;
    	    if (this.getCurrentTool() != null)
    	    {	this.getCurrentTool().superMouseDown(sender, e, this);		}
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)		//鼠标移动
        {
    	    toolStripStatusLabel1.Text = "鼠标位置：" + e.X.ToString() + "," + e.Y.ToString();//显示鼠标的位置
    	    if (isMouseDown)
    	    {
        	    if (this.getCurrentTool() != null)
         	    {	this.getCurrentTool().superMouseDrag(sender, e);		}
    	    }
        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)		//如果鼠标弹起
        {
    	    isMouseDown = false;
    	    if (this.getCurrentTool() != null)
    	    {	this.getCurrentTool().superMouseUp(sender, e);	}
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)//图片框重绘,循环画出过去所画的图像
        {
            int lx, ly;
    	    Graphics g = e.Graphics;
    	    for (int i = 0; i < currentShapes.Count; i++)
    	    {
       	        string Type = ((BaseShape)currentShapes[i]).GetType().ToString();	//获取对象类型
        	    switch (Type)
        	    {
            	    case "DRAW.LineShape":          					//如果是直线
             	    g.DrawLine(new Pen(((BaseShape)currentShapes[i]).penColor, ((BaseShape)currentShapes[i]).penwidth), ((BaseShape)currentShapes[i]).getP1(), ((BaseShape)currentShapes[i]).getP2());
                 	break;
                    case "DRAW.CircleShape":        					//如果是圆
                 	int r = (int)Math.Pow(Math.Pow(((BaseShape)currentShapes[i]).getP2().X - ((BaseShape)currentShapes[i]).getP1().X, 2) + Math.Pow(((BaseShape)currentShapes[i]).getP2().Y - ((BaseShape)currentShapes[i]).getP1().Y, 2), 0.5);
                 	g.DrawEllipse(new Pen(((BaseShape)currentShapes[i]).penColor,((BaseShape)currentShapes[i]).penwidth), ((BaseShape)currentShapes[i]).getP1().X - r,((BaseShape)currentShapes[i]).getP1().Y - r, 2 * r, 2 * r);
                    break;
                    case "DRAW.RectangleShape":
                    if (((BaseShape)currentShapes[i]).getP1().X < ((BaseShape)currentShapes[i]).getP2().X && ((BaseShape)currentShapes[i]).getP1().Y < ((BaseShape)currentShapes[i]).getP2().Y)
                    {
                        lx = ((BaseShape)currentShapes[i]).getP1().X;
                        ly = ((BaseShape)currentShapes[i]).getP1().Y;
                    }
                    else if (((BaseShape)currentShapes[i]).getP1().X > ((BaseShape)currentShapes[i]).getP2().X && ((BaseShape)currentShapes[i]).getP1().Y > ((BaseShape)currentShapes[i]).getP2().Y) 
                    {
                        lx = ((BaseShape)currentShapes[i]).getP2().X;
                        ly = ((BaseShape)currentShapes[i]).getP2().Y;
                    }
                    else if (((BaseShape)currentShapes[i]).getP1().X > ((BaseShape)currentShapes[i]).getP2().X && ((BaseShape)currentShapes[i]).getP1().Y < ((BaseShape)currentShapes[i]).getP2().Y) 
                    {
                        lx = ((BaseShape)currentShapes[i]).getP2().X;
                        ly = ((BaseShape)currentShapes[i]).getP1().Y;
                    }
                    else 
                    {
                        lx = ((BaseShape)currentShapes[i]).getP1().X;
                        ly = ((BaseShape)currentShapes[i]).getP2().Y;
                    }
                    g.DrawRectangle(new Pen(((BaseShape)currentShapes[i]).penColor, ((BaseShape)currentShapes[i]).penwidth), lx, ly, (int)Math.Abs(((BaseShape)currentShapes[i]).getP2().X - ((BaseShape)currentShapes[i]).getP1().X), (int)Math.Abs(((BaseShape)currentShapes[i]).getP2().Y - ((BaseShape)currentShapes[i]).getP1().Y));
                    break;
                    case "DRAW.EllipseShape":
                    if (((BaseShape)currentShapes[i]).getP1().X < ((BaseShape)currentShapes[i]).getP2().X && ((BaseShape)currentShapes[i]).getP1().Y < ((BaseShape)currentShapes[i]).getP2().Y)
                    {
                        lx = ((BaseShape)currentShapes[i]).getP1().X;
                        ly = ((BaseShape)currentShapes[i]).getP1().Y;
                    }
                    else if (((BaseShape)currentShapes[i]).getP1().X > ((BaseShape)currentShapes[i]).getP2().X && ((BaseShape)currentShapes[i]).getP1().Y > ((BaseShape)currentShapes[i]).getP2().Y) 
                    {
                        lx = ((BaseShape)currentShapes[i]).getP2().X;
                        ly = ((BaseShape)currentShapes[i]).getP2().Y;
                    }
                    else if (((BaseShape)currentShapes[i]).getP1().X > ((BaseShape)currentShapes[i]).getP2().X && ((BaseShape)currentShapes[i]).getP1().Y < ((BaseShape)currentShapes[i]).getP2().Y) 
                    {
                        lx = ((BaseShape)currentShapes[i]).getP2().X;
                        ly = ((BaseShape)currentShapes[i]).getP1().Y;
                    }
                    else 
                    {
                        lx = ((BaseShape)currentShapes[i]).getP1().X;
                        ly = ((BaseShape)currentShapes[i]).getP2().Y;
                    }
                    g.DrawEllipse(new Pen(((BaseShape)currentShapes[i]).penColor, ((BaseShape)currentShapes[i]).penwidth), lx, ly, (int)Math.Abs(((BaseShape)currentShapes[i]).getP2().X - ((BaseShape)currentShapes[i]).getP1().X), (int)Math.Abs(((BaseShape)currentShapes[i]).getP2().Y - ((BaseShape)currentShapes[i]).getP1().Y));
                    break;
                    case "DRAW.ArcShape":
                    if (((BaseShape)currentShapes[i]).getP1().X < ((BaseShape)currentShapes[i]).getP2().X && ((BaseShape)currentShapes[i]).getP1().Y < ((BaseShape)currentShapes[i]).getP2().Y)
                    {
                        lx = ((BaseShape)currentShapes[i]).getP1().X;
                        ly = ((BaseShape)currentShapes[i]).getP1().Y;
                    }
                    else if (((BaseShape)currentShapes[i]).getP1().X > ((BaseShape)currentShapes[i]).getP2().X && ((BaseShape)currentShapes[i]).getP1().Y > ((BaseShape)currentShapes[i]).getP2().Y)
                    {
                        lx = ((BaseShape)currentShapes[i]).getP2().X;
                        ly = ((BaseShape)currentShapes[i]).getP2().Y;
                    }
                    else if (((BaseShape)currentShapes[i]).getP1().X > ((BaseShape)currentShapes[i]).getP2().X && ((BaseShape)currentShapes[i]).getP1().Y < ((BaseShape)currentShapes[i]).getP2().Y)
                    {
                        lx = ((BaseShape)currentShapes[i]).getP2().X;
                        ly = ((BaseShape)currentShapes[i]).getP1().Y;
                    }
                    else
                    {
                        lx = ((BaseShape)currentShapes[i]).getP1().X;
                        ly = ((BaseShape)currentShapes[i]).getP2().Y;
                    }
                    //Rectangle rect = new Rectangle(lx, ly, (int)Math.Abs(((BaseShape)currentShapes[i]).getP2().X - ((BaseShape)currentShapes[i]).getP1().X), (int)Math.Abs(((BaseShape)currentShapes[i]).getP2().Y - ((BaseShape)currentShapes[i]).getP1().Y)); 
                    g.DrawArc(new Pen(((BaseShape)currentShapes[i]).penColor, ((BaseShape)currentShapes[i]).penwidth), new Rectangle(lx, ly, (int)Math.Abs(((BaseShape)currentShapes[i]).getP2().X - ((BaseShape)currentShapes[i]).getP1().X), (int)Math.Abs(((BaseShape)currentShapes[i]).getP2().Y - ((BaseShape)currentShapes[i]).getP1().Y)), 10F, 150F);
                    break;
        	    }
        	    ((BaseShape)currentShapes[i]).superDraw(g); 	//如果当前图形处于选择状态则画出热点
    	    }
        }

        public void record()								//保存快照
        {
    	    if (undoIndex > 0)							//当有撤销时，清空回退获得快照
    	    {
        	    while (undoIndex != 0)
         	    {
             	    this.getHistoryShape().RemoveAt(this.getHistoryShape().Count-1);
             	    undoIndex--;
        	    }
    	    }
    	    this.getHistoryShape().Add(this.cloneShapArray(this.getCurrentShapes()));		//保存快照
        }
        
        private void btnClear_Click(object sender, EventArgs e)
        {
            undoIndex = 0;
            this.setHistoryShapes(new ArrayList());
            this.setCurrentShapes(new ArrayList());
            record();
            this.pictureBox1.Refresh();
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            picCurrentTool.Image = null;
            if ((this.getHistoryShape().Count - 1 - undoIndex) > 0)	//历史快照中还有历史才能撤销
            {
                undoIndex++;							//将历史快照取回到当前图形中
                this.setCurrentShapes((this.cloneShapArray((ArrayList)this.getHistoryShape()
                [this.getHistoryShape().Count - 1 - undoIndex])));
            }
            this.Refresh();   
        }

        private void btnRedo_Click(object sender, EventArgs e)
        {
            picCurrentTool.Image = null;
            if (undoIndex > 0)							//当有回退时才可重复
            {
                undoIndex--;							//将历史快照取回到当前图形中
                this.setCurrentShapes(this.cloneShapArray((ArrayList)this.getHistoryShape()
            [this.getHistoryShape().Count - 1 - undoIndex]));
            }
            this.Refresh();
        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "draw类型(*.draw)|*.draw";
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Stream str = File.Open(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();
                ArrayList als = new ArrayList();
                bool forFlat = true;
                for (int i = 0; forFlat; i++)
                {
                    try
                    { als.Add(bf.Deserialize(str)); } 	//反序列化并将图形放在动态数组中
                    catch
                    { forFlat = false; }
                }
                str.Close();
                this.setCurrentShapes(als);
                this.setHistoryShapes(new ArrayList());
                this.record();
                undoIndex = 0;
                this.pictureBox1.Refresh();
            }
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "draw类型(*.draw)|*.draw";
            if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Stream str = File.Open(saveFileDialog1.FileName, FileMode.Create, FileAccess.ReadWrite);
                BinaryFormatter bf = new BinaryFormatter();
                for (int i = 0; i < this.getCurrentShapes().Count; i++)
                { bf.Serialize(str, this.getCurrentShapes()[i]); }	//将图形进行序列化保存
                str.Close();        							//关闭流
            }
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHand_Click(object sender, EventArgs e)
        {
            BaseTool setTool = (BaseTool)new HandTool();	//加载现在要用的工具
            if (setTool != null)
            {
                this.setCurrentTool(setTool);			//装载工具
                setTool.setRefDRAWPanel(this);
                picCurrentTool.Image = btnHand.Image;
            }
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            BaseTool setTool = (BaseTool)new RectangleTool();		//加载现在要用的圆工具
            if (setTool != null)
            {
                this.setCurrentTool(setTool);				//装载工具
                setTool.setRefDRAWPanel(this);
                picCurrentTool.Image = btnRectangle.Image;
            }
        }

        private void btnEllipse_Click(object sender, EventArgs e)
        {
            BaseTool setTool = (BaseTool)new EllipseTool();		//加载现在要用的圆工具
            if (setTool != null)
            {
                this.setCurrentTool(setTool);				//装载工具
                setTool.setRefDRAWPanel(this);
                picCurrentTool.Image = btnEllipse.Image;
            }
        }

        private void btnArc_Click(object sender, EventArgs e)
        {
            BaseTool setTool = (BaseTool)new ArcTool();		//加载现在要用的圆工具
            if (setTool != null)
            {
                this.setCurrentTool(setTool);				//装载工具
                setTool.setRefDRAWPanel(this);
                picCurrentTool.Image = btnArc.Image;
            }
        }

    }
}
