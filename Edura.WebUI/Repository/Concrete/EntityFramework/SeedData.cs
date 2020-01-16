using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Edura.WebUI.Entity;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Edura.WebUI.Repository.Concrete.EntityFramework
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            var context = app.ApplicationServices.GetRequiredService<EduraDbContext>();

            context.Database.Migrate();

            if (!context.Products.Any())
            {
                var products = new[]
                {
                    new Product(){ProductName="Photo Camera",Price=1000,Image="product1.jpg",IsHome=true,IsApproved=true,IsFeatured=true,Description="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic",HtmlContent="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, <b>abut also the leap into electronic</b>",DateAdded=DateTime.Now.AddDays(-10)},
                    new Product(){ProductName="web Camera",Price=200,Image ="product2.jpg",IsHome=true,IsApproved=true,IsFeatured=true ,Description="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic",HtmlContent="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, <b>abut also the leap into electronic</b>",DateAdded=DateTime.Now.AddDays(-20)},
                    new Product(){ProductName="Hand Bag",Price=500,Image="product3.jpg",IsHome=true,IsApproved=true,IsFeatured=true ,Description="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic",HtmlContent="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, <b>abut also the leap into electronic</b>",DateAdded=DateTime.Now.AddDays(-30)},
                    new Product(){ProductName="Sofa",Price=3000 ,Image="product4.jpg",IsHome=true,IsApproved=true,IsFeatured=true ,Description="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic",HtmlContent="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, <b>abut also the leap into electronic</b>",DateAdded=DateTime.Now.AddDays(-2)}
                };
                context.Products.AddRange(products);
                var categories = new[]
                {
                    new Category() {CategoryName="Electronic"},
                    new Category() {CategoryName="Accessories"},
                   new Category() {CategoryName="Furniture"}

                };
                context.Categories.AddRange(categories);

                var productCategories = new[]
                {
                new ProductCategory(){Product=products[0],Category =categories[0]},
                new ProductCategory(){Product=products[1],Category =categories[0]},
                new ProductCategory(){Product=products[3],Category =categories[2]},
                new ProductCategory(){Product=products[2],Category =categories[1]},
                };
                context.AddRange(productCategories);

                var Images = new[]
                {
                    new Image(){ImageName="product1.jpg",product=products[0]},
                    new Image(){ImageName="product2.jpg",product=products[0]},
                    new Image(){ImageName="product3.jpg",product=products[0]},
                    new Image(){ImageName="product4.jpg",product=products[0]},

                    new Image(){ImageName="product1.jpg",product=products[1]},
                    new Image(){ImageName="product2.jpg",product=products[1]},
                    new Image(){ImageName="product3.jpg",product=products[1]},
                    new Image(){ImageName="product4.jpg",product=products[1]},

                    new Image(){ImageName="product1.jpg",product=products[2]},
                    new Image(){ImageName="product2.jpg",product=products[2]},
                    new Image(){ImageName="product3.jpg",product=products[2]},
                    new Image(){ImageName="product4.jpg",product=products[2]},

                    new Image(){ImageName="product1.jpg",product=products[3]},
                    new Image(){ImageName="product2.jpg",product=products[3]},
                    new Image(){ImageName="product3.jpg",product=products[3]},
                    new Image(){ImageName="product4.jpg",product=products[3]},
                };

                context.Images.AddRange(Images);



                var attribute = new[]
            {
                    new ProductAttribute(){Attribute="Display",Value="15.6",Product =products[0] },
                    new ProductAttribute(){Attribute="Processor",Value="Intel Hede",Product =products[0]},
                    new ProductAttribute(){Attribute="HardDisk",Value="1 Tb",Product =products[0] },
                    new ProductAttribute(){Attribute="Color",Value="Black",Product =products[0] },

                       new ProductAttribute(){Attribute="Display",Value="15.6",Product =products[1] },
                    new ProductAttribute(){Attribute="Processor",Value="Intel Hede",Product =products[1]},
                    new ProductAttribute(){Attribute="HardDisk",Value="1 Tb",Product =products[1] },
                    new ProductAttribute(){Attribute="Color",Value="Black",Product =products[1] },

                       new ProductAttribute(){Attribute="Display",Value="15.6",Product =products[2] },
                    new ProductAttribute(){Attribute="Processor",Value="Intel Hede",Product =products[2]},
                    new ProductAttribute(){Attribute="HardDisk",Value="1 Tb",Product =products[2] },
                    new ProductAttribute(){Attribute="Color",Value="Black",Product =products[2] },

                       new ProductAttribute(){Attribute="Display",Value="15.6",Product =products[3] },
                    new ProductAttribute(){Attribute="Processor",Value="Intel Hede",Product =products[3]},
                    new ProductAttribute(){Attribute="HardDisk",Value="1 Tb",Product =products[3]},
                    new ProductAttribute(){Attribute="Color",Value="Black",Product =products[3]},

                };
                context.Attributes.AddRange(attribute);
                context.SaveChanges();
            }

        }

    }
}
