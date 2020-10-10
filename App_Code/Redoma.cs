using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Redoma
/// </summary>
public class Redoma
{
    public static DateTime Proximo_Dia_Util(DateTime _data)
    {
        DateTime result;
        _data = _data.AddDays(1);
        while (!(Srelib.DiaUtil(_data)))
        {
            _data = _data.AddDays(1);
        }
        result = _data;
        return result;
    }
}