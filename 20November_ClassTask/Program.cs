using Domain.Models;
using Service.Controllers;
using Service.Service;


#region Practice


//int[] arr = { 1, 2, 3, 4, 5 };

//for (int i = 0; i < arr.Length; i++)
//{
//    Console.WriteLine(arr[i]);
//}
//try
//{
//    Console.WriteLine(arr[7]);
//}
//catch (IndexOutOfRangeException e)
//{
//    Console.WriteLine("An Exception has occurred : {0}", e.Message);
//}



//////////////////////////////////////////////////////////////////


//int[] arr1 = { 19, 0, 75, 52 };

//try
//{
//    for (int i = 0; i < arr1.Length; i++)
//    {
//        Console.WriteLine(arr1[i] / arr1[i + 1]);
//    }
//}
//catch (IndexOutOfRangeException e)
//{
//    Console.WriteLine("An Exception has occurred : {0}", e.Message);
//}
//catch (DivideByZeroException e)
//{
//    Console.WriteLine("An Exception has occurred : {0}", e.Message);
//}
//catch (ArgumentOutOfRangeException e)
//{
//    Console.WriteLine("An Exception has occurred : {0}", e.Message);
//}
//finally
//{
//    for (int i = 0; i < arr1.Length; i++)
//    {
//        Console.Write(" {0}", arr1[i]);
//    }
//}



/////////////////////////////////////////////////////////













//class DivByZero : Exception
//{

//    public DivByZero()
//    {
//        Console.Write("Exception has occurred : ");
//    }
//}

//class Program1
//{

//    public double DivisionOperation(double numerator,
//                                double denominator)
//    {

//        if (denominator == 0)
//            throw new DivByZero();

//        return numerator / denominator;
//    }

//    static void Main(string[] args)
//    {
//        Program1 obj = new Program1();
//        double num = 9, den = 0, quotient;
//        try
//        {

//            quotient = obj.DivisionOperation(num, den);
//            Console.WriteLine("Quotient = {0}", quotient);
//        }
//        catch (Exception e)
//        {

//            Console.Write(e.Message);
//        }
//    }
//}




#endregion









#region LibraryTask

//LibraryController.GetAllData();

//var result = LibraryController.GetAllBooksByLibrary(m => m.LibraryId == 1);

//foreach (var item in result)
//{
//    Console.WriteLine(item.Name + " " + item.Author);
//}
#endregion


//bool isParse = true;

//try
//{
//    //string name = null;
//    //Console.WriteLine(name.ToString());

//    int index = int.Parse(Console.ReadLine());

//    int[] arr = new int[2];

//    arr[0] = 5;

//    throw new Exception("MMSAMDKMSAKDNKSLANK");

//    isParse = true;

//    Console.WriteLine(arr[index]);
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//    Console.WriteLine("Zehmet olmasa duzgun daxil edin");
//    isParse = false;
//}
//finally
//{
//    if (isParse)
//    {
//        Console.WriteLine("Welcome");
//    }
//    else
//    {
//        Console.WriteLine("Failed");
//    }
//}


//GetNameById(null);

//static void GetNameById(int? id)
//{
//	try
//	{
//		if (id == null)
//		{
//			throw new ArgumentNullException();
//		}

//		Console.WriteLine("Name id :" + id);
//	}
//	catch (Exception ex)
//	{
//		Console.WriteLine(ex.Message);
//	}
//}











//UserController.Register();
//UserController.GetUserById();


#region Task3

//FactorialController.GetFactorial();


#endregion


#region Task4
//LoginController.LoginValidation();
#endregion





