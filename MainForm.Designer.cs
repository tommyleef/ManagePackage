/*
 * Created by SharpDevelop.
 * User: Tommy
 * Date: 7/20/2017
 * Time: 3:15 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace manageObj
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
			this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
			this.dgvpkgname = new System.Windows.Forms.DataGridView();
			this.lbiws = new System.Windows.Forms.ListBox();
			this.btlist = new System.Windows.Forms.Button();
			this.btactivate = new System.Windows.Forms.Button();
			this.btdeacti = new System.Windows.Forms.Button();
			this.btreset = new System.Windows.Forms.Button();
			this.lbsite = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.btdelete = new System.Windows.Forms.Button();
			this.btimport = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rbcuss = new System.Windows.Forms.RadioButton();
			this.rbcute = new System.Windows.Forms.RadioButton();
			this.tbwks = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.tbpackage = new System.Windows.Forms.TextBox();
			this.btAutoStatus = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.statusStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvpkgname)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolStripStatusLabel1,
									this.toolStripProgressBar1,
									this.toolStripStatusLabel2,
									this.toolStripStatusLabel3});
			this.statusStrip1.Location = new System.Drawing.Point(0, 564);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(1096, 22);
			this.statusStrip1.TabIndex = 13;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.MergeIndex = 0;
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
			// 
			// toolStripProgressBar1
			// 
			this.toolStripProgressBar1.MergeIndex = 1;
			this.toolStripProgressBar1.Name = "toolStripProgressBar1";
			this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
			// 
			// toolStripStatusLabel2
			// 
			this.toolStripStatusLabel2.MergeIndex = 2;
			this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
			this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
			// 
			// toolStripStatusLabel3
			// 
			this.toolStripStatusLabel3.MergeIndex = 3;
			this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
			this.toolStripStatusLabel3.Size = new System.Drawing.Size(0, 17);
			// 
			// dgvpkgname
			// 
			this.dgvpkgname.AllowUserToAddRows = false;
			this.dgvpkgname.AllowUserToDeleteRows = false;
			this.dgvpkgname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dgvpkgname.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvpkgname.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvpkgname.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvpkgname.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgvpkgname.Location = new System.Drawing.Point(275, 12);
			this.dgvpkgname.MultiSelect = false;
			this.dgvpkgname.Name = "dgvpkgname";
			this.dgvpkgname.RowHeadersVisible = false;
			this.dgvpkgname.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvpkgname.Size = new System.Drawing.Size(809, 545);
			this.dgvpkgname.TabIndex = 14;
			// 
			// lbiws
			// 
			this.lbiws.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left)));
			this.lbiws.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbiws.FormattingEnabled = true;
			this.lbiws.ItemHeight = 20;
			this.lbiws.Location = new System.Drawing.Point(13, 73);
			this.lbiws.Name = "lbiws";
			this.lbiws.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.lbiws.Size = new System.Drawing.Size(130, 484);
			this.lbiws.TabIndex = 15;
			this.lbiws.SelectedIndexChanged += new System.EventHandler(this.LbiwsSelectedIndexChanged);
			// 
			// btlist
			// 
			this.btlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btlist.Location = new System.Drawing.Point(153, 55);
			this.btlist.Name = "btlist";
			this.btlist.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btlist.Size = new System.Drawing.Size(116, 26);
			this.btlist.TabIndex = 16;
			this.btlist.Text = "List";
			this.btlist.UseVisualStyleBackColor = true;
			this.btlist.Click += new System.EventHandler(this.BtlistClick);
			// 
			// btactivate
			// 
			this.btactivate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btactivate.Location = new System.Drawing.Point(153, 95);
			this.btactivate.Name = "btactivate";
			this.btactivate.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btactivate.Size = new System.Drawing.Size(116, 26);
			this.btactivate.TabIndex = 17;
			this.btactivate.Text = "Activate";
			this.btactivate.UseVisualStyleBackColor = true;
			this.btactivate.Click += new System.EventHandler(this.BtactivateClick);
			// 
			// btdeacti
			// 
			this.btdeacti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btdeacti.Location = new System.Drawing.Point(153, 135);
			this.btdeacti.Name = "btdeacti";
			this.btdeacti.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btdeacti.Size = new System.Drawing.Size(116, 26);
			this.btdeacti.TabIndex = 18;
			this.btdeacti.Text = "DeActivate";
			this.btdeacti.UseVisualStyleBackColor = true;
			this.btdeacti.Click += new System.EventHandler(this.BtdeactiClick);
			// 
			// btreset
			// 
			this.btreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btreset.Location = new System.Drawing.Point(153, 215);
			this.btreset.Name = "btreset";
			this.btreset.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btreset.Size = new System.Drawing.Size(116, 26);
			this.btreset.TabIndex = 19;
			this.btreset.Text = "Reset";
			this.btreset.UseVisualStyleBackColor = true;
			this.btreset.Click += new System.EventHandler(this.BtresetClick);
			// 
			// lbsite
			// 
			this.lbsite.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbsite.Location = new System.Drawing.Point(153, 13);
			this.lbsite.Name = "lbsite";
			this.lbsite.Size = new System.Drawing.Size(95, 26);
			this.lbsite.TabIndex = 20;
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// btdelete
			// 
			this.btdelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btdelete.Location = new System.Drawing.Point(153, 255);
			this.btdelete.Name = "btdelete";
			this.btdelete.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btdelete.Size = new System.Drawing.Size(116, 26);
			this.btdelete.TabIndex = 21;
			this.btdelete.Text = "Delete";
			this.btdelete.UseVisualStyleBackColor = true;
			this.btdelete.Click += new System.EventHandler(this.BtdeleteClick);
			// 
			// btimport
			// 
			this.btimport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btimport.Location = new System.Drawing.Point(153, 295);
			this.btimport.Name = "btimport";
			this.btimport.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btimport.Size = new System.Drawing.Size(116, 26);
			this.btimport.TabIndex = 22;
			this.btimport.Text = "Import";
			this.btimport.UseVisualStyleBackColor = true;
			this.btimport.Click += new System.EventHandler(this.BtimportClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rbcuss);
			this.groupBox1.Controls.Add(this.rbcute);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(153, 385);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(116, 84);
			this.groupBox1.TabIndex = 23;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Group";
			// 
			// rbcuss
			// 
			this.rbcuss.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbcuss.Location = new System.Drawing.Point(7, 54);
			this.rbcuss.Name = "rbcuss";
			this.rbcuss.Size = new System.Drawing.Size(74, 24);
			this.rbcuss.TabIndex = 1;
			this.rbcuss.Text = "CUSS";
			this.rbcuss.UseVisualStyleBackColor = true;
			// 
			// rbcute
			// 
			this.rbcute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbcute.Location = new System.Drawing.Point(7, 24);
			this.rbcute.Name = "rbcute";
			this.rbcute.Size = new System.Drawing.Size(74, 24);
			this.rbcute.TabIndex = 0;
			this.rbcute.Text = "CUTE";
			this.rbcute.UseVisualStyleBackColor = true;
			// 
			// tbwks
			// 
			this.tbwks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbwks.Location = new System.Drawing.Point(7, 25);
			this.tbwks.Name = "tbwks";
			this.tbwks.Size = new System.Drawing.Size(117, 26);
			this.tbwks.TabIndex = 24;
			this.tbwks.TextChanged += new System.EventHandler(this.tbwksTextChanged);
			this.tbwks.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbwksKeyDown);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.tbwks);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(13, 8);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(130, 59);
			this.groupBox2.TabIndex = 25;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "IWS Filter";
			// 
			// tbpackage
			// 
			this.tbpackage.Enabled = false;
			this.tbpackage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbpackage.Location = new System.Drawing.Point(8, 24);
			this.tbpackage.Name = "tbpackage";
			this.tbpackage.Size = new System.Drawing.Size(102, 26);
			this.tbpackage.TabIndex = 25;
			this.tbpackage.TextChanged += new System.EventHandler(this.tbpackageTextChanged);
			this.tbpackage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbpackageKeyDown);
			// 
			// btAutoStatus
			// 
			this.btAutoStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btAutoStatus.Location = new System.Drawing.Point(153, 175);
			this.btAutoStatus.Name = "btAutoStatus";
			this.btAutoStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btAutoStatus.Size = new System.Drawing.Size(116, 26);
			this.btAutoStatus.TabIndex = 26;
			this.btAutoStatus.Text = "AutoActivate";
			this.btAutoStatus.UseVisualStyleBackColor = true;
			this.btAutoStatus.Click += new System.EventHandler(this.BtAutoStatusClick);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.tbpackage);
			this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox3.Location = new System.Drawing.Point(153, 328);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(116, 57);
			this.groupBox3.TabIndex = 27;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Layer Filter";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1096, 586);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.btAutoStatus);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btimport);
			this.Controls.Add(this.btdelete);
			this.Controls.Add(this.lbsite);
			this.Controls.Add(this.btreset);
			this.Controls.Add(this.btdeacti);
			this.Controls.Add(this.btactivate);
			this.Controls.Add(this.btlist);
			this.Controls.Add(this.lbiws);
			this.Controls.Add(this.dgvpkgname);
			this.Controls.Add(this.statusStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(1112, 625);
			this.Name = "MainForm";
			this.Text = "Manage Package V 1.3";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvpkgname)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
		private System.Windows.Forms.Button btAutoStatus;
		private System.Windows.Forms.TextBox tbpackage;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox tbwks;
		private System.Windows.Forms.RadioButton rbcute;
		private System.Windows.Forms.RadioButton rbcuss;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btimport;
		private System.Windows.Forms.Button btdelete;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
		private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label lbsite;
		private System.Windows.Forms.Button btreset;
		private System.Windows.Forms.Button btdeacti;
		private System.Windows.Forms.Button btactivate;
		private System.Windows.Forms.Button btlist;
		private System.Windows.Forms.ListBox lbiws;
		private System.Windows.Forms.DataGridView dgvpkgname;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.StatusStrip statusStrip1;
	}
}
