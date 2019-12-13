namespace FormUI
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.graphrbMp = new MetroFramework.Controls.MetroPanel();
            this.graph_minRb = new MetroFramework.Controls.MetroRadioButton();
            this.graphRb = new MetroFramework.Controls.MetroRadioButton();
            this.fileLbl = new MetroFramework.Controls.MetroLabel();
            this.findPathBtn = new MetroFramework.Controls.MetroButton();
            this.fileTb = new System.Windows.Forms.RichTextBox();
            this.readfileBtn = new MetroFramework.Controls.MetroButton();
            this.resTb = new System.Windows.Forms.RichTextBox();
            this.graphViewer = new Microsoft.Glee.GraphViewerGdi.GViewer();
            this.graphrbMp.SuspendLayout();
            this.SuspendLayout();
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // graphrbMp
            // 
            this.graphrbMp.Controls.Add(this.graph_minRb);
            this.graphrbMp.Controls.Add(this.graphRb);
            this.graphrbMp.Enabled = false;
            this.graphrbMp.HorizontalScrollbarBarColor = true;
            this.graphrbMp.HorizontalScrollbarHighlightOnWheel = false;
            this.graphrbMp.HorizontalScrollbarSize = 10;
            this.graphrbMp.Location = new System.Drawing.Point(23, 596);
            this.graphrbMp.Name = "graphrbMp";
            this.graphrbMp.Size = new System.Drawing.Size(677, 35);
            this.graphrbMp.TabIndex = 31;
            this.graphrbMp.VerticalScrollbarBarColor = true;
            this.graphrbMp.VerticalScrollbarHighlightOnWheel = false;
            this.graphrbMp.VerticalScrollbarSize = 10;
            // 
            // graph_minRb
            // 
            this.graph_minRb.AutoSize = true;
            this.graph_minRb.Location = new System.Drawing.Point(81, 8);
            this.graph_minRb.Name = "graph_minRb";
            this.graph_minRb.Size = new System.Drawing.Size(93, 15);
            this.graph_minRb.TabIndex = 3;
            this.graph_minRb.Text = "Optimal path";
            this.graph_minRb.UseSelectable = true;
            this.graph_minRb.CheckedChanged += new System.EventHandler(this.graph_minRb_CheckedChanged);
            // 
            // graphRb
            // 
            this.graphRb.AutoSize = true;
            this.graphRb.Checked = true;
            this.graphRb.Location = new System.Drawing.Point(12, 8);
            this.graphRb.Name = "graphRb";
            this.graphRb.Size = new System.Drawing.Size(55, 15);
            this.graphRb.TabIndex = 2;
            this.graphRb.TabStop = true;
            this.graphRb.Text = "Graph";
            this.graphRb.UseSelectable = true;
            this.graphRb.CheckedChanged += new System.EventHandler(this.graphRb_CheckedChanged);
            // 
            // fileLbl
            // 
            this.fileLbl.Location = new System.Drawing.Point(482, 247);
            this.fileLbl.Name = "fileLbl";
            this.fileLbl.Size = new System.Drawing.Size(218, 19);
            this.fileLbl.TabIndex = 30;
            this.fileLbl.Text = "No file opened";
            this.fileLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // findPathBtn
            // 
            this.findPathBtn.Location = new System.Drawing.Point(482, 22);
            this.findPathBtn.Name = "findPathBtn";
            this.findPathBtn.Size = new System.Drawing.Size(122, 34);
            this.findPathBtn.TabIndex = 29;
            this.findPathBtn.Text = "Execute";
            this.findPathBtn.UseSelectable = true;
            this.findPathBtn.Click += new System.EventHandler(this.findPathBtn_Click);
            // 
            // fileTb
            // 
            this.fileTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fileTb.Location = new System.Drawing.Point(482, 77);
            this.fileTb.Name = "fileTb";
            this.fileTb.ReadOnly = true;
            this.fileTb.Size = new System.Drawing.Size(217, 189);
            this.fileTb.TabIndex = 28;
            this.fileTb.Text = "";
            // 
            // readfileBtn
            // 
            this.readfileBtn.Location = new System.Drawing.Point(316, 22);
            this.readfileBtn.Name = "readfileBtn";
            this.readfileBtn.Size = new System.Drawing.Size(160, 34);
            this.readfileBtn.TabIndex = 27;
            this.readfileBtn.Text = "Read data from a text file";
            this.readfileBtn.UseSelectable = true;
            this.readfileBtn.Click += new System.EventHandler(this.readfileBtn_Click);
            // 
            // resTb
            // 
            this.resTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resTb.Location = new System.Drawing.Point(23, 77);
            this.resTb.Name = "resTb";
            this.resTb.Size = new System.Drawing.Size(453, 189);
            this.resTb.TabIndex = 26;
            this.resTb.Text = "";
            // 
            // graphViewer
            // 
            this.graphViewer.AsyncLayout = false;
            this.graphViewer.AutoScroll = true;
            this.graphViewer.BackwardEnabled = false;
            this.graphViewer.ForwardEnabled = false;
            this.graphViewer.Graph = null;
            this.graphViewer.Location = new System.Drawing.Point(23, 272);
            this.graphViewer.MouseHitDistance = 0.05D;
            this.graphViewer.Name = "graphViewer";
            this.graphViewer.NavigationVisible = true;
            this.graphViewer.PanButtonPressed = false;
            this.graphViewer.SaveButtonVisible = true;
            this.graphViewer.Size = new System.Drawing.Size(676, 318);
            this.graphViewer.TabIndex = 32;
            this.graphViewer.ZoomF = 1D;
            this.graphViewer.ZoomFraction = 0.5D;
            this.graphViewer.ZoomWindowThreshold = 0.05D;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 631);
            this.Controls.Add(this.graphViewer);
            this.Controls.Add(this.graphrbMp);
            this.Controls.Add(this.fileLbl);
            this.Controls.Add(this.findPathBtn);
            this.Controls.Add(this.fileTb);
            this.Controls.Add(this.readfileBtn);
            this.Controls.Add(this.resTb);
            this.Name = "MainForm";
            this.Resizable = false;
            this.Text = "Travelling salesman problem";
            this.graphrbMp.ResumeLayout(false);
            this.graphrbMp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog ofd;
        private MetroFramework.Controls.MetroPanel graphrbMp;
        private MetroFramework.Controls.MetroRadioButton graph_minRb;
        private MetroFramework.Controls.MetroRadioButton graphRb;
        private MetroFramework.Controls.MetroLabel fileLbl;
        private MetroFramework.Controls.MetroButton findPathBtn;
        public System.Windows.Forms.RichTextBox fileTb;
        private MetroFramework.Controls.MetroButton readfileBtn;
        public System.Windows.Forms.RichTextBox resTb;
        private Microsoft.Glee.GraphViewerGdi.GViewer graphViewer;
    }
}

