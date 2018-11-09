using System;
using System.ServiceModel;
using System.Windows.Forms;

namespace MyAirport.Pim.Server
{
	public partial class Form1 : Form
	{
		private ServiceHost host = null;

		public Form1()
		{
			InitializeComponent();
		}

		private void host_State(object sender, EventArgs e)
		{
			this.textBox_state.Text = this.host.State.ToString();
		}


		private void button_create_Click(object sender, EventArgs e)
		{
			if (this.host != null)
			{
				this.host.Close();
				this.button_open_close.Text = "Ouvrir";
			}
			this.host = new ServiceHost(typeof(MyAirport.Pim.Service.ServicePim));

			this.host.Closed += host_State;
			this.host.Closing += host_State;
			this.host.Faulted += host_State;
			this.host.Opened += host_State;
			this.host.Opening += host_State;

			//Lance le service dès sa création, pour ne pas avoir à cliquer sur button_open_close
			this.button_open_close.PerformClick();
		}

		private void button_open_close_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.host != null)
				{
					if (this.host.State == CommunicationState.Opened)
					{
						this.host.Close();
						this.button_open_close.Text = "Ouvrir";
					}
					else if (this.host.State != CommunicationState.Closed)
					{
						this.host.Open();
						this.listBox1.Items.Clear();
						foreach (var item in host.Description.Behaviors)
						{
							if (item is System.ServiceModel.ServiceBehaviorAttribute)
							{
								this.listBox1.Items.Add(((System.ServiceModel.ServiceBehaviorAttribute)item).InstanceContextMode.ToString());
							}
						}
						foreach (var item in host.Description.Endpoints)
						{
							this.listBox1.Items.Add(item.Name);
						}
						this.button_open_close.Text = "Fermer";
					}
					else
						throw new Exception("Le service a été fermé, veuillez en recréer un.");
				}
				else
					throw new Exception("Le service n'est pas créé.");
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
