using System;
using System.Collections.Generic;
using System.Text;

namespace ClaseTres
{
    public class FoodGenerator// var hola = new FoodGenerator(5);
    {
        private List<Comida> Comidas { get; set; }

        public FoodGenerator()
        {
            Comidas = new List<Comida>()
            {
                new Comida(){
                    Nombre = "Bacconator",
                    Descripcion = "Una rica amburguesa con bacon",
                    ImageUrl = "https://vignette.wikia.nocookie.net/bacon/images/3/3a/New_baconator.jpg/revision/latest?cb=20171126021042"
                },
                new Comida(){
                    Nombre = "Jhons' Favorite",
                    Descripcion = "La pizza favorita en Papa Jhons",
                    ImageUrl = "https://www.papajohns.com.co/media/johns-favorite_03_intOpt.png"
                },
                new Comida(){
                    Nombre = "Mega Stacker",
                    Descripcion = "Una rica amburguesa con mucha carne",
                    ImageUrl = "http://bk-latam-prod.s3.amazonaws.com/sites/burgerking.com.br/files/Desktop-500x540px-03.png"
                },
                new Comida(){
                    Nombre = "Big Bell Box",
                    Descripcion = "Una caja con tacos, burritos y diversion",
                    ImageUrl = "http://www.mydrivewithpride.com/upload/2017/11/19/sony-and-taco-bell-want-you-to-win-a-destiny-ps4-bundle-taco-bell-box-lunch-l-403570c5fd5fdf86.png"
                },
                new Comida(){
                    Nombre = "Burrito de baccon",
                    Descripcion = "Un burrito envuelto en baccon",
                    ImageUrl = "https://imagesvc.timeincapp.com/v3/mm/image?url=https%3A%2F%2Fcdn-image.foodandwine.com%2Fsites%2Fdefault%2Ffiles%2F.%2Fbacon-weave-breakfast-burrito-fwx-4.jpg&w=1000&q=70"
                },
                new Comida(){
                    Nombre = "Pollo teriyaky",
                    Descripcion = "Pollo teriyaky con vegetales salteados",
                    ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRv3DSjDwy5QsCPaRMgdZ_6XboDG03Uir-7p7KSuRufZ89pYjjA"
                },
                new Comida(){
                    Nombre = "Pechuga Crugiente",
                    Descripcion = "Pechuga Crugiente con salsa y guarnicion",
                    ImageUrl = "https://bocao.com.do//uploads/img16-12-2014-731878893.jpg"
                },
                new Comida(){
                    Nombre = "Langosta Sabrosa",
                    Descripcion = "Una langostita para los ricos",
                    ImageUrl = "https://vignette.wikia.nocookie.net/bacon/images/3/3a/New_baconator.jpg/revision/latest?cb=20171126021042"
                },
                new Comida(){
                    Nombre = "Bizcocho de chocolate",
                    Descripcion = "Un rico pastel de chocolate con frutas en toping",
                    ImageUrl = "https://cdn2.cocinadelirante.com/sites/default/files/images/2017/06/pasteldechocolatesinazucar.jpg"
                },
                new Comida(){
                    Nombre = "Cheesy Bites",
                    Descripcion = "Una rica pizza con pops de queso",
                    ImageUrl = "https://imgix.bustle.com/uploads/image/2018/7/16/4cf8ffe8-aa30-4f8a-94b9-d44d09adabd0-screen-shot-2018-07-16-at-50313-pm.png?w=970&h=582&fit=crop&crop=faces&auto=format&q=70"
                },
                new Comida(){
                    Nombre = "Panormus",
                    Descripcion = "Dos pizzas de diferente ingredientes y mucho sabor",
                    ImageUrl = "https://pbs.twimg.com/media/C1mwK9zUQAA1jMJ.jpg"
                },
                new Comida(){
                    Nombre = "Mofongo",
                    Descripcion = "Un rico mofongo",
                    ImageUrl = "https://i1.wp.com/farm8.staticflickr.com/7530/16068735207_32ddb6bbf2.jpg?resize=433%2C500&ssl=1"
                },
                new Comida(){
                    Nombre = "Helado de chocolate",
                    Descripcion = "Un refrescante refrigerio de cacao",
                    ImageUrl = "https://www.cocinerosargentinos.com/images/4_helado.jpg"
                },
                new Comida(){
                    Nombre = "Cheese Cacke",
                    Descripcion = "Un postre magico",
                    ImageUrl = "https://www.onceuponachef.com/images/2017/12/NY-Cheesecake-1024x773.jpg"
                },
                new Comida(){
                    Nombre = "Club sandwich",
                    Descripcion = "Un rico sandwich cortado en 4 con papas",
                    ImageUrl = "https://i.blogs.es/c25090/sandwich-club-dap/450_1000.jpg"
                },
                new Comida(){
                    Nombre = "Sandwich Cubano",
                    Descripcion = "Rico sandwich directo desde cuba",
                    ImageUrl = "https://afm-6b83.kxcdn.com/wp-content/uploads/2017/07/Pic-_36-Sandwich-Cubano-Final-low-1.jpg"
                },
                new Comida(){
                    Nombre = "Cheese Stick",
                    Descripcion = "Pakitos de queso sabrosos con ajo",
                    ImageUrl = "https://2.bp.blogspot.com/-cnaimuQ69GU/WGGOvHgpWtI/AAAAAAAAzic/6H4FyT5xQaMrx33uBWHUZpXtex-phXDTACLcB/s1600/papa-johns-stufffed-cheesesticks.jpg"
                },
                new Comida(){
                    Nombre = "Empanadas",
                    Descripcion = "Una de las comidas mas populares en la region",
                    ImageUrl = "https://cdn-image.myrecipes.com/sites/default/files/styles/medium_2x/public/image/recipes/cl/13/05/beef-empanadas-cl-x.jpg?itok=OZscx5LJ"
                },
                new Comida(){
                    Nombre = "Pastelon de platano",
                    Descripcion = "Horeado con platano maduro, carne y queso",
                    ImageUrl = "https://img-global.cpcdn.com/002_recipes/409e4e4c4f6123da/751x532cq70/photo.jpg"
                },
                new Comida(){
                    Nombre = "Yaroa",
                    Descripcion = "Papas fritas con carne queso y mucho ketchup",
                    ImageUrl = "http://multimedia.mmc.com.do/multimedia/multimedia/2011/08/25/cms-image-000010486_400x400.jpg"
                }
            };
        }

        public List<Comida> GenerateFood()
        {
            int i = 0;
            foreach (var comida in Comidas)
            {
                comida.Precio = (i + 1) * 38;
                comida.Cantidad = (i + 1) % 3;
                i++;
            }
            return Comidas;
        }
        

    }
}
