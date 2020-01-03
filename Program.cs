using System;

namespace fibonacciNumberPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            string sCurrentFnCNumber = "144";
            string sPribusfibbo = "089";
            string sTempfibbo = "000";

            string sSumresult = "";
            string sFncNumberST = "144";
            int nNumberOfMath = 3;
            int nNumberOfStep = 1;


            string sTempResultSt = "";
            int nTempFirstNumber = 0, nTempSecondNumber = 0, nSumRes = 0, nExtraval = 0;
            while (nNumberOfMath <900)
            {
                sTempfibbo = sCurrentFnCNumber;
                nExtraval = 0;
                int i = sCurrentFnCNumber.Length - 1;
                if (sPribusfibbo.Length != sCurrentFnCNumber.Length)
                {
                    sTempResultSt = "0" + sPribusfibbo;
                    sPribusfibbo = sTempResultSt;
                }
                while (i >= 0)
                {

                    //temFirst = sPribusfibbo.Substring(2,1);   //sPribusfibbo[i];
                    nTempFirstNumber = Convert.ToInt16(sPribusfibbo.Substring(i, 1));

                    nTempSecondNumber = Convert.ToInt16(sCurrentFnCNumber.Substring(i, 1));
                    nSumRes = nTempFirstNumber + nTempSecondNumber + nExtraval;
                    if (nSumRes > 9)
                    {
                        sTempResultSt = sSumresult;
                        sTempResultSt = nSumRes.ToString()[1] + sTempResultSt;

                        //Set result
                        sSumresult = sTempResultSt;
                        nExtraval = Convert.ToInt32(nSumRes.ToString().Substring(0, 1));
                    }
                    else
                    {
                        sTempResultSt = sSumresult;
                        sTempResultSt = nSumRes.ToString() + sTempResultSt;

                        //Set result
                        sSumresult = sTempResultSt;
                        nExtraval = 0;//Reset
                    }
                    i--;

                }
                if (nExtraval != 0)
                {
                    sSumresult = nExtraval.ToString() + sSumresult;
                }
                sCurrentFnCNumber = sSumresult;
                sPribusfibbo = sTempfibbo;

                sFncNumberST = sCurrentFnCNumber;
                sSumresult = "";

                if (sFncNumberST.Length > nNumberOfMath)
                {
                    nNumberOfMath = sFncNumberST.Length;
                }
                nNumberOfStep++;
              //  Console.WriteLine(" " + sCurrentFnCNumber);
            }
            //Console.WriteLine(" " + sCurrentFnCNumber);
            Console.WriteLine("Step Number : " + nNumberOfStep);

            Console.ReadKey();

            
        }
    }
}
