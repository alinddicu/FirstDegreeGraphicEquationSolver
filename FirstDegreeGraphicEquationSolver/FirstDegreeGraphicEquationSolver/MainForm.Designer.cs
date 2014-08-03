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
            this.trackBarScale = new System.Windows.Forms.TrackBar();
            this.statusStripBottom1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelPointerCoords = new System.Windows.Forms.ToolStripStatusLabel();
            this.mousePointerPositionLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this._drawingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarScale)).BeginInit();
            this.statusStripBottom1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _drawingPanel
            // 
            this._drawingPanel.Controls.Add(this.trackBarScale);
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
            this.trackBarScale.LargeChange = 1;
            this.trackBarScale.Location = new System.Drawing.Point(3, 3);
            this.trackBarScale.Minimum = 1;
            this.trackBarScale.Name = "trackBarScale";
            this.trackBarScale.Size = new System.Drawing.Size(104, 45);
            this.trackBarScale.TabIndex = 2;
            this.trackBarScale.Value = 1;
            this.trackBarScale.ValueChanged += new System.EventHandler(this.trackBarScale_ValueChanged);
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
            ((System.ComponentModel.ISupportInitialize)(this.trackBarScale)).EndInit();
            this.statusStripBottom1.ResumeLayout(false);
            this.statusStripBottom1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel _drawingPanel;
        private System.Windows.Forms.StatusStrip statusStripBottom1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelPointerCoords;
        private System.Windows.Forms.ToolStripStatusLabel mousePointerPositionLabel;
        private System.Windows.Forms.TrackBar trackBarScale;

    }
}

