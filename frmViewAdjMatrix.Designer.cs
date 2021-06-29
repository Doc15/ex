
namespace Dijkstra
{
    partial class frmViewAdjMatrix
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
            this.lvwAdjMatrix = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lvwAdjMatrix
            // 
            this.lvwAdjMatrix.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvwAdjMatrix.HideSelection = false;
            this.lvwAdjMatrix.Location = new System.Drawing.Point(13, 13);
            this.lvwAdjMatrix.Margin = new System.Windows.Forms.Padding(4);
            this.lvwAdjMatrix.Name = "lvwAdjMatrix";
            this.lvwAdjMatrix.Size = new System.Drawing.Size(229, 34);
            this.lvwAdjMatrix.TabIndex = 1;
            this.lvwAdjMatrix.UseCompatibleStateImageBehavior = false;
            this.lvwAdjMatrix.View = System.Windows.Forms.View.Details;
            // 
            // frmViewAdjMatrix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 59);
            this.Controls.Add(this.lvwAdjMatrix);
            this.Name = "frmViewAdjMatrix";
            this.Text = "Матрица";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvwAdjMatrix;
    }
}