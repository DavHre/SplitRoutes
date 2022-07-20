
namespace SplitRoutes
{
    partial class frm_Main
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
            this.btn_Split = new System.Windows.Forms.Button();
            this.WalksCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Select = new System.Windows.Forms.Button();
            this.btn_Deselect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Split
            // 
            this.btn_Split.Location = new System.Drawing.Point(17, 182);
            this.btn_Split.Name = "btn_Split";
            this.btn_Split.Size = new System.Drawing.Size(318, 57);
            this.btn_Split.TabIndex = 0;
            this.btn_Split.Text = "Split Routes";
            this.btn_Split.UseVisualStyleBackColor = true;
            this.btn_Split.Click += new System.EventHandler(this.btn_Split_Click);
            // 
            // WalksCheckedListBox
            // 
            this.WalksCheckedListBox.FormattingEnabled = true;
            this.WalksCheckedListBox.Location = new System.Drawing.Point(864, 57);
            this.WalksCheckedListBox.Name = "WalksCheckedListBox";
            this.WalksCheckedListBox.Size = new System.Drawing.Size(285, 368);
            this.WalksCheckedListBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 2;
            // 
            // btn_Select
            // 
            this.btn_Select.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Select.Location = new System.Drawing.Point(865, 16);
            this.btn_Select.Name = "btn_Select";
            this.btn_Select.Size = new System.Drawing.Size(144, 41);
            this.btn_Select.TabIndex = 3;
            this.btn_Select.Text = "Select All";
            this.btn_Select.UseVisualStyleBackColor = true;
            this.btn_Select.Click += new System.EventHandler(this.btn_Select_Click);
            // 
            // btn_Deselect
            // 
            this.btn_Deselect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Deselect.Location = new System.Drawing.Point(1008, 15);
            this.btn_Deselect.Name = "btn_Deselect";
            this.btn_Deselect.Size = new System.Drawing.Size(141, 41);
            this.btn_Deselect.TabIndex = 4;
            this.btn_Deselect.Text = "Deselect All";
            this.btn_Deselect.UseVisualStyleBackColor = true;
            this.btn_Deselect.Click += new System.EventHandler(this.btn_Deselect_Click);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 450);
            this.Controls.Add(this.btn_Deselect);
            this.Controls.Add(this.btn_Select);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WalksCheckedListBox);
            this.Controls.Add(this.btn_Split);
            this.Name = "frm_Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frm_Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Split;
        private System.Windows.Forms.CheckedListBox WalksCheckedListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Select;
        private System.Windows.Forms.Button btn_Deselect;
    }
}

