using System;

/// <summary>
/// Summary description for CMC7
/// </summary>
public class ValorExtenso
{
    
   public String ValExtenso( Double yVal )
   {
       int l;

       if (yVal <= 0)
       {
           yVal = (yVal) * -1;
       }


       String cents,
              cruz    ,
              mil     ,
              milhao  ,
              bilhao,
              singular,
              plural,
              exp     ,
              xis     ,
              yps     ,
              resto0  ,
              resto1  ,
              resto2;

       xis = "";
       yps      = "";
       singular = "REAL";  
       plural   = "REAIS"; 
       exp      = String.Format("{0:################0.00;-################0.00;###.##}", yVal);
       exp = exp.Trim();
       l        = exp.Length;

       if (l<20) 
          exp   = Srelib.replicate ("0",20-l) + exp;

       l = exp.Length;

       if (singular=="")
       {
         singular = "REAL";
         plural   = "REAIS";
       }

       cents  = exp.Substring(l-2,2);
       cruz   = exp.Substring(l-6,3);
       mil    = exp.Substring(l-9,3);
       milhao = exp.Substring(l-12,3);
       bilhao = exp.Substring(l-15,3);

       resto0 = bilhao + milhao + mil  + cruz + "." + cents;
       resto1 =          milhao + mil  + cruz + "." + cents;
       resto2 =                   mil  + cruz + "." + cents;

       if (cents!="00")
       {
         xis = dupla (cents) + " CENTAVO";
         if (cents!="01") 
              xis=xis+"S";
       }

      if (cruz != "000")
      {
          if (cents != "00")
              xis = " E " + xis;

          if ( (cruz == "001") && (resto1 == "000000000.00") )
              xis = tripla(cruz) + " " + singular + xis;
          else
              xis = tripla(cruz) + " " + plural + xis;
      }

      if (mil != "000")
      {
          if ((cruz != "000") || (cents != "00"))
          {
              xis = ", " + xis;
              if (cruz == "000")
                  xis = " " + plural + xis;
          }
          else
              xis = xis + " " + plural;

          xis = tripla(mil) + " MIL" + xis;
      }

      if (milhao != "000")
      {
          if (resto2 != "000000.00")
          {
              if (resto2.Substring(0, 6) != "000000")
                  xis = ", " + xis;
              else
                  xis = " E " + xis;
          }
          else
              xis = xis + " DE " + plural;

          yps = tripla(milhao);

          if (milhao == "001")
              xis = yps + " MILHAO" + xis;
          else
              xis = yps + " MILHOES" + xis;
      }

       
      if (bilhao!="000")
      {
         if (resto1!="000000000.00")
         {
           if (resto1.Substring(1,8)=="00000000")
             xis = " E " + xis;
           else
             xis = ", " + xis;
         }
         else
           xis = xis + " DE " + plural;

         yps = tripla (bilhao);

         if (bilhao=="001")
           xis = yps + " BILHAO"  + xis;
         else
           xis = yps + " BILHOES" + xis;
      }

      return xis;
   }




    public String unidade( String alg )
    {
        int _aux;
        String str;
        _aux = (6*Convert.ToInt16(alg))-5;
        str = "UM    DOIS  TRES  QUATROCINCO SEIS  SETE  OITO  NOVE  DEZ   ";
        return str.Substring(_aux-1,6).Trim();
    }

    public String dezvinte( String alg )
    {
        int _aux;
        String str;
        _aux = (9*Convert.ToInt16(alg))-8;
        str  = "ONZE     DOZE     TREZE    QUATORZE QUINZE   DEZESSEISDEZESSETEDEZOITO  DEZENOVE ";
        return str.Substring(_aux-1,9).Trim();
    }

   public String dezena( String alg )
   {
        int _aux;
        String str;
        _aux = (9*Convert.ToInt16(alg))-8;
        str  = "DEZ      VINTE    TRINTA   QUARENTA CINQUENTASESSENTA SETENTA  OITENTA  NOVENTA  ";
        return str.Substring(_aux-1,9).Trim();
    }

   public String centena( String alg )
   {
        int _aux;
        String str;
        if (alg == "-")
        {
            return "MENOS ";
        }
        else
        {
            _aux = (12 * Convert.ToInt16(alg)) - 11;
            str = "CENTO       DUZENTOS    TREZENTOS   QUATROCENTOSQUINHENTOS  SEISCENTOS  " +
                   "SETECENTOS  OITOCENTOS  NOVECENTOS  ";
            return str.Substring(_aux - 1, 12).Trim();
        }
    }

    public string dupla( String algs )
    {
       String alg_esq;
       String alg_dir;
       String volta;
       alg_esq = algs.Substring(0,1);
       alg_dir = algs.Substring(1,1);
       if (alg_dir=="0")
           volta = dezena( alg_esq );
       else
       if (alg_esq=="0")
           volta = unidade( alg_dir );
       else
       if (alg_esq=="1")
           volta = dezvinte(alg_dir);
       else
           volta = dezena(alg_esq) + " E " + unidade(alg_dir);

       return volta;           
    }

    public String tripla( String algs )
    {
       String alg_esq;
       String alg_dir;
       String volta;
       alg_esq = algs.Substring(0,1);
       alg_dir = algs.Substring(1,2);
       if (alg_esq=="0")
         volta = dupla( alg_dir );
       else
       if (alg_dir=="00")
       {
           if (alg_esq=="1")
               volta = "CEM";
           else
               volta = centena(alg_esq);
       }
       else
           if (alg_esq == "-")
           {
              volta = centena(alg_esq) + " " + dupla(alg_dir);
           }
           else
             volta = centena(alg_esq) + " E " + dupla (alg_dir);
     return volta;
 }




    public ValorExtenso()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}
