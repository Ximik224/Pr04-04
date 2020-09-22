using System.Globalization;
using System.Collections;
using System.Collections.Specialized;
class Program
{
  static void Main(string[] args)
  {
    // Создать Словарь, нечувствительный к регистру
    ListDictionary list = new ListDictionary(new CaseInsensitiveComparer(CultureInfo.InvariantCulture));
    // Добавить несколько элементов
    list["Estados Unidos"] = "United States of America";
    list["Canada"] = "Canada";
    list["Espana"] = "Spain";
    // Показать результаты
    System.Console.WriteLine(list["espana"]);
    System.Console.WriteLine(list["CANADA"]);
    System.Console.Read();
  }
}