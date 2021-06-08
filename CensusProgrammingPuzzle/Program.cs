using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CensusProblem
{

	class Program
	{

		int[] populations = { 18897109, 12828837, 9461105, 6371773, 5965343,
								5946800, 5582170, 5564635, 5268860, 4552402,
								4335391, 4296250, 4224851, 4192887, 3439809,
								3279833, 3095313, 2812896, 2783243, 2710489,
								2543482, 2356285, 2226009, 2149127, 2142508, 2134411 };


		void run()
		{
			var start = DateTime.Now;
			var end = DateTime.Now;
			int i = 0b10_0000_0000_0000_0000_0000_0000;
			int tot = 0;
			var goal = 100000000;
			while (tot != goal || i < Math.Pow(2,26))
			{
				if ((i & 0b1) > 0) { tot += populations[0]; }
				if ((i & 0b10) > 0) { tot += populations[1]; }
				if ((i & 0b100) > 0) { tot += populations[2]; }
				if ((i & 0b1000) > 0) { tot += populations[3]; }
				if ((i & 0b1_0000) > 0) { tot += populations[4]; }
				if ((i & 0b10_0000) > 0) { tot += populations[5]; }
				if ((i & 0b100_0000) > 0) { tot += populations[6]; }
				if ((i & 0b1000_0000) > 0) { tot += populations[7]; }
				if ((i & 0b1_0000_0000) > 0) { tot += populations[8]; }
				if ((i & 0b10_0000_0000) > 0) { tot += populations[9]; }
				if ((i & 0b100_0000_0000) > 0) { tot += populations[10]; }
				if ((i & 0b1000_0000_0000) > 0) { tot += populations[11]; }
				if ((i & 0b1_0000_0000_0000) > 0) { tot += populations[12]; }
				if ((i & 0b10_0000_0000_0000) > 0) { tot += populations[13]; }
				if ((i & 0b100_0000_0000_0000) > 0) { tot += populations[14]; }
				if ((i & 0b1000_0000_0000_0000) > 0) { tot += populations[15]; }
				if ((i & 0b1_0000_0000_0000_0000) > 0) { tot += populations[16]; }
				if ((i & 0b10_0000_0000_0000_0000) > 0) { tot += populations[17]; }
				if ((i & 0b100_0000_0000_0000_0000) > 0) { tot += populations[18]; }
				if ((i & 0b1000_0000_0000_0000_0000) > 0) { tot += populations[19]; }
				if ((i & 0b1_0000_0000_0000_0000_0000) > 0) { tot += populations[20]; }
				if ((i & 0b10_0000_0000_0000_0000_0000) > 0) { tot += populations[21]; }
				if ((i & 0b100_0000_0000_0000_0000_0000) > 0) { tot += populations[22]; }
				if ((i & 0b1000_0000_0000_0000_0000_0000) > 0) { tot += populations[23]; }
				if ((i & 0b1_0000_0000_0000_0000_0000_0000) > 0) { tot += populations[24]; }
				if ((i & 0b10_0000_0000_0000_0000_0000_0000) > 0) { tot += populations[25]; }
				if (tot == goal)
				{
					end = DateTime.Now;
					TimeSpan ts = end - start;
					print(i, ts);
					break;
				}
				else
                {
					tot = 0;
					i++;				
                }
			}
		}

		void print(int i, TimeSpan ts)
		{
			List<int> solution = new List<int>();
			if ((i & 0b1) > 0) { solution.Add(populations[0]); }
			if ((i & 0b10) > 0) { solution.Add(populations[1]); }
			if ((i & 0b100) > 0) { solution.Add(populations[2]); }
			if ((i & 0b1000) > 0) { solution.Add(populations[3]); }
			if ((i & 0b1_0000) > 0) { solution.Add(populations[4]); }
			if ((i & 0b10_0000) > 0) { solution.Add(populations[5]); }
			if ((i & 0b100_0000) > 0) { solution.Add(populations[6]); }
			if ((i & 0b1000_0000) > 0) { solution.Add(populations[7]); }
			if ((i & 0b1_0000_0000) > 0) { solution.Add(populations[8]); }
			if ((i & 0b10_0000_0000) > 0) { solution.Add(populations[9]); }
			if ((i & 0b100_0000_0000) > 0) { solution.Add(populations[10]); }
			if ((i & 0b1000_0000_0000) > 0) { solution.Add(populations[11]); }
			if ((i & 0b1_0000_0000_0000) > 0) { solution.Add(populations[12]); }
			if ((i & 0b10_0000_0000_0000) > 0) { solution.Add(populations[13]); }
			if ((i & 0b100_0000_0000_0000) > 0) { solution.Add(populations[14]); }
			if ((i & 0b1000_0000_0000_0000) > 0) { solution.Add(populations[15]); }
			if ((i & 0b1_0000_0000_0000_0000) > 0) { solution.Add(populations[16]); }
			if ((i & 0b10_0000_0000_0000_0000) > 0) { solution.Add(populations[17]); }
			if ((i & 0b100_0000_0000_0000_0000) > 0) { solution.Add(populations[18]); }
			if ((i & 0b1000_0000_0000_0000_0000) > 0) { solution.Add(populations[19]); }
			if ((i & 0b1_0000_0000_0000_0000_0000) > 0) { solution.Add(populations[20]); }
			if ((i & 0b10_0000_0000_0000_0000_0000) > 0) { solution.Add(populations[21]); }
			if ((i & 0b100_0000_0000_0000_0000_0000) > 0) { solution.Add(populations[22]); }
			if ((i & 0b1000_0000_0000_0000_0000_0000) > 0) { solution.Add(populations[23]); }
			if ((i & 0b1_0000_0000_0000_0000_0000_0000) > 0) { solution.Add(populations[24]); }
			if ((i & 0b10_0000_0000_0000_0000_0000_0000) > 0) { solution.Add(populations[25]); }
			var str = string.Join(", ", solution);
			Console.WriteLine($"In {ts}, the solution is :\n {str}");
			Console.ReadKey();
		}

		static void Main(string[] args)
		{
			(new Program()).run();
		}
	}
}