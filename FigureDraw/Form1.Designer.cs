namespace FigureDraw
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnShape = new System.Windows.Forms.Panel();
            this.radioStar = new System.Windows.Forms.RadioButton();
            this.radioRound = new System.Windows.Forms.RadioButton();
            this.radioRect = new System.Windows.Forms.RadioButton();
            this.radioLine = new System.Windows.Forms.RadioButton();
            this.pnCanvas = new System.Windows.Forms.Panel();
            this.pnLib = new System.Windows.Forms.Panel();
            this.radioCairo = new System.Windows.Forms.RadioButton();
            this.radioGdi = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnType = new System.Windows.Forms.Panel();
            this.radioDiagram = new System.Windows.Forms.RadioButton();
            this.radioShape = new System.Windows.Forms.RadioButton();
            this.pnDiagram = new System.Windows.Forms.Panel();
            this.radioAcD = new System.Windows.Forms.RadioButton();
            this.radioDfdD = new System.Windows.Forms.RadioButton();
            this.radioFcD = new System.Windows.Forms.RadioButton();
            this.pnBlock = new System.Windows.Forms.Panel();
            this.radioInputB = new System.Windows.Forms.RadioButton();
            this.radioStartB = new System.Windows.Forms.RadioButton();
            this.pnEffect = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbHighlight = new System.Windows.Forms.CheckBox();
            this.cbShadow = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnShape.SuspendLayout();
            this.pnLib.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.pnType.SuspendLayout();
            this.pnDiagram.SuspendLayout();
            this.pnBlock.SuspendLayout();
            this.pnEffect.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(552, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(8, 8);
            this.panel1.TabIndex = 0;
            // 
            // pnShape
            // 
            this.pnShape.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnShape.Controls.Add(this.radioStar);
            this.pnShape.Controls.Add(this.radioRound);
            this.pnShape.Controls.Add(this.radioRect);
            this.pnShape.Controls.Add(this.radioLine);
            this.pnShape.Location = new System.Drawing.Point(132, 27);
            this.pnShape.Name = "pnShape";
            this.pnShape.Size = new System.Drawing.Size(512, 51);
            this.pnShape.TabIndex = 1;
            // 
            // radioStar
            // 
            this.radioStar.AutoSize = true;
            this.radioStar.Location = new System.Drawing.Point(246, 17);
            this.radioStar.Name = "radioStar";
            this.radioStar.Size = new System.Drawing.Size(44, 17);
            this.radioStar.TabIndex = 3;
            this.radioStar.Text = "Star";
            this.radioStar.UseVisualStyleBackColor = true;
            // 
            // radioRound
            // 
            this.radioRound.AutoSize = true;
            this.radioRound.Location = new System.Drawing.Point(170, 17);
            this.radioRound.Name = "radioRound";
            this.radioRound.Size = new System.Drawing.Size(57, 17);
            this.radioRound.TabIndex = 2;
            this.radioRound.TabStop = true;
            this.radioRound.Text = "Round";
            this.radioRound.UseVisualStyleBackColor = true;
            // 
            // radioRect
            // 
            this.radioRect.AutoSize = true;
            this.radioRect.Location = new System.Drawing.Point(81, 17);
            this.radioRect.Name = "radioRect";
            this.radioRect.Size = new System.Drawing.Size(74, 17);
            this.radioRect.TabIndex = 1;
            this.radioRect.TabStop = true;
            this.radioRect.Text = "Rectangle";
            this.radioRect.UseVisualStyleBackColor = true;
            // 
            // radioLine
            // 
            this.radioLine.AutoSize = true;
            this.radioLine.Checked = true;
            this.radioLine.Location = new System.Drawing.Point(19, 17);
            this.radioLine.Name = "radioLine";
            this.radioLine.Size = new System.Drawing.Size(45, 17);
            this.radioLine.TabIndex = 0;
            this.radioLine.TabStop = true;
            this.radioLine.Text = "Line";
            this.radioLine.UseVisualStyleBackColor = true;
            // 
            // pnCanvas
            // 
            this.pnCanvas.BackColor = System.Drawing.Color.White;
            this.pnCanvas.Location = new System.Drawing.Point(13, 138);
            this.pnCanvas.Name = "pnCanvas";
            this.pnCanvas.Size = new System.Drawing.Size(775, 461);
            this.pnCanvas.TabIndex = 2;
            this.pnCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pnCanvas_Paint);
            this.pnCanvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnCanvas_click);
            this.pnCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnCanvas_MouseMove);
            // 
            // pnLib
            // 
            this.pnLib.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnLib.Controls.Add(this.radioCairo);
            this.pnLib.Controls.Add(this.radioGdi);
            this.pnLib.Location = new System.Drawing.Point(650, 27);
            this.pnLib.Name = "pnLib";
            this.pnLib.Size = new System.Drawing.Size(138, 51);
            this.pnLib.TabIndex = 3;
            // 
            // radioCairo
            // 
            this.radioCairo.AutoSize = true;
            this.radioCairo.Location = new System.Drawing.Point(80, 17);
            this.radioCairo.Name = "radioCairo";
            this.radioCairo.Size = new System.Drawing.Size(49, 17);
            this.radioCairo.TabIndex = 3;
            this.radioCairo.Text = "Cairo";
            this.radioCairo.UseVisualStyleBackColor = true;
            // 
            // radioGdi
            // 
            this.radioGdi.AutoSize = true;
            this.radioGdi.Checked = true;
            this.radioGdi.Location = new System.Drawing.Point(13, 17);
            this.radioGdi.Name = "radioGdi";
            this.radioGdi.Size = new System.Drawing.Size(61, 17);
            this.radioGdi.TabIndex = 2;
            this.radioGdi.TabStop = true;
            this.radioGdi.Text = "GdiPlus";
            this.radioGdi.UseVisualStyleBackColor = true;
            this.radioGdi.CheckedChanged += new System.EventHandler(this.radioGdi_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // pnType
            // 
            this.pnType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnType.Controls.Add(this.radioDiagram);
            this.pnType.Controls.Add(this.radioShape);
            this.pnType.Location = new System.Drawing.Point(13, 27);
            this.pnType.Name = "pnType";
            this.pnType.Size = new System.Drawing.Size(113, 103);
            this.pnType.TabIndex = 5;
            // 
            // radioDiagram
            // 
            this.radioDiagram.AutoSize = true;
            this.radioDiagram.Location = new System.Drawing.Point(17, 71);
            this.radioDiagram.Name = "radioDiagram";
            this.radioDiagram.Size = new System.Drawing.Size(64, 17);
            this.radioDiagram.TabIndex = 3;
            this.radioDiagram.TabStop = true;
            this.radioDiagram.Text = "Diagram";
            this.radioDiagram.UseVisualStyleBackColor = true;
            // 
            // radioShape
            // 
            this.radioShape.AutoSize = true;
            this.radioShape.Checked = true;
            this.radioShape.Location = new System.Drawing.Point(17, 17);
            this.radioShape.Name = "radioShape";
            this.radioShape.Size = new System.Drawing.Size(56, 17);
            this.radioShape.TabIndex = 2;
            this.radioShape.TabStop = true;
            this.radioShape.Text = "Shape";
            this.radioShape.UseVisualStyleBackColor = true;
            this.radioShape.CheckedChanged += new System.EventHandler(this.radioShape_CheckedChanged);
            // 
            // pnDiagram
            // 
            this.pnDiagram.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnDiagram.Controls.Add(this.radioAcD);
            this.pnDiagram.Controls.Add(this.radioDfdD);
            this.pnDiagram.Controls.Add(this.radioFcD);
            this.pnDiagram.Enabled = false;
            this.pnDiagram.Location = new System.Drawing.Point(132, 81);
            this.pnDiagram.Name = "pnDiagram";
            this.pnDiagram.Size = new System.Drawing.Size(228, 51);
            this.pnDiagram.TabIndex = 4;
            // 
            // radioAcD
            // 
            this.radioAcD.AutoSize = true;
            this.radioAcD.Location = new System.Drawing.Point(170, 16);
            this.radioAcD.Name = "radioAcD";
            this.radioAcD.Size = new System.Drawing.Size(59, 17);
            this.radioAcD.TabIndex = 5;
            this.radioAcD.TabStop = true;
            this.radioAcD.Text = "Activity";
            this.radioAcD.UseVisualStyleBackColor = true;
            this.radioAcD.CheckedChanged += new System.EventHandler(this.radioAcD_CheckedChanged);
            // 
            // radioDfdD
            // 
            this.radioDfdD.AutoSize = true;
            this.radioDfdD.Location = new System.Drawing.Point(90, 16);
            this.radioDfdD.Name = "radioDfdD";
            this.radioDfdD.Size = new System.Drawing.Size(73, 17);
            this.radioDfdD.TabIndex = 4;
            this.radioDfdD.TabStop = true;
            this.radioDfdD.Text = "Data Flow";
            this.radioDfdD.UseVisualStyleBackColor = true;
            this.radioDfdD.CheckedChanged += new System.EventHandler(this.radioDfdD_CheckedChanged);
            // 
            // radioFcD
            // 
            this.radioFcD.AutoSize = true;
            this.radioFcD.Checked = true;
            this.radioFcD.Location = new System.Drawing.Point(9, 16);
            this.radioFcD.Name = "radioFcD";
            this.radioFcD.Size = new System.Drawing.Size(75, 17);
            this.radioFcD.TabIndex = 3;
            this.radioFcD.TabStop = true;
            this.radioFcD.Text = "Flow Chart";
            this.radioFcD.UseVisualStyleBackColor = true;
            this.radioFcD.CheckedChanged += new System.EventHandler(this.radioFcD_CheckedChanged);
            // 
            // pnBlock
            // 
            this.pnBlock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnBlock.Controls.Add(this.label2);
            this.pnBlock.Controls.Add(this.radioInputB);
            this.pnBlock.Controls.Add(this.radioStartB);
            this.pnBlock.Enabled = false;
            this.pnBlock.Location = new System.Drawing.Point(368, 81);
            this.pnBlock.Name = "pnBlock";
            this.pnBlock.Size = new System.Drawing.Size(200, 51);
            this.pnBlock.TabIndex = 6;
            // 
            // radioInputB
            // 
            this.radioInputB.AutoSize = true;
            this.radioInputB.Location = new System.Drawing.Point(132, 17);
            this.radioInputB.Name = "radioInputB";
            this.radioInputB.Size = new System.Drawing.Size(49, 17);
            this.radioInputB.TabIndex = 3;
            this.radioInputB.Text = "Input";
            this.radioInputB.UseVisualStyleBackColor = true;
            // 
            // radioStartB
            // 
            this.radioStartB.AutoSize = true;
            this.radioStartB.Checked = true;
            this.radioStartB.Location = new System.Drawing.Point(79, 17);
            this.radioStartB.Name = "radioStartB";
            this.radioStartB.Size = new System.Drawing.Size(47, 17);
            this.radioStartB.TabIndex = 2;
            this.radioStartB.TabStop = true;
            this.radioStartB.Text = "Start";
            this.radioStartB.UseVisualStyleBackColor = true;
            // 
            // pnEffect
            // 
            this.pnEffect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnEffect.Controls.Add(this.cbShadow);
            this.pnEffect.Controls.Add(this.cbHighlight);
            this.pnEffect.Controls.Add(this.label1);
            this.pnEffect.Location = new System.Drawing.Point(574, 81);
            this.pnEffect.Name = "pnEffect";
            this.pnEffect.Size = new System.Drawing.Size(214, 51);
            this.pnEffect.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Effect :";
            // 
            // cbHighlight
            // 
            this.cbHighlight.AutoSize = true;
            this.cbHighlight.Location = new System.Drawing.Point(69, 16);
            this.cbHighlight.Name = "cbHighlight";
            this.cbHighlight.Size = new System.Drawing.Size(67, 17);
            this.cbHighlight.TabIndex = 5;
            this.cbHighlight.Text = "Highlight";
            this.cbHighlight.UseVisualStyleBackColor = true;
            // 
            // cbShadow
            // 
            this.cbShadow.AutoSize = true;
            this.cbShadow.Location = new System.Drawing.Point(142, 16);
            this.cbShadow.Name = "cbShadow";
            this.cbShadow.Size = new System.Drawing.Size(65, 17);
            this.cbShadow.TabIndex = 6;
            this.cbShadow.Text = "Shadow";
            this.cbShadow.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Block :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 611);
            this.Controls.Add(this.pnEffect);
            this.Controls.Add(this.pnBlock);
            this.Controls.Add(this.pnDiagram);
            this.Controls.Add(this.pnType);
            this.Controls.Add(this.pnLib);
            this.Controls.Add(this.pnCanvas);
            this.Controls.Add(this.pnShape);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnShape.ResumeLayout(false);
            this.pnShape.PerformLayout();
            this.pnLib.ResumeLayout(false);
            this.pnLib.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnType.ResumeLayout(false);
            this.pnType.PerformLayout();
            this.pnDiagram.ResumeLayout(false);
            this.pnDiagram.PerformLayout();
            this.pnBlock.ResumeLayout(false);
            this.pnBlock.PerformLayout();
            this.pnEffect.ResumeLayout(false);
            this.pnEffect.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnShape;
        private System.Windows.Forms.Panel pnCanvas;
        private System.Windows.Forms.RadioButton radioLine;
        private System.Windows.Forms.RadioButton radioRect;
        private System.Windows.Forms.Panel pnLib;
        private System.Windows.Forms.RadioButton radioGdi;
        private System.Windows.Forms.RadioButton radioCairo;
        private System.Windows.Forms.RadioButton radioRound;
        private System.Windows.Forms.RadioButton radioStar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.Panel pnType;
        private System.Windows.Forms.RadioButton radioShape;
        private System.Windows.Forms.RadioButton radioDiagram;
        private System.Windows.Forms.Panel pnDiagram;
        private System.Windows.Forms.RadioButton radioAcD;
        private System.Windows.Forms.RadioButton radioDfdD;
        private System.Windows.Forms.RadioButton radioFcD;
        private System.Windows.Forms.Panel pnBlock;
        private System.Windows.Forms.RadioButton radioInputB;
        private System.Windows.Forms.RadioButton radioStartB;
        private System.Windows.Forms.Panel pnEffect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbHighlight;
        private System.Windows.Forms.CheckBox cbShadow;
        private System.Windows.Forms.Label label2;
    }
}

