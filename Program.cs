using ExceptionLesson;
using MyException;
using System.Text;

// int a = 2;
// int b = 0;


// try
// {
// Console.WriteLine(a / b);
// }
// catch (System.Exception ex)
// {
// Console.WriteLine(ex.Message);
// }



#region NeBred1

var group = new Group()
{
    Capacity = 5,
    Teacher = new() { Age = 20, Name = "Elvin", Surname = "Azimov", Salary = Int32.MaxValue },
    Students = new()
    {
        new("Omar", "Xayyam", 20),
        new("Medina", "Abbasova", 19),
        new("Shems", "Ismayilova", 18),
        new("Fidan", "Axundbeyli", 19),
        new("Akber", "Sharifov", 18)
    }
};


try
{
    group.AddStudent(new("Maksimus", "Prime", 15));
}
catch (StudentException ex)
{
    string name_of_error = "2022:21:09";
    using (FileStream fs = new("error.log", FileMode.OpenOrCreate))
    {
        byte[] buffer = Encoding.Default.GetBytes(name_of_error + ex.Message);
        await fs.WriteAsync(buffer, 0, buffer.Length);
        Console.WriteLine("error in file...");
    }
}



#endregion