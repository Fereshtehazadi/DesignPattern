namespace DesignPattern
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
            this.lblDisplayText = new System.Windows.Forms.Label();
            this.btAdd = new System.Windows.Forms.Button();
            this.btReplace = new System.Windows.Forms.Button();
            this.btRemove = new System.Windows.Forms.Button();
            this.tbReplaceTo = new System.Windows.Forms.TextBox();
            this.tbReplaceFrom = new System.Windows.Forms.TextBox();
            this.tbAddText = new System.Windows.Forms.TextBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblRemoveFrom = new System.Windows.Forms.Label();
            this.lblRemoveTo = new System.Windows.Forms.Label();
            this.nAddPosition = new System.Windows.Forms.NumericUpDown();
            this.nRemoveFrom = new System.Windows.Forms.NumericUpDown();
            this.nRemoveTo = new System.Windows.Forms.NumericUpDown();
            this.btUndo = new System.Windows.Forms.Button();
            this.btRedo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nAddPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nRemoveFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nRemoveTo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDisplayText
            // 
            this.lblDisplayText.AutoSize = true;
            this.lblDisplayText.Location = new System.Drawing.Point(326, 72);
            this.lblDisplayText.Name = "lblDisplayText";
            this.lblDisplayText.Size = new System.Drawing.Size(35, 17);
            this.lblDisplayText.TabIndex = 0;
            this.lblDisplayText.Text = "Text";
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(99, 285);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 1;
            this.btAdd.Text = "Lägg till";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btReplace
            // 
            this.btReplace.Location = new System.Drawing.Point(302, 285);
            this.btReplace.Name = "btReplace";
            this.btReplace.Size = new System.Drawing.Size(75, 23);
            this.btReplace.TabIndex = 2;
            this.btReplace.Text = "Ersätt";
            this.btReplace.UseVisualStyleBackColor = true;
            this.btReplace.Click += new System.EventHandler(this.btReplace_Click);
            // 
            // btRemove
            // 
            this.btRemove.Location = new System.Drawing.Point(506, 285);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(75, 23);
            this.btRemove.TabIndex = 3;
            this.btRemove.Text = "Ta bort";
            this.btRemove.UseVisualStyleBackColor = true;
            this.btRemove.Click += new System.EventHandler(this.btRemove_Click);
            // 
            // tbReplaceTo
            // 
            this.tbReplaceTo.Location = new System.Drawing.Point(286, 218);
            this.tbReplaceTo.Name = "tbReplaceTo";
            this.tbReplaceTo.Size = new System.Drawing.Size(100, 22);
            this.tbReplaceTo.TabIndex = 5;
            // 
            // tbReplaceFrom
            // 
            this.tbReplaceFrom.Location = new System.Drawing.Point(286, 161);
            this.tbReplaceFrom.Name = "tbReplaceFrom";
            this.tbReplaceFrom.Size = new System.Drawing.Size(100, 22);
            this.tbReplaceFrom.TabIndex = 6;
            // 
            // tbAddText
            // 
            this.tbAddText.Location = new System.Drawing.Point(87, 218);
            this.tbAddText.Name = "tbAddText";
            this.tbAddText.Size = new System.Drawing.Size(100, 22);
            this.tbAddText.TabIndex = 7;
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(23, 164);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(58, 17);
            this.lblPosition.TabIndex = 10;
            this.lblPosition.Text = "Position";
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(35, 223);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(35, 17);
            this.lblText.TabIndex = 11;
            this.lblText.Text = "Text";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(234, 165);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(37, 17);
            this.lblFrom.TabIndex = 12;
            this.lblFrom.Text = "Från";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(234, 221);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(26, 17);
            this.lblTo.TabIndex = 13;
            this.lblTo.Text = "Till";
            // 
            // lblRemoveFrom
            // 
            this.lblRemoveFrom.AutoSize = true;
            this.lblRemoveFrom.Location = new System.Drawing.Point(439, 161);
            this.lblRemoveFrom.Name = "lblRemoveFrom";
            this.lblRemoveFrom.Size = new System.Drawing.Size(37, 17);
            this.lblRemoveFrom.TabIndex = 14;
            this.lblRemoveFrom.Text = "Från";
            // 
            // lblRemoveTo
            // 
            this.lblRemoveTo.AutoSize = true;
            this.lblRemoveTo.Location = new System.Drawing.Point(439, 223);
            this.lblRemoveTo.Name = "lblRemoveTo";
            this.lblRemoveTo.Size = new System.Drawing.Size(26, 17);
            this.lblRemoveTo.TabIndex = 15;
            this.lblRemoveTo.Text = "Till";
            // 
            // nAddPosition
            // 
            this.nAddPosition.Location = new System.Drawing.Point(87, 163);
            this.nAddPosition.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nAddPosition.Name = "nAddPosition";
            this.nAddPosition.Size = new System.Drawing.Size(120, 22);
            this.nAddPosition.TabIndex = 16;
            // 
            // nRemoveFrom
            // 
            this.nRemoveFrom.Location = new System.Drawing.Point(491, 165);
            this.nRemoveFrom.Name = "nRemoveFrom";
            this.nRemoveFrom.Size = new System.Drawing.Size(120, 22);
            this.nRemoveFrom.TabIndex = 17;
            // 
            // nRemoveTo
            // 
            this.nRemoveTo.Location = new System.Drawing.Point(491, 223);
            this.nRemoveTo.Name = "nRemoveTo";
            this.nRemoveTo.Size = new System.Drawing.Size(120, 22);
            this.nRemoveTo.TabIndex = 18;
            // 
            // btUndo
            // 
            this.btUndo.Location = new System.Drawing.Point(669, 165);
            this.btUndo.Name = "btUndo";
            this.btUndo.Size = new System.Drawing.Size(75, 23);
            this.btUndo.TabIndex = 19;
            this.btUndo.Text = "Undo";
            this.btUndo.UseVisualStyleBackColor = true;
            this.btUndo.Click += new System.EventHandler(this.btUndo_Click);
            // 
            // btRedo
            // 
            this.btRedo.Location = new System.Drawing.Point(669, 223);
            this.btRedo.Name = "btRedo";
            this.btRedo.Size = new System.Drawing.Size(75, 23);
            this.btRedo.TabIndex = 20;
            this.btRedo.Text = "Redo";
            this.btRedo.UseVisualStyleBackColor = true;
            this.btRedo.Click += new System.EventHandler(this.btRedo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btRedo);
            this.Controls.Add(this.btUndo);
            this.Controls.Add(this.nRemoveTo);
            this.Controls.Add(this.nRemoveFrom);
            this.Controls.Add(this.nAddPosition);
            this.Controls.Add(this.lblRemoveTo);
            this.Controls.Add(this.lblRemoveFrom);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.tbAddText);
            this.Controls.Add(this.tbReplaceFrom);
            this.Controls.Add(this.tbReplaceTo);
            this.Controls.Add(this.btRemove);
            this.Controls.Add(this.btReplace);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.lblDisplayText);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nAddPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nRemoveFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nRemoveTo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDisplayText;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btReplace;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.TextBox tbReplaceTo;
        private System.Windows.Forms.TextBox tbReplaceFrom;
        private System.Windows.Forms.TextBox tbAddText;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblRemoveFrom;
        private System.Windows.Forms.Label lblRemoveTo;
        private System.Windows.Forms.NumericUpDown nAddPosition;
        private System.Windows.Forms.NumericUpDown nRemoveFrom;
        private System.Windows.Forms.NumericUpDown nRemoveTo;
        private System.Windows.Forms.Button btUndo;
        private System.Windows.Forms.Button btRedo;
    }
}

