using Microsoft.VisualBasic;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    internal static class Concecionaria
    {

        static Dictionary<Auto,Persona> Registro_Autos = new Dictionary<Auto,Persona>();

        public static void Agregar( Auto newA, Persona newP , DataGridView dgv )
        {
            try
            {
                if (newA == null && newP == null)
                {
                    throw new ArgumentNullException("No se puede agregar un auto ni persona nula.");
                }
                if (newA != null && newP != null)
                {
                    Registro_Autos.Add(newA,newP);
                }
                if (newA == null )
                {
                    Auto autoVacio = new Auto();
                    if (Registro_Autos.ToList().Exists( persona => persona.Value._dni == newP._dni )) throw new Exception("[Error] Ya existe esta persona");
                    Registro_Autos.Add(autoVacio,newP);
                    Cargar_Personas(dgv);
                    return;
                }
                if (newP == null )
                {
                    Persona pVacio = new Persona();
                    Registro_Autos.Add(newA,pVacio);
                    Cargar_Autos(dgv);
                    return;
                }
            }
            catch( Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void Cargar_Personas( DataGridView dgv )
        {
            try
            {
                dgv.Rows.Clear();
                Registro_Autos.Values
                    .Where(persona => persona != null && persona._dni != null)
                    .Distinct()
                    .ToList()
                    .ForEach(p =>
                    {
                        dgv.Rows.Add(p._nombre, p._apellido,p._dni);
                    });
            }
            catch( Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void Cargar_Autos(DataGridView dgv)
        {
            try
            {
                dgv.Rows.Clear();

                Registro_Autos
                    .Where(auto => auto.Key._patente != null )
                    .ToList()
                    .ForEach(p =>
                    {
                        dgv.Rows.Add(
                            p.Key._patente,
                            p.Key._marca,
                            p.Key._modelo,
                            p.Key._año,
                            p.Key._precio
                        );
                    });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void Asignar(DataGridView dgv_Autos, DataGridView dgv_Personas)
        {
            try
            {
                if (dgv_Autos.SelectedRows.Count == 0 || dgv_Personas.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar un auto y una persona.");
                    return;
                }


                var rowAuto = dgv_Autos.SelectedRows[0];
                string patente = rowAuto.Cells["_Patente"].Value?.ToString(); 


                var rowPersona = dgv_Personas.SelectedRows[0];
                string dni = rowPersona.Cells["_DNI"].Value?.ToString(); 


                Auto autoSeleccionado = Registro_Autos.Keys.FirstOrDefault(a => a._patente == patente);
                if (autoSeleccionado == null)
                {
                    MessageBox.Show("Auto no encontrado.");
                    return;
                }


                Persona personaSeleccionada = Registro_Autos.Values.FirstOrDefault(p => p != null && p._dni == dni);
                if (personaSeleccionada == null)
                {
                    MessageBox.Show("Persona no encontrada.");
                    return;
                }


                Registro_Autos[autoSeleccionado] = personaSeleccionada;

                MessageBox.Show("¡Persona asignada al auto correctamente!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        public static void Autos_Seleccionados_Persona( DataGridView dgv , DataGridView dgv_Persona)
        {
            try
            {
                dgv.Rows.Clear();
                if (dgv_Persona.SelectedRows.Count == 0)
                {
                    dgv.Rows.Clear();
                }
                else
                {
                    DataGridViewRow row = dgv_Persona.SelectedRows[0];
                    var dni = row.Cells["_DNI"].Value.ToString();
                    Registro_Autos
                        .Where(auto => auto.Key._patente != null && auto.Value._dni != null && auto.Value._dni == dni)
                        .ToList()
                        .ForEach(p =>
                        {
                            dgv.Rows.Add(
                        p.Key._patente,
                        p.Key._marca,
                        p.Key._modelo,
                        p.Key._año,
                        p.Key._precio);
                        });
                }
            }
            catch( Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void Autos_Con_Dueño( DataGridView dgv )
        {
            try
            {
                dgv.Rows.Clear();
                Registro_Autos
                    .Where(Entry => Entry.Key._patente != null && Entry.Value._dni != null)
                    .Distinct()
                    .ToList()
                    .ForEach(Entry =>
                    {
                        dgv.Rows.Add( Entry.Key._marca , Entry.Key._año , Entry.Key._modelo, Entry.Key._patente, Entry.Value._dni,$"{Entry.Value._nombre},{Entry.Value._apellido}");
                    });
            }
            catch( Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void Eliminar_Persona( DataGridView DGV_Persona , DataGridView autos_Con_Dueño , DataGridView autos_De_Persona)
        {
            try
            {

                if (DGV_Persona.SelectedRows.Count == 0) throw new ArgumentException();

                var dni = DGV_Persona.SelectedRows[0].Cells["_DNI"].Value;
                if (dni is null) throw new ArgumentNullException(" [Error] No se encontro DNI en el DataGridView Persona ");

                DGV_Persona.Rows.Clear();
                autos_Con_Dueño.Rows.Clear();

                Registro_Autos
                    .Where(persona => persona.Value != null && persona.Value._dni == dni)
                    .Select( auto => auto.Key )
                    .Distinct()
                    .ToList()
                    .ForEach( auto => 
                                        {
                                            Registro_Autos[auto] = new Persona(null, null, null);
                                        });


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);    
            }
            finally
            {
                Cargar_Personas(DGV_Persona);
                Autos_Con_Dueño(autos_Con_Dueño);
                Autos_Seleccionados_Persona(DGV_Persona,autos_De_Persona);
            }
        }
        public static void Eliminar_Autos(DataGridView DGV_Autos)
        {
            try
            {
                if (DGV_Autos.SelectedRows.Count == 0)
                    throw new ArgumentOutOfRangeException("[Error] Seleccione un auto para eliminar.");

                var patente = DGV_Autos.SelectedRows[0].Cells["_Patente"].Value?.ToString();

                if (string.IsNullOrWhiteSpace(patente))
                    throw new ArgumentNullException("[Error] Patente inválida o vacía.");

                // Buscar el auto sin dueño real
                var auto = Registro_Autos
                    .Where(entry =>
                        entry.Key != null &&
                        entry.Key._patente == patente &&
                        (entry.Value == null || string.IsNullOrWhiteSpace(entry.Value._dni)))
                    .Select(entry => entry.Key)
                    .FirstOrDefault();

                if (auto == null)
                {
                    MessageBox.Show("[Error] Este auto tiene dueño y no puede ser eliminado.");
                    return;
                }

                Registro_Autos.Remove(auto);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                
            }
        }
        public static void Modificar_Autos( DataGridView DGV_Autos , DataGridView DGV_Autos_Con_Dueño ,DataGridView DGV_Autos_De_Persona , DataGridView DGV_Persona)
        {
            try
            {
                if (DGV_Autos.SelectedRows.Count == 0) throw new ArgumentOutOfRangeException("[ERROR] fuera de rango","Error");
                var patente = DGV_Autos.SelectedRows[0].Cells["_Patente"].Value.ToString();
                var Entry = Registro_Autos.FirstOrDefault( Entry => patente == Entry.Key._patente );

                if (Entry.Key == null) throw new InvalidOperationException("Auto no encontrado en el registro.");

                string pat = Interaction.InputBox("Ingrese Patente");
                string mar = Interaction.InputBox("Ingrese la Marca");
                string mo = Interaction.InputBox("Ingrese la Modelo");
                string pre = Interaction.InputBox("Ingrese el Precio");
                string an = Interaction.InputBox("Ingrese el Año");

                Auto newA = new(pat,mar,mo,an,pre);
                Persona newP = new(Entry.Value);

                Registro_Autos.Remove(Entry.Key);
                Registro_Autos[newA] = newP;

                MessageBox.Show("Auto modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                DGV_Autos.Rows.Clear();
                DGV_Autos_Con_Dueño.Rows.Clear();
                DGV_Autos_De_Persona.Rows.Clear();
                Cargar_Autos(DGV_Autos);
                Autos_Con_Dueño(DGV_Autos_Con_Dueño);
                Autos_Seleccionados_Persona(DGV_Autos_De_Persona, DGV_Persona);
            }
        }
        public static void Modificar_Personas( DataGridView DGV_Persona , DataGridView DGV_Autos_Con_Dueño )
        {
            try
            {
                if (DGV_Persona.SelectedRows.Count == 0) throw new ArgumentOutOfRangeException("[ERROR] Seleccione una persona ");

                var dni = DGV_Persona.SelectedRows[0].Cells["_dni"].Value as string;
                if (dni == null) throw new ArgumentNullException("[ERROR]DNI seleccionado invalido");
                var Entry = Registro_Autos.FirstOrDefault( Entry => Entry.Value._dni == dni).Value;

                string nombre = Interaction.InputBox("Ingrese un nombre");
                string apellido = Interaction.InputBox("Ingrese un apellido");
                string d = Interaction.InputBox("Ingrese un dni");

                Entry._nombre = nombre;
                Entry._apellido = apellido;
                Entry._dni = d;
                   

                MessageBox.Show("Persona modificada correctamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch ( Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                DGV_Persona.Rows.Clear();
                DGV_Autos_Con_Dueño.Rows.Clear();

                Cargar_Personas(DGV_Persona);
                Autos_Con_Dueño(DGV_Autos_Con_Dueño);
            }
        }
    }
}
