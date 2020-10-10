using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

/// <summary>
/// Summary description for ClasseData
/// </summary>
public class ClasseData
{
    private DateTime fValor;
    private String fTexto;
    private String fFormato;
   


    public DateTime Valor
    {
        get
        {
            return fValor;
        }
        set
        {

            fValor = value;
            fTexto = fValor.ToString();
        }
    }

    public String Texto
    {
        get
        {
            return fTexto;
        }
        set
        {
            fTexto = value;
            fValor = Convert.ToDateTime(fTexto);
        }
    }

    public String Formato
    {
        get
        {
            return fFormato;

        }
        set
        {
            fFormato = value;
        }
    }
    public String TextoFormatado
    {
        get
        {
            return FormataTexto();
        }
    }

    private String FormataTexto()
    {
        String dd = fValor.Day.ToString();
        String mm = fValor.Month.ToString();
        String aaaa = fValor.Year.ToString();

        if (dd.Length == 1) dd = "0" + dd;
        if (mm.Length == 1) mm = "0" + mm;

        String Data = fFormato.ToUpper();

        Data = Data.Replace("DD", dd);
        Data = Data.Replace("MM", mm);
        Data = Data.Replace("AAAA",aaaa);

        return Data;
    }

	public ClasseData()
	{
		//
		// TODO: Add constructor logic here
		//
        fFormato = "dd/mm/aaaa"; 
        // padrao
	}

    public ClasseData(String _Texto, String _Formato)
    {
        //
        // TODO: Add constructor logic here
        //
        fFormato = _Formato;
        Texto = _Texto;
        // padrao
    }
}
