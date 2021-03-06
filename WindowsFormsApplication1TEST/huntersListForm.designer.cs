
using System.Windows.Forms;
using System;

namespace Testwin.UI.CSWinForm
{
	public partial class huntersListForm : BaseForm
	{	

		public huntersListForm()
		{	
			//this. call is required by the Windows Form Designer.
			InitializeComponent();
			//Add any initialization after the InitializeComponent() call
		}
 
		//Form overrides dispose to clean up the component list.
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components = null;
        //NOTE: The following procedure is required by the Windows Form Designer
        //It can be modified using the Windows Form Designer.  
        //Do not modify it using the code editor.
		private System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel FlowLayoutPanel1;
		private TierDeveloper.Windows.Forms.ListFormManager huntersListFormMgr;
		private System.Windows.Forms.DataGridView grhuntersResult;
		private System.Windows.Forms.DataGridViewTextBoxColumn grdvColidRecHunter;
		private System.Windows.Forms.DataGridViewTextBoxColumn grdvColIdCardNumber;
		private System.Windows.Forms.DataGridViewTextBoxColumn grdvColSurname;
		private System.Windows.Forms.DataGridViewTextBoxColumn grdvColName;
		private System.Windows.Forms.DataGridViewTextBoxColumn grdvColAddress1;
		private System.Windows.Forms.DataGridViewTextBoxColumn grdvColAddress2;
		private System.Windows.Forms.DataGridViewTextBoxColumn grdvColLocality;
		private System.Windows.Forms.DataGridViewTextBoxColumn grdvColMaltaOrGozo;
		private System.Windows.Forms.DataGridViewTextBoxColumn grdvColLicencedMobileNumber;
		private System.Windows.Forms.DataGridViewTextBoxColumn grdvColHomePhoneNumber;
		private System.Windows.Forms.DataGridViewTextBoxColumn grdvColDesc1;
		private System.Windows.Forms.DataGridViewTextBoxColumn grdvColDesc2;
		private System.Windows.Forms.DataGridViewTextBoxColumn grdvColLicenceActive;
		private System.Windows.Forms.DataGridViewTextBoxColumn grdvColActive;
		private System.Windows.Forms.Label lblTitleBar;
		//private string errMsg = "";
		
		private System.Windows.Forms.LinkLabel hlEdit;
		private System.Windows.Forms.LinkLabel hlNew;
		//private System.Windows.Forms.LinkLabel hlNext;
		//private System.Windows.Forms.LinkLabel hlPrevious;	
		

        private void InitializeComponent()
		{
            System.Configuration.AppSettingsReader configurationAppSettings = new System.Configuration.AppSettingsReader();	   
			//
            //lblTitleBar
            //
			this.lblTitleBar = new System.Windows.Forms.Label();
			this.lblTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
			//this.lblTitleBar.BackColor = this.titleBGColor;
			this.lblTitleBar.BackColor =System.Drawing.Color.FromArgb(((byte)(12)), ((byte)(22)), ((byte)(118)));
            this.lblTitleBar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTitleBar.Font = new System.Drawing.Font("Tahoma", 16.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			//this.lblTitleBar.ForeColor =this.titleFGColor;
			this.lblTitleBar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTitleBar.Location = new System.Drawing.Point(0, 0);
            this.lblTitleBar.Name = "lblTitleBar";
            this.lblTitleBar.Size = new System.Drawing.Size(864, 32);
            this.lblTitleBar.TabIndex = 218;
            this.lblTitleBar.Text = "hunters List Form";
            this.lblTitleBar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.FlowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.TableLayoutPanel1.SuspendLayout();
            this.FlowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
	    
			//
	        //hlEdit
			//
			this.hlEdit= new System.Windows.Forms.LinkLabel();
			
			this.hlEdit.AutoSize = true;		
			this.hlEdit.Location = new System.Drawing.Point(24,40);
			this.hlEdit.Name = "hlEdit";
			this.hlEdit.Font = new System.Drawing.Font( "Tahoma",8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.hlEdit.Size = new System.Drawing.Size(28,16);
			this.hlEdit.TabIndex = 199;
			this.hlEdit.TabStop = true;
			this.hlEdit.Text = "Edit";
			//
	        //hlNew
			//
			this.hlNew= new System.Windows.Forms.LinkLabel();
			
			this.hlNew.AutoSize = true;		
			this.hlNew.Location = new System.Drawing.Point(62,40);
			this.hlNew.Name = "hlNew";
			this.hlNew.Font = new System.Drawing.Font( "Tahoma",8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.hlNew.Size = new System.Drawing.Size(30,16);
			this.hlNew.TabIndex = 199;
			this.hlNew.TabStop = true;
			this.hlNew.Text = "New";
			//
			//grdvColidRecHunter
			//
			this.grdvColidRecHunter = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.grdvColidRecHunter.DataPropertyName = "idRecHunter";
		    this.grdvColidRecHunter.HeaderText = "idRecHunter";
		    this.grdvColidRecHunter.Name = "grdvColidRecHunter";
			
			//
			//grdvColIdCardNumber
			//
			this.grdvColIdCardNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.grdvColIdCardNumber.DataPropertyName = "IdCardNumber";
		    this.grdvColIdCardNumber.HeaderText = "IdCardNumber";
		    this.grdvColIdCardNumber.Name = "grdvColIdCardNumber";
			
			//
			//grdvColSurname
			//
			this.grdvColSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.grdvColSurname.DataPropertyName = "Surname";
		    this.grdvColSurname.HeaderText = "Surname";
		    this.grdvColSurname.Name = "grdvColSurname";
			
			//
			//grdvColName
			//
			this.grdvColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.grdvColName.DataPropertyName = "Name";
		    this.grdvColName.HeaderText = "Name";
		    this.grdvColName.Name = "grdvColName";
			
			//
			//grdvColAddress1
			//
			this.grdvColAddress1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.grdvColAddress1.DataPropertyName = "Address1";
		    this.grdvColAddress1.HeaderText = "Address1";
		    this.grdvColAddress1.Name = "grdvColAddress1";
			
			//
			//grdvColAddress2
			//
			this.grdvColAddress2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.grdvColAddress2.DataPropertyName = "Address2";
		    this.grdvColAddress2.HeaderText = "Address2";
		    this.grdvColAddress2.Name = "grdvColAddress2";
			
			//
			//grdvColLocality
			//
			this.grdvColLocality = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.grdvColLocality.DataPropertyName = "Locality";
		    this.grdvColLocality.HeaderText = "Locality";
		    this.grdvColLocality.Name = "grdvColLocality";
			
			//
			//grdvColMaltaOrGozo
			//
			this.grdvColMaltaOrGozo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.grdvColMaltaOrGozo.DataPropertyName = "MaltaOrGozo";
		    this.grdvColMaltaOrGozo.HeaderText = "MaltaOrGozo";
		    this.grdvColMaltaOrGozo.Name = "grdvColMaltaOrGozo";
			
			//
			//grdvColLicencedMobileNumber
			//
			this.grdvColLicencedMobileNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.grdvColLicencedMobileNumber.DataPropertyName = "LicencedMobileNumber";
		    this.grdvColLicencedMobileNumber.HeaderText = "LicencedMobileNumber";
		    this.grdvColLicencedMobileNumber.Name = "grdvColLicencedMobileNumber";
			
			//
			//grdvColHomePhoneNumber
			//
			this.grdvColHomePhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.grdvColHomePhoneNumber.DataPropertyName = "HomePhoneNumber";
		    this.grdvColHomePhoneNumber.HeaderText = "HomePhoneNumber";
		    this.grdvColHomePhoneNumber.Name = "grdvColHomePhoneNumber";
			
			//
			//grdvColDesc1
			//
			this.grdvColDesc1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.grdvColDesc1.DataPropertyName = "Desc1";
		    this.grdvColDesc1.HeaderText = "Desc1";
		    this.grdvColDesc1.Name = "grdvColDesc1";
			
			//
			//grdvColDesc2
			//
			this.grdvColDesc2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.grdvColDesc2.DataPropertyName = "Desc2";
		    this.grdvColDesc2.HeaderText = "Desc2";
		    this.grdvColDesc2.Name = "grdvColDesc2";
			
			//
			//grdvColLicenceActive
			//
			this.grdvColLicenceActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.grdvColLicenceActive.DataPropertyName = "LicenceActive";
		    this.grdvColLicenceActive.HeaderText = "LicenceActive";
		    this.grdvColLicenceActive.Name = "grdvColLicenceActive";
			
			//
			//grdvColActive
			//
			this.grdvColActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.grdvColActive.DataPropertyName = "Active";
		    this.grdvColActive.HeaderText = "Active";
		    this.grdvColActive.Name = "grdvColActive";
						
			//
			//grhuntersResult
			//	   
			this.grhuntersResult = new System.Windows.Forms.DataGridView();
			this.grhuntersResult.AllowUserToAddRows = false;
			((System.ComponentModel.ISupportInitialize)(this.grhuntersResult)).BeginInit();
			this.grhuntersResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { 
				this.grdvColidRecHunter, 
				this.grdvColIdCardNumber, 
				this.grdvColSurname, 
				this.grdvColName, 
				this.grdvColAddress1, 
				this.grdvColAddress2, 
				this.grdvColLocality, 
				this.grdvColMaltaOrGozo, 
				this.grdvColLicencedMobileNumber, 
				this.grdvColHomePhoneNumber, 
				this.grdvColDesc1, 
				this.grdvColDesc2, 
				this.grdvColLicenceActive, 
				this.grdvColActive});
			this.grhuntersResult.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.grhuntersResult.Location = new System.Drawing.Point(3, 33);
            this.grhuntersResult.MultiSelect = false;
            this.grhuntersResult.Name = "grhuntersResult";
			this.grhuntersResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grhuntersResult.Size = new System.Drawing.Size(744, 312);
            this.grhuntersResult.AutoScrollOffset = new System.Drawing.Point(744, 312);
            this.grhuntersResult.TabIndex = 212;
            this.grhuntersResult.ReadOnly = true;
			//this.grhuntersResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.grhuntersResult.Visible = true;
			//
            //huntersListFormMgr
            //
			this.huntersListFormMgr = new TierDeveloper.Windows.Forms.ListFormManager();
	    
            ((System.ComponentModel.ISupportInitialize)(this.huntersListFormMgr)).BeginInit();
            this.huntersListFormMgr.BindingSource = null;
            this.huntersListFormMgr.DataSource = null;
			this.huntersListFormMgr.ParentForm = this;
            this.huntersListFormMgr.DomainObject = typeof(Testwin.Business.Domain.hunters);
			this.huntersListFormMgr.CommandDescriptors.AddRange(new TierDeveloper.Windows.Forms.CommandDescriptor[] {new TierDeveloper.Windows.Forms.ListCommandDescriptor( this.hlEdit, "Testwin.UI.CSWinForm.huntersForm", this.huntersListFormMgr, new TierDeveloper.Windows.Forms.ParameterDescriptor[] {new TierDeveloper.Windows.Forms.ParameterDescriptor(typeof(Int32), this.grdvColidRecHunter)},new TierDeveloper.Windows.Forms.ListCommandDescriptor[0] ),new TierDeveloper.Windows.Forms.ListCommandDescriptor( this.hlNew, "Testwin.UI.CSWinForm.huntersForm", this.huntersListFormMgr, new TierDeveloper.Windows.Forms.ParameterDescriptor[0],new TierDeveloper.Windows.Forms.ListCommandDescriptor[0] )});
			this.huntersListFormMgr.FieldDescriptors.AddRange( new TierDeveloper.Windows.Forms.FieldDescriptor[] {new TierDeveloper.Windows.Forms.FieldDescriptor(this.grdvColidRecHunter, "idRecHunter"),new TierDeveloper.Windows.Forms.FieldDescriptor(this.grdvColIdCardNumber, "IdCardNumber"),new TierDeveloper.Windows.Forms.FieldDescriptor(this.grdvColSurname, "Surname"),new TierDeveloper.Windows.Forms.FieldDescriptor(this.grdvColName, "Name"),new TierDeveloper.Windows.Forms.FieldDescriptor(this.grdvColAddress1, "Address1"),new TierDeveloper.Windows.Forms.FieldDescriptor(this.grdvColAddress2, "Address2"),new TierDeveloper.Windows.Forms.FieldDescriptor(this.grdvColLocality, "Locality"),new TierDeveloper.Windows.Forms.FieldDescriptor(this.grdvColMaltaOrGozo, "MaltaOrGozo"),new TierDeveloper.Windows.Forms.FieldDescriptor(this.grdvColLicencedMobileNumber, "LicencedMobileNumber"),new TierDeveloper.Windows.Forms.FieldDescriptor(this.grdvColHomePhoneNumber, "HomePhoneNumber"),new TierDeveloper.Windows.Forms.FieldDescriptor(this.grdvColDesc1, "Desc1"),new TierDeveloper.Windows.Forms.FieldDescriptor(this.grdvColDesc2, "Desc2"),new TierDeveloper.Windows.Forms.FieldDescriptor(this.grdvColLicenceActive, "LicenceActive"),new TierDeveloper.Windows.Forms.FieldDescriptor(this.grdvColActive, "Active")});
            this.huntersListFormMgr.PersistenceObject = typeof(Testwin.Data.Persistence.huntersFactory);
            this.huntersListFormMgr.Status = TierDeveloper.Windows.Forms.eExecution.Success;
            this.huntersListFormMgr.TargetGrid = this.grhuntersResult;
			this.huntersListFormMgr.ExceptionOccured += new TierDeveloper.Windows.Forms.FormManager.ExceptionOccuredDel(this.OnException);
			//
            //TableLayoutPanel1
            //
            this.TableLayoutPanel1.ColumnCount = 1;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0F));
            this.TableLayoutPanel1.Controls.Add(this.grhuntersResult, 0, 1);
            this.TableLayoutPanel1.Controls.Add(this.FlowLayoutPanel1, 0, 0);
            this.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel1.Location = new System.Drawing.Point(0, 32);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 2;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0F));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(808, 526);
            this.TableLayoutPanel1.TabIndex = 220;
            //
            //FlowLayoutPanel1
            //
			
		    this.FlowLayoutPanel1.Controls.Add(this.hlEdit);
		    this.FlowLayoutPanel1.Controls.Add(this.hlNew);            
            this.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.FlowLayoutPanel1.Name = "FlowLayoutPanel1";
            this.FlowLayoutPanel1.Size = new System.Drawing.Size(802, 24);
            this.FlowLayoutPanel1.TabIndex = 213;
            //
            //huntersListForm
            //
            //this.AutoScaleDimensions = new System.Drawing.Size(5, 13);           
            this.AutoScroll = true          ;  
            this.ClientSize = new System.Drawing.Size(808, 558);
            this.Controls.Add(this.TableLayoutPanel1);
            this.Controls.Add(this.lblTitleBar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Name = "huntersListForm";
            this.Text = "huntersListForm";
            ((System.ComponentModel.ISupportInitialize)(this.grhuntersResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.huntersListFormMgr)).EndInit();
			this.TableLayoutPanel1.ResumeLayout(false);
            this.FlowLayoutPanel1.ResumeLayout(false);
            this.FlowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

    }
}

