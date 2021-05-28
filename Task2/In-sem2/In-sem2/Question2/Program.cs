using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    class Embassy
    {
        public static void Main(string[] args)
        {
            List<Applicant> applicants = new List<Applicant>()
            { new Applicant(1), new Applicant(2)};
            VisaProcessor visaProcessor = new VisaProcessor();
            visaProcessor.SetCallbackForVisaStatus(
                () => { Console.WriteLine("Function CalledBack!!"); }
            );
            foreach (var applicant in applicants)
                visaProcessor.ProcessVisa(applicant);
            Console.ReadLine();
        }
    }

    class VisaProcessor
    {
        public delegate void MyCallBack();
        public void SetCallbackForVisaStatus(MyCallBack callBackObj)
        {
            callBackObj();
        }

        public void ProcessVisa(Applicant applicant)
        {
            Console.WriteLine("Applicant Id: {0}, Status: {1}", applicant.ID, "Approved");
        }
    }

    class Applicant
    {
        public Applicant(int ID) { this.ID = ID; }
        public int ID { get; }
    }

}
