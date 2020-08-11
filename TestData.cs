/* DO NOT MODIFY THE CONTENTS OF THIS FILE */

using System;

namespace Marks
{
	public class TestData
	{
		private static string[] names1 = {
			"Alemany Alceste, Arnau",
			"Bonila Bonamusa, Bibiana",
			"Canilla Closa, Carles",
			"Delhort Dalmau, Diana",
			"Espert Eroles, Eduard",
			"Fonoll Famia, Fatima",
			"Gomis Galet, Gerard",
			"Herrera Huertas, Helena",
			"Iglesia Ibarra, Ignasi",
			"Juarez Jurado, Judit"
		};


		private static string[] names2 = {
			"Alos Arenes, Anna",
			"Bertran Ballo, Bernat",
			"Comas Cano, Cristina",
			"Deulofeu Dones, Didac",
			"Espriu Egea, Emilia",
			"Font Fuster, Ferran",
			"Gallego Gomis, Gina",
			"Herrera Huertas, Hector",
			"Illana Ingles, Irina",
		};

		private static string[] names3 = {
			"Lemos Ledesma, Lluc ",
			"Mollo Merodio, Marta",
			"Nafria Nonell, Norbert",
			"Peris Perlasca, Pamela",
			"Quintana Quiroga, Quirze",
		};

		private static string[] subjects1 = {
			"Algebra",
			"Calculus",
			"Programming",
			"Physics",
			"Computers"
		};

		private static string[] subjects2 = {
			"Algebra",
			"Calculus",
			"Programming",
			"Physics",
			"Computers",
			"Chemistry "
		};

		private static string[] subjects3 = {
			"Statistics",
			"Databases",
			"English",
		};

		private static double[,] marks1 = {
			{ 4,  3,  2,  1,  3.5 },
			{ 5.5, 4, 6, 6, 8 },
			{ 3,  6, 5, 5.5, 3 },
			{ 8, 7.5, 9, 9.5, 9 },
			{ 7, 5.5, 5, 8, 8.9 },
			{ 6.3, 2,  3.5, 7, 5.5 },
			{ 2, 7, 3, 5, 4 },
			{ 1.5, 4, 6, 6, 8 },
			{ 6, 3, 6, 7, 5 },
			{ 5, 7, 7, 5.5, 8 }
		};

		private static double[,] marks2 = {
			{ 5, 6.5, 7, 8, 9.5, 3 },
			{ 2, 1.5, 4, 5, 6, 7 },
			{ 4.5, 2, 2.5, 6, 1, 5 },
			{ 6, 6, 6, 7, 4, 7 },
			{ 3, 5, 8, 8, 2, 7 },
			{ 9, 9.5, 8, 8, 10, 9.5 },
			{ 7, 6, 5, 4, 1.5, 2 },
			{ 3, 9.5, 8, 7, 6.5, 5 },
			{ 4, 4, 3, 6, 8, 8 }
		};

		private static double[,] marks3 = {
			{ 3, 7.5, 4.5},
			{ 8, 6, 4},
			{ 1, 5, 3},
			{ 3, 7, 2},
			{ 9, 8.5, 3.5},
		};

		public TestData ()
		{
			
		}

		public static void FillData (int group, out string [] students, out string  [] subjects, out double [,] marks) {
			switch (group) {
			case 1: 
				students = names1;
				subjects = subjects1;
				marks = marks1;
				break;
			case 2:
				students = names2;
				subjects = subjects2;
				marks = marks2;
				break;
			case 3:
			default:
				students = names3;
				subjects = subjects3;
				marks = marks3;
				break;
			}
		}

	}
}

