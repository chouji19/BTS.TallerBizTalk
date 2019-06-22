using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTS.TallerBizTalk.Utilidades
{
    public class Utils
    {
        public string TipoDocumento(string tipoDocumento)
        {
            switch (tipoDocumento)
            {
                case "CC":
                    return "Cédula Ciudadanía";
                case "NIT":
                    return "Número de Identificación Tributaria";
                case "RC":
                    return "Registro Civil";
                default:
                    return "Tipo Documento no encontrado";
            }
        }
    }
}
