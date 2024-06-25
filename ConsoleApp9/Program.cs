using ConsoleApp9.Model;
using Newtonsoft.Json;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml;

//void XmlWrite()
//{
//    List<Car> cars = new List<Car>()
//    {
//        new Car{Model="Priora",Marka= "Lada",Year = 2013},
//        new Car{Model="2107",Marka= "Lada",Year = 2011},
//        new Car{Model="2106",Marka= "Lada",Year = 1999},
//    };

//    using var writer = new XmlTextWriter("cars.xml", Encoding.Default);
//    writer.Formatting = Formatting.Indented;

//    writer.WriteStartDocument();
//    writer.WriteStartElement("cars");
//    foreach (var car in cars)
//    {
//        writer.WriteStartElement("car");
//        writer.WriteElementString(nameof(car.Marka), car.Marka);
//        writer.WriteElementString(nameof(car.Model), car.Model);
//        writer.WriteElementString(nameof(car.Year), car.Year.ToString());
//        writer.WriteEndElement();
//    }
//    writer.WriteEndElement();
//    writer.WriteEndDocument();

//}

void XmlRead()
{
    XmlDocument doc = new XmlDocument();
    doc.Load("cars.xml");

    var root = doc.DocumentElement;
    foreach (XmlNode node in root.ChildNodes)
    {
        var car = new Car()
        {
            Marka = node.SelectSingleNode(nameof(Car.Marka)).InnerText,
            Model = node.SelectSingleNode(nameof(Car.Model)).InnerText,
            Year = int.Parse(node.SelectSingleNode(nameof(Car.Year)).InnerText)
        };
        Console.WriteLine(car);
    }

}



void JsonSerializeMethod()
{
    Car[] cars = {
        new Car{Model="Priora",Marka= "Lada",Year = 2013},
        new Car{Model="2107",Marka= "Lada",Year = 2011},
        new Car{Model="2106",Marka= "Lada",Year = 1999},
    };

    //Way 1

    //JsonSerializerOptions op = new JsonSerializerOptions();
    //op.WriteIndented = true;
    //Console.WriteLine(JsonSerializer.Serialize(cars,op));
    //var jsonString = JsonSerializer.Serialize(cars,op);
    //File.WriteAllText("cars.json", jsonString);

    //Way 2
    //var jsonString = JsonConvert.SerializeObject(cars,Newtonsoft.Json.Formatting.Indented);
    //File.WriteAllText("carNewtonSoftJson.json", jsonString);


}

void JsonDesiriazlizeMethod()
{
    Car[] cars = null;

    //Way1

    //using FileStream fs = new FileStream("cars.json", FileMode.Open);
    //cars = System.Text.Json.JsonSerializer.Deserialize<Car[]>(fs);


    //Way2

    //var stringData = File.ReadAllText("carNewtonSoftJson.json");
    //cars = JsonConvert.DeserializeObject<Car[]>(stringData);


    foreach (var car in cars)
    {
        Console.WriteLine(car);
    }

}


//XmlWrite();
//XmlRead();



//JsonSerializeMethod();

JsonDesiriazlizeMethod();
