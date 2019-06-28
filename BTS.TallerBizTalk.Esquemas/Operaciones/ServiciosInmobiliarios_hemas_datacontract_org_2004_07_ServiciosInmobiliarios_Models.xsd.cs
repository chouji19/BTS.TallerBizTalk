namespace BTS.TallerBizTalk.Esquemas.Operaciones {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"InmuebleRequest", @"InmuebleResponse", @"Encabezado", @"ArrayOfInmueble", @"Inmueble"})]
    public sealed class ServiciosInmobiliarios_hemas_datacontract_org_2004_07_ServiciosInmobiliarios_Models : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:tns=""http://schemas.datacontract.org/2004/07/ServiciosInmobiliarios.Models"" elementFormDefault=""qualified"" targetNamespace=""http://schemas.datacontract.org/2004/07/ServiciosInmobiliarios.Models"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:complexType name=""InmuebleRequest"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""NumeroDocumento"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""TipoDocumento"" nillable=""true"" type=""xs:string"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""InmuebleRequest"" nillable=""true"" type=""tns:InmuebleRequest"" />
  <xs:complexType name=""InmuebleResponse"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""Encabezado"" nillable=""true"" type=""tns:Encabezado"" />
      <xs:element minOccurs=""0"" name=""Inmuebles"" nillable=""true"" type=""tns:ArrayOfInmueble"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""InmuebleResponse"" nillable=""true"" type=""tns:InmuebleResponse"" />
  <xs:complexType name=""Encabezado"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CodigoRespuest"" type=""xs:int"" />
      <xs:element minOccurs=""0"" name=""Mensaje"" nillable=""true"" type=""xs:string"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""Encabezado"" nillable=""true"" type=""tns:Encabezado"" />
  <xs:complexType name=""ArrayOfInmueble"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""Inmueble"" nillable=""true"" type=""tns:Inmueble"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfInmueble"" nillable=""true"" type=""tns:ArrayOfInmueble"" />
  <xs:complexType name=""Inmueble"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""Ciudad"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""CodigoCiudad"" type=""xs:int"" />
      <xs:element minOccurs=""0"" name=""CodigoDepartamento"" type=""xs:int"" />
      <xs:element minOccurs=""0"" name=""CodigoPostal"" type=""xs:int"" />
      <xs:element minOccurs=""0"" name=""Departamento"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""Descripcion"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""Direccion"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""IdInmueble"" type=""xs:int"" />
      <xs:element minOccurs=""0"" name=""ValorRentaSemanal"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""ValorSeguro"" type=""xs:decimal"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""Inmueble"" nillable=""true"" type=""tns:Inmueble"" />
</xs:schema>";
        
        public ServiciosInmobiliarios_hemas_datacontract_org_2004_07_ServiciosInmobiliarios_Models() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [5];
                _RootElements[0] = "InmuebleRequest";
                _RootElements[1] = "InmuebleResponse";
                _RootElements[2] = "Encabezado";
                _RootElements[3] = "ArrayOfInmueble";
                _RootElements[4] = "Inmueble";
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
        
        [Schema(@"http://schemas.datacontract.org/2004/07/ServiciosInmobiliarios.Models",@"InmuebleRequest")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"InmuebleRequest"})]
        public sealed class InmuebleRequest : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public InmuebleRequest() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "InmuebleRequest";
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
        
        [Schema(@"http://schemas.datacontract.org/2004/07/ServiciosInmobiliarios.Models",@"InmuebleResponse")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"InmuebleResponse"})]
        public sealed class InmuebleResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public InmuebleResponse() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "InmuebleResponse";
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
        
        [Schema(@"http://schemas.datacontract.org/2004/07/ServiciosInmobiliarios.Models",@"Encabezado")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Encabezado"})]
        public sealed class Encabezado : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Encabezado() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Encabezado";
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
        
        [Schema(@"http://schemas.datacontract.org/2004/07/ServiciosInmobiliarios.Models",@"ArrayOfInmueble")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfInmueble"})]
        public sealed class ArrayOfInmueble : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfInmueble() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfInmueble";
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
        
        [Schema(@"http://schemas.datacontract.org/2004/07/ServiciosInmobiliarios.Models",@"Inmueble")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Inmueble"})]
        public sealed class Inmueble : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Inmueble() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Inmueble";
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
}
