#region Task - 1
//namespace MethodExample
//{
//	internal class Program
//	{
//		static void Main(string[] args)
//		{

//			int[] array = { 21, 42, 22, 14, 9, 0, 11, 56, 98, 100, -1 };
//            Console.WriteLine("Min element of the array :");
//			Console.WriteLine(Array(array));

//		}
//		public static int Array(int[] array)
//		{
//			int minElement = array[0];
//			for (int i = 0; i < array.Length; i++)
//			{
//				if (array[i] < minElement)
//				{
//					minElement = array[i];
//				}
//			}
//			return minElement;
//		}


//	}
//}

#endregion


namespace MethodExample
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("The area of circle :");
			FindArea(3, 5);
			Console.WriteLine("The area of rectangle :");
			FindArea(10.0, 6.0);//ədədlər double tipinə uyğun şəkildə daxil edilməlidir
			Console.WriteLine("The area of rectangular parallelepiped :");
			FindArea(1, 3, 13);
			Console.WriteLine("The area of ​​the inscribed circle of the triangle");
			FindArea(11, 1, 2, 3);
		}


		public static void FindArea(int p, int r)
		{
			int a = p * r;  //üstlü qüvvət anlayışı keçilmədiyi üçün əlavə dəyişən daxil etdim
			int S = a * r;
			Console.WriteLine(S);

		}

		public static void FindArea(double a, double b)
		{
			double S = a * b;
			Console.WriteLine(S);
		}

		public static void FindArea(int a, int b, int c)
		{
			int S = 2 * (a * b + a * c + b * c);
			Console.WriteLine(S);
		}

		public static void FindArea(double a, double b, double c, double r)
		{
			double p = (a + b + c) / 2;
			double S = p * r;
			Console.WriteLine(S);
		}

	}
}




