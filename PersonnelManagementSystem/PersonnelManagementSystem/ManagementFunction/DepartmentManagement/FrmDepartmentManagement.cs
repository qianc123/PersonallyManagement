using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using PersonnelManagementSystem;


namespace PersonnelManagementSystem.ManagementFunction.DepartmentManagement
{
    public partial class FrmDepartmentManagement : Form
    {
        public FrmDepartmentManagement()
        {
            InitializeComponent();
        }

        //定义可传递值的全局变量，用于保存所选择的节点文本值及部门详细面部门名称显示
        public static string selectDep;
        //定义刷新加载树形列表方法
        private void ReFreshTreeView()
        {
            tvDept.Nodes.Clear();
            //设置节点可拖拽
            tvDept.AllowDrop = true;
            //查询所有部门
            string strDepN = "select departmentName from tblDepartment";
            //定义数据表储存查询结果表，调用方法进行表获取
            DataTable dt = SqlHelper.getDataTable(strDepN);
            //定义循环语句将表内容赋给树状表节点
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //新建节点对象
                TreeNode DepNode = new TreeNode();
                //给节点对象赋值
                DepNode.Text = dt.Rows[i]["departmentName"].ToString();
                //将对象显示到窗体中
                tvDept.Nodes.Add(DepNode);
                //定义sql查询语句
                string strSelect = "select employeeName from tblEmployee where departmentId = (select departmentId from tblDepartment where departmentName= '" + DepNode.Text + "') ";////查询部门下的员工
                //创建新的数据表
                DataTable dtEmpN = SqlHelper.getDataTable(strSelect);
                //定义循环语句将查询得到的部门的员工加入为子节点
                for (int j = 0; j < dtEmpN.Rows.Count; j++)
                {
                    string ChildNode = dtEmpN.Rows[j]["employeeName"].ToString();
                    DepNode.Nodes.Add(ChildNode);
                }
            }
        }

        private void FrmDepartmentManagement_Load(object sender, EventArgs e)
        {
            //调用刷新加载树形列表
            ReFreshTreeView();
            //判断登录人职位并赋予相应权限
            string drgPower = string.Format("select * from tblEmployee where employeePosition = '经理' and employeeLoginName = '{0}'",FrmLogin.EmpName.ToString());
            SqlDataReader ds = SqlHelper.ExecuteDataReader(drgPower);
            if (ds.HasRows)
            {
                btnAddDept.Enabled = true;
                btnDeleteDept.Enabled = true;
            }
            else
            {
                btnAddDept.Enabled = false;
                btnDeleteDept.Enabled = false;
            }
        }

        private void btnAddDept_Click(object sender, EventArgs e)
        {
            //新建增加部门窗体对象
            FrmCreateDepartment frmCreateDepartment = new FrmCreateDepartment();
            //显示新窗体
            frmCreateDepartment.ShowDialog();
            //判断窗体是否点击确定按钮
            if (frmCreateDepartment.DialogResult == DialogResult.OK)
            {
                //刷新加载树形列表
                ReFreshTreeView();
            }
        }

        private void btnDeleteDept_Click(object sender, EventArgs e)
        {
            if (tvDept.SelectedNode.Parent == null)
            {
                //查询部门是否存在员工
                string sqlSelect = string.Format("select employeeId from tblEmployee where departmentId = (select departmentId from tblDepartment where departmentName = '{0}')", selectDep);
                SqlDataReader result = SqlHelper.ExecuteDataReader(sqlSelect);
                //有行数据则触发提问
                if (result.HasRows)
                {
                    if (MessageBox.Show("该部门存在员工，是否转移并删除？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        //新建移动员工到新部门的窗体对象
                        FrmMoveEmployee frmMoveEmployee = new FrmMoveEmployee();
                        frmMoveEmployee.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("您放弃了转移！");
                        return;
                    }
                }
                //部门没有员工则执行提问，确认后执行删除操作
                else
                {
                    if (MessageBox.Show("确定删除？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string sqldelete = string.Format("delete from tblDepartment where departmentName = '{0}'", tvDept.SelectedNode.Text);
                        int t = SqlHelper.ExecuteNonQuery(sqldelete);
                        if (t > 0)
                        {
                            MessageBox.Show("删除成功！");
                        }
                        else
                        {
                            MessageBox.Show("删除失败！");
                        }
                    }
                    else
                    {
                        MessageBox.Show("您放弃了删除！");
                        return;
                    }
                }
                //刷新树形列表
                ReFreshTreeView();
            }
        }

        private void btnDeptDetail_Click(object sender, EventArgs e)
        {  
            //判断节点有无父节点
            if (tvDept.SelectedNode.Parent != null)
            {
                //弹出消息提示
                MessageBox.Show("选择有误！请选择部门！");
                return;
            }
            //新建部门详细窗体对象
            FrmDepartmentInformation frmDepartmentInformation = new FrmDepartmentInformation();
            frmDepartmentInformation.ShowDialog();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            //关闭窗体
            this.Close();
        }

        private void tvDept_AfterExpand(object sender, TreeViewEventArgs e)
        {
            foreach (TreeNode item in ((TreeView)sender).Nodes)
            {
                if (e.Node != item)
                {
                    item.Collapse();
                }
            }
        }

        private void tvDept_ItemDrag(object sender, ItemDragEventArgs e)
        {
            //展开当前选中的节点收缩其他节点 
            if (tvDept.SelectedNode.Nodes.Count <= 0)
            {
                if (e.Button == MouseButtons.Left)
                {
                    DoDragDrop(e.Item, DragDropEffects.Move);
                }
            }
        }

        private void tvDept_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent("System.Windows.Forms.TreeNode"))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            } 
        }

        private void tvDept_DragDrop(object sender, DragEventArgs e)
        {
            if ((MessageBox.Show("是否执行移动操作？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                //获取被拖动的节点
                TreeNode moveNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");
                //根据鼠标坐标确定要移动到的目标节点 
                Point pt = this.tvDept.PointToClient(new Point(e.X, e.Y));
                TreeNode targeNode = this.tvDept.GetNodeAt(pt);
                if (targeNode.Parent == null)
                {
                    //如果1.目标节点不是空。2.目标节点不是被拖拽接点的子节点。3.目标节点不是被拖拽节点本身  ，则将被拖曳节点添加到目标节点的子节点最后
                    if (targeNode != null && targeNode.Parent != moveNode && targeNode != moveNode)
                    {
                        //复制被拖动的节点
                        TreeNode DragNode = moveNode;
                        // 将被拖拽节点从原来位置删除。
                        moveNode.Remove();
                        // 在目标节点下增加被拖拽节点
                        targeNode.Nodes.Add(DragNode);
                        //设置当前拖动的节点为被选状态 
                        tvDept.SelectedNode = DragNode;
                        //展开目标节点,便于显示拖放效果 
                        targeNode.Expand();
                        string drage = string.Format("select employeeId from tblDepartment where employeeId =(select employeeId from tblEmployee where employeeName = '{0}')", moveNode.Text);
                        SqlDataReader ds = SqlHelper.ExecuteDataReader(drage);
                        if (ds.HasRows)
                        {
                            if ((MessageBox.Show("是否执行移动操作？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                            {
                                string change = string.Format("update tblEmployee set employeePosition = '员工',employeeRank = '1' where employeeName = '{0}'", moveNode.Text);
                                int k = SqlHelper.ExecuteNonQuery(change);
                                if (k > 0)
                                {
                                    string moveEmp = string.Format("update tblEmployee set departmentId =(select departmentId from tblDepartment where departmentName= '{0}') where employeeId=(select employeeId from tblemployee where employeeName= '{1}')", targeNode.Text, moveNode.Text);
                                    int backR = SqlHelper.ExecuteNonQuery(moveEmp);
                                    if (backR > 0)
                                    {
                                        MessageBox.Show("转移员工成功！");
                                    }
                                    else
                                    {
                                        MessageBox.Show("失败！");
                                    }
                                }
                            }
                            
                        }
                        else
                        {
                            string moveEmp = string.Format("update tblEmployee set departmentId =(select departmentId from tblDepartment where departmentName= '{0}') where employeeId=(select employeeId from tblemployee where employeeName= '{1}')", targeNode.Text, moveNode.Text);
                            int backR = SqlHelper.ExecuteNonQuery(moveEmp);
                            if (backR > 0)
                            {
                                MessageBox.Show("转移员工成功！");
                            }
                            else
                            {
                                MessageBox.Show("失败！");
                            }
                        }
                    }
                }
            }
            else
            {
                return;
            }
            ReFreshTreeView();
        }

        private void tvDept_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //获取所选到的节点的文本
            selectDep = e.Node.Text;
        }
    }
}
