using System.Text;
using Ef_Product1Management;

namespace Ef_Product1Management{
    class Read{
        public static void PrintData()
    {
      
      using (var context = new Product1Context())
      {
       
        foreach(var Product1details in context.Productdetails1 )
        {
          var data = new StringBuilder();
          data.AppendLine($"PID: {Product1details.PID}");
          data.AppendLine($"Productname: {Product1details.productname}");
          data.AppendLine($"Productquantity: {Product1details.productquantity}");
          data.AppendLine($"ProductPrice: {Product1details.productprice}");
         
         
          Console.WriteLine(data.ToString());
        }
      }
    }

    }
}