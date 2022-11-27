/*
By InnieSharp(ix4/i#)
*/
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace ix4Rooms
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void ШРИФТToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(fontDialog1.ShowDialog() == DialogResult.OK)
			{
				richTextBox1.Font = fontDialog1.Font;
			}
		}
		void FontDialog1Apply(object sender, EventArgs e)
		{
			
		}
		void ЦВЕТФОНАToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(colorDialog1.ShowDialog() == DialogResult.OK)
			{
				richTextBox1.BackColor = colorDialog1.Color;
			}
		}
		void ЦВЕТТЕКСТАToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(colorDialog2.ShowDialog() == DialogResult.OK)
			{
				richTextBox1.ForeColor = colorDialog2.Color;
			}
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			Engine.ra = this.richTextBox1;
			Engine.Initialize();
			Thread.Sleep(1000);
			timer1.Enabled = true;
		}
		void RichTextBox1KeyPress(object sender, KeyPressEventArgs e)
		{
			
		}
		void RichTextBox1KeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.A)
				Engine.Move("left");
			if(e.KeyCode == Keys.D)
				Engine.Move("right");
			if(e.KeyCode == Keys.W)
				Engine.Move("up");
			if(e.KeyCode == Keys.S)
				Engine.Move("down");
			Engine.Draw();
		}
		void MainFormKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.A)
				Engine.Move("left");
			if(e.KeyCode == Keys.D)
				Engine.Move("right");
			if(e.KeyCode == Keys.W)
				Engine.Move("up");
			if(e.KeyCode == Keys.S)
				Engine.Move("down");
			Engine.Draw();
		}
		void Timer1Tick(object sender, EventArgs e)
		{
			richTextBox1.Text = Engine.ra.Text;
		}
		void ОБНОВИТЬToolStripMenuItemClick(object sender, EventArgs e)
		{
			Engine.room = 0;
			timer1.Enabled = false;
			richTextBox1.Text = "";
			Engine.ra = this.richTextBox1;
			Engine.Initialize();
			Thread.Sleep(1000);
			timer1.Enabled = true;
		}
	}
}
