namespace ManejoDeContactos
{
    partial class Form1
    {

        /// Variable del diseñador necesaria.
        private System.ComponentModel.IContainer components = null;

        // Declaración de controles usados en el formulario.
        private System.Windows.Forms.ListView listViewContacts;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colEmail;
        private System.Windows.Forms.Panel panelDetails;

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;

        private System.Windows.Forms.Label lblPhones;
        private System.Windows.Forms.ListBox listBoxPhones;
        private System.Windows.Forms.TextBox txtPhoneInput;
        private System.Windows.Forms.Button btnAddPhone;
        private System.Windows.Forms.Button btnRemovePhone;

        private System.Windows.Forms.Label lblKeywords;
        private System.Windows.Forms.ListBox listBoxKeywords;
        private System.Windows.Forms.TextBox txtKeywordInput;
        private System.Windows.Forms.Button btnAddKeyword;
        private System.Windows.Forms.Button btnRemoveKeyword;

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnClear;

        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;


        /// Limpiar los recursos que se estén usando.
 
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.listViewContacts = new System.Windows.Forms.ListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelDetails = new System.Windows.Forms.Panel();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPhones = new System.Windows.Forms.Label();
            this.listBoxPhones = new System.Windows.Forms.ListBox();
            this.txtPhoneInput = new System.Windows.Forms.TextBox();
            this.btnAddPhone = new System.Windows.Forms.Button();
            this.btnRemovePhone = new System.Windows.Forms.Button();
            this.lblKeywords = new System.Windows.Forms.Label();
            this.listBoxKeywords = new System.Windows.Forms.ListBox();
            this.txtKeywordInput = new System.Windows.Forms.TextBox();
            this.btnAddKeyword = new System.Windows.Forms.Button();
            this.btnRemoveKeyword = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panelDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewContacts
            // 
            this.listViewContacts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colEmail});
            this.listViewContacts.FullRowSelect = true;
            this.listViewContacts.GridLines = true;
            this.listViewContacts.HideSelection = false;
            this.listViewContacts.Location = new System.Drawing.Point(12, 50);
            this.listViewContacts.Name = "listViewContacts";
            this.listViewContacts.Size = new System.Drawing.Size(520, 520);
            this.listViewContacts.TabIndex = 0;
            this.listViewContacts.UseCompatibleStateImageBehavior = false;
            this.listViewContacts.View = System.Windows.Forms.View.Details;
            this.listViewContacts.SelectedIndexChanged += new System.EventHandler(this.listViewContacts_SelectedIndexChanged);
            // 
            // colName
            // 
            this.colName.Text = "Nombre completo";
            this.colName.Width = 300;
            // 
            // colEmail
            // 
            this.colEmail.Text = "Correo";
            this.colEmail.Width = 200;
            // 
            // panelDetails
            // 
            this.panelDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDetails.Controls.Add(this.lblFirstName);
            this.panelDetails.Controls.Add(this.txtFirstName);
            this.panelDetails.Controls.Add(this.lblLastName);
            this.panelDetails.Controls.Add(this.txtLastName);
            this.panelDetails.Controls.Add(this.lblAddress);
            this.panelDetails.Controls.Add(this.txtAddress);
            this.panelDetails.Controls.Add(this.lblEmail);
            this.panelDetails.Controls.Add(this.txtEmail);
            this.panelDetails.Controls.Add(this.lblPhones);
            this.panelDetails.Controls.Add(this.listBoxPhones);
            this.panelDetails.Controls.Add(this.txtPhoneInput);
            this.panelDetails.Controls.Add(this.btnAddPhone);
            this.panelDetails.Controls.Add(this.btnRemovePhone);
            this.panelDetails.Controls.Add(this.lblKeywords);
            this.panelDetails.Controls.Add(this.listBoxKeywords);
            this.panelDetails.Controls.Add(this.txtKeywordInput);
            this.panelDetails.Controls.Add(this.btnAddKeyword);
            this.panelDetails.Controls.Add(this.btnRemoveKeyword);
            this.panelDetails.Controls.Add(this.btnAdd);
            this.panelDetails.Controls.Add(this.btnModify);
            this.panelDetails.Controls.Add(this.btnDelete);
            this.panelDetails.Controls.Add(this.btnView);
            this.panelDetails.Controls.Add(this.btnClear);
            this.panelDetails.Location = new System.Drawing.Point(540, 12);
            this.panelDetails.Name = "panelDetails";
            this.panelDetails.Size = new System.Drawing.Size(340, 558);
            this.panelDetails.TabIndex = 1;
            // 
            // lblFirstName
            // 
            this.lblFirstName.Location = new System.Drawing.Point(10, 10);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(100, 23);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "Nombre:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(10, 30);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(300, 20);
            this.txtFirstName.TabIndex = 1;
            // 
            // lblLastName
            // 
            this.lblLastName.Location = new System.Drawing.Point(10, 60);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(100, 23);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Apellido:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(10, 80);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(300, 20);
            this.txtLastName.TabIndex = 3;
            // 
            // lblAddress
            // 
            this.lblAddress.Location = new System.Drawing.Point(10, 110);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(100, 23);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = "Dirección:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(10, 130);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(300, 20);
            this.txtAddress.TabIndex = 5;
            // 
            // lblEmail
            // 
            this.lblEmail.Location = new System.Drawing.Point(10, 160);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(100, 23);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Correo:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(10, 180);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(300, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // lblPhones
            // 
            this.lblPhones.Location = new System.Drawing.Point(10, 210);
            this.lblPhones.Name = "lblPhones";
            this.lblPhones.Size = new System.Drawing.Size(100, 23);
            this.lblPhones.TabIndex = 8;
            this.lblPhones.Text = "Teléfonos:";
            // 
            // listBoxPhones
            // 
            this.listBoxPhones.Location = new System.Drawing.Point(10, 230);
            this.listBoxPhones.Name = "listBoxPhones";
            this.listBoxPhones.Size = new System.Drawing.Size(190, 56);
            this.listBoxPhones.TabIndex = 9;
            // 
            // txtPhoneInput
            // 
            this.txtPhoneInput.Location = new System.Drawing.Point(210, 230);
            this.txtPhoneInput.Name = "txtPhoneInput";
            this.txtPhoneInput.Size = new System.Drawing.Size(80, 20);
            this.txtPhoneInput.TabIndex = 10;
            // 
            // btnAddPhone
            // 
            this.btnAddPhone.Location = new System.Drawing.Point(210, 260);
            this.btnAddPhone.Name = "btnAddPhone";
            this.btnAddPhone.Size = new System.Drawing.Size(40, 30);
            this.btnAddPhone.TabIndex = 11;
            this.btnAddPhone.Text = "+";
            this.btnAddPhone.Click += new System.EventHandler(this.btnAddPhone_Click);
            // 
            // btnRemovePhone
            // 
            this.btnRemovePhone.Location = new System.Drawing.Point(250, 260);
            this.btnRemovePhone.Name = "btnRemovePhone";
            this.btnRemovePhone.Size = new System.Drawing.Size(40, 30);
            this.btnRemovePhone.TabIndex = 12;
            this.btnRemovePhone.Text = "-";
            this.btnRemovePhone.Click += new System.EventHandler(this.btnRemovePhone_Click);
            // 
            // lblKeywords
            // 
            this.lblKeywords.Location = new System.Drawing.Point(10, 300);
            this.lblKeywords.Name = "lblKeywords";
            this.lblKeywords.Size = new System.Drawing.Size(100, 23);
            this.lblKeywords.TabIndex = 13;
            this.lblKeywords.Text = "Palabras clave:";
            // 
            // listBoxKeywords
            // 
            this.listBoxKeywords.Location = new System.Drawing.Point(10, 320);
            this.listBoxKeywords.Name = "listBoxKeywords";
            this.listBoxKeywords.Size = new System.Drawing.Size(190, 69);
            this.listBoxKeywords.TabIndex = 14;
            // 
            // txtKeywordInput
            // 
            this.txtKeywordInput.Location = new System.Drawing.Point(210, 320);
            this.txtKeywordInput.Name = "txtKeywordInput";
            this.txtKeywordInput.Size = new System.Drawing.Size(80, 20);
            this.txtKeywordInput.TabIndex = 15;
            // 
            // btnAddKeyword
            // 
            this.btnAddKeyword.Location = new System.Drawing.Point(210, 350);
            this.btnAddKeyword.Name = "btnAddKeyword";
            this.btnAddKeyword.Size = new System.Drawing.Size(40, 30);
            this.btnAddKeyword.TabIndex = 16;
            this.btnAddKeyword.Text = "+";
            this.btnAddKeyword.Click += new System.EventHandler(this.btnAddKeyword_Click);
            // 
            // btnRemoveKeyword
            // 
            this.btnRemoveKeyword.Location = new System.Drawing.Point(250, 350);
            this.btnRemoveKeyword.Name = "btnRemoveKeyword";
            this.btnRemoveKeyword.Size = new System.Drawing.Size(40, 30);
            this.btnRemoveKeyword.TabIndex = 17;
            this.btnRemoveKeyword.Text = "-";
            this.btnRemoveKeyword.Click += new System.EventHandler(this.btnRemoveKeyword_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(10, 420);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(100, 420);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 19;
            this.btnModify.Text = "Modificar";
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(190, 420);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(10, 460);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 23);
            this.btnView.TabIndex = 21;
            this.btnView.Text = "Ver";
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(100, 460);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 22;
            this.btnClear.Text = "Limpiar";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.Location = new System.Drawing.Point(12, 12);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(100, 23);
            this.lblSearch.TabIndex = 2;
            this.lblSearch.Text = "Buscar (palabras clave):";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(160, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(300, 20);
            this.txtSearch.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(470, 10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.listViewContacts);
            this.Controls.Add(this.panelDetails);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Name = "Form1";
            this.Text = "Manejo de Contactos - Practica";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelDetails.ResumeLayout(false);
            this.panelDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}

