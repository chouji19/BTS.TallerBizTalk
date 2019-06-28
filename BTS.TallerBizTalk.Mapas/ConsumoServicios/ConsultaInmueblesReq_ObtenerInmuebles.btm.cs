namespace BTS.TallerBizTalk.Mapas.ConsumoServicios {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BTS.TallerBizTalk.Esquemas.ConsumoServicios.ConsultaInmueblesRequest", typeof(global::BTS.TallerBizTalk.Esquemas.ConsumoServicios.ConsultaInmueblesRequest))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BTS.TallerBizTalk.Esquemas.Operaciones.ServiciosInmobiliarios_tempuri_org+ObtenerInmuebles", typeof(global::BTS.TallerBizTalk.Esquemas.Operaciones.ServiciosInmobiliarios_tempuri_org.ObtenerInmuebles))]
    public sealed class ConsultaInmueblesReq_ObtenerInmuebles : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:ns0=""http://tempuri.org/"" xmlns:ns1=""http://schemas.datacontract.org/2004/07/ServiciosInmobiliarios.Models"" xmlns:s0=""http://BTS.TallerBizTalk.Esquemas.ConsumoServicios.ConsultaInmueblesRequest"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:ConsultaInmueblesRequest"" />
  </xsl:template>
  <xsl:template match=""/s0:ConsultaInmueblesRequest"">
    <ns0:ObtenerInmuebles>
      <ns0:request>
        <ns1:NumeroDocumento>
          <xsl:value-of select=""Identificacion/NumeroIdentificacion/text()"" />
        </ns1:NumeroDocumento>
        <ns1:TipoDocumento>
          <xsl:value-of select=""Identificacion/TipoIdentificacion/text()"" />
        </ns1:TipoDocumento>
      </ns0:request>
    </ns0:ObtenerInmuebles>
  </xsl:template>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"BTS.TallerBizTalk.Esquemas.ConsumoServicios.ConsultaInmueblesRequest";
        
        private const global::BTS.TallerBizTalk.Esquemas.ConsumoServicios.ConsultaInmueblesRequest _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"BTS.TallerBizTalk.Esquemas.Operaciones.ServiciosInmobiliarios_tempuri_org+ObtenerInmuebles";
        
        private const global::BTS.TallerBizTalk.Esquemas.Operaciones.ServiciosInmobiliarios_tempuri_org.ObtenerInmuebles _trgSchemaTypeReference0 = null;
        
        public override string XmlContent {
            get {
                return _strMap;
            }
        }
        
        public override int UseXSLTransform {
            get {
                return _useXSLTransform;
            }
        }
        
        public override string XsltArgumentListContent {
            get {
                return _strArgList;
            }
        }
        
        public override string[] SourceSchemas {
            get {
                string[] _SrcSchemas = new string [1];
                _SrcSchemas[0] = @"BTS.TallerBizTalk.Esquemas.ConsumoServicios.ConsultaInmueblesRequest";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"BTS.TallerBizTalk.Esquemas.Operaciones.ServiciosInmobiliarios_tempuri_org+ObtenerInmuebles";
                return _TrgSchemas;
            }
        }
    }
}
