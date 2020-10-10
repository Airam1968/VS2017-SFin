using System;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DevExpress.Web.ASPxEditors;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Globalization;



/// <summary>
/// Summary description for Srelib
/// </summary>

public class Srelib
{
    string FormatoData = "DMA";
    public static String ErroMsg;

    public static string DvCpf(String xCpf)
    {
        string dv1 = "";
        string dv2 = "";

        dv1 = Srelib.Modulo11(xCpf, 10);
        dv1 = Srelib.Modulo11(xCpf + dv1, 11);

        return dv1 + dv2;
    }

    public static double Eleva(double _x, double _y)
    {
        double _z = 0.00;
        try
        {
            if (double.IsNaN(Math.Pow(_x, _y)))
                _z = 1;
            else
                _z = Math.Pow(_x, _y);
        }
        catch (Exception)
        {
            _z = 1;
            throw;
        }

        return _z;
    }

    public static string Modulo11(String string1, int n)
    {
        int count = 0;
        int peso = 2;
        int mount = 0;

        for (count = string1.Length; (count == string1.Length); count--)
        {
            mount = mount + (Convert.ToInt16(string1.Substring(count, 1)) * peso);
            if (peso < n)
            {
                peso++;
            }
            else
            {
                peso = 2;
            }
        }

        //
        mount = 11 - (mount % 11);

        if ((mount == 10) || (mount == 11))
        {
            return "0";
        }
        else
        {
            return mount.ToString().Trim().Substring(1, 1);
        }
    }

    public static Boolean KCNPJ(String xCNPJ)
    {

        int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

        int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

        int soma;

        int resto;

        string digito;

        string tempCnpj;

        xCNPJ = xCNPJ.Trim();

        xCNPJ = xCNPJ.Replace(".", "").Replace("-", "").Replace("/", "");

        if (xCNPJ.Length != 14)

            return false;

        tempCnpj = xCNPJ.Substring(0, 12);

        soma = 0;

        for (int i = 0; i < 12; i++)

            soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];

        resto = (soma % 11);

        if (resto < 2)

            resto = 0;

        else

            resto = 11 - resto;

        digito = resto.ToString();

        tempCnpj = tempCnpj + digito;

        soma = 0;

        for (int i = 0; i < 13; i++)

            soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];

        resto = (soma % 11);

        if (resto < 2)

            resto = 0;

        else

            resto = 11 - resto;

        digito = digito + resto.ToString();


        return xCNPJ.EndsWith(digito);


    }

    public static string Left(String _s, int _tamanho)
    {
        string dc = "";

        dc = _s.Trim().Substring(1, _tamanho);

        return dc;
    }

    public static string Right(String _s, int _tamanho)
    {
        string dc = "";

        dc = _s.Trim().Substring(1 + _s.Length - _tamanho, _tamanho);

        return dc;
    }

    public static bool DiaUtil(DateTime _data)
    {
        bool result = false;
        SqlParameter[] parameters = { new SqlParameter("@DATA1", _data) };
        DataSet ds = SreDblib.GetDsSp("DIAUTIL", parameters);
        DataRow dr = ds.Tables[0].Rows[0];
        string retorno = dr[0].ToString();
        try
        {
            if (retorno == "N")
            {
                result = false;
            }
            else
            {
                result = true;
            }
        }
        catch
        {
            result = false;
        }
        return result;
    }

    public static DateTime CalcDelay(DateTime _datainicio, Int32 _dmais)
    {
        Int32 _cont = _dmais;
        DateTime _datafim = _datainicio;

        while (!DiaUtil(_datafim))
        {
            _datafim = _datafim.AddDays(1);
        }

        while (_cont > 0)
        {
            _datafim = _datafim.AddDays(1);
            while (!DiaUtil(_datafim))
            {
                _datafim = _datafim.AddDays(1);
            }
            _cont = _cont - 1;
        };

        return _datafim;
    }

    public static Int32 ProximoArquivoEmail()
    {

        DataSet ds = SreDblib.GetDsSpSp("GET_PROXIMO_NSEQ_EMAIL");
        DataRow dr = ds.Tables[0].Rows[0];

        Int32 retorno = Convert.ToInt32(dr[0].ToString());

        return retorno;
    }

    public static String DiaSemana(DateTime xdata)
    {
        //Refatorado 09/08/2018
        String[] diassemana = new String[7] { "Domingo", "Segunda", "Terça", "Quarta", "Quinta", "Sexta", "Sábado" };
        return diassemana[(int)xdata.DayOfWeek];
        //

        //Código Antigo 09/08/2018
        //DateTime data = Convert.ToDateTime(xdata);
        //String s = "";
        //s = Convert.ToString(data.DayOfWeek).ToUpper();
        //if (s == "SUNDAY")
        //{ s = "Domingo"; }
        //if (s == "MONDAY")
        //{ s = "Segunda"; }
        //if (s == "TUESDAY")
        //{ s = "Terça"; }
        //if (s == "WEDNESDAY")
        //{ s = "Quarta"; }
        //if (s == "THURSDAY")
        //{ s = "Quinta"; }
        //if (s == "FRIDAY")
        //{ s = "Sexta"; }
        //if (s == "SATURDAY")
        //{ s = "Sábado"; }

        //return s;
    }

    public static String DataMais(DateTime xdata, int xdias)
    {
        //Refatorado 09/08/2018
        return xdata.AddDays(xdias).ToString().Substring(0, 10);

        //Código Antigo 09/08/2018
        //String dd, mm, aaaa;
        //DateTime data = Convert.ToDateTime(xdata);
        //data = data.AddDays(xdias);
        //dd = Srelib.QStr0(data.Day.ToString(), 2);
        //mm = Srelib.QStr0(data.Month.ToString(), 2);
        //aaaa = data.Year.ToString(); // sempre vem com 4 digitos :::
        //String retorno = dd + "/" + mm + "/" + aaaa;
        //return retorno;
    }

    public static String Dia1(DateTime xdata)
    {
        //
        String dd, mm, aaaa;
        dd = "01";
        mm = Srelib.QStr0(xdata.Month.ToString(), 2);
        aaaa = xdata.Year.ToString(); // sempre vem com 4 digitos :::
        String retorno = dd + "/" + mm + "/" + aaaa;

        return retorno;
    }

    public static DateTime ProximoDia1(DateTime xdata)
    {
        //Refatorado 09/08/2018
        xdata = xdata.AddMonths(1);
        //
        String dd, mm, aaaa;
        dd = "01";
        mm = Srelib.QStr0(xdata.Month.ToString(), 2);
        aaaa = xdata.Year.ToString(); // sempre vem com 4 digitos :::
        DateTime retorno = Convert.ToDateTime(dd + "/" + mm + "/" + aaaa);

        return retorno;

        //Código Antigo 09/08/2018
        //int m, a;
        //DateTime d;
        //m = xdata.Month + 1;
        //a = xdata.Year;
        //if (m == 13)
        //{
        //    m = 1;
        //    a = a + 1;
        //}
        //if (m < 10)
        //{
        //    d = Convert.ToDateTime("01/0" + Convert.ToString(m) + "/" + Convert.ToString(a));
        //}
        //else
        //{
        //    d = Convert.ToDateTime("01/" + Convert.ToString(m) + "/" + Convert.ToString(a));
        //}
        //return d;
    }

    public static Int32 DiasCorridos(DateTime d1, DateTime d2)
    {
        //Refatorado 09/08/2018
        try
        {
            return Convert.ToInt32(d2.Subtract(d1));
        }
        catch (Exception)
        {
            return 0;
        }

        //Código Antigo 09/08/2018
        //Int32 retorno = 0;

        //TimeSpan ts = d2 - d1;

        //if (ts.Days > 0)
        //    retorno = ts.Days;
        //else
        //    retorno = 0;

        //return retorno;

    }

    public static String Converte_Senha(String _x)
    {
        Int64 j, r;
        Byte m;
        Char c;

        r = 0;
        for (m = 0; (m <= (_x.Length - 1)); m++)
        {
            c = _x[m];
            j = c;
            r = (r + (j * 3)) * 2;
        }

        String retorno = Srelib.strzero(r, 10);
        return retorno;
    }

    public static String PadData(String _d)
    {
        String s = null;
        if ((_d != null) && (_d != "") && (_d != "&nbsp;") && (_d != "01/01/1900 00:00:00"))
        {
            DateTime _d1 = Convert.ToDateTime(_d);
            s = String.Format("{0:dd/MM/yyyy}", _d1);
        }
        return s;
    }

    public static String QStr0(String s, Double tam)
    {
        while (s.Length < tam) { s = "0" + s; }
        return s;
    }

    public static String QStr(String s)
    {
        return "'" + s + "'";
    }

    public static String DataHojeMais(int xdias)
    {
        //Refatorado 09/08/2018
        return DateTime.Today.AddDays(xdias).ToString().Substring(0, 10);

        //Código Antigo 09/08/2018
        //String dd, mm, aaaa;
        //DateTime data = DateTime.Today.AddDays(xdias);
        //dd = Srelib.QStr0(data.Day.ToString(), 2);
        //mm = Srelib.QStr0(data.Month.ToString(), 2);
        //aaaa = data.Year.ToString(); // sempre vem com 4 digitos :::
        //String retorno = dd + "/" + mm + "/" + aaaa;
        //return retorno;
    }

    public static String DataHojePura(int xdigano)
    {
        //Refatorado 09/08/2018
        String retorno = DateTime.Today.ToString().Substring(0, 10);
        if (xdigano == 2)
            retorno = retorno.Substring(0, 6) + retorno.Substring(9, 2);
        return retorno;       

        //Código Antigo 09/08/2018
        //String dd, mm, aaaa;
        //DateTime data = DateTime.Today;
        //dd = Srelib.QStr0(data.Day.ToString(), 2);
        //mm = Srelib.QStr0(data.Month.ToString(), 2);
        //aaaa = data.Year.ToString(); // sempre vem com 4 digitos :::
        //if (xdigano == 2)
        //    aaaa = aaaa.Substring(2, 2);
        //String retorno = dd + mm + aaaa;
        //return retorno;
    }

    public static String DataPura(DateTime xdata, int xdigano)
    {
        //Refatorado 09/08/2018
        String retorno = xdata.ToString().Substring(0, 10);
        if (xdigano == 2)
            retorno = retorno.Substring(0, 6) + retorno.Substring(9, 2);
        return retorno;

        //Código Antigo 09/08/2018
        //int dia, mes, ano;
        //string dd, mm, aa, aux = "";

        //dia = data.Day;
        //mes = data.Month;
        //ano = data.Year;

        //dd = Srelib.strzero2(dia.ToString(), 2);
        //mm = Srelib.strzero2(mes.ToString(), 2);
        //aa = Srelib.strzero2(ano.ToString(), 4);

        //if (DigAno == 2)
        //    aa = aa.Substring(2, 2);

        //aux = dd + mm + aa;

        //return aux;

    }

    public static String DataAmericana(DateTime xdata)
    {
        //Refatorado 09/08/2018
        //DataAmericana = aa + "/" + mm + "/" + dd;
        //String retorno = xdata.ToString().Substring(6, 4) + "/" +
        //                 xdata.ToString().Substring(3, 2) + "/" +
        //                 xdata.ToString().Substring(0, 2) + "/";

        //return retorno;

        //Código Antigo 09/08/2018
        int dia, mes, ano;
        string dd, mm, aa, aux = "";

        DateTime Data;
        try
        {
            Data = Convert.ToDateTime(xdata);
        }
        catch (Exception)
        {
            Data = Convert.ToDateTime("01/01/1900");
        }

        dia = Data.Day;
        mes = Data.Month;
        ano = Data.Year;

        dd = Srelib.strzero2(dia.ToString(), 2);
        mm = Srelib.strzero2(mes.ToString(), 2);
        aa = Srelib.strzero2(ano.ToString(), 4);

        aux = aa + "/" + mm + "/" + dd;


        return aux;
    }

    public static String DataAmericanasembarra(string xdata)
    {
        //Refatorado 09/08/2018
        //DataAmericana SQL = aa + mm + dd;
        //String retorno = Convert.ToDateTime(xdata).ToString().Substring(6, 4) +
        //                 Convert.ToDateTime(xdata).ToString().Substring(3, 2) +
        //                 Convert.ToDateTime(xdata).ToString().Substring(0, 2);

        //return retorno;

        //Código Antigo 09/08/2018
        //dataamericana SQL
        int dia, mes, ano;
        string dd, mm, aa, aux = "";

        DateTime Data;
        try
        {
            Data = Convert.ToDateTime(xdata);
        }
        catch (Exception)
        {
            Data = Convert.ToDateTime("01/01/1900");
        }
        dia = Data.Day;
        mes = Data.Month;
        ano = Data.Year;

        dd = Srelib.strzero2(dia.ToString(), 2);
        mm = Srelib.strzero2(mes.ToString(), 2);
        aa = Srelib.strzero2(ano.ToString(), 4);

        aux = aa + mm + dd;

        return aux;
    }

    public static String DataQuery(String xdata, String FormatoData)
    {
        string dd, mm, aa, aux = "";

        dd = xdata.Substring(0, 2);
        mm = xdata.Substring(3, 2);
        aa = xdata.Substring(6, 4);

        if (FormatoData == "DMA")
        {
            aux = dd + "/" + mm + "/" + aa;
        }

        if (FormatoData == "MDA")
        {
            aux = mm + "/" + dd + "/" + aa;
        }

        if (FormatoData == "AMD")
        {
            aux = aa + "/" + mm + "/" + dd;
        }

        return aux;
    }

    public static String DataNormal(String dma)
    {
        string dd, mm, aa, aux = "";

        dd = dma.Substring(0, 2);
        mm = dma.Substring(3, 2);
        aa = dma.Substring(6, 4);

        aux = dd + "/" + mm + "/" + aa;

        return aux;
    }

    public static String replicate(String x, int y)
    {
        String s = "";
        int m;
        for (m = 1; (m <= y); m++)
        {
            s = s + x;
        }
        return s;
    }

    public static String SubStr(String x, int ini, int tam)
    {
        string retorno = x;
        int tx = x.Length;
        int tmax = tx - ini;
        if (tam <= tmax)
        {
            retorno = x.Substring(ini, tam);
        }
        else
            if (tmax > 0)
            {
                retorno = x.Substring(ini, tmax);
            }
            else
            {
                retorno = "";
            }
        return retorno;
    }

    public static String strzero(Int64 numero, int nzeros)
    {
        String cResult;
        String numero2 = Convert.ToString(numero);

        if (numero != 0)
        {
            cResult = replicate("0", (nzeros - numero2.Length))
                      + numero2;
        }
        else
        { cResult = replicate("0", nzeros); }

        return cResult;
    }

    public static String ValorPuro(double _valor, int vaNo)
    {
        String s = "";
        String _aux = Convert.ToString(_valor).Trim();
        int m;
        for (m = 0; (m <= _aux.Length - 1); m++)
        {
            if ((_aux.Substring(m, 1) != ".") && (_aux.Substring(m, 1) != ","))
            {
                s = s + _aux.Substring(m, 1);
            }
        }
        s = replicate("0", vaNo - s.Length) + s;
        return s;
    }

    public static String TrNumero(String _valor)
    {
        String s = "";
        String _aux = _valor.Trim();
        int m;
        for (m = 0; (m <= _aux.Length - 1); m++)
        {
            String x = "";
            if ((_aux.Substring(m, 1) == ","))
            {
                x = ".";
            }
            else
                if ((_aux.Substring(m, 1) == "."))
                {
                    x = "";
                }
                else
                {
                    x = _aux.Substring(m, 1);
                }
            s = s + x;
        }
        return s;
    }

    public static double TruncarDecimais(double valor)
    {
        valor *= 100;
        valor = Math.Truncate(valor);
        valor /= 100;

        return valor;
    }

    public static double ArredondarDecimais(double valor)
    {
        valor *= 100;
        valor = Math.Round(valor);
        valor /= 100;

        return valor;
    }

    public static String PadDouble(String _d)
    {
        String s = "0.00";
        if ((_d != null) && (_d != "") && (_d != "&nbsp;") && (_d != "0.0000") && (_d != "0.00") && (_d != "0"))
        {
            Double _d1 = Convert.ToDouble(Srelib.TrNumero2(_d));//  Convert.ToDouble(_d);

            s = String.Format("{0:#,##0.00;-#,##0.00}", _d1);
        }
        return s;
    }

    public static String PadDouble3(String _d)
    {
        String s = "0.0000";
        if ((_d != null) && (_d != "") && (_d != "&nbsp;") && (_d != "0.00000") && (_d != "0.00") && (_d != "0"))
        {
            Double _d1 = Convert.ToDouble(Srelib.TrNumero(_d));//  Convert.ToDouble(_d);

            s = String.Format("{0:#,##0.0000;-#,##0.0000}", _d1);
        }
        return s;
    }

    public static Double TrNumero2(String x)
    {
        Boolean lPassou = false;
        int indice;
        String dc = "";
        String caux;
        String CaracteresValidos = "0123456789-";
        int i;
        if (x.Trim() == "") { x = "0.00"; }
        if (x.Trim() == "&nbsp;") { x = "0.00"; }

        if (x.Length != 0)
        {


            for (i = x.Length - 1; (i >= 0); i--)
            {
                caux = x.Substring(i, 1);
                if (!lPassou)
                {
                    if ((caux == ",") || (caux == "."))
                    {
                        lPassou = true;
                        // caux = ".";
                        dc = caux + dc;
                    }
                    else
                    {
                        indice = CaracteresValidos.IndexOf(caux);
                        if (indice != -1)
                        {
                            dc = caux + dc;
                        }
                    }
                }
                else
                {
                    indice = CaracteresValidos.IndexOf(caux);
                    if (indice != -1)
                    {
                        dc = caux + dc;
                    }
                }
            }
        }
        return Convert.ToDouble(dc);
    }

    public static String TrNumeroString2(String x)
    {
        Boolean lPassou = false;
        int indice;
        String dc = "";
        String caux;
        String CaracteresValidos = "0123456789-";
        int i;
        if (x == null) { x = "0.00"; }
        if (x.Trim() == "") { x = "0.00"; }
        if (x.Trim() == "&nbsp;") { x = "0.00"; }

        if (x.Length != 0)
        {

            for (i = x.Length - 1; (i >= 0); i--)
            {
                caux = x.Substring(i, 1);
                if (!lPassou)
                {
                    if ((caux == ",") || (caux == "."))
                    {
                        lPassou = true;
                        // caux = ".";
                        dc = caux + dc;
                    }
                    else
                    {
                        indice = CaracteresValidos.IndexOf(caux);
                        if (indice != -1)
                        {
                            dc = caux + dc;
                        }
                    }
                }
                else
                {
                    indice = CaracteresValidos.IndexOf(caux);
                    if (indice != -1)
                    {
                        dc = caux + dc;
                    }
                }
            }
        }

        return dc;
    }

    public static String TrNumeroString(String x)
    {
        String sint;
        String sdec;

        String ponto;

        ponto = x.Substring(x.Length - 3, 1);
        if ((ponto != ".") && (ponto != ","))
        {
            sdec = "";
            sint = x;
        }
        else
        {
            sdec = x.Substring(x.Length - 2, 2); ;
            sint = x.Substring(0, x.Length - 3);
        }

        return sint + '.' + sdec;

    }
    
    public static String StrTran(String _no, String _c1, String _c2)
    {
        String s = "";
        String _aux = _no.Trim();
        int m;
        for (m = 0; (m <= _aux.Length - 1); m++)
        {

            if ((_aux.Substring(m, 1) == _c1))
            {
                s = s + _c2;
            }
            else
            {
                s = s + _aux.Substring(m, 1);
            }
        }
        return s;
    }

    public static String Deixa_Numeros_Letras(String x)
    {
        String dc = "";
        String caux;
        String CaracteresValidos = "0123456789ABCDEFGHIJKLMNOPQRSTUVXZYW";
        int i;
        if (x.Length != 0)
        {
            for (i = 0; (i <= x.Length - 1); i++)
            {
                caux = x.Substring(i, 1);
                caux = caux.ToUpper();
                int indice = CaracteresValidos.IndexOf(caux);
                if (indice != -1)
                {
                    dc = dc + caux;
                }

            }
        }
        return dc;
    }

    public static String Deixa_Numeros(String Texto)
    {
        String TextoSoNumero = "";
        int tamTexto = Texto.Length - 1;
        string caracteresValidos = "0123456789";

        for (int i = 0; i <= tamTexto; i++)
        {
            if (caracteresValidos.IndexOf(Texto.Substring(i, 1)) != -1)
            {
                TextoSoNumero = TextoSoNumero + Texto.Substring(i, 1);
            }
        }
        return TextoSoNumero;
    }

    public static String PegaDigito(String cc)
    {
        String SeparadorDigito = "-";
        int indiceSeparador = cc.IndexOf(SeparadorDigito);
        if (indiceSeparador != -1)
        {
            return cc.Substring(indiceSeparador + 1, cc.Length - (indiceSeparador + 1));
        }
        else
        {
            return "";
        }

    }

    public static String PegaSemDigito(String cc)
    {
        String SeparadorDigito = "-";
        int indiceSeparador = cc.IndexOf(SeparadorDigito);
        if (indiceSeparador != -1)
        {
            return cc.Substring(0, indiceSeparador);
        }
        else
        {
            return cc;
        }

    }

    public static String PutIn0102(string _cgc)
    {
        int l = _cgc.Length;
        int x = 18 - l;
        string aux = _cgc + space(x);
        string aux2 = _cgc.Trim();

        if (aux2.Length <= 11)
            _cgc = "01" + aux;
        else
            _cgc = "02" + aux;
        return _cgc;
    }

    public static String PegaAno(String _d)
    {
        ValorExtenso xExt = new ValorExtenso();
        Double s;
        String cAux;
        s = Convert.ToDouble(_d.Substring(6, 4));
        cAux = xExt.ValExtenso(s);
        cAux = cAux.ToLower();
        cAux = StrTran(cAux, ",", " e ");

        String Separador = "reais";
        int indiceSeparador = cAux.IndexOf(Separador);
        if (indiceSeparador != -1)
        {
            cAux = cAux.Substring(0, indiceSeparador);
        }
        return cAux;
    }

    public static String PegaDia(String _d)
    {
        ValorExtenso xExt = new ValorExtenso();
        Double s;
        String cAux;
        s = Convert.ToDouble(_d.Substring(0, 2));
        cAux = xExt.ValExtenso(s);
        cAux = cAux.ToLower();
        cAux = StrTran(cAux, ",", " e ");

        String Separador = "reais";
        int indiceSeparador = cAux.IndexOf(Separador);
        if (indiceSeparador != -1)
        {
            cAux = cAux.Substring(0, indiceSeparador);
        }
        return cAux;
    }

    public static String strzero2(String numero, int nzeros)
    {
        String cResult;

        if (numero.Trim() != "")
        {
            cResult = replicate("0", (nzeros - numero.Length))
                      + numero.Trim();
        }
        else
        { cResult = replicate("0", nzeros); }

        return cResult;
    }

    public static String tiraacento(String xtexto)
    {
        //Refatorado 09/08/2018
        //string comAcentos = "ÄÅÁÂÀÃäáâàãÉÊËÈéêëèÍÎÏÌíîïìÖÓÔÒÕöóôòõÜÚÛüúûùÇç";
        //string semAcentos = "AAAAAAaaaaaEEEEeeeeIIIIiiiiOOOOOoooooUUUuuuuCc";

        //for (int i = 0; i < comAcentos.Length; i++)
        //{
        //    xtexto = xtexto.Replace(comAcentos[i].ToString(), semAcentos[i].ToString());
        //}
        //return xtexto;

        //Código Antigo 09/08/2018
        String s = "";
        String _aux = xtexto.Trim();
        int m;
        for (m = 0; (m <= _aux.Length - 1); m++)
        {
            String caux = _aux.Substring(m, 1);
            if (caux == "Ç") caux = "C";
            if (caux == "ç") caux = "c";

            if ((caux == "Á") || (caux == "À") || (caux == "Ã") || (caux == "Â")) caux = "A";
            if ((caux == "á") || (caux == "à") || (caux == "ã") || (caux == "â")) caux = "a";
            if ((caux == "É") || (caux == "Ê")) caux = "E";
            if ((caux == "é") || (caux == "ê")) caux = "e";
            if (caux == "Í") caux = "I";
            if (caux == "í") caux = "i";
            if ((caux == "Ó") || (caux == "Õ") || (caux == "Ô")) caux = "O";
            if ((caux == "ó") || (caux == "õ") || (caux == "ô")) caux = "o";
            if (caux == "Ú") caux = "U";
            if (caux == "ú") caux = "u";
            if (caux == "ª")
                caux = "a";
            if (caux == "º")
                caux = "o";
            if (caux == "'") caux = "";
            if (caux == "´") caux = "";
            if (caux == "`") caux = "";
            if (caux == "~") caux = "";
            if ((caux == "^") || (caux == "&") || (caux == "|")) caux = "";


            s = s + caux;
        }
        return s;
    }

    public static String tirasimbolos(String x)
    {
        //Refatorado 09/08/2018
        string resultString = string.Empty;
        Regex regexObj = new Regex(@"[^\d]");
        resultString = regexObj.Replace(x, "");
        return resultString;

        //Código Antigo 09/08/2018
        //String s = "";
        //String _aux = x.Trim();
        //int m;
        //for (m = 0; (m <= _aux.Length - 1); m++)
        //{
        //    String caux = _aux.Substring(m, 1);
        //    if ((caux != "0") &
        //        (caux != "1") &
        //        (caux != "2") &
        //        (caux != "3") &
        //        (caux != "4") &
        //        (caux != "5") &
        //        (caux != "6") &
        //        (caux != "7") &
        //        (caux != "8") &
        //        (caux != "9"))
        //    {
        //        caux = "";
        //    }

        //    s = s + caux;
        //}
        //return s;
    }

    public static String acentohtml(String x)
    {
        String s = "";
        String _aux = x.Trim();
        int m;
        for (m = 0; (m <= _aux.Length - 1); m++)
        {
            String caux = _aux.Substring(m, 1);
            if (caux == "Ç") caux = "&Ccedil;";
            if (caux == "ç") caux = "&ccedil;";

            if (caux == "Ã") caux = "&Atilde;";
            if (caux == "ã") caux = "&atilde;";
            if (caux == "Õ") caux = "&Otilde;";
            if (caux == "õ") caux = "&otilde;";

            if (caux == "Á") caux = "&Aacute;";
            if (caux == "É") caux = "&Eacute;";
            if (caux == "Í") caux = "&Iacute;";
            if (caux == "Ó") caux = "&Oacute;";
            if (caux == "Ú") caux = "&Uacute;";
            if (caux == "á") caux = "&aacute;";
            if (caux == "é") caux = "&eacute;";
            if (caux == "í") caux = "&iacute;";
            if (caux == "ó") caux = "&oacute;";
            if (caux == "ú") caux = "&uacute;";


            if (caux == "À") caux = "&Agrave;";
            if (caux == "à") caux = "&agrave;";

            if (caux == "Â") caux = "&Acirc;";
            if (caux == "â") caux = "&acird;";

            if (caux == "Ê") caux = "&Ecirc;";
            if (caux == "ê") caux = "&ecird;";

            if (caux == " ") caux = "&nbsp;";
            if (caux == "") caux = "&nbsp;";
            //            if (caux == "&") caux = "&amp;";


            s = s + caux;
        }
        return s;
    }

    public static string space(int _no)
    {
        return replicate(" ", _no);
    }

    public static String tira_nb(String s)
    {
        String x = s.Trim();
        if (x == "&nbsp;")
            s = "";
        return s;
    }

    public static String padr(string _char, int _no)
    {
        int l = 0;
        int x = 0;
        l = _char.Length;
        x = _no - l;
        if (x < 0) x = 0;
        return _char + space(x);
    }

    public static string padc(string _char, byte _no)
    {
        string result;
        int l;
        int x;
        int y;
        l = _char.Length;
        x = _no - l;
        if ((x < 0))
        {
            x = 0;
            y = 0;
        }
        else
        {
            x = x / 2;
            y = (_no - l) - x;
        }
        result = Srelib.space(x) + _char + Srelib.space(y);
        return result;
    }

    public static String padrhtml(string _char, int _no)
    {
        int l = 0;
        int x = 0;
        l = _char.Length;
        x = _no - l;
        if (x < 0) x = 0;
        return _char + Srelib.replicate("&nbsp;", x);
    }

    public static String TPadrao(String _char, int _no)
    {
        int l = 0;
        string cret = _char;
        l = _char.Length;
        if (l > _no)
        {
            cret = cret.Substring(0, _no);
        }
        return cret;
    }

    public static String padl(string _char, int _no)
    {
        int l = 0;
        int x = 0;
        l = _char.Length;
        x = _no - l;
        if (x < 0) x = 0;
        return space(x) + _char;
    }

    public static String padlhtml(string _char, int _no)
    {
        int l = 0;
        int x = 0;
        l = _char.Length;
        x = _no - l;
        if (x < 0) x = 0;
        return Srelib.replicate("&nbsp;", x) + _char;
    }

    public static Boolean critica_data(String sData)
    {
        Boolean cResult = true;

        if (sData == "")
            cResult = false;

        if (sData.Length != 10)
            cResult = false;

        if (cResult)
        {
            try { Convert.ToDateTime(sData); }
            catch (Exception erro) { cResult = false; }
        }

        if (!cResult) ErroMsg = "Data inválida (DD/MM/AAAA)!";
        return cResult;
    }

    public static Boolean critica_valor(String sValor, Boolean lZero)
    {
        Boolean cResult = true;
        ErroMsg = "";

        sValor = Srelib.TrNumeroString(sValor);

        try { Convert.ToDouble(sValor); }
        catch (Exception erro)
        {
            cResult = false;
        }

        if (lZero)
        {
            if ((sValor.Trim() == "") || (sValor.Trim() == "0.00") || (sValor.Trim() == "0,00"))
            {
                cResult = false;
            }
        }

        if (!cResult) ErroMsg = "Número não aceitável !";
        return cResult;
    }

    public static Boolean critica_numero(String sValor)
    {
        Boolean cResult = true;

        try { Convert.ToInt64(sValor); }
        catch (Exception erro) { cResult = false; }

        return cResult;
    }

    public static Boolean critica_cep(String sValor)
    {
        Boolean cResult = true;

        if (sValor.Trim() != "")
        {
            sValor = sValor.Trim();
            if (sValor.Length != 8)
            {

                cResult = false;
            }
            else
            {
                cResult = critica_numero(sValor);
            }
        }
        if (!cResult) ErroMsg = "Campo CEP inválido!";
        return cResult;
    }

    public static String critica_periodo(String sData1, String sData2)
    {
        String cResult = "";
        DateTime data1, data2;

        if (!critica_data(sData1))
        { cResult = "Data inicial inválida (DD/MM/AAAA)!"; }
        else if (!critica_data(sData2))
        { cResult = "Data final inválida (DD/MM/AAAA)!"; }
        else
        {
            data1 = Convert.ToDateTime(sData1);
            data2 = Convert.ToDateTime(sData2);
            if (data2 < data1)
                cResult = "Data final deve ser maior que a data inicial !";
        }

        return cResult;
    }

    public static String forcaponto(String _valor)
    {
        String s = "";
        int m;
        for (m = 0; (m <= _valor.Length - 1); m++)
        {
            if ((_valor.Substring(m, 1) == ",") || (_valor.Substring(m, 1) == "."))
            { s = s + "."; }
            else
            { s = s + _valor.Substring(m, 1); }
        }
        return s;
    }

    public static Boolean email_valido(String s)
    {
        int i;
        Boolean tem_arroba = false;
        Boolean tem_ponto = false;
        String aux;
        if (s.Trim() != "")
        {
            for (i = 0; (i <= s.Length - 1); i++)
            {
                aux = s.Substring(i, 1);
                if (aux == ".") { tem_ponto = true; }
                if (aux == "@") { tem_arroba = true; }
            }
            return ((tem_arroba) && (tem_ponto));
        }
        else
        {
            return false;
        }
    }

    public static String DataExtenso(DateTime _d)
    {
        String sData = String.Format("{0:dd/MM/yyyy}", Convert.ToDateTime(_d));
        String sRet;
        sRet = strzero2(sData.Substring(0, 2), 2) + " de " +
               Mes(strzero2(sData.Substring(3, 2), 2)) + " de " +
               sData.Substring(6, 4);
        return sRet;
    }

    public static Double Arredondar2(Double _d)
    {

        DataSet ds = SreDblib.GetDsScript("select round(" + String.Format("{0:N}", _d) + ",2) resultado");

        Double _returno = Convert.ToDouble(ds.Tables[0].Rows[0]["resultado"].ToString());

        return _returno;
    }

    public static String Mes(String xmes)
    {
        //Refatorado 09/08/2018
        String[] meses = new String[12] { "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };
        return meses[Convert.ToInt16(xmes)-1];
        //

        //Código Antigo 09/08/2018
        //String cRet = "";
        //if (xmes == "01")
        //    cRet = "Janeiro";
        //else
        //    if (xmes == "02")
        //        cRet = "Fevereiro";
        //    else
        //        if (xmes == "03")
        //            cRet = "Marco";
        //        else
        //            if (xmes == "04")
        //                cRet = "Abril";
        //            else
        //                if (xmes == "05")
        //                    cRet = "Maio";
        //                else
        //                    if (xmes == "06")
        //                        cRet = "Junho";
        //                    else
        //                        if (xmes == "07")
        //                            cRet = "Julho";
        //                        else
        //                            if (xmes == "08")
        //                                cRet = "Agosto";
        //                            else
        //                                if (xmes == "09")
        //                                    cRet = "Setembro";
        //                                else
        //                                    if (xmes == "10")
        //                                        cRet = "Outubro";
        //                                    else
        //                                        if (xmes == "11")
        //                                            cRet = "Novembro";
        //                                        else
        //                                            if (xmes == "12")
        //                                                cRet = "Dezembro";

        //return cRet;
    }

    public static String FormataCPFCNPJ(String _cpfcnpj)
    {
        _cpfcnpj = _cpfcnpj.Trim();
        String cRet = _cpfcnpj.Trim();
        if (_cpfcnpj.Length == 11)
            cRet = FormataCPF(_cpfcnpj);
        else
            if (_cpfcnpj.Length == 14)
                cRet = FormataCGC(_cpfcnpj);
        return cRet;
    }

    public static String FormataCPFCGC(String _cpfcnpj)
    {
        _cpfcnpj = _cpfcnpj.Trim();
        String cRet = _cpfcnpj.Trim();
        if (_cpfcnpj.Length == 11)
            cRet = FormataCPF(_cpfcnpj);
        else
            if (_cpfcnpj.Length == 14)
            cRet = FormataCGC(_cpfcnpj);
        return cRet;
    }

    public static String FormataCPF(String _cpf)
    {
        return _cpf.Substring(0, 3) + '.' +
               _cpf.Substring(3, 3) + '.' +
               _cpf.Substring(6, 3) + '-' +
               _cpf.Substring(9, 2);
    }

    public static String FormataCGC(String _cnpj)
    {
        return _cnpj.Substring(0, 2) + '.' +
               _cnpj.Substring(2, 3) + '.' +
               _cnpj.Substring(5, 3) + '/' +
               _cnpj.Substring(8, 4) + '-' +
               _cnpj.Substring(12, 2);
    }

    public static String DataGeral(String dma, String Formato)
    {
        ClasseData data = new ClasseData(dma, Formato);
        return data.TextoFormatado;
    }

    public static String LimpaEspacoDuplo(String _char)
    {
        string result;
        string resultado;
        resultado = _char;
        while ((resultado.IndexOf("  ") > 0))
        {
            resultado = resultado.Replace("  ", " ");
        }
        result = resultado;
        return result;
    }

    public static String MesExtenso(String xdata)
    {
        //Refatorado 09/08/2018
        String[] meses = new String[12] { "Jan", "Fev", "Mar", "Abr", "Mai", "Jun", "Jul", "Ago", "Set", "Out", "Nov", "Dez" };
        return meses[Convert.ToInt16(xdata.Substring(5, 2)) - 1] + "/" + xdata.Substring(0, 4);
        //

        //Código Antigo 09/08/2018
        //String m = xdata.Substring(5, 2);
        //String cMes = "";
        //if (m == "01")
        //{ cMes = "Jan"; }
        //if (m == "02")
        //{ cMes = "Fev"; }
        //if (m == "03")
        //{ cMes = "Mar"; }
        //if (m == "04")
        //{ cMes = "Abr"; }
        //if (m == "05")
        //{ cMes = "Mai"; }
        //if (m == "06")
        //{ cMes = "Jun"; }
        //if (m == "07")
        //{ cMes = "Jul"; }
        //if (m == "08")
        //{ cMes = "Ago"; }
        //if (m == "09")
        //{ cMes = "Set"; }
        //if (m == "10")
        //{ cMes = "Out"; }
        //if (m == "11")
        //{ cMes = "Nov"; }
        //if (m == "12")
        //{ cMes = "Dez"; }

        //if (cMes != "")
        //{ return cMes + "/" + xdata.Substring(0, 4); }
        //else
        //{ return xdata; }

    }

    public static String MesExtenso2(String xmesano)
    {
        //Refatorado 09/08/2018
        String[] meses = new String[12] { "Jan", "Fev", "Mar", "Abr", "Mai", "Jun", "Jul", "Ago", "Set", "Out", "Nov", "Dez" };
        return meses[Convert.ToInt16(xmesano.Substring(0, 2)) - 1] + "/" + xmesano.Substring(3, 4);
        //

        //Código Antigo 09/08/2018
        //String m = xdata.Substring(0, 2);
        //String cMes = "";
        //if (m == "01")
        //{ cMes = "Jan"; }
        //if (m == "02")
        //{ cMes = "Fev"; }
        //if (m == "03")
        //{ cMes = "Mar"; }
        //if (m == "04")
        //{ cMes = "Abr"; }
        //if (m == "05")
        //{ cMes = "Mai"; }
        //if (m == "06")
        //{ cMes = "Jun"; }
        //if (m == "07")
        //{ cMes = "Jul"; }
        //if (m == "08")
        //{ cMes = "Ago"; }
        //if (m == "09")
        //{ cMes = "Set"; }
        //if (m == "10")
        //{ cMes = "Out"; }
        //if (m == "11")
        //{ cMes = "Nov"; }
        //if (m == "12")
        //{ cMes = "Dez"; }

        //if (cMes != "")
        //{ return cMes + "/" + xdata.Substring(3, 4); }
        //else
        //{ return xdata; }

    }

    public static String MesExtenso3(String xmes)
    {
        //Refatorado 09/08/2018
        String[] meses = new String[12] { "Jan", "Fev", "Mar", "Abr", "Mai", "Jun", "Jul", "Ago", "Set", "Out", "Nov", "Dez" };
        return meses[Convert.ToInt16(Srelib.strzero2(xmes, 2)) - 1];
        //

        //Código Antigo 09/08/2018
        //String m = Srelib.strzero2(xdata, 2);
        //String cMes = "";
        //if (m == "01")
        //{ cMes = "Jan"; }
        //if (m == "02")
        //{ cMes = "Fev"; }
        //if (m == "03")
        //{ cMes = "Mar"; }
        //if (m == "04")
        //{ cMes = "Abr"; }
        //if (m == "05")
        //{ cMes = "Mai"; }
        //if (m == "06")
        //{ cMes = "Jun"; }
        //if (m == "07")
        //{ cMes = "Jul"; }
        //if (m == "08")
        //{ cMes = "Ago"; }
        //if (m == "09")
        //{ cMes = "Set"; }
        //if (m == "10")
        //{ cMes = "Out"; }
        //if (m == "11")
        //{ cMes = "Nov"; }
        //if (m == "12")
        //{ cMes = "Dez"; }

        //return cMes;

    }

    public static String MesExtenso4(String xdatahora)
    {
        //Refatorado 09/08/2018
        String[] meses = new String[12] { "Jan", "Fev", "Mar", "Abr", "Mai", "Jun", "Jul", "Ago", "Set", "Out", "Nov", "Dez" };
        return meses[Convert.ToInt16(xdatahora.Substring(3, 2)) - 1] + "/" + xdatahora.Substring(6, 12);
        //

        //Código Antigo 09/08/2018
        //String m = xdatahora.Substring(3, 2);
        //String cMes = "";
        //if (m == "01")
        //{ cMes = "Jan"; }
        //if (m == "02")
        //{ cMes = "Fev"; }
        //if (m == "03")
        //{ cMes = "Mar"; }
        //if (m == "04")
        //{ cMes = "Abr"; }
        //if (m == "05")
        //{ cMes = "Mai"; }
        //if (m == "06")
        //{ cMes = "Jun"; }
        //if (m == "07")
        //{ cMes = "Jul"; }
        //if (m == "08")
        //{ cMes = "Ago"; }
        //if (m == "09")
        //{ cMes = "Set"; }
        //if (m == "10")
        //{ cMes = "Out"; }
        //if (m == "11")
        //{ cMes = "Nov"; }
        //if (m == "12")
        //{ cMes = "Dez"; }

        //if (cMes != "")
        //{ return cMes + "/" + s.Substring(6, 12); }
        //else
        //{ return s; }

    }

    public static String Deixa_Numeros2(String x)
    {
        //Refatorado 09/08/2018
        string resultString = string.Empty;
        Regex regexObj = new Regex(@"[^\d]");
        resultString = regexObj.Replace(x, "");
        return resultString;

        //Código Antigo 09/08/2018
        //String dc = "";
        //String caux;
        //String CaracteresValidos = "0123456789";
        //int i;
        //if (x.Length != 0)
        //{
        //    for (i = 0; (i <= x.Length - 1); i++)
        //    {
        //        caux = x.Substring(i, 1);
        //        caux = caux.ToUpper();
        //        int indice = CaracteresValidos.IndexOf(caux);
        //        if (indice != -1)
        //        {
        //            dc = dc + caux;
        //        }

        //    }
        //}
        //if (dc.Trim() == "")
        //{ dc = "0"; }
        //return dc;
    }

    public static String PadData2(String _d)
    {
        String s = null;
        if ((_d != null) && (_d != "") && (_d != "&nbsp;"))
        {
            DateTime _d1 = Convert.ToDateTime(_d);
            s = String.Format("{0:dd/MM/yyyy}", _d1);
        }
        return s;
    }

    public static DateTime PoeMasc(String cData)
    {
        String cRetorno = "01/01/1900";
        if ((cData.Substring(0, 2) != "00") &&
            (cData.Substring(0, 2) != ""))
        {
            cRetorno = cData.Substring(0, 2) + "/" + cData.Substring(2, 2) + "/" + cData.Substring(4, 4);
        }
        return Convert.ToDateTime(cRetorno);
    }

    public static DateTime PoeMascSeis(String cData)
    {
        String cRetorno = "01/01/1900";
        try
        {
            cRetorno = cData.Substring(0, 2) + "/" + cData.Substring(2, 2) + "/20" + cData.Substring(4, 2);
            return Convert.ToDateTime(cRetorno);
        }
        catch
        {
            cRetorno = "01/01/1900";
            return Convert.ToDateTime(cRetorno);
        }
    }

    public static String PegaValor(String c)
    {
        int n1 = 0;
        c = c.Trim();
        n1 = c.Substring(0, c.Length - 2).Length;
        c = c.Substring(0, n1) + "." + c.Substring(n1, 2);
        return c;
    }

    public static Boolean critica_inteiro(String sValor, Boolean lZero)
    {
        Boolean cResult = true;
        ErroMsg = "";

        sValor = Srelib.TrNumeroString(sValor);

        try { Convert.ToInt16(sValor); }
        catch (Exception erro)
        {
            cResult = false;
        }

        if (!cResult) ErroMsg = "Número não aceitável !";
        return cResult;
    }

    public static String PegaNomeMes(Int32 xmes)
    {
        //Refatorado 09/08/2018
        String[] meses = new String[12] { "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };
        return meses[Convert.ToInt16(xmes) - 1];
        //

        //Código Antigo 09/08/2018
        //string cMes = "";
        //switch (xmes)
        //{
        //    case 01: cMes = "Janeiro"; break;
        //    case 02: cMes = "Fevereiro"; break;
        //    case 03: cMes = "Março"; break;
        //    case 04: cMes = "Abril"; break;
        //    case 05: cMes = "Maio"; break;
        //    case 06: cMes = "Junho"; break;
        //    case 07: cMes = "Julho"; break;
        //    case 08: cMes = "Agosto"; break;
        //    case 09: cMes = "Setembro"; break;
        //    case 10: cMes = "Outubro"; break;
        //    case 11: cMes = "Novembro"; break;
        //    case 12: cMes = "Dezembro"; break;
        //}
        //return cMes;
    }

    public static Int32 peganummes(string xmes)
    {
        //Refatorado 09/08/2018
        String[] meses = new String[12] { "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };
        //var target = xmes;
        var resultado = Array.FindAll(meses, s => s.Equals(xmes));
        return Convert.ToInt32(resultado);
        //

        //Código Antigo 09/08/2018
        //Int32 nMes = 0;
        //switch (xMes)
        //{
        //    case "Janeiro": nMes = 1; break;
        //    case "Fevereiro": nMes = 2; break;
        //    case "Março": nMes = 3; break;
        //    case "Abril": nMes = 4; break;
        //    case "Maio": nMes = 5; break;
        //    case "Junho": nMes = 6; break;
        //    case "Julho": nMes = 7; break;
        //    case "Agosto": nMes = 8; break;
        //    case "Setembro": nMes = 9; break;
        //    case "Outubro": nMes = 10; break;
        //    case "Novembro": nMes = 11; break;
        //    case "Dezembro": nMes = 12; break;
        //}
        //return nMes;
    }

    public static string PegaNomeLetra(Int32 cletra)
    {
        //Refatorado 09/08/2018
        String[] letras = new String[26] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J",
                                           "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T",
                                           "U", "V", "W", "X", "Y", "Z" };

        return letras[cletra-1];
        //

        //Código Antigo 09/08/2018
        //string nletra = "";
        //switch (cletra)
        //{
        //    case 01: nletra = "A"; break;
        //    case 02: nletra = "B"; break;
        //    case 03: nletra = "C"; break;
        //    case 04: nletra = "D"; break;
        //    case 05: nletra = "E"; break;
        //    case 06: nletra = "F"; break;
        //    case 07: nletra = "G"; break;
        //    case 08: nletra = "H"; break;
        //    case 09: nletra = "I"; break;
        //    case 10: nletra = "J"; break;
        //    case 11: nletra = "K"; break;
        //    case 12: nletra = "L"; break;
        //    case 13: nletra = "M"; break;
        //    case 14: nletra = "N"; break;
        //    case 15: nletra = "O"; break;
        //    case 16: nletra = "P"; break;
        //    case 17: nletra = "Q"; break;
        //    case 18: nletra = "R"; break;
        //    case 19: nletra = "S"; break;
        //    case 20: nletra = "T"; break;
        //    case 21: nletra = "U"; break;
        //    case 22: nletra = "V"; break;
        //    case 23: nletra = "W"; break;
        //    case 24: nletra = "X"; break;
        //    case 25: nletra = "Y"; break;
        //    case 26: nletra = "Z"; break;

        //}
        //return nletra;

    }

    public static Int32 Ocorrenciasstring(string xstring, string xBusca)
    {

        Int32 aux = 0;
        string xsubstring = xstring;
        Int32 tam = xsubstring.Length;

        //
        while (xsubstring.IndexOf(xBusca) != -1)
        {
            aux++;
            xsubstring = xsubstring.Substring((xsubstring.IndexOf(xBusca) + 1), tam - (xsubstring.IndexOf(xBusca) + 1));
            tam = xsubstring.Length;
        }

        return aux;
    }

    public static ASPxComboBox MontaComboMes(ASPxComboBox pCombo, Boolean pExibeValor)
    {
        //Documentação - Chamada da Função
        //
        //SreLib.MontaComboMes(ASPxComboBox1, true);
        //
        //Fim Documentação - Chamada da Função

        ListEditItem le;
        pCombo.Items.Clear();

        for (int i = 1; i < 13; i++)
        {
            //
            le = new ListEditItem();
            if (pExibeValor)
            {
                le.Text = Srelib.QStr0(i.ToString().Trim(), 2) + " - " + Srelib.PegaNomeMes(i);
            }
            else
            {
                le.Text = Srelib.PegaNomeMes(i);
            };
            le.Value = i;
            pCombo.Items.Add(le);
        }

        return pCombo;
    }

    public static ASPxComboBox MontaComboAno(ASPxComboBox pCombo, Boolean pExibeValor)
    {
        //Documentação - Chamada da Função
        //
        //SreLib.MontaComboAno(ASPxComboBox1, true);
        //
        //Fim Documentação - Chamada da Função

        ListEditItem le;
        Int16 xano = 1980;
        pCombo.Items.Clear();

        for (int i = 0; i < 50; i++)
        {
            //
            le = new ListEditItem();
            if (pExibeValor)
            {
                le.Text = Srelib.QStr0(xano.ToString().Trim(), 4) + " - " + Srelib.QStr0(xano.ToString().Trim(), 4);
            }
            else
            {
                le.Text = Srelib.QStr0(xano.ToString().Trim(), 4);
            };
            le.Value = i;
            pCombo.Items.Add(le);
            xano++;
        }

        return pCombo;
    }

    public static ASPxComboBox MontaComboLetra(ASPxComboBox pCombo, Boolean pExibeValor)
    {
        //Documentação - Chamada da Função
        //
        //SreLib.MontaComboLetra(ASPxComboBox1, true);
        //
        //Fim Documentação - Chamada da Função

        ListEditItem le;
        pCombo.Items.Clear();

        for (int i = 1; i < 27; i++)
        {
            //
            le = new ListEditItem();
            if (pExibeValor)
            {
                le.Text = Srelib.QStr0(i.ToString().Trim(), 2) + " - " + Srelib.PegaNomeLetra(i).ToUpper();
            }
            else
            {
                le.Text = Srelib.PegaNomeLetra(i).ToUpper();
            };
            le.Value = i;
            pCombo.Items.Add(le);
        }

        return pCombo;
    }

    public Srelib()
    {
        //
        // TODO: Add constructor logic here
        //
    }




}
