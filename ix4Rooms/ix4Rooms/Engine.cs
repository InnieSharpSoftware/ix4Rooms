/*
By InnieSharp(ix4/i#)
*/
using System;
using System.Windows.Forms;
using System.Text;

namespace ix4Rooms
{
	/// <summary>
	/// Description of Engine.
	/// </summary>
	public class Engine
	{
		// кординнаты
		public static int xa;
		public static int ya;
		//количество комнат (количество комнат - КОЛВО + 1 то есть чтобы было 15 комнат надо 14 сделать 
		public static int count;
		public static int room;
		//карта
		public static string[] map;
		public static RichTextBox ra;
		public static string[] msgs = new string[]
		{
			"Hi?",
			"110100001001011111010000100101001101000010010101110100001010000111010000101011000010000011010000100111111101000010100011110100001010000111010000101000101101000010011110001011000010000011010000100111001101000010011101110100001001010100100000110100001001110111010000100101011101000010100111110100001001010111010000100100111101000010011110001000001101000010010100110100001001010111010000100110111101000010010000001011100010111000101110",
			"<<<#>>>",
			"(T-T)",
			"\\\\|//",
			"...",
			"ix4l so gut",
			"i",
			"d",
			"k"
		};
		
		public Engine()
		{
			
		}
		
		public static void Initialize()
		{
			Random r = new Random();
			xa = 3; ya = 3; count = r.Next(5, 101);
			Generate();
			Draw();
		}
		
		public static void Generate()
		{
			Random r = new Random();
			int ja = r.Next(0, 11);
			if (ja == 1) {
				map = new string[]
				{
					"WWWOWWW",
					"W.....W",
					"W.....W",
					"O..P..O",
					"W.....W",
					"W.....W",
					"WWWOWWW",
				};
			}
			if (ja == 2) {
				map = new string[]
				{
					"WWWWWWW",
					"W.....W",
					"W.....W",
					"W..P..W",
					"W.....W",
					"W.....W",
					"WWWOWWW",
				};
			}
			if (ja == 3) {
				map = new string[]
				{
					"WWWOWWW",
					"W.....W",
					"W.....W",
					"W..P..O",
					"W.....W",
					"W.....W",
					"WWWOWWW",
				};
			}
			if (ja == 4) {
				map = new string[]
				{
					"WWWWWWW",
					"W.....W",
					"W.....W",
					"O..P..O",
					"W.....W",
					"W.....W",
					"WWWOWWW",
				};
			}
			if (ja == 5) {
				map = new string[]
				{
					"WWWOWWW",
					"W.....W",
					"W.....W",
					"W..P..W",
					"W.....W",
					"W.....W",
					"WWW.WWW",
				};
			}
			if (ja == 6) {
				map = new string[]
				{
					".......",
					".......",
					".......",
					"...P...",
					".......",
					".......",
					"...O...",
				};
			}
			if (ja == 7) {
				map = new string[]
				{
					"WWWWWWW",
					"W.....W",
					"W.....W",
					"O..P..W",
					"W.....W",
					"W.....W",
					"WWWWWWW",
				};
			}
			if (ja == 8) {
				map = new string[]
				{
					"WWWWWWW",
					"W.....W",
					"W.....W",
					"O..P..O",
					"W.....W",
					"W.....W",
					"WWWWWWW",
				};
			}
			if (ja == 9) {
				map = new string[]
				{
					"OOOOOOO",
					"OOOOOOO",
					"OOOOOOO",
					"OOOPOOO",
					"OOOOOOO",
					"OOOOOOO",
					"OOOOOOO",
				};
			}
			if (ja == 10) {
				map = new string[]
				{
					"...............................O",
					".......",
					".......",
					"...P...",
					".......",
					".......",
					".......",
				};
			}
		}
		
		public static void Move(string direct)
		{
//			Random ca = new Random();
//			int ch = ca.Next(0, 101);
//			if(ch > 98)
//			{
//				Random r = new Random();
//				MessageBox.Show(msgs[r.Next(0, msgs.Length - 1)]);
//			}
			try
			{
				if(direct == "left")
				{
					StringBuilder sb = new StringBuilder(map[ya]);
					bool a = false;
					if(xa > 0)
					{
						if(sb[xa - 1] == 'O' || sb[xa - 1] == 'W')
						{
							if(sb[xa - 1] == 'O')
							{
								if(room != count)
									room++;
								else
								{
									MessageBox.Show("Это конец!", "ix4Rooms", MessageBoxButtons.OK, MessageBoxIcon.Question);
									Application.Exit();
								}
								xa = 3; ya = 3;
								Generate();
								Draw();
								a = true;
							}
						}
						else
						{
							sb[xa] = '.';
							sb[xa - 1] = 'P';
							xa -= 1;
						}
					}
					if(!a)
						map[ya] = sb.ToString();
				}
				if(direct == "right")
				{
					StringBuilder sb = new StringBuilder(map[ya]);
					bool a = false;
					if(xa < sb.Length)
					{
						if(sb[xa + 1] == 'O' || sb[xa + 1] == 'W')
						{
							if(sb[xa + 1] == 'O')
							{
								if(room != count)
									room++;
								else
								{
									MessageBox.Show("Это конец!", "ix4Rooms", MessageBoxButtons.OK, MessageBoxIcon.Question);
									Application.Exit();
								}
								xa = 3; ya = 3;
								Generate();
								Draw();
								a = true;
							}
						}
						else
						{
							sb[xa] = '.';
							sb[xa + 1] = 'P';
							xa += 1;
						}
					}
					if(!a)
						map[ya] = sb.ToString();
				}
				if(direct == "down")
				{
					if(ya < map.Length)
					{
						StringBuilder sb = new StringBuilder(map[ya]);
						StringBuilder sb2 = new StringBuilder(map[ya + 1]);
						bool a = false;
						if(sb2[xa] == 'O' || sb2[xa] == 'W')
						{
							if(sb2[xa] == 'O')
							{
								if(room != count)
									room++;
								else
								{
									MessageBox.Show("Это конец!", "ix4Rooms", MessageBoxButtons.OK, MessageBoxIcon.Question);
									Application.Exit();
								}
								xa = 3; ya = 3;
								Generate();
								Draw();
								
							}
							a = true;
						}
						else
						{
							sb[xa] = '.';
							sb2[xa] = 'P';
						}
						if(!a)
						{
							map[ya] = sb.ToString();
							map[ya + 1] = sb2.ToString();
							ya += 1;
						}
					}
				}
				if(direct == "up")
				{
					if(ya > 0)
					{
						StringBuilder sb = new StringBuilder(map[ya]);
						StringBuilder sb2 = new StringBuilder(map[ya - 1]);
						bool a = false;
						if(sb2[xa] == 'O' || sb2[xa] == 'W')
						{
							if(sb2[xa] == 'O')
							{
								if(room != count)
									room++;
								else
								{
									MessageBox.Show("Это конец!", "ix4Rooms", MessageBoxButtons.OK, MessageBoxIcon.Question);
									Application.Exit();
								}
								xa = 3; ya = 3;
								Generate();
								Draw();
							}
							a = true;
						}
						else
						{
							sb[xa] = '.';
							sb2[xa] = 'P';
						}
						if(!a)
						{
							map[ya] = sb.ToString();
							map[ya - 1] = sb2.ToString();
							ya -= 1;
						}
					}
				}
			}
			catch
			{
				
			}
		}
		
		public static void Draw()
		{
			ra.Text = "";
			foreach(string l in map)
			{
				ra.Text += l + Environment.NewLine;
			}
		}
	}
}
