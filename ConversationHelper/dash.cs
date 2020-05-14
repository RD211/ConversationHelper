using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ConversationHelper
{
    public partial class dashboard : Form
    {
        //ugly code ahead
        #region Variables
        Followup rootConversation = new Followup();
        Dictionary<TreeNode, Followup> fromNodeToObject = new Dictionary<TreeNode, Followup>();
        Dictionary<Followup, Followup> fromFollowToFather = new Dictionary<Followup, Followup>();
        List<Bunifu.Framework.UI.BunifuMetroTextbox> answerTexts = new List<Bunifu.Framework.UI.BunifuMetroTextbox>();
        string locationOpened = "";
        TreeNode loadedNode;
        #endregion

        #region Hacks and workarounds
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void MoveForm(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private const int
            HTLEFT = 10,
            HTRIGHT = 11,
            HTTOP = 12,
            HTTOPLEFT = 13,
            HTTOPRIGHT = 14,
            HTBOTTOM = 15,
            HTBOTTOMLEFT = 16,
            HTBOTTOMRIGHT = 17;

        const int x = 10;

        Rectangle Top { get { return new Rectangle(0, 0, this.ClientSize.Width, x); } }
        Rectangle Left { get { return new Rectangle(0, 0, x, this.ClientSize.Height); } }
        Rectangle Bottom { get { return new Rectangle(0, this.ClientSize.Height - x, this.ClientSize.Width, x); } }
        Rectangle Right { get { return new Rectangle(this.ClientSize.Width - x, 0, x, this.ClientSize.Height); } }

        Rectangle TopLeft { get { return new Rectangle(0, 0, x, x); } }
        Rectangle TopRight { get { return new Rectangle(this.ClientSize.Width - x, 0, x, x); } }
        Rectangle BottomLeft { get { return new Rectangle(0, this.ClientSize.Height - x, x, x); } }
        Rectangle BottomRight { get { return new Rectangle(this.ClientSize.Width - x, this.ClientSize.Height - x, x, x); } }


        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == 0x84)
            {
                var cursor = this.PointToClient(Cursor.Position);

                if (TopLeft.Contains(cursor)) message.Result = (IntPtr)HTTOPLEFT;
                else if (TopRight.Contains(cursor)) message.Result = (IntPtr)HTTOPRIGHT;
                else if (BottomLeft.Contains(cursor)) message.Result = (IntPtr)HTBOTTOMLEFT;
                else if (BottomRight.Contains(cursor)) message.Result = (IntPtr)HTBOTTOMRIGHT;

                else if (Top.Contains(cursor)) message.Result = (IntPtr)HTTOP;
                else if (Left.Contains(cursor)) message.Result = (IntPtr)HTLEFT;
                else if (Right.Contains(cursor)) message.Result = (IntPtr)HTRIGHT;
                else if (Bottom.Contains(cursor)) message.Result = (IntPtr)HTBOTTOM;
            }
        }
        #endregion

        public dashboard()
        {
            InitializeComponent();
            this.MinimumSize = this.Size;
            answerTexts = new List<Bunifu.Framework.UI.BunifuMetroTextbox>() { txt_answer_1,
                txt_answer_2,
                txt_answer_3,
                txt_answer_4,
                txt_answer_5,
                txt_answer_6,
                txt_answer_7,
                txt_answer_8 };
            this.answerTexts.ForEach((txt) => txt.OnValueChanged += Txt_OnValueChanged);
            this.AllowDrop = true;
            this.DragEnter += new DragEventHandler(dash_DragEnter);
            this.DragDrop += new DragEventHandler(dash_DragDrop);
            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            PrivateFontCollection pfc = new PrivateFontCollection();
            int fontLength = Properties.Resources.circular_font.Length;
            byte[] fontdata = Properties.Resources.circular_font;
            System.IntPtr data = Marshal.AllocCoTaskMem(fontLength);
            Marshal.Copy(fontdata, 0, data, fontLength);
            pfc.AddMemoryFont(data, fontLength);
            foreach (var c in this.Controls)
            {
                if (c.GetType() == typeof(Label))
                {
                    ((Label)c).Font = new Font(pfc.Families[0], ((Label)c).Font.Size);
                }
                else if (c.GetType() == typeof(Bunifu.Framework.UI.BunifuMetroTextbox))
                {
                    ((Bunifu.Framework.UI.BunifuMetroTextbox)c).Font = new Font(pfc.Families[0], ((Bunifu.Framework.UI.BunifuMetroTextbox)c).Font.Size);

                }
                else if (c.GetType() == typeof(TreeView))
                {
                    ((TreeView)c).Font = new Font(pfc.Families[0], ((TreeView)c).Font.Size);

                }
                else if (c.GetType() == typeof(RichTextBox))
                {
                    ((RichTextBox)c).Font = new Font(pfc.Families[0], ((RichTextBox)c).Font.Size);

                }
            }
        }

        void dash_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        void dash_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            loadJsonFromFile(files[0]);
            
        }
        private void Txt_OnValueChanged(object sender, EventArgs e)
        {
            if (((Bunifu.Framework.UI.BunifuMetroTextbox)sender).Text != "" && loadedNode != null)
            {
                try
                {
                    int numberOfTxt = int.Parse(((Bunifu.Framework.UI.BunifuMetroTextbox)sender).Tag.ToString());
                    var followFromTree = fromNodeToObject[loadedNode];
                    if (followFromTree.Followups.Count < numberOfTxt)
                    {
                        var nT = new TreeNode(((Bunifu.Framework.UI.BunifuMetroTextbox)sender).Text);
                        loadedNode.Nodes.Add(nT);
                        var nF = new Followup();
                        nF.PlayerResponse = nT.Text;
                        followFromTree.Followups.Add(nF);
                        fromNodeToObject.Add(nT, nF);
                        if (!fromFollowToFather.ContainsKey(nF))
                            fromFollowToFather.Add(nF, followFromTree);
                        if (numberOfTxt != 8)
                            answerTexts[numberOfTxt].Show();
                    }
                    else
                    {
                        followFromTree.Followups[numberOfTxt - 1].PlayerResponse = ((Bunifu.Framework.UI.BunifuMetroTextbox)sender).Text;
                        loadedNode.Nodes[numberOfTxt - 1].Text = ((Bunifu.Framework.UI.BunifuMetroTextbox)sender).Text;
                    }
                }
                catch { }
            }
        }
        private void Txt_Question_OnValueChanged(object sender, EventArgs e)
        {
            if(loadedNode!=null && txt_question.Text!="")
            {
                try
                {
                    fromNodeToObject[loadedNode].Reply = txt_question.Text;
                    if (loadedNode.IsExpanded)
                        loadedNode.Text = txt_question.Text;

                }
                catch { }
            }
        }

        private void btn_new_click(object sender, EventArgs e)
        {
            rootConversation = new Followup();
            rootConversation.Reply = "start";
            rootConversation.PlayerResponse = "start";

            locationOpened = "";
            UpdateTreeView();
        }

        private void btn_open_click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                loadJsonFromFile(dialog.FileName);
            }
        }
        private void loadJsonFromFile(string path)
        {
            rootConversation = JsonConvert.DeserializeObject<Followup>(File.ReadAllText(path));
            this.locationOpened = path;
            UpdateTreeView();
        }
        private void dfsInModel(Followup follow,ref TreeNode father)
        {
            var copyFather = father;
            var newNode = new TreeNode($"{follow.PlayerResponse}");
            if(!fromNodeToObject.ContainsKey(father))
                fromNodeToObject.Add(father, follow);

            father.Nodes.Add(newNode);

            father = newNode;
            if (!fromNodeToObject.ContainsKey(father))
                fromNodeToObject.Add(father, follow);
            foreach (var followup in follow.Followups)
            {
                if (!fromFollowToFather.ContainsKey(followup))
                    fromFollowToFather.Add(followup, follow);
                dfsInModel(followup, ref father);
            }
            father = copyFather;
        }
        private void dfsInTree(TreeNode father)
        {
            if (father.IsExpanded)
                father.Text = fromNodeToObject[father].Reply;
            else
                father.Text = fromNodeToObject[father].PlayerResponse;
            for(int i = 0;i<father.Nodes.Count;i++)
            {
                dfsInTree(father.Nodes[i]);
            }
        }
        private void UpdateTreeView()
        {
            fromNodeToObject.Clear();
            this.treev_conversation.Nodes.Clear();

            TreeNode node = new TreeNode();
            dfsInModel(rootConversation, ref node);
            treev_conversation.Nodes.Add(node.Nodes[0]);
        }

        private void treev_conversation_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treev_conversation.SelectedNode != null)
            {
                showEditingBar();
                loadedNode = treev_conversation.SelectedNode;
                var node = treev_conversation.SelectedNode;
                txt_question.Text = "";
                txt_question.Text = fromNodeToObject[node].Reply;
                dfsInTree(treev_conversation.Nodes[0]);
                this.answerTexts.ForEach((answer) => { answer.Hide(); answer.Text = ""; });
                for (int i = 0; i < fromNodeToObject[node].Followups.Count; i++)
                {
                    this.answerTexts[i].Text = fromNodeToObject[node].Followups[i].PlayerResponse;
                    this.answerTexts[i].Show();
                }
                if (fromNodeToObject[node].Followups.Count != 8)
                    this.answerTexts[fromNodeToObject[node].Followups.Count].Show();
            }
        }
        private void treev_conversation_Click(object sender, EventArgs e) => treev_conversation_AfterSelect(null,null);
        private void treev_conversation_AfterExpand(object sender, TreeViewEventArgs e) => dfsInTree(treev_conversation.Nodes[0]);
        private void treev_conversation_AfterCollapse(object sender, TreeViewEventArgs e) => dfsInTree(treev_conversation.Nodes[0]);

        private void btn_up_Click(object sender, EventArgs e)
        {
            if(loadedNode!=null)
            {
                var objectNode = fromNodeToObject[loadedNode];
                var indx = fromFollowToFather[objectNode].Followups.IndexOf(objectNode);
                if(indx!=0)
                {
                    fromFollowToFather[objectNode].Followups.Remove(objectNode);
                    fromFollowToFather[objectNode].Followups.Insert(indx - 1, objectNode);
                    MoveUp(loadedNode);
                    treev_conversation.SelectedNode = loadedNode.PrevNode.PrevNode;
                }
            }
        }
        public static void MoveUp(TreeNode node)
        {
            TreeNode parent = node.Parent;
            TreeView view = node.TreeView;
            if (parent != null)
            {
                int index = parent.Nodes.IndexOf(node);
                if (index > 0)
                {
                    parent.Nodes.RemoveAt(index);
                    parent.Nodes.Insert(index - 1, node);
                }
            }
            else if (node.TreeView.Nodes.Contains(node))
            {
                int index = view.Nodes.IndexOf(node);
                if (index > 0)
                {
                    view.Nodes.RemoveAt(index);
                    view.Nodes.Insert(index - 1, node);
                }
            }
        }

        public static void MoveDown(TreeNode node)
        {
            TreeNode parent = node.Parent;
            TreeView view = node.TreeView;
            if (parent != null)
            {
                int index = parent.Nodes.IndexOf(node);
                if (index < parent.Nodes.Count - 1)
                {
                    parent.Nodes.RemoveAt(index);
                    parent.Nodes.Insert(index + 1, node);
                }
            }
            else if (view != null && view.Nodes.Contains(node))
            {
                int index = view.Nodes.IndexOf(node);
                if (index < view.Nodes.Count - 1)
                {
                    view.Nodes.RemoveAt(index);
                    view.Nodes.Insert(index + 1, node);
                }
            }
        }

        private void btn_codeOrTree_Click(object sender, EventArgs e)
        {
            if (treev_conversation.Enabled)
            {
                btn_codeOrTree.Image = ConversationHelper.Properties.Resources.list;
                treev_conversation.Hide();
                treev_conversation.Enabled = false;
                txt_json.Show();
                txt_json.Enabled = true;
                txt_json.Text = JsonConvert.SerializeObject(rootConversation, Formatting.Indented);
                loadedNode = null;
                hideEditingBar();
            }
            else
            {
                txt_json.Enabled = false;
                txt_json.Hide();
                btn_codeOrTree.Image = ConversationHelper.Properties.Resources.hashtag;
                treev_conversation.Enabled = true;
                treev_conversation.Show();
            }
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            hideEditingBar();
        }
        void hideEditingBar()
        {
            this.answerTexts.ForEach((item) => item.Hide());
            lbl_answers.Hide();
            lbl_question.Hide();
            txt_question.Hide();
        }
        void showEditingBar()
        {
            this.answerTexts.ForEach((item) => item.Show());
            lbl_answers.Show();
            lbl_question.Show();
            txt_question.Show();
        }

        private void btn_down_Click(object sender, EventArgs e)
        {
            if (loadedNode != null)
            {
                var objectNode = fromNodeToObject[loadedNode];
                var indx = fromFollowToFather[objectNode].Followups.IndexOf(objectNode);
                if (indx != fromFollowToFather[objectNode].Followups.Count-1)
                {
                    fromFollowToFather[objectNode].Followups.Remove(objectNode);
                    fromFollowToFather[objectNode].Followups.Insert(indx + 1, objectNode);
                    MoveDown(loadedNode);
                    treev_conversation.SelectedNode = loadedNode.NextNode;

                }
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            try
            {
                if (loadedNode == treev_conversation.Nodes[0])
                {
                    MessageBox.Show("Can't delete the root");
                }
                else if (loadedNode != null)
                {
                    fromFollowToFather[fromNodeToObject[loadedNode]].Followups.Remove(fromNodeToObject[loadedNode]);
                    fromNodeToObject[loadedNode] = null;
                    loadedNode.Remove();
                    dfsInTree(treev_conversation.Nodes[0]);
                }
            }
            catch { }
        }

        private void btn_save_click(object sender, EventArgs e)
        {
            if(locationOpened!="")
            {
                File.WriteAllText(locationOpened, JsonConvert.SerializeObject(rootConversation,Formatting.Indented));
            }
            else
            {
                btn_saveas_click(null,null);
            }
        }
        private void btn_saveas_click(object _,EventArgs __)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            if(dialog.ShowDialog()==DialogResult.OK)
            {
                File.WriteAllText(dialog.FileName, JsonConvert.SerializeObject(rootConversation, Formatting.Indented));
            }
        }

        private void btn_close_click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_enlarge_delarge_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Maximized)
            {
                btn_enlarge_delarge.Image = ConversationHelper.Properties.Resources.enlarge;
                this.WindowState = FormWindowState.Normal;
                this.Size = this.MinimumSize;
            }
            else
            {
                btn_enlarge_delarge.Image = ConversationHelper.Properties.Resources.minimize;
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
