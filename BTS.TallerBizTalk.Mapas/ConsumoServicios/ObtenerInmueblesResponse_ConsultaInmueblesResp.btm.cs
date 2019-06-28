namespace BTS.TallerBizTalk.Mapas.ConsumoServicios {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BTS.TallerBizTalk.Esquemas.Operaciones.ServiciosInmobiliarios_tempuri_org+ObtenerInmueblesResponse", typeof(global::BTS.TallerBizTalk.Esquemas.Operaciones.ServiciosInmobiliarios_tempuri_org.ObtenerInmueblesResponse))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BTS.TallerBizTalk.Esquemas.ConsumoServicios.ConsultaInmueblesResponse", typeof(global::BTS.TallerBizTalk.Esquemas.ConsumoServicios.ConsultaInmueblesResponse))]
    public sealed class ObtenerInmueblesResponse_ConsultaInmueblesResp : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 s1"" version=""1.0"" xmlns:s1=""http://tempuri.org/"" xmlns:ns0=""http://BTS.TallerBizTalk.Esquemas.ConsumoServicios.ConsultaInmueblesResponse"" xmlns:s0=""http://schemas.datacontract.org/2004/07/ServiciosInmobiliarios.Models"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s1:ObtenerInmueblesResponse"" />
  </xsl:template>
  <xsl:template match=""/s1:ObtenerInmueblesResponse"">
    <ns0:ConsultaInmueblesResponse>
      <xsl:for-each select=""s1:ObtenerInmueblesResult"">
        <xsl:for-each select=""s0:Encabezado"">
          <Respuesta>
            <xsl:if test=""s0:CodigoRespuest"">
              <CodRespuesta>
                <xsl:value-of select=""s0:CodigoRespuest/text()"" />
              </CodRespuesta>
            </xsl:if>
            <xsl:if test=""s0:Mensaje"">
              <Mensaje>
                <xsl:value-of select=""s0:Mensaje/text()"" />
              </Mensaje>
            </xsl:if>
          </Respuesta>
        </xsl:for-each>
      </xsl:for-each>
      <xsl:for-each select=""s1:ObtenerInmueblesResult"">
        <xsl:for-each select=""s0:Inmuebles"">
          <xsl:for-each select=""s0:Inmueble"">
            <Inmueble>
              <Ciudad>
                <xsl:if test=""s0:CodigoCiudad"">
                  <IdCiudad>
                    <xsl:value-of select=""s0:CodigoCiudad/text()"" />
                  </IdCiudad>
                </xsl:if>
                <xsl:if test=""s0:Ciudad"">
                  <NombreCiudad>
                    <xsl:value-of select=""s0:Ciudad/text()"" />
                  </NombreCiudad>
                </xsl:if>
              </Ciudad>
              <Departamento>
                <xsl:if test=""s0:CodigoDepartamento"">
                  <IdDepartamento>
                    <xsl:value-of select=""s0:CodigoDepartamento/text()"" />
                  </IdDepartamento>
                </xsl:if>
                <xsl:if test=""s0:Departamento"">
                  <NombreDepartamento>
                    <xsl:value-of select=""s0:Departamento/text()"" />
                  </NombreDepartamento>
                </xsl:if>
              </Departamento>
              <DatosBasicos>
                <xsl:if test=""s0:IdInmueble"">
                  <Direccion>
                    <xsl:value-of select=""s0:IdInmueble/text()"" />
                  </Direccion>
                </xsl:if>
                <xsl:if test=""s0:Descripcion"">
                  <Descripcion>
                    <xsl:value-of select=""s0:Descripcion/text()"" />
                  </Descripcion>
                </xsl:if>
                <xsl:if test=""s0:ValorRentaSemanal"">
                  <ValorRentaSemanal>
                    <xsl:value-of select=""s0:ValorRentaSemanal/text()"" />
                  </ValorRentaSemanal>
                </xsl:if>
                <xsl:if test=""s0:ValorSeguro"">
                  <ValorSeguro>
                    <xsl:value-of select=""s0:ValorSeguro/text()"" />
                  </ValorSeguro>
                </xsl:if>
              </DatosBasicos>
            </Inmueble>
          </xsl:for-each>
        </xsl:for-each>
      </xsl:for-each>
    </ns0:ConsultaInmueblesResponse>
  </xsl:template>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"BTS.TallerBizTalk.Esquemas.Operaciones.ServiciosInmobiliarios_tempuri_org+ObtenerInmueblesResponse";
        
        private const global::BTS.TallerBizTalk.Esquemas.Operaciones.ServiciosInmobiliarios_tempuri_org.ObtenerInmueblesResponse _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"BTS.TallerBizTalk.Esquemas.ConsumoServicios.ConsultaInmueblesResponse";
        
        private const global::BTS.TallerBizTalk.Esquemas.ConsumoServicios.ConsultaInmueblesResponse _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"BTS.TallerBizTalk.Esquemas.Operaciones.ServiciosInmobiliarios_tempuri_org+ObtenerInmueblesResponse";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"BTS.TallerBizTalk.Esquemas.ConsumoServicios.ConsultaInmueblesResponse";
                return _TrgSchemas;
            }
        }
    }
}
