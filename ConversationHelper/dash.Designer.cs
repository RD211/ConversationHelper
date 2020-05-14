namespace ConversationHelper
{
    partial class dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard));
            this.treev_conversation = new System.Windows.Forms.TreeView();
            this.txt_question = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lbl_question = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl_answers = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_answer_1 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_answer_2 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_answer_3 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_answer_4 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_answer_5 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_answer_8 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_answer_7 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_answer_6 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lbl_title = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel_top = new System.Windows.Forms.Panel();
            this.txt_json = new System.Windows.Forms.RichTextBox();
            this.btn_codeOrTree = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_down = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_up = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_close = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_minimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_enlarge_delarge = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_delete = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_open = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_save = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_new = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_saveas = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_codeOrTree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_down)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_up)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_enlarge_delarge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_open)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_save)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_new)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_saveas)).BeginInit();
            this.SuspendLayout();
            // 
            // treev_conversation
            // 
            this.treev_conversation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treev_conversation.BackColor = System.Drawing.Color.White;
            this.treev_conversation.Font = new System.Drawing.Font("Circular Bold", 20.25F, System.Drawing.FontStyle.Bold);
            this.treev_conversation.Location = new System.Drawing.Point(69, 87);
            this.treev_conversation.Name = "treev_conversation";
            this.treev_conversation.Size = new System.Drawing.Size(520, 557);
            this.treev_conversation.TabIndex = 0;
            this.treev_conversation.AfterCollapse += new System.Windows.Forms.TreeViewEventHandler(this.treev_conversation_AfterCollapse);
            this.treev_conversation.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.treev_conversation_AfterExpand);
            this.treev_conversation.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treev_conversation_AfterSelect);
            this.treev_conversation.Click += new System.EventHandler(this.treev_conversation_Click);
            this.treev_conversation.DragDrop += new System.Windows.Forms.DragEventHandler(this.dash_DragDrop);
            this.treev_conversation.DragEnter += new System.Windows.Forms.DragEventHandler(this.dash_DragEnter);
            // 
            // txt_question
            // 
            this.txt_question.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_question.BorderColorFocused = System.Drawing.Color.Blue;
            this.txt_question.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_question.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txt_question.BorderThickness = 3;
            this.txt_question.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_question.Font = new System.Drawing.Font("Circular Bold", 20.25F, System.Drawing.FontStyle.Bold);
            this.txt_question.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_question.isPassword = false;
            this.txt_question.Location = new System.Drawing.Point(596, 141);
            this.txt_question.Margin = new System.Windows.Forms.Padding(4);
            this.txt_question.Name = "txt_question";
            this.txt_question.Size = new System.Drawing.Size(389, 44);
            this.txt_question.TabIndex = 4;
            this.txt_question.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_question.OnValueChanged += new System.EventHandler(this.Txt_Question_OnValueChanged);
            // 
            // lbl_question
            // 
            this.lbl_question.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_question.AutoSize = true;
            this.lbl_question.BackColor = System.Drawing.Color.Transparent;
            this.lbl_question.Font = new System.Drawing.Font("Circular Bold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_question.ForeColor = System.Drawing.Color.Blue;
            this.lbl_question.Location = new System.Drawing.Point(595, 94);
            this.lbl_question.Name = "lbl_question";
            this.lbl_question.Size = new System.Drawing.Size(166, 43);
            this.lbl_question.TabIndex = 6;
            this.lbl_question.Text = "Question";
            // 
            // lbl_answers
            // 
            this.lbl_answers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_answers.AutoSize = true;
            this.lbl_answers.BackColor = System.Drawing.Color.Transparent;
            this.lbl_answers.Font = new System.Drawing.Font("Circular Bold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_answers.ForeColor = System.Drawing.Color.Blue;
            this.lbl_answers.Location = new System.Drawing.Point(595, 189);
            this.lbl_answers.Name = "lbl_answers";
            this.lbl_answers.Size = new System.Drawing.Size(158, 43);
            this.lbl_answers.TabIndex = 7;
            this.lbl_answers.Text = "Answers";
            // 
            // txt_answer_1
            // 
            this.txt_answer_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_answer_1.BorderColorFocused = System.Drawing.Color.Blue;
            this.txt_answer_1.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_answer_1.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txt_answer_1.BorderThickness = 3;
            this.txt_answer_1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_answer_1.Font = new System.Drawing.Font("Circular Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_answer_1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_answer_1.isPassword = false;
            this.txt_answer_1.Location = new System.Drawing.Point(596, 236);
            this.txt_answer_1.Margin = new System.Windows.Forms.Padding(4);
            this.txt_answer_1.Name = "txt_answer_1";
            this.txt_answer_1.Size = new System.Drawing.Size(389, 44);
            this.txt_answer_1.TabIndex = 9;
            this.txt_answer_1.Tag = "1";
            this.txt_answer_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_answer_2
            // 
            this.txt_answer_2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_answer_2.BorderColorFocused = System.Drawing.Color.Blue;
            this.txt_answer_2.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_answer_2.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txt_answer_2.BorderThickness = 3;
            this.txt_answer_2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_answer_2.Font = new System.Drawing.Font("Circular Bold", 20.25F, System.Drawing.FontStyle.Bold);
            this.txt_answer_2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_answer_2.isPassword = false;
            this.txt_answer_2.Location = new System.Drawing.Point(596, 288);
            this.txt_answer_2.Margin = new System.Windows.Forms.Padding(4);
            this.txt_answer_2.Name = "txt_answer_2";
            this.txt_answer_2.Size = new System.Drawing.Size(389, 44);
            this.txt_answer_2.TabIndex = 10;
            this.txt_answer_2.Tag = "2";
            this.txt_answer_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_answer_3
            // 
            this.txt_answer_3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_answer_3.BorderColorFocused = System.Drawing.Color.Blue;
            this.txt_answer_3.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_answer_3.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txt_answer_3.BorderThickness = 3;
            this.txt_answer_3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_answer_3.Font = new System.Drawing.Font("Circular Bold", 20.25F, System.Drawing.FontStyle.Bold);
            this.txt_answer_3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_answer_3.isPassword = false;
            this.txt_answer_3.Location = new System.Drawing.Point(596, 340);
            this.txt_answer_3.Margin = new System.Windows.Forms.Padding(4);
            this.txt_answer_3.Name = "txt_answer_3";
            this.txt_answer_3.Size = new System.Drawing.Size(389, 44);
            this.txt_answer_3.TabIndex = 11;
            this.txt_answer_3.Tag = "3";
            this.txt_answer_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_answer_4
            // 
            this.txt_answer_4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_answer_4.BorderColorFocused = System.Drawing.Color.Blue;
            this.txt_answer_4.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_answer_4.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txt_answer_4.BorderThickness = 3;
            this.txt_answer_4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_answer_4.Font = new System.Drawing.Font("Circular Bold", 20.25F, System.Drawing.FontStyle.Bold);
            this.txt_answer_4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_answer_4.isPassword = false;
            this.txt_answer_4.Location = new System.Drawing.Point(596, 392);
            this.txt_answer_4.Margin = new System.Windows.Forms.Padding(4);
            this.txt_answer_4.Name = "txt_answer_4";
            this.txt_answer_4.Size = new System.Drawing.Size(389, 44);
            this.txt_answer_4.TabIndex = 12;
            this.txt_answer_4.Tag = "4";
            this.txt_answer_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_answer_5
            // 
            this.txt_answer_5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_answer_5.BorderColorFocused = System.Drawing.Color.Blue;
            this.txt_answer_5.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_answer_5.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txt_answer_5.BorderThickness = 3;
            this.txt_answer_5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_answer_5.Font = new System.Drawing.Font("Circular Bold", 20.25F, System.Drawing.FontStyle.Bold);
            this.txt_answer_5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_answer_5.isPassword = false;
            this.txt_answer_5.Location = new System.Drawing.Point(596, 444);
            this.txt_answer_5.Margin = new System.Windows.Forms.Padding(4);
            this.txt_answer_5.Name = "txt_answer_5";
            this.txt_answer_5.Size = new System.Drawing.Size(389, 44);
            this.txt_answer_5.TabIndex = 13;
            this.txt_answer_5.Tag = "5";
            this.txt_answer_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_answer_8
            // 
            this.txt_answer_8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_answer_8.BorderColorFocused = System.Drawing.Color.Blue;
            this.txt_answer_8.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_answer_8.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txt_answer_8.BorderThickness = 3;
            this.txt_answer_8.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_answer_8.Font = new System.Drawing.Font("Circular Bold", 20.25F, System.Drawing.FontStyle.Bold);
            this.txt_answer_8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_answer_8.isPassword = false;
            this.txt_answer_8.Location = new System.Drawing.Point(596, 600);
            this.txt_answer_8.Margin = new System.Windows.Forms.Padding(4);
            this.txt_answer_8.Name = "txt_answer_8";
            this.txt_answer_8.Size = new System.Drawing.Size(389, 44);
            this.txt_answer_8.TabIndex = 16;
            this.txt_answer_8.Tag = "8";
            this.txt_answer_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_answer_7
            // 
            this.txt_answer_7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_answer_7.BorderColorFocused = System.Drawing.Color.Blue;
            this.txt_answer_7.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_answer_7.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txt_answer_7.BorderThickness = 3;
            this.txt_answer_7.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_answer_7.Font = new System.Drawing.Font("Circular Bold", 20.25F, System.Drawing.FontStyle.Bold);
            this.txt_answer_7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_answer_7.isPassword = false;
            this.txt_answer_7.Location = new System.Drawing.Point(596, 548);
            this.txt_answer_7.Margin = new System.Windows.Forms.Padding(4);
            this.txt_answer_7.Name = "txt_answer_7";
            this.txt_answer_7.Size = new System.Drawing.Size(389, 44);
            this.txt_answer_7.TabIndex = 15;
            this.txt_answer_7.Tag = "7";
            this.txt_answer_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_answer_6
            // 
            this.txt_answer_6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_answer_6.BorderColorFocused = System.Drawing.Color.Blue;
            this.txt_answer_6.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_answer_6.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txt_answer_6.BorderThickness = 3;
            this.txt_answer_6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_answer_6.Font = new System.Drawing.Font("Circular Bold", 20.25F, System.Drawing.FontStyle.Bold);
            this.txt_answer_6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_answer_6.isPassword = false;
            this.txt_answer_6.Location = new System.Drawing.Point(596, 496);
            this.txt_answer_6.Margin = new System.Windows.Forms.Padding(4);
            this.txt_answer_6.Name = "txt_answer_6";
            this.txt_answer_6.Size = new System.Drawing.Size(389, 44);
            this.txt_answer_6.TabIndex = 14;
            this.txt_answer_6.Tag = "6";
            this.txt_answer_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lbl_title
            // 
            this.lbl_title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_title.Font = new System.Drawing.Font("Circular Bold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.White;
            this.lbl_title.Location = new System.Drawing.Point(3, 3);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(823, 57);
            this.lbl_title.TabIndex = 27;
            this.lbl_title.Text = "Conversation editor";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveForm);
            // 
            // panel_top
            // 
            this.panel_top.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_top.BackColor = System.Drawing.Color.Blue;
            this.panel_top.Controls.Add(this.btn_close);
            this.panel_top.Controls.Add(this.lbl_title);
            this.panel_top.Controls.Add(this.btn_minimize);
            this.panel_top.Controls.Add(this.btn_enlarge_delarge);
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(997, 60);
            this.panel_top.TabIndex = 28;
            this.panel_top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveForm);
            // 
            // txt_json
            // 
            this.txt_json.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_json.BackColor = System.Drawing.Color.White;
            this.txt_json.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_json.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_json.Font = new System.Drawing.Font("Circular Bold", 16.25F, System.Drawing.FontStyle.Bold);
            this.txt_json.Location = new System.Drawing.Point(69, 87);
            this.txt_json.Name = "txt_json";
            this.txt_json.ReadOnly = true;
            this.txt_json.Size = new System.Drawing.Size(916, 557);
            this.txt_json.TabIndex = 32;
            this.txt_json.Text = "";
            // 
            // btn_codeOrTree
            // 
            this.btn_codeOrTree.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_codeOrTree.BackColor = System.Drawing.Color.Transparent;
            this.btn_codeOrTree.Image = global::ConversationHelper.Properties.Resources.hashtag;
            this.btn_codeOrTree.ImageActive = null;
            this.btn_codeOrTree.Location = new System.Drawing.Point(13, 595);
            this.btn_codeOrTree.Name = "btn_codeOrTree";
            this.btn_codeOrTree.Size = new System.Drawing.Size(50, 50);
            this.btn_codeOrTree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_codeOrTree.TabIndex = 31;
            this.btn_codeOrTree.TabStop = false;
            this.btn_codeOrTree.Zoom = 10;
            this.btn_codeOrTree.Click += new System.EventHandler(this.btn_codeOrTree_Click);
            // 
            // btn_down
            // 
            this.btn_down.BackColor = System.Drawing.Color.Transparent;
            this.btn_down.Image = global::ConversationHelper.Properties.Resources.down;
            this.btn_down.ImageActive = null;
            this.btn_down.Location = new System.Drawing.Point(14, 368);
            this.btn_down.Name = "btn_down";
            this.btn_down.Size = new System.Drawing.Size(50, 50);
            this.btn_down.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_down.TabIndex = 30;
            this.btn_down.TabStop = false;
            this.btn_down.Zoom = 10;
            this.btn_down.Click += new System.EventHandler(this.btn_down_Click);
            // 
            // btn_up
            // 
            this.btn_up.BackColor = System.Drawing.Color.Transparent;
            this.btn_up.Image = global::ConversationHelper.Properties.Resources.arrows;
            this.btn_up.ImageActive = null;
            this.btn_up.Location = new System.Drawing.Point(14, 312);
            this.btn_up.Name = "btn_up";
            this.btn_up.Size = new System.Drawing.Size(50, 50);
            this.btn_up.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_up.TabIndex = 29;
            this.btn_up.TabStop = false;
            this.btn_up.Zoom = 10;
            this.btn_up.Click += new System.EventHandler(this.btn_up_Click);
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.Image = global::ConversationHelper.Properties.Resources.close_1_;
            this.btn_close.ImageActive = null;
            this.btn_close.Location = new System.Drawing.Point(944, 7);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(50, 50);
            this.btn_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_close.TabIndex = 26;
            this.btn_close.TabStop = false;
            this.btn_close.Zoom = 10;
            this.btn_close.Click += new System.EventHandler(this.btn_close_click);
            // 
            // btn_minimize
            // 
            this.btn_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_minimize.BackColor = System.Drawing.Color.Transparent;
            this.btn_minimize.Image = global::ConversationHelper.Properties.Resources.minus;
            this.btn_minimize.ImageActive = null;
            this.btn_minimize.Location = new System.Drawing.Point(832, 7);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(50, 50);
            this.btn_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_minimize.TabIndex = 24;
            this.btn_minimize.TabStop = false;
            this.btn_minimize.Zoom = 10;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            // 
            // btn_enlarge_delarge
            // 
            this.btn_enlarge_delarge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_enlarge_delarge.BackColor = System.Drawing.Color.Transparent;
            this.btn_enlarge_delarge.Image = global::ConversationHelper.Properties.Resources.enlarge;
            this.btn_enlarge_delarge.ImageActive = null;
            this.btn_enlarge_delarge.Location = new System.Drawing.Point(888, 7);
            this.btn_enlarge_delarge.Name = "btn_enlarge_delarge";
            this.btn_enlarge_delarge.Size = new System.Drawing.Size(50, 50);
            this.btn_enlarge_delarge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_enlarge_delarge.TabIndex = 25;
            this.btn_enlarge_delarge.TabStop = false;
            this.btn_enlarge_delarge.Zoom = 10;
            this.btn_enlarge_delarge.Click += new System.EventHandler(this.btn_enlarge_delarge_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Transparent;
            this.btn_delete.Image = global::ConversationHelper.Properties.Resources.quit;
            this.btn_delete.ImageActive = null;
            this.btn_delete.Location = new System.Drawing.Point(14, 424);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(50, 50);
            this.btn_delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_delete.TabIndex = 23;
            this.btn_delete.TabStop = false;
            this.btn_delete.Zoom = 10;
            this.btn_delete.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_open
            // 
            this.btn_open.BackColor = System.Drawing.Color.Transparent;
            this.btn_open.Image = global::ConversationHelper.Properties.Resources._interface;
            this.btn_open.ImageActive = null;
            this.btn_open.Location = new System.Drawing.Point(14, 144);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(50, 50);
            this.btn_open.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_open.TabIndex = 19;
            this.btn_open.TabStop = false;
            this.btn_open.Zoom = 10;
            this.btn_open.Click += new System.EventHandler(this.btn_open_click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Transparent;
            this.btn_save.Image = ((System.Drawing.Image)(resources.GetObject("btn_save.Image")));
            this.btn_save.ImageActive = ((System.Drawing.Image)(resources.GetObject("btn_save.ImageActive")));
            this.btn_save.Location = new System.Drawing.Point(14, 200);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(50, 50);
            this.btn_save.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_save.TabIndex = 20;
            this.btn_save.TabStop = false;
            this.btn_save.Zoom = 10;
            this.btn_save.Click += new System.EventHandler(this.btn_save_click);
            // 
            // btn_new
            // 
            this.btn_new.BackColor = System.Drawing.Color.Transparent;
            this.btn_new.Image = global::ConversationHelper.Properties.Resources.more;
            this.btn_new.ImageActive = null;
            this.btn_new.Location = new System.Drawing.Point(14, 88);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(50, 50);
            this.btn_new.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_new.TabIndex = 18;
            this.btn_new.TabStop = false;
            this.btn_new.Zoom = 10;
            this.btn_new.Click += new System.EventHandler(this.btn_new_click);
            // 
            // btn_saveas
            // 
            this.btn_saveas.BackColor = System.Drawing.Color.Transparent;
            this.btn_saveas.Image = global::ConversationHelper.Properties.Resources.share_1_;
            this.btn_saveas.ImageActive = null;
            this.btn_saveas.Location = new System.Drawing.Point(14, 256);
            this.btn_saveas.Name = "btn_saveas";
            this.btn_saveas.Size = new System.Drawing.Size(50, 50);
            this.btn_saveas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_saveas.TabIndex = 21;
            this.btn_saveas.TabStop = false;
            this.btn_saveas.Zoom = 10;
            this.btn_saveas.Click += new System.EventHandler(this.btn_saveas_click);
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(997, 650);
            this.Controls.Add(this.btn_codeOrTree);
            this.Controls.Add(this.btn_down);
            this.Controls.Add(this.btn_up);
            this.Controls.Add(this.panel_top);
            this.Controls.Add(this.txt_answer_5);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.txt_answer_6);
            this.Controls.Add(this.lbl_answers);
            this.Controls.Add(this.txt_answer_4);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_answer_7);
            this.Controls.Add(this.txt_answer_1);
            this.Controls.Add(this.txt_question);
            this.Controls.Add(this.lbl_question);
            this.Controls.Add(this.txt_answer_3);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.txt_answer_8);
            this.Controls.Add(this.btn_saveas);
            this.Controls.Add(this.txt_answer_2);
            this.Controls.Add(this.treev_conversation);
            this.Controls.Add(this.txt_json);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "dashboard";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.dashboard_Load);
            this.panel_top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_codeOrTree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_down)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_up)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_enlarge_delarge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_open)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_save)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_new)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_saveas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treev_conversation;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_question;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_question;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_answers;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_answer_1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_answer_2;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_answer_3;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_answer_4;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_answer_5;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_answer_8;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_answer_7;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_answer_6;
        private Bunifu.Framework.UI.BunifuImageButton btn_new;
        private Bunifu.Framework.UI.BunifuImageButton btn_open;
        private Bunifu.Framework.UI.BunifuImageButton btn_save;
        private Bunifu.Framework.UI.BunifuImageButton btn_saveas;
        private Bunifu.Framework.UI.BunifuImageButton btn_close;
        private Bunifu.Framework.UI.BunifuImageButton btn_enlarge_delarge;
        private Bunifu.Framework.UI.BunifuImageButton btn_minimize;
        private Bunifu.Framework.UI.BunifuImageButton btn_delete;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_title;
        private System.Windows.Forms.Panel panel_top;
        private Bunifu.Framework.UI.BunifuImageButton btn_up;
        private Bunifu.Framework.UI.BunifuImageButton btn_down;
        private Bunifu.Framework.UI.BunifuImageButton btn_codeOrTree;
        private System.Windows.Forms.RichTextBox txt_json;
    }
}

