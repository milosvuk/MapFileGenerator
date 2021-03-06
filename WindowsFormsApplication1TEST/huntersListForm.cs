
using System.Text;

using Testwin.Data.Persistence;
using Testwin.Business.Domain;
using Testwin.Business.Interfaces;
using System.Windows.Forms;
using System.Collections;
using System;

namespace Testwin.UI.CSWinForm
{
	public partial class huntersListForm
	{
	
		public Hashtable HashTable
		{
		    get { return _hashTable; }
		    set { _hashTable = value; }
		}
		private Hashtable _hashTable; 

		public override void ShowForm(Hashtable hashTable)
		{
			this.WindowState = FormWindowState.Maximized;
        }

		protected void OnException(object sender, System.EventArgs e)
        {
            Exception ex = (Exception)sender;
            if (ex.InnerException != null)
                MessageBox.Show(ex.InnerException.Message);
            else
                MessageBox.Show(ex.Message);
        }
 
    }
}
