namespace wryt
{
    partial class DocPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Document = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Document
            // 
            this.Document.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Document.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Document.Location = new System.Drawing.Point(3, 3);
            this.Document.Name = "Document";
            this.Document.ShortcutsEnabled = false;
            this.Document.Size = new System.Drawing.Size(224, 221);
            this.Document.TabIndex = 0;
            this.Document.Text = "";
            // 
            // DocPage
            // 
            this.Controls.Add(this.Document);
            this.Name = "DocPage";
            this.Size = new System.Drawing.Size(230, 227);
            this.Enter += new System.EventHandler(this.DocPage_Enter);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox Document;
    }
}
