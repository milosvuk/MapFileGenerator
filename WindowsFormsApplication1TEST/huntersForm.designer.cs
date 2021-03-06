
using System.Windows.Forms;
using System;
using System.Drawing;

namespace Testwin.UI.CSWinForm
{
	public partial class huntersForm : BaseForm
	{
		/// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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

        //NOTE: The following procedure is required by the Windows Form Designer
        //It can be modified using the Windows Form Designer.
        //Do not modify it using the code editor.
		private System.Windows.Forms.Label lblTitleBar;
        private System.Windows.Forms.Label lblPrimary;
        private System.Windows.Forms.Label lblReq;
		private System.Windows.Forms.Label lblMssg;
		private System.Windows.Forms.Label lblcurrenthunters;
		private TierDeveloper.Windows.Forms.EditFormManager huntersEditFormMgr;
		//private string errMsg= "";
		private System.Windows.Forms.Button cmdSave;
		private System.Windows.Forms.Button cmdLoad;
		private System.Windows.Forms.Button cmdDelete;
		private System.Windows.Forms.Button cmdReset;
		private TierDeveloper.Windows.Forms.Validators.RequiredFieldValidator vldtxtidRecHunter;
		private System.Windows.Forms.TextBox txtidRecHunter;
		private System.Windows.Forms.Label lblidRecHunter;
		private System.Windows.Forms.TextBox txtIdCardNumber;
		private System.Windows.Forms.Label lblIdCardNumber;
		private System.Windows.Forms.TextBox txtSurname;
		private System.Windows.Forms.Label lblSurname;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.TextBox txtAddress1;
		private System.Windows.Forms.Label lblAddress1;
		private System.Windows.Forms.TextBox txtAddress2;
		private System.Windows.Forms.Label lblAddress2;
		private System.Windows.Forms.TextBox txtLocality;
		private System.Windows.Forms.Label lblLocality;
		private System.Windows.Forms.TextBox txtMaltaOrGozo;
		private System.Windows.Forms.Label lblMaltaOrGozo;
		private System.Windows.Forms.TextBox txtLicencedMobileNumber;
		private System.Windows.Forms.Label lblLicencedMobileNumber;
		private System.Windows.Forms.TextBox txtHomePhoneNumber;
		private System.Windows.Forms.Label lblHomePhoneNumber;
		private System.Windows.Forms.TextBox txtLicenceActive;
		private System.Windows.Forms.Label lblLicenceActive;
		private System.Windows.Forms.TextBox txtActive;
		private System.Windows.Forms.Label lblActive;
		private System.Windows.Forms.TextBox txtDesc1;
		private System.Windows.Forms.Label lblDesc1;
		private System.Windows.Forms.TextBox txtDesc2;
		private System.Windows.Forms.Label lblDesc2;

		private void InitializeComponent()
		{
            System.Configuration.AppSettingsReader configurationAppSettings = new System.Configuration.AppSettingsReader();
	        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(huntersForm));
			this.components = new System.ComponentModel.Container();
	    	//
            //lblTitleBar
			//
			this.lblTitleBar = new System.Windows.Forms.Label();
            this.lblTitleBar.Font = new System.Drawing.Font( "Tahoma",16.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitleBar.Dock = System.Windows.Forms.DockStyle.Top;			
			this.lblTitleBar.BackColor =System.Drawing.Color.FromArgb(((byte)(12)), ((byte)(22)), ((byte)(118)));
            this.lblTitleBar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;			
			this.lblTitleBar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTitleBar.Location = new System.Drawing.Point(0, 0);
            this.lblTitleBar.Name = "lblTitleBar";
            this.lblTitleBar.Size = new System.Drawing.Size(864, 32);
            this.lblTitleBar.TabIndex = 218;
            this.lblTitleBar.Text = "hunters Form";
            this.lblTitleBar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SuspendLayout(); 
			//
			//lbllblcurrenthunters
			//
			this.lblcurrenthunters = new System.Windows.Forms.Label();
			this.Controls.Add(this.lblcurrenthunters);
			this.lblcurrenthunters.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblcurrenthunters.Location = new System.Drawing.Point(7,60);
			this.lblcurrenthunters.Name = "lblcurrenthunters";
			this.lblcurrenthunters.Size = new System.Drawing.Size( 110,16);
			this.lblcurrenthunters.TabIndex = 202;
			this.lblcurrenthunters.TextAlign = System.Drawing.ContentAlignment.TopLeft;
			this.lblcurrenthunters.Font =  new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline)));
			this.lblcurrenthunters.Text = "hunters";
			this.lblcurrenthunters.ForeColor = System.Drawing.Color.Navy;
			//
			//txtidRecHunter
			//
			this.txtidRecHunter = new System.Windows.Forms.TextBox();
			this.Controls.Add(this.txtidRecHunter);
			this.txtidRecHunter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtidRecHunter.TabIndex = 1;
			this.txtidRecHunter.Location = new System.Drawing.Point(120,100);
			this.txtidRecHunter.Name = "txtidRecHunter";
			this.txtidRecHunter.Size = new System.Drawing.Size( 48,16);
			
			//this.txtidRecHunter.ReadOnly = true;
			//this.txtidRecHunter.Text = "txtidRecHunter";
			this.txtidRecHunter.Font = new System.Drawing.Font( "Tahoma",8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			
			//
			//lblidRecHunter
			//
			this.lblidRecHunter = new System.Windows.Forms.Label();
			this.Controls.Add(this.lblidRecHunter);
			this.lblidRecHunter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblidRecHunter.Location = new System.Drawing.Point(7,100);
			this.lblidRecHunter.Name = "lblidRecHunter";
			this.lblidRecHunter.Size = new System.Drawing.Size( 110,16);
			this.lblidRecHunter.TabIndex = 202;
			this.lblidRecHunter.TextAlign = System.Drawing.ContentAlignment.TopRight;
			
			this.lblidRecHunter.ForeColor = Color.Red;
			this.lblidRecHunter.Text ="**idRecHunter:";
			this.lblidRecHunter.Font =  new System.Drawing.Font( "Tahoma",8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			
			
			//
            //vldtxtidRecHunter
            //
            this.vldtxtidRecHunter = new TierDeveloper.Windows.Forms.Validators.RequiredFieldValidator(this.components);
            this.vldtxtidRecHunter.CancelFocusChangeWhenInvalid = false;
            this.vldtxtidRecHunter.ErrorMessage = "Primary Key must not be left empty.";
            
			//
			//txtIdCardNumber
			//
			this.txtIdCardNumber = new System.Windows.Forms.TextBox();
			this.Controls.Add(this.txtIdCardNumber);
			this.txtIdCardNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtIdCardNumber.TabIndex = 2;
			this.txtIdCardNumber.Location = new System.Drawing.Point(495,100);
			this.txtIdCardNumber.Name = "txtIdCardNumber";
			this.txtIdCardNumber.Size = new System.Drawing.Size( 300,16);
			
			//this.txtIdCardNumber.Text = "txtIdCardNumber";
			this.txtIdCardNumber.Font = new System.Drawing.Font( "Tahoma",8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			
			//
			//lblIdCardNumber
			//
			this.lblIdCardNumber = new System.Windows.Forms.Label();
			this.Controls.Add(this.lblIdCardNumber);
			this.lblIdCardNumber.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblIdCardNumber.Location = new System.Drawing.Point(382,100);
			this.lblIdCardNumber.Name = "lblIdCardNumber";
			this.lblIdCardNumber.Size = new System.Drawing.Size( 110,16);
			this.lblIdCardNumber.TabIndex = 202;
			this.lblIdCardNumber.TextAlign = System.Drawing.ContentAlignment.TopRight;
			
			this.lblIdCardNumber.Font =  new System.Drawing.Font( "Tahoma",8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblIdCardNumber.Text = "IdCardNumber:";
			this.lblIdCardNumber.ForeColor = Color.Black;
			//
			//txtSurname
			//
			this.txtSurname = new System.Windows.Forms.TextBox();
			this.Controls.Add(this.txtSurname);
			this.txtSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtSurname.TabIndex = 3;
			this.txtSurname.Location = new System.Drawing.Point(120,125);
			this.txtSurname.Name = "txtSurname";
			this.txtSurname.Size = new System.Drawing.Size( 300,16);
			
			//this.txtSurname.Text = "txtSurname";
			this.txtSurname.Font = new System.Drawing.Font( "Tahoma",8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			
			//
			//lblSurname
			//
			this.lblSurname = new System.Windows.Forms.Label();
			this.Controls.Add(this.lblSurname);
			this.lblSurname.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblSurname.Location = new System.Drawing.Point(7,125);
			this.lblSurname.Name = "lblSurname";
			this.lblSurname.Size = new System.Drawing.Size( 110,16);
			this.lblSurname.TabIndex = 202;
			this.lblSurname.TextAlign = System.Drawing.ContentAlignment.TopRight;
			
			this.lblSurname.Font =  new System.Drawing.Font( "Tahoma",8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblSurname.Text = "Surname:";
			this.lblSurname.ForeColor = Color.Black;
			//
			//txtName
			//
			this.txtName = new System.Windows.Forms.TextBox();
			this.Controls.Add(this.txtName);
			this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtName.TabIndex = 4;
			this.txtName.Location = new System.Drawing.Point(495,125);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size( 300,16);
			
			//this.txtName.Text = "txtName";
			this.txtName.Font = new System.Drawing.Font( "Tahoma",8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			
			//
			//lblName
			//
			this.lblName = new System.Windows.Forms.Label();
			this.Controls.Add(this.lblName);
			this.lblName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblName.Location = new System.Drawing.Point(382,125);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size( 110,16);
			this.lblName.TabIndex = 202;
			this.lblName.TextAlign = System.Drawing.ContentAlignment.TopRight;
			
			this.lblName.Font =  new System.Drawing.Font( "Tahoma",8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblName.Text = "Name:";
			this.lblName.ForeColor = Color.Black;
			//
			//txtAddress1
			//
			this.txtAddress1 = new System.Windows.Forms.TextBox();
			this.Controls.Add(this.txtAddress1);
			this.txtAddress1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtAddress1.TabIndex = 5;
			this.txtAddress1.Location = new System.Drawing.Point(120,150);
			this.txtAddress1.Name = "txtAddress1";
			this.txtAddress1.Size = new System.Drawing.Size( 300,16);
			
			//this.txtAddress1.Text = "txtAddress1";
			this.txtAddress1.Font = new System.Drawing.Font( "Tahoma",8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			
			//
			//lblAddress1
			//
			this.lblAddress1 = new System.Windows.Forms.Label();
			this.Controls.Add(this.lblAddress1);
			this.lblAddress1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblAddress1.Location = new System.Drawing.Point(7,150);
			this.lblAddress1.Name = "lblAddress1";
			this.lblAddress1.Size = new System.Drawing.Size( 110,16);
			this.lblAddress1.TabIndex = 202;
			this.lblAddress1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			
			this.lblAddress1.Font =  new System.Drawing.Font( "Tahoma",8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblAddress1.Text = "Address1:";
			this.lblAddress1.ForeColor = Color.Black;
			//
			//txtAddress2
			//
			this.txtAddress2 = new System.Windows.Forms.TextBox();
			this.Controls.Add(this.txtAddress2);
			this.txtAddress2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtAddress2.TabIndex = 6;
			this.txtAddress2.Location = new System.Drawing.Point(495,150);
			this.txtAddress2.Name = "txtAddress2";
			this.txtAddress2.Size = new System.Drawing.Size( 300,16);
			
			//this.txtAddress2.Text = "txtAddress2";
			this.txtAddress2.Font = new System.Drawing.Font( "Tahoma",8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			
			//
			//lblAddress2
			//
			this.lblAddress2 = new System.Windows.Forms.Label();
			this.Controls.Add(this.lblAddress2);
			this.lblAddress2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblAddress2.Location = new System.Drawing.Point(382,150);
			this.lblAddress2.Name = "lblAddress2";
			this.lblAddress2.Size = new System.Drawing.Size( 110,16);
			this.lblAddress2.TabIndex = 202;
			this.lblAddress2.TextAlign = System.Drawing.ContentAlignment.TopRight;
			
			this.lblAddress2.Font =  new System.Drawing.Font( "Tahoma",8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblAddress2.Text = "Address2:";
			this.lblAddress2.ForeColor = Color.Black;
			//
			//txtLocality
			//
			this.txtLocality = new System.Windows.Forms.TextBox();
			this.Controls.Add(this.txtLocality);
			this.txtLocality.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtLocality.TabIndex = 7;
			this.txtLocality.Location = new System.Drawing.Point(120,175);
			this.txtLocality.Name = "txtLocality";
			this.txtLocality.Size = new System.Drawing.Size( 300,16);
			
			//this.txtLocality.Text = "txtLocality";
			this.txtLocality.Font = new System.Drawing.Font( "Tahoma",8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			
			//
			//lblLocality
			//
			this.lblLocality = new System.Windows.Forms.Label();
			this.Controls.Add(this.lblLocality);
			this.lblLocality.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblLocality.Location = new System.Drawing.Point(7,175);
			this.lblLocality.Name = "lblLocality";
			this.lblLocality.Size = new System.Drawing.Size( 110,16);
			this.lblLocality.TabIndex = 202;
			this.lblLocality.TextAlign = System.Drawing.ContentAlignment.TopRight;
			
			this.lblLocality.Font =  new System.Drawing.Font( "Tahoma",8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblLocality.Text = "Locality:";
			this.lblLocality.ForeColor = Color.Black;
			//
			//txtMaltaOrGozo
			//
			this.txtMaltaOrGozo = new System.Windows.Forms.TextBox();
			this.Controls.Add(this.txtMaltaOrGozo);
			this.txtMaltaOrGozo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtMaltaOrGozo.TabIndex = 8;
			this.txtMaltaOrGozo.Location = new System.Drawing.Point(495,175);
			this.txtMaltaOrGozo.Name = "txtMaltaOrGozo";
			this.txtMaltaOrGozo.Size = new System.Drawing.Size( 48,16);
			
			//this.txtMaltaOrGozo.Text = "txtMaltaOrGozo";
			this.txtMaltaOrGozo.Font = new System.Drawing.Font( "Tahoma",8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			
			//
			//lblMaltaOrGozo
			//
			this.lblMaltaOrGozo = new System.Windows.Forms.Label();
			this.Controls.Add(this.lblMaltaOrGozo);
			this.lblMaltaOrGozo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblMaltaOrGozo.Location = new System.Drawing.Point(382,175);
			this.lblMaltaOrGozo.Name = "lblMaltaOrGozo";
			this.lblMaltaOrGozo.Size = new System.Drawing.Size( 110,16);
			this.lblMaltaOrGozo.TabIndex = 202;
			this.lblMaltaOrGozo.TextAlign = System.Drawing.ContentAlignment.TopRight;
			
			this.lblMaltaOrGozo.Font =  new System.Drawing.Font( "Tahoma",8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblMaltaOrGozo.Text = "MaltaOrGozo:";
			this.lblMaltaOrGozo.ForeColor = Color.Black;
			//
			//txtLicencedMobileNumber
			//
			this.txtLicencedMobileNumber = new System.Windows.Forms.TextBox();
			this.Controls.Add(this.txtLicencedMobileNumber);
			this.txtLicencedMobileNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtLicencedMobileNumber.TabIndex = 9;
			this.txtLicencedMobileNumber.Location = new System.Drawing.Point(120,200);
			this.txtLicencedMobileNumber.Name = "txtLicencedMobileNumber";
			this.txtLicencedMobileNumber.Size = new System.Drawing.Size( 300,16);
			
			//this.txtLicencedMobileNumber.Text = "txtLicencedMobileNumber";
			this.txtLicencedMobileNumber.Font = new System.Drawing.Font( "Tahoma",8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			
			//
			//lblLicencedMobileNumber
			//
			this.lblLicencedMobileNumber = new System.Windows.Forms.Label();
			this.Controls.Add(this.lblLicencedMobileNumber);
			this.lblLicencedMobileNumber.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblLicencedMobileNumber.Location = new System.Drawing.Point(7,200);
			this.lblLicencedMobileNumber.Name = "lblLicencedMobileNumber";
			this.lblLicencedMobileNumber.Size = new System.Drawing.Size( 110,16);
			this.lblLicencedMobileNumber.TabIndex = 202;
			this.lblLicencedMobileNumber.TextAlign = System.Drawing.ContentAlignment.TopRight;
			
			this.lblLicencedMobileNumber.Font =  new System.Drawing.Font( "Tahoma",8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblLicencedMobileNumber.Text = "LicencedMobileNumber:";
			this.lblLicencedMobileNumber.ForeColor = Color.Black;
			//
			//txtHomePhoneNumber
			//
			this.txtHomePhoneNumber = new System.Windows.Forms.TextBox();
			this.Controls.Add(this.txtHomePhoneNumber);
			this.txtHomePhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtHomePhoneNumber.TabIndex = 10;
			this.txtHomePhoneNumber.Location = new System.Drawing.Point(495,200);
			this.txtHomePhoneNumber.Name = "txtHomePhoneNumber";
			this.txtHomePhoneNumber.Size = new System.Drawing.Size( 300,16);
			
			//this.txtHomePhoneNumber.Text = "txtHomePhoneNumber";
			this.txtHomePhoneNumber.Font = new System.Drawing.Font( "Tahoma",8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			
			//
			//lblHomePhoneNumber
			//
			this.lblHomePhoneNumber = new System.Windows.Forms.Label();
			this.Controls.Add(this.lblHomePhoneNumber);
			this.lblHomePhoneNumber.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblHomePhoneNumber.Location = new System.Drawing.Point(382,200);
			this.lblHomePhoneNumber.Name = "lblHomePhoneNumber";
			this.lblHomePhoneNumber.Size = new System.Drawing.Size( 110,16);
			this.lblHomePhoneNumber.TabIndex = 202;
			this.lblHomePhoneNumber.TextAlign = System.Drawing.ContentAlignment.TopRight;
			
			this.lblHomePhoneNumber.Font =  new System.Drawing.Font( "Tahoma",8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblHomePhoneNumber.Text = "HomePhoneNumber:";
			this.lblHomePhoneNumber.ForeColor = Color.Black;
			//
			//txtLicenceActive
			//
			this.txtLicenceActive = new System.Windows.Forms.TextBox();
			this.Controls.Add(this.txtLicenceActive);
			this.txtLicenceActive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtLicenceActive.TabIndex = 11;
			this.txtLicenceActive.Location = new System.Drawing.Point(120,225);
			this.txtLicenceActive.Name = "txtLicenceActive";
			this.txtLicenceActive.Size = new System.Drawing.Size( 48,16);
			
			//this.txtLicenceActive.Text = "txtLicenceActive";
			this.txtLicenceActive.Font = new System.Drawing.Font( "Tahoma",8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			
			//
			//lblLicenceActive
			//
			this.lblLicenceActive = new System.Windows.Forms.Label();
			this.Controls.Add(this.lblLicenceActive);
			this.lblLicenceActive.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblLicenceActive.Location = new System.Drawing.Point(7,225);
			this.lblLicenceActive.Name = "lblLicenceActive";
			this.lblLicenceActive.Size = new System.Drawing.Size( 110,16);
			this.lblLicenceActive.TabIndex = 202;
			this.lblLicenceActive.TextAlign = System.Drawing.ContentAlignment.TopRight;
			
			this.lblLicenceActive.Font =  new System.Drawing.Font( "Tahoma",8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblLicenceActive.Text = "LicenceActive:";
			this.lblLicenceActive.ForeColor = Color.Black;
			//
			//txtActive
			//
			this.txtActive = new System.Windows.Forms.TextBox();
			this.Controls.Add(this.txtActive);
			this.txtActive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtActive.TabIndex = 12;
			this.txtActive.Location = new System.Drawing.Point(495,225);
			this.txtActive.Name = "txtActive";
			this.txtActive.Size = new System.Drawing.Size( 48,16);
			
			//this.txtActive.Text = "txtActive";
			this.txtActive.Font = new System.Drawing.Font( "Tahoma",8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			
			//
			//lblActive
			//
			this.lblActive = new System.Windows.Forms.Label();
			this.Controls.Add(this.lblActive);
			this.lblActive.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblActive.Location = new System.Drawing.Point(382,225);
			this.lblActive.Name = "lblActive";
			this.lblActive.Size = new System.Drawing.Size( 110,16);
			this.lblActive.TabIndex = 202;
			this.lblActive.TextAlign = System.Drawing.ContentAlignment.TopRight;
			
			this.lblActive.Font =  new System.Drawing.Font( "Tahoma",8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblActive.Text = "Active:";
			this.lblActive.ForeColor = Color.Black;
			//
			//txtDesc1
			//
			this.txtDesc1 = new System.Windows.Forms.TextBox();
			this.Controls.Add(this.txtDesc1);
			this.txtDesc1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtDesc1.TabIndex = 13;
			this.txtDesc1.Location = new System.Drawing.Point(120,250);
			this.txtDesc1.Multiline = true;
			this.txtDesc1.Name = "txtDesc1";
			this.txtDesc1.Size = new System.Drawing.Size( 570,64);
			
			//this.txtDesc1.Text = "txtDesc1";
			this.txtDesc1.Font = new System.Drawing.Font( "Tahoma",8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			
			//
			//lblDesc1
			//
			this.lblDesc1 = new System.Windows.Forms.Label();
			this.Controls.Add(this.lblDesc1);
			this.lblDesc1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblDesc1.Location = new System.Drawing.Point(7,250);
			this.lblDesc1.Name = "lblDesc1";
			this.lblDesc1.Size = new System.Drawing.Size( 110,16);
			this.lblDesc1.TabIndex = 202;
			this.lblDesc1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			
			this.lblDesc1.Font =  new System.Drawing.Font( "Tahoma",8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblDesc1.Text = "Desc1:";
			this.lblDesc1.ForeColor = Color.Black;
			//
			//txtDesc2
			//
			this.txtDesc2 = new System.Windows.Forms.TextBox();
			this.Controls.Add(this.txtDesc2);
			this.txtDesc2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtDesc2.TabIndex = 14;
			this.txtDesc2.Location = new System.Drawing.Point(120,320);
			this.txtDesc2.Multiline = true;
			this.txtDesc2.Name = "txtDesc2";
			this.txtDesc2.Size = new System.Drawing.Size( 570,64);
			
			//this.txtDesc2.Text = "txtDesc2";
			this.txtDesc2.Font = new System.Drawing.Font( "Tahoma",8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			
			//
			//lblDesc2
			//
			this.lblDesc2 = new System.Windows.Forms.Label();
			this.Controls.Add(this.lblDesc2);
			this.lblDesc2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblDesc2.Location = new System.Drawing.Point(7,320);
			this.lblDesc2.Name = "lblDesc2";
			this.lblDesc2.Size = new System.Drawing.Size( 110,16);
			this.lblDesc2.TabIndex = 202;
			this.lblDesc2.TextAlign = System.Drawing.ContentAlignment.TopRight;
			
			this.lblDesc2.Font =  new System.Drawing.Font( "Tahoma",8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblDesc2.Text = "Desc2:";
			this.lblDesc2.ForeColor = Color.Black;
			//
			//lblPrimary
			//
			this.lblPrimary = new System.Windows.Forms.Label();
			this.Controls.Add(this.lblPrimary);
			this.lblPrimary.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.lblPrimary.Location = new System.Drawing.Point(120,406);
			this.lblPrimary.Name = "lblPrimary";
			this.lblPrimary.TabIndex = 202;
			this.lblPrimary.TextAlign = System.Drawing.ContentAlignment.TopLeft;
			this.lblPrimary.ForeColor = Color.Red;
			this.lblPrimary.Text = "**Primary Fields";
			this.lblPrimary.Font = new System.Drawing.Font( "Tahoma",8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			//lblReq
			//
			this.lblReq = new System.Windows.Forms.Label();
			this.Controls.Add(this.lblReq);
			this.lblReq.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.lblReq.Location = new System.Drawing.Point(250, 406);
			this.lblReq.Name = "lblReq";
			this.lblReq.TabIndex = 202;
			this.lblReq.TextAlign = System.Drawing.ContentAlignment.TopLeft;
			this.lblReq.ForeColor = Color.Purple;
			this.lblReq.Text = "*Required Fields";
			this.lblReq.Font = new System.Drawing.Font( "Tahoma",8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			
			//
			//cmdSave
			//
			this.cmdSave = new System.Windows.Forms.Button();
			this.Controls.Add(this.cmdSave);
			this.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmdSave.Font = new System.Drawing.Font( "Tahoma",8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdSave.TabIndex =  15;
			this.cmdSave.ForeColor = System.Drawing.Color.Black ;  
			this.cmdSave.Location = new System.Drawing.Point(120,430);
			this.cmdSave.Name = "cmdSave";
			this.cmdSave.Size = new System.Drawing.Size(72,20);
			this.cmdSave.Text = "Save";
			//
			//cmdLoad
			//
			this.cmdLoad = new System.Windows.Forms.Button();
			this.Controls.Add(this.cmdLoad);
			this.cmdLoad.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmdLoad.Font = new System.Drawing.Font( "Tahoma",8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdLoad.TabIndex =  16;
			this.cmdLoad.ForeColor = System.Drawing.Color.Black ;  
			this.cmdLoad.Location = new System.Drawing.Point(220,430);
			this.cmdLoad.Name = "cmdLoad";
			this.cmdLoad.Size = new System.Drawing.Size(72,20);
			this.cmdLoad.Text = "Load";
			//
			//cmdDelete
			//
			this.cmdDelete = new System.Windows.Forms.Button();
			this.Controls.Add(this.cmdDelete);
			this.cmdDelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmdDelete.Font = new System.Drawing.Font( "Tahoma",8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdDelete.TabIndex =  17;
			this.cmdDelete.ForeColor = System.Drawing.Color.Black ;  
			this.cmdDelete.Location = new System.Drawing.Point(320,430);
			this.cmdDelete.Name = "cmdDelete";
			this.cmdDelete.Size = new System.Drawing.Size(60,20);
			this.cmdDelete.Text = "Delete";
			//
			//cmdReset
			//
			this.cmdReset = new System.Windows.Forms.Button();
			this.Controls.Add(this.cmdReset);
			this.cmdReset.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmdReset.Font = new System.Drawing.Font( "Tahoma",8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdReset.TabIndex =  18;
			this.cmdReset.ForeColor = System.Drawing.Color.Black ;  
			this.cmdReset.Location = new System.Drawing.Point(408,430);
			this.cmdReset.Name = "cmdReset";
			this.cmdReset.Size = new System.Drawing.Size(72,20);
			this.cmdReset.Text = "Reset";
			
			//
			//lblMssg
			//
			this.lblMssg = new System.Windows.Forms.Label();
			this.Controls.Add(this.lblMssg);
			this.lblMssg.Location = new System.Drawing.Point(8, 460);
			this.lblMssg.Name = "lblMssg";
			this.lblMssg.AutoSize = true; //this.lblMssg.Size = new System.Drawing.Size(728, 23);
			this.lblMssg.Font = new System.Drawing.Font( "Tahoma",8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			//
            //huntersEditFormMgr
            //
			this.huntersEditFormMgr = new TierDeveloper.Windows.Forms.EditFormManager();
            ((System.ComponentModel.ISupportInitialize)(this.huntersEditFormMgr)).BeginInit();
            this.huntersEditFormMgr.BindingSource = null;
			this.huntersEditFormMgr.ParentForm = this;
			this.huntersEditFormMgr.CommandDescriptors.AddRange ( new TierDeveloper.Windows.Forms.CommandDescriptor[] { new TierDeveloper.Windows.Forms.EditCommandDescriptor( this.cmdSave, this.huntersEditFormMgr, " void Insert(hunters&, Int32)", " void Update(hunters&, Int32)", TierDeveloper.Windows.Forms.EOperation.Save, new TierDeveloper.Windows.Forms.ParameterDescriptor[] { new TierDeveloper.Windows.Forms.ParameterDescriptor( typeof(Testwin.Business.Domain.hunters)), new TierDeveloper.Windows.Forms.ParameterDescriptor( typeof(int), "1") }, new TierDeveloper.Windows.Forms.ParameterDescriptor[] { new TierDeveloper.Windows.Forms.ParameterDescriptor( typeof(Testwin.Business.Domain.hunters)), new TierDeveloper.Windows.Forms.ParameterDescriptor( typeof(int), "1") }, new TierDeveloper.Windows.Forms.EditCommandDescriptor[0] ),new TierDeveloper.Windows.Forms.EditCommandDescriptor( this.cmdLoad, this.huntersEditFormMgr, " void Load(hunters&, Int32)", null, TierDeveloper.Windows.Forms.EOperation.Load, new TierDeveloper.Windows.Forms.ParameterDescriptor[] { new TierDeveloper.Windows.Forms.ParameterDescriptor( typeof(Testwin.Business.Domain.hunters)), new TierDeveloper.Windows.Forms.ParameterDescriptor( typeof(int), "1") }, new TierDeveloper.Windows.Forms.EditCommandDescriptor[0] ),new TierDeveloper.Windows.Forms.EditCommandDescriptor( this.cmdDelete, this.huntersEditFormMgr, " void Delete(hunters&, Int32)", null, TierDeveloper.Windows.Forms.EOperation.Delete, new TierDeveloper.Windows.Forms.ParameterDescriptor[] { new TierDeveloper.Windows.Forms.ParameterDescriptor( typeof(Testwin.Business.Domain.hunters)), new TierDeveloper.Windows.Forms.ParameterDescriptor( typeof(int), "1") }, new TierDeveloper.Windows.Forms.EditCommandDescriptor[0] ),new TierDeveloper.Windows.Forms.EditCommandDescriptor( this.cmdReset, "ResetFormMethod", this.huntersEditFormMgr, new TierDeveloper.Windows.Forms.ParameterDescriptor[0] , new TierDeveloper.Windows.Forms.EditCommandDescriptor[0] )} );            
            this.huntersEditFormMgr.DataSource = null;
            this.huntersEditFormMgr.DomainObject = typeof(Testwin.Business.Domain.hunters);
			this.huntersEditFormMgr.FieldDescriptors.AddRange ( new TierDeveloper.Windows.Forms.FieldDescriptor[] { new TierDeveloper.Windows.Forms.FieldDescriptor(this.txtidRecHunter, "idRecHunter", this.vldtxtidRecHunter),new TierDeveloper.Windows.Forms.FieldDescriptor(this.txtIdCardNumber, "IdCardNumber"),new TierDeveloper.Windows.Forms.FieldDescriptor(this.txtSurname, "Surname"),new TierDeveloper.Windows.Forms.FieldDescriptor(this.txtName, "Name"),new TierDeveloper.Windows.Forms.FieldDescriptor(this.txtAddress1, "Address1"),new TierDeveloper.Windows.Forms.FieldDescriptor(this.txtAddress2, "Address2"),new TierDeveloper.Windows.Forms.FieldDescriptor(this.txtLocality, "Locality"),new TierDeveloper.Windows.Forms.FieldDescriptor(this.txtMaltaOrGozo, "MaltaOrGozo"),new TierDeveloper.Windows.Forms.FieldDescriptor(this.txtLicencedMobileNumber, "LicencedMobileNumber"),new TierDeveloper.Windows.Forms.FieldDescriptor(this.txtHomePhoneNumber, "HomePhoneNumber"),new TierDeveloper.Windows.Forms.FieldDescriptor(this.txtLicenceActive, "LicenceActive"),new TierDeveloper.Windows.Forms.FieldDescriptor(this.txtActive, "Active"),new TierDeveloper.Windows.Forms.FieldDescriptor(this.txtDesc1, "Desc1"),new TierDeveloper.Windows.Forms.FieldDescriptor(this.txtDesc2, "Desc2")} );

	
			this.huntersEditFormMgr.InitializationDescriptor = new TierDeveloper.Windows.Forms.ControlInitializationDescriptor( this.cmdLoad, new TierDeveloper.Windows.Forms.ParameterDescriptor[] {new TierDeveloper.Windows.Forms.ParameterDescriptor(typeof(Int32), this.txtidRecHunter)});

			this.huntersEditFormMgr.IsLoaded = false;
            this.huntersEditFormMgr.NamingConvention = "{0}{1}";
			this.huntersEditFormMgr.CommandExecuted += new TierDeveloper.Windows.Forms.FormManager.CommandExecutedDel(this.PostExecution);
            this.huntersEditFormMgr.ExceptionOccured += new TierDeveloper.Windows.Forms.FormManager.ExceptionOccuredDel(this.OnException);
            this.huntersEditFormMgr.PersistenceObject = typeof(Testwin.Data.Persistence.huntersFactory);
            this.huntersEditFormMgr.Status = TierDeveloper.Windows.Forms.eExecution.Success;
			((System.ComponentModel.ISupportInitialize)(this.huntersEditFormMgr)).EndInit();

			//
			//huntersForm
			//
			//this.AutoScaleDimensions = new System.Drawing.Size(5, 13);
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(808, 535);
			this.Controls.Add(this.lblTitleBar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "huntersForm";
			this.Text = "huntersForm";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.ResumeLayout(false);

        }
	#endregion
    }
}
