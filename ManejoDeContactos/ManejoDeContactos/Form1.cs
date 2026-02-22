using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManejoDeContactos
{
    public partial class Form1 : Form
    {
        // Lista en memoria de contactos. En un proyecto real esto iría en una base de datos o archivo.
        private List<Contact> contacts = new List<Contact>();

        public Form1()
        {
            InitializeComponent();
            // Inicializar estado de la interfaz
            RefreshContactsList(contacts);
        }

        // Método para actualizar la vista de la lista de contactos.
        // Recibe una colección de contactos para permitir mostrar resultados de búsqueda.
        private void RefreshContactsList(IEnumerable<Contact> source)
        {
            listViewContacts.BeginUpdate();
            listViewContacts.Items.Clear();
            foreach (var c in source)
            {
                var item = new ListViewItem(new[] { c.DisplayName, c.Email });
                item.Tag = c; // guardamos el objeto para acceso posterior
                listViewContacts.Items.Add(item);
            }
            listViewContacts.EndUpdate();
        }

        // Limpia los controles del panel de detalles para ingresar un nuevo contacto.
        private void ClearDetailInputs()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtAddress.Clear();
            txtEmail.Clear();
            txtPhoneInput.Clear();
            listBoxPhones.Items.Clear();
            txtKeywordInput.Clear();
            listBoxKeywords.Items.Clear();
            listViewContacts.SelectedItems.Clear();
        }

        // Agregar teléfono desde el campo de entrada a la lista local (interfaz)
        private void btnAddPhone_Click(object sender, EventArgs e)
        {
            var phone = txtPhoneInput.Text.Trim();
            if (string.IsNullOrEmpty(phone)) return;
            if (!listBoxPhones.Items.Contains(phone))
                listBoxPhones.Items.Add(phone);
            txtPhoneInput.Clear();
        }

        private void btnRemovePhone_Click(object sender, EventArgs e)
        {
            if (listBoxPhones.SelectedItem != null)
                listBoxPhones.Items.Remove(listBoxPhones.SelectedItem);
        }

        // Agregar palabra clave a la lista local
        private void btnAddKeyword_Click(object sender, EventArgs e)
        {
            var kw = txtKeywordInput.Text.Trim();
            if (string.IsNullOrEmpty(kw)) return;
            if (!listBoxKeywords.Items.Contains(kw))
                listBoxKeywords.Items.Add(kw);
            txtKeywordInput.Clear();
        }

        private void btnRemoveKeyword_Click(object sender, EventArgs e)
        {
            if (listBoxKeywords.SelectedItem != null)
                listBoxKeywords.Items.Remove(listBoxKeywords.SelectedItem);
        }

        // Botón agregar nuevo contacto
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var first = txtFirstName.Text.Trim();
            var last = txtLastName.Text.Trim();
            if (string.IsNullOrEmpty(first) || string.IsNullOrEmpty(last))
            {
                MessageBox.Show("El nombre y apellido son obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verificar unicidad del nombre completo
            if (contacts.Any(c => string.Equals(c.FirstName, first, StringComparison.OrdinalIgnoreCase)
                && string.Equals(c.LastName, last, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Ya existe un contacto con ese nombre completo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var contact = new Contact
            {
                FirstName = first,
                LastName = last,
                Address = txtAddress.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Phones = listBoxPhones.Items.Cast<string>().ToList()
            };

            // Construir conjunto de palabras clave: nombre, apellido y las ingresadas por el usuario
            var kws = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            kws.Add(contact.FirstName);
            kws.Add(contact.LastName);
            foreach (var k in listBoxKeywords.Items.Cast<string>())
                kws.Add(k);
            contact.Keywords = kws;

            contacts.Add(contact);
            RefreshContactsList(contacts);
            ClearDetailInputs();
        }

        // Modificar contacto seleccionado
        private void btnModify_Click(object sender, EventArgs e)
        {
            if (listViewContacts.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione un contacto para modificar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var item = listViewContacts.SelectedItems[0];
            var contact = (Contact)item.Tag;

            var newFirst = txtFirstName.Text.Trim();
            var newLast = txtLastName.Text.Trim();
            if (string.IsNullOrEmpty(newFirst) || string.IsNullOrEmpty(newLast))
            {
                MessageBox.Show("El nombre y apellido son obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Si el nombre cambia, comprobar unicidad
            if (!string.Equals(contact.FirstName, newFirst, StringComparison.OrdinalIgnoreCase)
                || !string.Equals(contact.LastName, newLast, StringComparison.OrdinalIgnoreCase))
            {
                if (contacts.Any(c => c != contact && string.Equals(c.FirstName, newFirst, StringComparison.OrdinalIgnoreCase)
                    && string.Equals(c.LastName, newLast, StringComparison.OrdinalIgnoreCase)))
                {
                    MessageBox.Show("Otro contacto ya tiene ese nombre completo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            contact.FirstName = newFirst;
            contact.LastName = newLast;
            contact.Address = txtAddress.Text.Trim();
            contact.Email = txtEmail.Text.Trim();
            contact.Phones = listBoxPhones.Items.Cast<string>().ToList();

            // Reconstruir palabras clave: aseguramos incluir nombre y apellido
            var kws = new HashSet<string>(StringComparer.OrdinalIgnoreCase) { contact.FirstName, contact.LastName };
            foreach (var k in listBoxKeywords.Items.Cast<string>())
                kws.Add(k);
            contact.Keywords = kws;

            RefreshContactsList(contacts);
        }

        // Eliminar contacto
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listViewContacts.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione un contacto para eliminar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var item = listViewContacts.SelectedItems[0];
            var contact = (Contact)item.Tag;
            var res = MessageBox.Show($"¿Eliminar contacto '{contact.DisplayName}'?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                contacts.Remove(contact);
                RefreshContactsList(contacts);
                ClearDetailInputs();
            }
        }
         
        // Ver detalles del contacto: muestra un cuadro con la información formateada
        private void btnView_Click(object sender, EventArgs e)
        {
            if (listViewContacts.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione un contacto para ver.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var contact = (Contact)listViewContacts.SelectedItems[0].Tag;
            var sb = new StringBuilder();
            sb.AppendLine($"Nombre: {contact.DisplayName}");
            sb.AppendLine($"Dirección: {contact.Address}");
            sb.AppendLine($"Correo: {contact.Email}");
            sb.AppendLine("Teléfonos:");
            foreach (var p in contact.Phones)
                sb.AppendLine($"  - {p}");
            sb.AppendLine("Palabras clave: " + string.Join(", ", contact.Keywords));
            MessageBox.Show(sb.ToString(), "Detalles del contacto", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Buscar por palabras clave (separadas por espacios)
        private void btnSearch_Click(object sender, EventArgs e)
        {
            var q = txtSearch.Text.Trim();
            if (string.IsNullOrEmpty(q))
            {
                RefreshContactsList(contacts);
                return;
            }
            var terms = q.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var results = contacts.Where(c => terms.Any(t => c.Keywords.Any(k => k.IndexOf(t, StringComparison.OrdinalIgnoreCase) >= 0)));
            RefreshContactsList(results);
        }

        // Cuando se selecciona un contacto en la lista, mostramos sus datos en los controles para poder editarlos
        private void listViewContacts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewContacts.SelectedItems.Count == 0)
                return;
            var contact = (Contact)listViewContacts.SelectedItems[0].Tag;
            txtFirstName.Text = contact.FirstName;
            txtLastName.Text = contact.LastName;
            txtAddress.Text = contact.Address;
            txtEmail.Text = contact.Email;
            listBoxPhones.Items.Clear();
            foreach (var p in contact.Phones) listBoxPhones.Items.Add(p);
            listBoxKeywords.Items.Clear();
            // Mostrar las palabras clave que no sean el nombre o apellido (estas se gestionan automáticamente)
            foreach (var k in contact.Keywords)
            {
                if (!string.Equals(k, contact.FirstName, StringComparison.OrdinalIgnoreCase)
                    && !string.Equals(k, contact.LastName, StringComparison.OrdinalIgnoreCase))
                    listBoxKeywords.Items.Add(k);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearDetailInputs();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
