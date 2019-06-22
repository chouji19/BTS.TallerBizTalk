namespace BTS.TallerBizTalk.Esquemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://BTS.TallerBizTalk.Esquemas.ClienteRequest",@"ClienteRequest")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"ClienteRequest"})]
    public sealed class ClienteRequest : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://BTS.TallerBizTalk.Esquemas.ClienteRequest"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://BTS.TallerBizTalk.Esquemas.ClienteRequest"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""ClienteRequest"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""1"" maxOccurs=""1"" name=""Identificacion"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""NumeroIdentificacion"" type=""xs:int"" />
              <xs:element name=""TipoIdentificacion"" type=""xs:string"" />
            </xs:sequence>
            <xs:attribute name=""Id"" type=""xs:string"" />
          </xs:complexType>
        </xs:element>
        <xs:choice minOccurs=""0"">
          <xs:element name=""PersonaJuridica"">
            <xs:complexType>
              <xs:sequence>
                <xs:element name=""RazonSocial"" type=""xs:string"" />
              </xs:sequence>
            </xs:complexType>
          </xs:element>
          <xs:element name=""PersonaNatural"">
            <xs:complexType>
              <xs:sequence>
                <xs:element name=""Nombres"" type=""xs:string"" />
                <xs:element name=""Apellidos"" type=""xs:string"" />
              </xs:sequence>
            </xs:complexType>
          </xs:element>
        </xs:choice>
        <xs:element name=""DatosBasicos"">
          <xs:complexType>
            <xs:sequence>
              <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Email"" type=""xs:string"" />
              <xs:element name=""Telefono"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public ClienteRequest() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "ClienteRequest";
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
