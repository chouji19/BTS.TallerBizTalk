namespace BTS.TallerBizTalk.Esquemas.ConsumoServicios {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://BTS.TallerBizTalk.Esquemas.ConsumoServicios.ConsultaInmueblesResponse",@"ConsultaInmueblesResponse")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"ConsultaInmueblesResponse"})]
    public sealed class ConsultaInmueblesResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://BTS.TallerBizTalk.Esquemas.ConsumoServicios.ConsultaInmueblesResponse"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://BTS.TallerBizTalk.Esquemas.ConsumoServicios.ConsultaInmueblesResponse"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""ConsultaInmueblesResponse"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Respuesta"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""CodRespuesta"" type=""xs:string"" />
              <xs:element name=""Mensaje"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""Inmueble"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""Ciudad"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""IdCiudad"" type=""xs:int"" />
                    <xs:element name=""NombreCiudad"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""Departamento"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""IdDepartamento"" type=""xs:int"" />
                    <xs:element name=""NombreDepartamento"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""DatosBasicos"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""Direccion"" type=""xs:string"" />
                    <xs:element name=""Descripcion"" type=""xs:string"" />
                    <xs:element name=""ValorRentaSemanal"" type=""xs:decimal"" />
                    <xs:element name=""ValorSeguro"" type=""xs:decimal"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public ConsultaInmueblesResponse() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "ConsultaInmueblesResponse";
                return _RootElements;
            }
        }
        
        protected override object RawSchema {
            get {
                return _rawSchema;
            }
            set {
                _rawSchema = value;
            }
        }
    }
}
