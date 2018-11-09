using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.FormIhm
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button_getBagageByID_Click(object sender, EventArgs e)
		{
			/*try
			{
				var bagage = MyAirport.Pim.Models.Factory.Model.GetBagage(24494124);
				if(bagage == null)
					MessageBox.Show("Aucune correspondance");
				else
					MessageBox.Show(bagage.ToString());
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}*/
		}

		private void button_getBagageByIata_Click(object sender, EventArgs e)
		{
			/*try
			{
				var bagage = MyAirport.Pim.Models.Factory.Model.GetBagage("309092");
				if (bagage == null)
				{
					MessageBox.Show("Aucune correspondance");
				}
				else
				{
						MessageBox.Show(bagage.ToString());
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}*/
}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}
