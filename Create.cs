using Ef_Product1Management;

namespace  Ef_Product1Management {
    class Create{
        public static void InsertData()
    {
      using(var context = new Product1Context())
      {
        
        context.Database.EnsureCreated();
        Console.WriteLine("Enter product id:");
        int Pid =Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the product Name:");
        string? Pname = Console.ReadLine();
        Console.WriteLine("Enter the product quantity:");
        string? Pquantity = Console.ReadLine();
        Console.WriteLine("Enter the product price:");
        int Pprice= int.Parse(Console.ReadLine());
        
        context.Productdetails1.Add(new Product
        {
          PID=Pid,
          productname=Pname,
          productquantity=Pquantity,
          productprice=Pprice,
         
        });
    
        context.SaveChanges();
      }
    }

    }
}
