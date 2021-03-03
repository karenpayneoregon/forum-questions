using System;
using System.Collections.Generic;
using System.Linq;
using ClaimsLibrary.Data;
using ClaimsLibrary.Models;

namespace ClaimsFrontEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            //Example3(Language.E, DoneCode.Y);
            GetAllDoneCodes3();

            Console.ReadLine();
        }

        private static void Example1()
        {

            using var context = new OcsContext();
            
            List<IccTran> iccTransList = context
                .IccTrans
                .Where(x => x.TrAllDone == "Y" && x.TrLanguageCode == "E")
                .ToList();

            for (int i = 0; i < iccTransList.Count; i++)
            {
                Console.WriteLine($"Id: {iccTransList[i].Id} Completed: {iccTransList[i].TrCompleteTime.Value:d}");
            }
        }
        private static void Example2()
        {
            
            using var context = new OcsContext();
            
            List<IccTran> iccTransList = context
                .IccTrans
                .Where(trans => trans.TrAllDone == "Y" && trans.TrLanguageCode == "E")
                .ToList();

            for (int index = 0; index < iccTransList.Count; index++)
            {
                Console.WriteLine($"Id: {iccTransList[index].Id} Completed: {iccTransList[index].TrCompleteTime.Value:d}");
            }
        }
        private static void Example3(Language language, DoneCode doneCode)
        {
           
            
            using var context = new OcsContext();
            
            var iccTransList = context
                .IccTrans
                .Where(trans => 
                    trans.TrAllDone == doneCode.ToString() && 
                    trans.TrLanguageCode == language.ToString())
                .ToList();

            foreach (var iccTrans in iccTransList)
            {
                if (iccTrans.TrCompleteTime != null)
                {
                    Console.WriteLine($"Id: {iccTrans.Id} Completed: {iccTrans.TrCompleteTime.Value:d}");
                }
            }
        }

        /// <summary>
        /// Get data conventional
        /// </summary>
        private static void GetAllDoneCodes1()
        {
            using (var context = new OcsContext())
            {
                context.AllDoneCodes.ToList().ForEach(
                    code => Console.WriteLine($"{code.Id}, {code.Code}, {code.Description}"));
            }
           
        }
        /// <summary>
        /// Get data using C#9
        /// </summary>
        private static void GetAllDoneCodes2()
        {
            using var context = new OcsContext();

            context.AllDoneCodes.ToList().ForEach(
                code => Console.WriteLine($"{code.Id}, {code.Code}, {code.Description}"));

        }
        /// <summary>
        /// Get data using C#9 with partial class
        /// </summary>
        private static void GetAllDoneCodes3()
        {
            using var context = new OcsContext();

            context.AllDoneCodes.ToList().ForEach(Console.WriteLine);

        }
    }
}
