//Sıfırdan proje (solution) oluşturunuz-->TobetoETrade //Product sınıfını katmanlarında işletiniz. //Product -->Id,Name,UnitPrice
//program.cs de mutlaka veri girişleri yapınız.
//tüm pairler bitmeden sonraki aşamaya geçmek yok :)
//tüm pairler bitince 10 dk mola.
//İkinci aşama. Önceki derste (çarşamba) oluşturduğumuz kodlama.io varlıklarını (entity) //TobetoCourseAcademy projesine uygulayınız. //program.cs de mutlaka veri girişleri yapınız

using Business.Concretes;
using Entities.Concretes;

Product product = new Product();
product.Id = 1;
product.Name = "Laptop";
product.UnitPrice = 40.000;

ProductManager productManager = new ProductManager();
productManager.Add(product);

