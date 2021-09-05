
namespace RawDataSender4
{
    partial class ClientForm
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
            this.splitContainerTop = new System.Windows.Forms.SplitContainer();
            this.splitContainerHex = new System.Windows.Forms.SplitContainer();
            this.richTextBoxIncomingHex = new System.Windows.Forms.RichTextBox();
            this.richTextBoxOutgoingHex = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxOutgoingHex = new System.Windows.Forms.TextBox();
            this.splitContainerText = new System.Windows.Forms.SplitContainer();
            this.richTextBoxIncomingText = new System.Windows.Forms.RichTextBox();
            this.richTextBoxOutgoingText = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxOutgoingText = new System.Windows.Forms.TextBox();
            this.statusStripTop = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelConnection = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTop)).BeginInit();
            this.splitContainerTop.Panel1.SuspendLayout();
            this.splitContainerTop.Panel2.SuspendLayout();
            this.splitContainerTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerHex)).BeginInit();
            this.splitContainerHex.Panel1.SuspendLayout();
            this.splitContainerHex.Panel2.SuspendLayout();
            this.splitContainerHex.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerText)).BeginInit();
            this.splitContainerText.Panel1.SuspendLayout();
            this.splitContainerText.Panel2.SuspendLayout();
            this.splitContainerText.SuspendLayout();
            this.statusStripTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerTop
            // 
            this.splitContainerTop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerTop.BackColor = System.Drawing.SystemColors.ControlDark;
            this.splitContainerTop.Location = new System.Drawing.Point(0, 0);
            this.splitContainerTop.Name = "splitContainerTop";
            // 
            // splitContainerTop.Panel1
            // 
            this.splitContainerTop.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainerTop.Panel1.Controls.Add(this.splitContainerHex);
            this.splitContainerTop.Panel1.Controls.Add(this.label1);
            this.splitContainerTop.Panel1.Controls.Add(this.textBoxOutgoingHex);
            // 
            // splitContainerTop.Panel2
            // 
            this.splitContainerTop.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainerTop.Panel2.Controls.Add(this.splitContainerText);
            this.splitContainerTop.Panel2.Controls.Add(this.label2);
            this.splitContainerTop.Panel2.Controls.Add(this.textBoxOutgoingText);
            this.splitContainerTop.Size = new System.Drawing.Size(549, 437);
            this.splitContainerTop.SplitterDistance = 274;
            this.splitContainerTop.TabIndex = 3;
            this.splitContainerTop.TabStop = false;
            this.splitContainerTop.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainerTop_SplitterMoved);
            // 
            // splitContainerHex
            // 
            this.splitContainerHex.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerHex.BackColor = System.Drawing.SystemColors.ControlDark;
            this.splitContainerHex.Location = new System.Drawing.Point(12, 29);
            this.splitContainerHex.Name = "splitContainerHex";
            this.splitContainerHex.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerHex.Panel1
            // 
            this.splitContainerHex.Panel1.Controls.Add(this.richTextBoxIncomingHex);
            // 
            // splitContainerHex.Panel2
            // 
            this.splitContainerHex.Panel2.Controls.Add(this.richTextBoxOutgoingHex);
            this.splitContainerHex.Size = new System.Drawing.Size(259, 372);
            this.splitContainerHex.SplitterDistance = 176;
            this.splitContainerHex.TabIndex = 3;
            this.splitContainerHex.TabStop = false;
            this.splitContainerHex.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainerHex_SplitterMoved);
            // 
            // richTextBoxIncomingHex
            // 
            this.richTextBoxIncomingHex.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxIncomingHex.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.richTextBoxIncomingHex.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxIncomingHex.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxIncomingHex.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxIncomingHex.Name = "richTextBoxIncomingHex";
            this.richTextBoxIncomingHex.ReadOnly = true;
            this.richTextBoxIncomingHex.Size = new System.Drawing.Size(259, 173);
            this.richTextBoxIncomingHex.TabIndex = 3;
            this.richTextBoxIncomingHex.TabStop = false;
            this.richTextBoxIncomingHex.Text = "";
            // 
            // richTextBoxOutgoingHex
            // 
            this.richTextBoxOutgoingHex.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxOutgoingHex.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.richTextBoxOutgoingHex.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxOutgoingHex.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxOutgoingHex.Location = new System.Drawing.Point(0, -1);
            this.richTextBoxOutgoingHex.Name = "richTextBoxOutgoingHex";
            this.richTextBoxOutgoingHex.ReadOnly = true;
            this.richTextBoxOutgoingHex.Size = new System.Drawing.Size(259, 193);
            this.richTextBoxOutgoingHex.TabIndex = 4;
            this.richTextBoxOutgoingHex.TabStop = false;
            this.richTextBoxOutgoingHex.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hex";
            // 
            // textBoxOutgoingHex
            // 
            this.textBoxOutgoingHex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOutgoingHex.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxOutgoingHex.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOutgoingHex.Location = new System.Drawing.Point(12, 407);
            this.textBoxOutgoingHex.Multiline = true;
            this.textBoxOutgoingHex.Name = "textBoxOutgoingHex";
            this.textBoxOutgoingHex.Size = new System.Drawing.Size(259, 20);
            this.textBoxOutgoingHex.TabIndex = 1;
            this.textBoxOutgoingHex.TextChanged += new System.EventHandler(this.textBoxOutgoingHex_TextChanged);
            this.textBoxOutgoingHex.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxOutgoingHex_KeyDown);
            this.textBoxOutgoingHex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxOutgoingHex_KeyPress);
            this.textBoxOutgoingHex.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.textBoxOutgoingHex_PreviewKeyDown);
            // 
            // splitContainerText
            // 
            this.splitContainerText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerText.BackColor = System.Drawing.SystemColors.ControlDark;
            this.splitContainerText.Location = new System.Drawing.Point(3, 29);
            this.splitContainerText.Name = "splitContainerText";
            this.splitContainerText.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerText.Panel1
            // 
            this.splitContainerText.Panel1.Controls.Add(this.richTextBoxIncomingText);
            // 
            // splitContainerText.Panel2
            // 
            this.splitContainerText.Panel2.Controls.Add(this.richTextBoxOutgoingText);
            this.splitContainerText.Size = new System.Drawing.Size(256, 372);
            this.splitContainerText.SplitterDistance = 176;
            this.splitContainerText.TabIndex = 5;
            this.splitContainerText.TabStop = false;
            this.splitContainerText.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainerText_SplitterMoved);
            // 
            // richTextBoxIncomingText
            // 
            this.richTextBoxIncomingText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxIncomingText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.richTextBoxIncomingText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxIncomingText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxIncomingText.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxIncomingText.Name = "richTextBoxIncomingText";
            this.richTextBoxIncomingText.ReadOnly = true;
            this.richTextBoxIncomingText.Size = new System.Drawing.Size(256, 173);
            this.richTextBoxIncomingText.TabIndex = 3;
            this.richTextBoxIncomingText.TabStop = false;
            this.richTextBoxIncomingText.Text = "";
            // 
            // richTextBoxOutgoingText
            // 
            this.richTextBoxOutgoingText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxOutgoingText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.richTextBoxOutgoingText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxOutgoingText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxOutgoingText.Location = new System.Drawing.Point(0, -1);
            this.richTextBoxOutgoingText.Name = "richTextBoxOutgoingText";
            this.richTextBoxOutgoingText.ReadOnly = true;
            this.richTextBoxOutgoingText.Size = new System.Drawing.Size(256, 193);
            this.richTextBoxOutgoingText.TabIndex = 4;
            this.richTextBoxOutgoingText.TabStop = false;
            this.richTextBoxOutgoingText.Text = "";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(228, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Text";
            // 
            // textBoxOutgoingText
            // 
            this.textBoxOutgoingText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOutgoingText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxOutgoingText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOutgoingText.Location = new System.Drawing.Point(3, 407);
            this.textBoxOutgoingText.Multiline = true;
            this.textBoxOutgoingText.Name = "textBoxOutgoingText";
            this.textBoxOutgoingText.Size = new System.Drawing.Size(256, 20);
            this.textBoxOutgoingText.TabIndex = 0;
            this.textBoxOutgoingText.TextChanged += new System.EventHandler(this.textBoxOutgoingText_TextChanged);
            this.textBoxOutgoingText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxOutgoingText_KeyDown);
            this.textBoxOutgoingText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxOutgoingText_KeyPress);
            this.textBoxOutgoingText.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.textBoxOutgoingText_PreviewKeyDown);
            // 
            // statusStripTop
            // 
            this.statusStripTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelConnection});
            this.statusStripTop.Location = new System.Drawing.Point(0, 440);
            this.statusStripTop.Name = "statusStripTop";
            this.statusStripTop.Size = new System.Drawing.Size(549, 22);
            this.statusStripTop.TabIndex = 1;
            this.statusStripTop.Text = "statusStrip1";
            // 
            // toolStripStatusLabelConnection
            // 
            this.toolStripStatusLabelConnection.Name = "toolStripStatusLabelConnection";
            this.toolStripStatusLabelConnection.Size = new System.Drawing.Size(69, 17);
            this.toolStripStatusLabelConnection.Text = "Placeholder";
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 462);
            this.Controls.Add(this.statusStripTop);
            this.Controls.Add(this.splitContainerTop);
            this.Name = "ClientForm";
            this.Text = "ClientForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ClientForm_FormClosed);
            this.Load += new System.EventHandler(this.ClientForm_Load);
            this.Resize += new System.EventHandler(this.ClientForm_Resize);
            this.splitContainerTop.Panel1.ResumeLayout(false);
            this.splitContainerTop.Panel1.PerformLayout();
            this.splitContainerTop.Panel2.ResumeLayout(false);
            this.splitContainerTop.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTop)).EndInit();
            this.splitContainerTop.ResumeLayout(false);
            this.splitContainerHex.Panel1.ResumeLayout(false);
            this.splitContainerHex.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerHex)).EndInit();
            this.splitContainerHex.ResumeLayout(false);
            this.splitContainerText.Panel1.ResumeLayout(false);
            this.splitContainerText.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerText)).EndInit();
            this.splitContainerText.ResumeLayout(false);
            this.statusStripTop.ResumeLayout(false);
            this.statusStripTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerTop;
        private System.Windows.Forms.TextBox textBoxOutgoingHex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxOutgoingText;
        private System.Windows.Forms.SplitContainer splitContainerHex;
        private System.Windows.Forms.RichTextBox richTextBoxIncomingHex;
        private System.Windows.Forms.RichTextBox richTextBoxOutgoingHex;
        private System.Windows.Forms.SplitContainer splitContainerText;
        private System.Windows.Forms.RichTextBox richTextBoxIncomingText;
        private System.Windows.Forms.RichTextBox richTextBoxOutgoingText;
        private System.Windows.Forms.StatusStrip statusStripTop;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelConnection;
    }
}