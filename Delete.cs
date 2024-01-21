
namespace Ef_Product1Management{
    class Delete{
        public static void RemoveData()
{
    using (var context = new Product1Context())
    {
    
       
        Console.Write("Enter the Product Id ");
        int  idToRemove = Convert.ToInt32(Console.ReadLine());

        
        var ProductToRemove = context.Productdetails1.FirstOrDefault(b => b.PID== idToRemove);

        if (ProductToRemove != null)
        {
       
            Console.WriteLine($"Removing Product - id: {ProductToRemove.PID}, Movie name: {ProductToRemove.productname}");

     
            context.Productdetails1.Remove(ProductToRemove);

            
            context.SaveChanges();

            Console.WriteLine("Removal successful!");
        }
        else
        {
            Console.WriteLine($"Product id is {idToRemove} not found.");
        }
    }
}






}  

}
