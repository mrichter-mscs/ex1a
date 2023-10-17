using System.Net.Http.Headers;

namespace Microsoft_Studio.Models
{
    public class Business
    {
        public int BusinessID { get; set; }
        public string EmpId { get; set; }
        public string ProdId { get; set; }
        public DateTime ProdComments { get; set; }


        public Employee Employee { get; set; }
        
        public Product Product { get; set; }

    }
}
