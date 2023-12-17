using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using StoreManagement.Models;

namespace StoreManagement.DAL
{
    public class StoreInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<StoreContext>
    {
        protected override void Seed(StoreContext context)
        {
            var products = new List<Product>
            {
            new Product { Title="Bread", Description="Homemade healthy wheat bread", IsDeleted=false, CreationDate=DateTime.Parse("2023-01-01"), ImageUrl="https://www.fivehearthome.com/wp-content/uploads/2019/09/Best-Whole-Wheat-Bread-Recipe-by-Five-Heart-Home-14.jpg" },
            new Product { Title = "Milk", Description = "Fresh milk from local cows", IsDeleted = false, CreationDate = DateTime.Parse("2023-01-01"), ImageUrl = "https://www.foodnavigator-asia.com/var/wrbm_gb_food_pharma/storage/images/publications/food-beverage-nutrition/foodnavigator-asia.com/headlines/food-safety/myth-busted-fssai-claims-local-milk-to-be-largely-safe-despite-widespread-quality-fears/10324838-1-eng-GB/Myth-busted-FSSAI-claims-local-milk-to-be-largely-safe-despite-widespread-quality-fears.jpg" },
            new Product { Title = "Water", Description = "Clean mineral water", IsDeleted = false, CreationDate = DateTime.Parse("2023-01-01"), ImageUrl = "https://ucccafe.mugengroup.ph/wp-content/uploads/sites/4/2023/09/BOTTLED-WATER-min.jpg" },
            new Product { Title = "Potatoes", Description = "Delicious potatoes from Poland", IsDeleted = false, CreationDate = DateTime.Parse("2023-01-01"), ImageUrl = "https://littlefoodcompany.co.uk/wp-content/uploads/2016/02/potato-1.jpg" }
            };

            products.ForEach(s => context.Products.Add(s));
            context.SaveChanges();

        }
    }
}