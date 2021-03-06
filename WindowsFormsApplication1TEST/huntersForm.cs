
using System.Text;

using Testwin.Data.Persistence;
using Testwin.Business.Domain;
using Testwin.Business.Interfaces;
using System.Windows.Forms;
using System.Collections;
using System;

namespace Testwin.UI.CSWinForm
{
	public partial class huntersForm
	{
		
		public huntersForm()
		{
			InitializeComponent();
		}
		
		public Hashtable HashTable
		{
		    get { return _hashTable; }
		    set { _hashTable = value; }
		}
		private Hashtable _hashTable; 
			
		
		protected void OnException(object sender, System.EventArgs e)
        {
            Exception ex = (Exception)sender;
            if (ex.InnerException != null)
                this.lblMssg.Text = ex.InnerException.Message;
            else
                this.lblMssg.Text = ex.Message;
        }

		protected void PostExecution(object sender, System.EventArgs e)
        {
             string btnText = "";
			if (sender is Button)
			{
				Button btnExecuted = (Button)sender;
				btnText = btnExecuted.Text;
			}
			else
				return;

			switch (btnText)
			{
				case "Load": this.lblMssg.Text = "Load command executed successfully."; 
					
				break;
				case "Save": this.lblMssg.Text = "Save command executed successfully."; break;
				case "Delete": this.lblMssg.Text = "Delete command executed successfully."; break;
				default: this.lblMssg.Text = ""; break;
			}

        }
		
    }

}
