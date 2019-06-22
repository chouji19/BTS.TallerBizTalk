namespace BTS.TallerBizTalk.Esquemas.Operaciones {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://BTS.TallerBizTalk.Esquemas.Operaciones.OperacionesEntrada",@"OperacionesEntrada")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"OperacionesEntrada"})]
    public sealed class OperacionesEntrada : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://BTS.TallerBizTalk.Esquemas.Operaciones.OperacionesEntrada"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://BTS.TallerBizTalk.Esquemas.Operaciones.OperacionesEntrada"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""OperacionesEntrada"">
    <xs:complexType>
      <xs:sequence>
        <xs:element maxOccurs=""unbounded"" name=""Maximo"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""Valor1"" type=""xs:int"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""DatoFecha"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""FechaInicial"" type=""xs:date"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""FunctoidsLogicos"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""Valor2"" type=""xs:int"" />
              <xs:element name=""Valor3"" type=""xs:int"" />
              <xs:element name=""Valor4"" type=""xs:int"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""OperacionesBasicas"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""Valor5"" type=""xs:int"" />
              <xs:element name=""Valor6"" type=""xs:int"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""OperacionesString"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""Valor7"" type=""xs:string"" />
              <xs:element name=""Valor8"" type=""xs:string"" />
              <xs:element name=""Valor9"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public OperacionesEntrada() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "OperacionesEntrada";
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
