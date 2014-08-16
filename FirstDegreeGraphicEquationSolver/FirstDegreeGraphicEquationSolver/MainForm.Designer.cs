namespace FirstDegreeGraphicEquationSolver
{
    partial class MainForm
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
            this._drawingPanel = new System.Windows.Forms.Panel();
            this._scaleTrackBar = new System.Windows.Forms.TrackBar();
            this.statusStripBottom1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelPointerCoords = new System.Windows.Forms.ToolStripStatusLabel();
            this.mousePointerPositionLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this._controlPanel = new System.Windows.Forms.Panel();
            this._equationTextBox = new System.Windows.Forms.TextBox();
            this._equationListBox = new System.Windows.Forms.ListBox();
            this._drawingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._scaleTrackBar)).BeginInit();
            this.statusStripBottom1.SuspendLayout();
            this._controlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // _drawingPanel
            // 
            this._drawingPanel.Controls.Add(this._controlPanel);
            this._drawingPanel.Controls.Add(this.statusStripBottom1);
            this._drawingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._drawingPanel.Location = new System.Drawing.Point(0, 0);
            this._drawingPanel.Name = "_drawingPanel";
            this._drawingPanel.Size = new System.Drawing.Size(623, 429);
            this._drawingPanel.TabIndex = 0;
            this._drawingPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drawingPanel_MouseMove);
            // 
            // trackBarScale
            // 
            this._scaleTrackBar.LargeChange = 1;
            this._scaleTrackBar.Location = new System.Drawing.Point(3, 3);
            this._scaleTrackBar.Minimum = 1;
            this._scaleTrackBar.Name = "trackBarScale";
            this._scaleTrackBar.Size = new System.Drawing.Size(126, 45);
            this._scaleTrackBar.TabIndex = 2;
            this._scaleTrackBar.Value = 1;
            this._scaleTrackBar.ValueChanged += new System.EventHandler(this.trackBarScale_ValueChanged);
            // 
            // statusStripBottom1
            // 
            this.statusStripBottom1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelPointerCoords,
            this.mousePointerPositionLabel});
            this.statusStripBottom1.Location = new System.Drawing.Point(0, 407);
            this.statusStripBottom1.Name = "statusStripBottom1";
            this.statusStripBottom1.Size = new System.Drawing.Size(623, 22);
            this.statusStripBottom1.TabIndex = 0;
            // 
            // toolStripStatusLabelPointerCoords
            // 
            this.toolStripStatusLabelPointerCoords.Name = "toolStripStatusLabelPointerCoords";
            this.toolStripStatusLabelPointerCoords.Size = new System.Drawing.Size(0, 17);
            // 
            // mousePointerPositionLabel
            // 
            this.mousePointerPositionLabel.Name = "mousePointerPositionLabel";
            this.mousePointerPositionLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // _controlPanel
            // 
            this._controlPanel.Controls.Add(this._equationListBox);
            this._controlPanel.Controls.Add(this._equationTextBox);
            this._controlPanel.Controls.Add(this._scaleTrackBar);
            this._controlPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this._controlPanel.Location = new System.Drawing.Point(0, 0);
            this._controlPanel.Name = "_controlPanel";
            this._controlPanel.Size = new System.Drawing.Size(132, 407);
            this._controlPanel.TabIndex = 3;
            // 
            // _equationTextBox
            // 
            this._equationTextBox.Location = new System.Drawing.Point(3, 49);
            this._equationTextBox.Name = "_equationTextBox";
            this._equationTextBox.Size = new System.Drawing.Size(126, 20);
            this._equationTextBox.TabIndex = 3;
            this._equationTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.equationTextBox_KeyPress);
            // 
            // _equationListBox
            // 
            this._equationListBox.FormattingEnabled = true;
            this._equationListBox.Location = new System.Drawing.Point(3, 73);
            this._equationListBox.Name = "_equationListBox";
            this._equationListBox.Size = new System.Drawing.Size(126, 368);
            this._equationListBox.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 429);
            this.Controls.Add(this._drawingPanel);
            this.Name = "MainForm";
            this.Text = "First degree graphical equation solver";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this._drawingPanel.ResumeLayout(false);
            this._drawingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._scaleTrackBar)).EndInit();
            this.statusStripBottom1.ResumeLayout(false);
            this.statusStripBottom1.PerformLayout();
            this._controlPanel.ResumeLayout(false);
            this._controlPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel _drawingPanel;
        private System.Windows.Forms.StatusStrip statusStripBottom1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelPointerCoords;
        private System.Windows.Forms.ToolStripStatusLabel mousePointerPositionLabel;
        private System.Windows.Forms.TrackBar _scaleTrackBar;
        private System.Windows.Forms.Panel _controlPanel;
    }
}

