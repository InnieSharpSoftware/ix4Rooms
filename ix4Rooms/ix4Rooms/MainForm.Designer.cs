/*
By InnieSharp(ix4/i#)
*/
namespace ix4Rooms
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		public System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem вИДToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem шРИФТToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem цВЕТФОНАToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem цВЕТТЕКСТАToolStripMenuItem;
		private System.Windows.Forms.FontDialog fontDialog1;
		private System.Windows.Forms.ColorDialog colorDialog1;
		private System.Windows.Forms.ColorDialog colorDialog2;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.ToolStripMenuItem оБНОВИТЬToolStripMenuItem;
		
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
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.вИДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.шРИФТToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.цВЕТФОНАToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.цВЕТТЕКСТАToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fontDialog1 = new System.Windows.Forms.FontDialog();
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.colorDialog2 = new System.Windows.Forms.ColorDialog();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.оБНОВИТЬToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// richTextBox1
			// 
			this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.richTextBox1.Location = new System.Drawing.Point(0, 24);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.ReadOnly = true;
			this.richTextBox1.Size = new System.Drawing.Size(331, 277);
			this.richTextBox1.TabIndex = 0;
			this.richTextBox1.Text = "";
			this.richTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RichTextBox1KeyPress);
			this.richTextBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.RichTextBox1KeyUp);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.вИДToolStripMenuItem,
			this.оБНОВИТЬToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(331, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// вИДToolStripMenuItem
			// 
			this.вИДToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.шРИФТToolStripMenuItem,
			this.цВЕТФОНАToolStripMenuItem,
			this.цВЕТТЕКСТАToolStripMenuItem});
			this.вИДToolStripMenuItem.Name = "вИДToolStripMenuItem";
			this.вИДToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
			this.вИДToolStripMenuItem.Text = "ВИД";
			// 
			// шРИФТToolStripMenuItem
			// 
			this.шРИФТToolStripMenuItem.Name = "шРИФТToolStripMenuItem";
			this.шРИФТToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.шРИФТToolStripMenuItem.Text = "ШРИФТ";
			this.шРИФТToolStripMenuItem.Click += new System.EventHandler(this.ШРИФТToolStripMenuItemClick);
			// 
			// цВЕТФОНАToolStripMenuItem
			// 
			this.цВЕТФОНАToolStripMenuItem.Name = "цВЕТФОНАToolStripMenuItem";
			this.цВЕТФОНАToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.цВЕТФОНАToolStripMenuItem.Text = "ЦВЕТ ФОНА";
			this.цВЕТФОНАToolStripMenuItem.Click += new System.EventHandler(this.ЦВЕТФОНАToolStripMenuItemClick);
			// 
			// цВЕТТЕКСТАToolStripMenuItem
			// 
			this.цВЕТТЕКСТАToolStripMenuItem.Name = "цВЕТТЕКСТАToolStripMenuItem";
			this.цВЕТТЕКСТАToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.цВЕТТЕКСТАToolStripMenuItem.Text = "ЦВЕТ ТЕКСТА";
			this.цВЕТТЕКСТАToolStripMenuItem.Click += new System.EventHandler(this.ЦВЕТТЕКСТАToolStripMenuItemClick);
			// 
			// fontDialog1
			// 
			this.fontDialog1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
			this.fontDialog1.Apply += new System.EventHandler(this.FontDialog1Apply);
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// оБНОВИТЬToolStripMenuItem
			// 
			this.оБНОВИТЬToolStripMenuItem.Name = "оБНОВИТЬToolStripMenuItem";
			this.оБНОВИТЬToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
			this.оБНОВИТЬToolStripMenuItem.Text = "ОБНОВИТЬ";
			this.оБНОВИТЬToolStripMenuItem.Click += new System.EventHandler(this.ОБНОВИТЬToolStripMenuItemClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(331, 301);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.menuStrip1);
			this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "ix4Rooms";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainFormKeyUp);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
