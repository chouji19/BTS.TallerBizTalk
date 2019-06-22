namespace BTS.TallerBizTalk.Mapas.Operaciones {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BTS.TallerBizTalk.Esquemas.Operaciones.OperacionesEntrada", typeof(global::BTS.TallerBizTalk.Esquemas.Operaciones.OperacionesEntrada))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BTS.TallerBizTalk.Esquemas.Operaciones.OperacionesSalida", typeof(global::BTS.TallerBizTalk.Esquemas.Operaciones.OperacionesSalida))]
    public sealed class OperacionesEntrada_OperacionesSalida : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp ScriptNS0"" version=""1.0"" xmlns:ns0=""http://BTS.TallerBizTalk.Esquemas.Operaciones.OperacionesSalida"" xmlns:s0=""http://BTS.TallerBizTalk.Esquemas.Operaciones.OperacionesEntrada"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"" xmlns:ScriptNS0=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS0"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:OperacionesEntrada"" />
  </xsl:template>
  <xsl:template match=""/s0:OperacionesEntrada"">
    <xsl:variable name=""var:v4"" select=""userCSharp:DateAddDays(string(DatoFecha/FechaInicial/text()) , &quot;5&quot;)"" />
    <xsl:variable name=""var:v5"" select=""userCSharp:LogicalEq(string(FunctoidsLogicos/Valor2/text()) , string(FunctoidsLogicos/Valor3/text()))"" />
    <xsl:variable name=""var:v7"" select=""string(FunctoidsLogicos/Valor3/text())"" />
    <xsl:variable name=""var:v8"" select=""userCSharp:LogicalNe($var:v7 , &quot;10&quot;)"" />
    <xsl:variable name=""var:v10"" select=""userCSharp:LogicalGt($var:v7 , &quot;10&quot;)"" />
    <xsl:variable name=""var:v11"" select=""userCSharp:LogicalGt(string(FunctoidsLogicos/Valor4/text()) , &quot;10&quot;)"" />
    <xsl:variable name=""var:v12"" select=""userCSharp:LogicalAnd(string($var:v10) , string($var:v11))"" />
    <xsl:variable name=""var:v14"" select=""userCSharp:LogicalNot(string($var:v12))"" />
    <xsl:variable name=""var:v16"" select=""userCSharp:MathMax(string(OperacionesBasicas/Valor5/text()) , string(OperacionesBasicas/Valor6/text()))"" />
    <xsl:variable name=""var:v17"" select=""string(OperacionesBasicas/Valor5/text())"" />
    <xsl:variable name=""var:v18"" select=""string(OperacionesBasicas/Valor6/text())"" />
    <xsl:variable name=""var:v19"" select=""userCSharp:MathMultiply($var:v17 , $var:v18)"" />
    <xsl:variable name=""var:v20"" select=""userCSharp:StringUpperCase(string(OperacionesString/Valor7/text()))"" />
    <xsl:variable name=""var:v21"" select=""userCSharp:StringLeft(string(OperacionesString/Valor8/text()) , &quot;6&quot;)"" />
    <ns0:OperacionesSalida>
      <Maximo>
        <xsl:variable name=""var:v1"" select=""userCSharp:InitCumulativeMax(0)"" />
        <xsl:for-each select=""/s0:OperacionesEntrada/Maximo"">
          <xsl:variable name=""var:v2"" select=""userCSharp:AddToCumulativeMax(0,string(Valor1/text()),&quot;1000&quot;)"" />
        </xsl:for-each>
        <xsl:variable name=""var:v3"" select=""userCSharp:GetCumulativeMax(0)"" />
        <ValorMayor>
          <xsl:value-of select=""$var:v3"" />
        </ValorMayor>
      </Maximo>
      <DatoFecha>
        <FechaFinal>
          <xsl:value-of select=""$var:v4"" />
        </FechaFinal>
      </DatoFecha>
      <FunctoidsLogicos>
        <xsl:if test=""string($var:v5)='true'"">
          <xsl:variable name=""var:v6"" select=""FunctoidsLogicos/Valor2/text()"" />
          <Resultado1>
            <xsl:value-of select=""$var:v6"" />
          </Resultado1>
        </xsl:if>
        <xsl:if test=""string($var:v8)='true'"">
          <xsl:variable name=""var:v9"" select=""FunctoidsLogicos/Valor3/text()"" />
          <Resultado2>
            <xsl:value-of select=""$var:v9"" />
          </Resultado2>
        </xsl:if>
        <xsl:if test=""string($var:v12)='true'"">
          <xsl:variable name=""var:v13"" select=""FunctoidsLogicos/Valor4/text()"" />
          <Resultado3>
            <xsl:value-of select=""$var:v13"" />
          </Resultado3>
        </xsl:if>
        <xsl:if test=""string($var:v14)='true'"">
          <xsl:variable name=""var:v15"" select=""FunctoidsLogicos/Valor2/text()"" />
          <Resultado3>
            <xsl:value-of select=""$var:v15"" />
          </Resultado3>
        </xsl:if>
      </FunctoidsLogicos>
      <OperacionesBasicas>
        <Resultado4>
          <xsl:value-of select=""$var:v16"" />
        </Resultado4>
        <Resultado5>
          <xsl:value-of select=""$var:v19"" />
        </Resultado5>
      </OperacionesBasicas>
      <OperacionesStrings>
        <ValorMayusculas>
          <xsl:value-of select=""$var:v20"" />
        </ValorMayusculas>
        <ValorLeft>
          <xsl:value-of select=""$var:v21"" />
        </ValorLeft>
        <xsl:variable name=""var:v22"" select=""ScriptNS0:TipoDocumento(string(OperacionesString/Valor9/text()))"" />
        <ResultadoScript>
          <xsl:value-of select=""$var:v22"" />
        </ResultadoScript>
      </OperacionesStrings>
    </ns0:OperacionesSalida>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string InitCumulativeMax(int index)
{
	if (index >= 0)
	{
		if (index >= myCumulativeMaxArray.Count)
		{
			int i = myCumulativeMaxArray.Count;
			for (; i<=index; i++)
			{
				myCumulativeMaxArray.Add("""");
			}
		}
		else
		{
			myCumulativeMaxArray[index] = """";
		}
	}
	return """";
}

public System.Collections.ArrayList myCumulativeMaxArray = new System.Collections.ArrayList();

public string AddToCumulativeMax(int index, string val, string notused)
{
	if (index < 0 || index >= myCumulativeMaxArray.Count)
	{
		return """";
	}
	double d = 0;
	if (IsNumeric(val, ref d))
	{
		if (myCumulativeMaxArray[index] is string || (d > (double)(myCumulativeMaxArray[index])))
		{
			myCumulativeMaxArray[index] = d;
		}
	}
	return (myCumulativeMaxArray[index] is double) ? ((double)myCumulativeMaxArray[index]).ToString(System.Globalization.CultureInfo.InvariantCulture) : """";
}

public string GetCumulativeMax(int index)
{
	if (index < 0 || index >= myCumulativeMaxArray.Count)
	{
		return """";
	}
	return (myCumulativeMaxArray[index] is double) ? ((double)myCumulativeMaxArray[index]).ToString(System.Globalization.CultureInfo.InvariantCulture) : """";
}

public string DateAddDays(string date, string days)
{
	string retval = """";
	double db = 0;
	if (IsDate(date) && IsNumeric(days, ref db))
	{
		DateTime dt = DateTime.Parse(date);
		int d = (int) db;
		dt = dt.AddDays(d);
		retval = dt.ToString(""yyyy-MM-dd"", System.Globalization.CultureInfo.InvariantCulture);
	}
	return retval;
}


public bool LogicalEq(string val1, string val2)
{
	bool ret = false;
	double d1 = 0;
	double d2 = 0;
	if (IsNumeric(val1, ref d1) && IsNumeric(val2, ref d2))
	{
		ret = d1 == d2;
	}
	else
	{
		ret = String.Compare(val1, val2, StringComparison.Ordinal) == 0;
	}
	return ret;
}


public bool LogicalNe(string val1, string val2)
{
	bool ret = false;
	double d1 = 0;
	double d2 = 0;
	if (IsNumeric(val1, ref d1) && IsNumeric(val2, ref d2))
	{
		ret = d1 != d2;
	}
	else
	{
		ret = String.Compare(val1, val2, StringComparison.Ordinal) != 0;
	}
	return ret;
}


public bool LogicalGt(string val1, string val2)
{
	bool ret = false;
	double d1 = 0;
	double d2 = 0;
	if (IsNumeric(val1, ref d1) && IsNumeric(val2, ref d2))
	{
		ret = d1 > d2;
	}
	else
	{
		ret = String.Compare(val1, val2, StringComparison.Ordinal) > 0;
	}
	return ret;
}


public bool LogicalAnd(string param0, string param1)
{
	return ValToBool(param0) && ValToBool(param1);
	return false;
}


public bool LogicalNot(string val)
{
	return !ValToBool(val);
}


public string MathMax(string param0, string param1)
{
	double max = Double.NegativeInfinity;
	System.Collections.ArrayList listValues = new System.Collections.ArrayList();
	listValues.Add(param0);
	listValues.Add(param1);
	foreach (string obj in listValues)
	{
		double d = 0;
		if (IsNumeric(obj, ref d))
		{
			max = (d >= max) ? d : max;
		}
		else
		{
			return """";
		}
	}
	if (Double.NegativeInfinity == max)
	{
		return """";
	}
	else
	{
		return max.ToString(System.Globalization.CultureInfo.InvariantCulture);
	}
}


public string MathMultiply(string param0, string param1)
{
	System.Collections.ArrayList listValues = new System.Collections.ArrayList();
	listValues.Add(param0);
	listValues.Add(param1);
	double ret = 1;
	bool first = true;
	foreach (string obj in listValues)
	{
		double d = 0;
		if (IsNumeric(obj, ref d))
		{
			if (first)
			{
				first = false;
				ret = d;
			}
			else
			{
				ret *= d;
			}
		}
		else
		{
			return """";
		}
	}
	return ret.ToString(System.Globalization.CultureInfo.InvariantCulture);
}


public string StringUpperCase(string str)
{
	if (str == null)
	{
		return """";
	}
	return str.ToUpper(System.Globalization.CultureInfo.InvariantCulture);
}


public string StringLeft(string str, string count)
{
	string retval = """";
	double d = 0;
	if (str != null && IsNumeric(count, ref d))
	{
		int i = (int) d;
		if (i > 0)
		{ 
			if (i <= str.Length)
			{
				retval = str.Substring(0, i);
			}
			else
			{
				retval = str;
			}
		}
	}
	return retval;
}


public bool IsNumeric(string val)
{
	if (val == null)
	{
		return false;
	}
	double d = 0;
	return Double.TryParse(val, System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out d);
}

public bool IsNumeric(string val, ref double d)
{
	if (val == null)
	{
		return false;
	}
	return Double.TryParse(val, System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out d);
}

public bool IsDate(string val)
{
	bool retval = true;
	try
	{
		DateTime dt = Convert.ToDateTime(val, System.Globalization.CultureInfo.InvariantCulture);
	}
	catch (Exception)
	{
		retval = false;
	}
	return retval;
}

public bool ValToBool(string val)
{
	if (val != null)
	{
		if (string.Compare(val, bool.TrueString, StringComparison.OrdinalIgnoreCase) == 0)
		{
			return true;
		}
		if (string.Compare(val, bool.FalseString, StringComparison.OrdinalIgnoreCase) == 0)
		{
			return false;
		}
		val = val.Trim();
		if (string.Compare(val, bool.TrueString, StringComparison.OrdinalIgnoreCase) == 0)
		{
			return true;
		}
		if (string.Compare(val, bool.FalseString, StringComparison.OrdinalIgnoreCase) == 0)
		{
			return false;
		}
		double d = 0;
		if (IsNumeric(val, ref d))
		{
			return (d > 0);
		}
	}
	return false;
}


]]></msxsl:script>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects>
  <ExtensionObject Namespace=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS0"" AssemblyName=""BTS.TallerBizTalk.Utilidades, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"" ClassName=""BTS.TallerBizTalk.Utilidades.Utils"" />
</ExtensionObjects>";
        
        private const string _strSrcSchemasList0 = @"BTS.TallerBizTalk.Esquemas.Operaciones.OperacionesEntrada";
        
        private const global::BTS.TallerBizTalk.Esquemas.Operaciones.OperacionesEntrada _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"BTS.TallerBizTalk.Esquemas.Operaciones.OperacionesSalida";
        
        private const global::BTS.TallerBizTalk.Esquemas.Operaciones.OperacionesSalida _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"BTS.TallerBizTalk.Esquemas.Operaciones.OperacionesEntrada";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"BTS.TallerBizTalk.Esquemas.Operaciones.OperacionesSalida";
                return _TrgSchemas;
            }
        }
    }
}
