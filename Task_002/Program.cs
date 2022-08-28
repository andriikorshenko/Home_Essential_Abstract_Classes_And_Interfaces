using Task_002;

Console.Write("Введите формат документа (.doc, .txt или .xml) : ");
string docType = Console.ReadLine();

switch (docType.ToLower())
{
    case ".txt":
    case "txt":
        AbstractHandler txtUpcast = new TXTHandler("TXT");
        txtUpcast.Create();
        txtUpcast.Open();
        txtUpcast.Change();
        txtUpcast.Save();
        break;
    case ".xml":
    case "xml":
        AbstractHandler xmlUpcast = new XMLHandler("XML");
        xmlUpcast.Create();
        xmlUpcast.Open();   
        xmlUpcast.Change();
        xmlUpcast.Save();
        break;
    case ".doc":
    case "doc":
        AbstractHandler docUpcast = new DOCHandler("DOC");
        docUpcast.Create();
        docUpcast.Open();
        docUpcast.Change();
        docUpcast.Save();
        break;
    default: 
        Console.WriteLine("Wrong format! Try again later...");
        break;
}
