using System.Data.SqlClient;
using System.Data;
using System;
using System.Configuration;
using DevExpress.Web.ASPxEditors;
using System.Text;

/// <summary>
/// Summary description for uCorrecoes
/// </summary>
public class uCorrecoes
{

    public static String CorrecaoTabelaPrice(string xvalorpresente,
                                             string xvalorprestacao,
                                             string xnumeroparcelas,
                                             string xtaxajuros)
    {
        string retorno = " ";
        double i = 0;
        double p = 0;
        double n = 0;
        //
        //Calculo
        if ((xvalorpresente != "0") || (xvalorpresente != string.Empty) &&
            (xvalorprestacao != "0") || (xvalorprestacao != string.Empty) &&
            (xnumeroparcelas != "0") || (xnumeroparcelas != string.Empty) &&
            (xtaxajuros != "0") || (xtaxajuros != string.Empty))
        {
            //Taxa de Juros em Fator
            i = (Convert.ToDouble(xtaxajuros) / 100);
            //
            n = Convert.ToDouble(xnumeroparcelas);
            //
            p = (Convert.ToDouble(xvalorpresente) * (i / (1 - Math.Pow((1 + i), -n))));
            //
            retorno = p.ToString();
        }
        //
        return retorno;
    }


    public static String CorrecaoParcela(string xproduto,
                                         string xgrupo,
                                         string xunidade,
                                         string xparte,
                                         string xmeiolote,
                                         DateTime xdtvencimento,
                                         DateTime xdtpagamento,
                                         string xvlrparcela,
                                         ref string xvlrcorrecao,
                                         ref string xvlrjuros,
                                         ref string xvlrmulta,
                                         ref string xvlrdesconto,
                                         ref string xvlrpagamento,
                                         ref string xvlrpagamentofinal,
                                         ref Boolean xbtprocessa,
                                         ref string xedfeedback,
                                         ref string xedindexadoracum,
                                         string xperiodicidade_comissao,
                                         string xjuros,
                                         string xtaxamulta,
                                         string xdiferencadias)
    {
        //
        //Calculo Pagamento
        if (xdtpagamento <= xdtvencimento)
        {
            //Mesmo Dia ou antecipado
            xedfeedback = "Calculo de pagamento na Data de Vencimento. Clique no Botão Gravar.";
            xvlrpagamento = xvlrparcela;
            //
            xvlrpagamentofinal = Convert.ToString(
                                 Convert.ToDouble(xvlrparcela) -
                                 Convert.ToDouble(xvlrdesconto)
                                 );
            //
            xbtprocessa = true;
            //
        }
        else
        {
            //Atrasado
            string metodo = uParametros.PegaParametro("PAGAMENTO METODO");
            if (metodo == "1")
            {
                //Calculo pelo Método 1, padrão do sistema
                //Atrasado
                xedfeedback = "Calculo de pagamento Atrasado (MÉTODO 1). Clique no Botão Gravar.";
                //Indexador
                string tx_indexador_acum = "0,00";
                string indexador = "";
                if (xparte == "0")
                {
                    indexador = uVendas.PegaIndexador(xproduto, xgrupo, xunidade, xparte);
                }
                else
                {
                    indexador = uVendas.PegaIndexador(xproduto, xgrupo, xunidade, xmeiolote);
                }
                //
                Decimal vlr_correcao = 0;
                if ((indexador != "NENHUM") || (indexador != ""))
                {
                    tx_indexador_acum = Convert.ToString(uTaxasMensais.PegaDadosTaxasMensaisAcumuladaNomePagamento(
                                        indexador,
                                        xdtvencimento,
                                        xdtpagamento));
                    tx_indexador_acum = Math.Round(Convert.ToDecimal(tx_indexador_acum), 4).ToString();
                    //
                    //Correção
                    if (tx_indexador_acum != "0")
                    {
                        vlr_correcao = (Math.Round(Convert.ToDecimal(xvlrparcela), 2) *
                                       ((Math.Round(Convert.ToDecimal(tx_indexador_acum), 4) / 100))
                                       );
                        vlr_correcao = Math.Round(Convert.ToDecimal(vlr_correcao), 2);
                    }
                    else
                    {
                        vlr_correcao = 0;
                    }
                }
                else
                {
                    xedfeedback = "Calculo de pagamento Atrasado (MÉTODO 1). Indexador NENHUM não gera calculo. Clique no Botão Gravar.";
                }
                //
                xedindexadoracum = indexador + " - " + tx_indexador_acum;
                xvlrcorrecao = vlr_correcao.ToString();
                //
                //Juros (Parcela + Correção) * (((( Juros/100 ) + 1) ^ Meses ou dias) - 1)
                Double diasatraso = Convert.ToDouble(xdiferencadias); // Convert.ToInt64((xdtpagamento - xdtvencimento).TotalDays);
                Double mesesatraso = diasatraso / 30;
                //
                Decimal vlr_juros = 0;
                if (xperiodicidade_comissao == "a.d.")
                {
                    vlr_juros = (Math.Round(Convert.ToDecimal(xvlrparcela), 2) +
                                Math.Round(Convert.ToDecimal(xvlrcorrecao), 2));
                    vlr_juros = vlr_juros *
                                (Convert.ToDecimal(Math.Pow((Convert.ToDouble(xjuros) / 100) + 1, diasatraso)) - 1);
                }
                if (xperiodicidade_comissao == "a.m.")
                {
                    vlr_juros = (Math.Round(Convert.ToDecimal(xvlrparcela), 2) +
                                Math.Round(Convert.ToDecimal(xvlrcorrecao), 2));
                    vlr_juros = vlr_juros *
                                (Convert.ToDecimal(Math.Pow((Convert.ToDouble(xjuros) / 100) + 1, mesesatraso)) - 1);

                }
                xvlrjuros = Math.Round(Convert.ToDecimal(vlr_juros), 2).ToString();
                //
                //Multa
                Decimal vlr_multa = (Math.Round(Convert.ToDecimal(xvlrparcela), 2) +
                                     Math.Round(Convert.ToDecimal(xvlrcorrecao), 2) +
                                     Math.Round(Convert.ToDecimal(xvlrjuros), 2)) *
                                     (Math.Round(Convert.ToDecimal(xtaxamulta), 2) / 100)
                                     ;
                vlr_multa = Math.Round(Convert.ToDecimal(vlr_multa), 2);
                xvlrmulta = vlr_multa.ToString();
                //
                Decimal vlr_pagamento = (Math.Round(Convert.ToDecimal(xvlrparcela), 2) +
                                       Math.Round(Convert.ToDecimal(xvlrcorrecao), 2) +
                                       Math.Round(Convert.ToDecimal(xvlrjuros), 2) +
                                       Math.Round(Convert.ToDecimal(xvlrmulta), 2))
                                       ;
                vlr_pagamento = Math.Round(Convert.ToDecimal(vlr_pagamento), 2);
                xvlrpagamento = vlr_pagamento.ToString();
                //
                Decimal vlr_pagofinal = Math.Round(Convert.ToDecimal(xvlrpagamento), 2) -
                                       Math.Round(Convert.ToDecimal(xvlrdesconto), 2)
                                       ;
                vlr_pagofinal = Math.Round(Convert.ToDecimal(vlr_pagofinal), 2);
                xvlrpagamentofinal = vlr_pagofinal.ToString();
                //
                xdiferencadias = mesesatraso.ToString() + " - " + diasatraso.ToString();
                //
                xbtprocessa = true;
            }
            if (metodo == "2")
            {
                //Calculo pelo Método 2, modificado Terra Simão
                //Atrasado
                xedfeedback = "Calculo de pagamento Atrasado (MÉTODO 2). Clique no Botão Gravar.";
                //
                Double diasatraso = Convert.ToInt64((xdtpagamento - xdtvencimento).TotalDays);
                Double mesesatraso = diasatraso / 30;
                //
                //Indexador
                string tx_indexador_acum = "0,00";
                string indexador = "";
                if (xparte == "0")
                {
                    indexador = uVendas.PegaIndexador(xproduto, xgrupo, xunidade, xparte);
                }
                else
                {
                    indexador = uVendas.PegaIndexador(xproduto, xgrupo, xunidade, xmeiolote);
                }
                //
                Decimal vlr_correcao = 0;
                if ((indexador != "NENHUM") || (indexador != ""))
                {
                    tx_indexador_acum = uTaxasMensais.PegaDadosTaxasMensaisAcumuladaNomePagamento(
                                                      indexador,
                                                      xdtvencimento,
                                                      xdtpagamento).ToString();
                    //
                    tx_indexador_acum = Math.Round(Convert.ToDecimal(tx_indexador_acum), 4).ToString();
                    //
                    //Correção
                    if (tx_indexador_acum != "0")
                    {
                        //Taxa Acumulada
                        vlr_correcao = (Math.Round(Convert.ToDecimal(xvlrparcela), 2) *
                                       ((Math.Round(Convert.ToDecimal(tx_indexador_acum), 4) / 100) *
                                       Convert.ToDecimal(diasatraso))
                                       );
                        vlr_correcao = Math.Round(Convert.ToDecimal(vlr_correcao), 2);
                    }
                    else
                    {
                        //Taxa Mês Corrente
                        if (diasatraso > 0)
                        {
                            tx_indexador_acum = uTaxasMensais.PegaDadosTaxasMensaisNomeString(
                                                              indexador,
                                                              xdtvencimento,
                                                              xdtpagamento).ToString();
                            if (tx_indexador_acum != "0")
                            {
                                //Taxa Mês
                                vlr_correcao = (Math.Round(Convert.ToDecimal(xvlrparcela), 2) *
                                               ((Math.Round(Convert.ToDecimal(tx_indexador_acum), 4) / 100) *
                                               Convert.ToDecimal(diasatraso))
                                               );
                                vlr_correcao = Math.Round(Convert.ToDecimal(vlr_correcao), 2);
                            }
                            else
                            {
                                vlr_correcao = 0;
                            }
                        }
                        else
                        {
                            vlr_correcao = 0;
                        }
                    }
                }
                else
                {
                    xedfeedback = "Calculo de pagamento Atrasado (MÉTODO 2). Indexador NENHUM não gera calculo. Clique no Botão Gravar.";
                }
                xedindexadoracum = indexador + " - " + tx_indexador_acum;
                xvlrcorrecao = vlr_correcao.ToString();
                //
                //Juros (Parcela + Correção) * (((( Juros/100 ) + 1) ^ Meses ou dias) - 1)
                //
                Decimal vlr_juros = 0;
                if (xperiodicidade_comissao == "a.d.")
                {
                    vlr_juros = (Math.Round(Convert.ToDecimal(xvlrparcela), 2) +
                                Math.Round(Convert.ToDecimal(xvlrcorrecao), 2));
                    //Multiplicar não Elevar
                    vlr_juros = vlr_juros *
                                (Convert.ToDecimal(Math.Pow((Convert.ToDouble(xjuros) / 100) + 1, diasatraso)) - 1);
                }
                if (xperiodicidade_comissao == "a.m.")
                {
                    vlr_juros = (Math.Round(Convert.ToDecimal(xvlrparcela), 2) +
                                Math.Round(Convert.ToDecimal(xvlrcorrecao), 2));

                    vlr_juros = vlr_juros *
                                (Convert.ToDecimal(Math.Pow((Convert.ToDouble(xjuros) / 100) + 1, mesesatraso)) - 1);

                }
                vlr_juros = Math.Round(Convert.ToDecimal(vlr_juros), 2);
                xvlrjuros = vlr_juros.ToString();
                //
                //Multa
                Decimal vlr_multa = (Math.Round(Convert.ToDecimal(xvlrparcela), 2) +
                                     Math.Round(Convert.ToDecimal(xvlrcorrecao), 2) +
                                     Math.Round(Convert.ToDecimal(xvlrjuros), 2)) *
                                     (Math.Round(Convert.ToDecimal(xtaxamulta), 2) / 100)
                                     ;
                vlr_multa = Math.Round(Convert.ToDecimal(vlr_multa), 2);
                xvlrmulta = vlr_multa.ToString();
                //
                Decimal vlr_pagamento = (Math.Round(Convert.ToDecimal(xvlrparcela), 2) +
                                       Math.Round(Convert.ToDecimal(xvlrcorrecao), 2) +
                                       Math.Round(Convert.ToDecimal(xvlrjuros), 2) +
                                       Math.Round(Convert.ToDecimal(xvlrmulta), 2))
                                       ;
                vlr_pagamento = Math.Round(Convert.ToDecimal(vlr_pagamento), 2);
                xvlrpagamento = vlr_pagamento.ToString();
                //
                Decimal vlr_pagofinal = Math.Round(Convert.ToDecimal(xvlrpagamento), 2) -
                                       Math.Round(Convert.ToDecimal(xvlrdesconto), 2)
                                       ;
                vlr_pagofinal = Math.Round(Convert.ToDecimal(vlr_pagofinal), 2);
                xvlrpagamentofinal = vlr_pagofinal.ToString();
                //
                xdiferencadias = mesesatraso.ToString() + " - " + diasatraso.ToString();
                //
                xbtprocessa = true;
            }
            if ((metodo != "1") && (metodo != "2"))
            {
                xedfeedback = "Atenção!!! Parâmetro PAGAMENTO MÉTODO não definido corretamente.";
            }
        }

        return " ";
    }

    public uCorrecoes()
    {
        //
        // TODO: Add constructor logic here
        //
    }
}