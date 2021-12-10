namespace TextEditorAndPaint
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainTab = new System.Windows.Forms.TabControl();
            this.tabText = new System.Windows.Forms.TabPage();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.rtxtEditor = new System.Windows.Forms.RichTextBox();
            this.TabPaint = new System.Windows.Forms.TabPage();
            this.btnColor = new System.Windows.Forms.Button();
            this.mainTab.SuspendLayout();
            this.tabText.SuspendLayout();
            this.TabPaint.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTab
            // 
            this.mainTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTab.Controls.Add(this.tabText);
            this.mainTab.Controls.Add(this.TabPaint);
            this.mainTab.Location = new System.Drawing.Point(12, 12);
            this.mainTab.Name = "mainTab";
            this.mainTab.SelectedIndex = 0;
            this.mainTab.Size = new System.Drawing.Size(776, 426);
            this.mainTab.TabIndex = 0;
            // 
            // tabText
            // 
            this.tabText.Controls.Add(this.btnOpen);
            this.tabText.Controls.Add(this.btnGuardar);
            this.tabText.Controls.Add(this.rtxtEditor);
            this.tabText.Location = new System.Drawing.Point(4, 24);
            this.tabText.Name = "tabText";
            this.tabText.Padding = new System.Windows.Forms.Padding(3);
            this.tabText.Size = new System.Drawing.Size(768, 398);
            this.tabText.TabIndex = 0;
            this.tabText.Text = "Text Editor";
            this.tabText.UseVisualStyleBackColor = true;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(6, 18);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(112, 23);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Abrir Archivo";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(124, 18);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(106, 23);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // rtxtEditor
            // 
            this.rtxtEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtEditor.Location = new System.Drawing.Point(6, 47);
            this.rtxtEditor.Name = "rtxtEditor";
            this.rtxtEditor.Size = new System.Drawing.Size(756, 345);
            this.rtxtEditor.TabIndex = 0;
            this.rtxtEditor.Text = "";
            // 
            // TabPaint
            // 
            this.TabPaint.Controls.Add(this.btnColor);
            this.TabPaint.Location = new System.Drawing.Point(4, 24);
            this.TabPaint.Name = "TabPaint";
            this.TabPaint.Padding = new System.Windows.Forms.Padding(3);
            this.TabPaint.Size = new System.Drawing.Size(768, 398);
            this.TabPaint.TabIndex = 1;
            this.TabPaint.Text = "Paint";
            this.TabPaint.UseVisualStyleBackColor = true;
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(20, 20);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(120, 23);
            this.btnColor.TabIndex = 0;
            this.btnColor.Text = "Escoger Color";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainTab);
            this.Name = "Form1";
            this.Text = "Form1";
            this.mainTab.ResumeLayout(false);
            this.tabText.ResumeLayout(false);
            this.TabPaint.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTab;
        private System.Windows.Forms.TabPage tabText;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.RichTextBox rtxtEditor;
        private System.Windows.Forms.TabPage TabPaint;
        private System.Windows.Forms.Button btnColor;
    }
}
