using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpExtendedCommands.DataTypeExtensions
{

    namespace UI
    {
        public static class UIClassExtensions
        {
            public static Point GetMouseInFormPosition(this Form form)
            {
                return CSharpExtendedCommands.UI.Info.GetMouseInFormLocation(form, 12, 30);
            }
            public static Point GetMouseInFormPosition(this Form form, int xoffset, int yoffset)
            {
                return CSharpExtendedCommands.UI.Info.GetMouseInFormLocation(form, xoffset, yoffset);
            }
            public static void CenterInScreen(this Form frm)
            {
                frm.Location = new Point(Info.ComputerInfo.ScreenWidth / 2 - frm.Size.Width / 2,
                    Info.ComputerInfo.ScreenHeight - frm.Size.Height / 2);
            }
            public static void ChangeBGColorSmoothly(this Control control, Color color, int delay = 1)
            {
                int a = control.BackColor.A;
                int r = control.BackColor.R;
                int g = control.BackColor.G;
                int b = control.BackColor.B;
                while (control.BackColor != color)
                {
                    if (a < color.A)
                        a++;
                    else if (a > color.A)
                        a--;
                    if (r < color.R)
                        r++;
                    else if (r > color.R)
                        r--;
                    if (g < color.G)
                        g++;
                    else if (g > color.G)
                        g--;
                    if (b < color.B)
                        b++;
                    else if (b > color.B)
                        b--;
                    control.BackColor = Color.FromArgb(a, r, g, b);
                    System.Threading.Thread.Sleep(delay);
                }
            }
            public static void CenterOnContainerX(this Control control) => control.Location = new Point(control.Parent.ClientRectangle.Size.Width / 2 - control.Size.Width / 2, control.Location.Y);
            public static void CenterOnContainerY(this Control control) => control.Location = new Point(control.Location.X, control.Parent.ClientRectangle.Height / 2 - control.Size.Height / 2);
            public static void CenterOnContainerX(this Control control, Control container)
            {
                control.Parent = container;
                control.CenterOnContainerX();
            }
            public static void CenterOnContainerY(this Control control, Control container)
            {
                control.Parent = container;
                control.CenterOnContainerY();
            }
            public static void CenterOnContainer(this Control control, Control container)
            {
                control.Parent = container;
                control.CenterOnContainer();
            }
            public static void CenterOnContainer(this Control control) => control.Location = new Point(control.Parent.ClientRectangle.Size.Width / 2 - control.Size.Width / 2, control.Parent.ClientRectangle.Size.Height / 2 - control.Size.Height / 2);
            public static decimal GetPercentage(this System.Windows.Forms.ProgressBar progressBar)
            {
                decimal NTP = progressBar.Value * 100 / progressBar.Maximum;
                if (NTP.ToString().Contains(","))
                    return Convert.ToDecimal(NTP.ToString().Substring(0, NTP.ToString().IndexOf(',') - 1));
                else
                    return NTP;
            }
            public static TreeNode GetNodeByPath(this TreeView tree, string path)
            {
                var paths = path.Split(new char[] { '\\' }, StringSplitOptions.RemoveEmptyEntries);
                TreeNode cNode = null;
                foreach (TreeNode n in tree.Nodes)
                    if (n.Text == paths[0])
                    { cNode = n; break; }
                if (paths.Length == 1 || cNode == null)
                    return cNode;
                for (int i = 1; i < paths.Count(); i++)
                {
                    var tmp = cNode;
                    foreach (TreeNode n in cNode.Nodes)
                        if (n.Text == paths[i])
                        { cNode = n; break; }
                    if (tmp == cNode)
                        return null;
                }
                return cNode;
            }
            public static TreeNode GetNodeByPath(this TreeNode root, string path)
            {
                var paths = path.Split(new char[] { '\\' }, StringSplitOptions.RemoveEmptyEntries);
                TreeNode cNode = root;
                for (int i = 0; i < paths.Count(); i++)
                {
                    var tmp = cNode;
                    foreach (TreeNode n in cNode.Nodes)
                        if (n.Text == paths[i])
                        { cNode = n; break; }
                    if (tmp == cNode)
                        return null;
                }
                return cNode;
            }
            public static void Sort(this TreeNodeCollection nodes)
            {
                List<string> sn = new List<string>();
                foreach (TreeNode node in nodes)
                    sn.Add(node.Text);
                sn.Sort();
                nodes.Clear();
                foreach (var item in sn)
                    nodes.Add(item);
            }
            public static void Sort(this TreeView tree)
            {
                tree.Nodes.SortAllTree();
            }
            private static void SortAllTree(this TreeNodeCollection rootNode)
            {
                rootNode.Sort();
                foreach (TreeNode node in rootNode)
                    node.Nodes.SortAllTree();
            }
        }
    }
}
