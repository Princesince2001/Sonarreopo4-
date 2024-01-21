namespace Ef_Product1Management{

    class Update{
     public static void UpdateData()
{
    using (var context = new Product1Context())
    {
       
        

       
        Console.Write("Enter your Product id :");
        int productone = Convert.ToInt32(Console.ReadLine());
         
        var ProductToUpdate = context.Productdetails1.FirstOrDefault(b => b.PID == productone);
          
         if (ProductToUpdate != null)
        {
            Console.WriteLine("Updating  values into the tables: ");
            Console.WriteLine("What you want to update");
            Console.WriteLine(" 1.Productname \n 2.Productquantity\n 3.ProductPrice");
          int updatechoice = Convert.ToInt32(Console.ReadLine());
           string? updatedata=null;
           switch(updatechoice)
        {
            case 1:
                updatedata = "ProductName";
            Console.WriteLine($"Current Name: {ProductToUpdate.productname}");
             Console.Write("Enter the new name : ");
            string? newname = Console.ReadLine();
            ProductToUpdate.productname = newname;
               break;
            case 2:
                updatedata = "productquantity";
            Console.WriteLine($"Current quantity: {ProductToUpdate.productquantity}");
             Console.Write("Enter the new quantity: ");
            string? newquantity= Console.ReadLine();
            ProductToUpdate.productquantity = newquantity;
            break;
            case 3:
                updatedata = "productprice";
            Console.WriteLine($"Current Price: {ProductToUpdate.productprice}");
            Console.Write("Enter the new price: ");
            int? newprice = int.Parse(Console.ReadLine());
            ProductToUpdate.productprice = newprice;
            break;
            
            
           
}
 context.SaveChanges();
        }
        
        else
        {
            Console.WriteLine($" PID:{productone} is not found.");
        }
    }
}

}
}