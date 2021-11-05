using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C.A.D.A_SOCIOS
{
    public class Socios
    {
        public int NumeroSocio { get; set; }
        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public int Nacimiento { get; set; }

        public  int Documento { get; set; }

        public int Edad { get; set; }

        public string Carnet { get; set; }

        public string Platea { get; set; }

        public string Estado { get; set; }

        public int UltimoSocio { get; set; } = 0; 

        public bool ValidarFecha()
        {
            bool resp = false;

            if (Nacimiento>1900 && Nacimiento<=DateTime.Now.Year)
            {
                resp = true; 
            }

            return resp; 
        }

        public DataTable DTS { get; set; } = new DataTable();

        public Socios()
        {
            DTS.TableName = "SOCIOS";
            DTS.Columns.Add("N°Socio");
            DTS.Columns.Add("Nombre");
            DTS.Columns.Add("Apellido");
            DTS.Columns.Add("Nacimiento");
            DTS.Columns.Add("Edad");
            DTS.Columns.Add("Documento");
            DTS.Columns.Add("Carnet");
            DTS.Columns.Add("Platea");
            DTS.Columns.Add("Estado");

        }
        public void LeerDTSArchivo()
        {
            if (System.IO.File.Exists("ListaSocios.xml"))
            {
                DTS.Clear();
                DTS.ReadXml("ListaSocios.xml");
                for (int i = 0; i < DTS.Rows.Count; i++)
                {
                    if (Convert.ToInt32(DTS.Rows[i]["N°Socio"])> UltimoSocio)
                    {
                        UltimoSocio = Convert.ToInt32(DTS.Rows[i]["N°Socio"]);
                    }
                }
            }
        }

        public void AgregarPersona()
        {
            bool resp = ValidarFecha();

            if (resp)
            {
                if (NumeroSocio==0)
                {
                    UltimoSocio = UltimoSocio + 1;
                    NumeroSocio = UltimoSocio;
                    DTS.Rows.Add();
                    int NumeroRegistroNuevo = DTS.Rows.Count - 1;
                    DTS.Rows[NumeroRegistroNuevo]["N°Socio"] = NumeroSocio.ToString();
                    DTS.Rows[NumeroRegistroNuevo]["Nombre"] = Nombre;
                    DTS.Rows[NumeroRegistroNuevo]["Apellido"] = Apellido;
                    DTS.Rows[NumeroRegistroNuevo]["Nacimiento"] = Nacimiento.ToString();
                    DTS.Rows[NumeroRegistroNuevo]["Edad"] = Edad.ToString();
                    DTS.Rows[NumeroRegistroNuevo]["Documento"] = Documento.ToString();
                    DTS.Rows[NumeroRegistroNuevo]["Carnet"] = Carnet;
                    DTS.Rows[NumeroRegistroNuevo]["Platea"] = Platea;
                    DTS.Rows[NumeroRegistroNuevo]["Estado"] = Estado;

                    DTS.WriteXml("ListaSocios.xml");

                }
                else
                {
                    for (int i = 0; i < DTS.Rows.Count; i++)
                    {
                        if (Convert.ToInt32(DTS.Rows[i]["N°Socio"])==NumeroSocio)
                        {
                            DTS.Rows[i]["N°Socio"] = NumeroSocio.ToString();
                            DTS.Rows[i]["Nombre"] = Nombre;
                            DTS.Rows[i]["Apellido"] = Apellido;
                            DTS.Rows[i]["Nacimiento"] = Nacimiento.ToString();
                            DTS.Rows[i]["Edad"] = Edad.ToString();
                            DTS.Rows[i]["Documento"] = Documento.ToString();
                            DTS.Rows[i]["Carnet"] = Carnet;
                            DTS.Rows[i]["Platea"] = Platea;
                            DTS.Rows[i]["Estado"] = Estado;

                            DTS.WriteXml("ListaSocios.xml");
                            break;
                        }
                    }
                }
            }
        }
    }
}
