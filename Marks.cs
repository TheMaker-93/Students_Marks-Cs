using System;


namespace Marks
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string[] students;
			string[] subjects;
			double[,] marks;

			int group;
			int NUMBER_OF_GROUPS = 3;

			Console.WriteLine ("MARKS PROCESSING");
			Console.WriteLine ("----------------");
			Console.WriteLine ();

			group = ReadGroupNumber (NUMBER_OF_GROUPS);
			TestData.FillData (group, out students, out subjects, out marks);

			// ---
			Console.WriteLine();

			/* COMPLETE FROM THIS POINT */

			// STUDENT AVERAGES
			Console.WriteLine("AVERAGE MARK PER STUDENT ");
			Console.WriteLine("------- ---- --- ------- ");
			ShowStudentAverage(students, marks);
			Console.WriteLine();

			// BEST AND WORST STUDENTS
			Console.WriteLine("BEST AND WORST STUDENTS");
			Console.WriteLine("---- --- ----- --------");
			ShowBestAndWorstStudents(students, marks);
			Console.WriteLine();
			// TODO

			// PASs COUNT PER SUBJECT
			Console.WriteLine("PASS COUNT PER SUBJECT");
			Console.WriteLine("---- ----- --- -------");
			ShowPassCount(subjects, marks);
			Console.WriteLine();

			Console.Write ("\n\n\nPress any key to exit");
			Console.ReadKey ();

		}


		static int ReadGroupNumber(int ng) {
			/* COMPLETE */

			bool onRange = false;

			while (onRange == false)
			{
				
				Console.Write("Enter the number of the group to has to be processed (1-3): ");
				Console.ForegroundColor = ConsoleColor.Yellow;
				ng = Convert.ToInt32(Console.ReadLine());
				Console.ResetColor();

				if (ng < 1 || ng > 3)
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("\tIncorrect value, it must be between 1 and 3");
					Console.ResetColor();
				}
				else {
					onRange = !onRange;
				}


			}

			return ng;
		} 

		static double StudentAverage (double [,]m, int student) {
			// calculate the average of the student
			/* COMPLETE */

			double resoult = 0f;

			for (int coll = 0; coll < m.GetLength(1); coll++)
			{
				resoult += m[student, coll];
			}

			// Calculate the average
			resoult = resoult / m.GetLength(1);

			return resoult;
		}

		// Show student averege
		static void ShowStudentAverage (string [] students, double[,] marks) {
			// for each student show student average
			/* COMPLETE */

			// we must work with the rows, so the row is the value to be changed, be quiet Dani, it is easyer than it seems
			for (int row = 0; row < marks.GetLength(0); row++)
			{
				Console.Write("\t" + students[row] + " ");
				// color grading
				if (StudentAverage(marks, row) < 5)
				{
					Console.ForegroundColor = ConsoleColor.Red;
				}
				else {
					Console.ForegroundColor = ConsoleColor.Green;
				}
				Console.WriteLine(StudentAverage(marks, row));
				Console.ResetColor();
			}
		}

		static void BestAverageStudent (double [,]m, out int student, out double average) {
			// find the student with the best average 
			/* COMPLETE */
			// 	todo GOOD?		REFINE THAT DANI, IT COULD BE BETTER... or not?

			average = 0f;           // OUT average
			student = 0;            // OUT student

			double lastAverage = 0f;		// prevous average
			int bestAveragedStudent = 0;    // best student at this moment
			double bestAverage = 0f;


			// Process each one of the students for his average
			for ( student = 0; student < m.GetLength(0); student++)
			{	
				// if his average is better than the one of the previous student...
				if (StudentAverage(m, student) >= lastAverage)
				{
					average = StudentAverage(m, student);	// process the average of the current student
					bestAveragedStudent = student;          // save his id to the variable best averaged student
					bestAverage = average;

					// we duplicate the value of average on the lastAverage for the porpose of comparing later
					lastAverage = average;

				}
			}

			// asign the correct values to the out variables
			student = bestAveragedStudent;                  // the student with the BEST average will OUT this functuion
			average = bestAverage;							// His average will be the OUT 

		}

		static void WorstAverageStudent (double [,]m, out int student, out double average) {
			// find the student with the worst average 
			/* COMPLETE */

			average = 0f;           // OUT average
			student = 0;            // OUT student

			double lastAverage = 0f;        // previous average
			int worstAveragedStudent = 0;    // best student at this moment
			double worstAverage = 0f;

			lastAverage = StudentAverage(m, student);       // for making able the if condition to make a comparaison that makes sense (dificult to have an equal or worst average than 0)
			worstAverage = lastAverage;						

			// Process each one of the students for his average
			for (student = 1; student < m.GetLength(0); student++)
			{
				// if his average is WORST than the one of the previous student...
				if (StudentAverage(m, student) <= lastAverage)
				{
					average = StudentAverage(m, student);   // process the average of the current student
					worstAveragedStudent = student;         // save his id to the variable best averaged student
					worstAverage = average;

					// we duplicate the value of average on the lastAverage for the porpose of comparing later
					lastAverage = average;
				}
			}

			// asign the correct values to the out variables
			student = worstAveragedStudent;                  // the student with the WORST average will OUT this functuion
			average = worstAverage;				           	// His average will be the OUT

		}

		// show best and worst student
		static void ShowBestAndWorstStudents(string[] students, double[,] marks)
		{
			// show best and worst students (with their averages)

			/* TODO COMPLETE */
			// HAZ UN FOR

			int student;            // it will contain the student id
			double average;

			// best student
			BestAverageStudent(marks, out student, out average);        // execute the function so student and average now have a value
			Console.Write("\t" + students[student] + " ");     // write the name of the student

			if (average < 5)
			{
				Console.ForegroundColor = ConsoleColor.Red;
			}
			else {
				Console.ForegroundColor = ConsoleColor.Green;
			}
			Console.WriteLine(average);          // and also his average

			Console.ResetColor();

			// worst student
			WorstAverageStudent(marks, out student, out average);
			Console.Write("\t" + students[student] + " ");

			if (average < 5)
			{
				Console.ForegroundColor = ConsoleColor.Red;
			}
			else {
				Console.ForegroundColor = ConsoleColor.Green;
			}
			Console.WriteLine(average);

			Console.ResetColor();
		}


		static int SubjectCountEqualOrGreater(double [,] m, int subject, int value) {
			// count how many students have a mark higher than value in subject
			/* COMPLETE */

			// the subject value is basically the collumn value
			int amount = 0;

			for (int row = 0; row < m.GetLength(0); row++)
			{
				if (m[row, subject] >= value)
				{
					amount++;
				}
			}

			return amount;		// the amount of students with the same or higger grade than the value sent to this procedure
		}

		static void ShowPassCount (string [] subjects, double [,] marks) {
			// show how many students pass each subject
			/* COMPLETE */

			// for each iteration on the collumn...
			for (int coll = 0; coll < marks.GetLength(1); coll++)
			{
				Console.Write("\t" + subjects[coll] + " ");
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.WriteLine(SubjectCountEqualOrGreater(marks,coll,5));
				Console.ResetColor();
			}

		}

	}
}
