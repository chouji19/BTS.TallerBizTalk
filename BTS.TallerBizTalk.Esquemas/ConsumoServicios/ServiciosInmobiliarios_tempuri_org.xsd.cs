namespace BTS.TallerBizTalk.Esquemas.Operaciones {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"ObtenerInmueblesResponse", @"ObtenerInmuebles"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BTS.TallerBizTalk.Esquemas.Operaciones.ServiciosInmobiliarios_hemas_datacontract_org_2004_07_ServiciosInmobiliarios_Models", typeof(global::BTS.TallerBizTalk.Esquemas.Operaciones.ServiciosInmobiliarios_hemas_datacontract_org_2004_07_ServiciosInmobiliarios_Models))]
    public sealed class ServiciosInmobiliarios_tempuri_org : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:tns=""http://tempuri.org/"" elementFormDefault=""qualified"" targetNamespace=""http://tempuri.org/"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:import schemaLocation=""BTS.TallerBizTalk.Esquemas.Operaciones.ServiciosInmobiliarios_hemas_datacontract_org_2004_07_ServiciosInmobiliarios_Models"" namespace=""http://schemas.datacontract.org/2004/07/ServiciosInmobiliarios.Models"" />
  <xs:annotation>
    <xs:appinfo>
      <b:references>
        <b:reference targetNamespace=""http://schemas.datacontract.org/2004/07/ServiciosInmobiliarios.Models"" />
      </b:references>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""ObtenerInmueblesResponse"">
    <xs:complexType>
      <xs:sequence>
        <xs:element xmlns:q2=""http://schemas.datacontract.org/2004/07/ServiciosInmobiliarios.Models"" minOccurs=""0"" name=""ObtenerInmueblesResult"" nillable=""true"" type=""q2:InmuebleResponse"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""ObtenerInmuebles"">
    <xs:complexType>
      <xs:sequence>
        <xs:element xmlns:q1=""http://schemas.datacontract.org/2004/07/ServiciosInmobiliarios.Models"" minOccurs=""0"" name=""request"" nillable=""true"" type=""q1:InmuebleRequest"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public ServiciosInmobiliarios_tempuri_org() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [2];
                _RootElements[0] = "ObtenerInmueblesResponse";
                _RootElements[1] = "ObtenerInmuebles";
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
        
        [Schema(@"http://tempuri.org/",@"ObtenerInmueblesResponse")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ObtenerInmueblesResponse"})]
        public sealed class ObtenerInmueblesResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ObtenerInmueblesResponse() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ObtenerInmueblesResponse";
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
        
        [Schema(@"http://tempuri.org/",@"ObtenerInmuebles")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ObtenerInmuebles"})]
        public sealed class ObtenerInmuebles : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ObtenerInmuebles() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ObtenerInmuebles";
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
