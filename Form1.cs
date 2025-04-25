using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

namespace TP1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DGV_PERSONA.Columns.Add("_Nombre", "Nombre");
            DGV_PERSONA.Columns.Add("_Apellido", "Apellido");
            DGV_PERSONA.Columns.Add("_DNI", "DNI");
            DGV_PERSONA.AllowUserToAddRows = false;
            DGV_PERSONA.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            DGV_Autos.Columns.Add("_Patente", "Patente");
            DGV_Autos.Columns.Add("_Marca", "Marca");
            DGV_Autos.Columns.Add("_Modelo", "Modelo");
            DGV_Autos.Columns.Add("_Año", "Año");
            DGV_Autos.Columns.Add("_Precio", "Precio");
            DGV_Autos.AllowUserToAddRows = false;
            DGV_Autos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            DGV_AUTOS_PERSONA.Columns.Add("_Patente", "Patente");
            DGV_AUTOS_PERSONA.Columns.Add("_Marca", "Marca");
            DGV_AUTOS_PERSONA.Columns.Add("_Modelo", "Modelo");
            DGV_AUTOS_PERSONA.Columns.Add("_Año", "Año");
            DGV_AUTOS_PERSONA.Columns.Add("_Precio", "Precio");
            DGV_AUTOS_PERSONA.AllowUserToAddRows = false;

            DGV_Autos_Con_Dueño.Columns.Add("_Marca", "Marca");
            DGV_Autos_Con_Dueño.Columns.Add("_Año", "Año");
            DGV_Autos_Con_Dueño.Columns.Add("_Modelo", "Modelo");
            DGV_Autos_Con_Dueño.Columns.Add("_Patente", "Patente");
            DGV_Autos_Con_Dueño.Columns.Add("_Dni", "DNI");
            DGV_Autos_Con_Dueño.Columns.Add("_Dueño", "Dueño");
            DGV_Autos_Con_Dueño.AllowUserToAddRows = false;
        }

        private void BTN_Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(TXT_APELLIDO.Text) && !string.IsNullOrEmpty(TXT_DNI.Text) && !string.IsNullOrEmpty(TXT_NOMBRE.Text))
                {
                    Persona newP = new Persona(TXT_NOMBRE.Text, TXT_APELLIDO.Text, TXT_DNI.Text);
                    Concecionaria.Agregar(null, newP, DGV_PERSONA);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BTN_Agregar_Auto_Click(object sender, EventArgs e)
        {
            try
            {
                if (
                    !string.IsNullOrEmpty(TXT_Marca.Text) &&
                    !string.IsNullOrEmpty(TXT_Modelo.Text) &&
                    !string.IsNullOrEmpty(TXT_Año.Text) &&
                    !string.IsNullOrEmpty(TXT_Patente.Text) &&
                    !string.IsNullOrEmpty(TXT_Precio.Text)
                    )
                {
                    Auto newA = new Auto(TXT_Patente.Text, TXT_Marca.Text, TXT_Modelo.Text, TXT_Año.Text, TXT_Precio.Text);
                    Concecionaria.Agregar(newA, null, DGV_Autos);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void DGV_PERSONA_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Concecionaria.Autos_Seleccionados_Persona(DGV_AUTOS_PERSONA, DGV_PERSONA);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Concecionaria.Asignar(DGV_Autos, DGV_PERSONA);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Concecionaria.Autos_Seleccionados_Persona(DGV_AUTOS_PERSONA, DGV_PERSONA);
                Concecionaria.Autos_Con_Dueño(DGV_Autos_Con_Dueño);
            }
        }

        private void BTN_Eliminar_Persona_Click(object sender, EventArgs e)
        {
            try
            {
                Concecionaria.Eliminar_Persona(DGV_PERSONA, DGV_Autos_Con_Dueño, DGV_AUTOS_PERSONA);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                DGV_AUTOS_PERSONA.Rows.Clear();
            }
        }

        private void BTN_Eliminar_Auto_Click(object sender, EventArgs e)
        {
            try
            {
                Concecionaria.Eliminar_Autos(DGV_Autos);
                Concecionaria.Autos_Seleccionados_Persona(DGV_AUTOS_PERSONA, DGV_PERSONA);
                Concecionaria.Cargar_Autos(DGV_Autos);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BTN_Modificar_Persona_Click(object sender, EventArgs e)
        {
            try
            {
                Concecionaria.Modificar_Personas(DGV_PERSONA, DGV_Autos_Con_Dueño);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BTN_Modificar_Auto_Click(object sender, EventArgs e)
        {
            try
            {
                Concecionaria.Modificar_Autos(DGV_Autos,DGV_Autos_Con_Dueño,DGV_AUTOS_PERSONA , DGV_PERSONA);
            }
            catch( Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
