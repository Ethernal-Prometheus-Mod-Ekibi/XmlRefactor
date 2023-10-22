namespace XmlRefactor.UI
{
    partial class XmlGridView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.webXmlView = new System.Windows.Forms.WebBrowser();
            this.grdTableView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdTableView)).BeginInit();
            this.SuspendLayout();
            // 
            // webXmlView
            // 
            this.webXmlView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webXmlView.Location = new System.Drawing.Point(0, 0);
            this.webXmlView.MinimumSize = new System.Drawing.Size(20, 20);
            this.webXmlView.Name = "webXmlView";
            this.webXmlView.Size = new System.Drawing.Size(315, 310);
            this.webXmlView.TabIndex = 0;
            // 
            // grdTableView
            // 
            this.grdTableView.AllowUserToAddRows = false;
            this.grdTableView.AllowUserToDeleteRows = false;
            this.grdTableView.BackgroundColor = System.Drawing.Color.DarkGoldenrod;
            this.grdTableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdTableView.DefaultCellStyle = dataGridViewCellStyle1;
            this.grdTableView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdTableView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdTableView.GridColor = System.Drawing.Color.Black;
            this.grdTableView.Location = new System.Drawing.Point(0, 0);
            this.grdTableView.Name = "grdTableView";
            this.grdTableView.ReadOnly = true;
            this.grdTableView.Size = new System.Drawing.Size(315, 310);
            this.grdTableView.TabIndex = 1;
            // 
            // XmlGridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.Controls.Add(this.grdTableView);
            this.Controls.Add(this.webXmlView);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "XmlGridView";
            this.Size = new System.Drawing.Size(315, 310);
            ((System.ComponentModel.ISupportInitialize)(this.grdTableView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webXmlView;
        private System.Windows.Forms.DataGridView grdTableView;
    }
}
