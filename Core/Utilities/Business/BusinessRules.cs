using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Business
{
    public class BusinessRules
    {
        //public static List<IResult>(params IResult[] logics) seklinda yazip liste de dondurulebilirdi.
        //o zaman foreach te butun logicleri(is kurallarini) calistirirdik.Asagidaki gibi

        //public static IResult Run(params IResult[] logics)
        //{
        //    List<IResult> errorResult = new List<Iresult>();
        //    foreach (var logic in logics)
        //    {
        //        if (!logic.Success)
        //        {
        //            //gezilen logic success degilse o logic i dondurur.
        //            errorResult.Add(logic);
        //        }
        //    }
        //    //logic basariliysa bir sey dondurmez.
        //    return errorResult;
        //}
        public static IResult Run(params IResult[] logics)
        {
            foreach (var logic in logics)
            {
                if (!logic.Success)
                {
                    //gezilen logic success degilse o logic i dondurur.
                    return logic;
                }
            }
            //logic basariliysa bir sey dondurmez.
            return null;
        }
    }
}
