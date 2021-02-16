namespace DiskSchedulingAlgorithm
{
    partial class MainForm
    {
        
        private System.ComponentModel.IContainer components = null;

       
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
            this.cbSelectAlg = new System.Windows.Forms.ComboBox();
            this.tbAddReq = new System.Windows.Forms.TextBox();
            this.rtbReadReqs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtAdd = new System.Windows.Forms.Button();
            this.cbExampleSelect = new System.Windows.Forms.ComboBox();
            this.btExampleSelect = new System.Windows.Forms.Button();
            this.btStartNext = new System.Windows.Forms.Button();
            this.btReset = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbSelectAlg
            // 
            this.cbSelectAlg.FormattingEnabled = true;
            this.cbSelectAlg.Location = new System.Drawing.Point(785, 43);
            this.cbSelectAlg.Name = "cbSelectAlg";
            this.cbSelectAlg.Size = new System.Drawing.Size(177, 21);
            this.cbSelectAlg.TabIndex = 0;
            // 
            // tbAddReq
            // 
            this.tbAddReq.Location = new System.Drawing.Point(786, 87);
            this.tbAddReq.Name = "tbAddReq";
            this.tbAddReq.Size = new System.Drawing.Size(177, 20);
            this.tbAddReq.TabIndex = 1;
            // 
            // rtbReadReqs
            // 
            this.rtbReadReqs.Location = new System.Drawing.Point(790, 155);
            this.rtbReadReqs.Multiline = true;
            this.rtbReadReqs.Name = "rtbReadReqs";
            this.rtbReadReqs.Size = new System.Drawing.Size(177, 59);
            this.rtbReadReqs.TabIndex = 2;
            this.rtbReadReqs.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(833, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choose Algorithm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(842, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Input Number";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // BtAdd
            // 
            this.BtAdd.Location = new System.Drawing.Point(848, 113);
            this.BtAdd.Name = "BtAdd";
            this.BtAdd.Size = new System.Drawing.Size(78, 23);
            this.BtAdd.TabIndex = 5;
            this.BtAdd.Text = "ADD ";
            this.BtAdd.UseVisualStyleBackColor = true;
            this.BtAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // cbExampleSelect
            // 
            this.cbExampleSelect.FormattingEnabled = true;
            this.cbExampleSelect.Items.AddRange(new object[] {
            "Random",
            "Starvation"});
            this.cbExampleSelect.Location = new System.Drawing.Point(838, 330);
            this.cbExampleSelect.Name = "cbExampleSelect";
            this.cbExampleSelect.Size = new System.Drawing.Size(105, 21);
            this.cbExampleSelect.TabIndex = 7;
            // 
            // btExampleSelect
            // 
            this.btExampleSelect.Location = new System.Drawing.Point(859, 357);
            this.btExampleSelect.Name = "btExampleSelect";
            this.btExampleSelect.Size = new System.Drawing.Size(65, 23);
            this.btExampleSelect.TabIndex = 8;
            this.btExampleSelect.Text = "SELECT";
            this.btExampleSelect.UseVisualStyleBackColor = true;
            this.btExampleSelect.Click += new System.EventHandler(this.btExampleSelect_Click);
            // 
            // btStartNext
            // 
            this.btStartNext.Location = new System.Drawing.Point(846, 220);
            this.btStartNext.Name = "btStartNext";
            this.btStartNext.Size = new System.Drawing.Size(75, 23);
            this.btStartNext.TabIndex = 9;
            this.btStartNext.Text = "START";
            this.btStartNext.UseVisualStyleBackColor = true;
            this.btStartNext.Click += new System.EventHandler(this.btStartNext_Click);
            // 
            // btReset
            // 
            this.btReset.Location = new System.Drawing.Point(849, 249);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(75, 23);
            this.btReset.TabIndex = 10;
            this.btReset.Text = "RESET";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(858, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Randomized";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.SEAN_WATERMARK_NEW;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(987, 653);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.btStartNext);
            this.Controls.Add(this.btExampleSelect);
            this.Controls.Add(this.cbExampleSelect);
            this.Controls.Add(this.BtAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbReadReqs);
            this.Controls.Add(this.tbAddReq);
            this.Controls.Add(this.cbSelectAlg);
            this.DoubleBuffered = true;
            this.Name = "MainForm";
            this.Text = "Disk Scheduling algorithm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSelectAlg;
        private System.Windows.Forms.TextBox tbAddReq;
        private System.Windows.Forms.TextBox rtbReadReqs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtAdd;
        private System.Windows.Forms.ComboBox cbExampleSelect;
        private System.Windows.Forms.Button btExampleSelect;
        private System.Windows.Forms.Button btStartNext;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Label label4;
    }
}

